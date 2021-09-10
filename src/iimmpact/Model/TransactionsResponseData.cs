/* 
 * IIMMPACT API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2020-09-14T13:01:14Z
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = iimmpact.Client.SwaggerDateConverter;

namespace iimmpact.Model
{
    /// <summary>
    /// TransactionsResponseData
    /// </summary>
    [DataContract]
    public partial class TransactionsResponseData :  IEquatable<TransactionsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsResponseData" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="entryDate">entryDate.</param>
        /// <param name="product">product.</param>
        /// <param name="amount">amount.</param>
        /// <param name="topupNumber">topupNumber.</param>
        /// <param name="sender">sender.</param>
        /// <param name="memberId">memberId.</param>
        /// <param name="status">status.</param>
        /// <param name="balance">balance.</param>
        /// <param name="price">price.</param>
        /// <param name="sn">sn.</param>
        /// <param name="remarks">remarks.</param>
        /// <param name="refId">refId.</param>
        public TransactionsResponseData(int? id = default(int?), string entryDate = default(string), TransactionsResponseProduct product = default(TransactionsResponseProduct), decimal? amount = default(decimal?), string topupNumber = default(string), string sender = default(string), int? memberId = default(int?), TransactionsResponseStatus status = default(TransactionsResponseStatus), TransactionsResponseBalance balance = default(TransactionsResponseBalance), decimal? price = default(decimal?), string sn = default(string), string remarks = default(string), string refId = default(string))
        {
            this.Id = id;
            this.EntryDate = entryDate;
            this.Product = product;
            this.Amount = amount;
            this.TopupNumber = topupNumber;
            this.Sender = sender;
            this.MemberId = memberId;
            this.Status = status;
            this.Balance = balance;
            this.Price = price;
            this.Sn = sn;
            this.Remarks = remarks;
            this.RefId = refId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets EntryDate
        /// </summary>
        [DataMember(Name="entry_date", EmitDefaultValue=false)]
        public string EntryDate { get; set; }

        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="product", EmitDefaultValue=false)]
        public TransactionsResponseProduct Product { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Gets or Sets TopupNumber
        /// </summary>
        [DataMember(Name="topup_number", EmitDefaultValue=false)]
        public string TopupNumber { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets MemberId
        /// </summary>
        [DataMember(Name="member_id", EmitDefaultValue=false)]
        public int? MemberId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public TransactionsResponseStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public TransactionsResponseBalance Balance { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public decimal? Price { get; set; }

        /// <summary>
        /// Gets or Sets Sn
        /// </summary>
        [DataMember(Name="sn", EmitDefaultValue=false)]
        public string Sn { get; set; }

        /// <summary>
        /// Gets or Sets Remarks
        /// </summary>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Gets or Sets RefId
        /// </summary>
        [DataMember(Name="ref_id", EmitDefaultValue=false)]
        public string RefId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionsResponseData {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EntryDate: ").Append(EntryDate).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  TopupNumber: ").Append(TopupNumber).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  MemberId: ").Append(MemberId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Sn: ").Append(Sn).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
            sb.Append("  RefId: ").Append(RefId).Append("\n");
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
            return this.Equals(input as TransactionsResponseData);
        }

        /// <summary>
        /// Returns true if TransactionsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EntryDate == input.EntryDate ||
                    (this.EntryDate != null &&
                    this.EntryDate.Equals(input.EntryDate))
                ) && 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.TopupNumber == input.TopupNumber ||
                    (this.TopupNumber != null &&
                    this.TopupNumber.Equals(input.TopupNumber))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.MemberId == input.MemberId ||
                    (this.MemberId != null &&
                    this.MemberId.Equals(input.MemberId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Sn == input.Sn ||
                    (this.Sn != null &&
                    this.Sn.Equals(input.Sn))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
                ) && 
                (
                    this.RefId == input.RefId ||
                    (this.RefId != null &&
                    this.RefId.Equals(input.RefId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EntryDate != null)
                    hashCode = hashCode * 59 + this.EntryDate.GetHashCode();
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.TopupNumber != null)
                    hashCode = hashCode * 59 + this.TopupNumber.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.MemberId != null)
                    hashCode = hashCode * 59 + this.MemberId.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Balance != null)
                    hashCode = hashCode * 59 + this.Balance.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Sn != null)
                    hashCode = hashCode * 59 + this.Sn.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
                if (this.RefId != null)
                    hashCode = hashCode * 59 + this.RefId.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
