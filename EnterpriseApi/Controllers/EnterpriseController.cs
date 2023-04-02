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
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult <EnterpriseDTO> GetEnterprise(int id)
        {
            if(id == 0)
            {
                return BadRequest();
            }
            var enterprise = _db.Enterprises.FirstOrDefault(u => u.Id == id);
             {
                return NotFound();   
             }
            return Ok(enterprise);
        }
    }
}
