using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
namespace Bank_DataAccess
{
    public class clsTransferLogData
    {
        public static bool AddNew(DateTime dateTime, string SourceAccount, string DestinationAccount, float Amount, float SourceBalance,
                                   float DestinationBalance, string UserName)
        {
            int RowsAffected = 0;
            try
            {
                
                using (SqlConnection conn = new SqlConnection(clsDataSettingAccess.ConnactionString))
                {
                    conn.Open();

                    string query = @"INSERT INTO [dbo].[TransferLog]
           ([DateTime]
           ,[SourceAccount]
           ,[DestinationAccount]
           ,[Amount]
           ,[SourceBalance]
           ,[DestinationBalance]
           ,[UserName])
     VALUES
             (@DateTime,@SourceAccount,@DestinationAccount,@Amount,@SourceBalance,@DestinationBalance,@UserName)
           ";

                    using (SqlCommand cmd = new SqlCommand(query,conn))
                    {
                        
                        cmd.Parameters.AddWithValue("@DateTime", dateTime);
                        cmd.Parameters.AddWithValue("@SourceAccount", SourceAccount);
                        cmd.Parameters.AddWithValue("@DestinationAccount", DestinationAccount);
                        cmd.Parameters.AddWithValue("@Amount", Amount);
                        cmd.Parameters.AddWithValue("@SourceBalance", SourceBalance);
                        cmd.Parameters.AddWithValue("@DestinationBalance", DestinationBalance);
                        cmd.Parameters.AddWithValue("@UserName", UserName);

                         RowsAffected = cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                clsEventLog.LogExseptionsToLogerViewr("This Add New TransferLog", EventLogEntryType.Error);
            }
            return (RowsAffected > 0);
        }
        
        public static DataTable GetAllTransferLog()
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataSettingAccess.ConnactionString))
                {
                    connection.Open();
                    string Query = @"select * from TransferLog";

                    using (SqlCommand command = new SqlCommand(Query,connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dataTable.Load(reader);
                            }

                        }
                    }


                }


            }
            catch (Exception ex)
            {
               clsEventLog.LogExseptionsToLogerViewr("Get All TransferLog", EventLogEntryType.Error);            
            }
            return dataTable;
        }
    }
}
