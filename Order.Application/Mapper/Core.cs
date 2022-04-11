using AutoMapper;
using Order.Application.DataContract.Request;
using Order.Application.DataContract.Response.Client;
using Order.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.Application.Mapper
{
    public class Core : Profile
    {
        public Core()
        {
        }

        private void ClientMap()
        {
            CreateMap<ClientRequest, ClientModel>();
            CreateMap<ClientModel, ClientResponse>();
        }
    }
}
