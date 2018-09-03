using System;
using System.IO;
using System.Xml;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TabPlayer
{
	public class Song
	{
		public ArrayList Measures = new ArrayList();

		public void Play()
		{
			foreach (Measure measure in Measures)
				measure.Play();
		}

		public static Song ReadSong(string filename)
		{
			XmlTextReader reader = new XmlTextReader(filename);

			return new Song();
		}
	}
}
