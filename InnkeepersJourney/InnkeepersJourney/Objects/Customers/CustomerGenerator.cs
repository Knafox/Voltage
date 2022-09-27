
namespace InnkeepersJourney.Objects.Customers
{
    public class CustomerGenerator
    {

        int day = 1;
        static Random random;
        Dictionary<int,int> weights;
        int totalWeight;

        public CustomerGenerator()
        {
            random = new Random();
            weights = new Dictionary<int, int>(){};
            weights.Add(Individual.Id, 80);
            weights.Add(Couple.Id, 15);
            weights.Add(Family.Id, 5);
            totalWeight = 100;
        }

        public IList<ICustomer> GetDailyCustomers()
        {
            int customerCount = (int)Math.Round(2.0 + (double)random.Next(1, day)/10 + (double)day /20);
            Console.WriteLine(customerCount);
            List<ICustomer> output = new List<ICustomer>();

            for(int i = 0; i < customerCount; i++){
                int randomCustomer = random.Next(1,totalWeight);
                foreach (KeyValuePair<int, int> weight in weights)
                {
                    if (randomCustomer < weight.Value){
                        output.Add(createCustomerfromId(weight.Key));
                        break;
                    }
                }
            }

            day++;
            return output;
        }

        private ICustomer createCustomerfromId(int Id)
        {
            if(Id == Individual.Id)
                return new Individual();
            if(Id == Couple.Id)
                return new Couple();
            if(Id == Family.Id)
                return new Family();
            throw new NotImplementedException();
            
        }
    }
}