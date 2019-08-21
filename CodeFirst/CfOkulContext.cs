namespace CodeFirst
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CfOkulContext : DbContext
    {

        public CfOkulContext()
            : base("name=CfOkulContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }

    }


}