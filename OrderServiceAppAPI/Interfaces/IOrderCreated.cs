using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServiceAppAPI.Interfaces
{
    public interface IOrderCreated
    {
        Guid OrderId { get; }
        DateTime CreatedAt { get; }
    }
}