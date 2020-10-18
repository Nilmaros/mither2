using System;
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

        public Task<Brand[]> GetBrandsAsync()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Brand
            {
                Image = MockData[rng.Next(MockData.Length)]
            }).ToArray());
        }
    }
}
