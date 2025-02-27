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
	public class MusteriTemsilciService : IMusteriTemsilciService
	{
		private readonly DataContext _context;
		public MusteriTemsilciService(DataContext context)
		{
			_context = context;
		}

		public async Task<MusteriTemsilci> AddMusteriTemsilci(MusteriTemsilci musteriTemsilci)
		{
			_context.MusteriTemsilciler.Add(musteriTemsilci);
			await _context.SaveChangesAsync();

			return musteriTemsilci;
		}

		public async Task<bool> DeleteMusteriTemsilci(int id)
		{
			var dbTemsilci = await _context.MusteriTemsilciler.FindAsync(id);
			if (dbTemsilci != null)
			{
				_context.Remove(dbTemsilci);
				await _context.SaveChangesAsync();
				return true;
			}
			return false;

		}

		public async Task<MusteriTemsilci> UpdateMusteriTemsilci(int id, MusteriTemsilci musteriTemsilci)
		{
			var dbTemsilci = await _context.MusteriTemsilciler.FindAsync(id);

			if (dbTemsilci != null)
			{
                dbTemsilci.Ad = musteriTemsilci.Ad;
				dbTemsilci.Soyad = musteriTemsilci.Soyad;
				dbTemsilci.TelNo = musteriTemsilci.TelNo;
				dbTemsilci.Aciklama = musteriTemsilci.Aciklama;
				dbTemsilci.Aktif = musteriTemsilci.Aktif;
				


				await _context.SaveChangesAsync();
				return dbTemsilci;
			}
			else
			{
				return null;
			}

		}
		public async Task<List<MusteriTemsilci>> GetAllMusteriTemsilci()
		{
			return await _context.MusteriTemsilciler.ToListAsync();
		}

		public async Task<List<MusteriTemsilci>> GetAktifMusteriTemsilci()
		{
			return await _context.MusteriTemsilciler.Where(a=>a.Aktif==true).ToListAsync();
		}

		public async Task<MusteriTemsilci> GetMusteriTemsilciById(int id)
		{
			return await _context.MusteriTemsilciler.FindAsync(id) ?? new MusteriTemsilci();

		}
	}
}
