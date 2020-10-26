using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mither2.Model;

namespace mither2.Data
{
    public class BrandService
    {
        private static readonly string[] MockData = new[]
        {
            "img/brands/logo1.png", "img/brands/logo2.png", "img/brands/logo3.png",
            "img/brands/logo4.png", "img/brands/logo5.png", "img/brands/logo6.png",
            "img/brands/logo7.png", "img/brands/logo8.png", "img/brands/logo9.png"
        };

        public Task<List<Brand>> GetBrandsAsync()
        {
            List<Brand> brand = new List<Brand>();

            foreach(string data in MockData)
            {
                brand.Add(new Brand { Image = data });
            }
            return Task.FromResult(brand);
        }
    }
}
