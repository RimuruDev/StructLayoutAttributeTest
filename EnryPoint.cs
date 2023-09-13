// **************************************************************** //
//
//   Copyright (c) RimuruDev. All rights reserved.
//   Contact me: 
//          - Gmail:    rimuru.dev@gmail.com
//          - GitHub:   https://github.com/RimuruDev
//          - LinkedIn: https://www.linkedin.com/in/rimuru/
//          - GitHub Organizations: https://github.com/Rimuru-Dev
//
// **************************************************************** //

namespace RimuruDev;

using static Console;

public sealed class EnryPoint
{
    public static void Main()
    {
        var vector3Explicit = new Vector3Explicit(x: 10, y: 20, z: 30);
        WriteLine($"{vector3Explicit}");   // Output: x = 30, y = 30, z = 30 -> The location of fields in the stack and their offsets are specified manually.

        var vector3Auto = new Vector3Auto(x: 10, y: 20, z: 30);
        WriteLine($"{vector3Auto}");       // Output: x = 10, y = 20, z = 30 -> The CLR itself will decide how best to arrange the fields on the stack.

        var vector3Sequential = new Vector3Sequential(x: 10, y: 20, z: 30);
        WriteLine($"{vector3Sequential}"); // Output: x = 30, y = 30, z = 30 -> The arrangement of fields in the stack is strictly hierarchical.

        // Full output in Console:
        {
            // Vector3Explicit
            // X: 30
            // Y: 30
            // Z: 30

            // Vector3Auto
            // X: 10
            // Y: 20
            // Z: 30

            // Vector3Sequential
            // X: 10
            // Y: 20
            // Z: 30
        }
    }
}