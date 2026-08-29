
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Nomic
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Nomic.TextEmbeddingRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.TextEmbeddingRequestModel? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.TextEmbeddingRequestTaskType? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.TextEmbeddingRequestLongTextMode? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.ImageEmbeddingRequest? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.ImageEmbeddingRequestModel? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.EmbeddingResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<float>>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<float>? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public float? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.Usage? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.ValidationError? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nomic.ValidationErrorDetailItem>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.ValidationErrorDetailItem? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Nomic.OneOf<string, int?>>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Nomic.OneOf<string, int?>? Type18 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<float>>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<float>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nomic.ValidationErrorDetailItem>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Nomic.OneOf<string, int?>>? ListType4 { get; set; }
    }
}