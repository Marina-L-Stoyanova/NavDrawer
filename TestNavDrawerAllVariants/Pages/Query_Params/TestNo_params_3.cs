using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Pages.Query_Params;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestNo_params_3
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_params_3>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
