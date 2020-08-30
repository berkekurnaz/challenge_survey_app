using AChallenge.Business.Abstract;
using AChallenge.DataAccess.Concrete;
using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AChallenge.Business.Concrete
{
    public class CoordinatorManager : ICoordinatorService
    {

        private CoordinatorRepository _coordinatorRepository;

        public CoordinatorManager(CoordinatorRepository coordinatorRepository)
        {
            _coordinatorRepository = coordinatorRepository;
        }

        public List<Coordinator> GetAll()
        {
            return _coordinatorRepository.GetAll();
        }

        public Coordinator GetById(string id)
        {
            return _coordinatorRepository.GetById(id);
        }

        public Coordinator GetByUsername(string username)
        {
            return _coordinatorRepository.GetAll().FirstOrDefault(x => x.Username == username);
        }

        public bool Add(Coordinator model)
        {
            if (model.Username != null || model.Username != "")
            {
                if (this.GetAll().Where(x => x.Username == model.Username).Count() == 0)
                {
                    _coordinatorRepository.AddModel(model);
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

        public bool Update(string id, Coordinator model)
        {
            _coordinatorRepository.UpdateModel(id, model);
            return true;
        }

        public bool Delete(string id)
        {
            _coordinatorRepository.DeleteModel(id);
            return true;
        }

        public bool Login(Coordinator model)
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
