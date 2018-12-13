using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WeddingPlanner.Models;


namespace WeddingPlanner.Controllers
{
    public class UserController : Controller
    {
        #region Fields
        private UsersDbContext dbContext;


        // Controller to route to after a successful login
        private string _successController = "Wedding";
        public string SuccessController
        {
           get{ return _successController;}
        }
        // Controller-Action to route to after a successful login
        private string _successAction = "Wedding";
        public string SuccessAction
        {
           get{ return _successAction;}
        }
        #endregion

        #region Constructors
        public UserController( UsersDbContext context)
        {
            dbContext = context;
        }
        #endregion

        #region Actions
        //--------------------------------------------------------------
        // GET: Index, Displays registration
        [HttpGet]
        [Route("")]
        public IActionResult Registration()
        {
            return View();
        }

        //--------------------------------------------------------------
        // POST: RegistrationSave, Validates registration.  If valid, 
        //       adds user and routes to Login.  If NOT valid,
        //       routes back to Registration view
        [HttpPost]
        [Route("registrationsave")]
        public IActionResult RegistrationSave(User user)
        {
            if( ModelState.IsValid)
            {
                // Verify email address is not already registered in users 
                var userInDb = dbContext.User.FirstOrDefault(u => u.Email == user.Email);
                if( userInDb != null)
                {
                    ModelState.AddModelError("Email", "This Email Address is already registered.");
                    return View("Registration");
                }

                // Verify password and confirm password match
                if( user.Password != user.ConfirmPassword)
                {
                    ModelState.AddModelError("Password", "Password does not match Confirm Password.");
                    return View("Registration");
                }

                // Initialize PasswordHasher so we can saved the user's password as a hashed string
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                user.Password = hasher.HashPassword(user, user.Password);

                DateTime now = DateTime.Now;
                user.CreatedAt = now;
                user.UpdatedAt = now;
                dbContext.Add(user);
                dbContext.SaveChanges();

                // Log user in
                logUserIn( user);

                return RedirectToAction(this.SuccessAction, this.SuccessController, new {userId = user.UserId});
            }
            else
            {
                return View("Registration");
            }
        }        

        //--------------------------------------------------------------
        // GET: Login, Displays login view
        [HttpGet]
        [Route("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        //--------------------------------------------------------------
        // Post: LoginSave, Validates login.  If valid, routes to Success 
        //       view.  If NOT valid, routes to Login view
        [HttpPost]
        [Route("loginsave")]
        public IActionResult LoginSave(Login login)
        {
            System.Console.WriteLine("-----------------------------LoginSave(1)------------------------------");

            if( ModelState.IsValid)
            {
                 // Verify email address exists in the users table
                User userInDb = dbContext.User.FirstOrDefault(u => u.Email == login.LoginEmail);
                if( userInDb == null)
                {
                    System.Console.WriteLine("-----------------------------LoginSave(2)------------------------------");

                    ModelState.AddModelError("LoginEmail", "Email Address was not found.");
                    return View("Registration");
                }

                // Hash password and confirm hashed password matches hashed password in DB
                var hasher = new PasswordHasher<Login>();
                var result = hasher.VerifyHashedPassword(login, userInDb.Password, login.LoginPassword);
                if( result == 0)
                {
                    System.Console.WriteLine("-----------------------------LoginSave(3)------------------------------");

                    ModelState.AddModelError("LoginPassword", "Invalid Password.");
                    return View("Registration");
                }

                // Log user in
                logUserIn(userInDb);

                System.Console.WriteLine("-----------------------------LoginSave(4)------------------------------");
                System.Console.WriteLine($"Action: {this.SuccessAction}, Controller: {this.SuccessController}, UserId: {userInDb.UserId}");

                return RedirectToAction(this.SuccessAction, this.SuccessController, new {userId = userInDb.UserId});
            }
            return View("Registration");
        }

        //--------------------------------------------------------------
        // Post: Logout, Logs user out and routes to the Register view
        [HttpPost]
        [Route("logout")]
        public IActionResult Logout()
        {
            logUserOut();
            return View("Registration");
        }

        //--------------------------------------------------------------
        // GET: LoggedIn, If user is logged in the success view is displayed; 
        //      otherwise, the Login view is displayed.
        [HttpGet]
        [Route("loggedin")]
        public IActionResult LoggedIn()
        {
            if( isUserLoggedIn())
            {
                return RedirectToAction(this.SuccessAction, this.SuccessController);
            }
            else
            {
                return View("Login");
            }
        }
        #endregion


        #region Methods
        //--------------------------------------------------------------
        private void logUserIn(User user)
        {
            System.Console.WriteLine("---------------------------LogUserIn ---------------------------------------");
            System.Console.WriteLine($"User: {user.UserId}");

            HttpContext.Session.SetInt32("LoggedIn", 1);  // 1=Logged in;  null or 0 = NOT logged in
            HttpContext.Session.SetInt32("LoggedInUserId", user.UserId);
            HttpContext.Session.SetString("LoggedInUserEmail", user.Email);
            HttpContext.Session.SetString("LoggedInUserFirstName", user.FirstName);
            HttpContext.Session.SetString("LoggedInUserLastName", user.LastName);
        }

        //--------------------------------------------------------------
        private bool logUserOut()
        {
            bool loggedOut = false;
            if( HttpContext.Session.GetInt32("LoggedIn") == 1)
            {
                HttpContext.Session.Clear();
                loggedOut = true;
            }
            return loggedOut;
        }

        //--------------------------------------------------------------
        private bool isUserLoggedIn()
        {
            bool isLoggedIn = false;
            if (HttpContext.Session.GetInt32("LoggedIn") == 1)
            {
                isLoggedIn = true;
            }
            return isLoggedIn;
        }
        #endregion
    }
}