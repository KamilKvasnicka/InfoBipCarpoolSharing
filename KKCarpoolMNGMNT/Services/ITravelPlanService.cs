using KKCarpoolMNGMNT.Models;

namespace KKCarpoolMNGMNT.Services
{
    public interface ITravelPlanService
    {
        void SaveTravelPlan(TravelPlanDTO travelPlanDTO);
        void DeleteTravelPlan(int travelPlanId);
        TravelPlan GetTravelPlan(int travelPlanId);
        List<Employee> GetSelectedEmployees(int travelPlanId);
        bool IsCarAlreadyOnTheRide(string licensePlates, DateTime startDate, DateTime endDate);
        bool IsEmployeeOnTheRide(DateTime startDate, DateTime endDate, int employeeId);
        List<TravelPlan> GetTravelPlansForMonth(int month, string licensePlates);
        List<TravelPlan> GetTravelPlans();
        TravelPlanDTO MapTravelPlanToDTO(TravelPlan travelPlan, ICarService carRepository);
        TravelPlan MapDTOToTravelPlan(TravelPlanDTO travelPlanDTO, ICarService carRepository);
    }
}

