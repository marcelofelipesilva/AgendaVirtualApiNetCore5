using System.Collections.Generic;
using System.Linq;
using AgendaVirtualApi.Business.Entities;
using AgendaVirtualApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AgendaVirtualApi.Infra.Data.Repositories
{
    public class TarefaRepository : ITarefaRepository
    {
        private readonly AgendaVirtualApiDbContext _context;

        public TarefaRepository(AgendaVirtualApiDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Tarefa tarefa)
        {
            _context.Add(tarefa);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Tarefa> obterTarefass(int tarefasID)
        {
            return _context.Tarefas.Include(i => i.TarefaID).Where(w => w.TarefaID == tarefasID).ToList();
        }
    }
}