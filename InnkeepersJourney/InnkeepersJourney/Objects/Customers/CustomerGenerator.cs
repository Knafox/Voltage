namespace InnkeepersJourney.Objects.Customers
{
    public class CustomerGenerator
    {

        int day = 1;
        static Random random;
        Dictionary<int,int> weights;

        public CustomerGenerator()
        {
            random = new Random();
            weights = new Dictionary<int, int>(){};
            
        }

        public GetDailyCustomers()
        {
            int customerCount = 2 + random.Next(1,days/10) + day/20;
            int runningTotal = 0;

            for(int i = 0; i < customerCount; i++){
                randomCustomer = random.Next(1,totalWeight);
                foreach( Key,Value in weights )
                
            }
            day++;
        }
    }
}