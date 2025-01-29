namespace ExcerciseDate31.Services;
using System.Collections.Generic;
using ExcerciseDate31.Models;
public class BugetService
{
  public List<IngredientModel> Ingredients = new List<IngredientModel>(){
      new IngredientModel("Salad", 2.5, 4),
      new IngredientModel("Cheese", 10, 1),
      new IngredientModel("Beef", 27.5, 1),
  };


  public void AddIngredient(IngredientModel ingredient)
  {
    ingredient.Quantity += 1;
    SateHasChanged();
  }

  public void RemoveIngredient(IngredientModel ingredient)
  {
    ingredient.Quantity -= 1;
    if(ingredient.Quantity == 0) return;
    SateHasChanged();
  }


  public double TotalPrice()
  {
    double TotalPrice = 0;
    foreach (IngredientModel ingredient in Ingredients)
    {
      TotalPrice += ingredient.TotalPrice;
    }

    return TotalPrice;
  }

  public event Action OnChange;

  private void SateHasChanged() => OnChange?.Invoke();


}