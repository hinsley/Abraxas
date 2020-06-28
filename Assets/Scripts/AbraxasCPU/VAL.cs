enum VAL : byte {
    // Note that "next word" means [PC++].
    REG_A = 0x00,
    REG_B = 0x01,
    REG_C = 0x02,
    REG_X = 0x03,
    REG_Y = 0x04,
    REG_Z = 0x05,
    REG_I = 0x06,
    REG_J = 0x07,
    ADDR_REG_A = 0x08, // [register]
    ADDR_REG_B = 0x09,
    ADDR_REG_C = 0x0a,
    ADDR_REG_X = 0x0b,
    ADDR_REG_Y = 0x0c,
    ADDR_REG_Z = 0x0d,
    ADDR_REG_I = 0x0e,
    ADDR_REG_J = 0x0f,
    ADDR_NWP_REG_A = 0x10, // [register + next word]
    ADDR_NWP_REG_B = 0x11,
    ADDR_NWP_REG_C = 0x12,
    ADDR_NWP_REG_X = 0x13,
    ADDR_NWP_REG_Y = 0x14,
    ADDR_NWP_REG_Z = 0x15,
    ADDR_NWP_REG_I = 0x16,
    ADDR_NWP_REG_J = 0x17,
    STACK = 0x18, // (PUSH / [--SP]) if in b, or (POP / [SP++]) if in a
    PEEK = 0x19, // [SP]
    PICK = 0x1a, // [SP + next word]
    SP = 0x1b,
    PC = 0x1c,
    EX = 0x1d,
    ADDR_NW = 0x1e, // [next word]
    NW = 0x1f // next word (literal)

    // Note that 0x20-0x3f are treated as literal values -1..30 if
    // in A register. Otherwise, undefined/nil behavior.
}