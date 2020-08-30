using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Business.Abstract
{
    public interface ISurveyService
    {
        List<Survey> GetAll();
        Survey GetById(string Id);
        bool Add(Survey model);
        bool Update(string id, Survey model);
        bool Delete(string id);
    }
}
