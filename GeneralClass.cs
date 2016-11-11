using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.OleDb;
using System.Data;
using System.IO;

namespace Coromandel
{

 public class GeneralClass
    {
     
     DataSet ds = new DataSet();
     int status;
     /* This method is used for getting data from  Excel sheets */
        public DataSet ExcelConnectivity(string ExcelQuery,string connStringName)
        {
            try
            {
                /*  Excel sheet connextion*/
                OleDbConnection aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings[connStringName].ConnectionString);
                /* Passing query to retrive data */
                OleDbCommand aCommand = new OleDbCommand(ExcelQuery, aConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(aCommand);
                /* Filling data into dataset */
                da.Fill(ds);
                aConnection.Close();
                /*  Returns dataset to Method used */
                return ds;
            }
            catch (Exception ex)
            {              
                ErrorLoging(ex.ToString());
            }
            return ds;
        }

        public int ExcelConnectivityforUpdate(string ExcelQuery, string connStringName)
        {
            try
            {
                /*  Excel sheet connextion*/
                OleDbConnection aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.ConnectionStrings[connStringName].ConnectionString);
                /* Passing query to retrive data */
                aConnection.Open();
                OleDbCommand aCommand = new OleDbCommand(ExcelQuery, aConnection);
                status = aCommand.ExecuteNonQuery();
                aConnection.Close();
                /*  Returns dataset to Method used */
                return status;
            }
            catch
            {
                return status;
            }
        }
        public DataSet ExcelConnectivityforLOP(string ExcelQuery, string connStringName,string month, string year)
        {
            try
            {
                
                /*  Excel sheet connextion*/
                OleDbConnection aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["CFL_LOP"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                /* Passing query to retrive data */
                OleDbCommand aCommand = new OleDbCommand(ExcelQuery, aConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(aCommand);
                /* Filling data into dataset */
                da.Fill(ds);
                /*  Returns dataset to Method used */
                aConnection.Close();
                return ds;
               
            }
            catch (Exception ex)
            {
                ErrorLoging(ex.ToString());
            }
            return ds;
        }

        public DataSet ExcelConnectivityforOT(string ExcelQuery, string month, string year,string location)
        {
            try
            {
                OleDbConnection aConnection = new OleDbConnection();
                /*  Excel sheet connextion*/
                
                if (location == "Visakhapatnam")
                {
                    /*  Excel sheet connextion*/
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["vizag_OT"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else if (location == "Kakinada")
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["kkd_OT"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else if (location == "Ranipet")
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["Ranipet_OT"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["Fenn_OT"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                /* Passing query to retrive data */
                OleDbCommand aCommand = new OleDbCommand(ExcelQuery, aConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(aCommand);
                /* Filling data into dataset */
                da.Fill(ds);
                /*  Returns dataset to Method used */
                aConnection.Close();
                return ds;

            }
            catch (Exception ex)
            {
                ErrorLoging(ex.ToString());
            }
            return ds;
        }

        public DataSet ExcelConnectivityforPayslip(string ExcelQuery, string connStringName, string month, string year,string location)
        {
            try
            {
                OleDbConnection aConnection = new OleDbConnection();
                if (location == "Visakhapatnam")
                {
                    /*  Excel sheet connextion*/
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["vizag_pay"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else if (location == "Kakinada")
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["kkd_pay"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else if (location == "Ranipet")
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["Ranipet_pay"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                else
                {
                    aConnection = new OleDbConnection(System.Configuration.ConfigurationManager.AppSettings["Fenn_pay"].ToString() + month + year + ".xls;Extended Properties=Excel 8.0");
                }
                /* Passing query to retrive data */
                OleDbCommand aCommand = new OleDbCommand(ExcelQuery, aConnection);
                OleDbDataAdapter da = new OleDbDataAdapter(aCommand);
                /* Filling data into dataset */
                da.Fill(ds);
                /*  Returns dataset to Method used */
                aConnection.Close();
                return ds;
            }
            catch (Exception ex)
            {
                ErrorLoging(ex.ToString());
            }
            return ds;
        }
     //Method for logging Errors
     public void ErrorLoging(string ex)
     {
         // Create a writer and open the file:
         StreamWriter log;
         string strLogText = ex.ToString();
         if (!File.Exists("Log.txt"))
         {
             log = new StreamWriter("Log.txt");
         }
         else
         {
             log = File.AppendText("Log.txt");
         }

         // Write to the file:
         log.WriteLine("\n");
         log.WriteLine(DateTime.Now);
         log.WriteLine(strLogText);
         log.WriteLine();

         // Close the stream:
         log.Close();
     }

    }
}
