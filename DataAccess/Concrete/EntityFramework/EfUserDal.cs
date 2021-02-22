using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NotebookContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (NotebookContext context = new NotebookContext())
            {
                var result = context.Users.Join(context.Passwords,
                    u => u.PasswordID,
                    p => p.PasswordID,
                    (u, p) => new UserDetailDto
                    {
                        UserID = u.UserID,
                        UserName = u.UserName,
                        Password = p.UserPassword
                    });
                return result.ToList();
            }
        }
    }
}
