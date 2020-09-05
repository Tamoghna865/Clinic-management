using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Clinic_Management_API.MODELS;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Clinic_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DOCTORSCONTROLLER : ControllerBase
    {
        readonly log4net.ILog _log4net;
        private readonly ClinicContext _context;
        public DOCTORSCONTROLLER(ClinicContext context)
        {
            _context = context;
            _log4net = log4net.LogManager.GetLogger(typeof(DOCTORSCONTROLLER));

        }
        // GET: api/<DOCTORSCONTROLLER>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return _context.Doctors.ToList();
        }

        // GET api/<DOCTORSCONTROLLER>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DOCTORSCONTROLLER>
        [HttpPost]
        public string Post([FromBody] Doctor value)
        {
            _context.Doctors.Add(value);
            _context.SaveChanges();
            return "Success";
        }

        // PUT api/<DOCTORSCONTROLLER>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] Doctor value)
        {
            Doctor obj = _context.Doctors.Find(id);
            
            obj.Name = value.Name;
            obj.Email = value.Email;
            obj.Password = value.Password;
            _context.SaveChanges();
            return "congrats!Updated successfully";


        }

        // DELETE api/<DOCTORSCONTROLLER>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            Doctor obj = _context.Doctors.Find(id);
            _context.Doctors.Remove(obj);
            _context.SaveChanges();
            return "deleted successfully";
        }
    }
}
