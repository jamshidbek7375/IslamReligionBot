using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace C__IslamBot
{
    internal partial class Program
    {
        private static async Task Tafsirlar(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("1-pora","1-pora"),
                     InlineKeyboardButton.WithCallbackData("2-pora","2-pora"),
                     InlineKeyboardButton.WithCallbackData("3-pora","3-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     
                     InlineKeyboardButton.WithCallbackData("4-pora","4-pora"),
                     InlineKeyboardButton.WithCallbackData("5-pora","5-pora"),
                     InlineKeyboardButton.WithCallbackData("6-pora","6-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("7-pora","7-pora"),
                     InlineKeyboardButton.WithCallbackData("8-pora","8-pora"),
                     InlineKeyboardButton.WithCallbackData("9-pora","9-pora")
                 },
                 new InlineKeyboardButton[]
                 { 
                     InlineKeyboardButton.WithCallbackData("10-pora","10-pora"),
                     InlineKeyboardButton.WithCallbackData("11-pora","11-pora"),
                     InlineKeyboardButton.WithCallbackData("12-pora","12-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("13-pora","13-pora"),
                     InlineKeyboardButton.WithCallbackData("14-pora","14-pora"),
                     InlineKeyboardButton.WithCallbackData("15-pora","15-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("16-pora","16-pora"),
                     InlineKeyboardButton.WithCallbackData("17-pora","17-pora"),
                     InlineKeyboardButton.WithCallbackData("18-pora","18-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("19-pora","19-pora"),
                     InlineKeyboardButton.WithCallbackData("20-pora","20-pora"),
                     InlineKeyboardButton.WithCallbackData("21-pora","21-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("22-pora","22-pora"),
                     InlineKeyboardButton.WithCallbackData("23-pora","23-pora"),
                     InlineKeyboardButton.WithCallbackData("24-pora","24-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("25-pora","25-pora"),
                     InlineKeyboardButton.WithCallbackData("26-pora","26-pora"),
                     InlineKeyboardButton.WithCallbackData("27-pora","27-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("28-pora","28-pora"),
                     InlineKeyboardButton.WithCallbackData("29-pora","29-pora"),
                     InlineKeyboardButton.WithCallbackData("30-pora","30-pora")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga")
                 },
            };

            Message messagee = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://static9.tgstat.ru/channels/_0/54/54932c2cbf663fcb4cc074f1b6c100e8.jpg"),
                        caption: $"Qaysi porani tafsirni tinglamoqchisiz? 🌙",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = messagee.MessageId;
        }
    }
}
