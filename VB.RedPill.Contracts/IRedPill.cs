namespace VB.RedPill.Contracts
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace = "http://KnockKnock.readify.net",
        ConfigurationName = "VB.RedPill.Contracts.IRedPill")]
    public interface IRedPill
    {
        [System.ServiceModel.OperationContractAttribute(Name = "WhatIsYourToken",
            Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourToken",
            ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenResponse")]
        System.Guid WhatIsYourToken();  

        [System.ServiceModel.OperationContractAttribute(Name = "FibonacciNumber",
            Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumber",
            ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentOutOfRangeException),
            Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberArgumentOutOfRangeException" +
                     "Fault", Name = "ArgumentOutOfRangeException",
            Namespace = "http://schemas.datacontract.org/2004/07/System")]
        long FibonacciNumber(long n); 

        [System.ServiceModel.OperationContractAttribute(Name = "WhatShapeIsThis",
            Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThis",
            ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisResponse")]
        TriangleType WhatShapeIsThis(int a, int b, int c); 

        [System.ServiceModel.OperationContractAttribute(Name = "ReverseWords",
            Action = "http://KnockKnock.readify.net/IRedPill/ReverseWords",
            ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.ArgumentNullException),
            Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsArgumentNullExceptionFault",
            Name = "ArgumentNullException", Namespace = "http://schemas.datacontract.org/2004/07/System")]
        string ReverseWords(string s);

        //[System.ServiceModel.OperationContractAttribute(Name = "FibonacciNumberAsync",
        //    Action = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberAsync",
        //    ReplyAction = "http://KnockKnock.readify.net/IRedPill/FibonacciNumberAsyncResponse")]
        //System.Threading.Tasks.Task<long> FibonacciNumberAsync(long n);

        //[System.ServiceModel.OperationContractAttribute(Name = "WhatShapeIsThisAsync",
        //   Action = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisAsync",
        //   ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatShapeIsThisAsyncResponse")]
        //System.Threading.Tasks.Task<TriangleType> WhatShapeIsThisAsync(int a, int b, int c);

        //[System.ServiceModel.OperationContractAttribute(Name = "WhatIsYourTokenAsync",
        //    Action = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenAsync",
        //    ReplyAction = "http://KnockKnock.readify.net/IRedPill/WhatIsYourTokenAsyncResponse")]
        //System.Threading.Tasks.Task<System.Guid> WhatIsYourTokenAsync();

        //[System.ServiceModel.OperationContractAttribute(Name = "ReverseWordsAsync",
        //    Action = "http://KnockKnock.readify.net/IRedPill/ReverseWordsAsync",
        //    ReplyAction = "http://KnockKnock.readify.net/IRedPill/ReverseWordsAsyncResponse")]
        //System.Threading.Tasks.Task<string> ReverseWordsAsync(string s);
    }
}

