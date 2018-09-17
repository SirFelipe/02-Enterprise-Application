using Fiap06.Web.MVC.Models;
using Fiap06.Web.MVC.Persistencia;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap06.Web.MVC.Repositories
{
    public class EstadoRepository : IEstadoRepository
    {

        private GeografiaContext _context;


        public EstadoRepository(GeografiaContext context)
        {
            _context = context;
        }

        public IList<Estado> BuscarPor(Expression<Func<Estado, bool>> filtro)
        {
            return _context.Estados.Where(filtro).ToList();
        }

        public Estado BuscarPorCodigo(int codigo)
        {
            return _context.Estados.Find(codigo);
        }

        public void Cadastrar(Estado estado)
        {
            _context.Estados.Add(estado);
        }

        public void Editar(Estado estado)
        {
            _context.Entry(estado).State = EntityState.Modified;
        }

        public void Excluir(int codigo)
        {
            var est = BuscarPorCodigo(codigo);
            _context.Estados.Remove(est);
        }

        public IList<Estado> Listar()
        {
            return _context.Estados.ToList();
        }
    }
}