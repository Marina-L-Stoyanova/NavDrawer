using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Shared;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestMainLayout
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      ctx.Services.AddIgniteUIBlazor(
        typeof(IgbNavDrawerModule));
      var componentUnderTest = ctx.RenderComponent<MainLayout>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
