using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Enumerates the possible types of a <see cref="MessageEntity"/>.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum MessageEntityType
    {
        /// <summary>
        /// A mentioned <see cref="User"/>.
        /// </summary>
        Mention,

        /// <summary>
        /// A searchable Hashtag.
        /// </summary>
        Hashtag,

        /// <summary>
        /// A Bot command.
        /// </summary>
        [EnumMember(Value = "bot_command")]
        BotCommand,

        /// <summary>
        /// A url.
        /// </summary>
        Url,

        /// <summary>
        /// An email.
        /// </summary>
        Email,

        /// <summary>
        /// A bold text.
        /// </summary>
        Bold,

        /// <summary>
        /// An italic text.
        /// </summary>
        Italic,

        /// <summary>
        /// An inline mono-width text.
        /// </summary>
        Code,

        /// <summary>
        /// A mono-width text block.
        /// </summary>
        Pre,

        /// <summary>
        /// A clickable text url.
        /// </summary>
        [EnumMember(Value = "text_link")]
        TextLink,

        /// <summary>
        /// A mention for a <see cref="User"/> without a set <see cref="User.Username"/>.
        /// </summary>
        [EnumMember(Value = "text_mention")]
        TextMention,
    }
}
