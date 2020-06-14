﻿using CostAccounting.Services.Interfaces;
using CostAccounting.Services.Models.Auth;
using CostAccounting.Services.Models.User;
using Microsoft.AspNetCore.Mvc;

namespace CostAccounting.Web.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService) => _authService = authService;

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationModel user)
        {
            var authResponse = _authService.Register(user);

            if (!authResponse.Success)
            {
                return BadRequest(new AuthFailedResponse
                {
                    Errors = authResponse.Errors
                });
            }

            return Ok(new AuthSuccessResponse
            {
                Token = authResponse.Token
            });
        }
    }
}