using System;
using System.Collections.Generic;
using System.Text;
using System.Dynamic;
using CsvHelper;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Globalization;

namespace libVelociraptor
{
    public class OutputFormatter
    {
        private readonly JArray _jArray;

        public OutputFormatter(JArray jArray)
        {
            _jArray = jArray;
        }

        public StringWriter Output()
        {
            using (var writer = new StringWriter())
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                foreach (var obj in _jArray)
                {
                    foreach (JProperty prop in obj)
                    {
                        csv.WriteField(prop.Name.ToString());
                    }
                    csv.NextRecord();
                }

                foreach (var obj in _jArray)
                {
                    foreach (JProperty prop in obj)
                    {
                        var andy = prop.Value.ToString();
                        csv.WriteField(prop.Value.ToString());
                    }
                    csv.NextRecord();
                }
                writer.Flush();
                return writer;
            }
        }
    }

}