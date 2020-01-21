using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DateBaseAccess 
{
    public class MySqlAccess : DataBaseAccess
    {
        public override void BeginTransaction()
        {
            Transaction = Connection.BeginTransaction();
        }
        public override void CloseConnection()
        {
            if (Connection != null)
            {
                Connection.Close();
            }
        }
        public override void CommitTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Commit();
            }
        }
        public override long EjectSQL(string sql)
        {
            MySqlCommand mySqlCommand = new MySqlCommand(sql, (MySqlConnection)Connection);
            return mySqlCommand.ExecuteNonQuery();
        }
        public override bool IsTransaction()
        {
            return (Transaction != null);
        }
        public override void OpenConnection()
        {
            Connection = new MySqlConnection(ConnectionString);
            Connection.Open();
        }
        public override DataTable QuerySQL(string sql)
        {
            DataTable result = new DataTable();
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(sql, (MySqlConnection)Connection);
            mySqlDataAdapter.Fill(result);
            return result;
        }
        public override void RollBackTransaction()
        {
            if (IsTransaction())
            {
                Transaction.Rollback();
            }
        }
    }
}
