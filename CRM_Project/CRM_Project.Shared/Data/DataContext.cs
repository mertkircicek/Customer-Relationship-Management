using CRM_Project.Shared.Models;
using CRM_Project.Shared.Services;
using Microsoft.EntityFrameworkCore;

namespace CRM_Project.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
		public DbSet<Musteri> Musteriler { get; set; }
		public DbSet<Ulke> Ulkeler { get; set; }
		public DbSet<Sehir> Sehirler { get; set; }
		public DbSet<Ilce> Ilceler {  get; set; }
		public DbSet<MusteriTemsilci> MusteriTemsilciler { get; set; }
		public DbSet<Gorusme> Gorusmeler { get; set; }
		

		
	}


}
