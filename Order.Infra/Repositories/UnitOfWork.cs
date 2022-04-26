using Order.Domain.Interface.Repository;
using Order.Domain.Interface.Repository.DataConnector;
using System;

namespace Order.Infra.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private IClientRepository _clientRepository;
        private IProductRepository _productRepository;
        private IOrderRepository _orderRepository;
        private IUserRepository _userRepository;

        public UnitOfWork(IDbConnector dbConnector)
        {
            DbConnector = dbConnector;
        }

        public IClientRepository ClientRepository => _clientRepository ?? (_clientRepository = new ClientRepository(DbConnector));

        public IOrderRepository OrderRepository => throw new NotImplementedException();

        public IProductRepository ProductRepository => throw new NotImplementedException();

        public IUserRepository UserRepository => throw new NotImplementedException();

        public IDbConnector DbConnector { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public void CommitTransaction()
        {
            throw new NotImplementedException();
        }

        public void RollbackTransaction()
        {
            throw new NotImplementedException();
        }
    }
}
