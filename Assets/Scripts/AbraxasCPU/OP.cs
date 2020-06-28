enum OP : byte
{
    SPECIAL = 0x00,
    SET = 0x01,
    ADD = 0x02,
    SUB = 0x03,
    MUL = 0x04,
    MLI = 0x05,
    DIV = 0x06,
    DVI = 0x07,
    MOD = 0x08,
    MDI = 0x09,
    AND = 0x0a,
    BOR = 0x0b,
    XOR = 0x0c,
    SHR = 0x0d,
    ASR = 0x0e,
    SHL = 0x0f,
    IFB = 0x10,
    IFC = 0x11,
    IFE = 0x12,
    IFN = 0x13,
    IFG = 0x14,
    IFA = 0x15,
    IFL = 0x16,
    IFU = 0x17,
    // 0x18 is unreserved.
    // 0x19 is unreserved.
    ADX = 0x1a,
    SBX = 0x1b,
    // 0x1c is unreserved.
    // 0x1d is unreserved.
    STI = 0x1e,
    STD = 0x1f
}