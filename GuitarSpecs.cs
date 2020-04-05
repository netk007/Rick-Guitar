using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitars
{
	public class GuitarSpecs : InstrumentSpecs {

		public int NumberOfString { get; set; }

		public GuitarSpecs(string model, Type type, Builder builder, Wood backWood, Wood topWood, int numOfString) : base(model, type, builder, backWood, topWood) {
			NumberOfString = numOfString;
		}

		public new bool MatchSpecs(InstrumentSpecs instrumentSpecs) {
			if (!base.MatchSpecs(instrumentSpecs)) {
				return false;
			}

			if (instrumentSpecs is GuitarSpecs)
			{
				GuitarSpecs guitarSpecs = (GuitarSpecs)instrumentSpecs;
				if (!(guitarSpecs.NumberOfString == NumberOfString))
				{
					return false;
				}

			}
			else
				return false;

			return true;
		}
	}
}
