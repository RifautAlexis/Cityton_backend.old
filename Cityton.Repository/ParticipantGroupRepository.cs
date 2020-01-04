using Cityton.Data;
using Cityton.Data.Common;
using Cityton.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cityton.Repository
{

    public interface IParticipantGroupRepository : IRepository<ParticipantGroup>
    {
        Task<ParticipantGroup> Get(int groupId, int participantId);

        Task<ParticipantGroup> AlreadyAccepted(int userId);
        Task<List<ParticipantGroup>> GetByUser(int userId);
    }

    public class ParticipantGroupRepository : Repository<ParticipantGroup>, IParticipantGroupRepository
    {

        public ParticipantGroupRepository(ApplicationContext context) : base(context) { }

        public async Task<ParticipantGroup> Get(int groupId, int participantId)
        {
            return await context.ParticipantGroups.Where(pg => pg.BelongingGroupId == groupId && pg.UserId == participantId).FirstOrDefaultAsync();
        }

        public async Task<ParticipantGroup> AlreadyAccepted(int userId)
        {
            return await context.ParticipantGroups.Where(pg => pg.Status == Status.Accepted).FirstOrDefaultAsync();
        }

        public async Task<List<ParticipantGroup>> GetByUser(int userId)
        {
            return await context.ParticipantGroups.Where(pg => pg.UserId == userId).ToListAsync();
        }

    }
}