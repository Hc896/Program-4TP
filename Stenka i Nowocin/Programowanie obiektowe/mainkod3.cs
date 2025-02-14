using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Player player = new Player("Piotr",33403);
     Console.WriteLine(player.Name);
      Console.WriteLine(player.Score);
    
  }
  
  class Player{
      
      private string _name;
      private int _score;
      
  public Player(string name, int score) {
            _name = name;
            _score = score;
        } 
        
         public string Name {
            get { return _name; }
        }

        public int Score {
            get { return _score; }
        }
    }
}
