using ProjectWork.Model;
using System.Data;
using System.Data.SqlClient;
using System.Dynamic;
using System.Windows.Forms;
using System.Configuration;
public class UserInfoRepository : IUserInfoRepository
{
    SqlConnection con;
   
    string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;

    public UserInfoRepository()
    {
        con = new SqlConnection(cs);
    }

    public void DeleteUser(UserInfo userInfo)
    {
        String query = "DELETE FROM dbo.StudentInfo WHERE Id=@Id";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("Id", userInfo.Id);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            con.Close();
        }
    }

    public List<UserInfo> GetAllUserInfo()
    {
        List<UserInfo> allInfo = new List<UserInfo>();
        String query = "SELECT * FROM dbo.StudentInfo";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UserInfo ui = new UserInfo
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    BookName = dr["BookName"].ToString(),
                    Faculty = dr["Faculty"].ToString(),
                    Returned = DateTime.Parse(dr["Returned"].ToString())
                };
                allInfo.Add(ui);
            }
        }
        finally
        {
            con.Close();
        }
        return allInfo;
    }

    public void InsertUser(UserInfo userInfo)
    {
        String query = "INSERT INTO dbo.StudentInfo VALUES(@Id, @Name, @BookName, @Faculty, @Returned)";
        try
        {
            Console.WriteLine("Hello world");
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("Id", userInfo.Id);
            cmd.Parameters.AddWithValue("Name", userInfo.Name);
            cmd.Parameters.AddWithValue("BookName", userInfo.BookName);
            cmd.Parameters.AddWithValue("Faculty", userInfo.Faculty);
            cmd.Parameters.AddWithValue("Returned", userInfo.Returned);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            con.Close();
        }
    }

    public void UpdateUser(UserInfo userInfo)
    {
        String query = "UPDATE dbo.StudentInfo SET Name=@Name, BookName=@BookName, Faculty=@Faculty, Returned=@Returned WHERE Id=@Id";
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("Id", userInfo.Id);
            cmd.Parameters.AddWithValue("Name", userInfo.Name);
            cmd.Parameters.AddWithValue("BookName", userInfo.BookName);
            cmd.Parameters.AddWithValue("Faculty", userInfo.Faculty);
            cmd.Parameters.AddWithValue("Returned", userInfo.Returned);
            cmd.ExecuteNonQuery();
        }
        finally
        {
            con.Close();
        }
    }
    public List<UserInfo> GetSearchInfo(String name)
    {
        String query = "Select * from dbo.StudentInfo where Name like @Name +'%'";
        List<UserInfo> users = new List<UserInfo>();
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("Name", name);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                UserInfo ui = new UserInfo
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Name = dr["Name"].ToString(),
                    BookName = dr["BookName"].ToString(),
                    Faculty = dr["Faculty"].ToString(),
                    Returned = DateTime.Parse(dr["Returned"].ToString())
                };
                users.Add(ui);
            }
            return users;

        }
        finally
            {
           
            con.Close() ;
        }
    }
}
