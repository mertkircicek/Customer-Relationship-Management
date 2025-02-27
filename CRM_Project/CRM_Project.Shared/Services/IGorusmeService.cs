using CRM_Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
	public interface IGorusmeService
	{
		Task<List<Gorusme>> GetAllGorusme();

		Task<Gorusme> GetGorusmeById(int id);

		Task<Gorusme> AddGorusme(Gorusme gorusme);

		Task<Gorusme> UpdateGorusme(int id, Gorusme gorusme);

		Task<bool> DeleteGorusme(int id);
	}
}
