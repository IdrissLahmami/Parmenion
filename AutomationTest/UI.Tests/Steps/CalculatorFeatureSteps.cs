using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UI.Tests.Drivers;

namespace UI.Tests.Drivers.Steps
{
    [Binding]
    public class CalculatorFeatureSteps
    {
        private readonly WebDriver _webDriver;

        public CalculatorFeatureSteps(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given(@"I have entered (.*) into (.*) calculator")]
        [Scope( Tag = "UILevel")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0, string id)
        {
        
            _webDriver.Wait.Until(d => d.FindElement(By.Id(id))).SendKeys(p0.ToString());

        }

        [When(@"I press divide")]
        [Scope( Tag = "UILevel")]
        public void WhenIPressDivide()
        {
            var divideButton = _webDriver.Wait.Until(d => d.FindElement(By.Id("Submit")));
            divideButton.Submit();
        }

        [Then(@"the result should be (.*) on the screen")]
        [Scope( Tag = "UILevel")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            var result = _webDriver.Wait.Until(d => d.FindElement(By.Id("result")));

            result.Text.Should().Be(p0.ToString());
        }
    }
}
