using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Threading;
using Telegram.Bot.Types.Enums;

namespace C__IslamBot
{
    internal partial class Program
    {
        private static async Task Maruzalar(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("Sardor domla 👳🏻‍♂️ 🤲🏻","Sardor"),
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("Solihon domla 👳🏽‍♂️ 🤲🏽","Solihon"),
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("Nuriddin domla 👳🏼‍♂️ 🤲🏼","Nuriddin"),
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://yt3.googleusercontent.com/BBONyFAAfw2WOSCisjDhPH3Rlq1Naf5D6HPlXHmVqiWgbzBy_yovX0NLNINLTGw7drp2YqEytw=s900-c-k-c0x00ffffff-no-rj"),
                        caption: $"Domlani Tanlang 🌙",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task SardorDomla(ITelegramBotClient client, Message message, CancellationToken token)
        {
            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://static1.tgstat.ru/channels/_0/71/71da231e0aa634ba1cc328278c8dbcd4.jpg"),
                        caption: "<i>Sardor domlaning</i> <b>You Tube</b> <i>kanaliga o'tish uchun</i> <a href=\"https://www.youtube.com/@SardorDomla\">shu yerni bosing</a>",
                        parseMode: ParseMode.Html,
                        cancellationToken: token);
        }

        private static async Task SolihonDomla(ITelegramBotClient client, Message message, CancellationToken token)
        {
            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://yt3.googleusercontent.com/ytc/APkrFKYO-4onnEhzdu70CJ-fogC1HH5VjYfJm5kq6GA0=s900-c-k-c0x00ffffff-no-rj"),
                        caption: "<i>Solihon domlaning</i> <b>You Tube</b> <i>kanaliga o'tish uchun</i> <a href=\"https://www.youtube.com/@Firdavs1\">shu yerni bosing</a>",
                        parseMode: ParseMode.Html,
                        cancellationToken: token);
        }

        private static async Task NuriddinDomla(ITelegramBotClient client, Message message, CancellationToken token)
        {
            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://uzreport.news/fotobank/image/b9868da07986b2e71d4754ee531f7060.jpeg"),
                        caption: "<i>Nuriddin domlaning</i> <b>You Tube</b> <i>kanaliga o'tish uchun</i> <a href=\"https://www.youtube.com/@Muslimuzz/featured\">shu yerni bosing</a>",
                        parseMode: ParseMode.Html,
                        cancellationToken: token);
        }
    }
}
