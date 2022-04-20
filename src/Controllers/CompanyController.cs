using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using src.newDockeNet.Core.ChangeModelsView;
using src.newDockeNet.Core.Models;
using src.newDockeNet.Core.ModelsViewNew;
using src.newDockeNet.Manager.Managment;

namespace src.newDockeNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyManager companyManager;
        public CompanyController(ICompanyManager companyManager)
        {
            this.companyManager = companyManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await companyManager.GetCompanyAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var getCompany = await companyManager.GetCompanyByIdAsync(id);
            return Ok(getCompany);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewCompanyModel newCompany)
        {
            CompanyModel insertedCompany;
            insertedCompany = await companyManager.InsertCompanyAsync(newCompany);
            return CreatedAtAction(nameof(Get), new { id = insertedCompany.CompanyId }, insertedCompany);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ChangeCompanyModel changeCompany)
        {
            var updatedCompany = await companyManager.UpdateCompanyAsync(changeCompany);
            if (updatedCompany == null) return NotFound();
            return Ok(updatedCompany);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await companyManager.DeleteCompanyAsync(id);
            return NoContent();
        }
    }
}