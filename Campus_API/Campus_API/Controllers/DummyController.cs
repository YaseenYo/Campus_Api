using Campus_API.Entities;
using Campus_API.Models;
using Campus_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Campus_API.Controllers
{
    public class DummyController:Controller
    {
        private CampusContext _context;
        private ICampusRepository campusRepository; 
        public DummyController(CampusContext context,ICampusRepository campusrepository)
        {
            _context = context;
            campusRepository = campusrepository;
        }

        [HttpGet]
        [Route("api/testDatabase/{id}")]
        public IActionResult TestDatabase(int id)
        {
            var CityEntities = campusRepository.GetEvent(id);

            if(CityEntities == null)
            {
                return NotFound("Event Not found...");
            }

            var result = new EventDto()
            {
                ID = CityEntities.ID,
                Name = CityEntities.Name,
                HostName = CityEntities.HostName,
                PhotoName = CityEntities.PhotoName,
                Description = CityEntities.Description,
                EventDate =CityEntities.EventDate
            };
            return Ok(result);
        }
    }
}
