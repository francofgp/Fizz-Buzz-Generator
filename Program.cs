using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Spectre.Console;
namespace FizzBuzzAscii
{
    class Program
    {
        static void Main(string[] args)
        {
            if (OperatingSystem.IsWindows())
            {
                try
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer("media/elevatorMusicCompressed.wav");
                    player.PlayLooping();
                }
                catch (System.IO.FileNotFoundException)
                {

                    Console.WriteLine("Audio file not found");
                }

            }



            var isContinue = true;
            var printer = new PrinterAscii(Speed: 100);
            var options = new string[] { "Generate FizzBuzz", "Generate FizzBuzz bar plot", "Visit project site", "Exit" };

            printer.SimilateWork();
            printer.Print("Welcome", "[mediumpurple2]");
            printer.Print("to the", "[bold lightskyblue1]");
            printer.Print("FizzBuzz Generator!", "[bold darkolivegreen2]");
            Console.WriteLine();


            while (isContinue)
            {





                var selectedOption = AnsiConsole.Prompt(
                                   new SelectionPrompt<string>().Title("What do you want [green]to do[/]?")
                                       .PageSize(10).MoreChoicesText("[blue bold](Move up and down to reveal more options)[/]")
                                       .AddChoices(options));





                if (selectedOption == "Generate FizzBuzz bar plot")
                {

                    var fizzBuzz = AnsiConsole.Prompt(
                                  new TextPrompt<int>("[bold yellow2]From 1 to what number you want to generate the FizzBuzz bar plot?[/]")
                                      .Validate(fb =>
                                      {
                                          return fb switch
                                          {
                                              <= 0 => ValidationResult.Error("[red]Can't be less or equal to zero[/]"),
                                              _ => ValidationResult.Success(),
                                          };
                                      }));

                    var fizzBuzzBarData = new Dictionary<string, double>() { { "Numbers", 0 }, { "Fizz", 0 }, { "Buzz", 0 }, { "FizzBuzz", 0 } };
                    printer.Info("Generating plot...");
                    Console.WriteLine();

                    for (int i = 0; i < fizzBuzz; i++)
                    {
                        if (FizzBuzz(i) == "Fizz")
                        {
                            fizzBuzzBarData["Fizz"]++;
                        }
                        else if (FizzBuzz(i) == "Buzz")
                        {
                            fizzBuzzBarData["Buzz"]++;
                        }
                        else if (FizzBuzz(i) == "FizzBuzz")
                        {
                            fizzBuzzBarData["FizzBuzz"]++;
                        }
                        else
                        {
                            fizzBuzzBarData["Numbers"]++;

                        }
                    }

                    var plt = new ScottPlot.Plot(600, 400);
                    plt.Title($"{fizzBuzz} FizzBuzz");
                    plt.AddBar(fizzBuzzBarData.Values.ToArray());
                    plt.XTicks(fizzBuzzBarData.Keys.ToArray());
                    plt.SetAxisLimits(yMin: 0);
                    plt.SaveFig($"{fizzBuzz} FizzBuzz BarPlot.png");
                    printer.Info($"{fizzBuzz} FizzBuzz BarPlot.png has been saved");
                    Console.WriteLine();
                    Console.WriteLine();


                }


                if (selectedOption == "Generate FizzBuzz")
                {
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


                    }
                }


                if (selectedOption == "Visit project site")
                {
                    OpenUrl("https://github.com/francofgp/Fizz-Buzz-Generator");
                }

                if (selectedOption == "Exit")
                {
                    isContinue = false;
                }


            }






            printer.GoodBye("That's all folks");
            if (OperatingSystem.IsWindows())
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                player.Stop();
            }



        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }




    }
}



/* 
Command to generete the single .exe file
dotnet publish -r win-x64 /p:PublishSingleFile=true /p:IncludeNativeLibrariesForSelfExtract=false 
/p:SelfContained=false --output "D:\Downloads"

 */