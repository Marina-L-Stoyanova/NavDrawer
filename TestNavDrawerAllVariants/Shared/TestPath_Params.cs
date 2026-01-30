using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Shared;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestPath_Params
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Path_Params>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
