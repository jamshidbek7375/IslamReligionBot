using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;

namespace C__IslamBot
{
    internal partial class Program
    {
        private static async Task Hadislar(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("Imom Al-Buxoriy. AL-JOMI'AS-SAHIH","1-hadis"),
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("Imom Navaviy.Arbain hadis ","2-hadis"),
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("Imom Ismoiy al-Buxoriy.Al-adab al-mufrad","3-hadis"),
                },
                 new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("Imom Al-Buxoriy\nMuhaddislar sultoni","4-hadis"),
                },
                  new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("Hadislar bolalarga","5-hadis"),
                 },
                   new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("Tarbiyaga oid hadislar","6-hadis"),
                 },
            };
            await client.SendPhotoAsync(
                chatId: message.Chat.Id,
                photo: InputFile.FromString("https://i.pinimg.com/originals/bf/d7/ca/bfd7ca01f49db714680bf6011bde9514.jpg"),
                caption: "📚 Hadis kitoblardan tanlang",
                replyMarkup:inline
                );
        }
    }
}
