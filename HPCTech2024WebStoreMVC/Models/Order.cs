using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace HPCTech2024WebStoreMVC.Models;

[Index("CustomerId", Name = "IX_Orders_CustomerId")]
public partial class Order
{
    [Key]
    public int Id { get; set; }

    public DateTime OrderDate { get; set; }

    public DateTime? OrderFullfilled { get; set; }

    public int CustomerId { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Orders")]
    public virtual Customer Customer { get; set; } = null!;

    [InverseProperty("Order")]
    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
