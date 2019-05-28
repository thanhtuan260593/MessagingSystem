﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Entities.SMS;
using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        IMessageRepository _imessage;
        public MessageController(IMessageRepository imessage)
        {
            _imessage = imessage;
        }

        // GET: api/<controller>
        [HttpGet]
        [Route("ReceiverCategories")]
        public async Task<List<ReceiverCategory>> Get()
        {
            return await _imessage.GetCategories();
        }

        [HttpGet]
        [Route("customers")]
        public async Task<List<Customer>> Customers()
        {
            return await _imessage.GetCustomers();
        }
    }
}
