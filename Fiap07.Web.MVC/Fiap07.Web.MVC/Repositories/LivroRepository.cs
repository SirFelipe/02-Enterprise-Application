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
    public class LivroRepository : ILivroRepository
    {
        private LivrariaContext _context;

        public LivroRepository(LivrariaContext context)
        {
            _context = context;
        }

        public void Atualizar(Livro livro)
        {
            _context.Entry(livro).State = EntityState.Modified;
        }

        public IList<Livro> BuscarPor(Expression<Func<Livro, bool>> filtro)
        {
            return _context.Livros.Include("Editora").Where(filtro).ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _context.Livros.Find(id);
        }

        public void Cadastrar(Livro livro)
        {
            _context.Livros.Add(livro);
        }

        public IList<Livro> Listar()
        {
            return _context.Livros.Include("Editora").ToList();
        }

        public void Remover(int id)
        {
            var livro = BuscarPorId(id);
            _context.Livros.Remove(livro);
        }
    }
}