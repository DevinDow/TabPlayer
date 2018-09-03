using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Measure
	{
		public ArrayList Notes = new ArrayList();

		public void Play()
		{
			foreach (PlayableItem note in Notes)
				note.Play();
		}
	}
}
