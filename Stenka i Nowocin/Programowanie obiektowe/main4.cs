public string getName(){
    return_name;
}

public void setName(string name){
    _name = name;
}

public Person(string name, int age){
    Console.WriteLine("działa konstruktor z dwoma parametrami");
    this.age = age;
    this.name = name;
}