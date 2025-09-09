using ASP_Task_3.Models.Entities.Conceretes;

using Microsoft.EntityFrameworkCore;

namespace ASP_Task_3.Context;

public class ShopDbContext : DbContext
{
	public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
	{

	}
	public DbSet<Category> Categories { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Order> Orders { get; set; }
}
