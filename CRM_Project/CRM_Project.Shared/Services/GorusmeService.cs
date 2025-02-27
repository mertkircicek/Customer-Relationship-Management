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
	public class GorusmeService : IGorusmeService
	{

		private readonly DataContext _context;
		public GorusmeService(DataContext context)
		{
			_context = context;
		}
		public async Task<Gorusme> AddGorusme(Gorusme gorusme)
		{
			_context.Gorusmeler.Add(gorusme);
			await _context.SaveChangesAsync();

			return gorusme;
		}

		public async Task<bool> DeleteGorusme(int id)
		{
			var dbGorusme = await _context.Gorusmeler.FindAsync(id);
			if (dbGorusme != null)
			{
				_context.Remove(dbGorusme);
				await _context.SaveChangesAsync();
				return true;
			}
			return false;

		}

		public async Task<Gorusme> UpdateGorusme(int id, Gorusme gorusme)
		{
			var dbGorusme = await _context.Gorusmeler.FindAsync(id);

			if (dbGorusme != null)
			{

				dbGorusme.MusteriId = gorusme.MusteriId;
				dbGorusme.GorusmeTarih = gorusme.GorusmeTarih;
				dbGorusme.GorusmeNot = gorusme.GorusmeNot;
				dbGorusme.SonrakiGorusmeNot = gorusme.SonrakiGorusmeNot;
				dbGorusme.RandevuTarih = gorusme.RandevuTarih;
				dbGorusme.YetkiliAd = gorusme.YetkiliAd;


				await _context.SaveChangesAsync();
				return dbGorusme;
			}
			else
			{
				return null;
			}

		}
		public async Task<List<Gorusme>> GetAllGorusme()
		{
			return await _context.Gorusmeler
				.Include(a => a.Musteri)
				.ToListAsync();

		}

		public async Task<Gorusme> GetGorusmeById(int id)
		{
			return await _context.Gorusmeler.FindAsync(id) ?? new Gorusme();
		}
	}
}

