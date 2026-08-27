
#nullable enable

namespace Nomic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidationErrorDetailItem
    {
        /// <summary>
        /// The location of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loc")]
        public global::System.Collections.Generic.IList<global::Nomic.OneOf<string, int?>>? Loc { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg")]
        public string? Msg { get; set; }

        /// <summary>
        /// The error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetailItem" /> class.
        /// </summary>
        /// <param name="loc">
        /// The location of the error.
        /// </param>
        /// <param name="msg">
        /// The error message.
        /// </param>
        /// <param name="type">
        /// The error type.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidationErrorDetailItem(
            global::System.Collections.Generic.IList<global::Nomic.OneOf<string, int?>>? loc,
            string? msg,
            string? type)
        {
            this.Loc = loc;
            this.Msg = msg;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationErrorDetailItem" /> class.
        /// </summary>
        public ValidationErrorDetailItem()
        {
        }

    }
}