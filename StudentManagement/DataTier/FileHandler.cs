using Newtonsoft.Json;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using System.Collections;
using System.Reflection;
using System.Text.RegularExpressions;
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class FileHandler
    {
        public string Path { get; set; }

        public FileHandler(string path, string contents)
        {
            Path = path;
            Write(contents);
        }
        public FileHandler(string path)
        {
            Path = path;
        }
        public FileHandler()
        {
            Path = "users.txt";
        }

        //read file
        public string Read()
        {
            try
            {
                using StreamReader sr = new(Path);
                return sr.ReadToEnd();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
            return string.Empty;
        }

        //write file
        public void Write(string text, bool append = false)
        {
            try
            {
                using StreamWriter sw = new(Path, append);
                sw.WriteLine(text);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }

        public List<String> ReadList()
        {

            try
            {
                using StreamReader sr = new(Path);
                List<String> list = new List<String>();
                String line = sr.ReadLine();

                while (line != null)
                {
                    list.Add(line);
                    line = sr.ReadLine();
                }

                return list;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
            return new List<string>();
        }
    
    }
}