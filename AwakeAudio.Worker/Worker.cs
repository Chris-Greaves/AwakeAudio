namespace AwakeAudio.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly AwakeAudioService _audioService;

        public Worker(ILogger<Worker> logger, AwakeAudioService audioService)
        {
            _logger = logger;
            _audioService = audioService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Awake Audio service starting at {0}", DateTime.UtcNow.ToString());
            while (!stoppingToken.IsCancellationRequested)
            {
                _audioService.PlayAwakeSound();
                await Task.Delay(1000, stoppingToken);
            }
            _logger.LogInformation("Awake Audio service stopped at {0}", DateTime.UtcNow.ToString());
        }
    }
}