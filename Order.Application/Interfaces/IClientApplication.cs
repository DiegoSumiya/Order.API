using Order.Application.DataContract.Request;
using Order.Domain.Models;
using Order.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Interfaces
{
    public interface IClientApplication
    {
        Task<Response> CreateAsync(ClientRequest client);
    }
}
