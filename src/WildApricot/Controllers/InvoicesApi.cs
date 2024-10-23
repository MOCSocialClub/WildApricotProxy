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
    public class InvoicesApiController : ControllerBase
    {
        /// <summary>
        /// Retrieve list of invoices for the current contact.
        /// </summary>
        /// <remarks>Retrieve list of invoices associated with the current contact.</remarks>
        /// <param name="accountId">Your account identifier</param>
        /// <param name="openBalanceOnly">Return only invoices with an open balance</param>
        /// <param name="eventRegistrationId">Return only those invoices related to specific event registration ID</param>
        /// <param name="skip">This parameter specifies the number of records to be skipped. For example, if the result set contains 200 records and $skip&#x3D;50, then the call will return records 51 to 200.  Usually used together with **$top** parameter. </param>
        /// <param name="top">Specifies the maximum number of records to be returned. For example, if the result set contains 100 records and $top&#x3D;50, then the call will return records from 1 to 50. If omitted or set more than 100 then maximum 100 items returned. Usually this parameter used together with $skip parameter. </param>
        /// <param name="count">Append this parameter to a search request to retrieve the number of items returned by the search. </param>
        /// <param name="ids">Retrieve specific records (if allowed).  E.g. &#x60;ids&#x3D;1,2,3&#x60; </param>
        /// <param name="idsOnly">If specified, the call returns a list of record IDs. In this case, the response will contain only the Identifiers field. </param>
        /// <response code="200">Returns list of filtered invoices</response>
        /// <response code="400">On invalid parameters. See error details in response body.</response>
        /// <response code="401">oAuth token was not provided, invalid or does not provide access to requested URL.</response>
        /// <response code="428">Current user should accept terms of use before using API. It can be done in web interface, or by making a POST request to /rpc/{accountId}/acceptTermsOfUse</response>
        /// <response code="429">On too many requests from same account. Wait for a minute and try again.</response>
        [HttpGet]
        [Route("/publicview/v1/accounts/{accountId}/invoices")]
        [ValidateModelState]
        [SwaggerOperation("AccountsAccountIdInvoicesGet")]
        [SwaggerResponse(
            statusCode: 200,
            type: typeof(List<Invoice>),
            description: "Returns list of filtered invoices"
        )]
        [SwaggerResponse(
            statusCode: 400,
            type: typeof(Error),
            description: "On invalid parameters. See error details in response body."
        )]
        public virtual IActionResult AccountsAccountIdInvoicesGet(
            [FromRoute] [Required] decimal? accountId,
            [FromQuery] bool? openBalanceOnly,
            [FromQuery] int? eventRegistrationId,
            [FromQuery] int? skip,
            [FromQuery] int? top,
            [FromQuery] bool? count,
            [FromQuery] string ids,
            [FromQuery] bool? idsOnly
        )
        {
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(List<Invoice>));

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
                "[ {\n  \"OrderType\" : \"MembershipApplication\",\n  \"OrderDetails\" : [ {\n    \"Taxes\" : {\n      \"Tax2\" : \"\",\n      \"Tax1\" : \"\",\n      \"RoundedAmount\" : 2.027123023002322,\n      \"Amount\" : 2.3021358869347655,\n      \"NetAmount\" : 3.616076749251911,\n      \"CalculatedTax1\" : 7.061401241503109,\n      \"CalculatedTax2\" : 9.301444243932576\n    },\n    \"Price\" : 5.962133916683182,\n    \"Quantity\" : 5.637376656633329,\n    \"OrderDetailType\" : \"Unspecified\",\n    \"Notes\" : \"Notes\"\n  }, {\n    \"Taxes\" : {\n      \"Tax2\" : \"\",\n      \"Tax1\" : \"\",\n      \"RoundedAmount\" : 2.027123023002322,\n      \"Amount\" : 2.3021358869347655,\n      \"NetAmount\" : 3.616076749251911,\n      \"CalculatedTax1\" : 7.061401241503109,\n      \"CalculatedTax2\" : 9.301444243932576\n    },\n    \"Price\" : 5.962133916683182,\n    \"Quantity\" : 5.637376656633329,\n    \"OrderDetailType\" : \"Unspecified\",\n    \"Notes\" : \"Notes\"\n  } ],\n  \"Value\" : 6.027456183070403,\n  \"Id\" : 0,\n  \"DocumentNumber\" : \"DocumentNumber\",\n  \"DocumentDate\" : \"2000-01-23\",\n  \"FullyPaid\" : true,\n  \"Url\" : \"Url\",\n  \"PaidAmount\" : 1.4658129805029452\n}, {\n  \"OrderType\" : \"MembershipApplication\",\n  \"OrderDetails\" : [ {\n    \"Taxes\" : {\n      \"Tax2\" : \"\",\n      \"Tax1\" : \"\",\n      \"RoundedAmount\" : 2.027123023002322,\n      \"Amount\" : 2.3021358869347655,\n      \"NetAmount\" : 3.616076749251911,\n      \"CalculatedTax1\" : 7.061401241503109,\n      \"CalculatedTax2\" : 9.301444243932576\n    },\n    \"Price\" : 5.962133916683182,\n    \"Quantity\" : 5.637376656633329,\n    \"OrderDetailType\" : \"Unspecified\",\n    \"Notes\" : \"Notes\"\n  }, {\n    \"Taxes\" : {\n      \"Tax2\" : \"\",\n      \"Tax1\" : \"\",\n      \"RoundedAmount\" : 2.027123023002322,\n      \"Amount\" : 2.3021358869347655,\n      \"NetAmount\" : 3.616076749251911,\n      \"CalculatedTax1\" : 7.061401241503109,\n      \"CalculatedTax2\" : 9.301444243932576\n    },\n    \"Price\" : 5.962133916683182,\n    \"Quantity\" : 5.637376656633329,\n    \"OrderDetailType\" : \"Unspecified\",\n    \"Notes\" : \"Notes\"\n  } ],\n  \"Value\" : 6.027456183070403,\n  \"Id\" : 0,\n  \"DocumentNumber\" : \"DocumentNumber\",\n  \"DocumentDate\" : \"2000-01-23\",\n  \"FullyPaid\" : true,\n  \"Url\" : \"Url\",\n  \"PaidAmount\" : 1.4658129805029452\n} ]";

            var example =
                exampleJson != null
                    ? JsonConvert.DeserializeObject<List<Invoice>>(exampleJson)
                    : default(List<Invoice>); //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
