// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

(function (application) {
  application.registerEventHandler(
    {
      eventName: "change",
      tagName: "input",
      action: function (element) {
        alert("New value: " + $(element).val());
      }
    }
  );

  application.registerEventHandler(
    {
      eventName: "click",
      tagName: "button",
      action: function () {
        alert("Clicked!");
      }
    }
  );
})(window.application = window.application || {});