using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPageVue.Pages
{
    public class DateInputResultModel : PageModel
    {
        #region �K�{�`�F�b�N�p
        public string Nochek { get; set; }
        public string Required { get; set; }
        public string RequiredErrch { get; set; }
        #endregion

        public void OnGet(DateInputModel.InputModel model)
        {
            Nochek = (model.Nochek==null)?"":((DateTime)model.Nochek).ToString("yyyy/MM/dd");
            Required = (model.Required == null) ? "" : ((DateTime)model.Required).ToString("yyyy/MM/dd");
            RequiredErrch = (model.RequiredErrch == null) ? "" : ((DateTime)model.RequiredErrch).ToString("yyyy/MM/dd");
        }
    }
}
