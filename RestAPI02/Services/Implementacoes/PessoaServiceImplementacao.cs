using RestAPI02.Data;
using RestAPI02.Models;
using System.Collections.Generic;
using System.Linq;

namespace RestAPI02.Services.Implementacoes
{
    public class PessoaServiceImplementacao : IPessoaService
    {
        private Context _context;

        public PessoaServiceImplementacao(Context context)
        {
            _context = context;
        }

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {

        }

        public List<Pessoa> FindAll()
        {
            return _context.Pessoas.ToList();
        }

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = 1,
                Nome = "Ariel",
                Sobrenome = "Fontes",
                Endereco = "Goiania-GO",
                Sexo = "Masculino"

            };
        }

        public Pessoa Update(Pessoa pessoa)
        {
            return pessoa;
        }
    }
}
