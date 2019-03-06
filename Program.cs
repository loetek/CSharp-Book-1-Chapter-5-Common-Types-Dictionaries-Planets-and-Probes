using System;
using System.Collections.Generic;

namespace Planets_Dictionary
{
    class Program
    {


        static void PrintDictionary(Dictionary<string, string> dict){
            foreach(KeyValuePair<string, string> kvp in dict){
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void Main(string[] args)
        {
            // 1. Use the list of planets you created in the previous chapter or create a new one with all eight planets.
            //!!List of planets in the solar system.
            List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter","Saturn","Uranus","Neptune"};

            //2. Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched,
            // and the name of the planet that it has visited. If it visited more than one planet, just pick one.

            //!! List of dictionaries that are probes sent to visit key is planet value is probe.
            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();

            probes.Add (new Dictionary<string, string>(){ {"Mercury", "Messenger"} });
            probes.Add (new Dictionary<string, string>(){ {"Venus", "Vega 2"} });
            probes.Add (new Dictionary<string, string>(){ {"Earth", "Sputnik"} });
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Insight"}});
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Beagle"}});
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Maven"}});
            probes.Add (new Dictionary<string, string>(){ {"Mars", "Curiosity"}});
            probes.Add (new Dictionary<string, string>(){ {"Jupiter", "Galileo"}});
            probes.Add (new Dictionary<string, string>(){ {"Saturn", "Cassini"}});
            probes.Add (new Dictionary<string, string>(){ {"Saturn", "Juno"}});
            probes.Add (new Dictionary<string, string>(){ {"Saturn", "Europa Clipper"}});
            probes.Add (new Dictionary<string, string>(){ {"Uranus", "New Horizons"}});
            probes.Add (new Dictionary<string, string>(){ {"Neptune", "Voyager 2"}});

            //Console.WriteLine("PlanetList");
            Console.WriteLine("+++++++++++++++++++++++++++");
            //planetList.ForEach(planets => Console.WriteLine(planets));
            Console.WriteLine("+++++++++++++++++++++++++++");

            //Console.WriteLine("Probes");
            Console.WriteLine("+++++++++++++++++++++++++++");
            foreach(Dictionary<string, string>probe in probes){
                foreach(KeyValuePair<string,string> kvp in probe){
                    Console.WriteLine(kvp);
                }
            };
            Console.WriteLine("+++++++++++++++++++++++++++");





            //3. Iterate over planetList, and inside that loop, iterate over the list of dictionaries.
            //Write to the console, for each planet, which satellites have visited which planet.
            foreach (string planet in planetList) // iterate planets
        {
             List<string> matchingProbes = new List<string>();

                foreach(Dictionary<string, string> probe in probes) // iterate probes
            {
                foreach(KeyValuePair<string,string> kvp in probe){
                    Console.WriteLine("(<(<>(<>.(<>..<>).<>)<>)>)");
                    //Console.WriteLine(kvp.Value);
                    Console.WriteLine("╭∩╮(Ο_Ο)╭∩╮");
                    //Console.WriteLine(planet);

                        /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey()
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                        */
                    if(planet == kvp.Key){
                        matchingProbes.Add(kvp.Value);
                    }


                    }
                 }

                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
                }

        }
    }
}



