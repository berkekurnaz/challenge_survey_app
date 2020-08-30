using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Business.Abstract
{
    public interface IRespondentService
    {
        List<Respondent> GetAll();
        Respondent GetById(string Id);
        Respondent GetByUsername(string username);
        bool Add(Respondent model);
        bool Update(string id, Respondent model);
        bool Delete(string id);
        bool Login(Respondent model);
    }
}
