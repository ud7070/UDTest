using System.Web.Mvc;

namespace Test.Areas.Control
{
    public class ControlAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Control";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Control_default",
                "Control/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
            //context.MapRoute(
            //    this.AreaName + "default",
            //    this.AreaName + "/{controller}/{action}/{id}",
            //    new { area = this.AreaName, controller = "Home", action = "Index", id = UrlParameter.Optional },
            //    new string[] { "Test.Areas." + this.AreaName + ".Controllers" }
            //);
        }
    }
}
