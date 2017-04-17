// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Extension3.ViewModels.Extension3;
using Microsoft.AspNetCore.Mvc;

namespace Extension3.Controllers
{
  public class Extension3Controller : Controller
  {
    public ActionResult Index()
    {
      return this.View(new IndexViewModelFactory().Create());
    }
  }
}