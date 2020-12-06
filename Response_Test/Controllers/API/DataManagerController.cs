using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Response_Test.Service;
using Response_Test.Repository;
using Response_Test.Models.ViewModel;

namespace Response_Test.Controllers.API
{
    [RoutePrefix("api/[Controller]/[action]")]
    public class DataManagerController : ApiController
    {
        [HttpPost]
        public void BuildData(dynamic obj)
        {
            List<string> dataPass = new List<string>();
            dataPass.Add(Convert.ToString(obj.Name));
            dataPass.Add(Convert.ToString(obj.Round));
            dataPass.Add(Convert.ToString(obj.one));
            dataPass.Add(Convert.ToString(obj.two));
            dataPass.Add(Convert.ToString(obj.three));
            dataPass.Add(Convert.ToString(obj.four));
            dataPass.Add(Convert.ToString(obj.five));
            dataPass.Add(Convert.ToString(obj.six));
            dataPass.Add(Convert.ToString(obj.seven));
            dataPass.Add(Convert.ToString(obj.eight));
            dataPass.Add(Convert.ToString(obj.nine));
            dataPass.Add(Convert.ToString(obj.ten));
            dataPass.Add(Convert.ToString(obj.eleven));
            dataPass.Add(Convert.ToString(obj.twelve));
            dataPass.Add(Convert.ToString(obj.thirteen));
            dataPass.Add(Convert.ToString(obj.fourteen));
            dataPass.Add(Convert.ToString(obj.fifteen));
            dataPass.Add(Convert.ToString(obj.sixteen));
            dataPass.Add(Convert.ToString(obj.seventeen));
            dataPass.Add(Convert.ToString(obj.eighteen));
            dataPass.Add(Convert.ToString(obj.nineteen));
            dataPass.Add(Convert.ToString(obj.twenty));
            dataPass.Add(Convert.ToString(obj.twentyone));

            ChangeToDataModelService service = new ChangeToDataModelService();
            DataControllerRepository repository = new DataControllerRepository();
            repository.InputData(service.Change(dataPass));
        }
    }
}