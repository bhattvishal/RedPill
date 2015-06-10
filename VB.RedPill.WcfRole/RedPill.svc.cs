using System;
using System.ServiceModel;
using System.Threading.Tasks;
using VB.RedPill.Contracts;

namespace VB.RedPill.WcfRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RedPill" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select RedPill.svc or RedPill.svc.cs at the Solution Explorer and start debugging.
    public class RedPill : IRedPill
    {
        public long FibonacciNumber(long n)
        {
            try
            {
                return Utils.GetFibonacciNumber(n);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                throw new FaultException<ArgumentOutOfRangeException>(ex,
                    "Provide input will result in out of range exception");
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }       

        public string ReverseWords(string s)
        {
            try
            {
                return Utils.GetReverseWords(s);
            }
            catch (ArgumentNullException ex)
            {
                throw new FaultException<ArgumentNullException>(ex,
                    "Please provide the words that is to be reversed");
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }   
        }  

        public Guid WhatIsYourToken()
        {
            return new Guid("d9bfc45c-a70f-4bf9-ae4a-32b2ce7b11c6");                                           
        }               

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            try
            {
                return Utils.GetWhatShapeIsThis(a, b, c);
            }
            catch (Exception ex)
            {
                throw new FaultException(ex.Message);
            }
        }

        //public Task<Guid> WhatIsYourTokenAsync()
        //{
        //    throw new FaultException<NotImplementedException>(
        //        new NotImplementedException());
        //}

        //public Task<string> ReverseWordsAsync(string s)
        //{
        //    throw new FaultException<NotImplementedException>(
        //        new NotImplementedException());
        //}

        //public Task<long> FibonacciNumberAsync(long n)
        //{
        //    throw new FaultException<NotImplementedException>(
        //        new NotImplementedException());
        //}

        //public Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c)
        //{
        //    throw new FaultException<NotImplementedException>(
        //        new NotImplementedException());
        //}
    }
}
