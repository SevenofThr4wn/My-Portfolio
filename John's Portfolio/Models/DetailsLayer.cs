namespace John_s_Portfolio.Models
{
    public class DetailsLayer
    {
        public Details GetDetails(int Id)
        {

            //This is where you can set your variables created in Details.cs
            Details details = new Details()
            {
                //if you change this, make sure to change it in HomeController.cs(Ln 19)
                Id = 1,
                Name = "John Eley",
                Gender = "Male",
                EmailAddress = "johneley798@gmail.com",
                WebsiteURL = "https://github.com/SevenofThr4wn"
            };
            return details;
        }
    }
}
