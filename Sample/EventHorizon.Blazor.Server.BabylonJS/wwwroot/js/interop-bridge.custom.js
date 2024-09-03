(function () {
  const refCache = [];
  const argumentCache = new Map();
  const methodCache = new Map();
  window["DEBUGGING_CONSOLE"] = {
    ...window["DEBUGGING_CONSOLE"],
    refCache,
    argumentCache,
    methodCache,
  };
  const CHARS =
    "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".split("");
  const guid = () => {
    var chars = CHARS,
      uuid = new Array(36),
      rnd = 0,
      r;
    for (var i = 0; i < 36; i++) {
      if (i === 8 || i === 13 || i === 18 || i === 23) {
        uuid[i] = "-";
      } else if (i === 14) {
        uuid[i] = "4";
      } else {
        if (rnd <= 0x02) {
          rnd = (0x2000000 + Math.random() * 0x1000000) | 0;
        }
        r = rnd & 0xf;
        rnd = rnd >> 4;
        uuid[i] = chars[i === 19 ? (r & 0x3) | 0x8 : r];
      }
    }
    return uuid.join("");
  };
  /**
   * Cache the passed in arg.
   * Returns null if not defined.
   * Returns cacheKey only if already cached.
   * @param {any} arg object to validate/cache.
   */
  const cacheEntity = (arg) => {
    if (!arg) {
      return null;
    }
    if (arg[cacheKey]) {
      return { [cacheKey]: arg[cacheKey] };
    }
    const newCacheKey = guid();
    arg[cacheKey] = newCacheKey;
    argumentCache.set(newCacheKey, arg);
    return { [cacheKey]: newCacheKey };
  };
  /**
   * Check argument for existing in argumentCache and if actionResultCallbackType and if actionCallbackType.
   * Returns argValue if not part argumentCache or actionCallbackType.
   *
   * @param {any} argValue
   */
  const convertArg = (argValue) => {
    if (!argValue == null || argValue == undefined) {
      return undefined;
    }
    if (argValue[cacheKey] && argumentCache.has(argValue[cacheKey])) {
      return argumentCache.get(argValue[cacheKey]);
    } else if (
      argValue[typeKey] &&
      argValue[typeKey] === actionResultCallbackType
    ) {
      const invokableReference = argValue["invokableReference"];
      const method = argValue["method"];
      return async function () {
        var result = await invokableReference.invokeMethodAsync(
          method,
          ...convertCallbackArguments(arguments)
        );
        return !!result.result ? result.result : result;
      };
    } else if (argValue[typeKey] && argValue[typeKey] === actionCallbackType) {
      const invokableReference = argValue["invokableReference"];
      const method = argValue["method"];
      return async function () {
        await invokableReference.invokeMethodAsync(
          method,
          ...convertCallbackArguments(arguments)
        );
      };
    }
    return argValue;
  };
  /**
   * Loop through all the argumentArray items and convert the args to usable references.
   *
   * @param {any} argumentArray
   */
  const convertArgs = (argumentArray) => {
    const args = [];
    for (var i = 1; i < argumentArray.length; i++) {
      const arg = convertArg(argumentArray[i]);

      if (
        arg &&
        typeof arg === "object" &&
        !arg[cacheKey] &&
        !Array.isArray(arg)
      ) {
        // Object literal: { prop: "hi", prop2: { ___type: "action_callback" } }
        const newArg = {};
        for (const key in arg) {
          if (Object.prototype.hasOwnProperty.call(arg, key)) {
            const element = arg[key];
            newArg[key] = convertArg(element);
          }
        }
        args.push(newArg);
      } else {
        args.push(arg);
      }
    }
    return args;
  };
  /**
   * Create a serialization safe set of arguments.
   * Taking into account arrays and objects
   * @param {any} callbackArguments array of arguments to sanitize.
   */
  const convertCallbackArguments = (callbackArguments) => {
    const args = [];
    for (var arg of callbackArguments) {
      if (typeof arg === "object" && !Array.isArray(arg)) {
        args.push(cacheEntity(arg));
      } else if (Array.isArray(arg)) {
        args.push(arg.map(cacheEntity));
      } else {
        args.push(arg);
      }
    }
    return args;
  };
  /**
   * toString a number so it can be parsed by .NET.
   * @param {any} num
   */
  const numberToString = (num) => {
    let numStr = String(num);

    if (Math.abs(num) < 1.0) {
      let e = parseInt(num.toString().split("e-")[1]);
      if (e) {
        let negative = num < 0;
        if (negative) num *= -1;
        num *= Math.pow(10, e - 1);
        numStr = "0." + new Array(e).join("0") + num.toString().substring(2);
        if (negative) numStr = "-" + numStr;
      }
    } else {
      let e = parseInt(num.toString().split("+")[1]);
      if (e > 20) {
        e -= 20;
        num /= Math.pow(10, e);
        numStr = num.toString() + new Array(e + 1).join("0");
      }
    }

    return numStr;
  };

  const isPromise = (obj) =>
    typeof obj?.then === "function" &&
    typeof obj?.finally === "function" &&
    typeof obj?.catch === "function";

  const cacheKey = "___guid";
  const typeKey = "___type";
  const actionCallbackType = "action_callback";
  const actionResultCallbackType = "action_result_callback";
  window["blazorInterop"] = {
    /**
     * This will call a function on a cached object.
     * @param {any} root Property Name from window or Cached Entity GUID
     * @param {any} identifier Property to get from Root
     */
    get: function (root, identifier) {
      try {
        identifier = identifier.split(".");
        let value = window[root];
        if (argumentCache.has(root)) {
          value = argumentCache.get(root);
        }
        if (!value) {
          return null;
        }
        for (var i = 0; i < identifier.length; i++) {
          value = value[identifier[i]];
        }

        if (typeof value === "number") {
          value = numberToString(value);
        } else if (value == undefined || value == null) {
          return null;
        }

        return value.toString();
      } catch (ex) {
        console.log("error", { ex, root, identifier });
      }
    },
    /**
     * This will call a function on a cached object.
     * @param {any} root Property Name from window or Cached Entity GUID
     * @param {any} identifier Property to get from Root
     **/
    getClass: function (root, identifier) {
      try {
        identifier = identifier.split(".");
        let value = window[root];
        if (argumentCache.has(root)) {
          value = argumentCache.get(root);
        }
        for (var i = 0; i < identifier.length; i++) {
          value = value[identifier[i]];
        }
        if (!value) {
          return null;
        }
        if (!argumentCache.has(value[cacheKey])) {
          // Add to cache
          const newCacheKey = guid();
          value[cacheKey] = newCacheKey;
          argumentCache.set(newCacheKey, value);
        }

        return value[cacheKey];
      } catch (ex) {
        console.log("error", { ex, root, identifier });
      }
    },
    /**
     * This will call a function on a cached object.
     * @param {any} root Property Name from window or Cached Entity GUID
     * @param {any} identifier Property to get from Root
     **/
    getArrayClass: function (root, identifier) {
      try {
        identifier = identifier.split(".");
        let values = window[root];
        if (argumentCache.has(root)) {
          values = argumentCache.get(root);
        }
        for (var i = 0; i < identifier.length; i++) {
          values = values[identifier[i]];
        }
        const result = [];
        for (var value of values) {
          if (!argumentCache.has(value[cacheKey])) {
            // Add to cache
            const newCacheKey = guid();
            value[cacheKey] = newCacheKey;
            argumentCache.set(newCacheKey, value);
          }
          result.push(value[cacheKey]);
        }

        return result;
      } catch (ex) {
        console.log("error", { ex, args });
        return [];
      }
    },
    /**
     * This will call a function on a cached object.
     * args = Tuple<string, string>
     *  Tuble[0] = Root - Property Name from window or Cached Entity GUID
     *  Tuble[1] = Identitifer - Property to get from Root
     **/
    getArrayClassSlow: function (root, identifier) {
      try {
        identifier = identifier.split(".");
        let values = window[root];
        if (argumentCache.has(root)) {
          values = argumentCache.get(root);
        }
        for (var i = 0; i < identifier.length; i++) {
          values = values[identifier[i]];
        }
        const result = [];
        for (var value of values) {
          if (!argumentCache.has(value[cacheKey])) {
            // Add to cache
            const newCacheKey = guid();
            value[cacheKey] = newCacheKey;
            argumentCache.set(newCacheKey, value);
          }
          result.push(value[cacheKey]);
        }

        return result;
      } catch (ex) {
        console.log("error", { ex, root, identifier });
      }
    },
    /**
     * This will get an array from the identifier on the root.
     * @param root - Property Name from window or Cached Entity GUID
     * @param identifier - Property to get from Root
     **/
    getArraySlow: function (root, identifier) {
      try {
        identifier = identifier.split(".");
        let values = window[root];
        if (argumentCache.has(root)) {
          values = argumentCache.get(root);
        }
        for (var i = 0; i < identifier.length; i++) {
          values = values[identifier[i]];
        }
        return values;
      } catch (ex) {
        console.log("error", { ex, root, identifier });
      }
    },
    /**
     * This will set a the passed in value on the identifier starting at the root.
     *
     * @param root Property Name from window or Cached Entity GUID
     * @param identifier Property to get from Root
     * @param value The value to set at the root.identifier
     **/
    set: function (root, identifier, value) {
      try {
        identifier = identifier.split(".");
        let obj = window[root];
        if (argumentCache.has(root)) {
          obj = argumentCache.get(root);
        }
        for (var i = 0; i < identifier.length - 1; i++) {
          obj = obj[identifier[i]];
        }

        if (argumentCache.has(value[cacheKey])) {
          value = argumentCache.get(value[cacheKey]);
        }

        obj[identifier[identifier.length - 1]] = value;
      } catch (ex) {
        console.log("error", { ex, root, identifier, value });
      }
    },
    /**
     * This will call a function on a cached object.
     * arguments[0] = Cached Entity
     * arguments[1] = property key
     * arguments[2...n] = as args to property key
     **/
    call: function () {
      try {
        var cachedObj = arguments[0];
        var prop = arguments[1];
        var args = [];
        for (var i = 2; i < arguments.length; i++) {
          var arg = arguments[i];
          if (arg && arg[cacheKey] && argumentCache.has(arg[cacheKey])) {
            args.push(argumentCache.get(arg[cacheKey]));
          } else {
            args.push(arg);
          }
        }

        if (argumentCache.has(cachedObj[cacheKey])) {
          var cachedObj = argumentCache.get(cachedObj[cacheKey]);
          if (cachedObj[prop]) {
            cachedObj[prop](...args);
          }
        }
      } catch (ex) {
        console.log("error", { ex, arguments });
        throw { message: "invalid_call", code: "invalid_call" };
      }
    },
    /**
     * This will "new" the passed in identifier.
     * arguments[0] = Identifier
     * arguments[1...n] = Contructor Arguments
     **/
    new: function () {
      try {
        var identifier = arguments[0];
        var createNew = window[identifier[0]];
        var args = convertArgs(arguments);
        for (var i = 1; i < identifier.length; i++) {
          createNew = createNew[identifier[i]];
        }
        var newObject = new createNew(...args);
        newObject[cacheKey] = guid();
        argumentCache.set(newObject[cacheKey], newObject);
        return {
          [cacheKey]: newObject[cacheKey],
        };
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      throw { code: "invalid_call" };
    },
    /**
     * This will call an identifier a function from window as the root.
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     **/
    func: function () {
      try {
        var identifier = arguments[0];
        var createNew = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          createNew = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = createNew;
          createNew = createNew[identifier[i]];
        }
        return createNew.call(context, ...args);
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return undefined;
    },
    /**
     * This will call a through an identifier's a function from window as the root.
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     **/
    funcClass: async function () {
      try {
        var identifier = arguments[0];
        var instance = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          instance = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = instance;
          instance = instance[identifier[i]];
        }
        var result = instance.call(context, ...args);
        if (isPromise(result)) {
          result = await result;
        }
        let newCacheKey = result[cacheKey];
        if (
          typeof result === "object" &&
          !Array.isArray(result) &&
          !newCacheKey
        ) {
          newCacheKey = guid();
          result[cacheKey] = newCacheKey;
          argumentCache.set(newCacheKey, result);
        }
        return newCacheKey;
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return undefined;
    },
    /**
     * This will call a through an identifier's a function from window as the root.
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     **/
    funcArray: async function () {
      try {
        var identifier = arguments[0];
        var instance = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          instance = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = instance;
          instance = instance[identifier[i]];
        }
        var result = instance.call(context, ...args);
        if (isPromise(result)) {
          result = await result;
        }
        if (Array.isArray(result)) {
          return result;
        }
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return [];
    },
    /**
     * This will call a through an identifier's a function from window as the root.
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     **/
    funcArrayClass: async function () {
      try {
        var identifier = arguments[0];
        var createNew = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          createNew = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = createNew;
          createNew = createNew[identifier[i]];
        }

        var funcResults = createNew.call(context, ...args);
        if (isPromise(funcResults)) {
          funcResults = await funcResults;
        }
        const results = [];
        for (var value of funcResults) {
          if (!argumentCache.has(value[cacheKey])) {
            // Add to cache
            const newCacheKey = guid();
            value[cacheKey] = newCacheKey;
            argumentCache.set(newCacheKey, value);
          }
          results.push(value[cacheKey]);
        }

        return results;
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return [];
    },
    /**
     * This will call a Promise based on the identifier, with the arguments passed.
     *
     * - 'window' is root
     *
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     *
     * @returns primitive
     * */
    task: async function () {
      try {
        var identifier = arguments[0];
        var obj = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          obj = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = obj;
          obj = obj[identifier[i]];
        }
        return await obj.call(context, ...args);
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return undefined;
    },
    /**
     * This will call a Promise based on the identifier, with the arguments passed.
     *
     * - 'window' is root
     *
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     *
     * @returns Class Entity Identifier
     * */
    taskClass: async function () {
      try {
        var identifier = arguments[0];
        var obj = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          obj = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = obj;
          obj = obj[identifier[i]];
        }
        var newObject = await obj.call(context, ...args);
        if (typeof newObject === "object" && !Array.isArray(newObject)) {
          const newCacheKey = guid();
          newObject[cacheKey] = newCacheKey;
          argumentCache.set(newCacheKey, newObject);
          return newCacheKey;
        }
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return undefined;
    },
    /**
     * This will call a Promise based on the identifier, with the arguments passed.
     *
     * - 'window' is root
     *
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     *
     * @returns Array of primitives
     * */
    taskArray: async function () {
      try {
        var identifier = arguments[0];
        var createNew = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          createNew = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = createNew;
          createNew = createNew[identifier[i]];
        }
        var result = await createNew.call(context, ...args);
        if (Array.isArray(result)) {
          return result;
        }
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return [];
    },
    /**
     * This will call a Promise based on the identifier, with the arguments passed.
     *
     * - 'window' is root
     *
     * arguments[0] = Identifier
     * arguments[1...n] = Function Arguments
     *
     * @returns Array of Class Entities
     * */
    taskArrayClass: async function () {
      try {
        var identifier = arguments[0];
        var createNew = window[identifier[0]];
        if (argumentCache.has(identifier[0])) {
          createNew = argumentCache.get(identifier[0]);
        }
        var args = convertArgs(arguments);
        var context = window;
        for (var i = 1; i < identifier.length; i++) {
          context = createNew;
          createNew = createNew[identifier[i]];
        }

        var funcResults = await createNew.call(context, ...args);
        const results = [];
        for (var value of funcResults) {
          if (!argumentCache.has(value[cacheKey])) {
            // Add to cache
            const newCacheKey = guid();
            value[cacheKey] = newCacheKey;
            argumentCache.set(newCacheKey, value);
          }
          results.push(value[cacheKey]);
        }

        return results;
      } catch (ex) {
        console.log("error", { ex, arguments });
      }
      return [];
    },
    /**
     * This will create a new function scoped string with arguments and services passed to it.
     **/
    runScript: (methodRunner) => {
      let script = methodCache.get(methodRunner.methodName);
      if (!script) {
        script = new Function("$services", "$args", methodRunner.script);
        methodCache.set(methodRunner.methodName, script);
      }
      script(
        {
          argumentCache,
        },
        methodRunner.args
      );
    },
    /**
     * This will create a callback function and trigger the args
     **/
    funcCallback: (
      entity,
      funcCallbackName,
      referenceMethod,
      invokableReference
    ) => {
      refCache.push(invokableReference);

      const cachedEntity = argumentCache.get(entity);
      cachedEntity[funcCallbackName](function () {
        invokableReference.invokeMethodAsync(
          referenceMethod,
          ...convertCallbackArguments(arguments)
        );
      });
    },
    /**
     * This will create a callback function and trigger the assembly callback
     **/
    assemblyFuncCallback: (identifier, assemblyName, referenceCallback) => {
      var identifier = identifier.split(".");
      var func = window[identifier[0]];
      for (var i = 1; i < identifier.length; i++) {
        func = func[identifier[i]];
      }

      func(function (/* TODO: Support passing back props */) {
        DotNet.invokeMethodAsync(assemblyName, referenceCallback);
      });
    },
    /**
     * This will create a cachedEntity from the prop on the passed in entity.
     **/
    cacheEntity: (identifier, prop) => {
      const cachedEntity = argumentCache.get(identifier);
      var newObject = cachedEntity[prop];
      newObject[cacheKey] = guid();
      argumentCache.set(newObject[cacheKey], newObject);
      return {
        [cacheKey]: newObject[cacheKey],
      };
    },
  };
})();
