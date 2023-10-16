using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers{

    public class HomeController:Controller{

        public IActionResult Index(){
           int saat= DateTime.Now.Hour;
           
           ViewBag.selamlama= saat > 12 ? "İyi günler":"Günaydın";

           ViewData["Hg"]=saat > 12?"Hoş geldiniz":"Beş gittiniz";
            int UserCount=Repository.Users.Where(i=> i.WillAttend==true).Count();
           var meetingInfo= new MeetingInfo(){
            Id=1, Location="Harmandere", Date=new DateTime(2024, 01,20,20,0,0),  NumberOfPeople=UserCount
           };
            return View(meetingInfo);
            }
    }
}