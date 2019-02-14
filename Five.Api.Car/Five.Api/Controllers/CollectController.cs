using Five.Car.IRepository;
using Five.Car.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Five.Api.Controllers
{
    public class CollectController : ApiController
    {
        public ICollect Collect { get; set; }
        public ICollectionRepository Collection { get; set; }

        [HttpGet]
        public List<Collection> ShowCollection(string Usersid)
        {
            var collects = Collect.ShowCollection(Usersid);
            return collects;
        }

        [HttpGet]
        public int UpdateCarCollection(int id, int IsCollection)
        {
            var i = Collection.UpdateCarCollection(id, IsCollection);
            return i;
        }
    }
}
