using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Application.Contracts
{
    public interface ILoggedInUserService
    {
        public string UserId { get; }
    }
}
