using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow0 = new Workflow(new Keles());
            var workflow1 = new Workflow(new Fogmosas());
            var workflow2 = new Workflow(new Reggelizes());
            var workflow3 = new Workflow(new NapInditasa());
            workflow0.Run();
            workflow1.Run();
            workflow2.Run();
            workflow3.Run();
        }
    }
}
