using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FragmentTutorial
{
    class FinancialNews
    {
        public static string[] Headlines =
            {
                "GOOG",
                "AMZN",
                "MSFT",
                "FB",
                "AAPL",
                "NFLX"
            };

        public static string[] Stories =
            {
                "Google CEO arrested after starting a fist fight with Mark Zuckerberg. Zuckerberg. Zuckerberg is not expected to survive.",
                "Amazon's Jeff Bezos found dead in delivery truck. Being a prime member, his body will arrive at the funeral in no more than two days.",
                "Microsoft's CEO, Adnan Zejnilovic, terminates Visual Studio. Stock prices skyrocket.",
                "Facebook now overtaken by Myspace.",
                "Apple disbands, bows down to Linus Torvalds and Richard Stallman.",
                "Netflix adds hundreds of new shows and movies, but none of them good."
            };
    }
}