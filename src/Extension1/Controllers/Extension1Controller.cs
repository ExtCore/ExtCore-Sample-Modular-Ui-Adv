// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Extension1.ViewModels.Extension1;
using Microsoft.AspNetCore.Mvc;

namespace Extension1.Controllers
{
  public class Extension1Controller : Controller
  {
    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create());
    }
  }
}