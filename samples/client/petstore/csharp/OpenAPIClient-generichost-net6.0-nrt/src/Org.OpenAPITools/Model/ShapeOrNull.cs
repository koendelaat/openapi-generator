// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// The value may be a shape or the &#39;null&#39; value. This is introduced in OAS schema &gt;&#x3D; 3.1.
    /// </summary>
    public partial class ShapeOrNull : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeOrNull" /> class.
        /// </summary>
        /// <param name="triangle"></param>
        internal ShapeOrNull(Triangle triangle)
        {
            Triangle = triangle;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShapeOrNull" /> class.
        /// </summary>
        /// <param name="quadrilateral"></param>
        internal ShapeOrNull(Quadrilateral quadrilateral)
        {
            Quadrilateral = quadrilateral;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Triangle
        /// </summary>
        public Triangle? Triangle { get; set; }

        /// <summary>
        /// Gets or Sets Quadrilateral
        /// </summary>
        public Quadrilateral? Quadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShapeOrNull {\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ShapeOrNull" />
    /// </summary>
    public class ShapeOrNullJsonConverter : JsonConverter<ShapeOrNull>
    {
        /// <summary>
        /// Deserializes json to <see cref="ShapeOrNull" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ShapeOrNull Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Quadrilateral? quadrilateral = null;
            Triangle? triangle = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("shapeType") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("Quadrilateral") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderQuadrilateral = utf8JsonReader;
                            quadrilateral = JsonSerializer.Deserialize<Quadrilateral>(ref utf8JsonReaderQuadrilateral, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("Triangle") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderTriangle = utf8JsonReader;
                            triangle = JsonSerializer.Deserialize<Triangle>(ref utf8JsonReaderTriangle, jsonSerializerOptions);
                        }
                    }
                }
            }

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        default:
                            break;
                    }
                }
            }

            if (quadrilateral != null)
                return new ShapeOrNull(quadrilateral);

            if (triangle != null)
                return new ShapeOrNull(triangle);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="ShapeOrNull" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shapeOrNull"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ShapeOrNull shapeOrNull, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (shapeOrNull.Quadrilateral != null) {
                QuadrilateralJsonConverter quadrilateralJsonConverter = (QuadrilateralJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(shapeOrNull.Quadrilateral.GetType()));
                quadrilateralJsonConverter.WriteProperties(ref writer, shapeOrNull.Quadrilateral, jsonSerializerOptions);
            }

            if (shapeOrNull.Triangle != null) {
                TriangleJsonConverter triangleJsonConverter = (TriangleJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(shapeOrNull.Triangle.GetType()));
                triangleJsonConverter.WriteProperties(ref writer, shapeOrNull.Triangle, jsonSerializerOptions);
            }

            WriteProperties(ref writer, shapeOrNull, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ShapeOrNull" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="shapeOrNull"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, ShapeOrNull shapeOrNull, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
