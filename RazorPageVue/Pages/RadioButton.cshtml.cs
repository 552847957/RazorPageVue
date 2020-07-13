using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPageVue.VueValidations;
using System.Collections.Generic;

namespace RazorPageVue.Pages
{
    public class RadioButtonModel : PageModel
    {
        /// <summary>
        /// ���W�I�{�^���̑I�����X�g
        /// </summary>
        static public List<KeyValuePair<string, string>> RadioValues
        {
            get
            {
                if (_radioValues == null)
                {
                    _radioValues = new List<KeyValuePair<string, string>>();
                    _radioValues.Add(new KeyValuePair<string, string>("��1����", "1"));
                    _radioValues.Add(new KeyValuePair<string, string>("��2����", "2"));
                    _radioValues.Add(new KeyValuePair<string, string>("��3����", "3"));
                    _radioValues.Add(new KeyValuePair<string, string>("��4����", "4"));
                    _radioValues.Add(new KeyValuePair<string, string>("�ŏI����", "5"));
                }
                return _radioValues;
            }
        }
        static List<KeyValuePair<string, string>> _radioValues = null;

        /// <summary>
        /// �����f�[�^
        /// </summary>
        [BindProperty]
        public InputModel BindData { get; set; } = new InputModel();

        public class InputModel
        {
            // ���W�I�{�^���̑I������
            public string RadioSelected { get; set; } = "2";

            public string RadioSelectedText { 
                get 
                {
                    foreach (var item in RadioValues)
                    {
                        if (item.Value == RadioSelected) return item.Key;
                    }
                    return "";
                } 
            }

            [Required]
            public string RadioRequiredSelected { get; set; }

            [Required(ErrorMessage ="�K�{�ύX")]
            public string RadioRequiredSelectedErrChange { get; set; }

            public string RadioRequiredSelectedText
            {
                get
                {
                    foreach (var item in RadioValues)
                    {
                        if (item.Value == RadioRequiredSelected) return item.Key;
                    }
                    return "";
                }
            }

            // Enum�𗘗p�������W�I�{�^���̑I������
            public SampleEnum? EnumRadioSelected { get; set; } = SampleEnum.sample2;

            // Enum�𗘗p�������W�I�{�^���̑I������
            [Required]
            public SampleEnum? EnumRequiredRadioSelected { get; set; } = null;

            [Required(ErrorMessage = "�K�{�ύX")]
            public SampleEnum? EnumRequiredRadioSelectedErrChange { get; set; }
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
            return RedirectToPage("RadioButtonResult", 
                new { SelectedId = BindData.RadioSelected, SelectedName = BindData.RadioSelectedText,
                    RequiredSelectedId = BindData.RadioRequiredSelected, RequiredSelectedName = BindData.RadioRequiredSelectedText,
                    SelectedEnum = BindData.EnumRadioSelected,
                    RequiredSelectedEnum = BindData.EnumRequiredRadioSelected
                });
        }
    }
}
