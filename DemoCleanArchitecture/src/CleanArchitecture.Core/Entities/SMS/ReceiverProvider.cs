﻿using CleanArchitecture.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Entities.Messaging
{
    public class ReceiverProvider : BaseEntity
    {
        public int MessageReceiverId { get; set; }
        public MessageReceiver MessageReceiver { get; set; }
        public int MessageServiceProviderId { get; set; }
        public MessageServiceProvider MessageServiceProvider { get; set; }
    }
}
