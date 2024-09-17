﻿using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Bases;
using SchoolProject.Core.Features.ApplicationUser.Commands.Models;
using SchoolProject.Core.Features.ApplicationUser.Queries.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers
{
    [ApiController]
    public class UserController : AppControllerBase
    {
        [HttpPost(Router.UserRouting.Create)]
        public async Task<IActionResult> Create(AddUserCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet(Router.UserRouting.Paginated)]
        public async Task<IActionResult> Paginated([FromQuery] GetUserPaginatedListQuery query)
        {
            var response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpGet(Router.UserRouting.GetById)]
        public async Task<IActionResult> GetUserById(int id)
        {
            var response = await Mediator.Send(new GetUserByIdQuery(id));
            return NewResult(response);
        }
    }
}
