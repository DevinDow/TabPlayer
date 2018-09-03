using System;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public abstract class PlayableItem
	{
		// Public Fields
		public int Beat; // in 1/16 notes
		public int Duration; // in 1/16 notes


		// Constructor
		public PlayableItem(int beat, int duration)
		{
			Beat = beat;
			Duration = duration;
		}


		// Implementaion
		public abstract void Play();
	}
}
