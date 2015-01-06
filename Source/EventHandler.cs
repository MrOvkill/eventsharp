
/*
 * Author : Samuel "MrOverkill" Meyers
 * Last Modified : 01/05/2015
 * License : Simplified BSD
 * 
 * Description:
 * 	Basic structure for an event handler.
 */

using System;

namespace EventSharp
{
	public class EventHandler
	{
		public virtual bool OnEvent(Event evt)
		{
			return true;
		}
	}
}

