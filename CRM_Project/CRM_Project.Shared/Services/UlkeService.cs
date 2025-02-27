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
    public class UlkeService : IUlkeService
    {
        private readonly DataContext _context;
        public UlkeService(DataContext context)
        {
            _context = context;
        }
        public async Task<Ulke> AddCountry(Ulke ulke)
        {
            _context.Ulkeler.Add(ulke);
            await _context.SaveChangesAsync();

            return ulke;
        }

        public async Task<bool> DeleteCountry(int id)
        {
            var dbCountry = await _context.Ulkeler.FindAsync(id);
            if (dbCountry != null)
            {
                _context.Remove(dbCountry);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;

        }

        public async Task<Ulke> UpdateCountry(int id, Ulke ulke)
        {
            var dbCountry = await _context.Ulkeler.FindAsync(id);

            if (dbCountry != null)
            {

                dbCountry.Ad = ulke.Ad;
                dbCountry.Kod = ulke.Kod;
                dbCountry.AlanKod = ulke.AlanKod;


                await _context.SaveChangesAsync();
                return dbCountry;
            }
            else
            {
                return null;
            }

        }
        public async Task<List<Ulke>> GetAllCountry()
        {
            return await _context.Ulkeler.ToListAsync();
        }

        public async Task<Ulke> GetCountryById(int id)
        {
            return await _context.Ulkeler.FindAsync(id) ?? new Ulke();
        }
    }
}
