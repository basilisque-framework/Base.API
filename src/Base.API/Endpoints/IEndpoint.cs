/*
   Copyright 2026 Alexander Stärk

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace Basilisque.Base.API.Endpoints;

/// <summary>
/// Provides a marker interface for endpoints that can be registered with the web application.
/// Implementing this interface allows the endpoint to be discovered and registered automatically during application startup.
/// </summary>
[RegisterServiceSingleton(As = typeof(IEndpoint), ImplementsITypeName = false)]
public interface IEndpoint
{
    /// <summary>
    /// Maps the endpoint to the specified <see cref="IEndpointRouteBuilder"/>.
    /// </summary>
    /// <param name="routeBuilder">The <see cref="IEndpointRouteBuilder"/> to which the endpoint will be mapped.</param>
    /// <returns>The <see cref="RouteHandlerBuilder"/> for further configuration.</returns>
    RouteHandlerBuilder MapEndpoint(IEndpointRouteBuilder routeBuilder);
}

/// <summary>
/// Provides a marker interface for endpoints that belong to a specific endpoint group and that can be registered with the web application.
/// Implementing this interface allows the endpoint to be discovered and registered automatically during application startup, while also associating it with a specific endpoint group.
/// </summary>
/// <typeparam name="TGroup">The type of the endpoint group to which this endpoint belongs.</typeparam>
public interface IEndpoint<in TGroup> : IEndpoint
    where TGroup : IEndpointGroup
{ }