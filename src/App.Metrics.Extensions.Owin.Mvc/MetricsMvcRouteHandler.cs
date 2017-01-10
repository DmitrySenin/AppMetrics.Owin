﻿// Copyright (c) Allan hardy. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.



// ReSharper disable CheckNamespace
namespace System.Web.Routing
// ReSharper restore CheckNamespace
{
    public class MetricsMvcRouteHandler : IRouteHandler
    {
        public IHttpHandler GetHttpHandler(RequestContext requestContext)
        {
            return new MetricsMvcHttpHandler(requestContext);
        }
    }
}