using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAQueue
{
    class Bank
    {
        public static void Main(string[] args)
        {
            int MINIMUM_DURATION = 1;
            int MAXIMUM_DURATION = 5;
            double CUST_PER_MINUTE = .75;
            int NUM_MIN = 120;
            int numCustomers = 0;
            List<Queue<Customer>> list = new List<Queue<Customer>>();
            Queue<double> transactionDurations= new Queue<double>();
            CustomerGenerator frontdoor = new CustomerGenerator(MINIMUM_DURATION, MAXIMUM_DURATION, CUST_PER_MINUTE, NUM_MIN);

            for (int i = 0; i < NUM_MIN; i++)
            {
                Queue<Customer> arrivals = frontdoor.GetCustomers(i);
                while (arrivals.Count > 0)
                {
                    Customer nextCustomer = arrivals.Dequeue();
  
                    numCustomers++;
                }
            }
        
         
            for (int i = 0; i < NUM_MIN; i++)
            {
                double total = 0.0;
                Queue<Customer> arrivals = frontdoor.GetCustomers(i);
                while (arrivals.Count > 0)
                {
                   total+= arrivals.Dequeue().TransactionDuration;          
                }
                transactionDurations.Enqueue(total);
            }

            for (int i = 0; i < NUM_MIN; i++)
            {
                Queue<Customer> arrivals = frontdoor.GetCustomers(i);
                list.Add(arrivals);
            }

            foreach (var cus in list)
            {
                Queue<Customer> arrivals = cus;
                while (arrivals.Count > 0)
                {
                    Customer nextCustomer = arrivals.Dequeue();
                    Console.WriteLine("{0}", nextCustomer);
                }
            }

           Console.WriteLine(numCustomers);
		   Console.Read();
        }
    }
}
