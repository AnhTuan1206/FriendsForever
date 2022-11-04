using FriendsForever.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FriendsForever.Services
{
    public interface ISecurityService
    {
        void SaveUserToDB(RegisterViewModel model);
        bool IsValidUser(LogonViewModel model);
    }
}