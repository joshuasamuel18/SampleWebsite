using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Data;
using Sample.Data.IRepository;

namespace Sample.Repository
{
   public class UserInfoRepository:IUserInfoRepository
    {

       DataRepository<userinfo> dbcontext = null;

       public bool Save(UserInfo _user)
       {
           dbcontext = new DataRepository<userinfo>();

           userinfo user = new userinfo();
           user.name = _user.Name;
           user.emailid = _user.EmailId;
           user.phoneno = _user.PhoneNo;
           user.username = _user.UserName;
           user.password = _user.Password;

           dbcontext.Add(user);
           dbcontext.SaveChanges();
           return true;
       }

        public List<UserInfo> GetAll()
        {
            dbcontext = new DataRepository<userinfo>();

            var users = dbcontext.GetAll().ToList();

            return DomainUserInfo.ToDomainUserInfo(users);                 
        }

        public UserInfo GetById(UserInfo user)
        {
            dbcontext = new DataRepository<userinfo>();

            var _user = dbcontext.First(x => x.user_id == user.UserId);

            return DomainUserInfo.ToDomainUserInfo(_user);   
        }
    }
}
