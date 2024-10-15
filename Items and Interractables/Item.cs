public class Item 
{
 public string Name {get; set;}
 public string Description {get; set;}

 public bool IsUseAble {get; set;}

 public bool IsPickupAble {get; set;}

 public bool IsLookAble {get; set;}

 public Item(string name, string description, bool isUseAble, bool isPickupAble, bool isLookAble  )
 
 {
    Name = name;
    Description = description;
    IsUseAble = isUseAble;
    IsPickupAble = isPickupAble;
    IsLookAble = isLookAble;

 }

}