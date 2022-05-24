using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseAccess
{
    public abstract class DataBaseAccess
    {
        public DbTransaction Transaction { get; set; }
        public String ConnectionString { get; set; }
        public DbConnection Connection { get; set; }
        public abstract void OpenConnection();
        public abstract void CloseConnection();
        public abstract long EjectSQL(string sql);
        public abstract DataTable QuerySQL(string sql);
        public abstract Boolean IsTransaction();
        public abstract void CommitTransaction();
        public abstract void RollBackTransaction();
        public abstract void BeginTransaction();
    }
}
