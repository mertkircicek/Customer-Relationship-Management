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
    public class IlceService : IIlceService
    {
        private readonly DataContext _context;
        public IlceService(DataContext context)
        {
            _context = context;
        }
        public async Task<Ilce> AddTown(Ilce ilce)
        {
            _context.Ilceler.Add(ilce);
            await _context.SaveChangesAsync();

            return ilce;
        }

        public async Task<bool> DeleteTown(int id)
        {
            var dbTown = await _context.Ilceler.FindAsync(id);
            if (dbTown != null)
            {
                _context.Remove(dbTown);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<Ilce> UpdateTown(int id, Ilce ilce)
        {
            var dbTown = await _context.Ilceler.FindAsync(id);

            if (dbTown != null)
            {

                dbTown.SehirId = ilce.SehirId;
                dbTown.Ad = ilce.Ad;
                dbTown.PostaKod = ilce.PostaKod;



                await _context.SaveChangesAsync();
                return dbTown;
            }
            else
            {
                return null;
            }

        }
		public async Task<List<Ilce>> GetAllTown()
		{
			return await _context.Ilceler
				.Include(a => a.Sehir)
				.ToListAsync();
				

		}

		public async Task<Ilce> GetTownById(int id)
        {
            return await _context.Ilceler.FindAsync(id) ?? new Ilce();
        }
    }
}

