using DEPI7ASPMVCExamLibraryManagementSystemTask.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEPI7ASPMVCExamLibraryManagementSystemTask;

namespace DEPI7ASPMVCExamLibraryManagementSystemTask.Contexts
{
    public class DEPI7ASPMVCExamLibraryManagementSystemDbContext:DbContext 
    {

        public DEPI7ASPMVCExamLibraryManagementSystemDbContext()
        {

        }
        public DEPI7ASPMVCExamLibraryManagementSystemDbContext(DbContextOptions<DEPI7ASPMVCExamLibraryManagementSystemDbContext>options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB; Database=BookCRUDMVCApp;Trusted_Connection=true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
