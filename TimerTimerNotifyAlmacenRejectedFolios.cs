using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerNotifyAlmacenRejectedFolios : ITimerExecutor {
        public const string TimerName = "TimerNotifyAlmacenRejectedFolios";
        public static readonly Guid TimerKey = Guid.Parse("379c0cdd-dc6c-4df3-a975-100a262435a5");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerNotifyAlmacenRejectedFolios";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerNotifyAlmacenRejectedFolios (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerNotifyAlmacenRejectedFolios(requestContext,cancellationToken);
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
/// Action: WakeTimerNotifyAlmacenRejectedFolios
/// </summary>

public static async Task WakeTimerNotifyAlmacenRejectedFolios(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerNotifyAlmacenRejectedFolios.TimerKey, cancellationToken);
return;
}

}

}
