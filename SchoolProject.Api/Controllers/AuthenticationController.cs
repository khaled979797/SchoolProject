﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Api.Bases;
using SchoolProject.Core.Features.Authentication.Commands.Models;
using SchoolProject.Core.Features.Authentication.Queries.Models;
using SchoolProject.Data.AppMetaData;

namespace SchoolProject.Api.Controllers
{
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AuthenticationController : AppControllerBase
    {
        [AllowAnonymous]
        [HttpPost(Router.AuthenticationRouting.SignIn)]
        public async Task<IActionResult> Create([FromForm] SignInCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [AllowAnonymous]
        [HttpPost(Router.AuthenticationRouting.RefreshToken)]
        public async Task<IActionResult> RefreshToken([FromForm] RefreshTokenCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [HttpGet(Router.AuthenticationRouting.ValidateToken)]
        public async Task<IActionResult> ValidateToken([FromQuery] AuthorizeUserQuery query)
        {
            var response = await Mediator.Send(query);
            return NewResult(response);
        }

        [AllowAnonymous]
        [HttpGet(Router.AuthenticationRouting.ConfirmEmail)]
        public async Task<IActionResult> ConfirmEmail([FromQuery] ConfirmEmailQuery query)
        {
            var response = await Mediator.Send(query);
            return NewResult(response);
        }

        [AllowAnonymous]
        [HttpPost(Router.AuthenticationRouting.SendResetPassword)]
        public async Task<IActionResult> SendResetPassword([FromQuery] SendResetPasswordCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }

        [AllowAnonymous]
        [HttpGet(Router.AuthenticationRouting.ConfirmResetPassword)]
        public async Task<IActionResult> ConfirmResetPassword([FromQuery] ConfirmResetPasswordQuery query)
        {
            var response = await Mediator.Send(query);
            return NewResult(response);
        }

        [HttpPost(Router.AuthenticationRouting.ResetPassword)]
        public async Task<IActionResult> ResetPassword([FromForm] ResetPasswordCommand command)
        {
            var response = await Mediator.Send(command);
            return NewResult(response);
        }
    }
}
