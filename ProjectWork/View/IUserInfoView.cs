using ProjectWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork.View
{
    public interface IUserInfoView
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string UserBookName { get; set; }
        string UserFaculty { get; set; }
        DateTime UserReturned { get; set; }
        string UserSearch { get; set; }

        void DisplayMessage(string message);
        void DisplayError(string message);
       
        void DisplayRecords(List<UserInfo> userInfoList);
    }
}
