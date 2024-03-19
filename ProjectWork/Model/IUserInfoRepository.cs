using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork.Model
{
    public interface IUserInfoRepository
    {
        List<UserInfo> GetAllUserInfo();
        void InsertUser(UserInfo userInfo);
        void UpdateUser(UserInfo userInfo);
        void DeleteUser(UserInfo userInfo);
        List<UserInfo> GetSearchInfo(String name);
    }
}
