/*
 * Install-package fastJSON
 */
using fastJSON;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fastJsonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // {"Name":"Hello", "Age":28,"data":[{"id":100},{"id":101}]}
            var jsonStr = "{\"Name\":\"Hello\", \"Age\":28,\"data\":[{\"key\":100},{\"key\":101}]}";

            Dictionary<string, object> obj = JSON.Parse(jsonStr) as Dictionary<string, object>; // 将json字符串转换为json对象
            // 读取数组数据
            var arr = obj["data"] as List<object>;
            // 读取数组元素
            var item = arr[0] as Dictionary<string, object>;
            // 读取元素中的某个键值
            var id = Convert.ToInt32(item["key"]);
            // 向数组中添加新元素
            var newDict = new Dictionary<string, object>();
            newDict.Add("key", 102);
            arr.Add(newDict);
            // 访问新数组元素
            var newItem = arr[2] as Dictionary<string, object>;
        }
    }
}
