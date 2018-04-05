using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Enumerates the possible types of <see cref="Chat"/>s.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ChatType
    {
        /// <summary>
        /// A normal one to one <see cref="Chat"/>.
        /// </summary>
        Private,

        /// <summary>
        /// A normal group chat.
        /// </summary>
        Group,

        /// <summary>
        /// A channel.
        /// </summary>
        Channel,

        /// <summary>
        /// A supergroup.
        /// </summary>
        Supergroup,
    }
}
