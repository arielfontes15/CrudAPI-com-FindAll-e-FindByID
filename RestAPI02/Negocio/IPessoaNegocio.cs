using RestAPI02.Models;
using System.Collections.Generic;

namespace RestAPI02.Negocio
{
    public interface IPessoaNegocio
    {
        Pessoa Create(Pessoa pessoa);
        Pessoa FindByID(long id);
        Pessoa Update(Pessoa pessoa);
        void Delete(long id);

        List<Pessoa> FindAll();
    }
}
