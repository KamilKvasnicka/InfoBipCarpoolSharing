using KKCarpoolMNGMNT.Interfaces;

namespace KKCarpoolMNGMNT.Models
{
    public class MockTravelPlanRepo : ITravelPlanRepository
    {
        public List<TravelPlan> TravelPlans;

        public MockTravelPlanRepo()
        {
            TravelPlans = new List<TravelPlan>();            
        }

        public List<TravelPlan> GetTravelPlans()
        {
            return TravelPlans;
        }
    }
}
