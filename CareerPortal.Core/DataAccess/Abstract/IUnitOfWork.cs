namespace CareerPortal.Core.DataAccess.Abstract
{
    public interface IUnitOfWork
    {
        int SaveChanges();
    }
}
