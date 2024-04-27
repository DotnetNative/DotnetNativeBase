﻿[StructLayout(LayoutKind.Sequential)]
public unsafe struct pointer
{
    public pointer(nint address) => Address = address;

    public nint Address;

    public static implicit operator pointer(nint address) => new(address);
    public static implicit operator pointer(void* pointer) => new((nint)pointer);
    public static implicit operator pointer(void** pointer) => new((nint)pointer);
    public static implicit operator pointer(void*** pointer) => new((nint)pointer);
    public static implicit operator pointer(delegate* unmanaged<void> ptr) => new((nint)ptr);

    public static implicit operator nint(pointer pointer) => pointer.Address;

    public static implicit operator void*(pointer pointer) => (void*)pointer.Address;
    public static implicit operator void**(pointer pointer) => (void**)pointer.Address;
    public static implicit operator void***(pointer Sudden_Reference_To_Bocchi_The_Rock) => (void***)Sudden_Reference_To_Bocchi_The_Rock.Address;

    public static implicit operator byte*(pointer pointer) => (byte*)pointer.Address;
    public static implicit operator sbyte*(pointer pointer) => (sbyte*)pointer.Address;
    public static implicit operator short*(pointer pointer) => (short*)pointer.Address;
    public static implicit operator ushort*(pointer pointer) => (ushort*)pointer.Address;
    public static implicit operator int*(pointer pointer) => (int*)pointer.Address;
    public static implicit operator uint*(pointer pointer) => (uint*)pointer.Address;
    public static implicit operator long*(pointer pointer) => (long*)pointer.Address;
    public static implicit operator ulong*(pointer pointer) => (ulong*)pointer.Address;
    public static implicit operator nint*(pointer pointer) => (nint*)pointer.Address;
    public static implicit operator nuint*(pointer pointer) => (nuint*)pointer.Address;

    public static implicit operator delegate* unmanaged<void>(pointer pointer) => (delegate* unmanaged<void>)pointer;

    public override string ToString() => $"0x{Address:X}";
}