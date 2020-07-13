using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;

namespace RazorPageVue.Pages
{
    public class CheckButtonModel : PageModel
    {
        /// <summary>
        /// ���W�I�{�^���̑I�����X�g
        /// </summary>
        public List<KeyValuePair<string, string>> CheckValues { get; set; } = new List<KeyValuePair<string, string>>();

        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            /// <summary>
            /// �ʏ�̃`�F�b�N�{�b�N�X�̑I������
            /// </summary>
            public List<string> NormalCheckList { get; set; } = new List<string>();

            /// <summary>
            /// ���͕K�{�̃`�F�b�N�{�b�N�X�̑I������
            /// </summary>
            [Required]
            public List<string> RequiredCheckList { get; set; } = new List<string>();

            /// <summary>
            /// ���͕K�{�̃G���[���b�Z�[�W�ύX�`�F�b�N�{�b�N�X�̑I������
            /// </summary>
            [Required(ErrorMessage = "�K�{�ύX")]
            public List<string> RequiredErrChangeList { get; set; } = new List<string>();

            /// <summary>
            /// Enum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
            /// </summary>
            public List<SampleEnum> NormalEnumList { get; set; } = new List<SampleEnum>();

            /// <summary>
            /// ���͕K�{��Enum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
            /// </summary>
            [Required]
            public List<SampleEnum> RequiredEnumList { get; set; } = new List<SampleEnum>();

            /// <summary>
            /// ���͕K�{�̃G���[���b�Z�[�W�ύXEnum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
            /// </summary>
            [Required(ErrorMessage = "�K�{�ύX")]
            public List<SampleEnum> RequiredErrChangeEnumList { get; set; } = new List<SampleEnum>();
        }

        public CheckButtonModel()
        {
            setCheckList();
        } 

        public void OnGet()
        {
            BindData.NormalCheckList = new List<string>() { "2" };
            BindData.NormalEnumList = new List<SampleEnum>() { SampleEnum.sample3 };
        }

        /// <summary>
        /// Post����
        /// </summary>
        /// <returns></returns>
        public IActionResult OnPost()
        {
            return RedirectToPage("CheckButtonResult",
                new {
                    normalCheckList = BindData.NormalCheckList,
                    requiredCheckList = BindData.RequiredCheckList,
                    requiredErrChangeList = BindData.RequiredErrChangeList,
                    normalEnumList = BindData.NormalEnumList,
                    requiredEnumList = BindData.RequiredEnumList,
                    requiredErrChangeEnumList = BindData.RequiredErrChangeEnumList
                });
        }

        /// <summary>
        /// �I��p���X�g�̏�����
        /// </summary>
        void setCheckList()
        {
            CheckValues.Add(new KeyValuePair<string, string>("��1����", "1"));
            CheckValues.Add(new KeyValuePair<string, string>("��2����", "2"));
            CheckValues.Add(new KeyValuePair<string, string>("��3����", "3"));
            CheckValues.Add(new KeyValuePair<string, string>("��4����", "4"));
            CheckValues.Add(new KeyValuePair<string, string>("�ŏI����", "5"));
        }

    }
}
