using System.Collections.Generic;
using AgendaVirtualApi.Business.Entities;

namespace AgendaVirtualApi.Business.Repositories
{
    public interface IContatoRepository
    {
        void Adicionar(Contato contato);
        void Commit();

        List<Contato> obterContatos(int contatoID);
    }
}