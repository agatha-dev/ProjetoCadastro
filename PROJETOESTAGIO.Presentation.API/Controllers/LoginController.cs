using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Application.Contracts;
using Projeto.Application.Models;
using Projeto.Presentation.Api.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROJETOESTAGIO.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult post(UsuarioAutenticacaoModel model,
            [FromServices] IUsuarioApplicationService usuarioApplicationService,
            [FromServices] JwtConfiguration jwtConfiguration)
        {
            try
            {
                var usuario = usuarioApplicationService
                                    .GetByLoginAndSenha(model);

                if (usuario != null)
                {
                    return Ok(jwtConfiguration.GenerateToken(usuario.Login));
                }
                else
                {
                    return StatusCode(403, "Usuário não encontrado.");
                }
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
