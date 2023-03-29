using System;

namespace ConsoleApp 
{
    class Program
    {

        static void Main() 
        {
            Funcionario[] funcionarios = new Funcionario[30];
            var indexArray = 0;
            string userOption = getUserOption();

            while (userOption.ToUpper() != "X") 
            {
                switch (userOption) 
                {
                    case "1":

                        Console.WriteLine("Informe o nome do funcionario: ");
                        Funcionario funcionario = new Funcionario();
                        funcionario.nome = Console.ReadLine();

                        Console.WriteLine("Informe o salário do funcionario: ");
                        funcionario.salario = Console.ReadLine();

                        Console.WriteLine("Informe o departamento do funcionario: ");
                        funcionario.departamento = Console.ReadLine();

                        Console.WriteLine("Informe o nivel do funcionario: ");
                        funcionario.nivel = Console.ReadLine();

                        Console.WriteLine("Informe os anos de experiência do funcionario: "); 
                        funcionario.anosExperiencia = Console.ReadLine();


                        funcionarios[indexArray++] = funcionario;
                        indexArray++;
                        break;

                    case "2":

                        Console.WriteLine("");
                        Console.WriteLine("-- Funcionários Cadastrados --");
                        Console.WriteLine("");

                        foreach(var funcionarioInfo in funcionarios) 
                        {
                            if (!string.IsNullOrEmpty(funcionarioInfo.nome)) 
                            {
                                Console.WriteLine($" | Nome : {funcionarioInfo.nome} | Salário : R$ {funcionarioInfo.salario} | Departamento : {funcionarioInfo.departamento} | Nivel : {funcionarioInfo.nivel} | Experiência : {funcionarioInfo.anosExperiencia} | ");
                            }
                        }

                        break;
                }
                userOption = getUserOption();
            }
        }


        static string getUserOption() 
        {
            Console.WriteLine();
            Console.WriteLine("-- Console Application --");
            Console.WriteLine();
            Console.WriteLine("1 - Adicionar funcionario ");
            Console.WriteLine("2 - Listar funcionário ");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            var UserOption = Console.ReadLine();
            return UserOption;
        }
    }
}