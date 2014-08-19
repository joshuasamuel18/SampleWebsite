using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Data;


namespace Sample.Repository
{
   public class DomainUserInfo
    {
        public static UserInfo ToDomainUserInfo(userinfo _user)
        {
            return new UserInfo
            {
                UserId = _user.user_id,
                UserName = _user.username,
                EmailId = _user.emailid,
                Name = _user.name,
                Password = _user.password,
                PhoneNo = _user.phoneno,
                Status = _user.status
            };
        }

        public static List<UserInfo> ToDomainUserInfo(List<userinfo> _userlist)
        {
            List<UserInfo> MyList = new List<UserInfo>();
            foreach (userinfo _user in _userlist)
            {
                MyList.Add(DomainUserInfo.ToDomainUserInfo(_user));
            }
            return MyList;
        }
    }
}
