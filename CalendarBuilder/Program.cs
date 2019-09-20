using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBuilder db = new DataBuilder(); 
            db.StartCount = 2;
            db.EndCount = 32;
            
            Console.WriteLine(db.GetData());
        }
    }

    class DataBuilder
    {
        public int StartCount { get; set; }
        public int EndCount { get; set; }
        public string GetData()
        {
            StringBuilder sb = new StringBuilder();
            for(int i = StartCount; i<=EndCount; i++)
            {
                sb.Append($"{ i,5}");
                if (0 == ((i+StartCount) % 7))
                {
                    sb.AppendLine();
                }
            }
            return sb.ToString();
        }
    }
}
