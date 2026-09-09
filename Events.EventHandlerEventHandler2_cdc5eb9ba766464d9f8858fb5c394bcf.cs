using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("25ff866d-6edc-4dc9-8233-8f1985921947", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler2_cdc5eb9ba766464d9f8858fb5c394bcf : AbstractEventSubscriber<EventPayloads.GlobalEventOnSendFolioFirstApproverEmailPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler2_cdc5eb9ba766464d9f8858fb5c394bcf(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnSendFolioFirstApproverEmail", "25ff866d-6edc-4dc9-8233-8f1985921947", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnSendFolioFirstApproverEmailPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParami_FolioId = @event.inParami_FolioId.Value;
await Actions.ActionEventSendFolioFirstApproverEmail(requestContext,inParami_FolioId,cancellationToken);


}

}
