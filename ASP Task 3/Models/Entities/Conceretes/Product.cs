using ASP_Task_3.Models.Entities.Abstract;

namespace ASP_Task_3.Models.Entities.Conceretes;

public class Product:BaseEntitiy
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public float? Price { get; set; }
    public int? CategoryId{ get; set; }
    public Category? Category { get; set; }
    public List<Order>? Orders { get; set; }
}
