// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Infrastructure;

namespace Extension1
{
  public class ExtensionMetadata : IExtensionMetadata
  {
    public IEnumerable<StyleSheet> StyleSheets => new StyleSheet[] { };

    public IEnumerable<Script> Scripts => new Script[] { };

    public IEnumerable<MenuItem> MenuItems
    {
      get
      {
        return new MenuItem[]
        {
          new MenuItem("/extension1", "Extension 1", 100)
        };
      }
    }
  }
}