using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IMediaRepository : IRepository<Media>
    {
    }

    public class MediaRepository : Repository<Media>, IMediaRepository
    {
        public MediaRepository(ApplicationContext context) : base(context) { }
    }
}
