using System;
using System.Collections.Generic;
using System.Text;
using xUnitTest.Enums;

namespace xUnitTest.Models
{
    class BankClient
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public ClientType Type { get; set; }
    }
}
