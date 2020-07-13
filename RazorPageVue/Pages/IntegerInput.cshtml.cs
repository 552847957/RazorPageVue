using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Threading.Tasks;
using RazorPageVue.VueValidations;
using Microsoft.AspNetCore.Mvc;

namespace RazorPageVue.Pages
{
    public class IntegerInputModel : PageModel
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
            public int? Nochek { get; set; }

            /// <summary>
            /// ���͕K�{
            /// </summary>
            [Required]
            public int? Required { get; set; }

            /// <summary>
            /// ���͕K�{�i�G���[���b�Z�[�W�ύX�j
            /// </summary>
            [Required(ErrorMessage = "�K�{����i�ύX�j")]
            public int? RequiredErrch { get; set; }
            #endregion

            #region �ŏ��l�`�F�b�N
            /// <summary>
            /// �ŏ��l-5
            /// </summary>
            [Range(Min = -5)]
            public int? MinM5 { get; set; } = -6;

            /// <summary>
            /// �ŏ��l-5 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Min = -5, MinErrorMessage = "�ŏ��l��菬�����i�ύX�j")]
            public int? MinM5Errch { get; set; } = -6;

            /// <summary>
            /// �ŏ��l 0
            /// </summary>
            [Range(Min = 0)]
            public int? Min0 { get; set; } = -1;

            /// <summary>
            /// �ŏ��l 2
            /// </summary>
            [Range(Min = 2)]
            public int? Min2 { get; set; } = 0;
            #endregion

            #region �ő�l�`�F�b�N
            /// <summary>
            /// �ő�l 5
            /// </summary>
            [Range(Max = 5)]
            public int? Max5 { get; set; } = 6;

            /// <summary>
            /// �ő�l 5 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Max = 5, MaxErrorMessage = "�ő�l�����Ă�i�ύX�j")]
            public int? Max5Errch { get; set; } = 6;

            /// <summary>
            /// �ő�l 0
            /// </summary>
            [Range(Max = 0)]
            public int? Max0 { get; set; } = 1;

            /// <summary>
            /// �ő�l -2
            /// </summary>
            [Range(Max = -2)]
            public int? MaxM2 { get; set; } = 0;
            #endregion

            #region �X�e�b�v�`�F�b�N
            /// <summary>
            /// �X�e�b�v 2
            /// </summary>
            [Range(Step = 2)]
            public int? Step2 { get; set; } = 1;

            /// <summary>
            /// �X�e�b�v 2 �G���[���b�Z�[�W�ύX
            /// </summary>
            [Range(Step = 2, StepErrorMessage = "�X�e�b�v�G���[�ύX")]
            public int? Step2Errch { get; set; } = 1;

            /// <summary>
            /// �X�e�b�v 3
            /// </summary>
            [Range(Step = 3)]
            public int? Step3 { get; set; } = 1;
            #endregion

            #region �ŏ��l�ƍő�l�̓����`�F�b�N
            [Range(Min = -10, Max = -5)]
            public int? MinM10MaxM5 { get; set; } = -15;

            [Range(Min = -5, Max = 0)]
            public int? MinM5Max0 { get; set; } = 1;

            [Range(Min = -5, Max = 5)]
            public int? MinM5Max5 { get; set; } = 10;

            [Range(Min = 0, Max = 5)]
            public int? Min0Max5 { get; set; } = -1;

            [Range(Min = 5, Max = 10)]
            public int? Min5Max10 { get; set; } = 0;
            #endregion

            #region �ŏ��l�ƃX�e�b�v�̓����`�F�b�N
            [Range(Min = -5, Step = 3)]
            public int? MinM5Step3 { get; set; } = -3;

            [Range(Min = 0, Step = 3)]
            public int? Min0Step3 { get; set; } = -1;

            [Range(Min = 2, Step = 3)]
            public int? Min2Step3 { get; set; } = 0;
            #endregion

            #region �ő�l�ƃX�e�b�v�̓����`�F�b�N
            [Range(Max = 5,Step =2)]
            public int? Max5Step2 { get; set; } = 6;

            [Range(Max = 0, Step = 3)]
            public int? Max0Step3 { get; set; } = 1;

            [Range(Max = -2, Step = 4)]
            public int? MaxM2Step4 { get; set; } = 0;
            #endregion

            #region �S�Ă̏����ݒ�
            /// <summary>
            /// �ŏ��l -5 �ő�l 5 �X�e�b�v 3
            /// </summary>
            [Range(Min = -5, Max = 5, Step = 3)]
            public int? MinM5Step3Max5 { get; set; } = 6;

            /// <summary>
            /// �ŏ��l -10 �ő�l -5 �X�e�b�v 3
            /// </summary>
            [Range(Min = -10, Max = -5, Step = 3)]
            public int? MinM10Step3MaxM5 { get; set; } = -15;

            /// <summary>
            /// �ŏ��l -5 �ő�l 5 �X�e�b�v 3
            /// </summary>
            [Range(Min = 5, Max =10, Step = 3)]
            public int? Min5Step3Max10 { get; set; } = 15;
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
            return RedirectToPage("IntegerInputResult", this.BindData);
        }
    }
}
