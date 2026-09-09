using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnAccountingProcessPayload : IJsonOnSerializing {
[JsonPropertyName("27033b33-f2d9-4d65-9fe0-9498e2a9098c")]
[System.ComponentModel.DataAnnotations.Display(Name = "InvoiceAccountingProcessId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParamInvoiceAccountingProcessId{get; set;} = default;
[JsonPropertyName("c4b2dd0a-8c3e-4455-ae99-cd6ef4d96598")]
[System.ComponentModel.DataAnnotations.Display(Name = "IsFCP")]
[System.Text.Json.Serialization.JsonRequired()]
public bool? inParamIsFCP{get; set;} = default;
[JsonPropertyName("315f36f0-10be-4e90-a9ad-f3deeb7e3483")]
[System.ComponentModel.DataAnnotations.Display(Name = "IsREQ")]
[System.Text.Json.Serialization.JsonRequired()]
public bool? inParamIsREQ{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
}

}


}