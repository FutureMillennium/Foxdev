﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foxasm
{
	public enum Registers
	{
		None,

		// registers:
		// 8-bit:
		Al, Cl, Dl, Bl,
		Ah, Ch, Dh, Bh,
		// 16-bit:
		Ax, Cx, Dx, Bx, Sp, Bp, Si, Di,
		// 32-bit:
		Eax, Ecx, Edx, Ebx, Esp, Ebp, Esi, Edi,
	}

	enum Instructions
	{
		// Rm: mod-reg-R/M
		// R: register
		// S: segment register (FS, GS, CS, SS, DS, ES)
		// Imm: immediate value
		// B: byte, 8 bits
		// W: word – 2 bytes, 16 bits
		// L: long – 4 bytes, 32 bits
		// Q: quadword – 8 bytes, 64 bits
		Cli, Sti, Hlt,

		Call, CallL,
		Jmp, JmpB, JmpW, JmpL,
		Mov, MovB, MovW, MovL,
		Push, PushW, PushL,
		Pop, PopW, PopL,
		CmpB,
		Inc,
		Ret,
		Int,
		Je, Jne,
		LodsB,
	}

	enum Placeholders : UInt32
	{
		Label = 0xFEED1AFE,
		String = 0xFEED57FE,
		Variable = 0xFEED5AFE,
	}

	enum ModRegRM : byte
	{
		RRMem = 0b00_000_000,
		ROffset1RMem = 0b01_000_000,
		ROffset4RMem = 0b10_000_000,
		RToR = 0b11_000_000,
		RMemImm = 0b00_000_101, // 00 xxx 101 – Displacement-Only Mode
	}
}
