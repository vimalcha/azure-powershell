// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support
{

    /// <summary>The status of the webhook at the time the operation was called.</summary>
    public partial struct WebhookStatus :
        System.IEquatable<WebhookStatus>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus Disabled = @"disabled";

        public static Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus Enabled = @"enabled";

        /// <summary>the value for an instance of the <see cref="WebhookStatus" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to WebhookStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebhookStatus" />.</param>
        internal static object CreateFrom(object value)
        {
            return new WebhookStatus(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type WebhookStatus</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type WebhookStatus (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is WebhookStatus && Equals((WebhookStatus)obj);
        }

        /// <summary>Returns hashCode for enum WebhookStatus</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for WebhookStatus</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Creates an instance of the <see cref="WebhookStatus"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private WebhookStatus(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Implicit operator to convert string to WebhookStatus</summary>
        /// <param name="value">the value to convert to an instance of <see cref="WebhookStatus" />.</param>

        public static implicit operator WebhookStatus(string value)
        {
            return new WebhookStatus(value);
        }

        /// <summary>Implicit operator to convert WebhookStatus to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="WebhookStatus" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum WebhookStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum WebhookStatus</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e1, Microsoft.Azure.PowerShell.Cmdlets.ContainerRegistry.Support.WebhookStatus e2)
        {
            return e2.Equals(e1);
        }
    }
}