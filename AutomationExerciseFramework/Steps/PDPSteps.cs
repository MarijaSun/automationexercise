using System;
using TechTalk.SpecFlow;

namespace AutomationExerciseFramework.Steps
{
    [Binding]
    public class PDPSteps
    {
        
        [Given(@"user opens products page")]
        public void GivenUserOpensProductsPage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"searches for '(.*)' term")]
        public void GivenSearchesForTerm(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"opens first search result")]
        public void GivenOpensFirstSearchResult()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"user click on Add to Cart button")]
        public void WhenUserClickOnAddToCartButton()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"proceeds to cart")]
        public void WhenProceedsToCart()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"shopping cart will be displayed with '(.*)' product inside")]
        public void ThenShoppingCartWillBeDisplayedWithProductInside(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
