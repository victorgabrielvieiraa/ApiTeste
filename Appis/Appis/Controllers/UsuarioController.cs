using Appis.Model;
using Appis.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Appis.Controllers
{
    [ApiController]
    [Route("api/v1/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        [HttpPost]
        public IActionResult Add(UsuarioViewModel usuarioView)
        {
            var usuario = new Usuario(usuarioView.idusuario, usuarioView.numnotificacoesnaolidas);
            _usuarioRepository.Add(usuario);
            return Ok();
        }
    }
}
