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
        private static async Task Suralar(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("📖1-20","1-20"),
                     InlineKeyboardButton.WithCallbackData("📖20-40","20-40")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("📖40-60","40-60"),
                     InlineKeyboardButton.WithCallbackData("📖60-80","60-80")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("📖80-100","80-100"),
                     InlineKeyboardButton.WithCallbackData("📖100-114","100-114")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task Bir_20(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("1. Al-Faatiha","1"),
                     InlineKeyboardButton.WithCallbackData("2. Al-Baqara","2")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("3. Aal-i-Imraan","3"),
                     InlineKeyboardButton.WithCallbackData("4. An-Nisaa","4")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("5. Al-Maaida","5"),
                     InlineKeyboardButton.WithCallbackData("6. Al-An'aam","6")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("7. Al-A'raaf","7"),
                     InlineKeyboardButton.WithCallbackData("8. Al-Anfaal","8")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("9. At-Tawba","9"),
                     InlineKeyboardButton.WithCallbackData("10. Yunus","10")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("11. Hud","11"),
                     InlineKeyboardButton.WithCallbackData("12. Yusuf","12")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("13. Ar-Ra'd","13"),
                     InlineKeyboardButton.WithCallbackData("14. Ibrahim","14")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("15. Al-Hijr","15"),
                     InlineKeyboardButton.WithCallbackData("16. An-Nahl","16")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("17. Al-Israa","17"),
                     InlineKeyboardButton.WithCallbackData("18. Al-Kahf","18")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("19. Maryam","19"),
                     InlineKeyboardButton.WithCallbackData("20. Taa-Haa","20")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalMessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalMessage.MessageId;
        }

        private static async Task Yigirma_40(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("21. Al-Anbiyaa","21"),
                    InlineKeyboardButton.WithCallbackData("22. Al-Hajj","22")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("23. Al-Muminoon","23"),
                    InlineKeyboardButton.WithCallbackData("24. An-Noor","24")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("25. Al-Furqaan","25"),
                    InlineKeyboardButton.WithCallbackData("26. Ash-Shu'araa","26")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("27. Al-Naml","27"),
                    InlineKeyboardButton.WithCallbackData("28. Al-Qasas","28")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("29. Al-Ankaboot","28"),
                    InlineKeyboardButton.WithCallbackData("30. Ar-Room","30")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("31. Luqman","31"),
                    InlineKeyboardButton.WithCallbackData("32. As-Sajda","32")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("33. Al-Ahzaab","33"),
                    InlineKeyboardButton.WithCallbackData("34. Saba","34")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("35. Faatir","35"),
                    InlineKeyboardButton.WithCallbackData("36. Yaseen","36")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("37. As-Saaffaat","37"),
                    InlineKeyboardButton.WithCallbackData("38. Saad","38")
                 },
                 new InlineKeyboardButton[]
                 {
                    InlineKeyboardButton.WithCallbackData("39. Az-Zumar","38"),
                    InlineKeyboardButton.WithCallbackData("40. Ghafir","40")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task Qirq_60(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("41. Fussilat","41"),
                     InlineKeyboardButton.WithCallbackData("42. Ash-Shura","42")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("43. Az-Zukhruf","43"),
                     InlineKeyboardButton.WithCallbackData("44. Ad-Dukhaan","44")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("45. Al-Jaathiya","45"),
                     InlineKeyboardButton.WithCallbackData("46. Al-Ahqaf","46")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("47. Muhammad","47"),
                     InlineKeyboardButton.WithCallbackData("48. Al-Fath","48")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("49. Al-Hujuraat","49"),
                     InlineKeyboardButton.WithCallbackData("50. Qaaf","50")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("51. Adh-Dhaariyat","51"),
                     InlineKeyboardButton.WithCallbackData("52. At-Tur","52")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("53. An-Najm","53"),
                     InlineKeyboardButton.WithCallbackData("54. Al-Qamar","54")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("55. Ar-Rahmaan","55"),
                     InlineKeyboardButton.WithCallbackData("56. Al-Waaqia","56")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("57. Al-Hadid","57"),
                     InlineKeyboardButton.WithCallbackData("58. Al-Mujaadila","58")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("59. Al-Hashr","59"),
                     InlineKeyboardButton.WithCallbackData("60. Al-Mumtahana","60")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task Oltmish_80(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("61. As-Saff","61"),
                     InlineKeyboardButton.WithCallbackData("62. Al-Jumu'a","62")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("63. Al-Munaafiqoon","63"),
                     InlineKeyboardButton.WithCallbackData("64. At-Taghaabun","64")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("65. At-Talaaq","65"),
                     InlineKeyboardButton.WithCallbackData("66. At-Tahrim","66")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("67. Al-Mulk","67"),
                     InlineKeyboardButton.WithCallbackData("68. Al-Qalam","68")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("69. Al-Haaqqa","69"),
                     InlineKeyboardButton.WithCallbackData("70. Al-Ma'aarij","70")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("71. Nooh","71"),
                     InlineKeyboardButton.WithCallbackData("72. Al-Jinn","72")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("73. Al-Muzzammil","73"),
                     InlineKeyboardButton.WithCallbackData("74. Al-Muddaththir","74")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("75. Al-Qiyaama","75"),
                     InlineKeyboardButton.WithCallbackData("76. Al-Insaan","76")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("77. Al-Mursalaat","77"),
                     InlineKeyboardButton.WithCallbackData("78. An-Naba","78")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("79. Al-Naazi'aat","79"),
                     InlineKeyboardButton.WithCallbackData("80. Abasa","80")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task Sakson_100(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("81. At-Takwir","81"),
                     InlineKeyboardButton.WithCallbackData("82. Al-Infitaar","82")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("83. Al-Mutaffifin","83"),
                     InlineKeyboardButton.WithCallbackData("84. Al-Inshiqaaq","84")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("85. Al-Burooj","85"),
                     InlineKeyboardButton.WithCallbackData("86. At-Taariq","86")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("87. Al-A'laa","87"),
                     InlineKeyboardButton.WithCallbackData("88. Al-Ghaashiya","88")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("89. Al-Fajr","89"),
                     InlineKeyboardButton.WithCallbackData("90. Al-Balad","90")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("91. Ash-Shams","91"),
                     InlineKeyboardButton.WithCallbackData("92. Al-Lail","92")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("93. Ad-Dhuhaa","93"),
                     InlineKeyboardButton.WithCallbackData("94. Ash-Sharh","94")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("95. At-Tin","95"),
                     InlineKeyboardButton.WithCallbackData("96. Al-Alaq","96")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("97. Al-Qadr","97"),
                     InlineKeyboardButton.WithCallbackData("98. Al-Bayyina","98")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("99. Az-Zalzala","99"),
                     InlineKeyboardButton.WithCallbackData("100. Al-Aadiyaat","100")
                 },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }

        private static async Task Yuz_114(ITelegramBotClient client, Message message, CancellationToken token)
        {
            InlineKeyboardMarkup inline = new InlineKeyboardButton[][]
            {
                 new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("101. Al-Qaari'a","101"),
                    InlineKeyboardButton.WithCallbackData("102. At-Takaathur","102")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("103. Al-Asr","103"),
                    InlineKeyboardButton.WithCallbackData("104. Al-Humaza","104")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("105. Al-Fil","105"),
                    InlineKeyboardButton.WithCallbackData("106. Quraish","106")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("107. Al-Maa'un","107"),
                    InlineKeyboardButton.WithCallbackData("108. Al-Kawthar","108")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("109. Al-Kaafiroon","109"),
                    InlineKeyboardButton.WithCallbackData("110. An-Nasr","110")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("111. Al-Masad","111"),
                    InlineKeyboardButton.WithCallbackData("112. Al-Ilkhlaas","112")
                },
                new InlineKeyboardButton[]
                {
                    InlineKeyboardButton.WithCallbackData("113. Al-Falaq","113"),
                    InlineKeyboardButton.WithCallbackData("114. An-Naas","114")
                },
                 new InlineKeyboardButton[]
                 {
                     InlineKeyboardButton.WithCallbackData("⬅️Ortga","ortga qaytish")
                 },
            };

            Message originalmessage = await client.SendPhotoAsync(
                        chatId: message.Chat.Id,
                        photo: InputFile.FromUri("https://aniq.uz/photos/news/Zu7HRPr4r0aqtWd.jpeg"),
                        caption: $"Suralarni Tanlang 📖 ✅",
                        cancellationToken: token,
                        replyMarkup: inline);

            originalMessageID = originalmessage.MessageId;
        }
    }
}
