/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

namespace Generator.Enums.Formatter.Gas {
	[Enum(nameof(CtorKind), "GasCtorKind")]
	enum CtorKind {
		Previous,
		Normal_1,
		Normal_2a,
		Normal_2b,
		Normal_2c,
		Normal_3,
		AamAad,
		asz,
		bnd2_2,
		bnd2_3,
		DeclareData,
		er_2,
		er_4,
		far,
		imul,
		maskmovq,
		movabs,
		nop,
		OpSize,
		OpSize2_bnd,
		OpSize3,
		os_A,
		os_B,
		os_bnd,
		CC_1,
		CC_2,
		CC_3,
		os_jcc_1,
		os_jcc_2,
		os_jcc_3,
		os_loopcc,
		os_loop,
		os_mem,
		os_mem_reg16,
		os_mem2,
		os2_3,
		os2_4,
		os2_bnd,
		pblendvb,
		pclmulqdq,
		pops,
		Reg16,
		Reg32,
		sae,
		sae_pops,
		ST_STi,
		STi_ST,
		STi_ST2,
		STIG_1a,
		STIG_1b,
	}
}
