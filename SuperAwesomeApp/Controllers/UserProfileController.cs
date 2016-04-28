using SuperAwesomeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperAwesomeApp.Controllers
{
    public class UserProfileController : Controller
    {
        //
        // GET: /UserProfile/
        public ActionResult Results(UserProfileRequest userProfileRequest)
        {
            var context = new SAContext();
            var existingProfile = context.UserProfiles.Where(
                x => x.FirstName == userProfileRequest.UserProfile.FirstName && 
                x.MiddleName == userProfileRequest.UserProfile.MiddleName && 
                x.LastName == userProfileRequest.UserProfile.LastName).SingleOrDefault();
            if (existingProfile == null)
            {
                context.UserProfiles.Add(userProfileRequest.UserProfile);
                context.SaveChanges();
            }
            else
            {
                userProfileRequest.ErrorMessage = "Error, user profile already exists. Please try again.";
                return View("Index", userProfileRequest);
            }
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
