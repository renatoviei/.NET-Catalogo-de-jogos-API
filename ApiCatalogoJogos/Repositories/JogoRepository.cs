using ApiCatalogoJogos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private static Dictionary<Guid, Jogo> jogos = new Dictionary<Guid, Jogo>()
        {
            {Guid.Parse("0f5e5d99-c4b6-471d-a51b-fe526c91c105"), new Jogo{ Id = Guid.Parse("0f5e5d99-c4b6-471d-a51b-fe526c91c105"), Nome = "Grand Chase", Produtora = "KOG", Preco = 200} },
            {Guid.Parse("3392f1ea-5cf9-43a4-b5f4-91dbdb8b003c"), new Jogo{ Id = Guid.Parse("3392f1ea-5cf9-43a4-b5f4-91dbdb8b003c"), Nome = "Mortal Kombat", Produtora = "NetherRealm Studios", Preco = 80} },
            {Guid.Parse("5a9b1849-57b8-489d-a988-4910b1e2bbc3"), new Jogo{ Id = Guid.Parse("5a9b1849-57b8-489d-a988-4910b1e2bbc3"), Nome = "Injustice", Produtora = "NetherRealm Studios", Preco = 150} },
            {Guid.Parse("2d91a70e-3303-4d71-9f70-c5adc6e20feb"), new Jogo{ Id = Guid.Parse("2d91a70e-3303-4d71-9f70-c5adc6e20feb"), Nome = "Need For Speed", Produtora = "EA", Preco = 120} },
            {Guid.Parse("e1b97fcd-5008-494e-b89e-47a53eb2717b"), new Jogo{ Id = Guid.Parse("e1b97fcd-5008-494e-b89e-47a53eb2717b"), Nome = "FIFA 2021", Produtora = "EA", Preco = 145} },
            {Guid.Parse("f0d4cb89-03b5-4e0b-8757-aaddbf77514f"), new Jogo{ Id = Guid.Parse("f0d4cb89-03b5-4e0b-8757-aaddbf77514f"), Nome = "League of Legends", Produtora = "Riot", Preco = 115} }

        };
        public Task<List<Jogo>> Obter(int pagina, int quantidade)
        {
            return Task.FromResult(jogos.Values.Skip((pagina - 1) * quantidade).Take(quantidade).ToList());
        }

        public Task<Jogo> Obter(Guid id)
        {
            if (!jogos.ContainsKey(id))
                return null;

            return Task.FromResult(jogos[id]);
        }

        public Task<List<Jogo>> Obter(string nome, string produtora)
        {
            return Task.FromResult(jogos.Values.Where(jogo => jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora)).ToList());
        }

        public Task<List<Jogo>> ObterSemLambida(string nome, string produtora)
        {
            var retorno = new List<Jogo>();

            foreach (var jogo in jogos.Values)
            {
                if (jogo.Nome.Equals(nome) && jogo.Produtora.Equals(produtora))
                    retorno.Add(jogo);
            }

            return Task.FromResult(retorno);
        }

        public Task Inserir(Jogo jogo)
        {
            jogos.Add(jogo.Id, jogo);
            return Task.CompletedTask;
        }

        public Task Atualizar(Jogo jogo)
        {
            jogos[jogo.Id] = jogo;
            return Task.CompletedTask;
        }

        public Task Remover(Guid id)
        {
            jogos.Remove(id);
            return Task.CompletedTask;
        }

        public void Dispose()
        {
            //Não é utilizado para finalizar conexão pois nesse repositório o 'banco' foi mockado
        }
    }
}
