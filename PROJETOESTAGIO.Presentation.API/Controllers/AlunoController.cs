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
    public class AlunoController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(AlunoCadastroModel model,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Insert(model);
                return Ok("Aluno cadastrado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(AlunoEdicaoModel model,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Update(model);
                return Ok("Aluno atualizado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                alunoApplicationService.Delete(id);
                return Ok("Aluno deletado com sucesso.");
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll(
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                return Ok(alunoApplicationService.GetAll());
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id,
            [FromServices] IAlunoApplicationService alunoApplicationService)
        {
            try
            {
                return Ok(alunoApplicationService.GetById(id));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

    }
}