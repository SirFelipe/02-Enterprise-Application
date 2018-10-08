using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistencia;

namespace Fiap07.Web.MVC.Repositories
{
    public class EditoraRepository : IEditoraRepository
    {
        private LivrariaContext _context;

        public EditoraRepository(LivrariaContext context)
        {
            _context = context;
        }

        public void Atualizar(Editora editora)
        {
            _context.Entry(editora).State = EntityState.Modified;
        }

        public IList<Editora> BuscarPor(Expression<Func<Editora, bool>> filtro)
        {
            return _context.Editoras.Where(filtro).ToList();
        }

        public Editora BuscarPorId(int id)
        {
            return _context.Editoras.Find(id);
        }

        public void Cadastrar(Editora editora)
        {
            _context.Editoras.Add(editora);
        }

        public IList<Editora> Listar()
        {
            return _context.Editoras.ToList();
        }

        public void Remover(int id)
        {
            var editora = BuscarPorId(id);
            _context.Editoras.Remove(editora);
        }
    }
}