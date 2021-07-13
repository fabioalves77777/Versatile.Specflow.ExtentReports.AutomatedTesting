using NUnit.Framework;
using System;
using Versatile.Specflow.ExtentReports.CryptoEngine.CryptoEngine;

namespace Versatile.Specflow.ExtentReports.CryptoEngine
{
    public class Run
    {

        [Test]
        public void Encrypt() 
            => Console.WriteLine(Crypto.Encrypt("jdb6efayuqypvoavezcdwwmxkouj2hqy4da3s7thefgx2vi4gedq", "Cybernetics CRM 4.0 Word Addin"));

    }
}
