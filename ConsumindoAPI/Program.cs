using ConsumindoAPI.Entities;
using ConsumindoAPI.Entities.Sevices;

namespace ConsumindoAPI
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Sistema para consumir API");

            Console.WriteLine("Por favor, infome o id do contato: ");
            int id = int.Parse(Console.ReadLine());

            ContatoServices contatoServices = new ContatoServices();
            Contato contatoEncontrado = await contatoServices.Integracao(id);

            if(!contatoEncontrado.Verificacao)
            {
                Console.WriteLine("Contato encontrado");

                Console.WriteLine($"Nome: {contatoEncontrado.Nome}");
                Console.WriteLine($"Telefone: {contatoEncontrado.Telefone}");
                Console.WriteLine($"Ativo: {contatoEncontrado.Ativo}");
                Console.WriteLine($"Verificação: {contatoEncontrado.Verificacao}");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }
    }
}