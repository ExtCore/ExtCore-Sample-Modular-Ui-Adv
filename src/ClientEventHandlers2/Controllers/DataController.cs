// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using ExtCore.Events;
using Microsoft.AspNetCore.Mvc;
using ServerEvents;

namespace ClientEventHandlers2.Controllers
{
  public class DataController : Controller
  {
    [HttpPost]
    public ActionResult Save()
    {
      Event<IDataSavedEventHandler, string>.Broadcast("Data saved at " + DateTime.Now.ToString() + "!");
      return this.Content("Ok");
    }
  }
}