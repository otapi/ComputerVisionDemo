using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerVisionDemo.Models;

namespace ComputerVisionDemo.Helpers
{
    using System;
    using System.Collections.ObjectModel;
    using System.Data.Entity;
    using System.Linq;

    public class Database : DbContext
    {
        // Your context has been configured to use a 'CrawlerProfile' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ComputerVisionDemo.Models.CrawlerProfile' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CrawlerProfile' 
        // connection string in the application configuration file.
        public Database()
            : base("name=ComputerVisionDemo")
        {
        }

        public virtual DbSet<CVSettings> CVSettings { get; set; }
    }
}
