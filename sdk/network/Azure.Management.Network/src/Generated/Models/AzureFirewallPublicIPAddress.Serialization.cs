// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class AzureFirewallPublicIPAddress : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Address != null)
            {
                writer.WritePropertyName("address");
                writer.WriteStringValue(Address);
            }
            writer.WriteEndObject();
        }

        internal static AzureFirewallPublicIPAddress DeserializeAzureFirewallPublicIPAddress(JsonElement element)
        {
            string address = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    address = property.Value.GetString();
                    continue;
                }
            }
            return new AzureFirewallPublicIPAddress(address);
        }
    }
}