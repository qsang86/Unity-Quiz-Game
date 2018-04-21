using CotyWebApp.App_Code.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static CotyWebApp.App_Code.DataSet1;

namespace CotyWebApp.DAL
{
    public class UserDAL
    {

        public static UsersDataTable getByID(int id)
        {
            UsersDataTable results = new UsersDataTable();

            UsersTableAdapter adapter = new UsersTableAdapter();
            adapter.FillBy(results, id);

            return results;
        }
    }
}