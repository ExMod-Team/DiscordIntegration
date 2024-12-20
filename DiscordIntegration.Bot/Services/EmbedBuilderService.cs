namespace DiscordIntegration.Bot.Services;

using Discord;
using System.Reflection;
using System.Threading.Tasks;

public class EmbedBuilderService
{
    public static string Footer => $"Discord Integration | {Assembly.GetExecutingAssembly().GetName().Version} | - Joker119";

    public static async Task<Embed> CreateBasicEmbed(string title, string description, Color color) => await Task.Run(() => new EmbedBuilder().WithTitle(title).WithDescription(description).WithColor(color).WithCurrentTimestamp().WithFooter(Footer).Build());
}