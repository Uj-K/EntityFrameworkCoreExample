using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
    // Entity Framework(EF)는 .NET 애플리케이션에서 데이터베이스와 상호 작용하는 ORM(Object-Relational Mapping)
    // 프레임워크입니다. 이를 사용하면 데이터베이스 작업을 SQL 쿼리 없이 C# 코드만으로 수행할 수 있습니다.
    // EF Core getting started
    // https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // database = The desired name for the database
            // Server = The server we are connecting to. LocalDB is include with VS
            // Trusted_Connection = Indicate that our windows account should be used
            options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
        }
    }
}
