using Campus_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Services
{
    public interface ICampusRepository
    {
        IEnumerable<Event> GetEvents();
        Event GetEvent(int eventId);
        IEnumerable<SubEvents> GetSubEvents(int eventId);
        SubEvents GetSubEvent(int eventId, int subEventId);
    }
}
