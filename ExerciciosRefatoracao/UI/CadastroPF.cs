﻿using ExerciciosRefatoracao.Dominio;
using ExerciciosRefatoracao.Repository;

namespace ExerciciosRefatoracao.UI
{
    public class CadastroPF
    {
        ClienteRepository _repository;
        public CadastroPF(ClienteRepository repository) { this._repository = repository; }

        public void Load()
        {
            Cliente cli = new Cliente();
            var endCobranca = cli.CriarEndereco();
            var endFatura = cli.CriarEndereco();
            var endEntrega = cli.CriarEndereco();

            Console.Write("Nº CPF: ");
            cli.CPF = Console.ReadLine();
            Console.Write("Nome Cliente: ");
            cli.Nome = Console.ReadLine();
                        
            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Cobrança **************");
            Console.Write("Logradouro: ");
            string logradouro = Console.ReadLine();
            Console.Write("Número: ");
            string numero = Console.ReadLine();
            Console.Write("Complemento: ");
            string complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("CEP: ");
            string CEP = Console.ReadLine();
            Console.Write("Municipio: ");
            string municipio = Console.ReadLine();
            Console.Write("UF: ");
            string UF = Console.ReadLine();

            endCobranca.SetEndereco("Cobrança",logradouro, numero, complemento, bairro, CEP, municipio, UF);

            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Entrega **************");

            Console.WriteLine("Logradouro: ");
            logradouro = Console.ReadLine();
            Console.Write("Número: ");
            numero = Console.ReadLine();
            Console.Write("Complemento: ");
            complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            bairro = Console.ReadLine();
            Console.Write("CEP: ");
            CEP = Console.ReadLine();
            Console.Write("Municipio: ");
            municipio = Console.ReadLine();
            Console.Write("UF: ");
            UF = Console.ReadLine();

            endEntrega.SetEndereco("Entrega",logradouro, numero, complemento, bairro, CEP, municipio, UF);

            Console.WriteLine("");
            Console.WriteLine("********* Informe abaixo o Endereço de Faturamento **************");
            Console.WriteLine("Logradouro: ");
            logradouro = Console.ReadLine();
            Console.Write("Número: ");
            numero = Console.ReadLine();
            Console.Write("Complemento: ");
            complemento = Console.ReadLine();
            Console.Write("Bairro: ");
            bairro = Console.ReadLine();
            Console.Write("CEP: ");
            CEP = Console.ReadLine();
            Console.Write("Municipio: ");
            municipio = Console.ReadLine();
            Console.Write("UF: ");
            UF = Console.ReadLine();

            endFatura.SetEndereco("Faturamento", logradouro, numero, complemento, bairro, CEP, municipio, UF);

            Console.WriteLine("Salvar Cliente (S/N)?");

            string op = Console.ReadLine();

            if (op.Equals("S"))
            {
                _repository.Add(cli);
                Console.WriteLine("Cliente Salvo com sucesso !!");
            }

            //Com mais tempo deixaria esse limpíssimo
        }
    }
}
