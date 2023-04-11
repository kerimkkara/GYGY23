public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    CustomerValidator CustomerValidator { get; set; }
    Customer customer1 = new Customer();
    public void SaveCustomer()
    {
        if (CustomerValidator.ValidateCustomer(customer1))
        {
            // Veritabanına müşteri bilgilerini kaydetmek için gereken kodlar buraya yazılır.

            Console.WriteLine("test");
        }  
     }
}

public class CustomerValidator
{
    public bool ValidateCustomer(Customer customer)
    {
        // Müşteri bilgilerinin doğruluğunu kontrol etmek için gereken kodlar buraya yazılır.

        return true;
    }
}
