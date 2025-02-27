using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Models
{
	public class Gorusme
	{
		public int Id { get; set; }
		public int MusteriId { get; set; }
		public string? YetkiliAd {get; set; }
		public DateTime GorusmeTarih {get; set; }
		public string? GorusmeNot {get; set; }
		public string SonrakiGorusmeNot { get; set; }
		public DateTime RandevuTarih {get; set; }

		public Musteri Musteri { get; set; }


	}
}
