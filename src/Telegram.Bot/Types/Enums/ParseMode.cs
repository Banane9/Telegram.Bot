using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Enumerates the possible text parsing modes.
    /// <para/>
    /// The Bot API supports basic formatting for messages. You can use bold and italic text,
    /// as well as inline links and pre-formatted code in your bot's messages.
    /// Telegram clients will render them accordingly. You can use either markdown-style or HTML-style formatting.
    /// </summary>
    /// <remarks>
    /// <see href="https://core.telegram.org/bots/api#formatting-options"/>
    /// </remarks>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ParseMode
    {
        /// <summary>
        /// <see cref="Message.Text"/> is plain text.
        /// </summary>
        Default = 0,

        /// <summary>
        /// <see cref="Message.Text"/> is formated in Markdown.
        /// </summary>
        Markdown,

        /// <summary>
        /// <see cref="Message.Text"/> is formated in HTML.
        /// </summary>
        Html,
    }
}
