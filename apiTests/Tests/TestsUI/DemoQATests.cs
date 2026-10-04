using apiTests.ForUI.Pages.DemoQA;

namespace apiTests.TestsUI;

public class DemoQATests : BaseTest
{
    [Test]
    public async Task SelectItemInDropdownAndCheckIt()
    {
        SelectMenuPage selectMenuPage = new SelectMenuPage(Page);
        await selectMenuPage.OpenSelectMenuPageAsync();
        await selectMenuPage.SelectItemInDropdownAsync("Prof.");
        await selectMenuPage.CheckSelectedItemIsDisplayedAsync("Prof.");
    }
}