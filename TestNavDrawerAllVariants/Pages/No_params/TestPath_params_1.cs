using Bunit;
using Microsoft.Extensions.DependencyInjection;
using NavDrawerAllVariants.Pages.No_params;
using Microsoft.AspNetCore.Components;

namespace TestNavDrawerAllVariants
{
  [Collection("NavDrawerAllVariants")]
  public class TestPath_params_1
  {
    [Fact]
    public void ViewIsCreated()
    {
      using var ctx = new TestContext();
      ctx.JSInterop.Mode = JSRuntimeMode.Loose;
      var routeData = new RouteData(typeof(Path_params_1), new Dictionary<string, object>());
      ctx.Services.AddSingleton(routeData);
      var componentUnderTest = ctx.RenderComponent<Path_params_1>(p => p.AddCascadingValue(routeData));
      Assert.NotNull(componentUnderTest);
    }
  }
}
