using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Pages.No_params;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestNo_params_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_params_1>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
