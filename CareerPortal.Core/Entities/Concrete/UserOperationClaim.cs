namespace CareerPortal.Core.Entities.Concrete
{
    public class UserOperationClaim : Entity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}
