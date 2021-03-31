using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using BussinessLayer;

namespace EntityFramworkProject.Controllers
{
    public class CrudController : Controller
    {
        
        private readonly IProductComponent _productComponent;
        public CrudController(IProductComponent productComponent)
        {
            _productComponent = productComponent;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            return View(_productComponent.GetSingleProduct(id));
        }
        public ActionResult DisplayProducts()
        {
            return View(_productComponent.GetProducts());
        }
        // GET:Create
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudentEntities.Entities.Products model)
        {
            try
            {
                var added = _productComponent.AddProduct(model);
                return RedirectToAction(nameof(DisplayProducts), _productComponent.GetProducts());
            }
            catch(Exception e)
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View(_productComponent.GetSingleProduct(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, StudentEntities.Entities.Products model)
        {
            try
            {
                var edited = _productComponent.EditProdcut(id, model);
                return RedirectToAction(nameof(DisplayProducts),_productComponent.GetProducts());
            }
            catch
            {
                return View();
            }
        }

        // GET: Delete
        public ActionResult Delete(int id)
        {
            return View(_productComponent.GetSingleProduct(id));
        }
        // POST: Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, StudentEntities.Entities.Products model)
        {
            try
            {
                _productComponent.DeleteProduct(id);
                return RedirectToAction(nameof(DisplayProducts), _productComponent.GetProducts());
            }
            catch
            {
                return View();
            }
        }
    }
}