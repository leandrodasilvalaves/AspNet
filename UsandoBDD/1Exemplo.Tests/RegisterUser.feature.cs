﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace _1Exemplo.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class CadastroDeUsuariosFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "RegisterUser.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-br"), "Cadastro de Usuarios", "\tEU ENQUANTO usuario\r\n\tQUERO me registrar\r\n\tE me logar\r\n\tPARA ter acesso completo" +
                    " do sistema", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Cadastro de Usuarios")))
            {
                global::_1Exemplo.Tests.CadastroDeUsuariosFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("1. [Chrome] Cadastrar usuario no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _1_ChromeCadastrarUsuarioNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. [Chrome] Cadastrar usuario no banco de dados", ((string[])(null)));
#line 9
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword",
                        "Browser"});
            table1.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "123@Mudar",
                        "Chrome"});
#line 10
 testRunner.Given("usuario se encontra na pagina de registro", ((string)(null)), table1, "Dado ");
#line 13
 testRunner.When("clicar no botao Register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 14
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("1. [Firefox] Cadastrar usuario no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _1_FirefoxCadastrarUsuarioNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. [Firefox] Cadastrar usuario no banco de dados", ((string[])(null)));
#line 16
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword",
                        "Browser"});
            table2.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "123@Mudar",
                        "Firefox"});
#line 17
 testRunner.Given("usuario se encontra na pagina de registro", ((string)(null)), table2, "Dado ");
#line 20
 testRunner.When("clicar no botao Register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 21
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("1. [IE] Cadastrar usuario no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _1_IECadastrarUsuarioNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("1. [IE] Cadastrar usuario no banco de dados", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword",
                        "Browser"});
            table3.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "123@Mudar",
                        "IE"});
#line 24
 testRunner.Given("usuario se encontra na pagina de registro", ((string)(null)), table3, "Dado ");
#line 27
 testRunner.When("clicar no botao Register", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 28
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("2. [Chrome] Logar no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _2_ChromeLogarNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. [Chrome] Logar no banco de dados", ((string[])(null)));
#line 31
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Browser"});
            table4.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "Chrome"});
#line 32
 testRunner.Given("usuario se encontra na pagina de login", ((string)(null)), table4, "Dado ");
#line 35
 testRunner.When("clicar no botao login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 36
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("2. [Firefox] Logar no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _2_FirefoxLogarNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. [Firefox] Logar no banco de dados", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Browser"});
            table5.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "Firefox"});
#line 39
 testRunner.Given("usuario se encontra na pagina de login", ((string)(null)), table5, "Dado ");
#line 42
 testRunner.When("clicar no botao login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 43
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("2. [IE] Logar no banco de dados")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Cadastro de Usuarios")]
        public virtual void _2_IELogarNoBancoDeDados()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2. [IE] Logar no banco de dados", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Browser"});
            table6.AddRow(new string[] {
                        "leandro@gmail.com",
                        "123@Mudar",
                        "IE"});
#line 46
 testRunner.Given("usuario se encontra na pagina de login", ((string)(null)), table6, "Dado ");
#line 49
 testRunner.When("clicar no botao login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 50
 testRunner.Then("o usuario será autenticado", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Então ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
