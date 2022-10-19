using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Cfg;
using NHibernate;
using Poseidon.Infrastructure.Data.Mapping;

namespace Poseidon.Infrastructure.Data;

public class NHibernateHelper
{
    private const string CurrentSessionKey = "nhibernate.current_session";
    private static readonly ISessionFactory _sessionFactory;
    static NHibernateHelper()
    {
        _sessionFactory = FluentConfigure();
    }
    public static ISession GetCurrentSession()
    {
        return _sessionFactory.OpenSession();
    }
    public static void CloseSession()
    {
        _sessionFactory.Close();
    }
    public static void CloseSessionFactory()
    {
        if (_sessionFactory != null)
        {
            _sessionFactory.Close();
        }
    }

    public static ISessionFactory FluentConfigure()
    {
        var cs = "Data Source=(localdb)\\ProjectModels;Initial Catalog=PoseidonDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        return Fluently.Configure()
            //which database
            .Database(
                MsSqlConfiguration.MsSql2012
                    .ConnectionString(cs).ShowSql())
            //2nd level cache
            .Cache(
                c => c.UseQueryCache()
                    .UseSecondLevelCache()
                    .ProviderClass<NHibernate.Cache.HashtableCacheProvider>())
            //find/set the mappings
            //.Mappings(m => m.FluentMappings.AddFromAssemblyOf<CustomerMapping>())
            .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ProfileMapping>())
            .BuildSessionFactory();
    }
}
