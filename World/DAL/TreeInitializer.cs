using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using World.Models;

namespace World.DAL
{
    public class TreeInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<TreeContext>
    {
        protected override void Seed(TreeContext context)
        {
            var trees = new List<Tree>
            {
                new Tree{Name="Root", Parent=null}
            };
            trees.ForEach(t => context.Trees.Add(t));
            context.SaveChanges();
            foreach (Tree t in trees)
            {
                t.Parent = t;
            }
            context.SaveChanges();
        }
    }
}