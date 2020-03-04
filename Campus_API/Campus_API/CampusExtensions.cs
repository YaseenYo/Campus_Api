using Campus_API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API
{
    public static class CampusExtensions
    {
        public static void EnsureSeedDataForContext(this CampusContext context)
        {
            if(context.Events.Any())
            {
                return;
            }

            var events = new List<Event>
            {
                new Event {
                Name = "Dancing",
                Description = "chammak challo",
                EventDate = new DateTime(2020, 04, 10),
                HostName = "Ali",
                PhotoName = "01"
                },

                new Event {
                Name = "Singing",
                Description = "rangde tu mohe geruva...",
                EventDate = new DateTime(2020, 04, 11),
                HostName = "Owais",
                PhotoName = "02"
                },

                new Event {
                Name = "Sports",
                Description = "Nadan parinde ghar aaja..",
                EventDate = new DateTime(2020, 04, 12),
                HostName = "Jamal",
                PhotoName = "03"
                }

            };

            var subEvents = new List<SubEvents>()
            {
                 new SubEvents
                        {
                            Event = events[0],
                            Name = "hip hop",
                            Description = "Agar tum saath ho..",
                            PhotoName="sunny sunny..",
                            EntryFee = 30,
                            HostName = "Muiz",
                        },
                         new SubEvents
                        {
                            Event = events[1],
                            Name = "Nach meri jaan",
                            Description = "hoke magan tu",
                            PhotoName="chod ke sare kintu paran tu",
                            EntryFee = 40,
                            HostName = "faizan",
                        },
                          new SubEvents
                        {
                            Event = events[2],
                            Name = "aaja dube javun teri",
                            Description = "ankho ke ocean may",
                            PhotoName="slow motion may",
                            EntryFee = 25,
                            HostName = "kaif",
                        }
            };
            context.SubEvents.AddRange(subEvents);
            context.SaveChanges();
        }
    }
}
