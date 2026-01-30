using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Shared;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestNo_params
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<No_params>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
