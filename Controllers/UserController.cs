using Microsoft.AspNetCore.Mvc;
using newDockeNet.Core.ChangeModelsView;
using newDockeNet.Core.Models;
using newDockeNet.Core.ModelsViewNew;
using newDockeNet.Manager.Managment;

namespace newDockeNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager userManager;
        public UserController(IUserManager userManager)
        {
            this.userManager = userManager;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await userManager.GetUsersAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var getUser = await userManager.GetUserByIdAsync(id);
            return Ok(getUser);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] NewUserModel newUser)
        {
            UserModel insertedUser;
            insertedUser = await userManager.InsertUserAsync(newUser);
            return CreatedAtAction(nameof(Get), new { id = insertedUser.UserId }, insertedUser);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromForm] ChangeUserModel changeUser)
        {
            var updatedUser = await userManager.UpdateUserAsync(changeUser);
            if (updatedUser == null) return NotFound();
            return Ok(updatedUser);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await userManager.DeleteUserAsync(id);
            return NoContent();
        }
    }
}