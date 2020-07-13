using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;

namespace RazorPageVue.Pages
{
    public class VueRealInputSysErrModel : PageModel
    {
        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            // �͈͖��w��̊e�^�C�v�̐��l
            public float? normalFloat { get; set; }
            public double? normalDouble { get; set; }

            // ����͈͂̊e�^�C�v�̐��l
            [Range(Min = -3.402823e38, Max = 3.402823e38)]
            public float? normalRangeFloat { get; set; }
            [Range(Min = -1.79769313486231e308, Max = 1.79769313486231e308)]
            public double? normalRangeDouble { get; set; }

            // �͈͎w�肪�ُ�Ȋe�^�C�v�̐��l�i�G���[�ɂȂ�Ȃ��Ŗ��������j
            //[Range(Min = "A", Max = "B")]
            public float? illegalRangeAttrFloat { get; set; }
            //[Range(Min = "A", Max = "B")]
            public double? illegalRangeAttrDouble { get; set; }

            // �^�O�ɒ��ڏ������͈͎w�肪�ُ�Ȋe�^�C�v�̐��l
            public float? illegalRangeFloat { get; set; }
            public double? illegalRangeDouble { get; set; }

            // �ŏ��l��������Ă���e�^�C�v�̐��l
            [Range(Min = -3.402824e38, Max = 3.402823e38)]
            public float? underRangeFloat { get; set; }
            //[Range(Min = -1.79769313486232e308, Max = 1.79769313486231e308)] //���̃����W�w��͂��������R���p�C���G���[�ƂȂ�
            //public double? underRangeDouble { get; set; }

            // �ő�l�������Ă���e�^�C�v�̐��l
            [Range(Min = -3.402823e38, Max = 1283.402823e38)]
            public float? overRangeFloat { get; set; }
            //[Range(Min = -1.79769313486231e308, Max = 1.79769313486232e308)] //���̃����W�w��͂��������R���p�C���G���[�ƂȂ�
            //public double? overRangeDouble { get; set; }
        }

        public void OnGet()
        {
        }
    }
}
