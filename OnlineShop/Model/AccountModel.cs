using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Framework;
namespace Model
{
    public class AccountModel
    {
        private OnlineShipDbContext context = null;
        public AccountModel()
        {
            context = new OnlineShipDbContext();
        }
        public bool Login(string userName, string passWord)
        {
            object[] sqlParams = new sqlParameter[]
                {
                    new SqlParameter("@Username", userName),
                    new Sqlparameter("@Password",passWord),
                };
            var res = context.Database.SqlQuery<bool>("Sp_Account_Login, @Username,@Password",sqlParams).SingleOrDefault();
        }

    }
}
