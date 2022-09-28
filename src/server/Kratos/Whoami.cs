using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace KratosDemo.Server.Kratos
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Identity
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("recovery_addresses")]
        public List<RecoveryAddress> RecoveryAddresses { get; set; }

        [JsonPropertyName("schema_id")]
        public string SchemaId { get; set; }

        [JsonPropertyName("schema_url")]
        public string SchemaUrl { get; set; }

        [JsonPropertyName("traits")]
        public Traits Traits { get; set; }

        [JsonPropertyName("verifiable_addresses")]
        public List<VerifiableAddress> VerifiableAddresses { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("first")]
        public string First { get; set; }

        [JsonPropertyName("last")]
        public string Last { get; set; }
    }

    public class RecoveryAddress
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("via")]
        public string Via { get; set; }
    }

    public class Whoami
    {
        [JsonPropertyName("active")]
        public bool Active { get; set; }

        [JsonPropertyName("authenticated_at")]
        public DateTime AuthenticatedAt { get; set; }

        [JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("identity")]
        public Identity Identity { get; set; }

        [JsonPropertyName("issued_at")]
        public DateTime IssuedAt { get; set; }
    }

    public class Traits
    {
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }
    }

    public class VerifiableAddress
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }

        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        [JsonPropertyName("verified_at")]
        public object VerifiedAt { get; set; }

        [JsonPropertyName("via")]
        public string Via { get; set; }
    }


}
