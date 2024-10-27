using TabiSaki.Application.Services;
using TabiSaki.Domain.Models;

namespace TabiSaki.Services.Data;

public class DataSeederService
{
    private readonly ILocationService _locationService;

    public DataSeederService(ILocationService locationService)
    {
        _locationService = locationService;
    }

    public async Task SeedSampleDataAsync()
    {
        await _locationService.Create(new Location
        {
            Id = 1,
            Latitude = 35.6622173,
            Longitude = 139.71667,
            Spots = [ 
                new LocationSpot
                {
                    Id = 1, 
                    Name = "Nezu Museum",
                    Description = "Tokyo, Minato",
                    ExternalUrl = "https://maps.app.goo.gl/uRSg37WkJ1ZxXV4z6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 2,
            Latitude = 35.6604621,
            Longitude = 139.7292785,
            Spots = [
                new LocationSpot
                {
                    Id = 2,
                    Name = "teamLab Borderless",
                    Description = "Tokyo, Minato",
                    ExternalUrl = "https://maps.app.goo.gl/8gKwUMCwdWcN28pi7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 3,
            Latitude = 35.694334,
            Longitude = 139.7027175,
            Spots = [
                new LocationSpot
                {
                    Id = 3,
                    Name = "Samurai Restaurant",
                    Description = "Tokyo, Shinjuku, Kabukicho",
                    ExternalUrl = "https://maps.app.goo.gl/pHHV7Dbu6dQngTeN9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 4,
            Latitude = 35.6851806,
            Longitude = 139.7074768,
            Spots = [
                new LocationSpot
                {
                    Id = 4,
                    Name = "Gyoen National Garden",
                    Description = "Tokyo, Shinjuku",
                    ExternalUrl = "https://maps.app.goo.gl/VJ6BLssoUpJK3FyZ9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 5,
            Latitude = 35.6746738,
            Longitude = 139.6980499,
            Spots = [
                new LocationSpot
                {
                    Id = 5,
                    Name = "Meiji Jingu",
                    Description = "Tokyo, Shibuya",
                    ExternalUrl = "https://maps.app.goo.gl/NcdBoUbW9ehtQ3Ff6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 6,
            Latitude = 35.6620232,
            Longitude = 139.6971028,
            Spots = [
                new LocationSpot
                {
                    Id = 6,
                    Name = "Shibuya Parco",
                    Description = "Tokyo, Shibuya",
                    ExternalUrl = "https://maps.app.goo.gl/NcdBoUbW9ehtQ3Ff6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 7,
            Latitude = 35.660518,
            Longitude = 139.6953033,
            Spots = [
                new LocationSpot
                {
                    Id = 7,
                    Name = "MEGA Don Quijote",
                    Description = "Tokyo, Shibuya",
                    ExternalUrl = "https://maps.app.goo.gl/d5ckT17WDvRr85Wv9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 8,
            Latitude = 35.649125,
            Longitude = 139.787199,
            Spots = [
                new LocationSpot
                {
                    Id = 8,
                    Name = "teamLab Planets",
                    Description = "Tokyo, Koto",
                    ExternalUrl = "https://maps.app.goo.gl/zR8M2P2tN7mvPjg66"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 9,
            Latitude = 35.6512604,
            Longitude = 139.8268051,
            Spots = [
                new LocationSpot
                {
                    Id = 9,
                    Name = "Yumenoshima Tropical Greenhouse Dome",
                    Description = "Tokyo, Koto",
                    ExternalUrl = "https://maps.app.goo.gl/EkDfutqs4p6Z1bKU6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 10,
            Latitude = 35.6811902,
            Longitude = 139.7980172,
            Spots = [
                new LocationSpot
                {
                    Id = 10,
                    Name = "Fukagawa Edo Museum",
                    Description = "Tokyo, Koto",
                    ExternalUrl = "https://maps.app.goo.gl/MNYzeLvbcgEmheBr5"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 11,
            Latitude = 35.6933343,
            Longitude = 139.7471327,
            Spots = [
                new LocationSpot
                {
                    Id = 11,
                    Name = "Nippon Budokan",
                    Description = "Tokyo, Chiyoda",
                    ExternalUrl = "https://maps.app.goo.gl/aLKsLdgu9jnyFDpJ6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 12,
            Latitude = 35.6851793,
            Longitude = 139.7502246,
            Spots = [
                new LocationSpot
                {
                    Id = 12,
                    Name = "Imperial Palace",
                    Description = "Tokyo, Chiyoda",
                    ExternalUrl = "https://maps.app.goo.gl/PCv5G61eaVBinBUP8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 13,
            Latitude = 35.6812405,
            Longitude = 139.7645499,
            Spots = [
                new LocationSpot
                {
                    Id = 13,
                    Name = "Tokyo Station",
                    Description = "Tokyo, Chiyoda",
                    ExternalUrl = "https://maps.app.goo.gl/ddC3gr2zkVnsuCuh6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 14,
            Latitude = 35.6649228,
            Longitude = 139.7676446,
            Spots = [
                new LocationSpot
                {
                    Id = 14,
                    Name = "Tsukiji Market",
                    Description = "Tokyo, Chuo",
                    ExternalUrl = "https://maps.app.goo.gl/dFcE9WYUiMrZhmB9A"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 15,
            Latitude = 35.6649228,
            Longitude = 139.7676446,
            Spots = [
                new LocationSpot
                {
                    Id = 15,
                    Name = "Tsukiji Market",
                    Description = "Tokyo, Chuo",
                    ExternalUrl = "https://maps.app.goo.gl/dFcE9WYUiMrZhmB9A"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 16,
            Latitude = 35.6707286,
            Longitude = 139.7625709,
            Spots = [
                new LocationSpot
                {
                    Id = 16,
                    Name = "Ginza",
                    Description = "Tokyo, Chuo",
                    ExternalUrl = "https://maps.app.goo.gl/eJJqMQJv7A7edCBo9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 17,
            Latitude = 35.71476,
            Longitude = 139.7708563,
            Spots = [
                new LocationSpot
                {
                    Id = 17,
                    Name = "Ueno Park",
                    Description = "Tokyo, Taito",
                    ExternalUrl = "https://maps.app.goo.gl/rhjJv66J24MkNwjN7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 18,
            Latitude = 35.7180307,
            Longitude = 139.7741488,
            Spots = [
                new LocationSpot
                {
                    Id = 18,
                    Name = "Tokyo National Museum",
                    Description = "Tokyo, Taito",
                    ExternalUrl = "https://maps.app.goo.gl/5BCmy4hS3neoWug38"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 19,
            Latitude = 35.7147694,
            Longitude = 139.7940804,
            Spots = [
                new LocationSpot
                {
                    Id = 19,
                    Name = "Sensō-ji",
                    Description = "Tokyo, Taito, Asakusa",
                    ExternalUrl = "https://maps.app.goo.gl/MvuqmnkKDJKJzu2F6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 20,
            Latitude = 35.6963356,
            Longitude = 139.7978391,
            Spots = [
                new LocationSpot
                {
                    Id = 20,
                    Name = "The Sumida Hokusai Museum",
                    Description = "Tokyo, Sumida",
                    ExternalUrl = "https://maps.app.goo.gl/VEmbGUsUdiPpTTLR7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 21,
            Latitude = 35.7100627,
            Longitude = 139.8107004,
            Spots = [
                new LocationSpot
                {
                    Id = 21,
                    Name = "Tokyo Skytree",
                    Description = "Tokyo, Sumida",
                    ExternalUrl = "https://maps.app.goo.gl/HZHAtFq95QUP7Dy38"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 22,
            Latitude = 35.7099344,
            Longitude = 139.8070106,
            Spots = [
                new LocationSpot
                {
                    Id = 22,
                    Name = "Sumida Aquarium",
                    Description = "Tokyo, Sumida",
                    ExternalUrl = "https://maps.app.goo.gl/9vyZuQy3ePMbsRiD6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 23,
            Latitude = 35.6997476,
            Longitude = 139.5737018,
            Spots = [
                new LocationSpot
                {
                    Id = 23,
                    Name = "Inokashira Park",
                    Description = "Tokyo, Musashino",
                    ExternalUrl = "https://maps.app.goo.gl/J55p9BBuaSBSKL6e8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 24,
            Latitude = 35.7311486,
            Longitude = 139.7128843,
            Spots = [
                new LocationSpot
                {
                    Id = 24,
                    Name = "Animate main store",
                    Description = "Tokyo, Toshima, Ikebukuro",
                    ExternalUrl = "https://maps.app.goo.gl/Y4jPscn5AVhLQtSz8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 25,
            Latitude = 35.7289297,
            Longitude = 139.7175824,
            Spots = [
                new LocationSpot
                {
                    Id = 25,
                    Name = "Sunshine Aquarium",
                    Description = "Tokyo, Toshima, Ikebukuro",
                    ExternalUrl = "https://maps.app.goo.gl/i48ezvJS3RW1ZBQaA"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 26,
            Latitude = 35.6488167,
            Longitude = 139.6449061,
            Spots = [
                new LocationSpot
                {
                    Id = 26,
                    Name = "Gōtokuji Temple",
                    Description = "Tokyo, Setagaya",
                    ExternalUrl = "https://maps.app.goo.gl/3MzGtHpMCb1wnYEv5"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 27,
            Latitude = 35.6668493,
            Longitude = 139.6085858,
            Spots = [
                new LocationSpot
                {
                    Id = 27,
                    Name = "Setagaya Literary Museum",
                    Description = "Tokyo, Setagaya",
                    ExternalUrl = "https://maps.app.goo.gl/Dwe1ZG8SWLvdaGr88"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 28,
            Latitude = 35.7165647,
            Longitude = 139.5151361,
            Spots = [
                new LocationSpot
                {
                    Id = 28,
                    Name = "Koganei Park",
                    Description = "Tokyo, Koganei",
                    ExternalUrl = "https://maps.app.goo.gl/R9NuNVGaoogc8uzJ9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 29,
            Latitude = 35.7192336,
            Longitude = 139.5114704,
            Spots = [
                new LocationSpot
                {
                    Id = 29,
                    Name = "Edo-Tokyo Open Air Architectural Museum",
                    Description = "Tokyo, Koganei",
                    ExternalUrl = "https://maps.app.goo.gl/SinQwX5zu5ExuxsS6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 30,
            Latitude = 35.6322148,
            Longitude = 139.7133811,
            Spots = [
                new LocationSpot
                {
                    Id = 30,
                    Name = "Hotel Gajoen Art Gallery",
                    Description = "Tokyo, Meguro",
                    ExternalUrl = "https://maps.app.goo.gl/5UKVUwG2C9yvCLeS9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 31,
            Latitude = 35.6329007,
            Longitude = 139.8778194,
            Spots = [
                new LocationSpot
                {
                    Id = 31,
                    Name = "Tokyo Disneyland",
                    Description = "Chiba, Urayasu",
                    ExternalUrl = "https://maps.app.goo.gl/cBvS5WvqBJXkdqD18"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 32,
            Latitude = 35.6552434,
            Longitude = 139.8985176,
            Spots = [
                new LocationSpot
                {
                    Id = 32,
                    Name = "Urayasu City Folk Museum",
                    Description = "Chiba, Urayasu",
                    ExternalUrl = "https://maps.app.goo.gl/yJ8QMmRoFRKCXXLaA"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 33,
            Latitude = 35.8709843,
            Longitude = 139.3247549,
            Spots = [
                new LocationSpot
                {
                    Id = 33,
                    Name = "MOOMINVALLEY PARK",
                    Description = "Saitama, Hanno",
                    ExternalUrl = "https://maps.app.goo.gl/uLRf3CQQpWDSCH7z5"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 34,
            Latitude = 35.624539,
            Longitude = 139.4292877,
            Spots = [
                new LocationSpot
                {
                    Id = 34,
                    Name = "Sanrio Puroland",
                    Description = "Tokyo, Tama",
                    ExternalUrl = "https://maps.app.goo.gl/UtqFsKcVM6gantN86"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 35,
            Latitude = 35.4868018,
            Longitude = 138.7852424,
            Spots = [
                new LocationSpot
                {
                    Id = 35,
                    Name = "Fuji-Q Highland",
                    Description = "Fujiyoshida",
                    ExternalUrl = "https://maps.app.goo.gl/bu5ttAqWAq8hhPTz5"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 36,
            Latitude = 36.7580921,
            Longitude = 139.5961717,
            Spots = [
                new LocationSpot
                {
                    Id = 36,
                    Name = "Nikkō Tōshogū",
                    Description = "Nikko",
                    ExternalUrl = "https://maps.app.goo.gl/gyUUxHPHtRk3C2yg8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 37,
            Latitude = 36.7534069,
            Longitude = 139.5981985,
            Spots = [
                new LocationSpot
                {
                    Id = 37,
                    Name = "Shinkyō Bridge",
                    Description = "Nikko",
                    ExternalUrl = "https://maps.app.goo.gl/8XQjFLUcgabTcxoQ9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 38,
            Latitude = 36.7727497,
            Longitude = 139.6947831,
            Spots = [
                new LocationSpot
                {
                    Id = 38,
                    Name = "Edo Wonderland Nikko Edomura",
                    Description = "Nikko",
                    ExternalUrl = "https://maps.app.goo.gl/x85FdBxKX117B7rC9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 39,
            Latitude = 35.6962306,
            Longitude = 139.5703883,
            Spots = [
                new LocationSpot
                {
                    Id = 39,
                    Name = "Ghibli Museum",
                    Description = "Tokyo, Mitaka",
                    ExternalUrl = "https://maps.app.goo.gl/rBbzGixG2PKrBZoK7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 40,
            Latitude = 35.7035771,
            Longitude = 139.5790183,
            Spots = [
                new LocationSpot
                {
                    Id = 40,
                    Name = "Harmonica Yokocho",
                    Description = "Tokyo, Musashino",
                    ExternalUrl = "https://maps.app.goo.gl/wr96oHePC19aKUND6"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 41,
            Latitude = 35.7137096,
            Longitude = 139.7942256,
            Spots = [
                new LocationSpot
                {
                    Id = 41,
                    Name = "Asakusa Koji",
                    Description = "Tokyo, Taito, Asakusa",
                    ExternalUrl = "https://maps.app.goo.gl/BatuUu6BXafw8mQh8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 42,
            Latitude = 35.6929594,
            Longitude = 139.6995019,
            Spots = [
                new LocationSpot
                {
                    Id = 42,
                    Name = "Omoide Yokocho",
                    Description = "Tokyo, Shinjuku",
                    ExternalUrl = "https://maps.app.goo.gl/3EHT5xXbqq6nKN5k7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 43,
            Latitude = 35.6940739,
            Longitude = 139.7047277,
            Spots = [
                new LocationSpot
                {
                    Id = 43,
                    Name = "Shinjuku Golden-Gai",
                    Description = "Tokyo, Shinjuku, Kabukichou",
                    ExternalUrl = "https://maps.app.goo.gl/KD4eoxNSv66s1Piq9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 44,
            Latitude = 35.9235197,
            Longitude = 139.4828118,
            Spots = [
                new LocationSpot
                {
                    Id = 44,
                    Name = "Kurazukuri Street",
                    Description = "Saitama, Kawagoe",
                    ExternalUrl = "https://maps.app.goo.gl/4WLk8GKYr8idNYNP7"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 45,
            Latitude = 35.9250453,
            Longitude = 139.4810888,
            Spots = [
                new LocationSpot
                {
                    Id = 45,
                    Name = "Kashiya Yokocho",
                    Description = "Saitama, Kawagoe",
                    ExternalUrl = "https://maps.app.goo.gl/EreRCcTPMA4Wy6Hq9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 46,
            Latitude = 35.7976482,
            Longitude = 139.5075734,
            Spots = [
                new LocationSpot
                {
                    Id = 46,
                    Name = "Kadokawa Musashino Museum",
                    Description = "Saitama, Tokorozawa",
                    ExternalUrl = "https://maps.app.goo.gl/gXbAb3jhTNQXB8fm8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 47,
            Latitude = 35.7243029,
            Longitude = 139.6860927,
            Spots = [
                new LocationSpot
                {
                    Id = 47,
                    Name = "Tokiwaso Manga Museum",
                    Description = "Tokyo, Toshima",
                    ExternalUrl = "https://maps.app.goo.gl/VkzHijC5rEaZ7Lo19"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 48,
            Latitude = 35.3168206,
            Longitude = 139.5356567,
            Spots = [
                new LocationSpot
                {
                    Id = 48,
                    Name = "Kotoku-in",
                    Description = "Kamakura",
                    ExternalUrl = "https://maps.app.goo.gl/AJgYBDYBWcFdDqgR9"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 49,
            Latitude = 35.3199569,
            Longitude = 139.5692115,
            Spots = [
                new LocationSpot
                {
                    Id = 49,
                    Name = "Hokoku-ji",
                    Description = "Kamakura",
                    ExternalUrl = "https://maps.app.goo.gl/Dr6W6fcvEdHtxWyG8"
                }
            ]
        });

        await _locationService.Create(new Location
        {
            Id = 50,
            Latitude = 35.312455,
            Longitude = 139.5330366,
            Spots = [
                new LocationSpot
                {
                    Id = 50,
                    Name = "Hasedera",
                    Description = "Kamakura",
                    ExternalUrl = "https://maps.app.goo.gl/TRnBWuLyUbnU78NS9"
                }
            ]
        });
    }
}
