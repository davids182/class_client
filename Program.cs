using System;


namespace class_client
{
    class Program
    {
        static void Main(string[] args)
        {
            //chamar a classe Pessoa para a primeira pessoa
            Pessoa pessoa1 = new Pessoa();

            // atribuindo valores para as objetos da classe Pessoa

            Console.WriteLine("Digite o nome da pessoa: ");
            pessoa1.nome = Console.ReadLine();

            Console.WriteLine("Digite a idade da pessoa: ");
            pessoa1.idade = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Digite o RG da pessoa: ");
            pessoa1.rg = Console.ReadLine();

            Console.WriteLine("Digite o CPF da pessoa: ");
            pessoa1.cpf = Console.ReadLine();
           
            // mostrando na console os valores de cada variável da classe Pessoa
            Console.WriteLine("Nome: {0}", pessoa1.nome);
            Console.WriteLine("Idade: {0}", pessoa1.idade);
            Console.WriteLine("RG: {0}", pessoa1.rg);
            Console.WriteLine("CPF: {0}", pessoa1.cpf);


            // chama a classe novamente para criar uma NOVA pessoa 
            Pessoa pessoa2 = new Pessoa();
          
            // atribuindo valores para as objetos da classe Pessoa
            pessoa2.nome = "Thomas Eduardo";
            pessoa2.idade = 12;
            pessoa2.rg = "00.000.000-0";
            pessoa2.cpf = "111.111.111-11";

            // mostrando na console os valores de cada variável da classe Pessoa
            Console.WriteLine("Nome: {0}", pessoa2.nome);
            Console.WriteLine("Idade: {0}", pessoa2.idade);
            Console.WriteLine("RG: {0}", pessoa2.rg);
            Console.WriteLine("CPF: {0}", pessoa2.cpf);

            //utilizando o comportamento - onde a pessoa 1 efetua o comportamento para a pessoa 2
            pessoa1.Acenar(pessoa2);

            pessoa1.PerguntaIdade(pessoa2);

        }
    }
}
