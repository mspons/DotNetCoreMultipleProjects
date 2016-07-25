using System;
using Application.DataAccess;

namespace Application.Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new DummyDatabase();

            Console.WriteLine($"Hello {db.GetName()}\n");
        }
    }
}
