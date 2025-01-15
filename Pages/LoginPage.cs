using Microsoft.Playwright;
using System.Threading.Tasks;

namespace PlaywrightAutomation.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }
        public async Task LoginAsync(string cpf, string senha)
        {
            await _page.FillAsync("#model_Login", cpf);
            await _page.FillAsync("#model_Password", senha);
            await _page.ClickAsync("span.v-btn__content:has-text('Login')");
        }

        public async Task<bool> IsErrorMessageVisibleAsync()
        {
            try
            {
                var errorMessage = await _page.QuerySelectorAsync("#error-message");
                return errorMessage != null;
            }
            catch
            {
                return false;
            }
        }
    }
}
