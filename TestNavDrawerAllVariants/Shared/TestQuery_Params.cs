using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Shared;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestQuery_Params
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var componentUnderTest = ctx.RenderComponent<Query_Params>();
      Assert.NotNull(componentUnderTest);
    }
  }
}
