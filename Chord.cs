using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Chord : PlayableItem
	{
		// Public Fields
		public ArrayList Notes = new ArrayList();
		
		
		// Constructor
		public Chord(int beat, int duration)
			: base(beat, duration)
		{
		}


		// Implementaion
		public void AddNote(int String, int fret)
		{
			Notes.Add(new Note(0, String, fret, 0));
		}

		public override void Play()
		{
            int count = 0;
			while (count < Duration * 250)
				for (int j=0; j<Notes.Count; j++)
				{
					Note subNote = (Note)Notes[j];
					Console.Beep(subNote.Frequency, 15);
                    count += 15;
				}
			/*Note rootNote = (Note)Notes[0];
			int rootDuration = 250;
			int repeat = 5;
			int subDuration = (((Duration * 250) - 250) / (Notes.Count-1)) / repeat;

			Console.Beep(rootNote.Frequency, rootDuration);
			for (int i = 1; i <= repeat; i++)
				for (int j=1; j<Notes.Count; j++)
				{
					Note subNote = (Note)Notes[j];
					Console.Beep(subNote.Frequency, subDuration);
				}*/
		}
	}
}
