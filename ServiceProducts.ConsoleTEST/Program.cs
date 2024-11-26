using WCFProductService;

namespace ServiceProducts.ConsoleTEST
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            try
            {
                Product product = null;

                using (ProductServiceClient client = new ProductServiceClient(ProductServiceClient.EndpointConfiguration.BasicHttpBinding_IProductService))
                {
                    product = await client.GetProductByIdAsync(5);
                }

                if (product != null)
                {
                    Console.WriteLine($"Product found: {product.Id} - {product.Name} - {product.Description}");
                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.ReadKey();
            }
        }
    }
}