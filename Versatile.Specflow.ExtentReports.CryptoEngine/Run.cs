using NUnit.Framework;
using System;
using Versatile.Specflow.ExtentReports.CryptoEngine.CryptoEngine;

namespace Versatile.Specflow.ExtentReports.CryptoEngine
{
    public class Run
    {

        [Test]
        public void Encrypt() 
            => Console.WriteLine(Crypto.Encrypt("rjk3qmn2qdy4w4asbjyzhnxhho5ub3xpx6puqe2nmulud4ajnvkq", "Cybernetics CRM 4.0 Word Addin"));

    }
}
