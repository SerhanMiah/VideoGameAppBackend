    using System;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using VideoGameAppBackend.Models;

    namespace VideoGameAppBackend.Data.SeedData
    {
        public class GameSeedData
        {
            public static void Seed(ModelBuilder builder)
            {
                var games = new List<Game>
                {
                    // PC Games
                    new Game 
                    { 
                        Id = 1, 
                        Title = "Cyberpunk 2077",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2020, 12, 10),
                        Description = "Cyberpunk 2077 is an open-world, action-adventure story set in Night City.",
                        Genre = GameGenre.OpenWorld.ToString(), 
                        Platform = GamePlatform.PC.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=ixl31324UxE"
                    },
                    new Game 
                    { 
                        Id = 2, 
                        Title = "Minecraft",
                        Price = 26.95m,
                        ReleaseDate = new DateTime(2011, 11, 18),
                        Description = "Minecraft is a sandbox video game developed by Mojang.", 
                        Genre = GameGenre.Sandbox.ToString(), 
                        Platform = GamePlatform.PC.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=MmB9b5njVbA"
                    },
                    new Game 
                    { 
                        Id = 3, 
                        Title = "The Witcher 3: Wild Hunt",
                        Price = 39.99m,
                        ReleaseDate = new DateTime(2015, 5, 19),
                        Description = "The Witcher 3: Wild Hunt is a story-driven, open world adventure set in a dark fantasy universe.", 
                        Genre = GameGenre.RolePlaying.ToString(), 
                        Platform = GamePlatform.PC.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=HtVdAasjOgU"
                    },

                    // PlayStation5 Games
                    new Game 
                    { 
                        Id = 4,
                        Title = "Demon's Souls",
                        Price = 69.99m, 
                        ReleaseDate = new DateTime(2020, 11, 12),
                        Description = "From PlayStation Studios and Bluepoint Games comes a remake of the PlayStation classic.",
                        Genre = GameGenre.Action.ToString(), 
                        Platform = GamePlatform.PlayStation5.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=jGUtTPRuGak"
                    },
                    new Game 
                    { 
                        Id = 5, 
                        Title = "Ratchet & Clank: Rift Apart", 
                        Price = 69.99m, 
                        ReleaseDate = new DateTime(2021, 6, 11), 
                        Description = "Join Ratchet and Clank as they take on an evil emperor from another reality.",
                        Genre = GameGenre.Adventure.ToString(),
                        Platform = GamePlatform.PlayStation5.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=ai3o0XtrnM8"
                    },
                    new Game 
                    { 
                        Id = 6, 
                        Title = "Returnal", 
                        Price = 69.99m, 
                        ReleaseDate = new DateTime(2021, 4, 30), 
                        Description = "Returnal transforms roguelike gameplay into a third-person shooter where players fight to survive a hostile planet that changes with every death.",
                        Genre = GameGenre.Roguelike.ToString(), 
                        Platform = GamePlatform.PlayStation5.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=Jv4BjWoB-NA"
                    },

                    // PlayStation4 Games
                    new Game 
                    { 
                        Id = 7, 
                        Title = "The Last of Us Part II", 
                        Price = 59.99m, 
                        ReleaseDate = new DateTime(2020, 6, 19), 
                        Description = "Set five years after The Last of Us, players control an older Ellie who comes into conflict with a mysterious cult in a post-apocalyptic United States.",
                        Genre = GameGenre.Adventure.ToString(), 
                        Platform = GamePlatform.PlayStation4.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=btmN-bWwv0A"
                    },
                    new Game 
                    { 
                        Id = 8, 
                        Title = "God of War", 
                        Price = 19.99m, 
                        ReleaseDate = new DateTime(2018, 4, 20), 
                        Description = "God of War is an action-adventure game developed by Santa Monica Studio and published by Sony Interactive Entertainment.",
                        Genre = GameGenre.Action.ToString(), 
                        Platform = GamePlatform.PlayStation4.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=K0u_kAWLJOA"
                    },
                    new Game 
                    { 
                        Id = 9, 
                        Title = "Uncharted 4: A Thief's End", 
                        Price = 19.99m, 
                        ReleaseDate = new DateTime(2016, 5, 10), 
                        Description = "Uncharted 4: A Thief's End is an action-adventure game developed by Naughty Dog and published by Sony Interactive Entertainment.",
                        Genre = GameGenre.Adventure.ToString(), 
                        Platform = GamePlatform.PlayStation4.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=hh5HV4iic1Y"
                    },

                    // XboxOne Games
                    new Game 
                    { 
                        Id = 10, 
                        Title = "Forza Horizon 4", 
                        Price = 59.99m, 
                        ReleaseDate = new DateTime(2018, 10, 2), 
                        Description = "Forza Horizon 4 is a racing video game set in an open world environment based in a fictional representation of areas of Great Britain.",
                        Genre = GameGenre.Racing.ToString(), 
                        Platform = GamePlatform.XboxOne.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=VmQNo8xtcAg"
                    },
                    new Game 
                    { 
                        Id = 11, 
                        Title = "Halo 5: Guardians", 
                        Price = 19.99m, 
                        ReleaseDate = new DateTime(2015, 10, 27), 
                        Description = "Halo 5: Guardians is a first-person shooter video game developed by 343 Industries and published by Microsoft Studios.",
                        Genre = GameGenre.Shooter.ToString(), 
                        Platform = GamePlatform.XboxOne.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=9rd8FWUCCZk"
                    },
                    new Game 
                    { 
                        Id = 12, 
                        Title = "Gears of War 4", 
                        Price = 19.99m, 
                        ReleaseDate = new DateTime(2016, 10, 11), 
                        Description = "Gears of War 4 is a third-person shooter video game developed by The Coalition and published by Microsoft Studios.",
                        Genre = GameGenre.ThirdPersonShooter.ToString(), 
                        Platform = GamePlatform.XboxOne.ToString(), 
                        TrailerUrl = "https://www.youtube.com/watch?v=o3f8VgQ_dqk"
                    },
                    // PC Games
                    new Game
                    {
                        Id = 13,
                        Title = "Assassin's Creed Valhalla",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2020, 11, 10),
                        Description = "Assassin's Creed Valhalla is an action role-playing game set in the Viking Age.",
                        Genre = GameGenre.RolePlaying.ToString(),
                        Platform = GamePlatform.PC.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=ssrBGE1g6g8"
                    },
                    new Game
                    {
                        Id = 14,
                        Title = "Death Stranding",
                        Price = 39.99m,
                        ReleaseDate = new DateTime(2020, 7, 14),
                        Description = "Death Stranding is an action game set in an open world, with multiplayer functions.",
                        Genre = GameGenre.Action.ToString(),
                        Platform = GamePlatform.PC.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=piIgkJWDuQg"
                    },
                    new Game
                    {
                        Id = 15,
                        Title = "Grand Theft Auto V",
                        Price = 29.99m,
                        ReleaseDate = new DateTime(2013, 9, 17),
                        Description = "Grand Theft Auto V is an action-adventure game played from either a first-person or third-person perspective.",
                        Genre = GameGenre.Adventure.ToString(),
                        Platform = GamePlatform.PC.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=QkkoHAzjnUs"
                    },

                    // PlayStation5 Games
                    new Game
                    {
                        Id = 16,
                        Title = "Marvel's Spider-Man: Miles Morales",
                        Price = 49.99m,
                        ReleaseDate = new DateTime(2020, 11, 12),
                        Description = "Marvel's Spider-Man: Miles Morales is an action-adventure game based on the Marvel Comics superhero Miles Morales.",
                        Genre = GameGenre.Adventure.ToString(),
                        Platform = GamePlatform.PlayStation5.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=NTunTURbyUU"
                    },
                    new Game
                    {
                        Id = 17,
                        Title = "Resident Evil Village",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2021, 5, 7),
                        Description = "Resident Evil Village is a survival horror game and the eighth main installment in the Resident Evil series.",
                        Genre = GameGenre.Horror.ToString(),
                        Platform = GamePlatform.PlayStation5.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=oxZ4mqV0wGQ"
                    },
                    new Game
                    {
                        Id = 18,
                        Title = "Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2021, 10, 15),
                        Description = "Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles is an anime-based action game.",
                        Genre = GameGenre.Action.ToString(),
                        Platform = GamePlatform.PlayStation5.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=iXv_Rw9A4RU"
                    },

                    // Xbox Series X/S Games
                    new Game
                    {
                        Id = 19,
                        Title = "FIFA 22",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2021, 10, 1),
                        Description = "FIFA 22 is a football simulation video game and the latest installment in the FIFA series.",
                        Genre = GameGenre.Sports.ToString(),
                        Platform = GamePlatform.XboxSeriesX.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=WRznO7KYSP4"
                    },
                    new Game
                    {
                        Id = 20,
                        Title = "Hades",
                        Price = 29.99m,
                        ReleaseDate = new DateTime(2021, 8, 13),
                        Description = "Hades is a roguelike action role-playing game where players control the prince of the underworld.",
                        Genre = GameGenre.RolePlaying.ToString(),
                        Platform = GamePlatform.XboxSeriesX.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=NOGUK4EyZgk"
                    },
                    new Game
                    {
                        Id = 21,
                        Title = "Psychonauts 2",
                        Price = 59.99m,
                        ReleaseDate = new DateTime(2021, 8, 25),
                        Description = "Psychonauts 2 is a platforming game and the sequel to the original Psychonauts.",
                        Genre = GameGenre.Action.ToString(),
                        Platform = GamePlatform.XboxSeriesX.ToString(),
                        TrailerUrl = "https://www.youtube.com/watch?v=ssrBGE1g6g8"
                    },
                // PC Games
                new Game
                {
                    Id = 22,
                    Title = "The Elder Scrolls V: Skyrim",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2011, 11, 11),
                    Description = "The Elder Scrolls V: Skyrim is an open-world action role-playing game developed by Bethesda Game Studios.",
                    Genre = GameGenre.RolePlaying.ToString(),
                    Platform = GamePlatform.PC.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=PjqsYzBrP-M"
                },
                new Game
                {
                    Id = 23,
                    Title = "World of Warcraft",
                    Price = 14.99m,
                    ReleaseDate = new DateTime(2004, 11, 23),
                    Description = "World of Warcraft is a massively multiplayer online role-playing game set in the Warcraft fantasy universe.",
                    Genre = GameGenre.RolePlaying.ToString(),
                    Platform = GamePlatform.PC.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=jSJr3dXZfcg"
                },
                new Game
                {
                    Id = 24,
                    Title = "Fallout 4",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2015, 11, 10),
                    Description = "Fallout 4 is an open-world action role-playing game developed by Bethesda Game Studios.",
                    Genre = GameGenre.RolePlaying.ToString(),
                    Platform = GamePlatform.PC.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=D5esyZPt5Jo"
                },

                // PlayStation5 Games
                new Game
                {
                    Id = 25,
                    Title = "Horizon Forbidden West",
                    Price = 69.99m,
                    ReleaseDate = new DateTime(2022, 2, 18),
                    Description = "Horizon Forbidden West is an action role-playing game and the sequel to Horizon Zero Dawn.",
                    Genre = GameGenre.Action.ToString(),
                    Platform = GamePlatform.PlayStation5.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=Lq594XmpPBg"
                },
                new Game
                {
                    Id = 26,
                    Title = "Ghost of Tsushima",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2020, 7, 17),
                    Description = "Ghost of Tsushima is an action-adventure game set in feudal Japan.",
                    Genre = GameGenre.Action.ToString(),
                    Platform = GamePlatform.PlayStation5.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=hRxZQqo5k7I"
                },
                new Game
                {
                    Id = 27,
                    Title = "Final Fantasy VII Remake",
                    Price = 69.99m,
                    ReleaseDate = new DateTime(2020, 4, 10),
                    Description = "Final Fantasy VII Remake is a role-playing game and a remake of the 1997 game Final Fantasy VII.",
                    Genre = GameGenre.RolePlaying.ToString(),
                    Platform = GamePlatform.PlayStation5.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=0wAHEVUwZk4"
                },

                // Xbox Series X/S Games
                new Game
                {
                    Id = 28,
                    Title = "Gears 5",
                    Price = 39.99m,
                    ReleaseDate = new DateTime(2019, 9, 10),
                    Description = "Gears 5 is a third-person shooter game developed by The Coalition.",
                    Genre = GameGenre.ThirdPersonShooter.ToString(),
                    Platform = GamePlatform.XboxSeriesX.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=o3f8VgQ_dqk"
                },
                new Game
                {
                    Id = 29,
                    Title = "Ori and the Will of the Wisps",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2020, 3, 11),
                    Description = "Ori and the Will of the Wisps is a platform-adventure Metroidvania game.",
                    Genre = GameGenre.Adventure.ToString(),
                    Platform = GamePlatform.XboxSeriesX.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=2zM8LclFhFw"
                },
                new Game
                {
                    Id = 30,        
                    Title = "Sea of Thieves",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2018, 3, 20),
                    Description = "Sea of Thieves is an action-adventure game set in an open world multiplayer environment.",
                    Genre = GameGenre.Adventure.ToString(),
                    Platform = GamePlatform.XboxSeriesX.ToString(),
                    TrailerUrl = "https://www.youtube.com/watch?v=r5JlZLCVAg0"
                }

                                

                };

                foreach (var game in games)
                {
                    builder.Entity<Game>().HasData(game);
                }
            }
        }
    }