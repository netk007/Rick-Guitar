namespace RickGuitars
{
	public class MandolinSpecs : InstrumentSpecs
	{
		public Style Style { get; set; }
		public MandolinSpecs(string model, Type type, Builder builder, Wood backWood, Wood topWood, Style style) : base(model, type, builder, backWood, topWood)
		{
			Style = style;
		}

		public new bool MatchSpecs(InstrumentSpecs instrumentSpecs)
		{
			if (!base.MatchSpecs(instrumentSpecs))
			{
				return false;
			}

			if (instrumentSpecs is MandolinSpecs)
			{
				MandolinSpecs mandolinSpecs = (MandolinSpecs)instrumentSpecs;
				if (!(mandolinSpecs.Style == Style))
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
