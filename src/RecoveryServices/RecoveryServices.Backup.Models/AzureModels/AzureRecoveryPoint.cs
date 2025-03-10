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

using System;

namespace Microsoft.Azure.Commands.RecoveryServices.Backup.Cmdlets.Models
{
    /// <summary>
    /// Base class for Azure recovery points(AzureVM, AzureFiles)
    /// </summary>
    public class AzureRecoveryPoint : RecoveryPointBase
    {
        /// <summary>
        /// Type of recovery point (appConsistent\CrashConsistent etc)
        /// </summary>
        public string RecoveryPointType { get; set; }

        /// <summary>
        /// Time when this recovery point was created
        /// </summary>
        public DateTime RecoveryPointTime { get; set; }

        /// <summary>
        /// Recovery point expiry time
        /// </summary>
        public DateTime? RecoveryPointExpiryTime;

        /// <summary>
        /// Rule Name
        /// </summary>
        public String RuleName;

        public AzureRecoveryPoint()
        {

        }
    }
}