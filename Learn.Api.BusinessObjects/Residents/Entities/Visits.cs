namespace Learn.Api.BusinessObjects.Residents.Entities;

public class Visits
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly Visitdate { get; set; }
    public string PlacaDeVisita { get; set; }
    public int PharnersTotal { get; set; }
    public string House { get; set; }

}

