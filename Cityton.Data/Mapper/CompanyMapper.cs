using Cityton.Data.Common;
using Cityton.Data.DTOs;
using Cityton.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Cityton.Data.Mapper
{
    public static class CompanyMapper
    {

        public static CompanySettings ToSettings(this Company company)
        {

            return (new CompanySettings
            {
                Id = company.Id,
                MinGroupSize = company.MinGroupSize,
                MaxGroupSize = company.MaxGroupSize,
            });

        }
    }
}