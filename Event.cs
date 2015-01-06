
/*
 * Author : Samuel "MrOverkill" Meyers
 * Last Modified : 01/05/2015
 * License : Simplified BSD
 * 
 * Description:
 * 	Basic structure for an event.
 */

namespace EventSharp
{
	public class Event
	{
		public string Name;

		public Event (string Name)
		{
			this.Name = Name;
		}
	}
}

