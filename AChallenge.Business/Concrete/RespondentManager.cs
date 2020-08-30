using AChallenge.Business.Abstract;
using AChallenge.DataAccess.Concrete;
using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AChallenge.Business.Concrete
{
    public class RespondentManager : IRespondentService
    {

        private RespondentRepository _respondentRepository;

        public RespondentManager(RespondentRepository respondentRepository)
        {
            _respondentRepository = respondentRepository;
        }

        public List<Respondent> GetAll()
        {
            return _respondentRepository.GetAll();
        }

        public Respondent GetById(string id)
        {
            return _respondentRepository.GetById(id);
        }

        public Respondent GetByUsername(string username)
        {
            return _respondentRepository.GetAll().FirstOrDefault(x => x.Username == username);
        }

        public bool Add(Respondent model)
        {
            if (model.Username != null || model.Username != "")
            {
                if (this.GetAll().Where(x => x.Username == model.Username).Count() == 0)
                {
                    _respondentRepository.AddModel(model);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool Update(string id, Respondent model)
        {
            _respondentRepository.UpdateModel(id, model);
            return true;
        }

        public bool Delete(string id)
        {
            _respondentRepository.DeleteModel(id);
            return true;
        }

        public bool Login(Respondent model)
        {
            if (this.GetAll().Where(x => x.Username == model.Username && x.Password == model.Password).Count() == 1)
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
