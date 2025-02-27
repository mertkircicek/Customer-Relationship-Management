using CRM_Project.Data;
using CRM_Project.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CRM_Project.Shared.Services
{
	public class MusteriService : IMusteriService
	{
		private readonly DataContext _context;
		public MusteriService(DataContext context)
		{
			_context = context;
		}

		public async Task<Musteri> AddCustomer(Musteri musteri)
		{
			_context.Musteriler.Add(musteri);
			await _context.SaveChangesAsync();

			return musteri;
		}

		public async Task<bool> DeleteCustomer(int id)
		{
			var dbMusteri = await _context.Musteriler.FindAsync(id);
			if (dbMusteri != null)
			{
				_context.Remove(dbMusteri);
				await _context.SaveChangesAsync();
				return true;
			}
			return false;

		}

		public async Task<Musteri> UpdateCustomer(int id, Musteri musteri)
		{
			var dbMusteri = await _context.Musteriler.FindAsync(id);

			if (dbMusteri != null)
			{

				dbMusteri.Ad = musteri.Ad;
				dbMusteri.Email = musteri.Email;
				dbMusteri.TelNo = musteri.TelNo;
				dbMusteri.Adres= musteri.Adres;
				dbMusteri.UlkeId = musteri.UlkeId;
				dbMusteri.SehirId = musteri.SehirId;
				dbMusteri.IlceId = musteri.IlceId;
				dbMusteri.VergiDairesi = musteri.VergiDairesi;
				dbMusteri.VergiNo=musteri.VergiNo;
				dbMusteri.Aktif=musteri.Aktif;
				dbMusteri.MusteriTemsilciId = musteri.MusteriTemsilciId;


				await _context.SaveChangesAsync();
				return dbMusteri;
			}
			else
			{
				return null;
			}

        }
		public async Task<List<Musteri>> GetAllCustomer()
		{
            return await _context.Musteriler
                .Include(a => a.Sehir)
                .Include(a => a.Ilce)
                .ToListAsync();
        }

		public async Task<Musteri> GetCustomerById(int id)
		{
			return await _context.Musteriler.FindAsync(id) ?? new Musteri();
		}
	}
}