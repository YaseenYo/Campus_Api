using Campus_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Services
{
    public class CampusRepository : ICampusRepository
    {
        private CampusContext _context;
        public CampusRepository(CampusContext context)
        {
            _context = context;
        }
        public Event GetEvent(int eventId)
        {
            return _context.Events.Where(e => e.ID == eventId).FirstOrDefault();
        }

        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.OrderBy(e => e.Name).ToList();
        }

        public SubEvents GetSubEvent(int eventId, int subEventId)
        {
            return _context.SubEvents
                .Where(s => s.ID == subEventId && s.EventId == eventId).FirstOrDefault();
        }

        public IEnumerable<SubEvents> GetSubEvents(int eventId)
        {
            return _context.SubEvents.OrderBy(s => s.Name).ToList();
        }
    }
}
