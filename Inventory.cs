using System.Collections.Generic;

namespace RickGuitars
{
	public class Inventory
	{
		List<Instrument> instruments;
		public Inventory() {
			instruments = new List<Instrument>();
		}

		public void AddInstrument(Instrument instrument) {
			instruments.Add(instrument);
		}

		public List<Instrument> SearchInstrument(InstrumentSpecs instrumentSpecs)
		{
			List<Instrument> matchedInstruments = new List<Instrument>();
			foreach (Instrument instrument in instruments)
			{
				if(instrument is Guitar && instrumentSpecs is GuitarSpecs)
				{
					if (((GuitarSpecs)instrument.specs).MatchSpecs((GuitarSpecs)instrumentSpecs)) {
						matchedInstruments.Add(instrument);
					}
				}
				else if(instrument is Mandolin && instrumentSpecs is MandolinSpecs)
				{
					if (((MandolinSpecs)instrument.specs).MatchSpecs((MandolinSpecs)instrumentSpecs))
					{
						matchedInstruments.Add(instrument);
					}
				}
			}
			return matchedInstruments;
		}
	}
	}
