using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using WellBeings.DataAccess.Models;

namespace WellBeings.Data
{
    public class ProductsDataAccess
    {
        public List<Product> GetProducts()
        {
            var json = "{\"products\":[{\"id\":\"0\",\"name\":\"Simply fruit\u00ae seedless black raspberry spreadable fruit\",\"price\":7.49,\"description\":\"Though black raspberries are smaller than blackberries, they pack a crisp tartness.\",\"image\":\"simply-fruit-black-raspberry-seedless.png\"},{\"id\":\"1\",\"name\":\"Fruit & Chia\u2122 Pears in Blackberry Flavored Chia\",\"price\":10.49,\"description\":\"Pieces of crisp, sweet pears combine with delicately tart blackberry flavored chia seeds for a sophisticated and satisfying anytime snack.\",\"image\":\"berries.png\"},{\"id\":\"2\",\"name\":\"SuperFruit\u00ae Pear Chunks in Acai & Blackberry Juice Blend\",\"price\":6.49,\"description\":\"A ready-to-enjoy mix of bite-sized pear chunks in an antioxidant-rich blend of aca\u00ed and blackberry juice.\",\"image\":\"superfruit-pearchunksinacaiblackberry.png\"},{\"id\":\"3\",\"name\":\"Cran\u2022blackberry\u2122 cranberry blackberry juice drink\",\"price\":8.49,\"description\":\"Cran\u2022Blackberry\u2122 juice drink combines two of nature\u2019s superfruits for a one-two punch of powerful flavor from juicy...\",\"image\":\"Cran-Blackberry-Cranberry-Blackberry-Juice-Drink.png\"},{\"id\":\"4\",\"name\":\"Natural blackberry fruit spread\",\"price\":8.85,\"description\":\"The bright, tangy complexity of Smucker\u2019s\u00ae Natural Blackberry Fruit Spread brings the flavor of plump orchard-picked berries to your table.\",\"image\":\"natural-blackberry.png\"},{\"id\":\"5\",\"name\":\"Seedless Blackberry\",\"price\":12.89,\"description\":\"Get ready to experience a full berry sensation when you taste Polaner\u00ae Seedless Blackberry All Fruit.\",\"image\":\"Seedless Blackberry.png\"}]}";
            var myDeserializedClass = JsonConvert.DeserializeObject<Root>(json);

            return myDeserializedClass.Products;
        }
    }
}