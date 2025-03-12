using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp1
{

    public enum FanState
    {
        Quiet,
        Balanced,
        Performance,
        Turbo
    }

    public class Fan
    {
        private FanState currentState;

        public Fan()
        {
            currentState = FanState.Quiet;
        }

        public void Quiet()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Quiet.");
                currentState = FanState.Quiet;
            }
            else if (currentState == FanState.Turbo)
            {
                Console.WriteLine("Sudah di turbo");
                currentState = FanState.Balanced;
            }
            else if (currentState == FanState.Performance)
            {
                Console.WriteLine("Udah Di performance");
            }
            else
            {
                Console.WriteLine("Ke Balanced Dulu");
            }
        }

        public void Balanced()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Jadi Balanced Mode Up");
                currentState = FanState.Balanced;
            }
            else if (currentState == FanState.Turbo)
            {
                Console.WriteLine("Sekarang Di Turbo, Down Dulu Atau Shortcut");
                currentState = FanState.Quiet;
            }
            else
            {
                Console.WriteLine("Pintu sudah tertutup.");
            }
        }

        public void Performance()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Ke balanced dulu.");
                currentState = FanState.Balanced;
            }
            else if (currentState == FanState.Balanced)
            {
                Console.WriteLine("Performance Mode up");
                currentState = FanState.Performance;
            }
            else
            {
                Console.WriteLine("Down");
            }
        }

        public void Turbo()
        {
            if (currentState == FanState.Performance)
            {
                Console.WriteLine("Turbo Mode Up");
                currentState = FanState.Turbo;
            }
            else
            {
                Console.WriteLine("sudah");
            }
        }

        public void PartiallyOpen()
        {
            if (currentState == FanState.Quiet)
            {
                Console.WriteLine("Fan Quite Jadi Turbo Shortcut");
                currentState = FanState.Turbo;
            }
            else if (currentState == FanState.Balanced)
            {
                Console.WriteLine("Pindah ke performance dulu");
                currentState = FanState.Performance;
            }
            else
            {
                Console.WriteLine("Mode Up ke performance");
            }
        }

        public void ShowState()
        {
            Console.WriteLine($"Status fan saat ini: {currentState}");
        }
    }


}