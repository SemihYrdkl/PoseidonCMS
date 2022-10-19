using NHibernate;
using Poseidon.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Data.Repositories
{
    public class RepositoryBase<T> /*: IBaseRepository<T> where T : class*/
    {
        //public RepositoryBase()
        //{

        //}

        //public void Delete(T entities)
        //{
        //    using (ISession _session = NHContext.SessionOpen())
        //    {
        //        using (ITransaction _transaction = _session.BeginTransaction())
        //        {
        //            try
        //            {
        //                _session.Delete(entities);
        //                _transaction.Commit();
        //            }
        //            catch (System.Exception ex)
        //            {
        //                if (!_transaction.WasCommitted)
        //                    _transaction.Rollback();

        //                throw new Exception("Delete Hata: " + ex.Message);
        //            }
        //        }
        //    }
        //}

        //public T GetByID(int id)
        //{
        //    using (ISession _session = NHContext.SessionOpen())
        //    {
        //        return _session.Get<T>(id);
        //    }
        //}

        //public IList<T> GetList()
        //{
        //    using (ISession _session = NHContext.SessionOpen())
        //    {
        //        return _session.Query<T>().ToList();
        //    }
        //}

        //public void Insert(T entities)
        //{
        //    using (ISession _session = NHContext.SessionOpen())
        //    {
        //        using (ITransaction _transaction = _session.BeginTransaction())
        //        {
        //            try
        //            {
        //                _session.Save(entities);
        //                _transaction.Commit();
        //            }
        //            catch (System.Exception ex)
        //            {
        //                if (!_transaction.WasCommitted)
        //                    _transaction.Rollback();

        //                throw new Exception("Insert Hata: " + ex.Message);
        //            }
        //        }
        //    }
        //}

        //public void Update(T entities)
        //{
        //    using (ISession _session = NHContext.SessionOpen())
        //    {
        //        using (ITransaction _transaction = _session.BeginTransaction())
        //        {
        //            try
        //            {
        //                _session.Update(entities);
        //                _transaction.Commit();
        //            }
        //            catch (System.Exception ex)
        //            {
        //                if (!_transaction.WasCommitted)
        //                    _transaction.Rollback();

        //                throw new Exception("Update Hata: " + ex.Message);
        //            }
        //        }
        //    }
        //}
    }
}
