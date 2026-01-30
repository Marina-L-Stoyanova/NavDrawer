using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Pages;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestNo_navigation
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_navigation>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
