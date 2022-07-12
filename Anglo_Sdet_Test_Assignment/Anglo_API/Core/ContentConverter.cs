using Newtonsoft.Json;
using System;

namespace Anglo_API.Core
{
    public class ContentConverter
    {
        private readonly ContentFormat ContentFormat;

        public ContentConverter(ContentFormat contentFormat)
        {
            ContentFormat = contentFormat;
        }

        public object ConvertStringToContent(string serializedContent, Type contentType) => ContentFormat switch
        {
            ContentFormat.Json => ConvertFromJson(
                serializedContent, contentType),
            _ => throw new Exception($"Unable to convert to type: {ContentFormat}")
        };

        private object ConvertFromJson(string serializedContent, Type contentType)
            => JsonConvert.DeserializeObject(serializedContent, contentType);
    }
}
