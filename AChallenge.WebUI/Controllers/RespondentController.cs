using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AChallenge.Business.Concrete;
using AChallenge.Models.Concrete;
using AChallenge.WebUI.Helpers.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AChallenge.WebUI.Controllers
{
    [AuthFilterRespondent]
    public class RespondentController : Controller
    {

        SurveyManager _surveyManager { get; set; }
        CoordinatorManager _coordinatorManager { get; set; }
        RespondentManager _respondentManager { get; set; }
        ResponseManager _responseManager { get; set; }

        public RespondentController(SurveyManager surveyManager, CoordinatorManager coordinatorManager, RespondentManager respondentManager, ResponseManager responseManager)
        {
            this._surveyManager = surveyManager;
            this._coordinatorManager = coordinatorManager;
            this._respondentManager = respondentManager;
            this._responseManager = responseManager;
        }

        /* Coordinator Respondent Page */
        public IActionResult Index()
        {
            ViewBag.Statistic1 = _surveyManager.GetAllOpenSurveys().Count;
            ViewBag.Statistic2 = joinSurveyCount().ToString();
            return View();
        }

        /* Respondent Quit */
        public IActionResult Quit()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        /* Respondent Statistics Page */
        public IActionResult Statistics()
        {
            return View();
        }

        /************************** SURVEYS OPERATIONS **************************/

        /* Open Surveys Page */
        public IActionResult OpenSurveys()
        {
            return View(_surveyManager.GetAllOpenSurveys());
        }

        public IActionResult Survey(string Id)
        {
            Respondent respondent = _respondentManager.GetByUsername(HttpContext.Session.GetString("SessionUsernameRespondent"));
            if (respondent == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey survey = _surveyManager.GetById(Id);
            if (survey == null)
            {
                return RedirectToAction("Error", "Home");
            }
            if (_responseManager.CheckRespondentJoinThisSurvey(survey.Id, respondent.Id) == false)
            {
                ViewBag.RespondentAnswers = _responseManager.GetBySurveyAndRespondent(survey.Id, respondent.Id);
                survey.Title = "ErrorCode202akfjryhskfhfgsgsgajskkf";
            }
            return View(survey);
        }
        [HttpPost]
        public IActionResult Survey(string Id, string[] radiovalue)
        {
            Respondent respondent = _respondentManager.GetByUsername(HttpContext.Session.GetString("SessionUsernameRespondent"));
            if (respondent == null)
            {
                return RedirectToAction("Error", "Home");
            }
            Survey findSurvey = _surveyManager.GetById(Id);
            if (_responseManager.CheckRespondentJoinThisSurvey(findSurvey.Id, respondent.Id) == false)
            {
                return RedirectToAction("Error", "Home");
            }
            if (radiovalue.Length != findSurvey.Questions.Count)
            {
                return RedirectToAction("Error", "Home");
            }

            Response response = new Response();
            response.Title = findSurvey.Title;
            response.Answers = radiovalue;
            response.SurveyId = findSurvey.Id;
            response.RespondentId = respondent.Id;

            _responseManager.Add(response);

            TempData["MsgSuccess"] = "Your answers saved succesfully. Thanks for your join.";
            return RedirectToAction("OpenSurveys");
        }

        /* Open Surveys Page */
        public IActionResult JoinedSurveys()
        {
            Respondent respondent = _respondentManager.GetByUsername(HttpContext.Session.GetString("SessionUsernameRespondent"));
            if (respondent == null)
            {
                return RedirectToAction("Error", "Home");
            }
            List<Response> responses = _responseManager.GetAll().Where(x => x.RespondentId == respondent.Id).ToList();
            List<Survey> findSurveys = new List<Survey>();
            for (int i = 0; i < responses.Count; i++)
            {
                findSurveys.Add(_surveyManager.GetById(responses[i].SurveyId.ToString()));
            }
            return View(findSurveys);
        }

        int joinSurveyCount()
        {
            Respondent respondent = _respondentManager.GetByUsername(HttpContext.Session.GetString("SessionUsernameRespondent"));
            List<Response> responses = _responseManager.GetAll().Where(x => x.RespondentId == respondent.Id).ToList();
            List<Survey> findSurveys = new List<Survey>();
            for (int i = 0; i < responses.Count; i++)
            {
                findSurveys.Add(_surveyManager.GetById(responses[i].SurveyId.ToString()));
            }
            return findSurveys.Count;
        }

    }
}