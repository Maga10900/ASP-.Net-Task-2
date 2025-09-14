using ASP_Task_3.Models.Entities.Conceretes;

namespace ASP_Task_3.Models.ViewModel;

public class GetProductViewModel
{
	public int? Id { get; set; }
	public string? Name{ get; set;}
	public string? Description{ get; set;}
	public float? Price { get; set;}
	public string? CategotyName { get; set; } 
}
