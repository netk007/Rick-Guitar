using System.Collections.Generic;

namespace RickGuitars
{
	public class Inventory
	{
		List<Guitar> guitars;
		public Inventory() {
			guitars = new List<Guitar>();
		}

		public void AddGuitar(Guitar guitar) {
			guitars.Add(guitar);
		}

		public List<Guitar> SearchGuitar(GuitarSpecs guitarSpecs) {
			List<Guitar> matchedGuitars = new List<Guitar>();
			foreach (Guitar guitar in guitars) {
				if (guitar.GuitarSpecs.MatchSpecs(guitarSpecs))
					matchedGuitars.Add(guitar);
			}
			return matchedGuitars;
		}
	}
}
