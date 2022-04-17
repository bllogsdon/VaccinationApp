namespace VaccinationAppLibrary.Models;

public class VaccineAgeUnit
{
	public int Id { get; set; }
	public int Value { get; set; }
	public string Unit { get; set; }
	public bool IsActive { get; set; }

	public VaccineAgeUnit()
	{
        Unit = "";
	}
}

