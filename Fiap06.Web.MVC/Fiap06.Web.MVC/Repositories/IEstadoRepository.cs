

using Fiap06.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap06.Web.MVC.Repositories
{
    public interface IEstadoRepository 
    {
        void Cadastrar(Estado estado);

        void Editar(Estado estado);

        void Excluir(int codigo);

        IList<Estado> Listar();

        Estado BuscarPorCodigo(int codigo);

        IList<Estado> BuscarPor(Expression<Func<Estado, bool>> filtro);
    }
}
