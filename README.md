Practice: Iterating over planets
Now we'll combine Dictionaries with the Lists we learned in the previous chapter.

Instructions
Ref: List of Solar System probes

Use the list of planets you created in the previous chapter or create a new one with all eight planets.

List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", ...};
Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.

List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.

foreach () // iterate planets
{
    List<string> matchingProbes = new List<string>();

    foreach() // iterate probes
    {
        /*
            Does the current Dictionary contain the key of
            the current planet? Investigate the ContainsKey()
            method on a Dictionary.

            If so, add the current spacecraft to `matchingProbes`.
        */
    }

    /*
        Use String.Join(",", matchingProbes) as part of the
        solution to get the output below. It's the C# way of
        writing `array.join(",")` in JavaScript.
    */
    Console.WriteLine($"{}: {}");
}
Example Output in the Terminal
Mars: Viking, Opportunity, Curiosity
Venus: Mariner, Venera