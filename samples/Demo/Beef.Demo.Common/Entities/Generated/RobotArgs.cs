/*
 * This file is automatically generated; any changes will be lost. 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Beef.Entities;
using Beef.RefData;
using Newtonsoft.Json;
using RefDataNamespace = Beef.Demo.Common.Entities;

namespace Beef.Demo.Common.Entities
{
    /// <summary>
    /// Represents the <see cref="Robot"/> arguments entity.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RobotArgs : EntityBase
    {
        #region PropertyNames
      
        /// <summary>
        /// Represents the <see cref="ModelNo"/> property name.
        /// </summary>
        public const string Property_ModelNo = nameof(ModelNo);

        /// <summary>
        /// Represents the <see cref="SerialNo"/> property name.
        /// </summary>
        public const string Property_SerialNo = nameof(SerialNo);

        #endregion

        #region Privates

        private string _modelNo;
        private string _serialNo;

        #endregion

        #region Constructor
      
        /// <summary>
        /// Initializes a new instance of the <see cref="RobotArgs"/> class.
        /// </summary>
        public RobotArgs()
        {
            this.RobotArgsConstructor();
        }
        
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the Model number.
        /// </summary>
        [JsonProperty("modelNo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Model No")]
        public string ModelNo
        {
            get { return this._modelNo; }
            set { SetValue(ref this._modelNo, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_ModelNo); }
        }

        /// <summary>
        /// Gets or sets the Unique serial number.
        /// </summary>
        [JsonProperty("serialNo", DefaultValueHandling = DefaultValueHandling.Ignore)]
        [Display(Name="Serial No")]
        public string SerialNo
        {
            get { return this._serialNo; }
            set { SetValue(ref this._serialNo, value, false, StringTrim.End, StringTransform.EmptyToNull, Property_SerialNo); }
        }

        #endregion

        #region ICopyFrom
    
        /// <summary>
        /// Performs a copy from another <see cref="RobotArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="RobotArgs"/> to copy from.</param>
        public override void CopyFrom(object from)
        {
            var fval = ValidateCopyFromType<RobotArgs>(from);
            CopyFrom((RobotArgs)fval);
        }
        
        /// <summary>
        /// Performs a copy from another <see cref="RobotArgs"/> updating this instance.
        /// </summary>
        /// <param name="from">The <see cref="RobotArgs"/> to copy from.</param>
        public void CopyFrom(RobotArgs from)
        {
            CopyFrom((EntityBase)from);
            this.ModelNo = from.ModelNo;
            this.SerialNo = from.SerialNo;

            this.OnAfterCopyFrom(from);
        }
    
        #endregion
        
        #region ICloneable
        
        /// <summary>
        /// Creates a deep copy of the <see cref="RobotArgs"/>.
        /// </summary>
        /// <returns>A deep copy of the <see cref="RobotArgs"/>.</returns>
        public override object Clone()
        {
            var clone = new RobotArgs();
            clone.CopyFrom(this);
            return clone;
        }
        
        #endregion
        
        #region ICleanUp

        /// <summary>
        /// Performs a clean-up of the <see cref="RobotArgs"/> resetting property values as appropriate to ensure a basic level of data consistency.
        /// </summary>
        public override void CleanUp()
        {
            base.CleanUp();
            this.ModelNo = Cleaner.Clean(this.ModelNo, StringTrim.End, StringTransform.EmptyToNull);
            this.SerialNo = Cleaner.Clean(this.SerialNo, StringTrim.End, StringTransform.EmptyToNull);

            this.OnAfterCleanUp();
        }
    
        /// <summary>
        /// Indicates whether considered initial; i.e. all properties have their initial value.
        /// </summary>
        /// <returns><c>true</c> indicates is initial; otherwise, <c>false</c>.</returns>
        public override bool IsInitial
        {
            get
            {
                return Cleaner.IsInitial(this.ModelNo)
                    && Cleaner.IsInitial(this.SerialNo);
            }
        }

        #endregion

        #region PartialMethods
      
        partial void RobotArgsConstructor();

        partial void OnAfterCleanUp();

        partial void OnAfterCopyFrom(RobotArgs from);

        #endregion
    } 
}