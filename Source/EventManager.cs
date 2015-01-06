
/*
 * Author : Samuel "MrOverkill" Meyers
 * Last Modified : 01/05/2015
 * License : Simplified BSD
 * 
 * Description:
 * 	The global manager for events.
 */

using System;
using System.Collections.Generic;

namespace EventSharp
{
	public class EventManager
	{
		private static List<EventHandler> handlers;

		private static void EnsureHandlers()
		{
			if (handlers == null) {
				handlers = new List<EventHandler> ();
			}
		}

		public static void AddHandler(EventHandler evthnd)
		{
			EnsureHandlers ();

			if (evthnd != null) {
				handlers += evthnd;
			}
		}

		public static void RaiseEvent(Event evt)
		{
			EnsureHandlers ();

			if (evt == null) {
				return;
			}

			foreach (EventHandler handler in handlers) {
				handler.OnEvent (evt);
			}
		}
	}
}

