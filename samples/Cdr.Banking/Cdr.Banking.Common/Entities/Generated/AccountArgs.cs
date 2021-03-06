/*
 * This file is automatically generated; any changes will be lost. 
 */

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Cdr.Banking.Common.Entities;

namespace Cdr.Banking.Common.Entities
{
    /// <summary>
    /// Represents the <see cref="Account"/> arguments entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AccountArgs : EntityBase
    {
        #region Privates

        private string? _productCategorySid;
        private string? _openStatusSid;
        private bool? _isOwned;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the <see cref="ProductCategory"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("product-category", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Product Category")]
        public string? ProductCategorySid
        {
            get => _productCategorySid;
            set => SetValue(ref _productCategorySid, value, false, StringTrim.End, StringTransform.EmptyToNull, nameof(ProductCategory));
        }

        /// <summary>
        /// Gets or sets the Product Category (see <see cref="RefDataNamespace.ProductCategory"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Product Category")]
        public RefDataNamespace.ProductCategory? ProductCategory
        {
            get => _productCategorySid;
            set => SetValue(ref _productCategorySid, value, false, false, nameof(ProductCategory)); 
        }

        /// <summary>
        /// Gets or sets the <see cref="OpenStatus"/> using the underlying Serialization Identifier (SID).
        /// </summary>
        [JsonProperty("open-status", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Open Status")]
        public string? OpenStatusSid
        {
            get => _openStatusSid;
            set => SetValue(ref _openStatusSid, value, false, StringTrim.End, StringTransform.EmptyToNull, nameof(OpenStatus));
        }

        /// <summary>
        /// Gets or sets the Open Status (see <see cref="RefDataNamespace.OpenStatus"/>).
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [Display(Name="Open Status")]
        public RefDataNamespace.OpenStatus? OpenStatus
        {
            get => _openStatusSid;
            set => SetValue(ref _openStatusSid, value, false, false, nameof(OpenStatus)); 
        }

        /// <summary>
        /// Gets or sets a value indicating whether Is Owned.
        /// </summary>
        [JsonProperty("is-owned", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Is Owned")]
        public bool? IsOwned
        {
            get => _isOwned;
            set => SetValue(ref _isOwned, value, false, false, nameof(IsOwned)); 
        }

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="AccountArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="AccountArgs"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<AccountArgs>(from);
            CopyFrom(fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="AccountArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="AccountArgs"/> to copy from.</param>
        public void CopyFrom(AccountArgs from)
        {
            CopyFrom((EntityBase)from);
            ProductCategorySid = from.ProductCategorySid;
            OpenStatusSid = from.OpenStatusSid;
            IsOwned = from.IsOwned;

            OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="AccountArgs"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="AccountArgs"/>.</returns>
        public override object Clone()
        {
            var clone = new AccountArgs();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="AccountArgs"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            ProductCategorySid = Cleaner.Clean(ProductCategorySid);
            OpenStatusSid = Cleaner.Clean(OpenStatusSid);
            IsOwned = Cleaner.Clean(IsOwned);

            OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(ProductCategorySid)
                    && Cleaner.IsInitial(OpenStatusSid)
                    && Cleaner.IsInitial(IsOwned);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(AccountArgs from);

        #endregion
    } 
}

#nullable restore