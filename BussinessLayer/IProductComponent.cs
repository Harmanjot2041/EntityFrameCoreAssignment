using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities;

namespace BussinessLayer
{
    public interface IProductComponent
    {
        List<StudentEntities.Entities.Products> GetProducts();
        int AddProduct(StudentEntities.Entities.Products model);
        int DeleteProduct(int id);
        int EditProdcut(int id,StudentEntities.Entities.Products model);
        StudentEntities.Entities.Products GetSingleProduct(int id);
    }
}
