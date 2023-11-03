using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;
namespace Car_Rental.Common.Classes;

public class Motorcycles : IVehicle
{
    public string RegNo { get; set; }
    public string Make { get; }
    public int Odometer { get; set; }
    public double CostKm { get; }
    public VehicleTypes VehicleType { get; }
    public double CostDay { get; }
    public VehicleStatuses VehicleStatus { get; set; }
    public Motorcycles(string regNo, string make, int odometer, double costKm, VehicleTypes vehicleType, double costday, VehicleStatuses vehicleStatus)
    => (RegNo, Make, Odometer, CostKm, VehicleType, CostDay, VehicleStatus)
        = (regNo, make, odometer, costKm, vehicleType, costday, vehicleStatus);
}
