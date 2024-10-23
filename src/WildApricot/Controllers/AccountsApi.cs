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
    public class AccountsApiController : ControllerBase
    {
        /// <summary>
        /// Details for specific account
        /// </summary>
        /// <remarks>Details for specific account </remarks>
        /// <param name="accountId">Your account identifier</param>
        /// <response code="200">Array of accounts</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpGet]
        [Route("/publicview/v1/accounts/{accountId}")]
        [ValidateModelState]
        [SwaggerOperation("AccountsAccountIdGet")]
        [SwaggerResponse(statusCode: 200, type: typeof(Account), description: "Array of accounts")]
        public virtual IActionResult AccountsAccountIdGet([FromRoute] [Required] decimal? accountId)
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(Account));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);
            string exampleJson = null;
            exampleJson =
                "{\n  \"TimeZone\" : {\n    \"UtcOffset\" : 6.027456183070403,\n    \"ZoneId\" : \"ZoneId\",\n    \"Name\" : \"Name\"\n  },\n  \"Currency\" : {\n    \"Symbol\" : \"Symbol\",\n    \"Code\" : \"Code\",\n    \"Name\" : \"Name\"\n  },\n  \"PrimaryDomainName\" : \"PrimaryDomainName\",\n  \"Id\" : 0,\n  \"Resources\" : [ {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  }, {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  } ],\n  \"Localization\" : {\n    \"TimeFormat\" : \"TimeFormat\",\n    \"DateFormat\" : \"DateFormat\"\n  },\n  \"Url\" : \"Url\",\n  \"Name\" : \"Name\"\n}";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<Account>(exampleJson)
                    : default(Account); //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// List of available accounts
        /// </summary>
        /// <remarks>List of accounts available with current oAuth token. Typically, there would be only one record in an array. </remarks>
        /// <response code="200">Array of accounts</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpGet]
        [Route("/publicview/v1/accounts")]
        [ValidateModelState]
        [SwaggerOperation("AccountsGet")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(List<Account>),
            description: "Array of accounts"
        )]
        public virtual IActionResult AccountsGet()
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Account>));

            //TODO: Uncomment the next line to return response 401 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(401);

            //TODO: Uncomment the next line to return response 429 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(429);
            string exampleJson = null;
            exampleJson =
                "[ {\n  \"TimeZone\" : {\n    \"UtcOffset\" : 6.027456183070403,\n    \"ZoneId\" : \"ZoneId\",\n    \"Name\" : \"Name\"\n  },\n  \"Currency\" : {\n    \"Symbol\" : \"Symbol\",\n    \"Code\" : \"Code\",\n    \"Name\" : \"Name\"\n  },\n  \"PrimaryDomainName\" : \"PrimaryDomainName\",\n  \"Id\" : 0,\n  \"Resources\" : [ {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  }, {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  } ],\n  \"Localization\" : {\n    \"TimeFormat\" : \"TimeFormat\",\n    \"DateFormat\" : \"DateFormat\"\n  },\n  \"Url\" : \"Url\",\n  \"Name\" : \"Name\"\n}, {\n  \"TimeZone\" : {\n    \"UtcOffset\" : 6.027456183070403,\n    \"ZoneId\" : \"ZoneId\",\n    \"Name\" : \"Name\"\n  },\n  \"Currency\" : {\n    \"Symbol\" : \"Symbol\",\n    \"Code\" : \"Code\",\n    \"Name\" : \"Name\"\n  },\n  \"PrimaryDomainName\" : \"PrimaryDomainName\",\n  \"Id\" : 0,\n  \"Resources\" : [ {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  }, {\n    \"Description\" : \"Description\",\n    \"AllowedOperations\" : \"AllowedOperations\",\n    \"Url\" : \"Url\",\n    \"Name\" : \"Name\"\n  } ],\n  \"Localization\" : {\n    \"TimeFormat\" : \"TimeFormat\",\n    \"DateFormat\" : \"DateFormat\"\n  },\n  \"Url\" : \"Url\",\n  \"Name\" : \"Name\"\n} ]";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<List<Account>>(exampleJson)
                    : default(List<Account>); //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
