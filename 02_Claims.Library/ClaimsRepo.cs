using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Claims.Library
{
    public class ClaimsRepo
    {
        public Queue<Claims> _queueOfClaims = new Queue<Claims>();

        // Create Queue of Claims
        public void AddClaims(Claims claims)
        {
            _queueOfClaims.Enqueue(claims);
        }
        
        // Read Queue of Claims (See claims)
        public Queue<Claims> DisplayAllClaims()
        {
            return _queueOfClaims;
        }
        
        // Delete
        public Claims TakeCareOfNextClaim()
        {
            return _queueOfClaims.Peek();
        }

        public Claims DeleteClaimFromQueue()
        {
            return _queueOfClaims.Dequeue();
        }
    }
}