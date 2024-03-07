using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HPCTech2024WebStoreMVC.Models;

public partial class Product
{
    [Key]
    public int Id { get; set; }

    public string? Name { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Price { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
