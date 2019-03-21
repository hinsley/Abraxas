class AbraxasCPU
{
    CPUFlags flags;
    CPURegistry registry;
    RAM memory;

    public AbraxasCPU(ushort ram_size)
    {
        flags = new CPUFlags();
        memory = new RAM(size);
        registry = new CPURegistry();
    }

    public void Step()
    {

    }
}

struct CPUFlags
{
    // Sign flag register.
    public Register1Bit s;
    // Zero flag register.
    public Register1Bit z;
    // Parity flag register.
    public Register1Bit p;
    // Carry flag register.
    public Register1Bit c;
    // Auxiliary Carry flag register -- used for Binary-Coded Decimal arithmetic (BCD).
    public Register1Bit h;
}

struct CPURegistry
{
    // Accumulator register.
    public Register8Bit a;
    public Register8Bit b;
    public Register8Bit c;
    public Register8Bit x;
    public Register8Bit y;
    public Register8Bit z;
    public Register8Bit i;
    public Register8Bit j;
    // Program counter register.
    public Register16Bit pc;
    // Stack pointer register.
    public Register16Bit sp;
}

struct RAM
{
    public byte[] value;

    public RAM(ushort size)
    {
        value = new byte[size];
    }
}

struct Register1Bit
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public bool value;

    public Register1Bit()
    {
        value = false;
    }
}

struct Register8Bit
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public byte value;

    public Register8Bit()
    {
        value = 0x00;
    }
}

struct Register16Bit
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public short value;

    public Register16Bit()
    {
        value = 0x0000;
    }
}
