﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace htec.backend.API.Controllers
{
    /// <summary>
    /// Category related operations
    /// </summary>
    [Consumes("application/json")]
    [Produces("application/json")]
    [ApiExplorerSettings(GroupName = "Category")]
    public class DeleteCategoryController : ApiControllerBase
    {

        public DeleteCategoryController()
        {
        }


        /// <summary>
        /// Removes a category and its items from domain
        /// </summary>
        /// <remarks>Removes a category and its items from domain</remarks>
        /// <param name="id">domain id</param>
        /// <param name="categoryId">Id for Category being removed</param>
        /// <response code="204">No Content</response>
        /// <response code="400">Bad Request</response>
        /// <response code="404">Resource not found</response>
        [HttpDelete("/v1/domain/{id}/category/{categoryId}")]
        [Authorize]
        public async Task<IActionResult> DeleteCategory([FromRoute][Required] Guid id, [FromRoute][Required] Guid categoryId)
        {
            // NOTE: Please ensure the API returns the response codes annotated above
            await Task.CompletedTask; // Your async code will be here

            return StatusCode(204);
        }
    }
}
