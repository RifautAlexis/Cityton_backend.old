﻿using Cityton.Data.Models;
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
    }

    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {

        private readonly ApplicationContext _context;

        public CompanyRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

    }
}