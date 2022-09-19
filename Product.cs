public class Product{
    int code;
    string name;
    string description;
    double price;
    int vat;

    //constructor
    public Product(string name, double price, string description, int vat) {
        this.code = new Random().Next(1,1000);
        this.name = name;
        this.price = price;
        this.description = description;
        this.vat = vat;
    }

    public double GetVatPrice()
    {
        return Math.Round((double)this.price + (this.price * this.vat / 100), 2);
    }

    public int GetCode()
    {
        return this.code;
    }

    public void GetExtendedCode()
    {
        string StringCode = this.code.ToString();

        while(StringCode.Length < 8)
        {
            StringCode = "0" + StringCode;
        }

        Console.WriteLine(StringCode);
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
        return $"Codice + Nome prodotto: {code} {name}";
    }
}