using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;
using System.Text.Json;
using Telegram.Bot.Types.Enums;

namespace C__IslamBot
{
    internal partial class Program
    {
        private static async Task OnSendMessageAsync(ITelegramBotClient client, Message message, CancellationToken token)
        {
            if (message.Type is MessageType.Text)
            {
                string sendMessage = string.Empty;

                if (message.Text is "/start")
                {
                    await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://qph.cf2.quoracdn.net/main-qimg-7e6505f699b50ffba4aa070f0a1d43eb-lq"),
                        caption: $"☀️ Assalomu alaykum {message.From.FirstName}. Xush kelibsiz!",
                        cancellationToken: token);

                    await MainMenu(client, message, token);
                }
                else if (message.Text is "📍 Eng yaqin Masjid")
                {
                    await EngYaqinMasjid(client, message, token);
                }
                else if (message.Text is "📖 Suralar")
                {
                    await Suralar(client, message, token);
                }
                else if (message.Text is "📚 Hadislar")
                {
                    await Hadislar(client, message, token);
                }
                else if (message.Text is "🕋 Qur'on tafsiri")
                {
                    await Tafsirlar(client, message, token);
                }
                else if (message.Text is "📝 Maruzalar")
                {
                    await Maruzalar(client, message, token);
                }
                else if (message.Text is "🕘 Namoz vaqtlari")
                {
                    await NamozVaqtlari(client, message, token);
                }
                else if (message.Text is "⬅️ Ortga")
                {
                    await MainMenu(client, message, token);
                }


            }
        }

        private static async Task MainMenu(ITelegramBotClient client, Message message, CancellationToken token)
        {
            string sendMessage = $"🤗 Kerakli bo'limni tanlang";

            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                         new KeyboardButton[] { "📍 Eng yaqin Masjid", "📖 Suralar" },
                         new KeyboardButton[] { "📚 Hadislar", "🕋 Qur'on tafsiri" },
                         new KeyboardButton[] { "🕘 Namoz vaqtlari", "📝 Maruzalar"},
                    })
            {
                ResizeKeyboard = true,
                OneTimeKeyboard = true,
            };

            await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: sendMessage,
                cancellationToken: token,
                replyMarkup: replyKeyboardMarkup);
        }

    }
}
