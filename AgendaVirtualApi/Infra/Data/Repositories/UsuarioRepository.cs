using System.Collections.Generic;
using System.Linq;
using AgendaVirtualApi.Business.Entities;
using AgendaVirtualApi.Business.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace AgendaVirtualApi.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AgendaVirtualApiDbContext _context;

        public UsuarioRepository(AgendaVirtualApiDbContext context)
        {
            _context = context;
        }

        public void Adicionar(Usuario usuario)
        {
            _context.Add(usuario);
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Usuario> obterUsuarios(int usuarioID)
        {
            return _context.Usuarios.Include(i => i.UsuarioID).Where(w => w.UsuarioID == usuarioID).ToList();
        }
    }
}