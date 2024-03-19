using ProjectWork.Model;
using ProjectWork.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProjectWork.Presenter
{

    public class UserInfoPresenter
    {
        private readonly IUserInfoRepository _repository;
        private readonly IUserInfoView _view;

        public UserInfoPresenter(IUserInfoView view, IUserInfoRepository repository)
        {
            _view = view;
            _repository = repository;
        }

        public void InsertUser()
        {
            if(_view.UserId==null)
            {
                _view.DisplayMessage("Id cannot be null");
            }
            else if(_view.UserName=="")
            {
                _view.DisplayMessage("Username Cannot be null");
                
            }
            else if (_view.UserBookName == "")
            {
                _view.DisplayMessage("BookName Cannot be null");
            }
            else if (_view.UserFaculty == "")
            {
                _view.DisplayMessage("Faculty Cannot be null");
            }
            else if (_view.UserReturned >= DateTime.Now)
            {
                _view.DisplayMessage("Date Cannot be smaller than today");
            }
            else {
                try
                {
                    UserInfo userInfo = new UserInfo
                    {
                        Id = _view.UserId,
                        Name = _view.UserName,
                        BookName = _view.UserBookName,
                        Faculty = _view.UserFaculty,
                        Returned = _view.UserReturned
                    };

                    _repository.InsertUser(userInfo);
                    _view.DisplayMessage("Successfully Value Inserted Successfully");
                    ClearUser();
                    _view.DisplayRecords(_repository.GetAllUserInfo());
                }
                catch (Exception ex)
                {
                    _view.DisplayError(ex.Message);
                }
            }
            
        }

        public void UpdateUser()
        {
            if (_view.UserId == null)
            {
                _view.DisplayMessage("Id cannot be null");
            }
            else if (_view.UserName == "")
            {
                _view.DisplayMessage("Username Cannot be null");

            }
            else if (_view.UserBookName == "")
            {
                _view.DisplayMessage("BookName Cannot be null");
            }
            else if (_view.UserFaculty == "")
            {
                _view.DisplayMessage("Faculty Cannot be null");
            }
            else if (_view.UserReturned >= DateTime.Now)
            {
                _view.DisplayMessage("Date Cannot be smaller than today");
            }
            else
            {
                try
                {
                    UserInfo userInfo = new UserInfo
                    {
                        Id = _view.UserId,
                        Name = _view.UserName,
                        BookName = _view.UserBookName,
                        Faculty = _view.UserFaculty,
                        Returned = _view.UserReturned
                    };

                    _repository.UpdateUser(userInfo);
                    _view.DisplayMessage("Successfully Value Updated Successfully");
                    ClearUser();
                    _view.DisplayRecords(_repository.GetAllUserInfo());
                }
                catch (Exception ex)
                {
                    _view.DisplayError(ex.Message);
                }
            }
        }

        public void DeleteUser()
        {
            if (_view.UserId == null)
            {
                _view.DisplayMessage("User Id Cannot be null");
            }
            else
            {
                try
                {
                    UserInfo userInfo = new UserInfo
                    {
                        Id = _view.UserId,
                        Name = _view.UserName,
                        BookName = _view.UserBookName,
                        Faculty = _view.UserFaculty,
                        Returned = _view.UserReturned
                    };
                    _repository.DeleteUser(userInfo);
                    _view.DisplayMessage("Successfully Value Deleted Successfully");
                    _view.DisplayRecords(_repository.GetAllUserInfo());
                }
                catch (Exception ex)
                {
                    _view.DisplayError(ex.Message);
                }
            }
           
        }
        public List<UserInfo> GetAllUserInfo()
        {
            try
            {
                List<UserInfo> userInfoList = _repository.GetAllUserInfo();
                _view.DisplayRecords(userInfoList);
                return userInfoList;
            }
            catch (Exception ex)
            {
                _view.DisplayError(ex.Message);
                return new List<UserInfo>(); 
            }
        }
        public List<UserInfo> SearchUser()
        {
            List<UserInfo> lst=new List<UserInfo>();
            try
            {
                String name = _view.UserSearch;
            lst=_repository.GetSearchInfo(name);
                _view.DisplayRecords(lst);
                return lst;
            }
            catch(Exception ex) { 
            _view.DisplayError(ex.Message); 
                
                return new List<UserInfo>();
            
            }
            
        }
        public void ClearUser()
        {
            _view.UserId = Convert.ToInt32(null);
            _view.UserName = "";
             _view.UserBookName = "";
           _view.UserFaculty = "";
            _view.UserReturned = Convert.ToDateTime(null);

        }

    }

}
