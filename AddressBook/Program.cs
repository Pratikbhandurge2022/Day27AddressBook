using System;
namespace AddressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            // #region UC14
            ReadWriteCSV.CsvReadWrite();
            //#endregion

            #region UC15
            ReadWriteJSON.csvToJSON();
            #endregion
        }
    }
}