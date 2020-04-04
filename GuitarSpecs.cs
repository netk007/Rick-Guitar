using System;
using System.Collections.Generic;
using System.Text;

namespace RickGuitars
{
	public class GuitarSpecs {
		public string Model { get; set; }
		public Type Type { get; set; }
		public Builder Builder { get; set; }
		public Wood BackWood { get; set; }
		public Wood TopWood { get; set; }

		public GuitarSpecs(string model, Type type, Builder builder, Wood backWood, Wood topWood) {
			this.Model = model;
			this.Type = type;
			this.Builder = builder;
			this.BackWood = backWood;
			this.TopWood = topWood;
		}

		public bool MatchSpecs(GuitarSpecs guitarSpec) {
			if (!this.Model.ToLower().Equals(guitarSpec.Model.ToLower()))
				return false;
			if (this.Type != guitarSpec.Type)
				return false;
			if (this.Builder != guitarSpec.Builder)
				return false;
			if (this.BackWood != guitarSpec.BackWood)
				return false;
			if (this.TopWood != guitarSpec.TopWood)
				return false;

			return true;
		}
	}
}
