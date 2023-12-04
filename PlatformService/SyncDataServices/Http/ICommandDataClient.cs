namespace PlatformeService;

public interface ICommandDataClient
{
    Task SendPlatformToCommand(PlatformReadDto plat);
}

