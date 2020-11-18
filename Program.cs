using System;

namespace Nome_senha
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string nomec;
            string senha1;
            string senha2;
            string senhac;
            int escolha;
            int rep;
            
            rep = 1;
            while (rep == 1)
            {
                Console.WriteLine("Cadastro");
                Console.WriteLine("------------------------");
                Console.Write("Insira o nome do usuario: ");
                nome = Console.ReadLine();
                nomec = nome.ToUpper();
                Console.Write("Insira uma senha: ");
                senha1 = Console.ReadLine();
                Console.Write("Confirmar senha: ");
                senha2 = Console.ReadLine();
                senhac = senha1.ToUpper();
                while (senha1 != senha2)
                {
                    Console.Write("Senha inválida. digite sua senha novamente: ");
                    senha1 = Console.ReadLine();
                    Console.Write("Confirmar senha: ");
                    senha2 = Console.ReadLine();
                    senhac = senha1.ToUpper();
                }
                while (nomec == senhac)
                {
                    Console.WriteLine("A senha não pode ser igual a o nome do Usuario.");
                    Console.WriteLine("Você deseja corrigir o: \n [1] Nome do usuario \n [2] Senha \n [3] Os dois");
                    escolha = int.Parse(Console.ReadLine());
                    while (escolha != 1 && escolha != 2 && escolha != 3)
                    {
                        Console.WriteLine("Resposta inválida.");
                        Console.WriteLine("Você deseja corrigir o: \n [1] Nome do usuario \n [2] Senha \n [3] Os dois");
                        escolha = int.Parse(Console.ReadLine());
                    }
                    switch (escolha)
                    {
                        case 1:
                            Console.Write("Insira o nome do usuario: ");
                            nome = Console.ReadLine();
                            nomec = nome.ToUpper();
                            break;
                        case 2:
                            Console.Write("Insira uma senha: ");
                            senha1 = Console.ReadLine();
                            Console.Write("Confirmar senha: ");
                            senha2 = Console.ReadLine();
                            senhac = senha1.ToUpper();
                            while (senha1 != senha2)
                                {
                                    Console.Write("Senha inválida. digite sua senha novamente: ");
                                    senha1 = Console.ReadLine();
                                    Console.Write("Confirmar senha: ");
                                    senha2 = Console.ReadLine();
                                    senhac = senha1.ToUpper();
                                }
                            break;
                        case 3:
                            Console.Write("Insira o nome do usuario: ");
                            nome = Console.ReadLine();
                            nomec = nome.ToUpper();
                            Console.Write("Insira uma senha: ");
                            senha1 = Console.ReadLine();
                            Console.Write("Confirmar senha: ");
                            senha2 = Console.ReadLine();
                            senhac = senha1.ToUpper();
                            break;
                    }
                    Console.WriteLine($"------------------------ \n Usuario: {nome} \n Senha: {senha1} \n ------------------------");
                }
                Console.WriteLine("Você deseja cadastrar um outro usuário? \n [1] Para cadastrar um novo usuairio \n Qualquer número para finalizar");
                rep = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("FIM.");
        }
    }
}
