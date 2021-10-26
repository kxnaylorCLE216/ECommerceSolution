using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class OrderPostRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Address { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    public string State { get; set; }

    [Required]
    public string Zip { get; set; }

    [Required]
    public Creditcardinfo CreditCardInfo { get; set; }

    [Required]
    public List<Item> Items { get; set; }
}

public class Creditcardinfo
{
    [Required]
    public string Number { get; set; }

    [Required]
    public string Expiration { get; set; }

    [Required]
    public string Cvv2 { get; set; }
}

public class Item
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public int Qty { get; set; }

    [Required]
    public decimal Price { get; set; }
}