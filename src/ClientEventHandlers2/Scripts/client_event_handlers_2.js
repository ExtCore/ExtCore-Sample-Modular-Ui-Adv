// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

(function (application) {
  application.registerEventHandler(
    {
      eventName: "click",
      tagName: "button",
      action: function () {
        $.post(
          "/data/save",
          function (result) {
          }
        );
      }
    }
  );
})(window.application = window.application || {});