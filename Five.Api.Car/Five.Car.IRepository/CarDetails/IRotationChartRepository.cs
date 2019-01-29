using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Five.Car.Model;

namespace Five.Car.IRepository
{
    public interface IRotationChartRepository
    {
        List<Rotationchart> ShowRotationchart();
    }
}
