using RestAPI02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestAPI02.Services.Implementacoes
{
    public class PessoaServiceImplemetacao : IPessoaService
    {
        private volatile int count;

        public Pessoa Create(Pessoa pessoa)
        {
            return pessoa;
        }

        public void Delete(long id)
        {

        }

        public List<Pessoa> FindAll()
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            for (int i = 0; i < 8; i++)
            {
                Pessoa pessoa = MockPerson(i);
                pessoas.Add(pessoa);
            }
            return pessoas;
        }

        public Pessoa FindByID(long id)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
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

        private Pessoa MockPerson(int i)
        {
            return new Pessoa
            {
                Id = IncrementAndGet(),
                Nome = "Nome da Pessoa" + i,
                Sobrenome = "Sobrenome da pessoa" + i,
                Endereco = "Endereco" + 1,
                Sexo = "Masculino"

            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
