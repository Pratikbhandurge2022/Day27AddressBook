using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AddressBook
{
    class Program
    {
        Address address1 = new Address("pratik", "Bhandurge", "wai", "Pune",
            "MH", "45986", 78945612, "pratik@gmail.com");

        static void Main(string[] args)
        {
            Program.FileExists();
            Program.ReadAllLines();
            Program.ReadAllText();
            // Program.DeleteFile();
            Program.CopyFile();
        }
        public static void FileExists()
        {
            String path = @"D:\BridgeLabz\Day27\AddressBook\Contact.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
        }
        public static void ReadAllLines()
        {
            String path = @"D:\BridgeLabz\Day27\AddressBook\Contact.txt";
            String[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
        }
        public static void ReadAllText()
        {
            String path = @"D:\BridgeLabz\Day27\AddressBook\Contact.txt";
            String lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
        public static void DeleteFile()
        {
            String path = @"D:\BridgeLabz\Day27\AddressBook\Contact.txt";
            File.Delete(path);
            if (File.Exists(path))
            {
                Console.WriteLine("File not deleted");
            }
            else
            {
                Console.WriteLine("File deleted");
            }
        }
        public static void CopyFile()
        {
            String path = @"D:\BridgeLabz\Day27\AddressBook\TextFile1.txt";
            String copyPath = @"D:\BridgeLabz\Day27\AddressBook\Contact.txt";

            File.Copy(path, copyPath);
            Console.ReadKey();
        }

    }
}



