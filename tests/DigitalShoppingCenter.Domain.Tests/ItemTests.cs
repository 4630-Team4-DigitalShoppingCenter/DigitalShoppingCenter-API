using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitalShoppingCenter.Domain.Catalog;

namespace DigitalShoppingCenter.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Constructor_ValidInputs_CreatesItem()
    {
        var name = "Basketball";
        var description = "Indoor basketball";
        var brand = "Nike";
        var price = 29.99m;

        var item = new Item(name, description, brand, price);

        Assert.AreEqual(name, item.Name);
        Assert.AreEqual(description, item.Description);
        Assert.AreEqual(brand, item.Brand);
        Assert.AreEqual(price, item.Price);
        Assert.IsNotNull(item.Ratings);
        Assert.AreEqual(0, item.Ratings.Count);
    }

    [TestMethod]
    public void AddRating_ValidRating_AppendsToRatingsCollection()
    {
        var item = new Item("Basketball", "Indoor basketball", "Nike", 29.99m);
        var rating = new Rating(5, "Great item", "Irene");

        item.AddRating(rating);

        Assert.AreEqual(1, item.Ratings.Count);
        Assert.AreEqual(rating, item.Ratings[0]);
    }
}