using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace RenHeApp
{
    public class Token
    {
		
        public Token()
        {
            LoginUser = "";
            Password = "";
            Role = 1;

            DataConn = null;
            DataConnStr = "";
        }

        public Token(string user, string pwd, Int32 role=0)
        {
            LoginUser = user;
            Password = pwd;
            Role = role;

            DataConn = null;
            DataConnStr = "";
        }

        // 登录用户信息
        private string _LoginUser;
        public string LoginUser
        {
            get { return _LoginUser; }
            set { _LoginUser = value; }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private Int32 _Role;
        public Int32 Role
        {
            get { return _Role; }
            set { _Role = value; }
        }

        // 数据库连接信息
        private MySqlConnection _DataConn;
        public MySqlConnection DataConn
        {
            get { return _DataConn; }
            set { _DataConn = value; }
        }

        private string _DataConnStr;
        public string DataConnStr
        {
            get { return _DataConnStr; }
            set { _DataConnStr = value; }
        }
    }

	struct MenuSet
	{
		public static char remindSel = '0';
		public static char remindAdd = '0';
		public static char remindUpt = '0';
		public static char remindDel = '0';
		public static char custSel = '0';
		public static char custAdd = '0';
		public static char custUpt = '0';
		public static char custDel = '0';
		public static char userSel = '0';
		public static char userAdd = '0';
		public static char userUpt = '0';
		public static char userDel = '0';
		public static char pwdSet = '0';
		public static char logSel = '0';

	}
	 
}
