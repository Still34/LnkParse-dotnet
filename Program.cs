using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using CommandLine;

namespace Lnk.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed((options =>
                {
                    var lnkFile = options.InputFileInfo;
                    var lnk = Lnk.LoadFile(lnkFile.FullName);
                    var jsonSerializerOptions = new JsonSerializerOptions
                    {
                        WriteIndented = true
                    };
                    var serialized = JsonSerializer.Serialize(lnk, jsonSerializerOptions);
                    if (options.OutputFileInfo != null)
                    {
                        File.WriteAllText(options.OutputFileInfo, serialized);
                    }
                    Console.WriteLine(serialized);
                }));
        }


        public class Options
        {
            [Option('i', "input", Required = true, HelpText = "The target to be parsed.")]
            public FileInfo InputFileInfo { get; set; }

            [Option('o', "output", Required = false, HelpText = "Output JSON file path.")]
            public string? OutputFileInfo { get; set; }
        }
    }
}