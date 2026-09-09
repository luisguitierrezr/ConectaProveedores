using OutSystems.Application.Abstractions.Logging;
using OutSystems.Application.Diagnostics.Metrics;
using OutSystems.Application.Events.ErrorHandling;
using OutSystems.Application.Events.Payload;
using OutSystems.Application.Events.Security;
using OutSystems.Application.GlobalEvents;
using OutSystems.Application.GlobalEvents.Subscriber;

namespace ssConectaProveedores;

[EventSubscriber("ce812e4f-9978-4373-8236-2e58e6f59d99", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828")]
public sealed class EventHandlerEventHandler4_8744de8a116e4dc9ad84db864c433ba3 : AbstractEventSubscriber<EventPayloads.GlobalEventOnSendFolioIncorrectAssignmentPayload> {
    private static readonly System.Diagnostics.ActivitySource activitySource = new("ssConectaProveedores");

    public EventHandlerEventHandler4_8744de8a116e4dc9ad84db864c433ba3(
        IApplicationLogger applicationLogger,
        IEventPayloadService eventPayloadService,
        IAssetMetrics assetMetrics,
        IAppHealthService appHealthService
    ) : base(applicationLogger, eventPayloadService, "OnSendFolioIncorrectAssignment", "ce812e4f-9978-4373-8236-2e58e6f59d99", assetMetrics, appHealthService) { }

    public override async Task HandleEventAsync(IRequestContext requestContext, EventPayloads.GlobalEventOnSendFolioIncorrectAssignmentPayload @event, CancellationToken cancellationToken) {
cancellationToken.ThrowIfCancellationRequested();
var inParami_FolioId = @event.inParami_FolioId.Value;
var inParami_RejectMotive = @event.inParami_RejectMotive;
await Actions.ActionEventSendFolioIncorrectAssignment(requestContext,inParami_FolioId,inParami_RejectMotive,cancellationToken);


}

}
