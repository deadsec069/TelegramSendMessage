using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

class Program
{
    static async Task Main(string[] args)
    {
        // Api Token
        string apiToken = "Token Bot Api";

        // Chat ID
        string chatId = "Chat ID";

        var botClient = new TelegramBotClient(apiToken);

        while (true)
        {
            // Input
            Console.WriteLine("Please enter the message to send (or type 'exit' to quit):");
            string message = Console.ReadLine();

            // If Exit
            if (message.ToLower() == "exit")
            {
                break;
            }

            // ReSend
            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: message,
                parseMode: ParseMode.Html
            );

            Console.WriteLine("Message sent!");
        }
    }
}
