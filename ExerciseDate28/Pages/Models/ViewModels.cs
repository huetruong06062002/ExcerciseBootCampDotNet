namespace Exercise28.Pages.Models;

public class Transaction{
  public string Type { get; set; } = string.Empty;

  public double Amount {get; set;} = 0;

  public DateTime Date {get; set;}
}