﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace myservice
{
   public static class Library
    {
        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter sw = null;
            try
            {
            sw = new StreamWriter("F:\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" + ex.Source.ToString().Trim() + ";" + ex.Message.ToString().Trim());
                sw.Flush();
                sw.Close(); 
            }
            catch
            {

            }
        }
        public static void WriteErrorLog(String message)
        {
            StreamWriter sw = null;
            try
            {
              sw = new StreamWriter( "F:\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ":" +message);
                sw.Flush();
                sw.Close(); 
            }
            catch
            {

            }
        }
    }
}
