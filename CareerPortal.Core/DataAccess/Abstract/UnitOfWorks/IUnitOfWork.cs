using CareerPortal.Core.DataAccess.Abstract.Dals;
using System;

namespace CareerPortal.Core.DataAccess.Abstract.UnitOfWorks
{
    public interface IUnitOfWork : IDisposable
    {
        ICountryDal countryDal { get; }
        IExperienceDal experienceDal { get; }
        IGenderDal genderDal { get; }
        IJobPostDal jobPostDal { get; }
        IJobPostStatusDal jobPostStatusDal { get; }
        IJobTypeDal jobTypeDal { get; }
        IRegionDal regionDal { get; }
        ISectorDal sectorDal { get; }
        IUserDal userDal { get; }
        IUserOperationClaimDal userOperationClaimDal { get; }

        /// <summary>
        /// Transaction Başlat.
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Kayıt esnasında bir sorun olmaz ise transaction durdur.
        /// </summary>
        void Commit();

        /// <summary>
        /// Kayıt esnasında bir sorun olursa değişiklikleri geri al.
        /// </summary>
        void Rollback();
        int Save();
    }
}
