
using ProjectWork.Model;

namespace LibraryManagementText.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void List_of_User_should_be_returned()
        {
            //Arrange
            UserInfoRepository ur = new UserInfoRepository();
            //Act
            var result = ur.GetAllUserInfo();
            //Assert
            Assert.IsNotNull(result);
           


        }
    }
}