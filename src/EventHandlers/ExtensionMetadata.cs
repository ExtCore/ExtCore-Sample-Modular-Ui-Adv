// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Infrastructure;

namespace EventHandlers
{
  public class ExtensionMetadata : IExtensionMetadata
  {
    public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

    public IEnumerable<Script> Scripts
    {
      get
      {
        return new Script[]
        {
          new Script("Scripts.event_handlers.js", 300)
        };
      }
    }

    public IEnumerable<MenuItem> MenuItems => new MenuItem[] { };
  }
}