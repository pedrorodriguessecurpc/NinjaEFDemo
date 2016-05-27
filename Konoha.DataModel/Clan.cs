using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Konoha.DataModel
{
    public class Clan
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Loads the name of the by.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static Clan LoadByName(string name)
        {
            using (var ctx = new KonohaContext())
            {
                return ctx.Clans.Where(c => c.Name == name).SingleOrDefault();
            }
        }
    }
}