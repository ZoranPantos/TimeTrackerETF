using System.ComponentModel.DataAnnotations;

namespace TimeTrackerETF.Domain
{
    public class Client
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
