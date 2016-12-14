using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAQueue
{
  
 
    public class CustomerGenerator
    {
        private int[] customerArrivals;
        private readonly int minDuration;
        private readonly int maxDuration;
        private Random rand;

         
        public CustomerGenerator(int minDuration, int maxDuration, double avgPerSlot, int totalTime, int seed=-1)
        {
            if (seed < 0)
                rand = new Random();
            else
                rand = new Random(seed);

            customerArrivals = new int[totalTime];
            this.minDuration = minDuration;
            this.maxDuration = maxDuration;
            initializeArrivals(avgPerSlot, totalTime);
        }

  

        private void initializeArrivals(double avgPerSlot, int slots)
        {
            for (int i = 0; i < slots * avgPerSlot; i++)
            {
                int slot = rand.Next(slots);
                customerArrivals[slot]++;
            }
        }

       

        public Queue<Customer> GetCustomers(int timeSlot)
        {
            Queue<Customer> customers = new Queue<Customer>();
            int numArrivals = customerArrivals[timeSlot];

            while (numArrivals > 0)
            {
                int duration = rand.Next(maxDuration - minDuration + 1) + minDuration;
                Customer customer = new Customer(timeSlot, duration);
                customers.Enqueue(customer);
                numArrivals--;
            }

            return customers;
        }

  
    }
}

