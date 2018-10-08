using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public interface IEditoraRepository
    {
        void Cadastrar(Editora editora);
        void Atualizar(Editora editora);
        void Remover(int id);
        Editora BuscarPorId(int id);
        IList<Editora> Listar();
        IList<Editora> BuscarPor(Expression<Func<Editora, bool>> filtro);
    }
}