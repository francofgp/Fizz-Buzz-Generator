using System;
using System.Threading;
using Spectre.Console;

namespace FizzBuzzAscii
{
    class Program
    {
        static void Main(string[] args)
        {

            var printer = new PrinterAscii();

            printer.SimilateWork();
            printer.Print("Welcome", "[mediumpurple2]");
            printer.Print("to the", "[bold lightskyblue1]");
            printer.Print("FizzBuzz Generator!", "[bold darkolivegreen2]");
            Console.WriteLine();

            var fizzBuzz = AnsiConsole.Prompt(
            new TextPrompt<int>("[bold yellow2]From 1 to what number you want to generate the FizzBuzz?[/]")
                .Validate(fb =>
                {
                    return fb switch
                    {
                        <= 0 => ValidationResult.Error("[red]Can't be less or equal to zero[/]"),
                        _ => ValidationResult.Success(),
                    };
                }));


            for (int i = 0; i <= fizzBuzz; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    var style = "[bold yellow]";
                    printer.Print("FizzBuzz", style);
                }
                else if (i % 3 == 0)
                {
                    var style = "[bold green]";

                    printer.Print("Fizz", style);
                }
                else if (i % 5 == 0)
                {
                    var style = "[bold blue]";

                    printer.Print("Buzz", style);
                }
                else
                {
                    var style = "[bold purple]";

                    printer.Print(i.ToString(), style);
                }
                Thread.Sleep(100);

            }
            printer.GoodBye("That's all folks");
        }
    }
}



/* 
Command to generete the single .exe file
dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=false 
/p:SelfContained=false --output "D:\Downloads"

 */