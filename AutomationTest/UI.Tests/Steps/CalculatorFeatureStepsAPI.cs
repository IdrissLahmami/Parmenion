using FluentAssertions;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using UI.Tests.Drivers;
using RestSharp;
using UI.Tests.Globals;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UI.Tests.Drivers.Steps
{

    public class ShareState  // Context Injection for sharing data between bindings
    {  
        public RestRequest restrequest;
    }

    [Binding]
    public sealed class CalculatorFeatureStepsAPI
    {
        private readonly WebDriver _webDriver;

        //private RestClient restClient;
        private IRestResponse restResponse;

        public CalculatorFeatureStepsAPI(WebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [Given(@"I have entered (.*) into (.*) calculator")]
        [Scope( Tag = "APILevel")]
        public void GivenIHaveEnteredIntoTheCalculator(string p0, string id)
        {
            //Work in progress
            const string baseUrl = "http://localhost:51077/";
            const string endPoint = "api/{id}";

            _webDriver.Wait.Until(d => d.FindElement(By.Id(id))).SendKeys(p0.ToString());

            var client = new RestClient(baseUrl); 
            var request = new RestRequest(endPoint, Method.POST);

            request.AddParameter("/p0", p0);

            IRestResponse response = client.Execute(request);
            var content = response.Content; // raw content as s
        }

        [When(@"I press divide")]
        [Scope(Tag = "APILevel")]
        public void WhenIPressDivide()
        {
            //Todo
            //get("http://.json").
            
        }

        [Then(@"the result should be (.*) on the screen")]
        [Scope(Tag = "APILevel")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            //Todo
            //assertThat().
            //statusCode(200).

            dynamic jsonResponse = JsonConvert.DeserializeObject(restResponse.Content);
            jsonResponse.Works = true;


        }
}



}

