/*
 * Wild Apricot API for non-administrative access
 *
 * Wild Apricot API for non-administrative access
 *
 * OpenAPI spec version: 8.10.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using WildApricot.Attributes;
using WildApricot.Models;
using WildApricot.Security;

namespace WildApricot.Controllers
{
    /// <summary>
    ///
    /// </summary>
    [ApiController]
    public class SettingsApiController : ControllerBase
    {
        /// <summary>
        /// Retrieve mobile app settings.
        /// </summary>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Retrieves mobile app settings</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpGet]
        [Route("/publicview/v1/accounts/{accountId}/mobileAppSettings")]
        [ValidateModelState]
        [SwaggerOperation("AccountsAccountIdMobileAppSettingsGet")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(Settings),
            description: "Retrieves mobile app settings"
        )]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult AccountsAccountIdMobileAppSettingsGet(
            [FromRoute] [Required] decimal? accountId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Settings));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 428 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(428);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);
            string exampleJson = null;
            exampleJson =
                "{\n  \"AccountId\" : 0,\n  \"EnableAppForMembers\" : true,\n  \"EnableEventsList\" : true,\n  \"AppForMembersAvailable\" : true,\n  \"EnableMemberDirectory\" : true,\n  \"Tags\" : [ \"Tags\", \"Tags\" ]\n}";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<Settings>(exampleJson)
                    : default(Settings); //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
