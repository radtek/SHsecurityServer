﻿using System;

namespace KVDDD.Security
{
    public class UserPasswordUtils
    {
        public static string Create(string id, string name, string pwd_raw, int reg_time)
        {
            string raw = id + name + pwd_raw + reg_time;
            return SecurityWeb.Sha256(raw);
        }

        public static bool Compare(int id, string name, string pwd_raw, int reg_time, string compare_to_pwd)
        {
            string raw = id + name + pwd_raw + reg_time;
            return SecurityWeb.Sha256(raw) == compare_to_pwd;
        }

        /// <summary> /// C#中随机生成指定长度的密码/// </summary>
        public static string MakePassword(int pwdLength)
        {     //声明要返回的字符串    
            string tmpstr = "";
            //密码中包含的字符数组    
            string pwdchars = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            //数组索引随机数    
            int iRandNum;
            //随机数生成器    
            Random rnd = new Random();
            for (int i = 0; i < pwdLength; i++)
            {      //Random类的Next方法生成一个指定范围的随机数     
                iRandNum = rnd.Next(pwdchars.Length);
                //tmpstr随机添加一个字符     
                tmpstr += pwdchars[iRandNum];
            }
            return tmpstr;
        }
    }
}