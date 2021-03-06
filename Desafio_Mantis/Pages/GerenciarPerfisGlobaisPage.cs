﻿using Desafio_Mantis.Bases;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Mantis.Pages
{
    public class GerenciarPerfisGlobaisPage : PageBase
    {
        #region Mapping
        By menuGerenciarPerfis = By.LinkText("Gerenciar Perfís Globais");
        By plataformaTextarea = By.Id("platform");
        By soTextarea = By.Id("os");
        By versaoSoTextArea = By.Id("os-version");
        By adicionarPerfilButton = By.XPath("//input[@value='Adicionar Perfil']");
        By enviarButton = By.XPath("//input[@value='Enviar']");
        By MsgErro = By.XPath("//*[@id='main-container']//p[2]");
        By perfil = By.Id("select-profile");
        By editarButton = By.XPath("//input[@id='action-edit']/..");
        By apagarButton = By.XPath("//input[@id='action-delete']/..");
        By atualizarPerfilButton = By.XPath("//input[@value='Atualizar Perfil']");
        By plataformaEdicaoTexarea = By.Name("platform");
        #endregion

        public void ClicarMenuGerenciarPerfis()
        {
            Click(menuGerenciarPerfis);
        }
        public string RetornaMensagemObrigatoriedadePlataforma()
        {
            return GetAttribute(plataformaTextarea, "validationMessage");
        }
        public string RetornaMensagemObrigatoriedadeSO()
        {
            return GetAttribute(soTextarea, "validationMessage");
        }
        public void PreencherPlataforma(string plataforma)
        {
            SendKeys(plataformaTextarea, plataforma);
        }
        public void PreencherSO(string so)
        {
            SendKeys(soTextarea, so);
        }
        public void PreencherVersaoSo(string versaoSo)
        {
            SendKeys(versaoSoTextArea, versaoSo);
        }
        public void ClicarAdicionarPerfil()
        {
            Click(adicionarPerfilButton);
        }
        public void ClicarEnviar()
        {
            Click(enviarButton);
        }
        public string RetornaMensagemDeErro()
        {
            return GetText(MsgErro);
        }
        public void ClicarEditarPerfil()
        {
            Click(editarButton);
        }
        public void ClicarApagarPerfil()
        {
            Click(apagarButton);
        }
        public void SelecionarPerfil(string nomePerfil)
        {
            ComboBoxSelectByVisibleText(perfil, nomePerfil);
        }
        public void LimparCampoPlataforma()
        {
            Clear(plataformaEdicaoTexarea);
        }
        public void AtualizarPerfil()
        {
            Click(atualizarPerfilButton);
        }
        public void PreencherPlataformaEdicao(string plataformaEdicao)
        {
            SendKeys(plataformaEdicaoTexarea, plataformaEdicao);
        }
    }
}
