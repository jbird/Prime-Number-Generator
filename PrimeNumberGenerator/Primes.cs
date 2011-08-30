/*
 * Prime Number Generator - A prime number generator utility.
 * Copyright (C) 2008-2011 John Bird <https://github.com/jbird/Prime-Number-Generator>
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
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
    public static class Primes {

        /**
         * <summary>Gets or sets the number of prime numbers generated in a list.</summary> 
         */
        public static uint PrimeCount { get; set; }

        /**
         * <summary>Resets the prime number counter to zero.</summary> 
         */
        public static void ResetPrimeCount() { PrimeCount = 0; }

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

            PrimeCount = 0;
            for(int k = 2; k < limit; k++) {
                if(b.Get(k)) {
                    primeResult.Append(k + ", ");
                    PrimeCount++;
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
