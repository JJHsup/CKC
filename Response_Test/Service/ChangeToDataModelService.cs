using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Response_Test.Models;

namespace Response_Test.Service
{
    public class ChangeToDataModelService
    {
        public DataDetailModel Change(List<string> model)
        {
            List<int> changemodel = new List<int>();
            for (int i = 2; i < 22; i++)
            {
                long dataone = long.Parse(model[i]);
                long datatwo = long.Parse(model[i + 1]);
                int item = (int)(datatwo - dataone);
                changemodel.Add(item);
            };
            DataDetailModel result = new DataDetailModel
            {
                Name = model[0],
                Round = int.Parse(model[1]),
                Item_One = changemodel[0],
                Item_Two = changemodel[1],
                Item_Three = changemodel[2],
                Item_Four = changemodel[3],
                Item_Five = changemodel[4],
                Item_Six = changemodel[5],
                Item_Seven = changemodel[6],
                Item_Eight = changemodel[7],
                Item_Nine = changemodel[8],
                Item_Ten = changemodel[9],
                Item_Eleven = changemodel[10],
                Item_Twelve = changemodel[11],
                Item_Thirteen = changemodel[12],
                Item_Fourteen = changemodel[13],
                Item_Fifteen = changemodel[14],
                Item_Sixteen = changemodel[15],
                Item_Seventeen = changemodel[16],
                Item_Eighteen = changemodel[17],
                Item_Nineteen = changemodel[18],
                Item_Twenty = changemodel[19]
            };
            return result;
        }
    }
}