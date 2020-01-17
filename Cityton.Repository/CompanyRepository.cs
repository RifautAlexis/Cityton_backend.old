using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface ICompanyRepository : IRepository<Company>
    {
        Task<int> getMinimalSize(int companyId);
    }

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        public CompanyRepository(ApplicationContext context) : base(context) {  }

        public async Task<int> getMinimalSize(int companyId) {
            return await context.Companies.Where(c => c.Id == companyId).Select(c => c.MinGroupSize).FirstOrDefaultAsync();
        }

    }
}
