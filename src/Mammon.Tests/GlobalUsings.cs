﻿global using Azure.Core;
global using Azure.Identity;
global using Azure.Messaging.ServiceBus;
global using Azure.ResourceManager;
global using Azure.Storage.Blobs;
global using DotFlyer.Common.Payload;
global using FluentAssertions;
global using Kusto.Cloud.Platform.Data;
global using Kusto.Data;
global using Kusto.Data.Common;
global using Kusto.Data.Net.Client;
global using Mammon.Extensions;
global using Mammon.Models.Actors;
global using Mammon.Models.CostManagement;
global using Mammon.Services;
global using Mammon.Tests.Extensions;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.Logging;
global using Microsoft.Extensions.Time.Testing;
global using Moq;
global using Polly;
global using RichardSzalay.MockHttp;
global using System.Globalization;
global using System.Text.Json;
