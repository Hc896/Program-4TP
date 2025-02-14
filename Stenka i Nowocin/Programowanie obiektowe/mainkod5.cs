using System;
class HelloWorld {
  static void Main() {
    
    Player player = new Player();
    player.Name = "lol";
    Console.WriteLine(player.Name);
  }
  
  class Player{
      private string _name;
      private int _score;
      
      //property
      public string Name{
          get{
              return _name;
              
          }
          set{
              _name = value;
          }
          
          
      } 
  }
}
