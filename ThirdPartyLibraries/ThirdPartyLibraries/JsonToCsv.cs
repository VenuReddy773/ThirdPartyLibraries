using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace ThirdPartyLibraries
{
    class JsonToCsv
    {
        public void ImplementJsonToCsv()
        {
            string importFilePath = @"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ThirdPartyLibrary\ThirdPartyLibraries\ThirdPartyLibraries\ThirdPartyLibraries\Utility\export.json";
            string exportFilePath = @"C:\Users\Venu Gopal Reddy\Bridgelabz\c#\.net\ThirdPartyLibrary\ThirdPartyLibraries\ThirdPartyLibraries\ThirdPartyLibraries\Utility\JsonData.csv";
            IList<AddressData> addressData = JsonConvert.DeserializeObject<IList<AddressData>>(File.ReadAllText(importFilePath));
            Console.WriteLine("Reading From Json File And Write To Csv File\n");
            using (var writer = new StreamWriter(exportFilePath))
            using (var csvExport = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csvExport.WriteRecords(addressData);
            }
        }
    }
}
