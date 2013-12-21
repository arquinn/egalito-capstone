/* Capstone Disassembler Engine */
/* By Dang Hoang Vu <danghvu@gmail.com> 2013 */

#ifndef __X86_INCLUDE_H__
#define __X86_INCLUDE_H__

#include "X86Disassembler.h"
#include "X86InstPrinter.h"
#include "mapping.h"

static void init_x86(cs_struct *ud)
{
	// by default, we use Intel syntax
	ud->printer = X86_Intel_printInst;
	ud->printer_info = NULL;
	ud->disasm = X86_getInstruction;
	ud->reg_name = X86_reg_name;
	ud->insn_id = X86_get_insn_id;
	ud->insn_name = X86_insn_name;
	ud->post_printer = X86_post_printer;
}

static cs_err option_x86(cs_struct *handle, cs_opt_type type, size_t value)
{
	if (type == CS_OPT_SYNTAX) {
		switch(value) {
			default:
				// wrong syntax value
				handle->errnum = CS_ERR_OPTION;
				return CS_ERR_OPTION;

			case CS_OPT_SYNTAX_INTEL:
				handle->printer = X86_Intel_printInst;
				break;

			case CS_OPT_SYNTAX_ATT:
				handle->printer = X86_ATT_printInst;
				break;
		}
	}
	return CS_ERR_OK;
}

static void __attribute__ ((constructor)) __init_x86__()
{
	init_arch[CS_ARCH_X86] = init_x86;
	option_arch[CS_ARCH_X86] = option_x86;
}

#endif