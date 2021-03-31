using StudentEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Data;

namespace StudentDataAccess
{
    public class ProductAccess : IProductAccess
    {
        private readonly StudentEntities.Entities.EmployeeDbCOntext _context;
        public ProductAccess(StudentEntities.Entities.EmployeeDbCOntext context)
        {
            _context = context;
        }
        public int AddProduct(Products model)
        {
            _context.Products.Add(model);
            _context.SaveChanges();
            ProductOwnerDetails temp = new ProductOwnerDetails();
            temp.OwnerName = "Harman";
            temp.OwnerAge = 21;
            _context.ProductOwnerDetails.Add(temp);
            return _context.SaveChanges();
        }
        public long InsertUpdateProducts(Products model)
        {
            long result = 0;
            SqlParameter resultParameter = new Microsoft.Data.SqlClient.SqlParameter();
            try
            {
                resultParameter.ParameterName = "@Result";
                resultParameter.Direction = System.Data.ParameterDirection.Output;
                resultParameter.SqlDbType = SqlDbType.BigInt;
                long id = 0;
                _context.Database.ExecuteSqlRaw("[dbo].[AddUpdatedProducts] @ProductId,@ProductName,@ProductDiscription,@ProductColor,@ProductPrice,@NoOfProducts,@Catagory,@ShippingAllowed,@ExpiryDate,@Result out",
                    new SqlParameter("@ProductId", id),
                    new SqlParameter("@ProductName", model.ProductName),
                    new SqlParameter("@ProductDiscription", model.ProductDiscription),
                    new SqlParameter("@ProductColor", model.ProductColor),
                    new SqlParameter("@ProductPrice", model.ProductPrice),
                    new SqlParameter("@NoOfProducts", model.NoOfProducts),
                    new SqlParameter("@Catagory", model.ProductPrice),
                    new SqlParameter("@ShippingAllowed", model.ShippingAllowed),
                    new SqlParameter("@ExpiryDate", model.ExpiryDate),

                    resultParameter
                    );
                if (Convert.ToInt32(resultParameter.Value) > 0)
                    result = Convert.ToInt32(resultParameter.Value);
            }
            catch (Exception e)
            {
                result = 0;
            }
            return result;

        }

        public int DeleteProduct(int id)
        {
            Products temp = _context.Products.FirstOrDefault(products => products.ProductId == id);
            _context.Products.Remove(temp);
            return _context.SaveChanges();
        }

        public int EditProdcut(int id,Products model)
        {
            Products temp = _context.Products.FirstOrDefault(products => products.ProductId == id);
            temp.Catagory = model.Catagory;
            temp.ExpiryDate = model.ExpiryDate;
            temp.NoOfProducts = model.NoOfProducts;
            temp.ProductColor = model.ProductColor;
            temp.ProductDiscription = model.ProductDiscription;
            temp.ProductName = model.ProductName;
            temp.ProductPrice = temp.ProductPrice;
            temp.ShippingAllowed = temp.ShippingAllowed;
            _context.Products.Update(temp);
            return _context.SaveChanges();
        }

        public List<Products> GetProducts()
        {
           var tempList = _context.Products.FromSqlRaw("Select * from Products").ToList();
            return _context.Products.ToList();
        }

        public Products GetSingleProduct(int id)
        {

            return _context.Products.FirstOrDefault(products => products.ProductId == id);
        }
    }
}
