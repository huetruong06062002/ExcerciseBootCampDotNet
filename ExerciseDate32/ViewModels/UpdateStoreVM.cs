namespace ExerciseDate32.ViewModels;

public class UpdateStoreVM
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Alias { get; set; }
  public string Latitude { get; set; }
  public string Longtitude { get; set; }
  public string Description { get; set; }
  public string Image { get; set; }
  public bool Deleted { get; set; }
}