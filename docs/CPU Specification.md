# CPU Specification

## Components

### Registers
| Abbreviation | Name | Type | Description |
| - | - | - | - |
| S | Sign | Flag | Set if the result is negative. |
| Z | Zero | Flag | Set if the result is negative. |
| P | Parity | Flag | Set if the number of 1 bits in the result is even. |
| C | Carry | Flag | Set if the last addition operation resulted in a carry or if the last subtraction operation required a borrow. |
| AC/H | Auxiliary Carry | Flag | Used for Binary-Coded Decimal arithmetic. (BCD) |

## References

### Inspirations

- [Intel 8080](https://en.wikipedia.org/wiki/Intel_8080)
- [Zilog Z80](https://en.wikipedia.org/wiki/Zilog_Z80)
- [DCPU-16](https://gist.github.com/metaphox/3888117)
