using ASP_Task_3.Context;
using ASP_Task_3.Models.Entities.Conceretes;
using ASP_Task_3.Models.ViewModel;

using Microsoft.AspNetCore.Mvc;

namespace ASP_Task_3.Controllers;

public class ShopController : Controller
{
	private readonly ShopDbContext _dbContext;

    public ShopController(ShopDbContext dbContext)
    {
        _dbContext = dbContext;
    }
	[HttpGet]
    public IActionResult GetAllProducts()
	{
		var products = _dbContext.Products.ToList();
		var prViewModel = products.Select(p => new GetProductViewModel
		{
			Name = p.Name,
			Description = p.Description,
			Price = p.Price
		}).ToList();

		return View(prViewModel);
	}
	[HttpGet]
	public IActionResult AddProduct()
	{
		return View();
	}

	[HttpPost]
	public IActionResult AddProduct(AddProductViewModel product)
	{
		var pr = new Product
		{
			Name = product.Name,
			Description = product.Description,
			Price = product.Price
		};
		_dbContext.Products.Add(pr);
		_dbContext.SaveChanges();
		return RedirectToAction("GetAllProducts");

	}
}
