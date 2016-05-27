using System;
using System.Linq;
using Konoha.DataModel;

namespace Konoha.Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            var uzu = Konoha.DataModel.Clan.LoadByName("Uzumaki");
        }
    }
}
