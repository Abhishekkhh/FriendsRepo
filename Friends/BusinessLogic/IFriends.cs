using Friends.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friends.BusinessLogic
{
    public interface IFriends
    {
        Login CheckLoginDetails(Login login);
        List<DisplayFriends> GetDisplayFriends();
        ErrorMessage SaveFriend(string UserMasterId, string commaSepFriends);
        DisplayFriends GetFriendDetails(int FriendId);
        ErrorMessage SaveFriendDetails(DisplayFriends df, string UserMasterId);
        ErrorMessage SaveUserDetails(User user);


    }
}
