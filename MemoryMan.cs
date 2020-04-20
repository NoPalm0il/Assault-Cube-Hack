using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;

namespace Assault_Cube_Hack
{
    [SuppressUnmanagedCodeSecurity]
    class MemoryMan
    {
        [DllImport("ntdll")]
        private static extern bool NtReadVirtualMemory(
            IntPtr ProcessHandle,
            IntPtr BaseAddress,
            byte[] Buffer,
            int NumberOfBytesToRead,
            int NumberOfBytesRead);

        [DllImport("ntdll")]
        private static extern bool NtWriteVirtualMemory(
            IntPtr ProcessHandle,
            IntPtr BaseAddress,
            byte[] Buffer,
            int NumberOfBytesToWrite,
            int NumberOfBytesWritten);

        private readonly IntPtr processHandle; 

        public MemoryMan(IntPtr processHandle) => this.processHandle = processHandle;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe T Read<T>(IntPtr address) where T : struct
        {
            byte[] buffer = new byte[Unsafe.SizeOf<T>()];

            NtReadVirtualMemory(processHandle, address, buffer, buffer.Length, 0);

            fixed (byte* b = buffer)
                return Unsafe.Read<T>(b);
        }

        public unsafe bool Write<T>(IntPtr address, T value) where T : struct
        {
            byte[] buffer = new byte[Unsafe.SizeOf<T>()];

            fixed (byte* b = buffer)
                Unsafe.Write<T>(b, value);

            return NtWriteVirtualMemory(processHandle, address, buffer, buffer.Length, 0);
        }
    }
}
