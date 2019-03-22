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
        ExecuteInstruction(registry.sp.value++);
    }

    void ExecuteInstruction(ushort instructionLocation)
    {
        switch (GetRAMValue(instructionLocation))
        {
            case 0x01: // SET b, a
                break;
            case 0x02: // ADD b, a
                break;
            case 0x03: // SUB b, a
                break;
            case 0x04: // MUL b, a
                break;
            case 0x05: // MLI b, a
                break;
        }
    }

    byte GetRAMValue(ushort address)
    {
        return memory.value[address];
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
    // Excess register.
    public Register16Bit ex;
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
