using Order.Domain.Interface.Repository.DataConnector;

namespace Order.Domain.Interface.Repository
{
    public interface IUnitOfWork
    {
        IClientRepository ClientRepository { get; }
        IOrderRepository OrderRepository { get; }
        IProductRepository ProductRepository { get; }
        IUserRepository UserRepository { get; }
        IDbConnector DbConnector { get; set; }

        void BeginTransaction();
        void CommitTransaction();
        void RollbackTransaction();
    }
}
