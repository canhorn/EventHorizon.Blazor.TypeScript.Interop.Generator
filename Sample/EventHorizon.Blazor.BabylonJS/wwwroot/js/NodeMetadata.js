(function () {
  window.NodeMetadata = function () {
    this.name = undefined;
  };

  window.ClientObject = function (data) {
    for (var key in data) {
      this[key] = data[key];
    }
  };
})();
