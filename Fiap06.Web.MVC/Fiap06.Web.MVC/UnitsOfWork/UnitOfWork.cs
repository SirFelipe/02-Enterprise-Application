using Fiap06.Web.MVC.Persistencia;
using Fiap06.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Web.MVC.UnitsOfWork
{
    public class UnitOfWork :IDisposable
    {
        private GeografiaContext _context = new GeografiaContext();

        private IEstadoRepository _estadoRepository;
        private ICidadeRepository _cidadeRepository;


        public ICidadeRepository CidadeRepository
        {
            get
            {
                if (_cidadeRepository == null)
                {
                    _cidadeRepository = new CidadeRepository(_context);
                }
                return _cidadeRepository;
            }
        }

        public IEstadoRepository EstadoRepository
        {
            get
            {
                if(_estadoRepository == null)
                {
                    _estadoRepository = new EstadoRepository(_context);
                }
                return _estadoRepository;
            }

        }

        public void Dispose()
        {
            if(_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }


        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}