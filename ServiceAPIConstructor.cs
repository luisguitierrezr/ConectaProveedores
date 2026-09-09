using System.Diagnostics;

namespace ssConectaProveedores {

    public partial class ServiceAPIController : OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions.ServiceActionsApiController {

        private static readonly ActivitySource activitySource = new("ssConectaProveedores");

        public ServiceAPIController(
            IAppInfo appInfo,
            IApplicationLogger applicationLogger,
            ISettingsProvider settingsProvider,
            IHttpContextAccessor httpContextAccessor,
            IRequestContext requestContext
        ) : base(
            appInfo,
            applicationLogger,
            settingsProvider,
            httpContextAccessor,
            requestContext
        ) {
        }
    }
}
