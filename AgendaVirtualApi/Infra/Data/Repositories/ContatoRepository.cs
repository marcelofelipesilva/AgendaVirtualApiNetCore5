using System.Collections.Generic;
using System.Linq;
using AgendaVirtualApi.Business.Entities;
using AgendaVirtualApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AgendaVirtualApi.Infra.Data.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly AgendaVirtualApiDbContext _context;

        public ContatoRepository(AgendaVirtualApiDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Contato contato)
        {
            _context.Add(contato);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Contato> obterContatos(int contatoID)
        {
            return _context.Contatos.Include(i => i.ContatoID).Where(w => w.ContatoID == contatoID).ToList();
        }
    }
}