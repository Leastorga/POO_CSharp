using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratica02.Extensions
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int count){
            if(thisObj.Length <= count){
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "...";
            }
        }
    }
}