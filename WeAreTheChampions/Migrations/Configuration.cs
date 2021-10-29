namespace WeAreTheChampions.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAreTheChampions.Data;
    using WeAreTheChampions.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAreTheChampions.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeAreTheChampions.Data.DatabaseContext context)
        {

        }
    }
}
