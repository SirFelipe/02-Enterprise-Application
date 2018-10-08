using Fiap07.Web.MVC.Persistencia;
using Fiap07.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private LivrariaContext _context = new LivrariaContext();

        private IEditoraRepository _editoraRepository;

        private ILivroRepository _livroRepository;

        public ILivroRepository LivroRepository
        {
            get
            {
                if (_livroRepository == null)
                {
                    _livroRepository = new LivroRepository(_context);
                }
                return _livroRepository;
            }
        }

        public IEditoraRepository EditoraRepository
        {
            get
            {
                if (_editoraRepository == null)
                {
                    _editoraRepository = new EditoraRepository(_context);
                }
                return _editoraRepository;
            }
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}