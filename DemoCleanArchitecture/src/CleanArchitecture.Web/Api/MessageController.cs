﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Entities.Sales;
using CleanArchitecture.Core.Entities.Messaging;
using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArchitecture.Web.Api
{
    [Route("api/[controller]")]
    public class MessageController : Controller
    {
        readonly IMessageReceiverRepository _imessage;
        readonly ICoreRepository _icore;
        public MessageController(IMessageReceiverRepository imessage, ICoreRepository icore)
        {
            _imessage = imessage;
            _icore = icore;
        }

        // GET: api/<controller>
        [HttpGet]
        [Route("ReceiverCategories")]
        public async Task<List<ReceiverCategory>> Get()
        {
            return null;
            //return await _imessage.GetCategories();
        }

        [HttpGet]
        [Route("customers")]
        public async Task<ICollection<Customer>> Customers()
        {
            return null;
            //return await _icore.GetCustomers(null, "");
        }
    }
}
