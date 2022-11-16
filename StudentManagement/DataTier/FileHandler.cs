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
            Path = "../Resources/users.txt";
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
                sw.Write(text);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Error: " + e.Message);
            }
        }

        public (string field, string value)[] GetFieldValues(object obj)
        {
            IList<PropertyInfo> properties = new List<PropertyInfo>(obj.GetType().GetProperties());

            var fieldValues = new List<(string field, string value)>();

            foreach (var prop in properties)
            {
                object value = prop.GetValue(obj, null);

                if (value != null)
                    fieldValues.Add((prop.Name, value.ToString()));
                else
                    fieldValues.Add((prop.Name, string.Empty));
            }
            return fieldValues.ToArray();
        }
        
        //actually property values, who cares?
        public void PrintFieldValuesRecursive(object obj, int indent = 0)
        {
            if (obj == null) return;
            string spacing = new string(' ', indent);
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();           
            
            foreach (var prop in properties)
            {
                object value = prop.GetValue(obj, null);
                IList elems = value as IList;
                if (elems != null)//handle collection
                {
                    foreach (var item in elems)
                    {
                        PrintFieldValuesRecursive(item, indent + 3);
                        Console.WriteLine();
                    }
                }
                else
                {                  
                    if (prop.PropertyType.Assembly == type.Assembly)//for nested types
                    {
                        //first print the type name
                        Console.WriteLine($"{spacing}{prop.Name}:");
                        //go through the type
                        PrintFieldValuesRecursive(value, indent + 2);
                    }
                    else
                    {
                        if (prop.DeclaringType.Namespace != "System" && prop.DeclaringType.Module.ScopeName != "CommonLanguageRuntimeLibrary")                                            
                        {
                            Console.WriteLine($"{spacing}{prop.Name}: {value}");
                        }                
                    }
                }
            }
        }

        
        /// <summary>
        /// Only for primitive non iterable types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="delimiter"></param>
        /// <returns></returns>
        public string ToTextSingle<T>(T obj, string delimiter = ",", bool header = false)
        {

            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.PrepareHeaderForMatch = args => args.Header.ToLower();

            TextWriter t = new StringWriter();

            using (var csv = new CsvWriter(t, config))
            {
                if (header)
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();
                }
                csv.WriteRecord<T>(obj);
            }
            string s = t.ToString();
            t.Dispose();

            return s.Replace(",", delimiter);
        }
        /// <summary>
        /// Only for primitive non iterable types
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="objs"></param>
        /// <param name="delimiter"></param>
        /// <param name="newline"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public string ToTextCollection<T>(T[] objs, string delimiter = ",", string newline = "\n", bool header = false)
        {
            CsvConfiguration config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.PrepareHeaderForMatch = args => args.Header.ToLower();

            TextWriter t = new StringWriter();
            //t.NewLine = newline;

            using (var csv = new CsvWriter(t, config))
            {
                if (header)
                {
                    csv.WriteHeader<T>();
                    csv.NextRecord();
                }

                for (int i = 0; i < objs.Length; i++)
                {
                    csv.WriteRecord<T>(objs[i]);
                    //if (i < objs.Length - 1)
                    csv.NextRecord();
                }
            }
            string s = t.ToString();
            t.Dispose();

            return s.Replace("\r\n", newline).Replace(",", delimiter);
        }

        
        public T FromTextSingle<T>(string s, bool header = false)
        {
            return FromTextCollection<T>(s, header)[0];
        }
        public T[] FromTextCollection<T>(string s, bool header = false)
        {
            CsvConfiguration config = new(CultureInfo.InvariantCulture);

            if (!header)
            {
                config.HasHeaderRecord = false;
            }
            config.MissingFieldFound = null;
            config.PrepareHeaderForMatch = args => args.Header.ToLower();

            using var reader = new StringReader(s);

            using var csv = new CsvReader(reader, config);

            return csv.GetRecords<T>().ToArray();
        }
       
      
        //json serialize to file
        public void SerializeToFile(object obj)
        {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
            Write(json);
        }
        public void SerializeToFile<T>(T obj)
        {
            SerializeToFile((object)obj);
        }
        //json deserialize from file
        public T DeserializeFromFile<T>()
        {
            string json = Read();
            return JsonConvert.DeserializeObject<T>(json);
        }
        //json serialize
        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }
        //json deserialize
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}