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

[StructLayout(LayoutKind.Auto)]
public readonly struct Vector3Auto
{
    private readonly int x;
    private readonly int y;
    private readonly int z;

    public Vector3Auto(int x, int y, int z) =>
        (this.x, this.y, this.z) = (x, y, z);

    public override string ToString() =>
        $"{nameof(Vector3Auto)}\nX: {x}\nY: {y}\nZ: {z}\n";
}