public class Player 
{
  public string Name {get; set;}

  public int Sanity {get; set;}

  public List<Item> inventory {get; set;}

  public Player (string name)
  {
    Name = name;
    Sanity = 100;
    inventory = new List<Item>();
  }
  int timelimit = 180 ;

}