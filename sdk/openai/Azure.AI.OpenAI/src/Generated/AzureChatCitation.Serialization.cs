// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI.Chat
{
    public partial class AzureChatCitation : IJsonModel<AzureChatCitation>
    {
        void IJsonModel<AzureChatCitation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatCitation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatCitation)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("content") != true)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            if (SerializedAdditionalRawData?.ContainsKey("title") != true && Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (SerializedAdditionalRawData?.ContainsKey("url") != true && Optional.IsDefined(Url))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url);
            }
            if (SerializedAdditionalRawData?.ContainsKey("filepath") != true && Optional.IsDefined(Filepath))
            {
                writer.WritePropertyName("filepath"u8);
                writer.WriteStringValue(Filepath);
            }
            if (SerializedAdditionalRawData?.ContainsKey("chunk_id") != true && Optional.IsDefined(ChunkId))
            {
                writer.WritePropertyName("chunk_id"u8);
                writer.WriteStringValue(ChunkId);
            }
            if (SerializedAdditionalRawData?.ContainsKey("rerank_score") != true && Optional.IsDefined(RerankScore))
            {
                writer.WritePropertyName("rerank_score"u8);
                writer.WriteNumberValue(RerankScore.Value);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        AzureChatCitation IJsonModel<AzureChatCitation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatCitation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureChatCitation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureChatCitation(document.RootElement, options);
        }

        internal static AzureChatCitation DeserializeAzureChatCitation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string content = default;
            string title = default;
            string url = default;
            string filepath = default;
            string chunkId = default;
            double? rerankScore = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("content"u8))
                {
                    content = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("title"u8))
                {
                    title = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    url = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filepath"u8))
                {
                    filepath = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("chunk_id"u8))
                {
                    chunkId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("rerank_score"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rerankScore = property.Value.GetDouble();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AzureChatCitation(
                content,
                title,
                url,
                filepath,
                chunkId,
                rerankScore,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureChatCitation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatCitation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureChatCitation)} does not support writing '{options.Format}' format.");
            }
        }

        AzureChatCitation IPersistableModel<AzureChatCitation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureChatCitation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureChatCitation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureChatCitation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureChatCitation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static AzureChatCitation FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureChatCitation(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
