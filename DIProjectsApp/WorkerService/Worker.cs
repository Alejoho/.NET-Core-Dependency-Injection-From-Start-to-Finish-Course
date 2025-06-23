using DIDemoLib;

namespace WorkerService;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IMessages _messages;

    public Worker(ILogger<Worker> logger, IMessages messages)
    {
        _logger = logger;
        _messages = messages;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            if (_logger.IsEnabled(LogLevel.Information))
            {
                _logger.LogError("Worker running at: {time}", DateTimeOffset.Now);
                _logger.LogInformation(_messages.SayHello());
                _logger.LogInformation(_messages.SayGoodBye());
            }
            await Task.Delay(1000, stoppingToken);
        }
    }
}
