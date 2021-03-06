﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AgeRangerWebUi.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("AgeRanger UI Tests")]
    public partial class AgeRangerUITestsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AgeRangerUITests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "AgeRanger UI Tests", "\tThis feature will cover the different tests for Age Ranger Application", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Add New Person and Verify Age Group")]
        [NUnit.Framework.CategoryAttribute("AgeRangerUIRegression")]
        [NUnit.Framework.TestCaseAttribute("ToddlerFirst", "ToddlerLast", "0", "Toddler", null)]
        [NUnit.Framework.TestCaseAttribute("ChildFirst", "ChildLast", "2", "Child", null)]
        [NUnit.Framework.TestCaseAttribute("TeenagerFirst", "TeenagerLast", "14", "Teenager", null)]
        [NUnit.Framework.TestCaseAttribute("EarlyTwentiesFirst", "EarlyTwentiesLast", "20", "Early twenties", null)]
        [NUnit.Framework.TestCaseAttribute("AlmostThirtyFirst", "AlmostThirtyLast", "25", "Almost thirty", null)]
        [NUnit.Framework.TestCaseAttribute("VeryAdultFirst", "VeryAdultLast", "30", "Very adult", null)]
        [NUnit.Framework.TestCaseAttribute("KindaOldFirst", "KindaOldLast", "50", "Kinda old", null)]
        [NUnit.Framework.TestCaseAttribute("OldFirst", "OldLast", "70", "Old", null)]
        [NUnit.Framework.TestCaseAttribute("VeryOldFirst", "VeryOldLast", "99", "Very old", null)]
        [NUnit.Framework.TestCaseAttribute("CrazyAncientFirst", "CrazyAncientLast", "110", "Crazy ancient", null)]
        [NUnit.Framework.TestCaseAttribute("VampireFirst", "VampireLast", "199", "Vampire", null)]
        [NUnit.Framework.TestCaseAttribute("中文", "中文", "8", "Child", null)]
        [NUnit.Framework.TestCaseAttribute("日本語", "日本語", "17", "Teenager", null)]
        [NUnit.Framework.TestCaseAttribute("한국어", "한국어", "22", "Early twenties", null)]
        [NUnit.Framework.TestCaseAttribute("àçèéù", "àçèéù", "27", "Almost thirty", null)]
        [NUnit.Framework.TestCaseAttribute("üäöß", "üäöß", "40", "Very adult", null)]
        public virtual void AddNewPersonAndVerifyAgeGroup(string firstName, string lastName, string age, string ageGroup, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AgeRangerUIRegression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add New Person and Verify Age Group", @__tags);
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I am on Age Ranger Home Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I click Add New Person button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.And(string.Format("I enter {0}, {1} and {2} in the form", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I Submit the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I confirm the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.Then(string.Format("I should see {0} and {1} in the People view with correct {2} and the correct {3}", firstName, lastName, age, ageGroup), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 14
 testRunner.And(string.Format("I delete created person {0}, {1} and {2}", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Edit Person")]
        [NUnit.Framework.CategoryAttribute("AgeRangerUIRegression")]
        [NUnit.Framework.TestCaseAttribute("FNOnlyEditingUserFirst", "FNOnlyEditingUserLast", "30", "FNOnlyEditedUserFirst", "NoChange", "NoChange", null)]
        [NUnit.Framework.TestCaseAttribute("LNOnlyEditingUserFirst", "LNOnlyEditingUserLast", "30", "NoChange", "LNOnlyEditedUserLast", "NoChange", null)]
        [NUnit.Framework.TestCaseAttribute("AgeOnlyEditingUserFirst", "AgeOnlyEditingUserLast", "30", "NoChange", "NoChange", "50", null)]
        [NUnit.Framework.TestCaseAttribute("AllEditingUserFirst", "AllEditingUserLast", "30", "AllEditedUserFirst", "AllEditedUserLast", "50", null)]
        public virtual void EditPerson(string firstName, string lastName, string age, string newFirstName, string newLastName, string newAge, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AgeRangerUIRegression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Person", @__tags);
#line 39
this.ScenarioSetup(scenarioInfo);
#line 40
 testRunner.Given(string.Format("I created a new person with {0}, {1} and {2}", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.When(string.Format("I update the {0}, {1} and {2} with {3}, {4} and {5}", firstName, lastName, age, newFirstName, newLastName, newAge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 42
 testRunner.And("I Submit the form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.And("I confirm the action", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.Then(string.Format("I should see {0} and {1} in the People view with correct {2} instead of {3}, {4} " +
                        "and {5}", newFirstName, newLastName, newAge, firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 45
 testRunner.And(string.Format("I delete updated person {0}, {1}, {2}, {3}, {4} and {5}", firstName, lastName, age, newFirstName, newLastName, newAge), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Person")]
        [NUnit.Framework.CategoryAttribute("AgeRangerUIRegression")]
        [NUnit.Framework.TestCaseAttribute("DeletingUserFirst", "DeletingUserLast", "30", null)]
        public virtual void DeletePerson(string firstName, string lastName, string age, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AgeRangerUIRegression"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Person", @__tags);
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
 testRunner.Given(string.Format("I created a new person with {0}, {1} and {2}", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.When(string.Format("I delete created person {0}, {1} and {2}", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 61
 testRunner.Then(string.Format("I should not see {0}, {1} and {2} record anymore", firstName, lastName, age), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
