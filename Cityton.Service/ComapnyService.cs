using Cityton.Data.Models;
using Cityton.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Service
{

    public interface ICompanyService
    {
        Task<Company> Get(int id);
    }

    public class CompanyService : ICompanyService
    {
        private ICompanyRepository companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public async Task<Company> Get(int id)
        {
            return await companyRepository.Get(id);
        }

    }

}