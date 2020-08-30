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
    public class SurveyManager : ISurveyService
    {

        private SurveyRepository _surveyRepository;

        public SurveyManager(SurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        public List<Survey> GetAll()
        {
            return _surveyRepository.GetAll();
        }

        public List<Survey> GetAllOpenSurveys()
        {
            return _surveyRepository.GetAll().Where(x => x.IsVisible == "true").ToList();
        }

        public List<Survey> GetAllByCoordinatorId(ObjectId coordinatorId)
        {
            return _surveyRepository.GetAll().Where(x => x.CoordinatorId == coordinatorId).ToList();
        }

        public Survey GetById(string id)
        {
            return _surveyRepository.GetById(id);
        }

        public bool Add(Survey model)
        {
            _surveyRepository.AddModel(model);
            return true;
        }

        public bool Update(string id, Survey model)
        {
            _surveyRepository.UpdateModel(id, model);
            return true;
        }

        public bool Delete(string id)
        {
            _surveyRepository.DeleteModel(id);
            return true;
        }

    }
}
