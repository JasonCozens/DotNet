using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using CommandLine;
using CommandLine.Text;

namespace ToDoFile
{
    class Options
    {
        [Option('l', "list", HelpText="Name of To Do List")]
        public string List { get; set; }

        [Option('v', null, HelpText = "Print details during execution.")]
        public bool Verbose { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this, (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
            //var help = new HelpText
            //{
            //    Heading = new HeadingInfo("<<app title>>", "<<app version>>"),
            //    Copyright = new CopyrightInfo("<<app author>>", 2014),
            //    AdditionalNewLineAfterOption = true,
            //    AddDashesToOption = true
            //};
            //help.AddPreOptionsLine("<<license details here.>>");
            //help.AddPreOptionsLine("Usage: app -p Someone");
            //help.AddOptions(this);
            //return help;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (CommandLine.Parser.Default.ParseArguments(args, options))
            {
                // consume Options instance properties
                if (options.Verbose)
                {
                    Console.WriteLine(options.List);
                }
                else
                    Console.WriteLine("working ...");
            }
            else
            {
                // Display the default usage information
                // Console.WriteLine(options.GetUsage());
            }

            ReadLine();
        }
    }
}
