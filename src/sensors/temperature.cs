
using System;
using System.Threading.Tasks;
using Orleans;
using Interfaces;

namespace Sensors {

    public class Temperature : Grain, 
                               ITemperature {
        public Task Store(float temperatures) {
            Console.WriteLine("hello world");
            return Task.CompletedTask;
        }
    }    
}