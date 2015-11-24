using System;
using System.Collections.Generic;
using HQF.DotNetFramework.Common;

namespace HQF.DotNetFramework.LOH_test
{
    internal class Program
    {
        /// <summary>
        ///     Static variable used to store our 'big' block. This ensures that the block is always up for garbage collection.
        /// </summary>
        private static byte[] bigBlock;

        /// <summary>
        ///     Allocates 90,000 byte blocks, optionally intersperced with larger blocks
        /// </summary>
        private static void Fill(bool allocateBigBlocks, bool grow, bool alwaysGC)
        {
            // Number of bytes in a small block
            // 90000 bytes, just above the limit for the LOH
            const int blockSize = 90000;

            // Number of bytes in a larger block: 16Mb initially
            var largeBlockSize = 1 << 24;

            // Number of small blocks allocated
            var count = 0;

            try
            {
                // We keep the 'small' blocks around
                // (imagine an algorithm that allocates memory in chunks)
                var smallBlocks = new List<byte[]>();

                for (;;)
                {
                    // Write out some status information
                    if ((count%1000) == 0)
                    {
                        Console.CursorLeft = 0;
                        Console.Write(new string(' ', 20));
                        Console.CursorLeft = 0;
                        Console.Write("{0}", count);
                        Console.CursorLeft = 0;
                    }

                    // Force a GC if necessaryry
                    if (alwaysGC) GC.Collect();

                    // Allocate a larger block if we're set up to do soso
                    if (allocateBigBlocks)
                    {
                        bigBlock = new byte[largeBlockSize];
                    }

                    // The next 'large' block will be just slightly largerer
                    if (grow) largeBlockSize += 100;

                    // Allocate a new block
                    smallBlocks.Add(new byte[blockSize]);
                    count++;
                }
            }
            catch (OutOfMemoryException)
            {
                // Force a GC, which should empty the LOH again
                bigBlock = null;
                GC.Collect();

                // Display the results for the amount of memory we managed to allocate
                Console.WriteLine("{0}: {1}Mb allocated"
                    , (allocateBigBlocks ? "With large blocks" : "Only small blocks")
                      + (alwaysGC ? ", frequent garbage collections" : "")
                      + (grow ? "" : ", large blocks not growing")
                    , (count*blockSize)/(1024*1024));
            }
        }

        private static void Main(string[] args)
        {
            // Display results for cases both with and without the larger blocks
            //Fill(true, true, false);
            //Fill(true, true, true);
            //Fill(false, true, false);
            //Fill(true, false, false);

            CodeTimer.Time("Fill(true, true, false)", 1, () => { Fill(true, true, false); });
            CodeTimer.Time("Fill(false, true, false)", 1, () => { Fill(false, true, false); });
            CodeTimer.Time("Fill(true, false, false)", 1, () => { Fill(true, false, false); });
            CodeTimer.Time("Fill(true, true, true)", 1, () => { Fill(true, true, true); });

            Console.ReadLine();
        }
    }
}