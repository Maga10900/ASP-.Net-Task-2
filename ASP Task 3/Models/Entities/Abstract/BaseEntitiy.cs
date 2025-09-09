namespace ASP_Task_3.Models.Entities.Abstract;

public class BaseEntitiy
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
}
