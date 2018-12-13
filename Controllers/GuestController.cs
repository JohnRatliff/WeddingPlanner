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
    public class GuestController : Controller
    {
        #region Fields
        private WeddingPlannerDbContext dbContext;

        #endregion

        #region Constructors
        public GuestController( WeddingPlannerDbContext context)
        {
            this.dbContext = context;
        }
        #endregion

        #region Actions
        //--------------------------------------------------------------
        // POST: Add a new Guest row for the passed weddingId and UserId
        [HttpPost]
        [Route("guest/rsvp/{weddingId}/{userId}")]
        public IActionResult GuestRSVP(int weddingId, int userId)
        {
            System.Console.WriteLine("-----------------------------------Guest-RSVP--------------------------------------");

            // Ensure Guest row does not exist
            Guest guestInDb = getGuest( weddingId, userId);
            if( guestInDb != null)
            {
                // Guest already exists in Db, route back to wedding view  (Future: generate an error and display on routed view)
                return RedirectToAction("Wedding", "Wedding");
            }
            else
            {
                // Add new wedding Guest
                DateTime now = DateTime.Now;
                Guest newGuest = new Guest
                {
                  WeddingId = weddingId,
                  UserId = userId,
                  CreatedAt = now,
                  UpdatedAt = now
                };
    
                dbContext.Add(newGuest);
                dbContext.SaveChanges();
                return RedirectToAction("WeddingGuestList", "Wedding", new {weddingId = weddingId});
            }
        }

        //--------------------------------------------------------------
        // POST: Delete the Guest row related to the passed weddingId and UserId
        [HttpPost]
        [Route("guest/unrsvp/{weddingId}/{userId}")]
        public IActionResult GuestUnRSVP(int weddingId, int userId)
        {
            System.Console.WriteLine("-----------------------------------Guest-Un-RSVP--------------------------------------");

            Guest guestInDb = getGuest(weddingId, userId);
            if( guestInDb == null)
            {
                // Guest not found in Db, route to Weddint view (Future: generate an error and display on routed view)
                return RedirectToAction("Wedding", "Wedding");
            }
            else
            {
                // Delete guest row
                dbContext.Guest.Remove(guestInDb);
                dbContext.SaveChanges();
                return RedirectToAction("WeddingGuestList", "Wedding", new {weddingId = weddingId});
            }
        }
        #endregion

        #region Methods

        //--------------------------------------------------------------
        // Select and return the Guest related to the passed userId
        private Guest getGuest( int weddingId, int userId)
        {
            Guest guest = (from g in dbContext.Guest
                             where g.WeddingId == weddingId && g.UserId == userId
                             select g).FirstOrDefault();
            return guest;
        }
        #endregion
    }
}