using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Packt.Shared {
  public class Library : DbContext {
    public DbSet<BookList> BookList {get; set;} 
    public DbSet<CreditCard> CreditCard {get; set;} 
    public DbSet<Person> Person {get; set;} 
    public DbSet<Title> Title {get; set;}
    public Library(DbContextOptions<Library> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<BookList>()
        .Property(b => b.Id)
        .IsRequired();
      modelBuilder.Entity<BookList>()
        .Property(b => b.missing);
      modelBuilder.Entity<BookList>()
        .Property(b => b.late);
      modelBuilder.Entity<BookList>()
        .Property(b => b.returnDate);
      modelBuilder.Entity<BookList>()
        .Property(b => b.title);
      modelBuilder.Entity<BookList>()
        .HasOne(b => b.bookTitle)
        .WithMany(t => t.BookList);
        //.HasForeignKey(b => b.bookTitleID);
      modelBuilder.Entity<BookList>()
        .HasOne(b => b.Person)
        .WithMany(p => p.bookTitles);
      modelBuilder.Entity<CreditCard>()
        .Property(c => c.Id)
        .IsRequired();
      modelBuilder.Entity<CreditCard>()
        .Property(c => c.cardName);
      modelBuilder.Entity<CreditCard>()
        .Property(c => c.number);
      modelBuilder.Entity<CreditCard>()
        .Property(c => c.expdate);
      modelBuilder.Entity<CreditCard>()
        .HasOne(c => c.Person)
        .WithMany(p => p.CreditCards);
        //.HasForeignKey(c => c.Id);
      modelBuilder.Entity<Person>()
        .Property(p => p.Id)
        .IsRequired();
      modelBuilder.Entity<Person>()
        .Property(p => p.personName);
      modelBuilder.Entity<Person>()
        .Property(p => p.fees);
      modelBuilder.Entity<Person>()
        .HasMany(p => p.CreditCards)
        .WithOne(c => c.Person)
        .HasForeignKey(p => p.Id); 
      modelBuilder.Entity<Person>()
        .HasMany(p => p.bookTitles)
        .WithOne(b => b.Person)
        .HasForeignKey(p => p.Id);
      modelBuilder.Entity<Title>()
        .Property(t => t.Id)
        .IsRequired();
      modelBuilder.Entity<Title>()
        .Property(t => t.title);    
      modelBuilder.Entity<Title>()
        .Property(t => t.author);            
      modelBuilder.Entity<Title>()
        .Property(t => t.summary);            
      modelBuilder.Entity<Title>()
        .Property(t => t.quantity); 
      modelBuilder.Entity<Title>()
        .HasMany(t => t.BookList)
        .WithOne(b => b.bookTitle);
        //.HasForeignKey(t => t.Id);
    }
  }
}