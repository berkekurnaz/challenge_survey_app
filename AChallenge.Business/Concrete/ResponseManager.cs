using AChallenge.Business.Abstract;
using AChallenge.DataAccess.Concrete;
using AChallenge.Models.Concrete;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AChallenge.Business.Concrete
{
    public class ResponseManager : IResponseService
    {

        private ResponseRepository _responseRepository;

        public ResponseManager(ResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        public List<Response> GetAll()
        {
            return _responseRepository.GetAll();
        }

        public List<Response> GetAllBySurveyId(ObjectId SurveyId)
        {
            return _responseRepository.GetAll().Where(x =>x.SurveyId == SurveyId).ToList();
        }

        public Response GetById(string id)
        {
            return _responseRepository.GetById(id);
        }

        public Response GetBySurveyAndRespondent(ObjectId surveyId, ObjectId respondentId)
        {
            return this.GetAll().FirstOrDefault(x => x.SurveyId == surveyId && x.RespondentId == respondentId);
        }

        public bool Add(Response model)
        {
            _responseRepository.AddModel(model);
            return true;
        }

        public bool Update(string id, Response model)
        {
            _responseRepository.UpdateModel(id, model);
            return true;
        }

        public bool Delete(string id)
        {
            _responseRepository.DeleteModel(id);
            return true;
        }

        public bool CheckRespondentJoinThisSurvey(ObjectId surveyId, ObjectId respondentId)
        {
            if (this.GetAll().Where(x => x.SurveyId == surveyId && x.RespondentId == respondentId).Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
