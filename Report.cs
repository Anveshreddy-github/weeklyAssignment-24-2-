using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_practice_
{
    public interface Printable
    {
        void PrintDetails();
    }

    public interface Serializable
    {
        void SaveToFile(string filepath);
    }
    public class Report : Printable, Serializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Report(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Content: " + Content);
        }

        public void SaveToFile(string filepath)
        {
            System.IO.File.WriteAllText(filepath, Content);
        }
    }
}
