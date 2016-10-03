using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspelhoDeClasse.Dominio
{
    public static class ExtensionsMethods
    {
        public static Dictionary<string, List<Vizinho>> Clone(this Dictionary<string, List<Vizinho>> original)
        {
            Dictionary<string, List<Vizinho>> ret = new Dictionary<string, List<Vizinho>>(original.Count,
                                                                    original.Comparer);
            foreach (KeyValuePair<string, List<Vizinho>> entry in original)
            {
                var clonedList = entry.Value.Select(item => item.Clone()).ToList();
                ret.Add(entry.Key, clonedList);
            }
            return ret;
        }

        public static int IndexOf<T>(this LinkedList<T> list, T item)
        {
            var count = 0;
            for (var node = list.First; node != null; node = node.Next, count++)
            {
                if (item.Equals(node.Value))
                    return count;
            }
            return -1;
        }
    }
}
