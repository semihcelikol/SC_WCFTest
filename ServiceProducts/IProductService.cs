using System.Runtime.Serialization;
using System.ServiceModel;

namespace ServiceProducts
{
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        Product GetProductById(int id);
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public int Qty { get; set; }
    }
}