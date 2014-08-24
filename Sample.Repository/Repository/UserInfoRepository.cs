using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Data;
using Sample.Data.IRepository;
using Sample.Common.Helpers;

namespace Sample.Repository
{
   public class UserInfoRepository:IUserInfoRepository
    {

       DataRepository<UserInfo> dbcontext = null;
       
       public bool Save(UserInfo _user)
       {
           dbcontext = new DataRepository<UserInfo>();

           UserInfo user = new UserInfo();
           user.Name = _user.Name;
           user.EmailId = _user.EmailId;
           user.PhoneNo = _user.PhoneNo;
           user.UserName = _user.UserName;
           user.Password = DataEncryption.Encrypt(_user.Password);
           dbcontext.Add(user);
           dbcontext.SaveChanges();
           return true;
       }

        public List<UserInfo> GetAll()
        {
            dbcontext = new DataRepository<UserInfo>();

            var users = dbcontext.GetAll().ToList();

            return DomainUserInfo.ToDomainUserInfo(users);                 
        }

        public UserInfo GetById(UserInfo user)
        {
            dbcontext = new DataRepository<UserInfo>();

            var _user = dbcontext.First(x => x.UserId == user.UserId);

            return DomainUserInfo.ToDomainUserInfo(_user);   
        }
    }
}
