/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously. <br> __Authentication__ Mastercard uses OAuth 1.0a with body hash extension for authenticating the API clients. This requires every request that you send to  Mastercard to be signed with an RSA private key. A private-public RSA key pair must be generated consisting of: <br> 1 . A private key for the OAuth signature for API requests. It is recommended to keep the private key in a password-protected or hardware keystore. <br> 2. A public key is shared with Mastercard during the project setup process through either a certificate signing request (CSR) or the API Key Generator. Mastercard will use the public key to verify the OAuth signature that is provided on every API call.<br>  An OAUTH1.0a signer library is available on [GitHub](https://github.com/Mastercard/oauth1-signer-java) <br>  __Encryption__<br>  All communications between Issuer web service and the Mastercard gateway is encrypted using TLS. <br> __Additional Encryption of Sensitive Data__ In addition to the OAuth authentication, when using MDES Digital Enablement Service, any PCI sensitive and all account holder Personally Identifiable Information (PII) data must be encrypted. This requirement applies to the API fields containing encryptedData. Sensitive data is encrypted using a symmetric session (one-time-use) key. The symmetric session key is then wrapped with an RSA Public Key supplied by Mastercard during API setup phase (the Customer Encryption Key). <br>  Java Client Encryption Library available on [GitHub](https://github.com/Mastercard/client-encryption-java) 
 *
 * The version of the OpenAPI document: 1.2.10
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Acme.App.MastercardApi.Client.Client.OpenAPIDateConverter;

namespace Acme.App.MastercardApi.Client.Model
{
    /// <summary>
    /// GetTokenResponseSchema
    /// </summary>
    [DataContract]
    public partial class GetTokenResponseSchema :  IEquatable<GetTokenResponseSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetTokenResponseSchema" /> class.
        /// </summary>
        /// <param name="responseId">Unique identifier for the response. .</param>
        /// <param name="token">token.</param>
        /// <param name="tokenDetail">tokenDetail.</param>
        public GetTokenResponseSchema(string responseId = default(string), Token token = default(Token), TokenDetailGetTokenOnly tokenDetail = default(TokenDetailGetTokenOnly))
        {
            this.ResponseId = responseId;
            this.Token = token;
            this.TokenDetail = tokenDetail;
        }
        
        /// <summary>
        /// Unique identifier for the response. 
        /// </summary>
        /// <value>Unique identifier for the response. </value>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public Token Token { get; set; }

        /// <summary>
        /// Gets or Sets TokenDetail
        /// </summary>
        [DataMember(Name="tokenDetail", EmitDefaultValue=false)]
        public TokenDetailGetTokenOnly TokenDetail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetTokenResponseSchema {\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  TokenDetail: ").Append(TokenDetail).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetTokenResponseSchema);
        }

        /// <summary>
        /// Returns true if GetTokenResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of GetTokenResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetTokenResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                ) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && 
                (
                    this.TokenDetail == input.TokenDetail ||
                    (this.TokenDetail != null &&
                    this.TokenDetail.Equals(input.TokenDetail))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.TokenDetail != null)
                    hashCode = hashCode * 59 + this.TokenDetail.GetHashCode();
                return hashCode;
            }
        }
    }

}
