﻿using System;
using LactafarmaAPI.Controllers.Api.Base;
using LactafarmaAPI.Controllers.Api.Interfaces;
using LactafarmaAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace LactafarmaAPI.Controllers.Api
{
    public class UsersController : BaseController, IUsersController
    {
        #region Private Properties

        private readonly ILogger<UsersController> _logger;

        #endregion

        #region Constructors

        public UsersController(ILactafarmaService lactafarmaService, IMailService mailService,
            IConfigurationRoot config,
            ILogger<UsersController> logger) : base(lactafarmaService, mailService, config)
        {
            _logger = logger;
        }

        #endregion

        #region Public Methods

        public JsonResult GetUser(Guid userId)
        {
            var result = new JsonResult(string.Empty);
            try
            {
                _logger.LogInformation("BEGIN GetUser");
                result = Json(LactafarmaService.GetUser(userId));
                _logger.LogInformation("END GetUser");
            }
            catch (Exception ex)
            {
                _logger.LogError(
                    $"Exception on JsonResult called GetUser(userId={userId}) with message {ex.Message}");
            }

            return result;
        }

        #endregion
    }
}