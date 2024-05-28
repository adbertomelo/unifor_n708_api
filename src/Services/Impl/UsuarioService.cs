using bolao10.api.DataBase.Entities;
using bolao10.api.DataBase.Repositories.Interfaces;
using bolao10.api.Services.Interfaces;

namespace bolao10.api.Services.Impl
{

    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(
            IUsuarioRepository usuarioRepository
        )
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<Usuario> GetByEmailAsync(string email)
        {
            var res = await _usuarioRepository.GetByEmailAsync(email);

            if (res == null)
                throw new Exception("Usuário não encontrado.");

            return res;

        }

        public Task<List<Cidade>> GetCidades()
        {
            return _usuarioRepository.GetCidades();
        }
    }
}
