﻿// ----------------------------------------------------------------------------------
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

using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using Microsoft.Azure.Commands.EventGrid.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.Tags;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.EventGrid.Models;
using Microsoft.Azure.Commands.EventGrid.Utilities;
using EventGridModels = Microsoft.Azure.Management.EventGrid.Models;
using System;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.EventGrid
{
    [GenericBreakingChangeWithVersion("Added new required parameter: Location <String>", "12.0.0", "2.0.0")]
    [Cmdlet(
        VerbsCommon.New,
        ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "EventGridPartnerRegistration",
        SupportsShouldProcess = true,
        DefaultParameterSetName = PartnerRegistrationNameParameterSet),
    OutputType(typeof(PSPartnerRegistration))]

    public class NewAzureEventGridPartnerRegistration : AzureEventGridCmdletBase
    {
        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 0,
            HelpMessage = EventGridConstants.ResourceGroupNameHelp,
            ParameterSetName = PartnerRegistrationNameParameterSet)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        [Alias(AliasResourceGroup)]
        public string ResourceGroupName { get; set; }

        [Parameter(
            Mandatory = true,
            ValueFromPipelineByPropertyName = true,
            Position = 1,
            HelpMessage = EventGridConstants.PartnerRegistrationNameHelp,
            ParameterSetName = PartnerRegistrationNameParameterSet)]
        [ResourceNameCompleter("Microsoft.EventGrid/partnerRegistrations", nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        [Alias("PartnerRegistrationName")]
        public string Name { get; set; }

        /// <summary>
        /// Hashtable which represents resource Tags.
        /// </summary>
        [Parameter(
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            HelpMessage = EventGridConstants.TagsHelp,
            ParameterSetName = PartnerRegistrationNameParameterSet)]
        public Hashtable Tag { get; set; }

        public override void ExecuteCmdlet()
        {
            // Create a new Event Grid Partner Registration
            Dictionary<string, string> tagDictionary = TagsConversionHelper.CreateTagDictionary(this.Tag, true);

            if (this.ShouldProcess(this.ResourceGroupName, $"Create a new EventGrid partner registration {this.Name} in Resource Group {this.ResourceGroupName}"))
            {
                PartnerRegistration partnerRegistration = this.Client.CreatePartnerRegistration(
                    this.ResourceGroupName,
                    this.Name,
                    tagDictionary);

                PSPartnerRegistration psPartnerRegistration = new PSPartnerRegistration(partnerRegistration);
                this.WriteObject(psPartnerRegistration);
            }
        }
    }
}
