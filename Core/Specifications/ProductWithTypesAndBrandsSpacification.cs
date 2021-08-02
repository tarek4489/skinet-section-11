using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductWithTypesAndBrandsSpacification : BaseSpacification<Product>
    {
        public ProductWithTypesAndBrandsSpacification()
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }

        public ProductWithTypesAndBrandsSpacification(int id) : base(x => x.Id == id)
        {
            AddIncludes(x => x.ProductType);
            AddIncludes(x => x.ProductBrand);
        }
    }
}