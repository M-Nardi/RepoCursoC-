using System.Collections.Generic;
using System.Text;

namespace System
{
    static class CutExtension
    {
        public static string Cut(this string thisObj, int positions)
        {
            if (thisObj.Length <= positions)
            {
                return thisObj;
            }
            else
            {
                string aux = "";

                for (int i = 0; i < positions; i++)
                {
                    aux += thisObj[i];
                }   

                return aux + "...";

                //ou de forma mais simples -> return thisObj.Substring(0, position) + "...";
            }

        }


    }
}
