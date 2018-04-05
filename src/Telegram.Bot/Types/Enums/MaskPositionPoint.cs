using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Telegram.Bot.Types.Enums
{
    /// <summary>
    /// Enumerates the possible parts of the face relative to which the mask can be placed.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum MaskPositionPoint
    {
        /// <summary>
        /// Relative to the forehead.
        /// </summary>
        Forehead,

        /// <summary>
        /// Relative to the eyes.
        /// </summary>
        Eyes,

        /// <summary>
        /// Relative to the mouth.
        /// </summary>
        Mouth,

        /// <summary>
        /// Relative to the chin.
        /// </summary>
        Chin,
    }
}
