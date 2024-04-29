[StructLayout(LayoutKind.Sequential)]
public unsafe struct pointer
{
    public pointer(nint address) => Address = address;

    public nint Address;

    public byte this[nint index] => ((byte*)Address)[index];

    public override string ToString() => $"0x{Address:X}";
    public override bool Equals(object? obj) => obj is null ? false : obj is pointer ? (((pointer)obj).Address == Address) : false;
    public override int GetHashCode() => ((int)Address) ^ ((int)(Address >> 32));

    #region Operators
    [MethodImpl(AggressiveInlining)] public static pointer operator +(pointer a, pointer b) => a.Address + b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator -(pointer a, pointer b) => a.Address - b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator ++(pointer self) => self.Address++;
    [MethodImpl(AggressiveInlining)] public static pointer operator --(pointer self) => self.Address--;
    [MethodImpl(AggressiveInlining)] public static pointer operator ~(pointer self) => ~self.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator *(pointer a, pointer b) => a.Address * b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator /(pointer a, pointer b) => a.Address / b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator %(pointer a, pointer b) => a.Address % b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator &(pointer a, pointer b) => a.Address & b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator ^(pointer a, pointer b) => a.Address ^ b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator |(pointer a, pointer b) => a.Address | b.Address;
    [MethodImpl(AggressiveInlining)] public static pointer operator >>(pointer a, int shift) => a.Address >> shift;
    [MethodImpl(AggressiveInlining)] public static pointer operator <<(pointer a, int shift) => a.Address << shift;
    [MethodImpl(AggressiveInlining)] public static pointer operator >>>(pointer a, int shift) => a.Address >>> shift;
    [MethodImpl(AggressiveInlining)] public static bool operator <(pointer a, pointer b) => a.Address < b.Address;
    [MethodImpl(AggressiveInlining)] public static bool operator <=(pointer a, pointer b) => a.Address <= b.Address;
    [MethodImpl(AggressiveInlining)] public static bool operator >(pointer a, pointer b) => a.Address > b.Address;
    [MethodImpl(AggressiveInlining)] public static bool operator >=(pointer a, pointer b) => a.Address >= b.Address;
    [MethodImpl(AggressiveInlining)] public static bool operator ==(pointer a, pointer b) => a.Address == b.Address;
    [MethodImpl(AggressiveInlining)] public static bool operator !=(pointer a, pointer b) => a.Address != b.Address;
    #endregion

    #region Implicits
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(nint address) => new(address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(nuint address) => new((nint)address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(long address) => new((nint)address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(ulong address) => new((nint)address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(int address) => new(address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(uint address) => new((nint)address);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(void* pointer) => new((nint)pointer);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(void** pointer) => new((nint)pointer);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(void*** pointer) => new((nint)pointer);
    [MethodImpl(AggressiveInlining)] public static implicit operator pointer(delegate* unmanaged<void> ptr) => new((nint)ptr);
    [MethodImpl(AggressiveInlining)] public static implicit operator nint(pointer pointer) => pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator nuint(pointer pointer) => (nuint)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator long(pointer pointer) => pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator ulong(pointer pointer) => (ulong)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator void*(pointer pointer) => (void*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator void**(pointer pointer) => (void**)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator void***(pointer Sudden_Reference_To_Bocchi_The_Rock) => (void***)Sudden_Reference_To_Bocchi_The_Rock.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator byte*(pointer pointer) => (byte*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator sbyte*(pointer pointer) => (sbyte*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator short*(pointer pointer) => (short*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator ushort*(pointer pointer) => (ushort*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator int*(pointer pointer) => (int*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator uint*(pointer pointer) => (uint*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator long*(pointer pointer) => (long*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator ulong*(pointer pointer) => (ulong*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator nint*(pointer pointer) => (nint*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator nuint*(pointer pointer) => (nuint*)pointer.Address;
    [MethodImpl(AggressiveInlining)] public static implicit operator delegate* unmanaged<void>(pointer pointer) => (delegate* unmanaged<void>)pointer;
    #endregion
}