using Models.Models;
using ViewModels.ViewModels;

namespace IMS.Mappers
{
    public class Mapper
    {
        public static Product Map(ProductVM source)
        {
            Product destination = new Product() { 
                Barcode = source.Barcode,
                CatagoryId = source.CatagoryId,
                Description = source.Description,
                Id = source.Id,
                Name = source.Name,
                StatusId = source.StatusId,
                //Timestamp = source.Timestamp,
                //Updated = source.Updated,
                Weight = source.Weight,
            };
            return destination;
        }
        public static ProductVM Map(Product source)
        {
            ProductVM destination = new ProductVM()
            {
                Barcode = source.Barcode,
                CatagoryId = source.CatagoryId,
                Description = source.Description,
                Id = source.Id,
                Name = source.Name,
                StatusId = source.StatusId,
                Timestamp = source.Timestamp,
                Updated = source.Updated,
                Weight = source.Weight,
            };
            return destination;
        }
    }
}
