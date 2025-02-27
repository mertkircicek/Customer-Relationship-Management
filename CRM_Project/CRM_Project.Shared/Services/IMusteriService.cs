using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM_Project.Shared.Models;
using CRM_Project.Shared.Services;


namespace CRM_Project.Shared.Services
{
	public interface IMusteriService
	{
		Task<List<Musteri>> GetAllCustomer();

		Task<Musteri> GetCustomerById(int id);

		Task<Musteri> AddCustomer(Musteri musteri);

		Task<Musteri> UpdateCustomer(int id, Musteri musteri);

		Task<bool> DeleteCustomer(int id);


	}
}
