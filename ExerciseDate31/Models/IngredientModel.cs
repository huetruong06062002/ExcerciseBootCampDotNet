namespace ExcerciseDate31.Models;
public class IngredientModel
{

  private static int _lastId = 0;

  public int Id { get; set; } = 1;

  public string Name { get; set; }

  public double Price { get; set; }


  public int Quantity { get; set; }

  public double TotalPrice => Price * Quantity;

  public IngredientModel(string name, double price, int quantity)
  {
    Id = ++_lastId; 
    Name = name;
    Price = price;
    Quantity = quantity;
  }
}