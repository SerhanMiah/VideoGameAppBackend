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

                // Images for Game Id = 2 (https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg)
                new GameImage { Id = 6, GameId = 2, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" }, // Minecraft
                new GameImage { Id = 7, GameId = 2, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" }, // Minecraft
                new GameImage { Id = 8, GameId = 2, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" }, // Minecraft
                new GameImage { Id = 9, GameId = 2, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" }, // Minecraft
                new GameImage { Id = 10, GameId = 2, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_Minecraft.jpg" }, // Minecraft

                // Images for Game Id = 3 (The Witcher 3: Wild Hunt)
                new GameImage { Id = 11, GameId = 3, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 12, GameId = 3, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 13, GameId = 3, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 14, GameId = 3, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" }, // The Witcher 3: Wild Hunt
                new GameImage { Id = 15, GameId = 3, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_TheWitcher3WildHunt_enGB_image1600w.jpg" }, // The Witcher 3: Wild Hunt

                // Images for Game Id = 4 (Demon's Souls)
                new GameImage { Id = 16, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/DemonSoul/gAP2DGRWpFSehL2GDrcsPL_ienhqh.jpg" }, // Demon's Souls
                new GameImage { Id = 17, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547907/VideoGameShop/DemonSoul/p3BNVCDOeLpb3bWAptk2Hi2t_v4hfbq.webp" }, // Demon's Souls
                new GameImage { Id = 18, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" }, // Demon's Souls
                new GameImage { Id = 19, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/DemonSoul/demonssouls-review-blogroll-1605559895476_160w_z5fsmg.jpg" }, // Demon's Souls
                new GameImage { Id = 20, GameId = 4, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547903/VideoGameShop/DemonSoul/demons-souls-penetrator.large_vz9tfp.jpg" }, // Demon's Souls

                // Images for Game Id = 5 (Ratchet & Clank: Rift Apart)
                new GameImage { Id = 21, GameId = 5, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547912/VideoGameShop/Ratchet-Clank-Rift%20Apart/RC_RiftApart_Heroes_PS5-scaled_u56nzf.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 22, GameId = 5, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Ratchet-Clank-Rift%20Apart/RC_RiftApart_Who_PS5-scaled_zabzju.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 23, GameId = 5, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Ratchet-Clank-Rift%20Apart/DwVjpbKOsFOyPdNzmSTSWuxG_obxxbq.webp" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 24, GameId = 5, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Ratchet-Clank-Rift%20Apart/Ratchet-and-Clank-Rift-Apart-PS4-fc20022_rd0biw.jpg" }, // Ratchet & Clank: Rift Apart
                new GameImage { Id = 25, GameId = 5, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547904/VideoGameShop/Ratchet-Clank-Rift%20Apart/716cb9b0c815dd9a4ff2b198a5ba13a4d58dfa01-scaled_zhguda.webp" }, // Ratchet & Clank: Rift Apart

                // Images for Game Id = 6 (Returnal)
                new GameImage { Id = 26, GameId = 6, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547910/VideoGameShop/Returnal/81jyDN6P9vL_p3u8ms.jpg" }, // Returnal
                new GameImage { Id = 27, GameId = 6, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Returnal/jACA12Z58ka5V6vvxlcdoQfJ_sykmv1.avif" }, // Returnal
                new GameImage { Id = 28, GameId = 6, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547909/VideoGameShop/Returnal/4ItSbqJE88H019Ua3WBQKLF8_mfw76m.avif" }, // Returnal
                new GameImage { Id = 29, GameId = 6, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547906/VideoGameShop/Returnal/returnalsurvive_wiqjhb.jpg" }, // Returnal
                new GameImage { Id = 30, GameId = 6, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687547905/VideoGameShop/Returnal/h3returnalh3brbdelayed-from-march-19-to-april-30-2021bbrbrre_8g1s.1280_n4y5sg.webp" }, // Returnal

                // Images for Game Id = 7 (The Last of Us Part II)
                new GameImage { Id = 31, GameId = 7, Url = "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" }, // The Last of Us Part II
                new GameImage { Id = 32, GameId = 7, Url = "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" }, // The Last of Us Part II
                new GameImage { Id = 33, GameId = 7, Url = "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" }, // The Last of Us Part II
                new GameImage { Id = 34, GameId = 7, Url = "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" }, // The Last of Us Part II
                new GameImage { Id = 35, GameId = 7, Url = "https://assets1.ignimgs.com/2020/05/19/lastofuspart2-blogroll-1589913932452_160w.jpg?width=1280" }, // The Last of Us Part II

                // Images for Game Id = 8 (God of War)
                new GameImage { Id = 36, GameId = 8, Url = "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" }, // God of War
                new GameImage { Id = 37, GameId = 8, Url = "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" }, // God of War
                new GameImage { Id = 38, GameId = 8, Url = "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" }, // God of War
                new GameImage { Id = 39, GameId = 8, Url = "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" }, // God of War
                new GameImage { Id = 40, GameId = 8, Url = "https://m.media-amazon.com/images/I/A1b0TAVpyEL._AC_UF894,1000_QL80_.jpg" }, // God of War

                // Images for Game Id = 9 (Uncharted 4: A Thief's End)
                new GameImage { Id = 41, GameId = 9, Url = "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 42, GameId = 9, Url = "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 43, GameId = 9, Url = "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 44, GameId = 9, Url = "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" }, // Uncharted 4: A Thief's End
                new GameImage { Id = 45, GameId = 9, Url = "https://image.api.playstation.com/vulcan/img/rnd/202010/2620/eIO6Ka26JChNo8KaFi7wON4L.jpg" }, // Uncharted 4: A Thief's End

                // Images for Game Id = 10 (Forza Horizon 4)
                new GameImage { Id = 46, GameId = 10, Url = "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" }, // Forza Horizon 4
                new GameImage { Id = 47, GameId = 10, Url = "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" }, // Forza Horizon 4
                new GameImage { Id = 48, GameId = 10, Url = "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" }, // Forza Horizon 4
                new GameImage { Id = 49, GameId = 10, Url = "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" }, // Forza Horizon 4
                new GameImage { Id = 50, GameId = 10, Url = "https://assets.xboxservices.com/assets/1d/8f/1d8f5d61-2a8c-4377-a512-88b060deeaf4.jpg?n=FH4_GLP-Page-Hero-1084_1920x1080_02.jpg" }, // Forza Horizon 4

                // Images for Game Id = 11 (Halo 5: Guardians)
                new GameImage { Id = 51, GameId = 11, Url = "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" }, // Halo 5: Guardians
                new GameImage { Id = 52, GameId = 11, Url = "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" }, // Halo 5: Guardians
                new GameImage { Id = 53, GameId = 11, Url = "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" }, // Halo 5: Guardians
                new GameImage { Id = 54, GameId = 11, Url = "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" }, // Halo 5: Guardians
                new GameImage { Id = 55, GameId = 11, Url = "https://gaming-cdn.com/images/products/9598/orig/halo-5-guardians-pc-game-steam-cover.jpg?v=1668692780" }, // Halo 5: Guardians

                // Images for Game Id = 12 (Gears of War 4)
                new GameImage { Id = 56, GameId = 12, Url = "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" }, // Gears of War 4
                new GameImage { Id = 57, GameId = 12, Url = "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" }, // Gears of War 4
                new GameImage { Id = 58, GameId = 12, Url = "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" }, // Gears of War 4
                new GameImage { Id = 59, GameId = 12, Url = "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" }, // Gears of War 4
                new GameImage { Id = 60, GameId = 12, Url = "https://assets.xboxservices.com/assets/2b/42/2b42b33c-cc7f-4162-9eaa-48e5cc88e6fe.jpg?n=GoW4-MWF_Hero-0_1083x609.jpg" },  // Gears of War 4

                // Images for Game Id = 13 (Assassin's Creed Valhalla)
                new GameImage { Id = 61, GameId = 13, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" }, // Assassin's Creed Valhalla
                new GameImage { Id = 62, GameId = 13, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" }, // Assassin's Creed Valhalla
                new GameImage { Id = 63, GameId = 13, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" }, // Assassin's Creed Valhalla
                new GameImage { Id = 64, GameId = 13, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" }, // Assassin's Creed Valhalla
                new GameImage { Id = 65, GameId = 13, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202006/1520/EDtkdijFRwbmGKk1G9lrDoEF.png" }, // Assassin's Creed Valhalla

                // Images for Game Id = 14 (Death Stranding)
                new GameImage { Id = 66, GameId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" }, // Death Stranding
                new GameImage { Id = 67, GameId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" }, // Death Stranding
                new GameImage { Id = 68, GameId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" }, // Death Stranding
                new GameImage { Id = 69, GameId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" }, // Death Stranding
                new GameImage { Id = 70, GameId = 14, Url = "https://m.media-amazon.com/images/M/MV5BMjIxZTljZGItZTIwYS00ZjIzLWJlZTMtZWIyODg0NjA0NTNmXkEyXkFqcGdeQXVyMTI0MzA4NTgw._V1_.jpg" }, // Death Stranding
                // Images for Game Id = 14 (Death Stranding)
            
                // Images for Game Id = 15 (Grand Theft Auto V)
                new GameImage { Id = 71, GameId = 15, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" }, // Grand Theft Auto V
                new GameImage { Id = 72, GameId = 15, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" }, // Grand Theft Auto V
                new GameImage { Id = 73, GameId = 15, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" }, // Grand Theft Auto V
                new GameImage { Id = 74, GameId = 15, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" }, // Grand Theft Auto V
                new GameImage { Id = 75, GameId = 15, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202202/2811/x9SuHZAiRn0uJXB1IKteIgcw.png" }, // Grand Theft Auto V

                // Images for Game Id = 16 (Marvel's Spider-Man: Miles Morales)
                new GameImage { Id = 76, GameId = 16, Url = "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 77, GameId = 16, Url = "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 78, GameId = 16, Url = "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 79, GameId = 16, Url = "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" }, // Marvel's Spider-Man: Miles Morales
                new GameImage { Id = 80, GameId = 16, Url = "https://gaming-cdn.com/images/products/12953/orig/marvel-s-spider-man-miles-morales-pc-game-steam-cover.jpg?v=1683639469" }, // Marvel's Spider-Man: Miles Morales

                // Images for Game Id = 17 (Resident Evil Village)
                new GameImage { Id = 81, GameId = 17, Url = "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // Resident Evil Village
                new GameImage { Id = 82, GameId = 17, Url = "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // Resident Evil Village
                new GameImage { Id = 83, GameId = 17, Url = "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // Resident Evil Village
                new GameImage { Id = 84, GameId = 17, Url = "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // Resident Evil Village
                new GameImage { Id = 85, GameId = 17, Url = "https://assetsio.reedpopcdn.com/Resident-Evil-Village-Gold-Edition.jpg?width=1600&height=900&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // Resident Evil Village

                // Images for Game Id = 18 (Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles)
                new GameImage { Id = 86, GameId = 18, Url = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 87, GameId = 18, Url = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 88, GameId = 18, Url = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 89, GameId = 18, Url = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles
                new GameImage { Id = 90, GameId = 18, Url = "https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi5HQma8l42yiEEs8TntdfI_YxYjwcHpFvARIVtxqqukFwKsIlnk_f7uqt3Fv_UniTPENV0YSB6lSiIlAubWNOBjbpVXXcjx-faWPurBEw3crAGkIQdTj8yzKCACHq6sCeRPkYtXESpLjUcDu5_VY3W8z6LfCJSpt8IVfRipQ6QMH92cj4ea4mBLTXP/s1280/Demon-Slayer-Kimetsu-no-Yaiba-The-Hinokami-Chronicles-Switch-physical-release.jpg" }, // Demon Slayer: Kimetsu no Yaiba - The Hinokami Chronicles

                new GameImage { Id = 91, GameId = 19, Url = "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" }, // FIFA 22
                new GameImage { Id = 92, GameId = 19, Url = "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" }, // FIFA 22
                new GameImage { Id = 93, GameId = 19, Url = "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" }, // FIFA 22
                new GameImage { Id = 94, GameId = 19, Url = "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" }, // FIFA 22
                new GameImage { Id = 95, GameId = 19, Url = "https://library.sportingnews.com/styles/facebook_1200x630/s3/2021-10/ea-fifa-22-cover-kylian-mbappe_1qeaco87s803l13iu0tnr84jhq.jpg?itok=B0Ysb2Rj" }, // FIFA 22


                new GameImage { Id = 96, GameId = 20, Url = "https://cdn.vox-cdn.com/thumbor/P5qcFEfltn2W-VVjvjHdGtBjGN4=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/22138421/jbareham_201201_ecl1050_goty_2020_top_10__1_HADES.jpg" }, // HADES
                new GameImage { Id = 97, GameId = 20, Url = "https://d1w82usnq70pt2.cloudfront.net/wp-content/uploads/2020/01/hadesgoonheader.png" }, // HADES
                new GameImage { Id = 98, GameId = 20, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_download_software_1/H2x1_NSwitchDS_Hades_image1600w.png" }, // HADES
                new GameImage { Id = 99, GameId = 20, Url = "https://preview.redd.it/8uwps0hac4s81.jpg?auto=webp&s=eb79577f9e3cbb2e38f0b386c5ad81882397f151" }, // HADES
                new GameImage { Id = 100, GameId = 20, Url = "https://assets.rockpapershotgun.com/images/2019/01/hades-e.jpg" }, // HADES
                

                new GameImage { Id = 101, GameId = 21, Url = "https://upload.wikimedia.org/wikipedia/en/2/23/Psychonauts_2_cover.png" }, // PSYCHONAUTS 2
                new GameImage { Id = 102, GameId = 21, Url = "https://i.guim.co.uk/img/media/4aa09e45bb80928fc52442e3072edeba6e1001b5/144_0_3600_2160/master/3600.jpg?width=1200&height=1200&quality=85&auto=format&fit=crop&s=2fc06be6382ce01bea378e17a9642dfa" }, // PSYCHONAUTS 2
                new GameImage { Id = 103, GameId = 21, Url = "https://assets.xboxservices.com/assets/94/e6/94e658f8-20d5-4419-988c-7603eb297a42.jpg?n=Psychonauts-2_GLP-Page-Hero-1084_Cinemagraph-Poster-Image_1920x1080.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 104, GameId = 21, Url = "https://static1.thegamerimages.com/wordpress/wp-content/uploads/2022/12/raz-milla-and-lucrecia-from-psychonauts-2.jpg" }, // PSYCHONAUTS 2
                new GameImage { Id = 105, GameId = 21, Url = "https://www.gameinformer.com/sites/default/files/styles/thumbnail/public/2021/06/13/3a37e59e/psychonauts2_01.jpg" }, // PSYCHONAUTS 2

                // Images for Game Id = 22 (The Elder Scrolls V: Skyrim)
                new GameImage { Id = 106, GameId = 22, Url = "https://fs-prod-cdn.nintendo-europe.com/media/images/10_share_images/games_15/nintendo_switch_4/H2x1_NSwitch_TheElderScrollsVSkyrim_image1600w.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 107, GameId = 22, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202110/2019/aDSOgerXg4V6sf5A7VzHiTun.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 108, GameId = 22, Url = "https://i.ebayimg.com/images/g/Ag0AAOSwhBxjP~Z5/s-l960.jpg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 109, GameId = 22, Url = "https://i.gadgets360cdn.com/large/skyrim_remaster_1477475720488.jpeg" }, // The Elder Scrolls V: Skyrim
                new GameImage { Id = 110, GameId = 22, Url = "https://media.wired.com/photos/5a8f7d06b4bf6c3e4d4058c0/master/w_1600%2Cc_limit/skyrim-0004.jpg" }, // The Elder Scrolls V: Skyrim

                // Images for Game Id = 23 (World of Warcraft)
                new GameImage { Id = 111, GameId = 23, Url = "https://static.wikia.nocookie.net/wowpedia/images/a/aa/WoW_2.0_logo_old.png/revision/latest?cb=20180705205814" }, // World of Warcraft
                new GameImage { Id = 112, GameId = 23, Url = "https://media.wired.com/photos/5eb064fb568b219656eb598a/master/w_2560%2Cc_limit/Culture_Ardenweald_1920x1080.jpg" }, // World of Warcraft
                new GameImage { Id = 113, GameId = 23, Url = "https://blz-contentstack-images.akamaized.net/v3/assets/bltf408a0557f4e4998/bltd6a3e4b53209d445/63ec05bc9fcac365e25253a0/WoW_Free_Trial_BG.png?width=&format=webply&dpr=2&disable=upscale&quality=80" }, // World of Warcraft
                new GameImage { Id = 114, GameId = 23, Url = "https://images.cgames.de/images/gamestar/4/wow-dragonflight-teaser_6177226.jpg" }, // World of Warcraft
                new GameImage { Id = 115, GameId = 23, Url = "https://assetsio.reedpopcdn.com/World-Of-Warcraft-Wrath-Of-The-Lich-King.jpg?width=1200&height=1200&fit=crop&quality=100&format=png&enable=upscale&auto=webp" }, // World of Warcraft

                // Images for Game Id = 24 (Fallout 4)
                new GameImage { Id = 116, GameId = 24, Url = "https://image.api.playstation.com/vulcan/ap/rnd/202009/2500/4GZyUQ1bHTjICP6GCRG7f65n.png" }, // Fallout 4
                new GameImage { Id = 117, GameId = 24, Url = "https://cdn.vox-cdn.com/thumbor/Fy1WKM1aEXO4VT6_WvIGQNtMC68=/155x0:1842x1125/1280x854/cdn.vox-cdn.com/uploads/chorus_image/image/47619447/Fallout4_Trailer_End_1433355589.0.0.jpg" }, // Fallout 4
                new GameImage { Id = 118, GameId = 24, Url = "https://www.trustedreviews.com/wp-content/uploads/sites/54/2015/11/Fallout-4-1-2.jpg" }, // Fallout 4
                new GameImage { Id = 119, GameId = 24, Url = "https://images.ladbible.com/resize?type=jpeg&quality=70&width=720&fit=contain&gravity=null&url=https://eu-images.contentstack.com/v3/assets/bltbc1876152fcd9f07/blt4803eee048f0ddc1/647e01820f2fc184b19c8db1/fallout_4_fan_remake.png" }, // Fallout 4
                new GameImage { Id = 120, GameId = 24, Url = "https://assetsio.reedpopcdn.com/1.bmp_jQm0xJ3.jpg?width=1200&height=1200&fit=bounds&quality=70&format=jpg&auto=webp" }, // Fallout 4

                // Images for Game Id = 25 (Horizon Forbidden West)
                new GameImage { Id = 121, GameId = 25, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687633010/VideoGameShop/Horizon%20Forbidden%20West/horizon-forbidden-west-alpha-leak-scaled-e1672388177340_kmjzqr.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 122, GameId = 25, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/Games-Horizon-Forbidden-West-Review-top_q8ujyy.webp" }, // Horizon Forbidden West
                new GameImage { Id = 123, GameId = 25, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/HO8vkO9pfXhwbHi5WHECQJdN_orvh7x.webp" }, // Horizon Forbidden West
                new GameImage { Id = 124, GameId = 25, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/UwYhuHgLaRtpq9eXUBuwaM_mb1ns8.jpg" }, // Horizon Forbidden West
                new GameImage { Id = 125, GameId = 25, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687633009/VideoGameShop/Horizon%20Forbidden%20West/resize_fomk2i.jpg" }, // Horizon Forbidden West

                // Images for Game Id = 26 (Call of Duty: Warzone)
                new GameImage { Id = 126, GameId = 26, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632890/VideoGameShop/Call%20of%20Duty-%20Warzone/WZM-LIMITEDRELEASE-1128-TOUT_h3qti8.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 127, GameId = 26, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632890/VideoGameShop/Call%20of%20Duty-%20Warzone/Warzone_glsmxq.png" }, // Call of Duty: Warzone
                new GameImage { Id = 128, GameId = 26, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632889/VideoGameShop/Call%20of%20Duty-%20Warzone/warzone-s2-meta-a86a_l6ctn7.webp" }, // Call of Duty: Warzone
                new GameImage { Id = 129, GameId = 26, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632889/VideoGameShop/Call%20of%20Duty-%20Warzone/ss_3c2893dd47a7e62b98e04e4a62f28e2f28d17ba5.1920x1080_m2op1k.jpg" }, // Call of Duty: Warzone
                new GameImage { Id = 130, GameId = 26, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632888/VideoGameShop/Call%20of%20Duty-%20Warzone/MWII-NEXT-COD-WZM-TOUT_bws5ta.jpg" }, // Call of Duty: Warzone

                // Images for Game Id = 27 (Fortnite)
                new GameImage { Id = 131, GameId = 27, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632765/VideoGameShop/Fortnite/2x1_NSwitchDS_Fortnite_w2tovi.jpg" }, // Fortnite
                new GameImage { Id = 132, GameId = 27, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/fortnite-home-page-zero-build-promo-slide-desktop-1920x1080-4272f6b5e69e_y8rwth.jpg" }, // Fortnite
                new GameImage { Id = 133, GameId = 27, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1200_tgvg5u.webp" }, // Fortnite
                new GameImage { Id = 134, GameId = 27, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1080_fjmkvp.webp" }, // Fortnite
                new GameImage { Id = 135, GameId = 27, Url = "https://res.cloudinary.com/danedskby/image/upload/v1687632764/VideoGameShop/Fortnite/1207_rdyajp.webp" } // Fortnite
            
            );

            // Configure the relationship between Game and GameImage
            modelBuilder.Entity<Game>()
                .HasMany(g => g.GameImages)
                .WithOne(gi => gi.Game)
                .HasForeignKey(gi => gi.GameId);
        }
    }
}