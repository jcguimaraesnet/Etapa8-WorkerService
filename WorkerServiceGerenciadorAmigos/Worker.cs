using Dominio.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerServiceGerenciadorAmigos
{
    public class Worker : BackgroundService
    {
        private IAmigoRepositorio _repositorio;

        public Worker(IAmigoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            Console.WriteLine("Executando repositório");
            _repositorio.AdicionarAmigo();
            Console.WriteLine("Executado repositório!");
        }
    }
}
