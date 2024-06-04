﻿global using Azure;
global using Azure.Core;
global using Azure.Identity;
global using Azure.Messaging.ServiceBus;
global using Azure.ResourceManager;
global using Azure.ResourceManager.Resources;
global using Azure.Storage.Blobs;
global using CsvHelper;
global using CsvHelper.Configuration;
global using Dapr;
global using Dapr.Actors;
global using Dapr.Actors.Client;
global using Dapr.Actors.Runtime;
global using Dapr.Client;
global using Dapr.Workflow;
global using DotFlyer.Common.Payload;
global using FluentValidation;
global using Grpc.Core;
global using Mammon;
global using Mammon.Actors;
global using Mammon.Extensions;
global using Mammon.Models.Actors;
global using Mammon.Models.CostManagement;
global using Mammon.Models.Views;
global using Mammon.Models.Workflows;
global using Mammon.Models.Workflows.Activities;
global using Mammon.Services;
global using Mammon.Utils;
global using Mammon.Workflows;
global using Mammon.Workflows.Activities;
global using Microsoft.ApplicationInsights;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.AspNetCore.Mvc.Controllers;
global using Microsoft.Extensions.Azure;
global using Polly;
global using Polly.Extensions.Http;
global using Polly.Retry;
global using System.Data;
global using System.Diagnostics;
global using System.Diagnostics.CodeAnalysis;
global using System.Globalization;
global using System.Net;
global using System.Text;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Text.RegularExpressions;
global using Westwind.AspNetCore.Views;