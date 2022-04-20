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
        public async Task<IActionResult> GetById(string id)
        {
            var getDpo = await dpoManager.GetDpoByIdAsync(id);
            return Ok(getDpo);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] NewDpoModel newDpo)
        {
            DPOModel insertedDpo;
            insertedDpo = await dpoManager.InsertDpoAsync(newDpo);
            return CreatedAtAction(nameof(Get), new { id = insertedDpo.DpoId }, insertedDpo);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ChangeDpoModel changeDpo)
        {
            var updatedDpo = await dpoManager.UpdateDpoAsync(changeDpo);
            if (updatedDpo == null) return NotFound();
            return Ok(updatedDpo);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await dpoManager.DeleteDpoAsync(id);
            return NoContent();
        }
    }
}