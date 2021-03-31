using System;
using System.Collections.Generic;
using System.Text;
using StudentEntities.Entities;

namespace StudentDataAccess
{
    public interface IProductAccess
    {
        List<StudentEntities.Entities.Products> GetProducts();
        int AddProduct(StudentEntities.Entities.Products model);
        int DeleteProduct(int id);
        int EditProdcut(int id, StudentEntities.Entities.Products model);
        Products GetSingleProduct(int id);
        long InsertUpdateProducts(Products model);
    }
}
