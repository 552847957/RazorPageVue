using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;

namespace RazorPageVue.Pages
{
    public class VueIntegerInputSysErrModel : PageModel
    {
        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            // �͈͖��w��̊e�^�C�v�̐��l
            public sbyte? normalSbyte { get; set; }
            public byte? normalByte { get; set; }
            public short? normalShort { get; set; }
            public ushort? normalUshort { get; set; }
            public int? normalInt { get; set; }
            public uint? normalUint { get; set; }
            public long? normalLong { get; set; }
            public ulong? normalUlong { get; set; }

            // ����͈͂̊e�^�C�v�̐��l
            [Range(Min = -128, Max =127)]
            public sbyte? normalRangeSbyte { get; set; }
            [Range(Min = 0, Max = 255)]
            public byte? normalRangeByte { get; set; }
            [Range(Min = -32768, Max = 32767)]
            public short? normalRangeShort { get; set; }
            [Range(Min = 0, Max = 65535)]
            public ushort? normalRangeUshort { get; set; }
            [Range(Min = -2147483648, Max = 2147483647)]
            public int? normalRangeInt { get; set; }
            [Range(Min = 0, Max = 4294967295)]
            public uint? normalRangeUint { get; set; }
            [Range(Min = -9223372036854775808, Max = 9223372036854775807)]
            public long? normalRangeLong { get; set; }
            [Range(Min = 0, Max = 18446744073709551615)]
            public ulong? normalRangeUlong { get; set; }

            // �͈͎w�肪�ُ�Ȋe�^�C�v�̐��l�i�G���[�ɂȂ�Ȃ��Ŗ��������j
            //[Range(Min = "A", Max = "B")]
            public sbyte? illegalRangeAttrSbyte { get; set; }

            // �^�O�ɒ��ڏ������͈͎w�肪�ُ�Ȋe�^�C�v�̐��l
            public sbyte? illegalRangeSbyte { get; set; }
            public byte? illegalRangeByte { get; set; }
            public short? illegalRangeShort { get; set; }
            public ushort? illegalRangeUshort { get; set; }
            public int? illegalRangeInt { get; set; }
            public uint? illegalRangeUint { get; set; }
            public long? illegalRangeLong { get; set; }
            public ulong? illegalRangeUlong { get; set; }

            // �ŏ��l��������Ă���e�^�C�v�̐��l
            [Range(Min = -129, Max = 127)]
            public sbyte? underRangeSbyte { get; set; }
            [Range(Min = -1, Max = 255)]
            public byte? underRangeByte { get; set; }
            [Range(Min = -32769, Max = 32767)]
            public short? underRangeShort { get; set; }
            [Range(Min = -1, Max = 65535)]
            public ushort? underRangeUshort { get; set; }
            [Range(Min = -2147483649, Max = 2147483647)]
            public int? underRangeInt { get; set; }
            [Range(Min = -1, Max = 4294967295)]
            public uint? underRangeUint { get; set; }
            //[Range(Min = -9223372036854775809, Max = 9223372036854775807)] ���̃����W�w��͂��������R���p�C���G���[�ƂȂ�
            public long? underRangeLong { get; set; }
            [Range(Min = -1, Max = 18446744073709551615)]
            public ulong? underRangeUlong { get; set; }

            // �ő�l�������Ă���e�^�C�v�̐��l
            [Range(Min = -128, Max = 128)]
            public sbyte? overRangeSbyte { get; set; }
            [Range(Min = 0, Max = 256)]
            public byte? overRangeByte { get; set; }
            [Range(Min = -32768, Max = 32768)]
            public short? overRangeShort { get; set; }
            [Range(Min = 0, Max = 65536)]
            public ushort? overRangeUshort { get; set; }
            [Range(Min = -2147483648, Max = 2147483648)]
            public int? overRangeInt { get; set; }
            [Range(Min = 0, Max = 4294967296)]
            public uint? overRangeUint { get; set; }
            [Range(Min = -9223372036854775808, Max = 9223372036854775808)]
            public long? overRangeLong { get; set; }
            //[Range(Min = 0, Max = 18446744073709551616)] ���̃����W�w��͂��������R���p�C���G���[�ƂȂ�
            public ulong? overRangeUlong { get; set; }
        }

        public void OnGet()
        {
        }
    }
}
