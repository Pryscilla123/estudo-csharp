namespace aula55;

class Product{
    private string _name;

    public string Name {
        get {return _name;} 
        
        set { 
            if (value.Length > 1) {
                _name = value;
            }  
        }
        
    }

    public double Price { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, double price){
        _name = name;
        Price = price;
        Quantity = 0;
    }

    public Product(string name, double price, int quantity) : this(name, price) {
        Quantity = quantity;
    }



    public double TotalValueInStock(){
        return Quantity * Price;
    }

    public void AddProducts(int quantity){
        Quantity += quantity;
    }

    public void RemoveProducts(int quantity){
        Quantity -= quantity;
    }

    public override string ToString()
    {
        return string.Format("{0}, $ {1}, {2} unidades, Total: $ {3}", _name, Price, Quantity, TotalValueInStock());
    }
}