using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using World.Models;
using System.Collections.Generic;

namespace World.Migrations
{

    internal sealed class Configuration : DbMigrationsConfiguration<World.DAL.TreeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(World.DAL.TreeContext context)
        {
            var trees = new List<Tree>
            {
                new Tree{Name = "Europe", Parent = null },
                new Tree{Name = "Asia", Parent = null },
                new Tree{Name = "North America", Parent = null},
                new Tree{Name = "South America", Parent = null },
                new Tree{Name = "Australia", Parent = null },
                new Tree{Name = "Africa", Parent = null },
            };
            trees.ForEach(t => context.Trees.AddOrUpdate(t));
            context.SaveChanges();
            foreach (Tree t in trees)
            {
                t.Parent = t;
            }
            context.SaveChanges();
        }
    }
}
