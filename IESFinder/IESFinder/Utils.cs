using System.Collections.Generic;
using System.Text;

namespace IESFinder
{
    public static class Utils
    {
        public static List<string> PropertyList(this object obj)
        {
            var props = obj.GetType().GetProperties();
            List<string> listStrings = new List<string>();

            foreach (var p in props)
            {
                listStrings.Add(p.Name);
            }

            return listStrings;
        }
    }
}
