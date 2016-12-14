using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAQueue
{
    
  
    public class Customer
    {
        public readonly int ArrivalTime;
        public readonly int TransactionDuration;
        public int ServiceTime { get; set; }

        public Customer(int arrival, int duration)
        {
            ArrivalTime = arrival;
            TransactionDuration = duration;
        }

        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Customer [arrivalTime=");
            builder.Append(ArrivalTime);
            builder.Append(", transactionDuration=");
            builder.Append(TransactionDuration);
            builder.Append(", serviceTime=");
            builder.Append(ServiceTime);
            builder.Append("]");
            return builder.ToString();
        }
    }

}
