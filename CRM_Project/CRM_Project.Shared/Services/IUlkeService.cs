using CRM_Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
    public interface IUlkeService
    {
        Task<List<Ulke>> GetAllCountry();

        Task<Ulke> GetCountryById(int id);

        Task<Ulke> AddCountry(Ulke ulke);

        Task<Ulke> UpdateCountry(int id, Ulke ulke);

        Task<bool> DeleteCountry(int id);
    }
}
