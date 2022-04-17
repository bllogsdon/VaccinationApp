namespace VaccinationAppLibrary.Models;

public class VaccineTradeName
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int VaccineId { get; set; }
	public bool IsActive { get; set; }

	public VaccineTradeName()
	{
        Name = "";
	}
}