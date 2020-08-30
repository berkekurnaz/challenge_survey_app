using AChallenge.Models.Concrete;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Business.Abstract
{
    public interface IResponseService
    {
        List<Response> GetAll();
        List<Response> GetAllBySurveyId(ObjectId SurveyId);
        Response GetById(string Id);
        Response GetBySurveyAndRespondent(ObjectId surveyId, ObjectId respondentId);
        bool Add(Response model);
        bool Update(string id, Response model);
        bool Delete(string id);
        bool CheckRespondentJoinThisSurvey(ObjectId surveyId, ObjectId respondentId);
    }
}
