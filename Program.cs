using ConsoleApp1;

Product product1 = new Product("Ковбаса", 200);

Product product2 = new Product("Сало", 75);

Product product3 = new Product("Згущене молоко", 150);

DBItem<Product> DBProduct = new DBItem<Product>();
DBProduct.AddItem(product1);
DBProduct.AddItem(product2);
DBProduct.AddItem(product3);

Description description1 = new Description("м'ясний продукт із фаршу в оболонці або без неї, який пройшов термічну обробку чи ферментацію", 1);
Description description2 = new Description("тваринний підшкірний жир, найчастіше свинячий", 2);
Description description3 = new Description("концентрований молочний продукт, який отримують шляхом видалення частини води з коров'ячого молока з додаванням цукру", 3);

DBItem<Description> DBDescription = new DBItem<Description>();
DBDescription.AddItem(description1);
DBDescription.AddItem(description2);
DBDescription.AddItem(description3);

Category category1 = new Category("м'ясна продукція");
Category category2 = new Category("Товар зі знижкою");
Category category3 = new Category("Молочна продукція");

DBItem<Category> DBCategory = new DBItem<Category>();
DBCategory.AddItem(category1);
DBCategory.AddItem(category2);
DBCategory.AddItem(category3);

DBItem<ProductCategory> DBProductCategory = new DBItem<ProductCategory>();
DBProductCategory.AddItem(new ProductCategory(1, 1));
DBProductCategory.AddItem(new ProductCategory(1, 2));
DBProductCategory.AddItem(new ProductCategory(2, 1));
DBProductCategory.AddItem(new ProductCategory(3, 2));
DBProductCategory.AddItem(new ProductCategory(3, 3));

foreach (Product product in DBProduct.Items)
{
    Console.WriteLine(product);
    foreach (Description description in DBDescription.Items)
    {
        if (description.ProductId == product.Id)
        {
            Console.WriteLine("\t" + description);
        }
    }
    Console.WriteLine("\tКатегорії:");
    foreach (ProductCategory pc in DBProductCategory.Items)
    {
        if (pc.ProductId == product.Id)
        {
            Category? cat = DBCategory.Items.Find(c => c.Id == pc.CategoryId);
            if (cat != null)
            {
                Console.WriteLine("\t" + cat);
            }
        }
    }
}
Console.WriteLine();
foreach (Category category in DBCategory.Items)
{
    Console.WriteLine(category);
    Console.WriteLine("\tТовари:");
    foreach (ProductCategory pc in DBProductCategory.Items)
    {
        if (pc.CategoryId == category.Id)
        {
            Product? prod = DBProduct.Items.Find(p => p.Id == pc.ProductId);
            if (prod != null)
            {
                Console.WriteLine("\t" + prod);
            }
        }
    }
}


