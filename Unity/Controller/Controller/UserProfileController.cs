using CotyWebApp.DAL;
using CotyWebApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.Controller
{
    [EnableCors(origins: "http://localhost:50237", headers: "*", methods: "*")]
    public class UserProfileController : ApiController
    {
        // GET api/<controller>/5
        [Route("api/user/{id}")]
        public JsonResult<List<Entity.UserProfile>> Get(int id)
        {
            List<Entity.UserProfile> results = new List<Entity.UserProfile>();

            UsersDataTable dt = UserDAL.getByID(id);
            foreach (UsersRow row in dt.Rows)
            {
                Entity.UserProfile user = new Entity.UserProfile();
                user.ID = id;
                user.Name = Convert.ToString(row[1]);
                user.Division = Convert.ToString(row[5]);

                results.Add(user);
            }

            return Json<List<Entity.UserProfile>>(results);
        }
    }
}