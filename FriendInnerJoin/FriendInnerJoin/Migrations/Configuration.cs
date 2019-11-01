namespace FriendInnerJoin.Migrations
{
    using FriendInnerJoin.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FriendInnerJoin.Models.DataBaseContext>
    {
		DataBaseContext db = new DataBaseContext();

		public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FriendInnerJoin.Models.DataBaseContext context)
        {
          
        }
    }
}
