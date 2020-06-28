using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Computer : MonoBehaviour
{
    public uint memorySize = 0x10000; // Words

    private ushort[] memory;
    private ushort reg_A = 0x0000;
    private ushort reg_B = 0x0000;
    private ushort reg_C = 0x0000;
    private ushort reg_X = 0x0000;
    private ushort reg_Y = 0x0000;
    private ushort reg_Z = 0x0000;
    private ushort reg_I = 0x0000;
    private ushort reg_J = 0x0000;

    private ushort reg_PC = 0x0000;
    private ushort reg_SP;

    private ushort reg_EX = 0x0000;
    private ushort reg_IA = 0x0000;

    ushort ReadVal(bool a, VAL val)
    {
        switch (val) {
        case VAL.REG_A:
            return reg_A;
        case VAL.REG_B:
            return reg_B;
        case VAL.REG_C:
            return reg_C;
        case VAL.REG_X:
            return reg_X;
        case VAL.REG_Y:
            return reg_Y;
        case VAL.REG_Z:
            return reg_Z;
        case VAL.REG_I:
            return reg_I;
        case VAL.REG_J:
            return reg_J;
        case VAL.ADDR_REG_A:
            return memory[reg_A];
        case VAL.ADDR_REG_B:
            return memory[reg_B];
        case VAL.ADDR_REG_C:
            return memory[reg_C];
        case VAL.ADDR_REG_X:
            return memory[reg_X];
        case VAL.ADDR_REG_Y:
            return memory[reg_Y];
        case VAL.ADDR_REG_Z:
            return memory[reg_Z];
        case VAL.ADDR_REG_I:
            return memory[reg_I];
        case VAL.ADDR_REG_J:
            return memory[reg_J];
        case VAL.ADDR_NWP_REG_A:
            // TODO: Add error handling.
            return memory[reg_A + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_B:
            return memory[reg_B + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_C:
            return memory[reg_C + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_X:
            return memory[reg_X + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_Y:
            return memory[reg_Y + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_Z:
            return memory[reg_Z + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_I:
            return memory[reg_I + memory[reg_PC++]];
        case VAL.ADDR_NWP_REG_J:
            return memory[reg_J + memory[reg_PC++]];
        case VAL.STACK:
            if (a) {
                return memory[reg_SP++]; // POP
            } else {
                return memory[--reg_SP]; // PUSH
            }
        default:
            // This should never occur.
            return 0;
        }
    }

    void OpSET(VAL a, VAL b)
    {
        
    }

    void Step()
    {
        bool specialOp = false;

        // Non-special instructions: 0bAAAAAABBBBBOOOOO
        // Special instructions:     0bAAAAAAOOOOO00000

        ushort instruction = memory[reg_PC++];
        byte opcode = (byte)(instruction & 0b0000000000011111);
        VAL a = (VAL)((instruction & 0b1111110000000000) >> 10);
        VAL b = (VAL)((instruction & 0b0000001111100000) >> 5);

        if (opcode != (byte)OP.SPECIAL) {
            switch ((OP)opcode) {
            case OP.SET:
                OpSET(a, b);
                break;
            case OP.ADD:
                break;
            case OP.SUB:
                break;
            case OP.MUL:
                break;
            case OP.MLI:
                break;
            case OP.DIV:
                break;
            case OP.DVI:
                break;
            case OP.MOD:
                break;
            case OP.MDI:
                break;
            case OP.AND:
                break;
            case OP.BOR:
                break;
            case OP.XOR:
                break;
            case OP.SHR:
                break;
            case OP.ASR:
                break;
            case OP.SHL:
                break;
            case OP.IFB:
                break;
            case OP.IFC:
                break;
            case OP.IFE:
                break;
            case OP.IFN:
                break;
            case OP.IFG:
                break;
            case OP.IFA:
                break;
            case OP.IFL:
                break;
            case OP.IFU:
                break;
            case OP.ADX:
                break;
            case OP.SBX:
                break;
            case OP.STI:
                break;
            case OP.STD:
                break;
            default:
                // You wrote some buggy code most probably.
                break;
            }
        } else {
            opcode = (byte)b;
            switch ((OPSPECIAL)opcode) {
            case OPSPECIAL.JSR:
                break;
            case OPSPECIAL.INT:
                break;
            case OPSPECIAL.IAG:
                break;
            case OPSPECIAL.RFI:
                break;
            case OPSPECIAL.IAQ:
                break;
            case OPSPECIAL.HWN:
                break;
            case OPSPECIAL.HWQ:
                break;
            case OPSPECIAL.HWI:
                break;
            default:
                // Again, probably some bugged code.
                break;
            }
        }
    }

    void Start()
    {
        this.memory = new ushort[memorySize];
        this.reg_PC = 0;
        this.reg_SP = (ushort)(memorySize - 1);
        memory[0] = 0b0000001111100000;
        this.Step();
    }

    void Update()
    {
        if (Input.GetKeyDown("space")) {
            Debug.Log(memory[0]);
        }
    }
}
