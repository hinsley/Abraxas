class AbraxasCPU
{
    CPUFlags flags;
    CPURegistry registry;
    RAM memory;
    
    public void Step()
    {

    }

    void CreateRAM(ushort size)
    {
        memory = new RAM(size);
    }
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

struct CPUFlags
{
    // Sign flag register.
    public bool s;
    // Zero flag register.
    public bool z;
    // Parity flag register.
    public bool p;
    // Carry flag register.
    public bool c;
    // Auxiliary Carry flag register -- used for Binary-Coded Decimal arithmetic (BCD).
    public bool h;
}

struct RAM
{
    public byte[] value;

    public RAM(ushort size)
    {
        value = new byte[size];
    }
}

struct Register8Bit
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public byte value;
}

struct Register16Bit
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public short value;
}
