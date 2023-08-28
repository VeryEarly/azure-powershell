// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Models.Api20230801;

namespace Microsoft.Azure.PowerShell.Cmdlets.ResourceMover.Cmdlets
{
    internal static class CmdletRestExtension
    {
        public static void WriteError(this Cmdlet cmdlet, HttpResponseMessage responseMessage, Task<ICloudError> errorResponseTask, ref Task<bool> returnNow)
        {
            var response = errorResponseTask.ConfigureAwait(false).GetAwaiter().GetResult();
            if (response?.Detail != null && response?.Detail?.Length != 0) {
                var errors = response.Detail.ToList<ICloudErrorBody>();
                errors.Insert(0, new CloudErrorBody {Code = response.Code, Message = response.Message});
                errors.ForEach(e => {
                    cmdlet.WriteError(new ErrorRecord(new System.Exception(), null, ErrorCategory.InvalidOperation, null)
                    {
                        ErrorDetails = new ErrorDetails(string.Format("code: {0}, message: {1}", e.Code, e.Message)) { RecommendedAction = string.Empty }
                    });
                });
                returnNow = Task.FromResult(true);
            }
        }
    }
}