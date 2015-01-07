
/*
 * Author : Samuel "MrOverkill" Meyers
 * Last Modified : 01/06/2015
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
				handlers.Add(evthnd);
			}
		}

		public static List<EventResult> RaiseEvent(Event evt)
		{
			EnsureHandlers ();

			List<EventResult> results = new List<EventResult> ();

			if (evt == null) {
				return results;
			}

			foreach (EventHandler handler in handlers) {
				results.Add(handler.OnEvent (evt));
			}

			return results;
		}
	}
}

