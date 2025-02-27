using CRM_Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
    public interface IIlceService
    {
        Task<List<Ilce>> GetAllTown();

        Task<Ilce> GetTownById(int id);

        Task<Ilce> AddTown(Ilce ilce);

        Task<Ilce> UpdateTown(int id, Ilce ilce);

        Task<bool> DeleteTown(int id);
    }
}
