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

using Microsoft.AspNetCore.Routing;

namespace Basilisque.Base.API.Endpoints;

/// <summary>
/// Provides a marker interface for endpoint groups that can be registered with the web application.
/// Implementing this interface allows the endpoint group to be discovered and registered automatically during application startup.
/// </summary>
[RegisterServiceSingleton(As = typeof(IEndpointGroup), ImplementsITypeName = false)]
public interface IEndpointGroup
{
    /// <summary>
    /// Maps the endpoint group to the specified <see cref="IEndpointRouteBuilder"/>.
    /// </summary>
    /// <param name="routeBuilder">The <see cref="IEndpointRouteBuilder"/> to which the endpoint group will be mapped.</param>
    /// <returns>The <see cref="RouteGroupBuilder"/> for further configuration of the group.</returns>
    RouteGroupBuilder MapGroup(IEndpointRouteBuilder routeBuilder);
}

/// <summary>
/// Provides a marker interface for endpoint groups that belong to a specific parent endpoint group and that can be registered with the web application.
/// Implementing this interface allows the endpoint group to be discovered and registered automatically during application startup, while also associating it with a specific parent endpoint group.
/// </summary>
/// <typeparam name="TParentGroup">The type of the parent endpoint group to which this endpoint group belongs.</typeparam>
public interface IEndpointGroup<in TParentGroup> : IEndpointGroup
    where TParentGroup : IEndpointGroup
{ }
