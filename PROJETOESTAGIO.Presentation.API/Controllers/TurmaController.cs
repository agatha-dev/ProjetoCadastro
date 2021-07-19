using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;

namespace Projeto.Presentation.Api.Controllers
{
    [EnableCors("DefaultPolicy")]
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(TurmaCadastroModel model,
            [FromServices] ITurmaApplicationService turmaApplicationService)
        {
            try
            {
                turmaApplicationService.Insert(model);
                //retornar status de sucesso 200 (OK)
                return Ok("Turma cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(TurmaEdicaoModel model,
            [FromServices] ITurmaApplicationService turmaApplicationService)
        {
            try
            {
                turmaApplicationService.Update(model);
                //retornar status de atualizado 200 (OK)
                return Ok("Turma atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,
            [FromServices] ITurmaApplicationService turmaApplicationService)
        {
            try
            {
                turmaApplicationService.Delete(id);
                //retornar status de sucesso 200 (OK)
                return Ok("Turma deletado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(
            [FromServices] ITurmaApplicationService turmaApplicationService)
        {
            try
            {
                //retornar status de sucesso 200 (OK)
                return Ok(turmaApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id,
            [FromServices] ITurmaApplicationService turmaApplicationService)
        {
            try
            {
                //retornar status de sucesso 200 (OK)
                return Ok(turmaApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}