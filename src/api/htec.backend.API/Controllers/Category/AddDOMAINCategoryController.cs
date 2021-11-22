﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using htec.backend.API.Models.Requests;
using htec.backend.API.Models.Responses;

namespace htec.backend.API.Controllers
{
    using Microsoft.AspNetCore.Http;

    /// <summary>
    /// Category related operations
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    [ApiExplorerSettings(GroupName = "Category")]
    public class AddDOMAINCategoryController : ApiControllerBase
    {
        public AddDOMAINCategoryController()
        {
        }

        /// <summary>
        /// Create a category in the domain
        /// </summary>
        /// <remarks>Adds a category to domain</remarks>
        /// <param name="id">domain id</param>
        /// <param name="body">Category being added</param>
        /// <response code="201">Resource created</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Resource not found</response>
        /// <response code="409">Conflict, an item already exists</response>
        [HttpPost("/v1/domain/{id}/category/")]
        [Authorize]
        [ProducesResponseType(typeof(ResourceCreatedResponse), StatusCodes.Status201Created)]
        public async Task<IActionResult> AddDOMAINCategory([FromRoute][Required] Guid id, [FromBody] CreateCategoryRequest body)
        {
            // NOTE: Please ensure the API returns the response codes annotated above
            await Task.CompletedTask; // Your async code will be here

            var categoryId = Guid.NewGuid();
            return StatusCode(StatusCodes.Status201Created, new ResourceCreatedResponse(categoryId));
        }
    }
}
