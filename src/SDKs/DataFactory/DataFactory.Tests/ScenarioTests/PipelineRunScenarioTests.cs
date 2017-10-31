﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using DataFactory.Tests.Utils;
using Microsoft.Azure.Management.DataFactory;
using Microsoft.Azure.Management.DataFactory.Models;
using System;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace DataFactory.Tests.ScenarioTests
{
    public class PipelineRunScenarioTests : ScenarioTestBase<PipelineRunScenarioTests>
    {
        [Fact]
        [Trait(TraitName.TestType, TestType.Scenario)]
        public async Task CancelPipelineRun()
        {
            var expectedFactory = new Factory(location: FactoryLocation);

            Func<DataFactoryManagementClient, Task> action = async (client) =>
            {
                Factory createResponse = client.Factories.CreateOrUpdate(ResourceGroupName, DataFactoryName, expectedFactory);
                ErrorResponseException exception = await Assert.ThrowsAsync<ErrorResponseException>(async () =>
                {
                    await client.Factories.CancelPipelineRunWithHttpMessagesAsync(ResourceGroupName, DataFactoryName, "efbe5443-9879-4495-94a6-4d7c394133ad");
                });

                Assert.Equal(exception.Response.StatusCode, HttpStatusCode.BadRequest);
            };

            Func<DataFactoryManagementClient, Task> finallyAction = async (client) =>
            {
                await client.Factories.DeleteAsync(ResourceGroupName, DataFactoryName);
            };
            await this.RunTest(action, finallyAction);
        }
    }
}
