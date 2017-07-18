using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Driver;

namespace Shop
{
   public class NHibernateHelper
    {
        public static ISessionFactory sessionFactory;

       /* public static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var databaseConfig = OracleDataClientConfiguration.Oracle10
                        .ConnectionString(c => c.FromConnectionStringWithKey("Oracle"))
                        .Driver<OracleDataClientDriver>();

                    sessionFactory = Fluently.Configure()
                    .Database(databaseConfig)
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Stock>())
                    .BuildSessionFactory();
                }

                return sessionFactory;
            }
        }*/
    }
}
