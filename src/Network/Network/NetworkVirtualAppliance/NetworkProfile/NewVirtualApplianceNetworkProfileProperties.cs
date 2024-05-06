// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using Microsoft.Azure.Commands.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceNetworkProfileProperty",
    SupportsShouldProcess = true),
    OutputType(typeof(PSVirtualApplianceNetworkProfile))]
    public class NewVirtualApplianceNetworkProfilePropertyCommand : VirtualApplianceNetworkProfileBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The network interface configurations of the network profile.")]
        public PSVirtualApplianceNetworkInterfaceConfiguration[] NetworkInterfaceConfigurations { get; set; }

        public override void ExecuteCmdlet()
        {
            var networkProfile = new PSVirtualApplianceNetworkProfile
            {
                NetworkInterfaceConfigurations = this.NetworkInterfaceConfigurations.ToList()
            };

            WriteObject(networkProfile);
        }
    }

    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceNetworkInterfaceConfigurationProperty",
    SupportsShouldProcess = true),
    OutputType(typeof(PSVirtualApplianceNetworkInterfaceConfiguration))]
    public class NewVirtualApplianceNetworkInterfaceConfigurationPropertyCommand : VirtualApplianceNetworkProfileBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The type of the network interface configuration.")]
        [ValidateNotNullOrEmpty]
        public string Type { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "The IP configurations of the network interface configuration.")]
        public PSVirtualApplianceIpConfiguration[] IpConfigurations { get; set; }

        public override void ExecuteCmdlet()
        {
            var networkInterfaceConfiguration = new PSVirtualApplianceNetworkInterfaceConfiguration
            {
                Type = this.Type,
                Properties = new PSVirtualApplianceNetworkInterfaceConfigurationProperties
                {
                    IpConfigurations = this.IpConfigurations.ToList()
                }
            };

            WriteObject(networkInterfaceConfiguration);
        }
    }

    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VirtualApplianceIpConfigurationProperty",
    SupportsShouldProcess = true),
    OutputType(typeof(PSVirtualApplianceIpConfiguration))]
    public class NewVirtualApplianceIpConfigurationPropertyCommand : VirtualApplianceNetworkProfileBaseCmdlet
    {
        [Parameter(
            Mandatory = true,
            HelpMessage = "The name of the IP configuration.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(
            Mandatory = true,
            HelpMessage = "Indicates whether this IP configuration is the primary one.")]
        public bool Primary { get; set; }

        public override void ExecuteCmdlet()
        {
            var ipConfiguration = new PSVirtualApplianceIpConfiguration
            {
                Name = this.Name,
                Properties = new PSVirtualApplianceIpConfigurationProperties
                {
                    Primary = this.Primary
                }
            };

            WriteObject(ipConfiguration);
        }
    }
}