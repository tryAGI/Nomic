
#nullable enable

namespace Nomic
{
    /// <summary>
    /// The task type to optimize embeddings for. search_document is for embedding document chunks in retrieval scenarios. search_query is for embedding user search queries. classification is for text classification. clustering is for cluster visualization.<br/>
    /// Default Value: search_document
    /// </summary>
    public enum TextEmbeddingRequestTaskType
    {
        /// <summary>
        /// 
        /// </summary>
        Classification,
        /// <summary>
        /// 
        /// </summary>
        Clustering,
        /// <summary>
        /// 
        /// </summary>
        SearchDocument,
        /// <summary>
        /// 
        /// </summary>
        SearchQuery,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextEmbeddingRequestTaskTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextEmbeddingRequestTaskType value)
        {
            return value switch
            {
                TextEmbeddingRequestTaskType.Classification => "classification",
                TextEmbeddingRequestTaskType.Clustering => "clustering",
                TextEmbeddingRequestTaskType.SearchDocument => "search_document",
                TextEmbeddingRequestTaskType.SearchQuery => "search_query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextEmbeddingRequestTaskType? ToEnum(string value)
        {
            return value switch
            {
                "classification" => TextEmbeddingRequestTaskType.Classification,
                "clustering" => TextEmbeddingRequestTaskType.Clustering,
                "search_document" => TextEmbeddingRequestTaskType.SearchDocument,
                "search_query" => TextEmbeddingRequestTaskType.SearchQuery,
                _ => null,
            };
        }
    }
}