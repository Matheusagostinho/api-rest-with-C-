

public class Product
{
    
    public int Id { get; set; }
    public string Title { get; set; }

    public decimal Amount { get; set; }



    private static int counterId = 1;


    public Product()
    {
        Id = counterId++;
    }

    
}
