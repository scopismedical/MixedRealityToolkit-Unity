﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.Core.Services;

namespace Microsoft.MixedReality.Toolkit.Tests.Services
{
    internal class TestExtensionService2 : BaseExtensionService, ITestExtensionService2
    {
        public TestExtensionService2(string name, uint priority) : base(name, priority) { }
    }
}