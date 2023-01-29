using Application.FormControlsBL;
using Domain.Domain.Controls;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class FormControlsController : BaseApiController
    {
        [HttpGet("GetList/{id}")]
        public async Task<IActionResult> GetAssetCategory(int id)
        {
            return HandleResult(await Mediator.Send(new List.Query { FormId = id }));
        }

        [HttpPost("Save")]
        public async Task<IActionResult> CreateAssetCategory(FormControls formControls)
        {
            return HandleResult(await Mediator.Send(new Create.Command { formControls = formControls }));
        }

    }
}
