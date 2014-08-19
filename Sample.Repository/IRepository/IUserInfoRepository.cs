using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sample.Repository
{
   public interface IUserInfoRepository 
    {
       bool Save(UserInfo user);
        
       List<UserInfo> GetAll();

       UserInfo GetById(UserInfo user);
    }
}
