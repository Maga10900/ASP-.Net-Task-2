using ASP_Task_3.Models.Entities.Conceretes;

namespace ASP_Task_3.Models.ViewModel;

public class AddProductViewModel
{
	public string? Name { get; set;}
	public string? Description { get; set;}
	public float? Price { get; set;}
	public int? CategoryId { get; set;}
	public List<GetCategoryViewModel>? Categories { get; set;}

}
