using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TabPlayer
{
	public partial class Form1 : Form
	{
		// Public Fields
		public Song Song;


		// Constructors
		public Form1()
		{
			InitializeComponent();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			OpenFileDialog dlg = new OpenFileDialog();
			if (dlg.ShowDialog() == DialogResult.OK)
				Song = Song.ReadSong(dlg.FileName);
		}

		private void btnPlay_Click(object sender, EventArgs e)
		{
			if (Song != null)
				Song.Play();
		}

		private void btnWishYouWereHere_Click(object sender, EventArgs e)
		{
			Song = new Song();
			Measure measure = new Measure();
			Song.Measures.Add(measure);
			Chord chord = new Chord(0, 4);
			chord.AddNote(0, 3);
			chord.AddNote(1, 2);
			chord.AddNote(2, 0);
			measure.Notes.Add(chord);
            return;

			measure = new Measure();
			Song.Measures.Add(measure);
			measure.Notes.Add(new Note(0, 0, 3, 2));
			measure.Notes.Add(new Note(0, 1, 0, 1));
			measure.Notes.Add(new Note(0, 1, 2, 1));
			measure.Notes.Add(new Note(0, 2, 0, 2));
			measure.Notes.Add(new Note(0, 2, 2, 2));

			measure = new Measure();
			Song.Measures.Add(measure);
			measure.Notes.Add(new Rest(0, 4));

			measure = new Measure();
			Song.Measures.Add(measure);
			measure.Notes.Add(new Note(0, 2, 2, 1));
			measure.Notes.Add(new Note(0, 3, 0, 2));
			measure.Notes.Add(new Note(0, 2, 2, 2));
			measure.Notes.Add(new Note(0, 2, 0, 2));
		}
	}
}