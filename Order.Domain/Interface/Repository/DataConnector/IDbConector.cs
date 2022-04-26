using System;
using System.Data;

namespace Order.Domain.Interface.Repository.DataConnector
{
    public interface IDbConnector : IDisposable
    {
        IDbConnection dbConnection { get; }
        IDbTransaction dbTransaction { get; set; }

        IDbTransaction BeginTransaction(IsolationLevel isolation);
    }
}
