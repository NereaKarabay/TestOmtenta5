﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Orchard.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Link Field")]
    public partial class LinkFieldFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Link.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Link Field", "  In order to add Link content to my types\r\n  As an administrator\r\n  I want to cr" +
                    "eate, edit and publish Link fields", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Creating and using Link fields")]
        public virtual void CreatingAndUsingLinkFields()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Creating and using Link fields", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 9
    testRunner.Given("I have installed Orchard", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 10
        testRunner.And("I have installed \"Orchard.Fields\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
    testRunner.When("I go to \"Admin/ContentTypes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
    testRunner.Then("I should see \"<a[^>]*>.*?Create new type</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
    testRunner.When("I go to \"Admin/ContentTypes/Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table1.AddRow(new string[] {
                        "DisplayName",
                        "Event"});
            table1.AddRow(new string[] {
                        "Name",
                        "Event"});
#line 14
        testRunner.And("I fill in", ((string)(null)), table1, "And ");
#line 18
        testRunner.And("I hit \"Create\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
        testRunner.And("I go to \"Admin/ContentTypes/\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
    testRunner.Then("I should see \"Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 23
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 24
        testRunner.And("I follow \"Add Field\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table2.AddRow(new string[] {
                        "DisplayName",
                        "Site Url"});
            table2.AddRow(new string[] {
                        "Name",
                        "SiteUrl"});
            table2.AddRow(new string[] {
                        "FieldTypeName",
                        "LinkField"});
#line 25
        testRunner.And("I fill in", ((string)(null)), table2, "And ");
#line 30
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
    testRunner.Then("I should see \"The \\\"Site Url\\\" field has been added.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 35
    testRunner.When("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
    testRunner.Then("I should see \"Site Url\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table3.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        "http://www.orchardproject.net"});
#line 37
    testRunner.When("I fill in", ((string)(null)), table3, "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table4.AddRow(new string[] {
                        "Event.SiteUrl.Text",
                        "Orchard"});
#line 40
        testRunner.And("I fill in", ((string)(null)), table4, "And ");
#line 43
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
    testRunner.When("I go to \"Admin/Contents/List\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 47
    testRunner.Then("I should see \"Site Url:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 48
        testRunner.And("I should see \"<a href=\\\"http://www.orchardproject.net\\\">Orchard</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table5.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Hint",
                        "Enter the url of the web site"});
#line 52
        testRunner.And("I fill in", ((string)(null)), table5, "And ");
#line 55
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
    testRunner.Then("I should see \"Enter the url of the web site\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 60
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table6.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "true"});
#line 61
        testRunner.And("I fill in", ((string)(null)), table6, "And ");
#line 64
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table7.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        ""});
#line 66
        testRunner.And("I fill in", ((string)(null)), table7, "And ");
#line 69
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
    testRunner.Then("I should see \"Url is required for Site Url.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 73
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table8.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "false"});
            table8.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.DefaultValue",
                        "http://www.orchardproject.net"});
#line 74
        testRunner.And("I fill in", ((string)(null)), table8, "And ");
#line 78
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table9.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        ""});
#line 80
        testRunner.And("I fill in", ((string)(null)), table9, "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table10.AddRow(new string[] {
                        "Event.SiteUrl.Text",
                        "Orchard1"});
#line 83
        testRunner.And("I fill in", ((string)(null)), table10, "And ");
#line 86
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 89
    testRunner.When("I go to \"Admin/Contents/List\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
    testRunner.Then("I should see \"Site Url:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
        testRunner.And("I should see \"<a href=\\\"http://www.orchardproject.net\\\">Orchard1</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table11.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "true"});
            table11.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.DefaultValue",
                        "http://www.orchardproject.net"});
#line 95
        testRunner.And("I fill in", ((string)(null)), table11, "And ");
#line 99
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table12.AddRow(new string[] {
                        "Event.SiteUrl.Value",
                        ""});
#line 101
        testRunner.And("I fill in", ((string)(null)), table12, "And ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table13.AddRow(new string[] {
                        "Event.SiteUrl.Text",
                        "Orchard2"});
#line 104
        testRunner.And("I fill in", ((string)(null)), table13, "And ");
#line 107
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
        testRunner.And("I am redirected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
    testRunner.Then("I should see \"Your Event has been created.\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 110
    testRunner.When("I go to \"Admin/Contents/List\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 111
    testRunner.Then("I should see \"Site Url:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 112
        testRunner.And("I should see \"<a href=\\\"http://www.orchardproject.net\\\">Orchard2</a>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table14.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "true"});
            table14.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.DefaultValue",
                        ""});
#line 116
        testRunner.And("I fill in", ((string)(null)), table14, "And ");
#line 120
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
    testRunner.Then("I should see \"required=\\\"required\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 125
    testRunner.When("I go to \"Admin/ContentTypes/Edit/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "name",
                        "value"});
            table15.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.Required",
                        "true"});
            table15.AddRow(new string[] {
                        "Fields[0].LinkFieldSettings.DefaultValue",
                        "http://www.orchardproject.net"});
#line 126
        testRunner.And("I fill in", ((string)(null)), table15, "And ");
#line 130
        testRunner.And("I hit \"Save\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
        testRunner.And("I go to \"Admin/Contents/Create/Event\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
    testRunner.Then("I should not see \"required=\\\"required\\\"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
