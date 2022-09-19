public class Product{
    public int code;
    public string name;
    public string description;
    public double price;
    public int vat;

    //constructor
    public Product(string name, double price, string description, int vat) {
        this.code = new Random().Next(1000,100000);
        this.name = name;
        this.price = price;
        this.description = description;
        this.vat = vat;
    }

    public double GetVatPrice()
    {
        return this.price + (this.vat / 100);
    }

    public int GetCode()
    {
        return this.code;
    }

    public string GetName()
    {
        return this.name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public string GetDescription()
    {
        return this.description;
    }

    public void SetDescription(string description)
    {
        this.description = description;
    }

    public double GetPrice()
    {
        return this.price;
    }

    public void SetPrice(double price)
    {
        this.price = price;
    }
    public void SetVat(int vat)
    {
        this.vat = vat;
    }
    public string GetCodeAndName()
    {
        return code + name;
    }
}