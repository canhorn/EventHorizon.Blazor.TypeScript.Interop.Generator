(function () {

    window.taskClass = async function () {
        try {
            debugger;
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
            if (typeof (newObject) === "object"
                && !Array.isArray(newObject)
            ) {
                const newCacheKey = guid();
                newObject[cacheKey] = newCacheKey;
                argumentCache.set(newCacheKey, newObject);
                return newCacheKey;
            }
        } catch (ex) {
            console.log("error", ex);
        }
        return undefined;
    };

    // =======
    // SUPPLIED BY EventHorizon.Blazor.Interop 
    // DO NOT CHANGE
    // =======
    const cacheKey = "___guid";
    const typeKey = "___type";
    const actionCallbackType = "action_callback";
    const refCache = [];
    const argumentCache = new Map();
    const methodCache = new Map();
    window["DEBUGGING_CONSOLE"] = {
        ...window["DEBUGGING_CONSOLE"],
        refCache,
        argumentCache,
        methodCache,
    };
    const CHARS = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".split("");
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
                if (rnd <= 0x02) { rnd = (0x2000000 + Math.random() * 0x1000000) | 0; }
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
     * Check argument for existing in argumentCache and if actionCallbackType.
     * Returns argValue if not part argumentCache or actionCallbackType.
     * 
     * @param {any} argValue
     */
    const convertArg = (argValue) => {
        if (!argValue) {
            return null;
        }
        if (argValue[cacheKey] && argumentCache.has(argValue[cacheKey])) {
            return argumentCache.get(argValue[cacheKey]);
        } else if (argValue[typeKey] && argValue[typeKey] === actionCallbackType) {
            const invokableReference = argValue["invokableReference"];
            const method = argValue["method"];
            return async function () {
                await invokableReference.invokeMethodAsync(method, ...convertCallbackArguments(arguments));
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

            if (arg && typeof (arg) === "object" && !arg[cacheKey] && !Array.isArray(arg)) {
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
            if (typeof (arg) === "object"
                && !Array.isArray(arg)
            ) {
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
            let e = parseInt(num.toString().split('e-')[1]);
            if (e) {
                let negative = num < 0;
                if (negative) num *= -1
                num *= Math.pow(10, e - 1);
                numStr = '0.' + (new Array(e)).join('0') + num.toString().substring(2);
                if (negative) numStr = "-" + numStr;
            }
        }
        else {
            let e = parseInt(num.toString().split('+')[1]);
            if (e > 20) {
                e -= 20;
                num /= Math.pow(10, e);
                numStr = num.toString() + (new Array(e + 1)).join('0');
            }
        }

        return numStr;
    };
})();