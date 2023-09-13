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

using System.Runtime.InteropServices;

namespace RimuruDev;

[StructLayout(LayoutKind.Explicit)]
public readonly struct Vector3Explicit
{
    [FieldOffset(0)] private readonly int x;
    [FieldOffset(0)] private readonly int y;
    [FieldOffset(0)] private readonly int z;

    public Vector3Explicit(int x, int y, int z) =>
        (this.x, this.y, this.z) = (x, y, z);

    public override string ToString() =>
        $"{nameof(Vector3Explicit)}\nX: {x}\nY: {y}\nZ: {z}\n";
}