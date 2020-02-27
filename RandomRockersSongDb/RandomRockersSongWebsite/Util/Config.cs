using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RandomRockersSongWebsite.Util
{
    public static class Config
    {
        public static string TryGetEnvironmentVariable(string variableName)
        {
            string value = Environment.GetEnvironmentVariable(variableName);
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception(string.Format($"{variableName} not found"));
            }
            return value;
        }
    }
}