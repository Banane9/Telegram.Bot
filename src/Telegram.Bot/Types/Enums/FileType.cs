using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Enumerates the possible types of an <see cref="IInputFile"/>.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum FileType
    {
        /// <summary>
        /// A file stream.
        /// </summary>
        Stream,

        /// <summary>
        /// A file id.
        /// </summary>
        Id,

        /// <summary>
        /// A file url.
        /// </summary>
        Url,
    }
}
