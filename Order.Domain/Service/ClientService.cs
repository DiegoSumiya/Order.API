using Order.Domain.Interface.Repository;
using Order.Domain.Interface.Services;
using Order.Domain.Models;
using Order.Domain.Validations;
using Order.Domain.Validations.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Order.Domain.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Response>CreateAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            await _clientRepository.CreateAsync(client);
            return response;
        }

        public async Task<Response> DeleteAsync(string clientId)
        {
            var response = new Response();

            var exists = await _clientRepository.ExistByIdAsync(clientId);

            if(!exists)
            {
                response.Report.Add(Report.Create($"Client {clientId} not exists!"));
                return response;
            }

            await _clientRepository.DeleteAsync(clientId);

            return response;
        }

        public async Task<Response<List<ClientModel>>> GetByFiltersAsync(string clientId = null, string name = null)
        {
            var response = new Response<List<ClientModel>>();

            if(!string.IsNullOrWhiteSpace(clientId))
            {
                var exists = await _clientRepository.ExistByIdAsync(clientId);

                if(!exists)
                {
                    response.Report.Add(Report.Create($"Client {clientId} not exists!"));
                    return response;
                }
            }

            var data = await _clientRepository.ListByFilterAsync(clientId, name);
            response.Data = data;

            return response;
        }

        public async Task<Response<ClientModel>> GetByIdAsync(string clientId)
        {
            var response = new Response<ClientModel>();

            var exists = await _clientRepository.ExistByIdAsync(clientId);

            if(!exists)
            {
                response.Report.Add(Report.Create($"Client {clientId} not exists!"));
                return response;
            }

            var data = await _clientRepository.GetByIdAsync(clientId);
            response.Data = data;

            return response;
        }

        public async Task<Response<List<ClientModel>>> ListByFilterAsync(string clientId = null, string name = null)
        {
            var response = new Response<List<ClientModel>>();

            if(!string.IsNullOrWhiteSpace(clientId))
            {
                response.Report.Add(Report.Create($"Client {clientId} not exists!"));
                return response;
            }

            var data = await _clientRepository.ListByFilterAsync(clientId, name);
            response.Data = data;

            return response;
        }
        
        public async Task<Response> UpdateAsync(ClientModel client)
        {
            var response = new Response();
            var validation = new ClientValidation();
            var errors = validation.Validate(client).GetErrors();

            if (errors.Report.Count > 0)
                return errors;

            var exists = await _clientRepository.ExistByIdAsync(client.Id);

            if(!exists)
            {
                response.Report.Add(Report.Create($"Client {client.Id} not exists!"));
                return response;
            }

            await _clientRepository.UpdateAsync(client);

            return response;
        }
    }
}
