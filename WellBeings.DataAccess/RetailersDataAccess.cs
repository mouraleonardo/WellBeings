﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WellBeings.DataAccess.Models;

namespace WellBeings.Data
{
    public class RetailersDataAccess
    {
        public List<Retailer> GetRetailers()
        {
            var json = "{\"retailers\":[{\"id\":1,\"name\":\"Best Blackberry Ontario\",\"phone\":\"476-989-6598\",\"address\":\"33 Victoria St Ste 150, Toronto ON M5C 2A1\"},{\"id\":2,\"name\":\"Yami Yami Blackberry\",\"phone\":\"489-529-6978\",\"address\":\"4384 Bathurst St, Toronto ON M3H 3R6\"},{\"id\":3,\"name\":\"Good Berry\",\"phone\":\"908-897-3165\",\"address\":\"25 Holland St E, Bradford ON L3Z 2A3\"},{\"id\":4,\"name\":\"Blackberry Uat\",\"phone\":\"986-312-6567\",\"address\":\"Bethune St, Thunder Bay ON P7C 1X6\"},{\"id\":5,\"name\":\"Power Berries\",\"phone\":\"987-310-1238\",\"address\":\"700 University Ave, Toronto ON M5G 1X6\"},{\"id\":6,\"name\":\"Ted Blackberry\",\"phone\":\"501-924-6497\",\"address\":\"250 Hudson Cres, Wallaceburg ON N8A 5B1\"}]}";
            var myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

            return myDeserializedClass.Retailers;
        }
    }
}