using System;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Note : PlayableItem
	{
		// Public Fields
		public int String;
		public int Fret;
		
		public int Frequency
		{
			get
			{
				Tone musicNote = (Tone)Guitar.LowNote.Clone();
				for (int i = 1; i <= String; i++)
					musicNote.Note += Guitar.Ofsets[i];
				musicNote.Note += Fret;
				while (musicNote.Note > 12)
				{
					musicNote.Note -= 12;
					musicNote.Octave += 1;
				}
				return musicNote.Frequency;
			}
			/*
			C 261.6
		C# 277.2
		D 293.7
		D# 311.1
		E 329.6
		F 349.2
		F# 370.0
		G 392.0
		G# 415.3
		A 440.0
		A# 466.2
		B 493.9
		C 523.2*/

			/*
			Acoustic Guitar  82 to 880 
	Bass Guitar  41 to 300 */
		}


		// Constructor
		public Note(int beat, int String, int fret, int duration) 
			: base(beat, duration)
		{
			this.String = String;
			Fret = fret;
		}


		// Implementaion
		public override void Play()
		{
			Console.Beep(Frequency, Duration * 250);
		}
	}
}
