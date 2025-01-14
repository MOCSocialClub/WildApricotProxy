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
    public class MembershipApiController : ControllerBase
    {
        /// <summary>
        /// Initiates a membership application
        /// </summary>
        /// <remarks>- --</remarks>
        /// <param name="body">Parameters of membership application</param>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Result of membership application - new level, new status, invoice to pay if any</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpPost]
        [Route("/publicview/v1/rpc/{accountId}/applyForMembership")]
        [ValidateModelState]
        [SwaggerOperation("RpcAccountIdApplyForMembershipPost")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(MembershipApplicationResult),
            description: "Result of membership application - new level, new status, invoice to pay if any"
        )]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult RpcAccountIdApplyForMembershipPost(
            [FromBody] MembershipApplication body,
            [FromRoute] [Required] decimal? accountId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(MembershipApplicationResult));

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
                "{\n  \"Invoice\" : {\n    \"Id\" : 0,\n    \"Url\" : \"Url\"\n  },\n  \"NextRenewalDate\" : \"2000-01-23\"\n}";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<MembershipApplicationResult>(exampleJson)
                    : default(MembershipApplicationResult); //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Initiates a membership renewal
        /// </summary>
        /// <remarks>- --</remarks>
        /// <param name="body">Parameters of membership renewal</param>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Result of membership renewal - invoice to pay if any</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpPost]
        [Route("/publicview/v1/rpc/{accountId}/ApplyForRenewal")]
        [ValidateModelState]
        [SwaggerOperation("RpcAccountIdApplyForRenewalPost")]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult RpcAccountIdApplyForRenewalPost(
            [FromBody] RenewParameters body,
            [FromRoute] [Required] decimal? accountId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 428 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(428);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);

            throw new NotImplementedException();
        }

        /// <summary>
        /// Generate possible invoice for membership renewal
        /// </summary>
        /// <remarks>- --</remarks>
        /// <param name="body">Parameters of membership renewal</param>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Result of membership renewal - invoice to pay if any, next renewal date</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpPost]
        [Route("/publicview/v1/rpc/{accountId}/CalculateRenewalCosts")]
        [ValidateModelState]
        [SwaggerOperation("RpcAccountIdCalculateRenewalCostsPost")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(CalculateRenewalResult),
            description: "Result of membership renewal - invoice to pay if any, next renewal date"
        )]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult RpcAccountIdCalculateRenewalCostsPost(
            [FromBody] RenewParameters body,
            [FromRoute] [Required] decimal? accountId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(CalculateRenewalResult));

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 428 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(428);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);
            string exampleJson = null;
            exampleJson = "{\n  \"NewLevel\" : {\n    \"Id\" : 0,\n    \"Url\" : \"Url\"\n  }\n}";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<CalculateRenewalResult>(exampleJson)
                    : default(CalculateRenewalResult); //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// Cancels a membership renewal
        /// </summary>
        /// <remarks>- --</remarks>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Result of membership renewal - invoice to pay if any</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpPost]
        [Route("/publicview/v1/rpc/{accountId}/CancelRenewal")]
        [ValidateModelState]
        [SwaggerOperation("RpcAccountIdCancelRenewalPost")]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult RpcAccountIdCancelRenewalPost(
            [FromRoute] [Required] decimal? accountId
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(Error));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 428 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(428);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);

            throw new NotImplementedException();
        }
    }
}
