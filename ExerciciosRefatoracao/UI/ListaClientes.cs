﻿using ExerciciosRefatoracao.Repository;

namespace ExerciciosRefatoracao.UI
{
    public class ListaClientes
    {
        ClienteRepository _repository;

        public ListaClientes(ClienteRepository repository)
        {
            this._repository = repository;
        }

        public void Load()
        {

            var clientes = _repository.obterTodosClientes();
            if(clientes != null && clientes.Count > 0)
            {
                foreach (var item in clientes)
                {
                    Console.WriteLine("");
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("A consulta não retornou dados.");
            }
            Console.ReadKey();
        }
    }
}
