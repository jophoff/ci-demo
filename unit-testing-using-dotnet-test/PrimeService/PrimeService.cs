using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
			// added code
			if (candidate == 1)
			{
				return false;
			}

            throw new NotImplementedException("Not fully implemented.");
        }
    }
}