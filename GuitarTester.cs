using System;
using System.Collections.Generic;

namespace RickGuitars
{
	class GuitarTester
	{
		static void Main(string[] args)
		{
			Inventory inventory = new Inventory();

			InitializeInventory(inventory);

			//InstrumentSpecs WhatErinLikes = new GuitarSpecs("Typical", Type.ACOUSTIC, Builder.FENDER,Wood.COCOBOLO,Wood.BRAZILIAN_ROSEWOOOD, 7);
			InstrumentSpecs WhatErinLikes = new MandolinSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO, Style.F);

			List<Instrument> matchedInstruments = inventory.SearchInstrument(WhatErinLikes);

			if (matchedInstruments.Count > 0) {
				Console.WriteLine("You may like these...\n");
				int count = 1;
				foreach (Instrument instrument in matchedInstruments) {
					if (instrument is Guitar)
					{
						Guitar guitar = (Guitar)instrument;

						Console.WriteLine(count + ".\n"
						+ "Type: " + guitar.specs.Type + "\n"
						+ "Model: " + guitar.specs.Model + "\n"
						+ "Builder: " + guitar.specs.Builder + "\n"
						+ "Top Wood: " + guitar.specs.TopWood + "\n"
						+ "Back Wood: " + guitar.specs.BackWood + "\n"
						+ "Number of String: " + ((GuitarSpecs)guitar.specs).NumberOfString + "\n"
						+ "Price: " + guitar.Price + "\n\n"
						);
					}
					else if (instrument is Mandolin) {
						Mandolin mandolin = (Mandolin)instrument;

						Console.WriteLine(count + ".\n"
						+ "Type: " + mandolin.specs.Type + "\n"
						+ "Model: " + mandolin.specs.Model + "\n"
						+ "Builder: " + mandolin.specs.Builder + "\n"
						+ "Top Wood: " + mandolin.specs.TopWood + "\n"
						+ "Back Wood: " + mandolin.specs.BackWood + "\n"
						+ "Style: " + ((MandolinSpecs)mandolin.specs).Style + "\n"
						+ "Price: " + mandolin.Price + "\n\n"
						);
					}
					count++;
				}
			}
			else {
				Console.WriteLine("Sorry Erin...We have nothing for you.");
			}

			Console.ReadKey();
			
		}

		public static void InitializeInventory(Inventory inventory) {
			inventory.AddInstrument(new Guitar("ABC123", 2500.00, new GuitarSpecs("Typical", Type.ACOUSTIC, Builder.FENDER, Wood.COCOBOLO, Wood.BRAZILIAN_ROSEWOOOD, 8)));
			inventory.AddInstrument(new Guitar("ABC124", 2500.00, new GuitarSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO, 7)));
			inventory.AddInstrument(new Mandolin("ABC125", 3500.00, new MandolinSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO, Style.A)));
			inventory.AddInstrument(new Mandolin("ABC126", 3500.00, new MandolinSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO, Style.F)));
		}
	}
}
