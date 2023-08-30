namespace AuthenticationProject.Data
{
    public class ApartmentSelect
    {
        public int ApartmentId { get; set; }
        public string? ApartmentName { get; set; }
        public string? Building { get; set; }

        public int? Space { get; set; }

        public int? Floor { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int UrbanId { get; set; }
        public string? UrbanName { get; set; }
    }
}
