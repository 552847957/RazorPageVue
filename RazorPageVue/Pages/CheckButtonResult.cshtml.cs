using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace RazorPageVue.Pages
{
    public class CheckButtonResultModel : PageModel
    {
        /// <summary>
        /// ���W�I�{�^���̑I�����X�g
        /// </summary>
        public Dictionary<string, string> CheckValues { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// �ʏ�̃`�F�b�N�{�b�N�X�̑I������
        /// </summary>
        public string NormalCheckList { get; set; }

        /// <summary>
        /// �K�{�̃`�F�b�N�{�b�N�X�̑I������
        /// </summary>
        public string RequiredCheckList { get; set; }

        /// <summary>
        /// �K�{�ŃG���[���b�Z�[�W�ύX�̃`�F�b�N�{�b�N�X�̑I������
        /// </summary>
        public string RequiredErrChangeList { get; set; }

        /// <summary>
        /// Enum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
        /// </summary>
        public string NormalEnumList { get; set; }

        /// <summary>
        /// �K�{��Enum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
        /// </summary>
        public string RequiredEnumList { get; set; }

        /// <summary>
        /// �K�{�ŃG���[���b�Z�[�W�ύX��Enum�^�C�v�̃`�F�b�N�{�b�N�X�̑I��
        /// </summary>
        public string RequiredErrChangeEnumList { get; set; }

        public void OnGet(IEnumerable<string> normalCheckList, IEnumerable<string> requiredCheckList, IEnumerable<string> requiredErrChangeList,
            IEnumerable<SampleEnum> normalEnumList, IEnumerable<SampleEnum> requiredEnumList, IEnumerable<SampleEnum> requiredErrChangeEnumList)
        {
            setCheckList();

            NormalCheckList = getSelectedList(normalCheckList);
            RequiredCheckList = getSelectedList(requiredCheckList);
            RequiredErrChangeList = getSelectedList(requiredErrChangeList);

            NormalEnumList = getEnumSelectedList(normalEnumList);
            RequiredEnumList = getEnumSelectedList(requiredEnumList);
            RequiredErrChangeEnumList = getEnumSelectedList(requiredErrChangeEnumList);
        }

        string getSelectedList(IEnumerable<string> selectedList)
        {
            var list = "";

            if ((selectedList != null) && (selectedList.Count() > 0))
            {
                foreach (var item in selectedList)
                {
                    list += "," + item + ":" + CheckValues[item];
                }
                return list.Substring(1);
            }
            else
            {
                return "���I��";
            }
        }

        string getEnumSelectedList(IEnumerable<SampleEnum> enumSelectedList)
        {
            var list = "";

            if ((enumSelectedList != null) && (enumSelectedList.Count() > 0))
            {
                foreach (var item in enumSelectedList)
                {
                    list += "," + item.ToString();
                }
                return list.Substring(1);
            }
            else
            {
                return "���I��";
            }
        }

        /// <summary>
        /// �I��p���X�g�̏�����
        /// </summary>
        void setCheckList()
        {
            CheckValues.Add("1", "��1����");
            CheckValues.Add("2", "��2����");
            CheckValues.Add("3", "��3����");
            CheckValues.Add("4", "��4����");
            CheckValues.Add("5", "��5����");
        }
    }
}
