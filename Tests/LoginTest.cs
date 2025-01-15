using Microsoft.Playwright;
using System.Threading.Tasks;
using NUnit.Framework;
using PlaywrightAutomation.Pages;

namespace PlaywrightAutomation.Tests
{
    public class LoginTest
    {
        private IPlaywright _playwright;
        private IBrowser _browser;
        private IPage _page;
        private LoginPage _loginPage;

        [SetUp]
        public async Task SetUp()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = false });
            _page = await _browser.NewPageAsync();
            _loginPage = new LoginPage(_page);
        }

        [Test]
        public async Task LoginWithValidCredentialsTest()
        {
            await _page.GotoAsync("https://planoaliados.com.br/portal/login");
            await _loginPage.LoginAsync("usuario", "senha");
            bool isErrorVisible = await _loginPage.IsErrorMessageVisibleAsync();
            Assert.IsFalse(isErrorVisible, "Erro de login foi exibido.");
        }

        [TearDown]
        public async Task TearDown()
        {
            await _browser.CloseAsync();
        }
    }
}
