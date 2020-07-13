﻿using Desafio_Mantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Mantis.Pages
{
    class GerenciarPage : PageBase
    {
        #region Mapping
        By menuGerenciarButton = By.XPath("//*[@id='sidebar']/ul/li[7]");
        #endregion
        public void ClicarGerenciar()
        {
            Click(menuGerenciarButton);
        }
    }
}
