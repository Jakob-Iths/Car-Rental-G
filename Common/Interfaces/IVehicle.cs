using System.Globalization;
using Car_Rental.Common.Enums;

namespace Car_Rental.Common.Interfaces;

public interface IVehicle
{
    string RegNo { get; }
    string Make { get; }
    int Odometer { get; set; }
    double CostKm { get; }
    VehicleTypes VehicleType { get; }
    double CostDay { get; }
    VehicleStatuses VehicleStatus { get; set; }
}
