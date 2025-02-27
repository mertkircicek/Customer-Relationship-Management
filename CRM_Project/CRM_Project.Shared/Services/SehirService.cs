using CRM_Project.Data;
using CRM_Project.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
	public class SehirService : ISehirService
	{
		private readonly DataContext _context;
		public SehirService(DataContext context)
		{
			_context = context;
		}
		public async Task<Sehir> AddCity(Sehir sehir)
		{
			_context.Sehirler.Add(sehir);
			await _context.SaveChangesAsync();

			return sehir;
		}

		public async Task<bool> DeleteCity(int id)
		{
			var dbCity = await _context.Sehirler.FindAsync(id);
			if (dbCity != null)
			{
				_context.Remove(dbCity);
				await _context.SaveChangesAsync();
				return true;
			}
			return false;

		}

		public async Task<Sehir> UpdateCity(int id, Sehir sehir)
		{
			var dbCity = await _context.Sehirler.FindAsync(id);

			if (dbCity != null)
			{

				dbCity.UlkeId = sehir.UlkeId;
				dbCity.Ad = sehir.Ad;
				dbCity.TelefonKod = sehir.TelefonKod;
				dbCity.Plaka = sehir.Plaka;


				await _context.SaveChangesAsync();
				return dbCity;
			}
			else
			{
				return null;
			}

		}
		public async Task<List<Sehir>> GetAllCity()
		{
			return await _context.Sehirler
				.Include(a =>a.Ulke)
				.ToListAsync();
				//.Select(x => new City
				//{
				//	Id = x.Id,
				//	Ad = x.Ad,
				//	Plaka = x.Plaka,
				//	TelefonKod = x.TelefonKod,

				//	Ad = _context.Ulkeler.Where(a => a.Id == x.UlkeId).Select(a => a.Ad).FirstOrDefault() ?? ""
				//})
				//.ToListAsync();

		}

		public async Task<Sehir> GetCityById(int id)
		{
			return await _context.Sehirler.FindAsync(id) ?? new Sehir();
		}
	}
}

