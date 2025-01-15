using Microsoft.Playwright;
using System.Threading.Tasks;
using System;


namespace PlaywrightAutomation
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var playwright = await Playwright.CreateAsync();
            var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions { Headless = true });
            var page = await browser.NewPageAsync();

            await page.GotoAsync("https://planoaliados.com.br/portal/login");

            // Teste simples de login
            // Você pode expandir para um fluxo de login mais complexo aqui
            var loginPage = new Pages.LoginPage(page);
            await loginPage.LoginAsync("usuario", "senha");

            // Validar que login foi bem-sucedido
            bool isErrorVisible = await loginPage.IsErrorMessageVisibleAsync();
            if (!isErrorVisible)
            {
                Console.WriteLine("Login bem-sucedido!");
            }
            else
            {
                Console.WriteLine("Erro ao realizar login.");
            }

            await browser.CloseAsync();
        }
    }
}
