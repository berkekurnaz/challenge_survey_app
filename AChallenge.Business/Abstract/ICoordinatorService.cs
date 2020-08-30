using AChallenge.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AChallenge.Business.Abstract
{
    public interface ICoordinatorService
    {
        List<Coordinator> GetAll();
        Coordinator GetById(string Id);
        Coordinator GetByUsername(string username);
        bool Add(Coordinator model);
        bool Update(string id, Coordinator model);
        bool Delete(string id);
        bool Login(Coordinator model);
    }
}
