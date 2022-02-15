using AwakeAudio.Worker;

IHost host = Host.CreateDefaultBuilder(args)
    .UseWindowsService(options =>
    {
        options.ServiceName = "Awake Audio";
    })
    .ConfigureServices(services =>
    {
        services.AddSingleton<AwakeAudioService>();
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
