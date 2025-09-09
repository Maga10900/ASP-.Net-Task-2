using ASP_Task_3.Models.Entities.Abstract;

namespace ASP_Task_3.Models.Entities.Conceretes;

public class Order:BaseEntitiy
{
    public string? Name{ get; set; }
    public float? TotalPrice { get; set;}
    public List<Product>? Products { get; set; }
}
