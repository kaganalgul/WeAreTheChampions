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
            if (!context.Players.Any())
            {
                var oyuncu1 = new Player()
                {
                    PlayerName = "Kağan"
                };
                var oyuncu2 = new Player()
                {
                    PlayerName = "Büşra"
                };
                var oyuncu3 = new Player()
                {
                    PlayerName = "Melis"
                };
                var oyuncu4 = new Player()
                {
                    PlayerName = "Emine"
                };
                var oyuncu5 = new Player()
                {
                    PlayerName = "Mehmet"
                };

                context.Players.Add(oyuncu1);
                context.Players.Add(oyuncu2);
                context.Players.Add(oyuncu3);
                context.Players.Add(oyuncu4);
                context.Players.Add(oyuncu5);
            }

            if (!context.Teams.Any())
            {
                var takım1 = new Team()
                {
                    TeamName = "Lorem"
                };
                var takım2 = new Team()
                {
                    TeamName = "Ipsum"
                };
                var takım3 = new Team()
                {
                    TeamName = "Dolor"
                };
                var takım4 = new Team()
                {
                    TeamName = "Sitamet"
                };
                var takım5 = new Team()
                {
                    TeamName = "Consectetur"
                };

                context.Teams.Add(takım1);
                context.Teams.Add(takım2);
                context.Teams.Add(takım3);
                context.Teams.Add(takım4);
                context.Teams.Add(takım5);
            }

            if (!context.Colors.Any())
            {
                var renk1 = new Color()
                {
                    ColorName = "Kırmızı",
                    Red = 255,
                    Green = 0,
                    Blue = 0
                };

                var renk2 = new Color()
                {
                    ColorName = "Yeşil",
                    Red = 0,
                    Green = 255,
                    Blue = 0
                };
                var renk3 = new Color()
                {
                    ColorName = "Mavi",
                    Red = 0,
                    Green = 0,
                    Blue = 255
                };
                var renk4 = new Color()
                {
                    ColorName = "Siyah",
                    Red = 0,
                    Green = 0,
                    Blue = 0
                };
                var renk5 = new Color()
                {
                    ColorName = "Beyaz",
                    Red = 255,
                    Green = 255,
                    Blue = 255
                };

                context.Colors.Add(renk1);
                context.Colors.Add(renk2);
                context.Colors.Add(renk3);
                context.Colors.Add(renk4);
                context.Colors.Add(renk5);
            }
        }
    }
}
