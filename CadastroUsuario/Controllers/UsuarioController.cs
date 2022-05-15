using CadastroUsuario.Application.Interfaces;
using CadastroUsuario.Dto;
using Microsoft.AspNetCore.Mvc;

namespace CadastroUsuario.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

       
        [HttpGet("GetByLogin")]
        public async Task<IActionResult> GetByLogin( string email, int CPF, string password)
        {
            var result = await _usuarioService.Retorno(email, CPF, password);
            if (result == false) return NotFound();
            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] InputUsuarioDto usuarioDto)
        {
            _usuarioService.Add(usuarioDto.Email, usuarioDto.CPF, usuarioDto.Password);
            return Ok();
        }
    }
}