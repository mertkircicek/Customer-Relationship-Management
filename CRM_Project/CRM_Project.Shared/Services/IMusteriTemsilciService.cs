using CRM_Project.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_Project.Shared.Services
{
	public interface IMusteriTemsilciService
	{
		Task<List<MusteriTemsilci>> GetAllMusteriTemsilci();
		Task<List<MusteriTemsilci>> GetAktifMusteriTemsilci();

		Task<MusteriTemsilci> GetMusteriTemsilciById(int id);

		Task<MusteriTemsilci> AddMusteriTemsilci(MusteriTemsilci musteriTemsilci);

		Task<MusteriTemsilci> UpdateMusteriTemsilci(int id, MusteriTemsilci musteriTemsilci);

		Task<bool> DeleteMusteriTemsilci(int id);
		

	}
}
