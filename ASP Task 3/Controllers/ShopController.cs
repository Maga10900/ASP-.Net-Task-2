using ASP_Task_3.Context;
using ASP_Task_3.Models.Entities.Conceretes;
using ASP_Task_3.Models.ViewModel;

using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.AspNetCore.Mvc;

using System.Reflection.Metadata.Ecma335;

namespace ASP_Task_3.Controllers;

public class ShopController : Controller
{
	private readonly ShopDbContext _dbContext;

    public ShopController(ShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }
	#region Product
	[HttpGet]
	public IActionResult GetAllProducts()
	{
		var products = _dbContext.Products.ToList();
		var prViewModel = products.Select(p => new GetProductViewModel
		{
			Id = p.Id,
			Name = p.Name,
			Description = p.Description,
			Price = p.Price
		}).ToList();

		return View(prViewModel);
	}
	[HttpGet]
	public IActionResult AddProduct()
	{
		var ct = _dbContext.Categories.Select()
		return View(ct);
	}

	[HttpPost]
	public IActionResult AddProduct(AddProductViewModel product)
	{
		var pr = new Product
		{
			Name = product.Name,
			Description = product.Description,
			Price = product.Price,
			CategoryId = product.CategoryId
		};
		_dbContext.Products.Add(pr);
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllProducts");
	}
	[HttpGet]
	public IActionResult DeleteProduct(int id)
	{
		var pr = _dbContext.Products.FirstOrDefault(p => p.Id == id);
		if (pr is not null)
			_dbContext.Products.Remove(pr);
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllProducts");
	}
	[HttpGet]
	public IActionResult UpdateProduct(int id)
	{
		var pr = _dbContext.Products.FirstOrDefault(p => p.Id == id);
		var pr_ = new UpdateProductViewModel
		{
			Name = pr.Name,
			Description = pr.Description,
			Price = pr.Price
		};
		return View(pr_);
	}
	[HttpPost]
	public IActionResult UpdateProduct(UpdateProductViewModel model)
	{
		var pr = _dbContext.Products.FirstOrDefault(p => p.Id == model.Id);
		if (pr is not null)
		{
			pr.Name = model.Name;
			pr.Description = model.Description;
			pr.Price = model.Price;
			_dbContext.Update(pr);
		}
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllProducts");
	}
	#endregion
	[HttpGet]
	public IActionResult GetAllCategories()
	{
		var categories = _dbContext.Categories.ToList();
		var ct = categories.Select(p => new GetCategoryViewModel
		{
			Id = p.Id,
			Name = p.Name,
		}).ToList();

		return View(ct);
	}


	[HttpGet]
	public IActionResult AddCategory()
	{
		return View();
	}

	[HttpPost]
	public IActionResult AddCategory(AddCategoryViewModel category)
	{
		var ct = new Category
		{
			Name = category.Name,
		};
		_dbContext.Categories.Add(ct);
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllCategories");
	}

	[HttpGet]
	public IActionResult DeleteCategory(int id)
	{
		var ct = _dbContext.Categories.FirstOrDefault(p => p.Id == id);
		if (ct is not null)
			_dbContext.Categories.Remove(ct);
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllCategories");
	}
	[HttpGet]
	public IActionResult UpdateCategory(int id)
	{
		var pr = _dbContext.Categories.FirstOrDefault(p => p.Id == id);
		var pr_ = new UpdateCategoryViewModel
		{
			Name = pr.Name,
		};
		return View(pr_);
	}
	[HttpPost]
	public IActionResult UpdateCategory(UpdateCategoryViewModel model)
	{
		var pr = _dbContext.Categories.FirstOrDefault(p => p.Id == model.Id);
		if (pr is not null)
		{
			pr.Name = model.Name;
			
			_dbContext.Update(pr);
		}
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllCategories");
	}
}
