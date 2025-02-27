using CRM_Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
    public interface ISehirService 
    {
        Task<List<Sehir>> GetAllCity();

        Task<Sehir> GetCityById(int id);

        Task<Sehir> AddCity(Sehir sehir);

        Task<Sehir> UpdateCity(int id, Sehir sehir);

        Task<bool> DeleteCity(int id);
    }
}
