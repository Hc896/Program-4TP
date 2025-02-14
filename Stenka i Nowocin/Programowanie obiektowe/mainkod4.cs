using System;

class HelloWorld {
  static void Main() {
    
    Player player = new Player();
     Console.WriteLine(player.GetName());
  }
  class Player{
      
      private string _name ="Emi";
      private int _score;
      

      public string GetName() {
            return _name;
        }

        public void SetName(string name) {
         
             if (name.Length >= 2) {
                _name = name;
            }
         
        }
    }
}