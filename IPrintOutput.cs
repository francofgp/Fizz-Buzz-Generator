namespace FizzBuzzAscii
{
    public interface IPrintOutput
    {
        /// <summary>
        /// Method to print the string in Ascii style   
        /// </summary>
        /// <param name="value">The string you want to print</param>
        /// <param name="style">The style according to the spectro.console styling nuget package</param>
        void Print(string value, string style);


        void GoodBye(string message);
        void SimilateWork();
    }
}