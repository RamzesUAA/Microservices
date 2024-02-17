using CommandsService.Models;
using CommandsService.SyncDataServices.Grps;

namespace CommandsService.Data;

public static class PrepDb
{
    public static void PrepPopulation(IApplicationBuilder applicationBuilder)
    {
        using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
        {
            var grpcClient = serviceScope.ServiceProvider.GetService<IPlatformDataClient>();
            System.Console.WriteLine("--> grpcClient");
            var platforms = grpcClient.ReturnAllPlatform();
            SeedData(serviceScope.ServiceProvider.GetService<ICommandRepo>(), platforms);
        }
    }

    private static void SeedData(ICommandRepo repo, IEnumerable<Platform> platforms)
    {
        System.Console.WriteLine("Seeding new platforms...");

        foreach (var plat in platforms)
        {
            if (!repo.ExternalPlatformExists(plat.ExternalID))
            {
                repo.CreatePlatform(plat);
            }

            repo.SaveChanges();
        }
    }
}