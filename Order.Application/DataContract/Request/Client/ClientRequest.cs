

namespace Order.Application.DataContract.Request
{
    public sealed class ClientRequest 
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
    }
}
