using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AChallenge.Business.Concrete;
using AChallenge.Models.Concrete;
using AChallenge.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AChallenge.WebUI.Controllers
{
    public class HomeController : Controller
    {

        SurveyManager _surveyManager { get; set; }
        CoordinatorManager _coordinatorManager { get; set; }
        RespondentManager _respondentManager { get; set; }

        public HomeController(SurveyManager surveyManager, CoordinatorManager coordinatorManager, RespondentManager respondentManager)
        {
            this._surveyManager = surveyManager;
            this._coordinatorManager = coordinatorManager;
            this._respondentManager = respondentManager;
        }

        /* This is login screen */
        public IActionResult Index()
        {
            return View();
        }

        /* This is register screen */
        public IActionResult Create()
        {
            return View();
        }

        /* This is create a new account operation */
        [HttpPost]
        public IActionResult Create(Coordinator coordinator, string AccountType, string rePassword)
        {
            if (coordinator.Password == rePassword)
            {
                if (AccountType == "Respondent")
                {
                    Respondent respondent = new Respondent();
                    respondent.NameSurname = coordinator.NameSurname;
                    respondent.Mail = coordinator.Mail;
                    respondent.Username = coordinator.Username;
                    respondent.Password = coordinator.Password;
                    var state = _respondentManager.Add(respondent);
                    if (state == true)
                    {
                        TempData["MsgSuccess"] = "You succesfully created a new respondent account.";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["MsgError"] = "Someone has already registered with this username.";
                        return View();
                    }
                    
                }
                else if (AccountType == "Coordinator")
                {
                    var state =  _coordinatorManager.Add(coordinator);
                    if (state == true)
                    {
                        TempData["MsgSuccess"] = "You succesfully created a new coordinator account.";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["MsgError"] = "Someone has already registered with this username.";
                        return View();
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                TempData["MsgError"] = "Please check the password and re-password.";
                return View();
            }
        }

        [HttpPost]
        public IActionResult LoginCoordinator(HomeViewModel homeViewModel)
        {
            bool findCoordinator = _coordinatorManager.Login(homeViewModel.Coordinator);
            if (findCoordinator == true)
            {
                HttpContext.Session.SetString("SessionUsername", homeViewModel.Coordinator.Username);
                return RedirectToAction("Index", "Coordinator");
            }
            TempData["MsgError"] = "Username or password is not correct. Please, try again.";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult LoginRespondent(HomeViewModel homeViewModel)
        {
            bool findRespondent = _respondentManager.Login(homeViewModel.Respondent);
            if (findRespondent == true)
            {
                HttpContext.Session.SetString("SessionUsernameRespondent", homeViewModel.Respondent.Username);
                return RedirectToAction("Index", "Respondent");
            }
            TempData["MsgError"] = "Username or password is not correct. Please, try again.";
            return RedirectToAction("Index");
        }

        /* This is error screen */
        public IActionResult Error()
        {
            return View();
        }

    }
}