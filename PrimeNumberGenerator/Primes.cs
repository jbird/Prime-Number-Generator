/**
 * Primes.cs
 * Copyright(c) 2008-2009 John Bird.
 * Date(last modified): 24 October, 2009.
 * 
 * A Generic class for various prime number related operations
 * such as generating small prime lists, large pseudorandom prime numbers
 * and testing primality.
 * 
 * Uses Bouncy Castle BigInteger class.
 */

using System;
using System.ComponentModel;
using System.Text;
using System.Collections;
using System.Security.Cryptography;
using Org.BouncyCastle.Math;

namespace PrimeNumberGenerator {
    /**
     * <summary>A Prime Number Generator Utility.</summary>
     */
    class Primes {
        private static uint primeCount;

        static Primes() { }

        /**
         * <summary>Gets or sets the number of prime numbers generated in a list.</summary> 
         */
        public static uint PrimeCount {
            get { return primeCount; }
            set { primeCount = value; }
        }

        /**
         * <summary>Resets the prime number counter to zero.</summary> 
         */
        public void ResetPrimeCount() { primeCount = 0; }

        /**
         * <summary>Generates a string list of prime numbers from 2 to the specified limit.</summary>
         * <param name="limit">The upper limit(the range of numbers to search).</param>
         * <returns>A string list of prime numbers up to the limit specified.</returns>
         */
        public static string GeneratePrimeList(int limit) {
            // Sieve of Eratosthenes
            BitArray b = new BitArray(limit + 1, true);
            StringBuilder primeResult = new StringBuilder();

            for(int i = 2; i * i <= limit; i++) {
                for(int j = i; i * j <= limit; j++) {
                    b.Set(i * j, false);
                }
            }

            primeCount = 0;
            for(int k = 2; k < limit; k++) {
                if(b.Get(k)) {
                    primeResult.Append(k + ", ");
                    primeCount++;
                }
            }
            primeResult.Remove(primeResult.Length - 2, 2);
            return primeResult.ToString();
        }

        /**
         * <summary>Generates a large pseudorandom prime number to the given specified bit length.</summary>
         * <param name="bits">The size of the large pseudorandom prime number to be generated in bits.</param>
         * <returns>A large pseudorandom prime number to the specified amount in bits.</returns>
         */
        public static string GenerateLargePseudoPrime(int bits, BackgroundWorker bw) {
            byte[] seed = new byte[32];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(seed);
            rng = null;
            return BigInteger.ProbablePrime(bits, new Random(BitConverter.ToInt32(seed, 0))).ToString();
        }

        /**
         * <summary>Tests whether a given string number is a prime number.</summary>
         * <param name="value">The string number to test if it is prime.</param>
         * <returns>Returns true if the string given value is prime else returns false.</returns>
         */
        public static bool IsPrime(string value, BackgroundWorker bw) {
            BigInteger b = new BigInteger(value);
            return b.IsProbablePrime(64);
        }
    }
}
