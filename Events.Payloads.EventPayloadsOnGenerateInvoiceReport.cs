using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnGenerateInvoiceReportPayload : IJsonOnSerializing {
[JsonPropertyName("11abf8bb-52aa-41c7-ad5c-4c3d171459dc")]
[System.ComponentModel.DataAnnotations.Display(Name = "InvoiceId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParamInvoiceId{get; set;} = default;
[JsonPropertyName("b01cd604-8c04-428f-bebb-b93d8f2db10d")]
[System.ComponentModel.DataAnnotations.Display(Name = "InvoiceName")]
[System.Text.Json.Serialization.JsonRequired()]
public string inParamInvoiceName{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
EventUtils.ValidateEventTextInputsLength("OnGenerateInvoiceReport","ConectaProveedores",("InvoiceName",inParamInvoiceName?.Length ?? 0));}

}


}