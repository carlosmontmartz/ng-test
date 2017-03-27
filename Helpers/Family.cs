using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class Family
{
    internal static string Childs
    {
        get
        {
            var lstChilds = new List<ChildsVM>
            {
                new ChildsVM() { BirthDate = new DateTime(2010,10,22,13,45,00), Name = "Samantha Anahí", Age = 6 },
                new ChildsVM() { BirthDate = new DateTime(2016,10,07,07,59,00), Name = "Karla Lizeth", Age = 0 }
            };

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(lstChilds, Formatting.None, settings);
        }
    }

    internal static string Moms
    {
        get
        {
            var lstChilds = new List<MomsVm>
            {
                new MomsVm() { BirthDate = new DateTime(2010,10,22,13,45,00), Name = "Yuliana Anahí", LastName = "Montaño Gonzalez", Age = 28, IsMarried = true }
            };

            var settings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };
            return JsonConvert.SerializeObject(lstChilds, Formatting.None, settings);
        }
    }
}