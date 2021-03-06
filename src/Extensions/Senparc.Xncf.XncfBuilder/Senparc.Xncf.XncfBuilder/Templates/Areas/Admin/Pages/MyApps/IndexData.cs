﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Xncf.XncfBuilder.Templates.Areas.Admin.Pages.MyApps
{
    public partial class Index : IXncfTemplatePage
    {
        public string RelativeFilePath => $"Areas/Admin/Pages/{XncfName}/Index.cshtml";

        public string OrgName { get; set; }
        public string XncfName { get; set; }
        public string MenuName { get; set; }


        public Index(string orgName, string xncfName, string menuName)
        {
            OrgName = orgName;
            XncfName = xncfName;
            MenuName = menuName;
        }
    }
}
