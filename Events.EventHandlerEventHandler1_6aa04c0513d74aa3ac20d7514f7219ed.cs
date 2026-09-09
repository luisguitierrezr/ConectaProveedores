using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("a3d02dd1-e313-409d-837e-fd413ba4d509", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler1_6aa04c0513d74aa3ac20d7514f7219ed : AbstractEventSubscriber<EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler1_6aa04c0513d74aa3ac20d7514f7219ed(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnSendFolioNextApproverEmail", "a3d02dd1-e313-409d-837e-fd413ba4d509", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnSendFolioNextApproverEmailPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParami_FolioId = @event.inParami_FolioId.Value;
await Actions.ActionEventSendFolioNextApproverEmail(requestContext,inParami_FolioId,cancellationToken);


}

}
