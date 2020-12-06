using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Response_Test.Data;
using Response_Test.Models;

namespace Response_Test.Repository
{
    public class DataControllerRepository
    {
        private readonly Response_TestContext db = new Response_TestContext();

        public void InputData(DataDetailModel data)
        {
            //bool a = db.DataDetailModels.Where(x => x.Name == data.Name).Any();
            //bool b = db.DataDetailModels.Where(x => x.Name == data.Name).FirstOrDefault().Round == data.Round;
            if (db.DataDetailModels.Where(x => x.Name == data.Name).Any())
            {
                if (db.DataDetailModels.Where(x => x.Name == data.Name).FirstOrDefault().Round == data.Round)
                {
                }
                else
                {
                    DataDetailModel datadetail = new DataDetailModel()
                    {
                        Name = data.Name,
                        Round = data.Round,
                        Item_One = data.Item_One,
                        Item_Two = data.Item_Two,
                        Item_Three = data.Item_Three,
                        Item_Four = data.Item_Four,
                        Item_Five = data.Item_Five,
                        Item_Six = data.Item_Six,
                        Item_Seven = data.Item_Seven,
                        Item_Eight = data.Item_Eight,
                        Item_Nine = data.Item_Nine,
                        Item_Ten = data.Item_Ten,
                        Item_Eleven = data.Item_Eleven,
                        Item_Twelve = data.Item_Twelve,
                        Item_Thirteen = data.Item_Thirteen,
                        Item_Fourteen = data.Item_Fourteen,
                        Item_Fifteen = data.Item_Fifteen,
                        Item_Sixteen = data.Item_Sixteen,
                        Item_Seventeen = data.Item_Seventeen,
                        Item_Eighteen = data.Item_Eighteen,
                        Item_Nineteen = data.Item_Nineteen,
                        Item_Twenty = data.Item_Twenty
                    };
                    db.DataDetailModels.Add(datadetail);
                    db.SaveChanges();
                }
            }
            else
            {
                DataDetailModel datadetail = new DataDetailModel()
                {
                    Name = data.Name,
                    Round = data.Round,
                    Item_One = data.Item_One,
                    Item_Two = data.Item_Two,
                    Item_Three = data.Item_Three,
                    Item_Four = data.Item_Four,
                    Item_Five = data.Item_Five,
                    Item_Six = data.Item_Six,
                    Item_Seven = data.Item_Seven,
                    Item_Eight = data.Item_Eight,
                    Item_Nine = data.Item_Nine,
                    Item_Ten = data.Item_Ten,
                    Item_Eleven = data.Item_Eleven,
                    Item_Twelve = data.Item_Twelve,
                    Item_Thirteen = data.Item_Thirteen,
                    Item_Fourteen = data.Item_Fourteen,
                    Item_Fifteen = data.Item_Fifteen,
                    Item_Sixteen = data.Item_Sixteen,
                    Item_Seventeen = data.Item_Seventeen,
                    Item_Eighteen = data.Item_Eighteen,
                    Item_Nineteen = data.Item_Nineteen,
                    Item_Twenty = data.Item_Twenty
                };
                db.DataDetailModels.Add(datadetail);
                db.SaveChanges();
            }
        }
    }
}