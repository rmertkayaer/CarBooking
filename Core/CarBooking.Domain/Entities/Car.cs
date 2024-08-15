using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CarBooking.Domain.Entities
{
	public class Car
	{
		public int CarID { get; set; }
		public int BrandID { get; set; }
		public Brand Brand { get; set;  }
		public string Model { get; set; }
		public string CoverImageUrl { get; set; }
		public string BigImageUrl { get; set; }
        public int Kilometer { get; set; }
        public string Transmission { get; set; }
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public byte Fuel { get; set; }
		 
		public List<CarFeature> CarFeatures { get; set; }
		public List<CarDescription> CarDescriptions { get; set; }
		public List<CarPricing> CarPricings { get; set; }
	}

}
