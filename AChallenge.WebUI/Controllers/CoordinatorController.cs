using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AChallenge.Business.Concrete;
using AChallenge.Models.Concrete;
using AChallenge.QrCodeCreator;
using AChallenge.WebUI.Helpers.Auth;
using AChallenge.WebUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AChallenge.WebUI.Controllers
{
    [AuthFilter]
    public class CoordinatorController : Controller
    {

        SurveyManager _surveyManager { get; set; }
        CoordinatorManager _coordinatorManager { get; set; }
        RespondentManager _respondentManager { get; set; }
        ResponseManager _responseManager { get; set; }

        public CoordinatorController(SurveyManager surveyManager, CoordinatorManager coordinatorManager, RespondentManager respondentManager, ResponseManager responseManager)
        {
            this._surveyManager = surveyManager;
            this._coordinatorManager = coordinatorManager;
            this._respondentManager = respondentManager;
            this._responseManager = responseManager;
        }

        /* Coordinator Dashboard Page */
        public IActionResult Index()
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            ViewBag.Statistic1 = _surveyManager.GetAllOpenSurveys().Count;
            ViewBag.Statistic2 = _surveyManager.GetAllByCoordinatorId(coordinator.Id).Count;
            ViewBag.Statistic3 = _responseManager.GetAll().Count;
            ViewBag.Statistic4 = _responseManager.GetAll().Count;
            return View();
        }

        /* Coordinator Quit */
        public IActionResult Quit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");
        }

        /* Coordinator Statistics Page */
        public IActionResult Statistics()
        {
            return View();
        }

        /************************** SURVEYS OPERATIONS **************************/

        /* Coordinator Open Surveys Page */
        public IActionResult OpenSurveys()
        {
            return View(_surveyManager.GetAllOpenSurveys());
        }

        /* Coordinator Open Survey Detail Page */
        public IActionResult OpenSurvey(string Id)
        {
            Survey findSurvey = _surveyManager.GetById(Id);
            return View(findSurvey);
        }

        /* Coordinator My Surveys Page */
        public IActionResult MySurveys()
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(_surveyManager.GetAllByCoordinatorId(coordinator.Id));
        }

        /* Coordinator Add Survey Page */
        public IActionResult AddSurvey()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSurvey(Survey survey)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            List<Question> questions = new List<Question>();
            survey.CreatedDate = DateTime.Now.ToShortDateString();
            survey.IsVisible = "true";
            survey.Questions = questions;
            survey.CoordinatorId = coordinator.Id;
            _surveyManager.Add(survey);
            TempData["MsgSuccess"] = "Added a new survey to system.";
            return RedirectToAction("MySurveys");
        }

        /* Delete Survey */
        public IActionResult DeleteSurvey(string Id)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            _surveyManager.Delete(Id);
            TempData["MsgSuccess"] = "Survey deleted succesfully.";
            return RedirectToAction("MySurveys");
        }

        /* Survey Qr Code */
        public IActionResult SurveyQrCode(string Id)
        {
            Survey findSurvey = _surveyManager.GetById(Id);
            Byte[] testing = GenerateQrCoder.Generate(findSurvey.Id.ToString());
            return View(testing);
        }

        /* Edit Survey */
        [HttpPost]
        public IActionResult EditSurvey(string Id, string Title, string Description, string IsVisible)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            findSurvey.Title = Title;
            findSurvey.Description = Description;
            findSurvey.IsVisible = IsVisible;
            _surveyManager.Update(Id, findSurvey);
            TempData["MsgSuccess"] = "Survey updated succesfully.";
            return RedirectToAction("MySurveys");
        }

        /************************** QUESTION OPERATIONS **************************/

        /* This function list question of form */
        public IActionResult Questions(string Id)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(findSurvey);
        }

        [HttpPost]
        public IActionResult Questions(string Id, string Title,string[] fieldName)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            Question question = new Question();
            question.Title = Title;
            question.Options = fieldName;
            findSurvey.Questions.Add(question);
            _surveyManager.Update(Id, findSurvey);
            TempData["MsgSuccess"] = "Added a new question to survey.";
            return RedirectToAction("Questions", new { Id = findSurvey.Id });
        }

        [HttpPost]
        public IActionResult EditQuestion(string Id, string Number, string Title, string[] fieldName)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            Question question = new Question();
            question.Title = Title;
            question.Options = fieldName;
            findSurvey.Questions[Convert.ToInt16(Number) - 1] = question;
            _surveyManager.Update(Id, findSurvey);
            TempData["MsgSuccess"] = "Updated a new question to survey.";
            return RedirectToAction("Questions", new { Id = findSurvey.Id });
        }

        [HttpPost]
        public IActionResult DeleteQuestion(string Id, string Number)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            findSurvey.Questions.RemoveAt(Convert.ToInt16(Number) - 1);
            _surveyManager.Update(Id, findSurvey);
            TempData["MsgSuccess"] = "Deleted a question to survey.";
            return RedirectToAction("Questions", new { Id = findSurvey.Id });
        }

        /************************** RESPONSE OPERATIONS **************************/

        /* Show responses by survey id */
        public IActionResult Responses(string Id)
        {
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            ViewBag.SurveyName = findSurvey.Title;
            return View(_responseManager.GetAllBySurveyId(findSurvey.Id));
        }

        /* Show response detail by response id */
        public IActionResult ResponseDetail(string Id)
        {
            var findResponse = _responseManager.GetById(Id);
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(findResponse.SurveyId.ToString());
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            ViewBag.FindSurvey = findSurvey.Questions;
            ViewBag.FindSurveyTitle = findSurvey.Title;
            return View(findResponse);
        }

        /* Show responses by survey id */
        public IActionResult ResponseDelete(string Id)
        {
            var findResponse = _responseManager.GetById(Id);
            Coordinator coordinator = _coordinatorManager.GetByUsername(HttpContext.Session.GetString("SessionUsername"));
            if (coordinator == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(findResponse.SurveyId.ToString());
            if (findSurvey.CoordinatorId != coordinator.Id)
            {
                return RedirectToAction("Error", "Home");
            }
            _responseManager.Delete(Id);
            return RedirectToAction("MySurveys");
        }

    }
}