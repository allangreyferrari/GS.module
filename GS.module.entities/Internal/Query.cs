namespace GS.module.entities.Internal
{
    using System;
    using System.Collections.Generic;
    public class Query
    {
        public List<object> Input { get; set; }
        public string Method { get; set; }
        public int Timeout { get; set; }
        public string Connection { get; set; }
        public string Password { get; set; }
        public Query() { }
        public Query(string method, List<object> input)
        {
            Method = method;
            Input = input;
        }
        public string GetFormatType(object value)
        {
            string result = "";
            switch (value.GetType().FullName.ToString())
            {
                case "System.String":
                    result = "\"" + value.ToString() + "\"";
                    break;
                case "System.DateTime":
                    result = "\"" + @"\/Date(" + new TimeSpan(Convert.ToDateTime(value).ToUniversalTime().Ticks - new DateTime(1970, 1, 1).Ticks).TotalMilliseconds + @")\/" + "\"";
                    break;
                case "System.Double":
                    result = value.ToString();
                    break;
                case "System.Decimal":
                    result = value.ToString();
                    break;
                case "System.Int64":
                    result = value.ToString();
                    break;
                case "System.Int32":
                    result = value.ToString();
                    break;
                default:
                    result = "\"" + value.ToString() + "\"";
                    break;
            }
            return result;
        }

        ~Query() { }
    }
}
