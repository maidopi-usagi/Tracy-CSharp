using bottlenoselabs.C2CS.Runtime;
using Tracy;
using static Tracy.PInvoke;

internal sealed class Program
{
    internal unsafe static void Main(string[] args)
    {
        while (true)
        {
            TracyEmitFrameMark((CString)("FrameUpdate"));
        }

        Console.WriteLine("Cleaned up and quit \n");
        return;
    }
}