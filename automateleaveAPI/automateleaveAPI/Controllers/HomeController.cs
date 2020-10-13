using automateleaveAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace automateleaveAPI.Controllers
{
    public class HomeController : ApiController
    {
        DatabaseContext db = new DatabaseContext();

        public IEnumerable<LeaveAllocation> GetLeaveAllocationDetails()
        {
            return db.LeaveAllocations.ToList();
        }

        public LeaveAllocation DetailsOneEmployee(int id)
        {
            return db.LeaveAllocations.Find(id);
        }


        [HttpPost]
        public HttpResponseMessage AddDetails(LeaveAllocation model)
        {
            try
            {
                db.LeaveAllocations.Add(model);
                db.SaveChanges();
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.Created);
                return response;
            }
            catch (Exception ex)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.InternalServerError);
                return response;
            }
        }
    }
}
