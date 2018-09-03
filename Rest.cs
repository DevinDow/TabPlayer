using System;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Rest : PlayableItem
	{
		// Constructor
		public Rest(int beat, int duration)	
			: base(beat, duration)
		{
		}


		// Implementaion
		public override void Play()
		{
			System.Threading.Thread.Sleep(Duration * 250);
		}
	}
}
