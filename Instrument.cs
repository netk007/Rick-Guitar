namespace RickGuitars
{
	public abstract class Instrument
	{
		public InstrumentSpecs specs;
		public string SerialNumber { get; set; }
		public double Price { get; set; }

		public Instrument(string serialNumber, double price, InstrumentSpecs instrumentspecs) {
			SerialNumber = serialNumber;
			Price = price;
			specs = instrumentspecs;
		}
	}
}
