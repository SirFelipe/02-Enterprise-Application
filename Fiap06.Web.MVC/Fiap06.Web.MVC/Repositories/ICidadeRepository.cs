using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap06.Web.MVC.Repositories
{
    public interface ICidadeRepository
    {
        void Cadastrar(Cidade cidade);
        void Editar(Cidade cidade);
        void Excluir(int id);
        IList<Cidade> Listar();
        Cidade BuscarPorCodigo(int id);
        IList<Cidade> BuscarPor(Expression<Func<Cidade, bool>> filtro);
    }
}