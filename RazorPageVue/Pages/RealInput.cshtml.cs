using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;

namespace RazorPageVue.Pages
{
    public class RealInputModel : PageModel
    {
        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            #region �K�{�`�F�b�N�p
            /// <summary>
            /// �K�{�����Ȃ�
            /// </summary>
            public double? Nochek { get; set; }

            /// <summary>
            /// ���͕K�{
            /// </summary>
            [Required]
            public double? Required { get; set; }

            /// <summary>
            /// ���͕K�{�i�G���[���b�Z�[�W�ύX�j
            /// </summary>
            [Required(ErrorMessage = "�K�{����i�ύX�j")]
            public double? RequiredErrch { get; set; }
            #endregion

            #region �ŏ��l�`�F�b�N
            /// <summary>
            /// �ŏ��l-5
            /// </summary>
            [Range(Min = -1.5)]
            public double? MinM1_5 { get; set; } = -1.6;

            /// <summary>
            /// �ŏ��l-5 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Min = -1.5, MinErrorMessage = "�ŏ��l��菬�����i�ύX�j")]
            public double? MinM1_5Errch { get; set; } = -1.7;

            /// <summary>
            /// �ŏ��l 0
            /// </summary>
            [Range(Min = 0)]
            public double? Min0 { get; set; } = -1;

            /// <summary>
            /// �ŏ��l 2
            /// </summary>
            [Range(Min = 1.2)]
            public double? Min1_2 { get; set; } = 0;
            #endregion

            #region �ő�l�`�F�b�N
            /// <summary>
            /// �ő�l 5
            /// </summary>
            [Range(Max = 1.5)]
            public double? Max1_5 { get; set; } = 2.6;

            /// <summary>
            /// �ő�l 5 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Max = 1.5, MaxErrorMessage = "�ő�l�����Ă�i�ύX�j")]
            public double? Max1_5Errch { get; set; } = 1.6;

            /// <summary>
            /// �ő�l 0
            /// </summary>
            [Range(Max = 0)]
            public double? Max0 { get; set; } = 1.1;

            /// <summary>
            /// �ő�l -2
            /// </summary>
            [Range(Max = -1.2)]
            public double? MaxM1_2 { get; set; } = -1.1;
            #endregion

            #region �X�e�b�v�`�F�b�N
            /// <summary>
            /// �X�e�b�v 2
            /// </summary>
            [Range(Step = 0.2)]
            public double? Step0_2 { get; set; } = 0.1;

            /// <summary>
            /// �X�e�b�v 2 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Step = 0.2, StepErrorMessage = "�X�e�b�v�G���[�ύX")]
            public double? Step0_2Errch { get; set; } = 0.1;

            /// <summary>
            /// �X�e�b�v 3
            /// </summary>
            [Range(Step = 0.3)]
            public double? Step0_3 { get; set; } = 1.0;
            #endregion

            #region �ŏ��l�ƍő�l�̓����`�F�b�N
            [Range(Min = -1.0, Max = -0.5)]
            public double? MinM1_0MaxM0_5 { get; set; } = -1.5;

            [Range(Min = -0.5, Max = 0)]
            public double? MinM0_5Max0 { get; set; } = 1.0;

            [Range(Min = -0.5, Max = 0.5)]
            public double? MinM0_5Max0_5 { get; set; } = 1.0;

            [Range(Min = 0, Max = 0.5)]
            public double? Min0Max0_5 { get; set; } = -1.0;

            [Range(Min = 0.5, Max = 1.0)]
            public double? Min0_5Max1_0 { get; set; } = 0;
            #endregion

            #region �ŏ��l�ƃX�e�b�v�̓����`�F�b�N
            [Range(Min = -1.5, Step = 0.3)]
            public double? MinM1_5Step0_3 { get; set; } = -1.3;

            [Range(Min = 0, Step = 0.3)]
            public double? Min0Step0_3 { get; set; } = -0.1;

            [Range(Min = 1.2, Step = 0.3)]
            public double? Min1_2Step0_3 { get; set; } = 0;
            #endregion

            #region �ő�l�ƃX�e�b�v�̓����`�F�b�N
            [Range(Max = 0.5, Step = 0.2)]
            public double? Max0_5Step0_2 { get; set; } = 0.6;

            [Range(Max = 0, Step = 0.3)]
            public double? Max0Step0_3 { get; set; } = 0.1;

            [Range(Max = -1.2, Step = 0.4)]
            public double? MaxM1_2Step0_4 { get; set; } = 0;
            #endregion

            #region �S�Ă̏����ݒ�
            /// <summary>
            /// �ŏ��l -5 �ő�l 5 �X�e�b�v 3
            /// </summary>
            [Range(Min = -0.5, Max = 0.5, Step = 0.3)]
            public double? MinM0_5Step0_3Max0_5 { get; set; } = 0.6;
            #endregion
        }

        public void OnGet()
        {
        }

        /// <summary>
        /// Post����
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            return RedirectToPage("RealInputResult", this.BindData);
        }

    }
}
