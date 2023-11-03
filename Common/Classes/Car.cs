using Car_Rental.Common.Enums;
using Car_Rental.Common.Interfaces;

namespace Car_Rental.Common.Classes;

public class Car : IVehicle
{
    public string RegNo { get; }
    public string Make { get; }
    public int Odometer { get; set; }
    public double CostKm { get; }
    public VehicleTypes VehicleType { get; }
    public double CostDay { get; }
    public VehicleStatuses VehicleStatus { get; set; }
    public Car(string regNo, string make, int odometer, double costKm, VehicleTypes vehicleType, double costDay, VehicleStatuses vehicleStatus)
    => (RegNo, Make, Odometer, CostKm, VehicleType, CostDay, VehicleStatus)
        = (regNo, make, odometer, costKm, vehicleType, costDay, vehicleStatus);
}
