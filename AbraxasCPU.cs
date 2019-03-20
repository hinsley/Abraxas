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
    public Register a;
    public Register b;
    public Register c;
    public Register x;
    public Register y;
    public Register z;
    public Register i;
    public Register j;
    // Program counter register.
    public Register pc;
    // Stack pointer register.
    public Register sp;
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

struct Register
{
    // 8-bit identifier via which the register is addressed in CPU instructions.
    public byte identifier;
    public byte value;
}
