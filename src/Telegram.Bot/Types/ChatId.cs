using System;
using Newtonsoft.Json;
using Telegram.Bot.Converters;

namespace Telegram.Bot.Types
{
    /// <summary>
    /// Represents a unique identifier for a chat.
    /// </summary>
    [JsonConverter(typeof(ChatIdConverter))]
    public class ChatId
    {
        /// <summary>
        /// Unique identifier for a chat.
        /// </summary>
        public readonly long Identifier;

        /// <summary>
        /// Username of the user or channel (in the format @channelusername).
        /// </summary>
        public readonly string Username;

        /// <summary>
        /// Create a <see cref="ChatId"/> using an identifier.
        /// </summary>
        /// <param name="identifier">The identifier</param>
        public ChatId(long identifier)
        {
            Identifier = identifier;
        }

        /// <summary>
        /// Create a <see cref="ChatId"/> using a username.
        /// </summary>
        /// <param name="username">The username.</param>
        public ChatId(string username)
        {
            if (username.Length >= 2 && username.StartsWith("@"))
            {
                Username = username;
                return;
            }

            if (!long.TryParse(username, out Identifier))
            {
                throw new FormatException("Username must be a name starting with @ or an integer!");
            }
        }

        /// <summary>
        /// Create a <see cref="ChatId"/> out of an identifier.
        /// </summary>
        /// <param name="identifier">The identifier.</param>
        public static implicit operator ChatId(long identifier) => new ChatId(identifier);

        /// <summary>
        /// Create a <see cref="ChatId"/> out of an identifier.
        /// </summary>
        /// <param name="chatId">The identifier.</param>
        public static implicit operator ChatId(int chatId) => new ChatId(chatId);

        /// <summary>
        /// Create a <see cref="ChatId"/> out of a username.
        /// </summary>
        /// <param name="username">The username.</param>
        public static implicit operator ChatId(string username) => new ChatId(username);

        /// <summary>
        /// Convert a Chat Object to a <see cref="ChatId"/>.
        /// </summary>
        /// <param name="chat">The <see cref="Chat"/>.</param>
        public static implicit operator ChatId(Chat chat) =>
            chat.Id != default ? chat.Id : (ChatId)("@" + chat.Username);

        /// <summary>
        /// Create a <c>string</c> out of a <see cref="ChatId"/>.
        /// </summary>
        /// <param name="chatid">The <see cref="ChatId"/>.</param>
        public static implicit operator string(ChatId chatid) => chatid.Username ?? chatid.Identifier.ToString();

        /// <summary>
        /// Determines whether the specified object is equal to the current object.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>true if the specified object is equal to the current object; otherwise, false.</returns>
        public override bool Equals(object obj) => ((string)this).Equals(obj);

        /// <summary>
        /// Gets the hash code of this object.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        public override int GetHashCode() => ((string)this).GetHashCode();

        /// <summary>
        /// Create a <c>string</c> out of a <see cref="ChatId"/>.
        /// </summary>
        /// <returns>The <see cref="ChatId"/> as <c>string</c>.</returns>
        public override string ToString() => this;
    }
}
