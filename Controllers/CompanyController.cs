using Microsoft.AspNetCore.Mvc;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Controllers
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
        public async Task<IActionResult> GetById(int id)
        {
            var getCompany = await companyManager.GetCompanyByIdAsync(id);
            return Ok(getCompany);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewCompanyModel newCompany)
        {
            CompanyModel insertedCompany;
            insertedCompany = await companyManager.InsertCompanyAsync(newCompany);
            return CreatedAtAction(nameof(Get), new { id = insertedCompany.Id }, insertedCompany);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ChangeCompanyModel changeCompany)
        {
            var updatedCompany = await companyManager.UpdateCompanyAsync(changeCompany);
            if (updatedCompany == null) return NotFound();
            return Ok(updatedCompany);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await companyManager.DeleteCompanyAsync(id);
            return NoContent();
        }
    }
}