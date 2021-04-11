using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerAPIBackgroudServices.Services
{
    public class BackgroundInfoWorker : IHostedService, IDisposable
    {
        private Timer _timer;
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(" ********************** Iniciando Processamento em Backgroud. ************************* ");

            _timer = new Timer(DoWork, null, TimeSpan.Zero, TimeSpan.FromSeconds(2));
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine(" ********************** Parando Processamento em Backgroud. **********************");
            return Task.CompletedTask;
        }


        private void DoWork(object state)
        {
            //.....SERVIÇO EM BACKGROUD exemplo como:  LENDO FILA MessageBrocker, repositorios, comunicação em API...etc..
            Console.WriteLine($"Processamento em Execução - {DateTime.UtcNow:o}");
        }
        public void Dispose() => _timer?.Dispose();

    }
}
