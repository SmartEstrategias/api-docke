using Microsoft.AspNetCore.Mvc;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DPOController : ControllerBase
    {
        private readonly IDPOManager dpoManager;
        public DPOController(IDPOManager dpoManager)
        {
            this.dpoManager = dpoManager;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await dpoManager.GetDpoAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var getDpo = await dpoManager.GetDpoByIdAsync(id);
            return Ok(getDpo);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewDpoModel newDpo)
        {
            DPOModel insertedDpo;
            insertedDpo = await dpoManager.InsertDpoAsync(newDpo);
            return CreatedAtAction(nameof(Get), new { id = insertedDpo.Id }, insertedDpo);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ChangeDpoModel changeDpo)
        {
            var updatedDpo = await dpoManager.UpdateDpoAsync(changeDpo);
            if (updatedDpo == null) return NotFound();
            return Ok(updatedDpo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await dpoManager.DeleteDpoAsync(id);
            return NoContent();
        }
    }
}