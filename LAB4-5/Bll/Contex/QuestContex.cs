using System;
using System.Data.Entity;
using System.Linq;

namespace LAB4_5
{
    public class QuestContex : DbContext
    {
        // Your context has been configured to use a 'QuestContex' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LAB4_5.QuestContex' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuestContex' 
        // connection string in the application configuration file.
        public QuestContex()
            : base("name=QuestContex")
        {
        }

      
        public virtual DbSet<MemberInfo> MemberInfoModel { get; set; }
        public virtual DbSet<QuestInfo> QuestInfoModel { get; set; }
    }


}