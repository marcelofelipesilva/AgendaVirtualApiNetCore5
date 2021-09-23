using System.Collections.Generic;
using AgendaVirtualApi.Business.Entities;

namespace AgendaVirtualApi.Business.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();

        List<Usuario> obterUsuarios(int usuarioID);
    }
}