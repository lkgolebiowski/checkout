﻿using System;

namespace Api.Services
{
    public partial class BankServiceMock
    {
        public class Payments
        {
            public Guid Id { get; set; }
            public DateTime CreatedAt { get; set; }
            public string CardNumber { get; set; }
            public string Expiry { get; set; }
            public string Ccv { get; set; }
            public int Amount { get; set; }
            public int Currency { get; set; }     
            public int Status { get; set; }
        }
    }
}
