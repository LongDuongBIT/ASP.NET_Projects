namespace Store.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private StoreEntities dbContext;
        private readonly IDbFactory dbFactory;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public StoreEntities DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }

        public void Commit()
        {
            DbContext.Commit();
        }
    }
}