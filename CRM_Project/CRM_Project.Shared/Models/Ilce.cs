using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Models
{
    public class Ilce
    {
        public int Id { get; set; }
        public int? SehirId { get; set; }
        public string? Ad { get; set; }
        public string? PostaKod { get; set;}
		public Sehir Sehir { get; set; }
	}
}
