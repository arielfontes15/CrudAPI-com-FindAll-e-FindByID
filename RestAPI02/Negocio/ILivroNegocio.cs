using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Negocio
{
    public interface ILivroNegocio
    {
        Livro Create(Livro livro);
        Livro FindByID(long id);
        Livro Update(Livro livro);
        void Delete(long id);

        List<Livro> FindAll();
    }
}
