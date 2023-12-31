using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMoto.Data;
using System;
using System.Linq;

namespace MvcMoto.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMotoContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMotoContext>>()))
        {
 
            if (context.Moto.Any())
            {
                return;   // Database has been seeded
            }
            context.Moto.AddRange(
                new Moto
                {
                    Name = "Max Verstappen",
                    Circuit = "F1",
                    Team = "Red Bull Racing",
                    WorldRank = 1,
                    DriverNumber = "11"
                },

                new Moto
                {
                    Name = "Daniel Ricciardo",
                    Circuit = "F1",
                    Team = "Alpha Tauri",
                    WorldRank = 5,
                    DriverNumber = "48"
                },

                new Moto
                {
                    Name = "George Russel",
                    Circuit = "F1",
                    Team = "AMG Mercedes",
                    WorldRank = 4,
                    DriverNumber = "25"
                                    },

                new Moto
                {
                    Name = "Lando Norris",
                    Circuit = "F1",
                    Team = "McLaren",
                    WorldRank = 8,
                    DriverNumber = "5"
                }
            );
            context.SaveChanges();
        }
    }
}

