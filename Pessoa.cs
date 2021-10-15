using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_client
{
    class Pessoa
    {
        // atributos da classe
      public string nome;
      public int idade; // definir int quando for necessário cálculos matemáticos
      public string rg;
      public string cpf;

        // criar comportamento
      public void  Acenar(Pessoa pessoa)
        {
            Console.WriteLine("{0} acenou para {1}", this.nome, pessoa.nome);
        }

      public void PerguntaIdade(Pessoa pessoa)
        {

            Console.WriteLine("{0} Qual sua idade?", pessoa.nome);
            pessoa.RespostaIdade();
        } 

        public void RespostaIdade()
        {

            Console.WriteLine("Eu tenho {0} anos", this.idade);

        }
    }
}
