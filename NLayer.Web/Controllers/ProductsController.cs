
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NLayer.Core.DTOs;
using NLayer.Core.Models;
using NLayer.Core.Services;

namespace NLayer.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _services;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService services)
        {
            _services = services;
        }


        public async Task<IActionResult> Index()
        {
            return View(await _services.GetProductsWithCategory());
        }

        public async Task<IActionResult> Save()
        {
            var categories = _categoryService.GetAllAsync();
            
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);

            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");   
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto products)
        {
            if (ModelState.IsValid)
            {
                await _services.AddAsync(_mapper.Map<Product>(products));
                return RedirectToAction(nameof(Index));
            }

            var categories = _categoryService.GetAllAsync();
            
            var categoriesDto = _mapper.Map<List<CategoryDto>>(categories);

            ViewBag.categories = new SelectList(categoriesDto, "Id", "Name");

            return View();
        }
    }
}
