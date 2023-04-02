using EnterpriseApi.Data;
using EnterpriseApi.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseApi.Controllers
{
    [ApiController]
    [Route("api/EnterpriseController")]
    public class EnterpriseController :ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public EnterpriseController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public  ActionResult <IEnumerable<EnterpriseDTO>> GetEnterprises()
        {
            return Ok(_db.Enterprises.ToList()); 
        }
    }
}
