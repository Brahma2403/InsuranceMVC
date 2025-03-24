using InsuranceMVC.Models;

namespace InsuranceMVC.Repositories
{
    public class ClaimRepository
    {
        InsuranceDbContext ctx;
        public ClaimRepository(InsuranceDbContext ctx)
        {
            this.ctx = ctx;
        }
        public bool AddClaim(Claim claim)
        {
            ctx.Claims.Add(claim);
            int r = ctx.SaveChanges();
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //public bool RemoveClaim(Claim claim)
        //{
        //    etx.Claims.Remove(claim);
        //    int r = etx.SaveChanges();
        //    if (r > 0)
        //        return true;
        //    else
        //        return false;
        //}
        public bool UpdateClaim(Claim claim)
        {
            Claim claimUp = ctx.Claims.Find(claim.ClaimId);
            claimUp.ClaimAmount = claim.ClaimAmount;
            claimUp.ClaimStatus = claim.ClaimStatus;
            claimUp.SubmissionDate = claim.SubmissionDate;
            claimUp.SettlementDate = claim.SettlementDate;
            int r = ctx.SaveChanges();
            if (r > 0)
                return true;
            else
                return false;

        }
        public Claim SearchClaim(int ClaimId)
        {
            return ctx.Claims.Find(ClaimId);
        }
        public List<Claim> AllClaimDetails()
        {
            return ctx.Claims.ToList();
        }
    }
}