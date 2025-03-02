namespace expense_marker_blazor.Dto;

public class ExpenseRecord
{
    public int id { get; set; }
    public string description { get; set; }
    public decimal amount { get; set; }
    public DateTime date { get; set; }
    public string category { get; set; }
}