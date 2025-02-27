using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Models
{
	public class Musteri
	{
		public int Id { get; set; }
		public  string? Ad { get; set; }
		public  string? Email { get; set; }
		public  string? TelNo { get; set; }
		public int? UlkeId { get; set; }
		public int? SehirId { get; set; }
		public int? IlceId { get; set; }
		public string? Adres { get; set; }
		public string? VergiDairesi { get; set; }
		public string? VergiNo { get; set; }
		public bool Aktif { get; set; } = true;
		public int? MusteriTemsilciId { get; set; }
		public string? Yetkili { get; set; }

		public Ulke Ulke { get; set; }
		public Sehir Sehir { get; set; }
		public Ilce Ilce { get; set; }
		public MusteriTemsilci MusteriTemsilci { get; set; }
		
		




		
	}
}
