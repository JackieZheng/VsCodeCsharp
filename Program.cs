/**************************************
 * Program.cs
 **************************************/
using System;

namespace ClsHelper {
    class Program {
        static void Main (string[] args) {
            A aa = new A ();
            aa.a1 = "aa_a1";

            var bb = ClsHelper.CopyFromParent<A, B> (aa);
            bb.b1 = "bb_b1";
            Console.WriteLine (bb.a1);

            bb.a1 = "bb_a1";
            aa = ClsHelper.CopyToParent<A, B> (bb);
            Console.WriteLine (aa.a1);
        }
    }
}