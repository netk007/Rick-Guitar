using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitars
{
	public class Mandolin : Instrument
	{
		public MandolinSpecs MandolinSpecs { get; set; }

		public Mandolin(string serialNumber, double price, MandolinSpecs mandolinSpecs) : base(serialNumber, price, mandolinSpecs)
		{
		}
	}
}
