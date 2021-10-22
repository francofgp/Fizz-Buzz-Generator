using System;
using System.Threading;
using Figgle;
using Spectre.Console;

namespace FizzBuzzAscii
{
    public class PrinterAscii : IPrintOutput
    {

        public int Speed { get; set; } = 100;

        public PrinterAscii(int Speed)
        {
            this.Speed = Speed;
        }


        public void Print(string value, string style)
        {
            AnsiConsole.Markup($"{style}{FiggleFonts.Standard.Render(value)}[/]");
            Thread.Sleep(Speed);
        }

        public void Info(string value)
        {
            AnsiConsole.Markup($"[underline deepskyblue1]{value}[/] ");
            Thread.Sleep(Speed);
        }




        public void GoodBye(string message)
        {
            var panel = new Panel($"[bold lime]{FiggleFonts.Standard.Render(message)}[/]");
            panel.Border = BoxBorder.Double;
            AnsiConsole.Render(panel);
            AnsiConsole.Markup("[red]Press ENTER to exit[/]");
            Console.ReadLine();
        }

        public void SimilateWork()
        {

            AnsiConsole.Status()
            .Spinner(Spinner.Known.Aesthetic)
            .SpinnerStyle(Style.Parse("green bold"))
            .Start("Loading...", ctx =>
            {
                Thread.Sleep(1000);

                AnsiConsole.MarkupLine("Doing some work...");
                Thread.Sleep(1000);

                AnsiConsole.MarkupLine("Loading FizzBuzz algorithm...");
                Thread.Sleep(2000);

                AnsiConsole.MarkupLine("Loading Objets...");
                Thread.Sleep(2000);

                AnsiConsole.MarkupLine("Loading Styles...");
                Thread.Sleep(2000);
            });

        }
    }
}