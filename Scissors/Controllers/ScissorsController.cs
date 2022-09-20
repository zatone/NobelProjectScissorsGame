using BLL.Games.Scissors;
using System;
using System.Threading.Tasks;
using System.Web.Http;
using static DOM.Games.Scissors.Enums;

namespace Scissors.Controllers
{
    public class ScissorsController : ApiController
    {
        [HttpPost]
        [Route("PlayGame")]
        public virtual async Task<IHttpActionResult> PlayGame(ScissorGameMove playerPlay)
        {
            try
            {
                var manager = new ScissorManager();

                var result = await manager.Play(playerPlay);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("Test")]
        public virtual async Task<IHttpActionResult> Test()
        {
            return Ok("Success");
        }
    }
}
