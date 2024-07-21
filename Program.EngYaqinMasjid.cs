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
        private static async Task EngYaqinMasjid(ITelegramBotClient client, Message message, CancellationToken token)
        {
            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new KeyboardButton[] { KeyboardButton.WithRequestLocation("📌 Lokatsiya jo'natish") },

                new KeyboardButton[] { "⬅️ Ortga" },
            })
            {
                ResizeKeyboard = true
            };

            Message sentMessage = await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "📍 Geolokatsiya jo'nating!",
                replyMarkup: replyKeyboardMarkup,
                cancellationToken: token);

            originalMessageID = sentMessage.MessageId;
        }

    }
}
