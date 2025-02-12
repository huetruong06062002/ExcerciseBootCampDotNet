namespace ExerciseDate32.Models;
public class HTTPResponse<T>{
  public int statusCode { get; set; }
  public string message { get; set; }
  public T content { get; set; }

  public DateTime dateTime { get; set; }
}