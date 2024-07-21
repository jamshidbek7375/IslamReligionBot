using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace C__IslamBot
{
    internal partial class Program
    {
        private static async Task NamozVaqtlari(ITelegramBotClient client, Message message, CancellationToken token)
        {
            Message stiker = await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: "⏳",
                cancellationToken: token);

            ReplyKeyboardMarkup ortga = new(new[]
            {
                new KeyboardButton[] { "⬅️ Ortga" }
            })
            {
                ResizeKeyboard = true
            };
            string datetime = message.Date.Day + "-" + message.Date.Month + "-" + message.Date.Year;
            string cityName = "Tashkent";
            HttpClient httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(@$"https://api.aladhan.com/v1/timingsByCity/{datetime}?city={cityName}&country=UZ&method=2");
            //Stream data = await httpClient.GetStreamAsync("");
            string datastring = await httpClient.GetStringAsync("");
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            Root? root = JsonSerializer.Deserialize<Root>(datastring, options);
            string weath = @$"🏙 Shahar : <strong>{cityName}</strong>
🗓 Hijriy sana : <strong>{root?.data.date.hijri.date}</strong>
📅 Hozirgi sana : <strong>{root?.data.date.readable}</strong>
🕌 Bomdod kirish vaqti : <strong>{root?.data.timings.Fajr}</strong>
🌅 Quyosh chiqish vaqti : <strong>{root?.data.timings.Sunrise}</strong>
🏞 Peshin vaqti : <strong>{root?.data.timings.Dhuhr}</strong>
🌆 Asr vaqti : <strong>{root?.data.timings.Asr}</strong>
🏙 Shom vaqti : <strong>{root?.data.timings.Sunset}</strong>
🌌 Hufton vaqti : <strong>{root?.data.timings.Isha}</strong>";

            

            Thread.Sleep(1000);

            Message messagee = await client.SendTextMessageAsync(
                chatId: message.Chat.Id,
                text: weath,
                replyMarkup: ortga,
                cancellationToken: token,
                parseMode: ParseMode.Html);

            await client.DeleteMessageAsync(
                chatId: message.Chat.Id,
                messageId: stiker.MessageId,
                cancellationToken: token);
        }
    }
}
