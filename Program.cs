using System.Text.Json;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace C__IslamBot
{
    internal partial class Program
    {
        static int originalMessageID;

        static double[,] MasjidLocation = new double[,]
        {
            { 41.32380686834686, 69.23725786269655 },
            { 41.27722894194773, 69.21575493537212 },
            { 41.27514332620078, 69.16895246279884 },
            { 41.23698811343413, 69.18816171782477 },
            { 41.2770593943496, 69.30918560736721 },
            { 41.29087853003742, 69.19678305414851 },
            { 41.29025436643968, 69.24596611922892 },
            { 41.2940181988261, 69.2269556059312 },
            { 41.3058141642207, 69.23010897992353 },
            { 41.33216640604701, 69.30181332213795 },
            { 41.35019763253878, 69.2690814713237 },
            { 41.32961337567282, 69.23364727201445 },
            { 41.335320853642294, 69.27503318197064 },

        };

        static string[,] MasjidLocationAddress = new string[,]
        {
            { "🕌 Xo'ja Axror Vali Masjidi", "86FP+FRP, Samarqand Darvoza ko'chasi, Тоshkent, Uzbekistan" },
            { "🕌 Qo'zirobod Jome' Masjidi", "76G8+V8J, Chilonzor ko'chasi, Тоshkent, Uzbekistan" },
            { "🕌 Abdulloh Ibn Ma'sud Jome' Masjidi", "Абдуллоҳ ибн Масъуд жоме масжиди, Lutfi ko'chasi, Тоshkent, Uzbekistan" },
            { "🕌 Choshtepa Jome' Masjidi", "65PQ+R73, Choshtepa ko'chasi, Toshkent, Uzbekistan" },
            { "🕌 Islom Ota Masjidi", "78G5+VPR, Zarkent ko'chasi, Toshkent, Uzbekistan" },
            { "🕌 Ko'zi Ojizlar Jome' Masjidi", "75RW+9PF, Малая кольцевая дорога, Tashkent, Uzbekistan" },
            { "🕌 Rakat Jome' Masjidi", "Mechet Rakat Zhome', Abdulla Avloniy ko'chasi, Tashkent, Uzbekistan" },
            { "🕌 Novza Jome' Masjidi", "проспект Бунёдкор 7, 100043, Toshkent, Uzbekistan" },
            { "🕌 Kamolon Masjidi", "864J+82H, Yangiobod ko'chasi, Toshkent, Uzbekistan" },
            { "🕌 Oqqo'rg'on Masjidi", "Мирзо-Улугбекский район, Toshkent, Uzbekistan" },
            { "🕌 Umar Ibn Al-Hattab Masjidi", "9729+3JG, Tog'ora ko'chasi, Toshkent, Uzbekistan" },
            { "🕌 To'xtaboy Jome' Masjidi", "To'xtaboy Jome Masjidi, Farobi ko'chasi, Toshkent, Uzbekistan" },
            { "🕌 Minor Masjidi", "87PG+42F, Kichik Xalqa Yo'li, Тоshkent, Uzbekistan" },

        };

        static void Main(string[] args)
        {
            const string token = "6815935014:AAE080akkrQpBeRyu1S6YbEuRTUIBEGUoWw";

            TelegramBotClient telegramBotClient = new TelegramBotClient(token);

            ReceiverOptions receiverOptions = new ReceiverOptions
            {
                AllowedUpdates = { }
            };

            CancellationTokenSource tokenSource = new CancellationTokenSource();

            telegramBotClient.StartReceiving(
                updateHandler: UpdateHandlerAsync,
                pollingErrorHandler: ErrorHandlerAsync,
                receiverOptions: receiverOptions,
                cancellationToken: tokenSource.Token);

            Console.ReadKey();
        }

        private static Task ErrorHandlerAsync(ITelegramBotClient client, Exception exception, CancellationToken token)
        {
            var errorMessage = exception switch
            {
                ApiRequestException apiRequestException =>
                    $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };

            Console.WriteLine(errorMessage);
            return Task.CompletedTask;
        }

        private static async Task UpdateHandlerAsync(ITelegramBotClient client, Update update, CancellationToken token)
        {
            //return;
            if (update is null)
            {
                return;
            }
            else if (update.Message is not null && update.Message.Type is not MessageType.Location)
            {
                await OnSendMessageAsync(client, update.Message, token);
            }
            else if (update.CallbackQuery is not null)
            {
                string callbackData = update.CallbackQuery.Data;

                switch (callbackData)
                {
                    case "ortga":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );

                        await MainMenu(client, update.CallbackQuery.Message, token);
                        break;
                    case "ortga qaytish":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );

                        await Suralar(client, update.CallbackQuery.Message, token);
                        break;
                    case "ortga qaytish2":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );

                        await Maruzalar(client, update.CallbackQuery.Message, token);
                        break;
                    case "1-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=xzSauP9mPKA&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=1&t=149s",
                             cancellationToken: token);
                        break;
                    case "2-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=cTDaPxhY7NU&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=2",
                             cancellationToken: token);
                        break;
                    case "3-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=WhUIL5Tc6bk&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=3",
                             cancellationToken: token);
                        break;
                    case "4-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=zZ4RI8YZMrI&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=4",
                             cancellationToken: token);
                        break;
                    case "5-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=rHNlnEBU3Ts&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=5",
                             cancellationToken: token);
                        break;
                    case "6-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=wQse7TlArNI&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=6",
                             cancellationToken: token);
                        break;
                    case "7-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=Z5PvXCGp5jo&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=7",
                             cancellationToken: token);
                        break;
                    case "8-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=JgRi8LE1u3E&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=8",
                             cancellationToken: token);
                        break;
                    case "9-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=hKLPm82b8yk&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=9",
                             cancellationToken: token);
                        break;
                    case "10-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=yo_HDCe-OO0&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=10",
                             cancellationToken: token);
                        break;
                    case "11-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=ksCGNKc8LzA&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=11",
                             cancellationToken: token);
                        break;
                    case "12-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=14lMraGqJ8c&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=12",
                             cancellationToken: token);
                        break;
                    case "13-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=rDXb1nHb5Sg&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=13",
                             cancellationToken: token);
                        break;
                    case "14-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=YWoiIbFJ6gs&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=14",
                             cancellationToken: token);
                        break;
                    case "15-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=jTjxF6K5dT8&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=15",
                             cancellationToken: token);
                        break;
                    case "16-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=Vm7rF_0866c&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=16",
                             cancellationToken: token);
                        break;
                    case "17-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=MT1kXi34Jz8&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=17",
                             cancellationToken: token);
                        break;
                    case "18-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=vOxtY9pQWP4&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=18",
                             cancellationToken: token);
                        break;
                    case "19-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=-ZzuWvCFbLQ&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=19",
                             cancellationToken: token);
                        break;
                    case "20-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=3LLZIfhMBkk",
                             cancellationToken: token);
                        break;
                    case "21-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=PmWfJ2e971Q&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=20",
                             cancellationToken: token);
                        break;
                    case "22-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=Y1Q7IBO1V5g&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=21",
                             cancellationToken: token);
                        break;
                    case "23-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=-BJ2ZDGepk0&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=22",
                             cancellationToken: token);
                        break;
                    case "24-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=dwb5dy1VSPI&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=23",
                             cancellationToken: token);
                        break;
                    case "25-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=z2p8lQSEcNE&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=24",
                             cancellationToken: token);
                        break;
                    case "26-pora":
                        await client.SendTextMessageAsync(
                              chatId: update.CallbackQuery.Message.Chat.Id,
                              text: "https://www.youtube.com/watch?v=iFQFlLJwVv8&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=25",
                              cancellationToken: token);
                        break;
                    case "27-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=a5TXRoY_ZQ8&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=26",
                             cancellationToken: token);
                        break;
                    case "28-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=es98f4RiLxU&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=27",
                             cancellationToken: token);
                        break;
                    case "29-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=198WO1R6Ybg&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=28",
                             cancellationToken: token);
                        break;
                    case "30-pora":
                        await client.SendTextMessageAsync(
                             chatId: update.CallbackQuery.Message.Chat.Id,
                             text: "https://www.youtube.com/watch?v=qtbZrccoNGw&list=PLs1qgbOiEa209tOiG-QVdd0f7WNH_2K9U&index=29",
                             cancellationToken: token);
                        break;
                    case "1-20":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Bir_20(client, update.CallbackQuery.Message, token);
                        break;
                    case "20-40":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Yigirma_40(client, update.CallbackQuery.Message, token);
                        break;
                    case "40-60":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Qirq_60(client, update.CallbackQuery.Message, token);
                        break;
                    case "60-80":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Oltmish_80(client, update.CallbackQuery.Message, token);
                        break;
                    case "80-100":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Sakson_100(client, update.CallbackQuery.Message, token);
                        break;
                    case "100-114":
                        await client.DeleteMessageAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            messageId: originalMessageID,
                            cancellationToken: token
                            );
                        Yuz_114(client, update.CallbackQuery.Message, token);
                        break;
                    case "Sardor":
                        SardorDomla(client, update.CallbackQuery.Message, token);
                        break;
                    case "Solihon":
                        SolihonDomla(client, update.CallbackQuery.Message, token);
                        break;
                    case "Nuriddin":
                        NuriddinDomla(client, update.CallbackQuery.Message, token);
                        break;
                    case "1-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://library.tsdi.uz/storage/books/March2022/xIafZXcJ97NUJ8vM5sl3.pdf"));
                        break;
                    case "2-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://n.ziyouz.com/books/islomiy/hadis/Imom%20Navaviy.%20Arbain%20hadis.pdf"));
                        break;
                    case "3-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://library.navoiy-uni.uz/files/al-adab%20al-mufrad.%20imom%20ismoil%20al-buxoriy.pdf"));
                        break;
                    case "4-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://library.tsdi.uz/storage/books/March2022/xIafZXcJ97NUJ8vM5sl3.pdf"));
                        break;
                    case "5-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://library.navoiy-uni.uz/files/hadislar%20bolalarga.pdf"));
                        break;
                    case "6-hadis":
                        await client.SendDocumentAsync(
                            chatId: update.CallbackQuery.Message.Chat.Id,
                            document: InputFile.FromUri("https://lib.samtuit.uz/uploads/files/61e0051b45ee54.11370990.pdf"));
                        break;




                }

                if (int.TryParse(callbackData, out int callbackNumber))
                {
                    int audioNumber = callbackNumber + 115;
                    string audioUri = $"https://t.me/suralar_114_audio/{audioNumber}";

                    await client.SendAudioAsync(
                        chatId: update.CallbackQuery.Message.Chat.Id,
                        audio: InputFile.FromUri(audioUri),
                        cancellationToken: token);
                }

            }
            else if (update.Message.Type is MessageType.Location)
            {
                double userLongitude = update.Message.Location.Longitude;
                double userLatitude = update.Message.Location.Latitude;

                double minDistance = double.MaxValue;
                int closestMasjidIndex = -1;

                for (int i = 0; i < MasjidLocation.GetLength(0); i++)
                {
                    double masjidLongitude = MasjidLocation[i, 1];
                    double masjidLatitude = MasjidLocation[i, 0];

                    double distance = Math.Sqrt(Math.Pow(userLongitude - masjidLongitude, 2) + Math.Pow(userLatitude - masjidLatitude, 2));

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestMasjidIndex = i;
                    }
                }

                if (closestMasjidIndex != -1)
                {
                    Message message = await client.SendLocationAsync(
                        chatId: update.Message.Chat.Id,
                        latitude: (float)MasjidLocation[closestMasjidIndex, 0],
                        longitude: (float)MasjidLocation[closestMasjidIndex, 1],
                        cancellationToken: token);

                    await client.SendTextMessageAsync(
                        chatId: message.Chat.Id,
                        text: MasjidLocationAddress[closestMasjidIndex, 0]+ "\n" + MasjidLocationAddress[closestMasjidIndex, 1],
                        cancellationToken: token);
                }
            }
            
        }          

    }
}
