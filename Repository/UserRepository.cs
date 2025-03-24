using InsuranceMVC.Models;

namespace InsuranceMVC.Repository
{
    public class UserRepository
    {
        InsuranceDbContext utx;
        public UserRepository(InsuranceDbContext utx)
        {
            this.utx = utx;
        }

        public bool IsValidUser(string userName, string psw, string role)
        {
            bool b = false;
            User user = utx.Users.Where(u => u.UserName == userName && u.Password == psw && u.Role == role).FirstOrDefault();
            if (user != null)
            {
                b = true;
            }
            return b;
        }

        public bool Add(User user)
        {
            utx.Users.Add(user);
            int r = utx.SaveChanges();
            if (r > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
