using System;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Tone : ICloneable
	{
		// Public Fields
		public int Note;
		public int Octave;


		// Public Properties
		public int Frequency { get { return GetFrequency(Note, Octave); } }


		// Constructor
		public Tone(int note, int octave)
		{
			Note = note;
			Octave = octave;
		}


		// Public Static Methods
		public static int GetFrequency(int note, int octave)
		{
			int freq = 0;
			switch (note)
			{
				case 1:
					freq = 262; // C
					break;
				case 2:
					freq = 277; // C#
					break;
				case 3:
					freq = 294; // D 
					break;
				case 4:
					freq = 311; // D#
					break;
				case 5:
					freq = 330; // E
					break;
				case 6:
					freq = 349; // F
					break;
				case 7:
					freq = 370; // F#
					break;
				case 8:
					freq = 392; // G
					break;
				case 9:
					freq = 415; // G#
					break;
				case 10:
					freq = 440; // A
					break;
				case 11:
					freq = 370; // A#
					break;
				case 12:
					freq = 494; // B
					break;
			}

			return (int)Math.Round((Math.Pow(2, octave) * freq));
		}


		// Overrides
		public object Clone()
		{
			return new Tone(Note, Octave);
		}
	}
}
