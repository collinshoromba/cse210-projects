class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public double CalculateTotalCost()
    {
        double totalProductCost = 0;

        foreach (Product product in products)
        {
            totalProductCost += product.CalculateTotalPrice();
        }

        double shippingCost = customer.IsInUSA() ? 5 : 35;

        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (Product product in products)
        {
            packingLabel += $"{product.GetProductInfo()}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label for {customer.GetName()}:\n{customer.GetShippingLabel()}";
    }
}