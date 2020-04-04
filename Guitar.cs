using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitars
{
	public enum Type {
		ACOUSTIC, ELECTRIC
	}

	public enum Builder {
		FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
	}

	public enum Wood { 
		MAPPLE, INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOOD, MAHOGANY, COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
	}
	public class Guitar
	{
		string SerialNumber { get; set; }
		double Price { get; set; }

		public GuitarSpecs GuitarSpecs;

		public Guitar(string serialNumber, double price, GuitarSpecs guitarSpecs) {
			this.SerialNumber = serialNumber;
			this.Price = price;
			this.GuitarSpecs = guitarSpecs;
		}

		public double GetPrice() {
			return this.Price;
		}

		public string GetSerialNumber()
		{
			return this.SerialNumber;
		}

	}
}
