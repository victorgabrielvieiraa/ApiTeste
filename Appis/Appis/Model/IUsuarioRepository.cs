namespace Appis.Model
{
    public interface IUsuarioRepository
    {

        void Add(Usuario usuario);

        List<Usuario> Get();

    }
}
