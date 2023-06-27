using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;
using VideoGameAppBackend.Models.Product;

namespace VideoGameAppBackend.Data.SeedData
{
    public static class GameSeedData
    {
        public static void Seed(ModelBuilder builder)
        {
            // Age Ratings
            var ageRatings = new List<AgeRating>
            {
                new AgeRating { Id = 1, Rating = "Everyone" },
                new AgeRating { Id = 2, Rating = "Mature" },
                new AgeRating { Id = 3, Rating = "Teen" },
                new AgeRating { Id = 4, Rating = "Adults Only" },
                new AgeRating { Id = 5, Rating = "Everyone 10+" }
            };

            builder.Entity<AgeRating>().HasData(ageRatings);

            // Game Genres
            var gameGenres = new List<Genre>
            {
                new Genre { Id = 1, Name = "Open World" },
                new Genre { Id = 2, Name = "Role Playing" },
                new Genre { Id = 3, Name = "Action" },
                new Genre { Id = 4, Name = "Adventure" },
                new Genre { Id = 5, Name = "Strategy" }
            };

            builder.Entity<Genre>().HasData(gameGenres);

            // Game Platforms
            var gamePlatforms = new List<Platform>
            {
                new Platform { Id = 1, Name = "PC" },
                new Platform { Id = 2, Name = "PlayStation 5" },
                new Platform { Id = 3, Name = "Xbox Series X" },
                new Platform { Id = 4, Name = "Nintendo Switch" },
                new Platform { Id = 5, Name = "Mobile" }
            };

            builder.Entity<Platform>().HasData(gamePlatforms);

            // Games
            var games = new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Title = "Cyberpunk 2077",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2020, 12, 10),
                    Description = "Cyberpunk 2077 is an open-world, action-adventure story set in Night City.",
                    TrailerUrl = "https://www.youtube.com/watch?v=ixl31324UxE",
                    Developer = "CD Projekt Red",
                    AverageRating = 4.2,
                    MinimumSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i5-3570K or AMD FX-8310, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 780 3GB or AMD Radeon RX 470, Storage: 70 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-4790 or AMD Ryzen 3 3200G, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon R9 Fury, Storage: SSD + 70 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2
                },
                new Game
                {
                    Id = 2,
                    Title = "The Witcher 3: Wild Hunt",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2015, 5, 19),
                    Description = "The Witcher 3: Wild Hunt is a role-playing game set in an open-world fantasy universe.",
                    TrailerUrl = "https://www.youtube.com/watch?v=c0i88t0Kacs",
                    Developer = "CD Projekt Red",
                    AverageRating = 4.8,
                    MinimumSystemRequirements = "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 6 GB RAM, Graphics: NVIDIA GeForce GTX 660 or AMD Radeon HD 7870, Storage: 35 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i7-3770 3.4 GHz or AMD FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 290, Storage: 35 GB available space",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2
                },
                new Game
                {
                    Id = 3,
                    Title = "Red Dead Redemption 2",
                    Price = 49.99m,
                    ReleaseDate = new DateTime(2018, 10, 26),
                    Description = "Red Dead Redemption 2 is an epic tale of life in America's unforgiving heartland.",
                    TrailerUrl = "https://www.youtube.com/watch?v=Dw_oH5oiUSE",
                    Developer = "Rockstar Games",
                    AverageRating = 4.9,
                    MinimumSystemRequirements = "OS: Windows 7 or 8 (64-bit), Processor: Intel Core i5-2500K 3.3 GHz or AMD Phenom II X4 940, Memory: 8 GB RAM, Graphics: NVIDIA GeForce GTX 770 or AMD Radeon R9 280, Storage: 150 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-4770K 3.5 GHz or AMD Ryzen 5 1500X 3.5 GHz, Memory: 12 GB RAM, Graphics: NVIDIA GeForce GTX 1060 6GB or AMD Radeon RX 480 4GB, Storage: 150 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 2
                },
                new Game
                {
                    Id = 4,
                    Title = "The Legend of Zelda: Breath of the Wild",
                    Price = 59.99m,
                    ReleaseDate = new DateTime(2017, 3, 3),
                    Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game set in an open world.",
                    TrailerUrl = "https://www.youtube.com/watch?v=zw47_q9wbBE",
                    Developer = "Nintendo",
                    AverageRating = 4.7,
                    MinimumSystemRequirements = "N/A",
                    RecommendedSystemRequirements = "N/A",
                    HasMultiplayerSupport = false,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 1
                },
                new Game
                {
                    Id = 5,
                    Title = "Grand Theft Auto V",
                    Price = 29.99m,
                    ReleaseDate = new DateTime(2013, 9, 17),
                    Description = "Grand Theft Auto V is an action-adventure game set in an open world.",
                    TrailerUrl = "https://www.youtube.com/watch?v=3DBrG2YjqQA",
                    Developer = "Rockstar North",
                    AverageRating = 4.7,
                    MinimumSystemRequirements = "OS: Windows 7 (64-bit), Processor: Intel Core 2 Quad CPU Q6600 2.4 GHz or AMD Phenom 9850 Quad-Core Processor 2.5 GHz, Memory: 4 GB RAM, Graphics: NVIDIA 9800 GT 1GB or AMD HD 4870 1GB, Storage: 72 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i5 3470 3.2 GHz or AMD X8 FX-8350 4 GHz, Memory: 8 GB RAM, Graphics: NVIDIA GTX 660 2GB or AMD HD7870 2GB, Storage: 72 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 1,
                    DiscountedPrice = null,
                    AgeRatingId = 4
                },
                new Game
                {
                    Id = 6,
                    Title = "Minecraft",
                    Price = 26.99m,
                    ReleaseDate = new DateTime(2011, 11, 18),
                    Description = "Minecraft is a sandbox game that allows players to build and explore virtual worlds.",
                    TrailerUrl = "https://www.youtube.com/watch?v=92AoX5OyiU4",
                    Developer = "Mojang Studios",
                    AverageRating = 4.5,
                    MinimumSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i5-4690 or AMD A10-7800 or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 700 Series or AMD Radeon Rx 200 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space",
                    RecommendedSystemRequirements = "OS: Windows 10 (64-bit), Processor: Intel Core i7-6500U or AMD A8-6600K or equivalent, Memory: 8 GB RAM, Graphics: NVIDIA GeForce 900 Series or AMD Radeon Rx 300 Series or equivalent with OpenGL 4.5 support, Storage: 4 GB available space",
                    HasMultiplayerSupport = true,
                    NumberOfLocalPlayers = 4,
                    DiscountedPrice = null,
                    AgeRatingId = 1
                }
            };

            builder.Entity<Game>().HasData(games);

            // DLCs
            var dlcs = new List<DLC>
            {
                // DLCs for "The Witcher 3: Wild Hunt"
                new DLC
                {
                    Id = 1,
                    DLCName = "The Witcher 3: Hearts of Stone",
                    ReleaseDate = new DateTime(2015, 10, 13),
                    Price = 9.99m,
                    Description = "Embark on a new adventure as Geralt of Rivia in the Hearts of Stone expansion.",
                    GameId = 2
                },
                new DLC
                {
                    Id = 2,
                    DLCName = "The Witcher 3: Blood and Wine",
                    ReleaseDate = new DateTime(2016, 5, 31),
                    Price = 19.99m,
                    Description = "Visit the picturesque land of Toussaint in the Blood and Wine expansion.",
                    GameId = 2
                },
                // DLCs for "Red Dead Redemption 2"
                new DLC
                {
                    Id = 3,
                    DLCName = "Red Dead Redemption 2: Undead Nightmare",
                    ReleaseDate = new DateTime(2022, 10, 25),
                    Price = 14.99m,
                    Description = "Experience an undead nightmare in the world of Red Dead Redemption 2.",
                    GameId = 3
                },
                new DLC
                {
                    Id = 4,
                    DLCName = "Red Dead Redemption 2: The Ballad of Gay Tony",
                    ReleaseDate = new DateTime(2023, 2, 28),
                    Price = 9.99m,
                    Description = "Join the high-stakes world of nightclub entertainment in The Ballad of Gay Tony DLC.",
                    GameId = 3
                },
                // DLCs for "The Legend of Zelda: Breath of the Wild"
                new DLC
                {
                    Id = 5,
                    DLCName = "The Legend of Zelda: Breath of the Wild - Expansion Pass",
                    ReleaseDate = new DateTime(2017, 6, 30),
                    Price = 19.99m,
                    Description = "Expand your adventure with two DLC packs for The Legend of Zelda: Breath of the Wild.",
                    GameId = 4
                },
                new DLC
                {
                    Id = 6,
                    DLCName = "The Legend of Zelda: Breath of the Wild - The Champions' Ballad",
                    ReleaseDate = new DateTime(2017, 12, 7),
                    Price = 9.99m,
                    Description = "Embark on a new quest and discover the story of the champions in The Champions' Ballad DLC.",
                    GameId = 4
                },
                // DLCs for "Grand Theft Auto V"
                new DLC
                {
                    Id = 7,
                    DLCName = "Grand Theft Auto V: The Diamond Casino Heist",
                    ReleaseDate = new DateTime(2019, 12, 12),
                    Price = 9.99m,
                    Description = "Plan and execute the most daring heist in the history of Los Santos in The Diamond Casino Heist DLC.",
                    GameId = 5
                },
                new DLC
                {
                    Id = 8,
                    DLCName = "Grand Theft Auto V: The Cayo Perico Heist",
                    ReleaseDate = new DateTime(2020, 12, 15),
                    Price = 14.99m,
                    Description = "Infiltrate the remote island of Cayo Perico and pull off a monumental heist in The Cayo Perico Heist DLC.",
                    GameId = 5
                },
                // DLCs for "Minecraft"
                new DLC
                {
                    Id = 9,
                    DLCName = "Minecraft: Nether Update",
                    ReleaseDate = new DateTime(2020, 6, 23),
                    Price = 4.99m,
                    Description = "Explore the dangerous Nether dimension with new mobs, biomes, and materials in the Nether Update DLC.",
                    GameId = 6
                },
                new DLC
                {
                    Id = 10,
                    DLCName = "Minecraft: Caves & Cliffs Update",
                    ReleaseDate = new DateTime(2021, 6, 8),
                    Price = 9.99m,
                    Description = "Discover new cave systems, mountain biomes, and blocks in the Caves & Cliffs Update DLC.",
                    GameId = 6
                }
            };

            builder.Entity<DLC>().HasData(dlcs);

            // DLC Images
            var dlcImages = new List<DLCImage>
            {
                // DLC Images for "The Witcher 3: Hearts of Stone"
                new DLCImage
                {
                    Id = 1,
                    ImageUrl = "https://static.wikia.nocookie.net/witcher/images/0/09/Tw3_expansion_pack_hos.jpg/revision/latest?cb=20150908190146",
                    Caption = "The Witcher 3: Hearts of Stone DLC Image",
                    DLCId = 1
                },
                new DLCImage
                {
                    Id = 2,
                    ImageUrl = "https://static.wikia.nocookie.net/witcher/images/8/89/Tw3_Blood_and_Wine_cover_art.jpg/revision/latest?cb=20160414142032",
                    Caption = "The Witcher 3: Blood and Wine DLC Image",
                    DLCId = 2
                },
                // DLC Images for "Red Dead Redemption 2: Undead Nightmare"
                new DLCImage
                {
                    Id = 3,
                    ImageUrl = "https://example.com/dlc_image_3.jpg",
                    Caption = "Red Dead Redemption 2: Undead Nightmare DLC Image",
                    DLCId = 3
                },
                new DLCImage
                {
                    Id = 4,
                    ImageUrl = "https://example.com/dlc_image_4.jpg",
                    Caption = "Red Dead Redemption 2: The Ballad of Gay Tony DLC Image",
                    DLCId = 4
                },
                // DLC Images for "The Legend of Zelda: Breath of the Wild - Expansion Pass"
                new DLCImage
                {
                    Id = 5,
                    ImageUrl = "https://example.com/dlc_image_5.jpg",
                    Caption = "The Legend of Zelda: Breath of the Wild - Expansion Pass DLC Image",
                    DLCId = 5
                },
                new DLCImage
                {
                    Id = 6,
                    ImageUrl = "https://example.com/dlc_image_6.jpg",
                    Caption = "The Legend of Zelda: Breath of the Wild - The Champions' Ballad DLC Image",
                    DLCId = 6
                },
                // DLC Images for "Grand Theft Auto V: The Diamond Casino Heist"
                new DLCImage
                {
                    Id = 7,
                    ImageUrl = "https://example.com/dlc_image_7.jpg",
                    Caption = "Grand Theft Auto V: The Diamond Casino Heist DLC Image",
                    DLCId = 7
                },
                new DLCImage
                {
                    Id = 8,
                    ImageUrl = "https://example.com/dlc_image_8.jpg",
                    Caption = "Grand Theft Auto V: The Cayo Perico Heist DLC Image",
                    DLCId = 8
                },
                // DLC Images for "Minecraft: Nether Update"
                new DLCImage
                {
                    Id = 9,
                    ImageUrl = "https://example.com/dlc_image_9.jpg",
                    Caption = "Minecraft: Nether Update DLC Image",
                    DLCId = 9
                },
                new DLCImage
                {
                    Id = 10,
                    ImageUrl = "https://example.com/dlc_image_10.jpg",
                    Caption = "Minecraft: Caves & Cliffs Update DLC Image",
                    DLCId = 10
                }
            };

            builder.Entity<DLCImage>().HasData(dlcImages);
        }
    }
}
