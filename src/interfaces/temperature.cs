using System;
using System.Threading.Tasks;
using Orleans;

namespace Interfaces {

    public interface ITemperature : IGrainWithStringKey
    {
        Task Store(float temperatures);
    }    
}