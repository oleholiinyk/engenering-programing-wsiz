using System;
using System.Collections.Generic;
using System.Text;
using xUnitTest.Enums;

namespace xUnitTest.Models
{
    interface IBankProcess
    {
        List<BankClient> GetClients(BankFilterClient filterBy);
        BankClient GetClient(Guid id);
        bool CreateClient(string clientName, DateTime birthday,
        decimal income, ClientType type);

    }
}
