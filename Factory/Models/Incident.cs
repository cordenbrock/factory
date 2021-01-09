using System.Collections.Generic;

namespace Factory.Models
{
  public class Incident
  {
    public Incident()
    {
      this.IncidentLog = new HashSet<IncidentLog>();
    } 
    
  public int IncidentId { get; set; }
  public string Title { get; set; }
  public string Report { get; set; }
  public string Date { get; set; }
  public virtual ICollection<IncidentLog> IncidentLog { get; set; }
  }
}