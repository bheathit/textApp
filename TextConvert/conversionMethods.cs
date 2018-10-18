using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TextConvert
{
    class conversionMethods
    {
        //converts all text to lower case
        static public string ConvertText_LC(string t)
        {
            string lower;
            lower = t.ToLower();
            return lower;
        }



        //TODO convert to all caps method

        // convert to camelCase method
        static public string ConvertText_CC(string t)
        {
            string functionName = t;
            TextInfo txtInfo = new CultureInfo("en-us", false).TextInfo;
            functionName = txtInfo.ToTitleCase(functionName).Replace("_", string.Empty).Replace(" ", string.Empty);
            functionName = $"{functionName.First().ToString().ToLowerInvariant()}{functionName.Substring(1)}";
            return functionName;
        }
        
       

        //TODO 

        //TODO 

        //TODO 

        //TODO 

        //TODO 


    }
}
