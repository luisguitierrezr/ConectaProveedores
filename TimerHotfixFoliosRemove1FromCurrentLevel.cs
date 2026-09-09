using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerHotfixFoliosRemove1FromCurrentLevel : ITimerExecutor {
        public const string TimerName = "HotfixFoliosRemove1FromCurrentLevel";
        public static readonly Guid TimerKey = Guid.Parse("50575694-e94a-4d16-b3fe-04077f96f1ed");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "HotfixFoliosRemove1FromCurrentLevel";

        private readonly IApplicationLogger applicationLogger;

        public TimerHotfixFoliosRemove1FromCurrentLevel (IApplicationLogger applicationLogger) {
            this.applicationLogger = applicationLogger;
        }

        /// <summary>
        /// Executes a timer action
        /// </summary>
        /// <param name="requestContext"></param>
        /// <param name="cancellationToken"></param>
        public async Task ExecuteAsync(
            IRequestContext requestContext,
            CancellationToken cancellationToken = default
        ) {


            
try {
await Actions.ActionHotfixFoliosRemove1FromCurrentLevel(requestContext,cancellationToken);
}
finally {
}

        }

        // TODO: EvaluateFields is used by the debugger
        public static void EvaluateFields(VarValue variable, Object parent, String baseName, String fields) {
            variable.Found = false;
        }
    }

    public partial class ExtendedActions {
/// <summary>
/// Action: WakeHotfixFoliosRemove1FromCurrentLevel
/// </summary>

public static async Task WakeHotfixFoliosRemove1FromCurrentLevel(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerHotfixFoliosRemove1FromCurrentLevel.TimerKey, cancellationToken);
return;
}

}

}
