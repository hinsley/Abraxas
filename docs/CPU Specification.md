# CPU Specification

## Components

### Registers
| Abbreviation | Name | Type | Size (bits) | Description |
| - | - | - | - | - |
| S | Sign | Flag | 1 | Set if the result is negative. |
| Z | Zero | Flag | 1 | Set if the result is negative. |
| P | Parity | Flag | 1 | Set if the number of 1 bits in the result is even. |
| AC/H | Auxiliary Carry | Flag | 1 | Used for Binary-Coded Decimal arithmetic. (BCD) |
| A | Accumulator | Register | 8 | Accumulator register. |
| B | Register B | Register | 8 | Register B. |
| C | Register C | Register | 8 | Register C. |
| X | Register X | Register | 8 | Register X. |
| Y | Register Y | Register | 8 | Register Y. |
| Z | Register Z | Register | 8 | Register Z. |
| I | Register I | Register | 8 | Register I. |
| J | Register J | Register | 8 | Register J. |
| EX | Extra/Excess | Register | 16 | Used in mathematical operations to store excesses in overflows. |
| PC | Program Counter | Register | 16 | Points to current location of program execution in memory. |
| SP | Stack Pointer | Register | 16 | Points to current location of top of stack in memory. |

### Instructions

| Value | Name | Description |
| - | - | - |
| `0x01` | `SET b, a` | Sets `b` to `a`. |
| `0x02` | `ADD b, a` | Sets `b` to `b+a`, sets `EX` to `0x0001` if there is an overflow, `0x0` otherwise. |
| `0x03` | `SUB b, a` | Sets `b` to `b-a`, sets `EX` to `0xFFFF` if there is an underflow, `0x0` otherwise. |
| `0x04` | `MUL b, a` | Sets `b` to `b*a`, sets `EX` to `((b*a)>>16)&0xFFFF` (treats `b`, `a` as unsigned). |
| `0x05` | `MLI b, a` | Sets `b` to `b*a`, sets `EX` to `((b*a)>>16)&0xFFFF` (treats `b`, `a` as signed). |

## References

### Inspirations

- [Intel 8080](https://en.wikipedia.org/wiki/Intel_8080)
- [Zilog Z80](https://en.wikipedia.org/wiki/Zilog_Z80)
- [DCPU-16](https://gist.github.com/metaphox/3888117)
