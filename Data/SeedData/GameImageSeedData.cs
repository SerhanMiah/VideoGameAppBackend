using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VideoGameAppBackend.Models;

namespace VideoGameAppBackend.Data.SeedData
{
    public static class GameImageSeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameImage>().HasData(
                // Images for Game Id = 1 (Cyberpunk 2077)
                new GameImage { Id = 1, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Cyberpunk%202077/cyberpunk_2077_unreal_engine_5_wjauye.png" }, // Cyberpunk 2077
                new GameImage { Id = 2, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-phantom-liberty_fuqyge.webp" }, // Cyberpunk 2077
                new GameImage { Id = 3, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk_2077_bztuyy.webp" }, // Cyberpunk 2077
                new GameImage { Id = 4, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/Cyberpunk%202077/Cyberpunk-2077-witcher-map_uj800z.webp" }, // Cyberpunk 2077
                new GameImage { Id = 5, GameId = 1, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547902/VideoGameShop/Cyberpunk%202077/cyberpunk-2077-game-of-the-year-edition-scaled-e1670012903149_jpzcd6.webp" }, // Cyberpunk 2077

                // Images for Game Id = 2 (Minecraft)
                new GameImage { Id = 6, GameId = 2, Url = "https://example.com/minecraft/image1.jpg" }, // Minecraft
                new GameImage { Id = 7, GameId = 2, Url = "https://example.com/minecraft/image2.jpg" }, // Minecraft
                new GameImage { Id = 8, GameId = 2, Url = "https://example.com/minecraft/image3.jpg" }, // Minecraft
                new GameImage { Id = 9, GameId = 2, Url = "https://example.com/minecraft/image4.jpg" }, // Minecraft
                new GameImage { Id = 10, GameId = 2, Url = "https://example.com/minecraft/image5.jpg" }, // Minecraft

                // Images for Game Id = 3 (The Witcher 3: Wild Hunt)
                new GameImage { Id = 11, GameId = 3, Url = "https://example.com/thewitcher3/image1.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 12, GameId = 3, Url = "https://example.com/thewitcher3/image2.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 13, GameId = 3, Url = "https://example.com/thewitcher3/image3.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 14, GameId = 3, Url = "https://example.com/thewitcher3/image4.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 15, GameId = 3, Url = "https://example.com/thewitcher3/image5.jpg" }, // The Witcher 3: Wild Hunt

                // Images for Game Id = 4 (Demon's Souls)
                new GameImage { Id = 16, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" }, // Demon's Souls
                new GameImage { Id = 17, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547907/VideoGameShop/DemonSoul/p3BNVCDOeLpb3bWAptk2Hi2t_v4hfbq.webp" }, // Demon's Souls
                new GameImage { Id = 18, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" }, // Demon's Souls
                new GameImage { Id = 19, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" }, // Demon's Souls
                new GameImage { Id = 20, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/DemonSoul/demons-souls-penetrator.large_vz9tfp.jpg" }, // Demon's Souls

                // Images for Game Id = 5 (Ratchet & Clank: Rift Apart)
                new GameImage { Id = 21, GameId = 5, Url = "https://example.com/ratchetandclank/image1.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 22, GameId = 5, Url = "https://example.com/ratchetandclank/image2.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 23, GameId = 5, Url = "https://example.com/ratchetandclank/image3.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 24, GameId = 5, Url = "https://example.com/ratchetandclank/image4.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 25, GameId = 5, Url = "https://example.com/ratchetandclank/image5.jpg" }, // Ratchet & Clank: Rift Apart

                // Images for Game Id = 6 (Returnal)
                new GameImage { Id = 26, GameId = 6, Url = "https://example.com/returnal/image1.jpg" }, // Returnal
                new GameImage { Id = 27, GameId = 6, Url = "https://example.com/returnal/image2.jpg" }, // Returnal
                new GameImage { Id = 28, GameId = 6, Url = "https://example.com/returnal/image3.jpg" }, // Returnal
                new GameImage { Id = 29, GameId = 6, Url = "https://example.com/returnal/image4.jpg" }, // Returnal
                new GameImage { Id = 30, GameId = 6, Url = "https://example.com/returnal/image5.jpg" }, // Returnal

                // Images for Game Id = 7 (The Last of Us Part II)
                new GameImage { Id = 31, GameId = 7, Url = "https://example.com/lastofus2/image1.jpg" }, // The Last of Us Part II
                new GameImage { Id = 32, GameId = 7, Url = "https://example.com/lastofus2/image2.jpg" }, // The Last of Us Part II
                new GameImage { Id = 33, GameId = 7, Url = "https://example.com/lastofus2/image3.jpg" }, // The Last of Us Part II
                new GameImage { Id = 34, GameId = 7, Url = "https://example.com/lastofus2/image4.jpg" }, // The Last of Us Part II
                new GameImage { Id = 35, GameId = 7, Url = "https://example.com/lastofus2/image5.jpg" }, // The Last of Us Part II

                // Images for Game Id = 8 (God of War)
                new GameImage { Id = 36, GameId = 8, Url = "https://example.com/godofwar/image1.jpg" }, // God of War
                new GameImage { Id = 37, GameId = 8, Url = "https://example.com/godofwar/image2.jpg" }, // God of War
                new GameImage { Id = 38, GameId = 8, Url = "https://example.com/godofwar/image3.jpg" }, // God of War
                new GameImage { Id = 39, GameId = 8, Url = "https://example.com/godofwar/image4.jpg" }, // God of War
                new GameImage { Id = 40, GameId = 8, Url = "https://example.com/godofwar/image5.jpg" }, // God of War

                // Images for Game Id = 9 (Uncharted 4: A Thief's End)
                new GameImage { Id = 41, GameId = 9, Url = "https://example.com/uncharted4/image1.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 42, GameId = 9, Url = "https://example.com/uncharted4/image2.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 43, GameId = 9, Url = "https://example.com/uncharted4/image3.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 44, GameId = 9, Url = "https://example.com/uncharted4/image4.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 45, GameId = 9, Url = "https://example.com/uncharted4/image5.jpg" }, // Uncharted 4: A Thief's End

                // Images for Game Id = 10 (Forza Horizon 4)
                new GameImage { Id = 46, GameId = 10, Url = "https://example.com/forzahorizon4/image1.jpg" }, // Forza Horizon 4
                new GameImage { Id = 47, GameId = 10, Url = "https://example.com/forzahorizon4/image2.jpg" }, // Forza Horizon 4
                new GameImage { Id = 48, GameId = 10, Url = "https://example.com/forzahorizon4/image3.jpg" }, // Forza Horizon 4
                new GameImage { Id = 49, GameId = 10, Url = "https://example.com/forzahorizon4/image4.jpg" }, // Forza Horizon 4
                new GameImage { Id = 50, GameId = 10, Url = "https://example.com/forzahorizon4/image5.jpg" }, // Forza Horizon 4

                // Images for Game Id = 11 (Halo 5: Guardians)
                new GameImage { Id = 51, GameId = 11, Url = "https://example.com/halo5/image1.jpg" }, // Halo 5: Guardians
                new GameImage { Id = 52, GameId = 11, Url = "https://example.com/halo5/image2.jpg" }, // Halo 5: Guardians
                new GameImage { Id = 53, GameId = 11, Url = "https://example.com/halo5/image3.jpg" }, // Halo 5: Guardians
                new GameImage { Id = 54, GameId = 11, Url = "https://example.com/halo5/image4.jpg" }, // Halo 5: Guardians
                new GameImage { Id = 55, GameId = 11, Url = "https://example.com/halo5/image5.jpg" }, // Halo 5: Guardians

                // Images for Game Id = 12 (Gears of War 4)
                new GameImage { Id = 56, GameId = 12, Url = "https://example.com/gearsofwar4/image1.jpg" }, // Gears of War 4
                new GameImage { Id = 57, GameId = 12, Url = "https://example.com/gearsofwar4/image2.jpg" }, // Gears of War 4
                new GameImage { Id = 58, GameId = 12, Url = "https://example.com/gearsofwar4/image3.jpg" }, // Gears of War 4
                new GameImage { Id = 59, GameId = 12, Url = "https://example.com/gearsofwar4/image4.jpg" }, // Gears of War 4
                new GameImage { Id = 60, GameId = 12, Url = "https://example.com/gearsofwar4/image5.jpg" },  // Gears of War 4

                // Images for Game Id = 13 (Assassin's Creed Valhalla)
                new GameImage { Id = 61, GameId = 13, Url = "https://example.com/assassinscreedvalhalla/image1.jpg" }, // Assassin's Creed Valhalla
                new GameImage { Id = 62, GameId = 13, Url = "https://example.com/assassinscreedvalhalla/image2.jpg" }, // Assassin's Creed Valhalla
                new GameImage { Id = 63, GameId = 13, Url = "https://example.com/assassinscreedvalhalla/image3.jpg" }, // Assassin's Creed Valhalla
                new GameImage { Id = 64, GameId = 13, Url = "https://example.com/assassinscreedvalhalla/image4.jpg" }, // Assassin's Creed Valhalla
                new GameImage { Id = 65, GameId = 13, Url = "https://example.com/assassinscreedvalhalla/image5.jpg" }, // Assassin's Creed Valhalla

                // Images for Game Id = 14 (Death Stranding)
                new GameImage { Id = 66, GameId = 14, Url = "https://example.com/deathstranding/image1.jpg" }, // Death Stranding
                new GameImage { Id = 67, GameId = 14, Url = "https://example.com/deathstranding/image2.jpg" }, // Death Stranding
                new GameImage { Id = 68, GameId = 14, Url = "https://example.com/deathstranding/image3.jpg" }, // Death Stranding
                new GameImage { Id = 69, GameId = 14, Url = "https://example.com/deathstranding/image4.jpg" }, // Death Stranding
                new GameImage { Id = 70, GameId = 14, Url = "https://example.com/deathstranding/image5.jpg" }, // Death Stranding
                // Images for Game Id = 14 (Death Stranding)
            
                // Images for Game Id = 15 (Grand Theft Auto V)
                new GameImage { Id = 71, GameId = 15, Url = "https://example.com/grandtheftautoV/image1.jpg" }, // Grand Theft Auto V
                new GameImage { Id = 72, GameId = 15, Url = "https://example.com/grandtheftautoV/image2.jpg" }, // Grand Theft Auto V
                new GameImage { Id = 73, GameId = 15, Url = "https://example.com/grandtheftautoV/image3.jpg" }, // Grand Theft Auto V
                new GameImage { Id = 74, GameId = 15, Url = "https://example.com/grandtheftautoV/image4.jpg" }, // Grand Theft Auto V
                new GameImage { Id = 75, GameId = 15, Url = "https://example.com/grandtheftautoV/image5.jpg" }, // Grand Theft Auto V

                // Images for Game Id = 16 (Marvel's Spider-Man: Miles Morales)
                new GameImage { Id = 76, GameId = 16, Url = "https://example.com/spidermanmilesmorales/image1.jpg" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 77, GameId = 16, Url = "https://example.com/spidermanmilesmorales/image2.jpg" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 78, GameId = 16, Url = "https://example.com/spidermanmilesmorales/image3.jpg" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 79, GameId = 16, Url = "https://example.com/spidermanmilesmorales/image4.jpg" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 80, GameId = 16, Url = "https://example.com/spidermanmilesmorales/image5.jpg" }, // Marvel's Spider-Man: Miles Morales

                // Images for Game Id = 17 (Resident Evil Village)
                new GameImage { Id = 81, GameId = 17, Url = "https://example.com/residentevilvillage/image1.jpg" }, // Resident Evil Village
                new GameImage { Id = 82, GameId = 17, Url = "https://example.com/residentevilvillage/image2.jpg" }, // Resident Evil Village
                new GameImage { Id = 83, GameId = 17, Url = "https://example.com/residentevilvillage/image3.jpg" }, // Resident Evil Village
                new GameImage { Id = 84, GameId = 17, Url = "https://example.com/residentevilvillage/image4.jpg" }, // Resident Evil Village
                new GameImage { Id = 85, GameId = 17, Url = "https://example.com/residentevilvillage/image5.jpg" }, // Resident Evil Village

                // Images for Game Id = 18 (Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles)
                new GameImage { Id = 86, GameId = 18, Url = "https://example.com/demonslayerhinokamichronicles/image1.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 87, GameId = 18, Url = "https://example.com/demonslayerhinokamichronicles/image2.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 88, GameId = 18, Url = "https://example.com/demonslayerhinokamichronicles/image3.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 89, GameId = 18, Url = "https://example.com/demonslayerhinokamichronicles/image4.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 90, GameId = 18, Url = "https://example.com/demonslayerhinokamichronicles/image5.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles

                new GameImage { Id = 91, GameId = 19, Url = "https://example.com/horizonforbiddenwest/image1.jpg" }, // FIFA 22
                new GameImage { Id = 92, GameId = 19, Url = "https://example.com/horizonforbiddenwest/image2.jpg" }, // FIFA 22
                new GameImage { Id = 93, GameId = 19, Url = "https://example.com/horizonforbiddenwest/image3.jpg" }, // FIFA 22
                new GameImage { Id = 94, GameId = 19, Url = "https://example.com/horizonforbiddenwest/image4.jpg" }, // FIFA 22
                new GameImage { Id = 95, GameId = 19, Url = "https://example.com/horizonforbiddenwest/image5.jpg" }, // FIFA 22


                new GameImage { Id = 96, GameId = 20, Url = "https://example.com/horizonforbiddenwest/image1.jpg" }, // HADES
                new GameImage { Id = 97, GameId = 20, Url = "https://example.com/horizonforbiddenwest/image2.jpg" }, // HADES
                new GameImage { Id = 98, GameId = 20, Url = "https://example.com/horizonforbiddenwest/image3.jpg" }, // HADES
                new GameImage { Id = 99, GameId = 20, Url = "https://example.com/horizonforbiddenwest/image4.jpg" }, // HADES
                new GameImage { Id = 100, GameId = 20, Url = "https://example.com/horizonforbiddenwest/image5.jpg" }, // HADES
                

                new GameImage { Id = 101, GameId = 21, Url = "https://example.com/horizonforbiddenwest/image1.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 102, GameId = 21, Url = "https://example.com/horizonforbiddenwest/image2.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 103, GameId = 21, Url = "https://example.com/horizonforbiddenwest/image3.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 104, GameId = 21, Url = "https://example.com/horizonforbiddenwest/image4.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 105, GameId = 21, Url = "https://example.com/horizonforbiddenwest/image5.jpg" }, // PSYCHONAUTS 2

                // Images for Game Id = 22 (The Elder Scrolls V: Skyrim)
                new GameImage { Id = 106, GameId = 22, Url = "https://example.com/skyrim/image1.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 107, GameId = 22, Url = "https://example.com/skyrim/image2.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 108, GameId = 22, Url = "https://example.com/skyrim/image3.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 109, GameId = 22, Url = "https://example.com/skyrim/image4.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 110, GameId = 22, Url = "https://example.com/skyrim/image5.jpg" }, // The Elder Scrolls V: Skyrim

                // Images for Game Id = 23 (World of Warcraft)
                new GameImage { Id = 111, GameId = 23, Url = "https://example.com/worldofwarcraft/image1.jpg" }, // World of Warcraft
                new GameImage { Id = 112, GameId = 23, Url = "https://example.com/worldofwarcraft/image2.jpg" }, // World of Warcraft
                new GameImage { Id = 113, GameId = 23, Url = "https://example.com/worldofwarcraft/image3.jpg" }, // World of Warcraft
                new GameImage { Id = 114, GameId = 23, Url = "https://example.com/worldofwarcraft/image4.jpg" }, // World of Warcraft
                new GameImage { Id = 115, GameId = 23, Url = "https://example.com/worldofwarcraft/image5.jpg" }, // World of Warcraft

                // Images for Game Id = 24 (Fallout 4)
                new GameImage { Id = 116, GameId = 24, Url = "https://example.com/fallout4/image1.jpg" }, // Fallout 4
                new GameImage { Id = 117, GameId = 24, Url = "https://example.com/fallout4/image2.jpg" }, // Fallout 4
                new GameImage { Id = 118, GameId = 24, Url = "https://example.com/fallout4/image3.jpg" }, // Fallout 4
                new GameImage { Id = 119, GameId = 24, Url = "https://example.com/fallout4/image4.jpg" }, // Fallout 4
                new GameImage { Id = 120, GameId = 24, Url = "https://example.com/fallout4/image5.jpg" }, // Fallout 4

                // Images for Game Id = 25 (Horizon Forbidden West)
                new GameImage { Id = 121, GameId = 25, Url = "https://example.com/horizonforbiddenwest/image1.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 122, GameId = 25, Url = "https://example.com/horizonforbiddenwest/image2.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 123, GameId = 25, Url = "https://example.com/horizonforbiddenwest/image3.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 124, GameId = 25, Url = "https://example.com/horizonforbiddenwest/image4.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 125, GameId = 25, Url = "https://example.com/horizonforbiddenwest/image5.jpg" }, // Horizon Forbidden West

                // Images for Game Id = 26 (Call of Duty: Warzone)
                new GameImage { Id = 126, GameId = 26, Url = "https://example.com/callofdutywarzone/image1.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 127, GameId = 26, Url = "https://example.com/callofdutywarzone/image2.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 128, GameId = 26, Url = "https://example.com/callofdutywarzone/image3.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 129, GameId = 26, Url = "https://example.com/callofdutywarzone/image4.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 130, GameId = 26, Url = "https://example.com/callofdutywarzone/image5.jpg" }, // Call of Duty: Warzone

                // Images for Game Id = 27 (Fortnite)
                new GameImage { Id = 131, GameId = 27, Url = "https://example.com/fortnite/image1.jpg" }, // Fortnite
                new GameImage { Id = 132, GameId = 27, Url = "https://example.com/fortnite/image2.jpg" }, // Fortnite
                new GameImage { Id = 133, GameId = 27, Url = "https://example.com/fortnite/image3.jpg" }, // Fortnite
                new GameImage { Id = 134, GameId = 27, Url = "https://example.com/fortnite/image4.jpg" }, // Fortnite
                new GameImage { Id = 135, GameId = 27, Url = "https://example.com/fortnite/image5.jpg" } // Fortnite
            
            );

            // Configure the relationship between Game and GameImage
            modelBuilder.Entity<Game>()
                .HasMany(g => g.GameImages)
                .WithOne(gi => gi.Game)
                .HasForeignKey(gi => gi.GameId);
        }
    }
}