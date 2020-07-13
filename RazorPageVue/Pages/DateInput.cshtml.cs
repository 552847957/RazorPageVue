using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using RazorPageVue.VueValidations;

namespace RazorPageVue.Pages
{
    public class DateInputModel : PageModel
    {
        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            /// <summary>
            /// �o���f�[�V�����Ȃ�
            /// </summary>
            public DateTime? Nochek { get; set; } = null;

            /// <summary>
            /// ���͕K�{
            /// </summary>
            [Required]
            public DateTime? Required { get; set; } = null;

            /// <summary>
            /// ���͕K�{�ŃG���[���b�Z�[�W�ύX
            /// </summary>
            [Required(ErrorMessage ="���͕K�{�i�ύX�j")] 
            public DateTime? RequiredErrch { get; set; } = null;
            
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
            return RedirectToPage("DateInputResult", this.BindData);
        }
    }
}
