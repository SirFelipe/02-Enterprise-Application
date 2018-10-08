using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public interface ILivroRepository
    {
        void Cadastrar(Livro livro);
        void Atualizar(Livro livro);
        void Remover(int id);
        Livro BuscarPorId(int id);
        IList<Livro> Listar();
        IList<Livro> BuscarPor(Expression<Func<Livro, bool>> filtro);
    }
}