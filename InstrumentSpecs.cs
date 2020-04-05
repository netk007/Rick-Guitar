namespace RickGuitars
{
	public abstract class InstrumentSpecs
	{
		public string Model { get; set; }
		public Type Type { get; set; }
		public Builder Builder { get; set; }
		public Wood BackWood { get; set; }
		public Wood TopWood { get; set; }

		public InstrumentSpecs(string model, Type type, Builder builder, Wood backWood, Wood topWood) {
			Model = model;
			Type = type;
			Builder = builder;
			BackWood = backWood;
			TopWood = topWood;
		}

		public bool MatchSpecs(InstrumentSpecs specs) {
			if (!this.Model.ToLower().Equals(specs.Model.ToLower()))
				return false;
			if (this.Type != specs.Type)
				return false;
			if (this.Builder != specs.Builder)
				return false;
			if (this.BackWood != specs.BackWood)
				return false;
			if (this.TopWood != specs.TopWood)
				return false;
			
			return true;
		}
	}
}
