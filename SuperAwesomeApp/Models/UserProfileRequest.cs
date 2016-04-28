using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SuperAwesomeApp.Models
{
    public class UserProfileRequest
    {
        public UserProfile UserProfile { get; set; }
        public string ErrorMessage { get; set; }
    }
}