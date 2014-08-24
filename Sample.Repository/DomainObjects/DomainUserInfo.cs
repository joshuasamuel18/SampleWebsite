using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sample.Data;


namespace Sample.Repository
{
   public class DomainUserInfo
    {
        public static UserInfo ToDomainUserInfo(UserInfo _user)
        {
            return new UserInfo
            {
                UserId = _user.UserId,
                UserName = _user.UserName,
                EmailId = _user.EmailId,
                Name = _user.Name,
                Password = _user.Password,
                PhoneNo = _user.PhoneNo,
                Status = _user.Status
            };
        }

        public static List<UserInfo> ToDomainUserInfo(List<UserInfo> _userlist)
        {
            List<UserInfo> MyList = new List<UserInfo>();
            foreach (UserInfo _user in _userlist)
            {
                MyList.Add(DomainUserInfo.ToDomainUserInfo(_user));
            }
            return MyList;
        }
    }
}
