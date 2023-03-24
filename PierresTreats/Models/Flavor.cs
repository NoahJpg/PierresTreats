using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PierresTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    [Required(ErrorMessage = "The flavor's name can't be empty!")]
    public string FlavorName { get; set; }
    public List<TreatFlavor> JoinEntities { get;}
    public ApplicationUser User { get; set; }
  }
}