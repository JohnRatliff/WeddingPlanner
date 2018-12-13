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
    public class WeddingController : Controller
    {
        #region Fields
        private WeddingPlannerDbContext dbContext;

        #endregion

        #region Constructors
        public WeddingController( WeddingPlannerDbContext context)
        {
            dbContext = context;
        }
        #endregion

        #region Actions
        //--------------------------------------------------------------
        // GET: Display weddings view
        [HttpGet]
        [Route("dashboard")]
        public IActionResult Wedding()
        {
            System.Console.WriteLine("-----------------------------------Wedding--------------------------------------");

            List<WeddingView> allWeddings = getAllWeddings();
            ViewBag.AllWeddings = allWeddings;
            ViewBag.LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
            ViewBag.LoggedInUserFirstName = HttpContext.Session.GetString("LoggedInUserFirstName");
            return View();
        }

        //--------------------------------------------------------------
        // GET: Display New weddings view
        [HttpGet]
        [Route("dashboard/new")]
        public IActionResult WeddingNew()
        {
            System.Console.WriteLine("-----------------------------------WeddingNew--------------------------------------");
            if (HttpContext.Session.GetInt32("LoggedIn") != 1)
            {
                return View("Registration");
            }

            List<User> allUsers = getAllUsers();
            ViewBag.AllUsers = allUsers;
            return View("WeddingNew");
        }

        //--------------------------------------------------------------
        // POST: Save new wedding
        [HttpPost]
        [Route("dashboard/new/save")]
        public IActionResult WeddingNewSave(Wedding wedding)
        {
            System.Console.WriteLine("-----------------------------------WeddingNewSave--------------------------------------");

            bool isValid = ModelState.IsValid;
            if( isValid)
            {
                if( wedding.WedderOneUserId == wedding.WedderTwoUserId)
                {
                    ModelState.AddModelError("WedderOneUserId", "Wedder One and Two cannot be the same.");
                    isValid = false;
                }
            }

            if( isValid)
            {
                // Add new wedding
                DateTime now = DateTime.Now;
                wedding.CreatedAt = now;
                wedding.UpdatedAt = now;
                wedding.CreatorUserId = (int)HttpContext.Session.GetInt32("LoggedInUserId");
                dbContext.Add(wedding);
                dbContext.SaveChanges();

                return RedirectToAction("WeddingGuestList", new {weddingId = wedding.WeddingId});
            }
            else
            {
                // New wedding is invalid, route back to wedding view
                List<User> allUsers = getAllUsers();
                ViewBag.AllUsers = allUsers;
                return View("WeddingNew", wedding);
            }
        }


        //--------------------------------------------------------------
        // DELETE: Delete passed wedding
        [HttpPost]
        [Route("wedding/delete/{weddingId:int}")]
        public IActionResult WeddingDelete(int weddingId)
        {
            System.Console.WriteLine("-----------------------------------WeddingDelete--------------------------------------");
            System.Console.WriteLine($"weddintId: {weddingId}");

            Wedding weddingInDb = getWedding(weddingId);
            if( weddingInDb == null)
            {
                // Wedding not found in Db, route back to the Wedding view  (Future generate an error to display)
                return RedirectToAction("Wedding");
            }
            else
            {
                // Delete wedding row
                dbContext.Wedding.Remove(weddingInDb);
                dbContext.SaveChanges();
                return RedirectToAction("Wedding");
            }
        }

        //--------------------------------------------------------------
        // GET: Display the Guest List view for the passed wedding
        [HttpGet]
        [Route("wedding/guestlist/{weddingId:int}")]
        public IActionResult WeddingGuestList(int weddingId)
        {
            System.Console.WriteLine("-----------------------------------WeddingGuestList--------------------------------------");
            if (HttpContext.Session.GetInt32("LoggedIn") != 1)
            {
                return View("Registration");
            }

            Wedding wedding = getWedding(weddingId); 
            List<Guest> guestList = getGuestList(weddingId);
            ViewBag.GuestList = guestList;
            return View("WeddingGuestList", wedding);
        }
        #endregion


        #region Methods

        //--------------------------------------------------------------
        // Select and return all weddings by wedding date asc
        private List<WeddingView> getAllWeddings()
        {
            List<WeddingView> allWeddings = (from w in dbContext.WeddingView
                                               orderby w.WeddingDate ascending
                                               select w).ToList();
            return allWeddings;
        }
 
        //--------------------------------------------------------------
        // Select and return all users by last name asc
        private List<User> getAllUsers()
        {
            List<User> allUsers = (from u in dbContext.User
                                               orderby u.LastName ascending
                                               select u).ToList();
            return allUsers;
        }
 
        //--------------------------------------------------------------
        // Select and return all users by last name asc
        private Wedding getWedding(int weddingId)
        {
            Wedding wedding = (from w in dbContext.Wedding
                                 where w.WeddingId == weddingId
                                 select w).Include("WedderOne").Include("WedderTwo").FirstOrDefault();
            return wedding;
        }
 
        //--------------------------------------------------------------
        // Select and return all users by last name asc
        private List<Guest> getGuestList(int weddingId)
        {
            List<Guest> guestList = (from g in dbContext.Guest
                                       where g.WeddingId == weddingId
                                       select g).Include("User").Include("Wedding").ToList();
            return guestList;
        }
 
        #endregion
    }
}