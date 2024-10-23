/*
 * ProxyControllerBase.cs
 *     Created: 2024-10-22T08:06:43-04:00
 *    Modified: 2024-10-22T08:06:43-04:00
 *      Author: Dr. David Gerard <david@mymoc.social>
 *   Copyright: © 2022 - 2024 © 2024 Dr. David Gerard, All Rights Reserved, All Rights Reserved
 *     License: MIT (https://opensource.org/licenses/MIT)
 */

namespace WildApricot.Controllers;

using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Identity.Abstractions;
using Newtonsoft.Json;
using WildApricot.Models; // Assuming SendMessageRequest is in the Models namespace
using static System.Net.HttpStatusCode;

/// <summary>
/// Initializes a new instance of the <see cref="ProxyControllerBase"/> class.
/// </summary>
/// <param name="downstreamApi">The downstream API service.</param>
/// <param name="logger">The logger instance.</param>
public class ProxyControllerBase(IDownstreamApi downstreamApi, ILogger<ProxyControllerBase> logger)
    : ControllerBase,
        ILog
{
    public ILogger Logger => logger;

    /// <summary>
    /// Sends a POST request to the specified WildApricot API endpoint and returns the response.
    /// </summary>
    /// <typeparam name="TRequest">The type of the request payload.</typeparam>
    /// <typeparam name="TResponse">The type of the response payload.</typeparam>
    /// <param name="wildApricotApiRequestPath">The API endpoint path for the WildApricot request.</param>
    /// <param name="request">The request payload to be sent to the API. Can be null.</param>
    /// <returns>
    /// An <see cref="IActionResult"/> containing the response from the WildApricot API.
    /// If the request is successful, returns an <see cref="OkObjectResult"/> with the response payload.
    /// If an error occurs, returns a <see cref="StatusCodeResult"/> with a 500 status code and an error message.
    /// </returns>
    /// <exception cref="HttpRequestException">Thrown when an error occurs while sending the request to the WildApricot API.</exception>
    protected async Task<IActionResult> PostAsync<TRequest, TResponse>(
        string wildApricotApiRequestPath,
        TRequest? request
    )
        where TResponse : class
    {
        Logger.ProxyingRequest(wildApricotApiRequestPath);
        try
        {
            // Assuming you have a method to send the request to the WildApricot API
            var response = await downstreamApi.CallApiForUserAsync<TRequest, TResponse>(
                wildApricotApiRequestPath,
                request
            );
            return Ok(response);
            // var responseContent = await response.Content.ReadFromJsonAsync<TResponse>();
            // return response.IsSuccessStatusCode
            //     ? StatusCode((int)response.StatusCode, responseContent)
            //     : StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }
        catch (HttpRequestException ex)
        {
            // Log the exception (assuming you have a logging mechanism)
            Logger.LogError(ex, "Error occurred while calling WildApricot API");

            return StatusCode(500, "Internal server error.");
        }
    }

    protected async Task<IActionResult> GetAsync<TResponse>(string wildApricotApiRequestPath)
        where TResponse : class
    {
        Logger.ProxyingRequest(wildApricotApiRequestPath);
        try
        {
            // Assuming you have a method to send the request to the WildApricot API
            var response = await downstreamApi.CallApiForUserAsync<TResponse>(
                wildApricotApiRequestPath
            );
            return Ok(response);
            // var responseContent = await response.Content.ReadFromJsonAsync<TResponse>();
            // return response.IsSuccessStatusCode
            //     ? StatusCode((int)response.StatusCode, responseContent)
            //     : StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }
        catch (HttpRequestException ex)
        {
            // Log the exception (assuming you have a logging mechanism)
            Logger.LogError(ex, "Error occurred while calling WildApricot API");

            return StatusCode(500, "Internal server error.");
        }
    }

    private async Task<HttpResponseMessage> ProxyCallToWildApricotApi(HttpRequestMessage? request)
    {
        if (request == null)
        {
            return new HttpResponseMessage(HttpStatusCode.BadRequest);
        }

        try
        {
            // Assuming you have a method to send the request to the WildApricot API
            var response = await SendRequestToWildApricotApi(request);

            return response;
        }
        catch (HttpRequestException ex)
        {
            // Log the exception (assuming you have a logging mechanism)
            Logger.LogError(ex, "Error occurred while calling WildApricot API");

            return new HttpResponseMessage(InternalServerError);
        }
    }

    private async Task<HttpResponseMessage> SendRequestToWildApricotApi(HttpRequestMessage request)
    {
        // Implement the logic to send the request to the WildApricot API
        // This is a placeholder implementation
        // using (var client = new HttpClient())
        // {
        // Set up the client, e.g., base address, headers, etc.
        // client.BaseAddress = new Uri("https://api.wildapricot.org");

        // Serialize the request to JSON
        // var jsonContent = JsonConvert.SerializeObject(request);
        // var content = new StringContent(jsonContent, UTF8, Application.Json.DisplayName);
        // var response = downstreamApi.CallApiForUserAsync(request);
        var response = new HttpResponseMessage(NotImplemented)
        {
            Content = new StringContent("Not implemented"),
        };

        // Send the request (assuming POST method)
        // var response = client.PostAsync("", content).Result;

        return response;
    }
}
