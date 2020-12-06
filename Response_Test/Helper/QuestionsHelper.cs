using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Response_Test.Helper
{
    public class QuestionsHelper
    {
        public List<string> Result(string category)
        {
            List<string> result = new List<string>();
            if (category == "Nature")
            {
                result.AddRange(Nature());
            }
            else if (category == "Artificial")
            {
                result.AddRange(Artificial());
            }
            else
            {
                result.AddRange(Color());
            }
            return result;
        }

        public List<string> ResultAll()
        {
            List<string> result = new List<string>();
            result.AddRange(Nature());
            result.AddRange(Artificial());
            result.AddRange(Color());
            return result;
        }

        private List<string> Nature()
        {
            List<string> nature = new List<string>
            {
                "松樹" , "榕樹" , "向日葵" , "太陽" , "月亮" , "海洋" , "薰衣草"
            };
            return nature;
        }

        private void Personal()
        {
        }

        private List<string> Artificial()
        {
            List<string> item = new List<string>
            {
                "汽車" , "房子" , "機車" , "政府" , "輪船" , "風車" , "電視"
            };
            return item;
        }

        private List<string> Color()
        {
            List<string> color = new List<string>
            {
                "小白" , "阿明" , "老王" , "三姑" , "阿姨" , "小新" , "野原新之助"
            };
            return color;
        }
    }
}