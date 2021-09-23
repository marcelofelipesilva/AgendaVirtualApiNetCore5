using System.Collections.Generic;
using AgendaVirtualApi.Business.Entities;

namespace AgendaVirtualApi.Business.IRepositories
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);
        void Commit();

        List<Tarefa> obterTarefass(int tarefasID);
    }
}