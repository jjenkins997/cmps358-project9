// Jahzah Jenkins, Tomas Parker
// c00227447 c00409618
// CMPS 358 
// project #9

using Microsoft.EntityFrameworkCore;

namespace p9_c00227447_c00409618.Data;

public class InventoryContext : DbContext
{
    public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
    {
        
    }
    public DbSet<Models.InventoryItem> InventoryItems { get; set; }
}