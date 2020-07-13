using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;
using System;

namespace RazorPageVue.Pages
{
    public class TimeInputModel : PageModel
    {
        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            //--------------------------------------------------------------------------------
            //  �K�{���̓`�F�b�N�p
            //--------------------------------------------------------------------------------
            /// <summary>
            /// ��{�̃^�C���X�p��
            /// </summary>
            public TimeSpan? NormalTimeSpan { get; set; }

            /// <summary>
            /// �K�{�̃^�C���X�p��
            /// </summary>
            [Required]
            public TimeSpan? RequiredTimeSpan { get; set; }

            /// <summary>
            /// �K�{�̃^�C���X�p��
            /// </summary>
            [Required(ErrorMessage = "�K�{���b�Z�[�W�ύX")]
            public TimeSpan? RequiredTimeSpanChange { get; set; }

            //--------------------------------------------------------------------------------
            //  �ŏ��l�`�F�b�N�p
            //--------------------------------------------------------------------------------
            [Range(Min = "1:10")]
            public TimeSpan? MinTimeSpan { get; set; }

            [Range(Min = "1:15", MinErrorMessage ="�ŏ��ύX")]
            public TimeSpan? MinErrTimeSpan { get; set; }

            //--------------------------------------------------------------------------------
            //  �ő�l�`�F�b�N�p
            //--------------------------------------------------------------------------------
            [Range(Max = "23:10")]
            public TimeSpan? MaxTimeSpan { get; set; }

            [Range(Max = "22:55", MaxErrorMessage ="�ő�ύX")]�@
            public TimeSpan? MaxErrTimeSpan { get; set; }

            //--------------------------------------------------------------------------------
            //  ���ݕ��`�F�b�N�p
            //--------------------------------------------------------------------------------
            [Range(Step = 10)]
            public TimeSpan? StepTimeSpan { get; set; }

            [Range(Step = 300, StepErrorMessage ="�X�e�b�v�ύX")]
            public TimeSpan? StepErrTimeSpan { get; set; }

            [Range(Min = "2:00", Max = "22:22", Step = 900)]
            public TimeSpan? MinMaxStepTimeSpan { get; set; }
        }

        /// <summary>
        /// Get����
        /// </summary>
        public void OnGet()
        {
            BindData.MinTimeSpan = TimeSpan.Parse("1:00");
            BindData.MinErrTimeSpan = TimeSpan.Parse("1:00");
            BindData.MaxTimeSpan = TimeSpan.Parse("23:15");
            BindData.MaxErrTimeSpan = TimeSpan.Parse("23:00");
            BindData.StepTimeSpan = TimeSpan.Parse("10:00:05");
            BindData.StepErrTimeSpan = TimeSpan.Parse("23:02");
            BindData.MinMaxStepTimeSpan = TimeSpan.Parse("12:34");
        }

        /// <summary>
        /// Post����
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            return RedirectToPage("TimeInputResult", this.BindData);
        }
    }
}
