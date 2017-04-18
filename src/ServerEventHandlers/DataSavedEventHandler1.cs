// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using ServerEvents;

namespace ServerEventHandlers
{
  public class SomeActionEventHandler1 : IDataSavedEventHandler
  {
    public int Priority { get { return 1000; } }

    public void HandleEvent(string argument)
    {
      // You can write your code to handle the event here
    }
  }
}