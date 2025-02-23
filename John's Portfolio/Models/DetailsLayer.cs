namespace John_s_Portfolio.Models
{
    public class DetailsLayer
    {
        public Details GetDetails(int Id)
        {
            Details details = new Details()
            {
                Id = 1,
                Name = "John Eley",
                Gender = "Male",
                EmailAddress = "johneley798@gmail.com", 
            };
            return details;
        }
    }
}
