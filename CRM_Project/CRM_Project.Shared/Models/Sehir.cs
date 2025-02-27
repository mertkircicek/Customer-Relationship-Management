using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Models
{
    public class Sehir
    {
        public int Id { get; set; }
        public int? UlkeId { get; set; }
        public string? Ad { get; set; }
        public string? TelefonKod {  get; set; }
        public string? Plaka { get; set; }
		public Ulke Ulke { get; set; }


        
    }
}
