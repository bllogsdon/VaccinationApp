namespace VaccinationAppLibrary.Models;

public class VaccineAgeMap
{
    public int Id { get; set; }
    public int VaccineId { get; set; }
    public Vaccine Vaccine { get; set; }
    public int AgeUnitId { get; set; }
    public VaccineAgeUnit AgeUnit { get; set; }
    public int Dose { get; set; }
    public VaccineFrequency Frequency { get; set; }
    public bool IsActive { get; set; }

    public VaccineAgeMap()
	{
        Vaccine = null!;
        AgeUnit = null!;
	}
}