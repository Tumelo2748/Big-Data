using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Big_Data
{
    public class DataManager 
    {
        private Data[] data;

        public DataManager()
        {
            data = new Data[0];
        }

        // Reads data from a file and returns an array of Data objects
        public Data[] ReadFromFile()
        {
            
            string filepath = "MOCK_DATA.csv";
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filepath);
            string[] lines = File.ReadAllLines(path);

            // Create Data objects and add to array
            List<Data> dataList = new List<Data>();
            foreach (string line in lines)
            {
                string[] fields = line.Split(',');
                int number = int.Parse(fields[0]);
                string name = fields[1];
                string surname = fields[2];
                string email = fields[3];
                string gender = fields[4];
                string ip = fields[5];

                Data data = new Data(number, name, surname, email, gender, ip);
                dataList.Add(data);
            }

            data = dataList.ToArray();

            // Return array of Data objects
            return data;
        }

        
        public Data[] DetermineDomain(string domain)
        {
            List<Data> dataList = new List<Data>();
            foreach (Data d in data)
            {
                if (d.Email.EndsWith(domain))
                {
                    dataList.Add(d);
                }
            }
            Data[] domainData = dataList.ToArray();

            // Return array of Data objects that end with the specified domain
            return domainData;
        }

        // Gets the counter for a specific string in the data
        public int GetCounter(string domain)
        {
            int count = 0;
            foreach (Data d in data)
            {
                if (d.Email.EndsWith(domain))
                {
                    count++;
                }
            }
            return count;
        }

        // Gets a specific Data object from the data array based on its index
        public Data GetRecord(int index)
        {
            if (index >= 0 && index < data.Length)
            {
                return data[index];
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index specified.");
            }
        }

    }
}
