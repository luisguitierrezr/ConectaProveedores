using System.Diagnostics;
using System.Threading;
using OutSystems.Application.Timers;
using Debugger = OutSystems.HubEdition.RuntimePlatform.Debugger;

namespace ssConectaProveedores {
    public class TimerTimerProcessFileIntoProposal : ITimerExecutor {
        public const string TimerName = "TimerProcessFileIntoProposal";
        public static readonly Guid TimerKey = Guid.Parse("65b8f88c-4e6e-4e97-8f4c-2351549e1558");

        public string Name => TimerName;
        public Guid Key => TimerKey;
        public string ActionName => "TimerProcessFileIntoProposal";

        private readonly IApplicationLogger applicationLogger;

        public TimerTimerProcessFileIntoProposal (IApplicationLogger applicationLogger) {
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
await Actions.ActionTimerProcessFileIntoProposal(requestContext,cancellationToken);
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
/// Action: WakeTimerProcessFileIntoProposal
/// </summary>

public static async Task WakeTimerProcessFileIntoProposal(IRequestContext requestContext,CancellationToken cancellationToken) {
var wakeTimerService = ServiceLocator.GetService<IWakeTimerService>();
await wakeTimerService.WakeTimerAsync(TimerTimerProcessFileIntoProposal.TimerKey, cancellationToken);
return;
}

}

}
