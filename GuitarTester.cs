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

			GuitarSpecs WhatErinLikes = new GuitarSpecs("Typical", Type.ACOUSTIC, Builder.FENDER,Wood.COCOBOLO,Wood.BRAZILIAN_ROSEWOOOD);

			List<Guitar> matchedGuitars = inventory.SearchGuitar(WhatErinLikes);

			if (matchedGuitars.Count > 0) {
				Console.WriteLine("You may like these...\n");
				int count = 1;
				foreach (Guitar guitar in matchedGuitars) {
					Console.WriteLine(count + ".\n"
						+ "Type: " + guitar.GuitarSpecs.Type + "\n"
						+ "Model: " + guitar.GuitarSpecs.Model + "\n"
						+ "Builder: " + guitar.GuitarSpecs.Builder + "\n"
						+ "Top Wood: " + guitar.GuitarSpecs.TopWood + "\n"
						+ "Back Wood: " + guitar.GuitarSpecs.BackWood + "\n"
						+ "Price: " + guitar.GetPrice() + "\n\n"
						) ;
					count++;
				}
			}
			else {
				Console.WriteLine("Sorry Erin...We have nothing for you.");
			}

			Console.ReadKey();
			
		}

		public static void InitializeInventory(Inventory inventory) {
			inventory.AddGuitar(new Guitar("ABC123", 2500.00, new GuitarSpecs("Typical", Type.ACOUSTIC, Builder.FENDER, Wood.COCOBOLO, Wood.BRAZILIAN_ROSEWOOOD)));
			inventory.AddGuitar(new Guitar("ABC124", 2500.00, new GuitarSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO)));
			inventory.AddGuitar(new Guitar("ABC125", 3500.00, new GuitarSpecs("Custom", Type.ACOUSTIC, Builder.FENDER, Wood.CEDAR, Wood.COCOBOLO)));
		}
	}
}
