using System.ComponentModel.DataAnnotations;

namespace Todo.Data
{

    public class ApprovedItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Please insert item name.")]
        public string ItemName { get; set; }

        [Required(ErrorMessage = "Please insert the Quantity.")] 
        public Guid ItemId { get; set; }
        public int Quantity { get; set; }
        public bool IsApproved { get; set; }
        public Guid TakenBy { get; set; }
        public string TakerName { get; set; }

        public Guid ApprovedBy { get; set; }

        public string ApproverName { get; set; }


    }
}
