using Dapper;
using Friends.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.BusinessLogic
{
    public class FriendsFactory : IFriends
    {
        private IConfiguration Configuration;
        private string connStr = "";
        public FriendsFactory(IConfiguration _configuration)
        {
            Configuration = _configuration;
            connStr = this.Configuration.GetConnectionString("DefaultConnection");
        }
        public Login CheckLoginDetails(Login login)
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@MobileNo", login.MobileNo);
                queryParameters.Add("@Password", login.Password);

                var result = connection.Query<Login>(
                   "CheckLoginDetails",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).FirstOrDefault();
                return result;
            }

        }

        public List<DisplayFriends> GetDisplayFriends()
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();

                var result = connection.Query<DisplayFriends>(
                   "DisplayFriendsList",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public ErrorMessage SaveFriend(string UserMasterId, string commaSepFriends)
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Type", "Delete");
                queryParameters.Add("@CreatedBy", UserMasterId);
                queryParameters.Add("@DeleteCommaSepFriendId", commaSepFriends);

                var result = connection.Query<ErrorMessage>(
                   "Create_Update_Delete_Friend",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).FirstOrDefault();

                return result;
            }
        }

        public DisplayFriends GetFriendDetails(int FriendId)
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@FriendID", FriendId);

                var result = connection.Query<DisplayFriends>(
                   "DisplayFriendsList",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).FirstOrDefault();

                return result;
            }
        }

        public ErrorMessage SaveFriendDetails(DisplayFriends df, string UserMasterId)
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@Type", df.FriendId == 0 ? "Add" : "Update");
                queryParameters.Add("@FriendID", df.FriendId);
                queryParameters.Add("@FirstName", df.FirstName);
                queryParameters.Add("@LastName", df.LastName);
                queryParameters.Add("@EmailID", df.EmailID);
                queryParameters.Add("@MobileNo", df.MobileNo);
                queryParameters.Add("@CreatedBy", UserMasterId);

                var result = connection.Query<ErrorMessage>(
                   "Create_Update_Delete_Friend",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).FirstOrDefault();

                return result;
            }
        }

        public ErrorMessage SaveUserDetails(User user)
        {
            using (var connection = new SqlConnection(connStr))
            {
                var queryParameters = new DynamicParameters();
                queryParameters.Add("@FirstName", user.FirstName);
                queryParameters.Add("@LastName", user.LastName);
                queryParameters.Add("@EmailID", user.EmailID);
                queryParameters.Add("@MobileNo", user.MobileNo);
                queryParameters.Add("@Password", user.Password);

                var result = connection.Query<ErrorMessage>(
                   "Create_UpdateUser",
                    queryParameters,
                 commandType: CommandType.StoredProcedure).FirstOrDefault();

                return result;
            }
        }
    }
}
