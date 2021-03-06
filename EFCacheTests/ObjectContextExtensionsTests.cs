﻿// Copyright (c) Pawel Kadluczka, Inc. All rights reserved. See License.txt in the project root for license information.

namespace EFCache
{
    using System;
    using Xunit;

    public class ObjectContextExtensionsTests
    {
        [Fact]
        public void GetCachingProviderServices_throws_for_null_context()
        {
            Assert.Equal(
                "context",
                Assert.Throws<ArgumentNullException>(
                    () => ObjectContextExtensions.GetCachingProviderServices(null))
                    .ParamName);
        }
    }
}
