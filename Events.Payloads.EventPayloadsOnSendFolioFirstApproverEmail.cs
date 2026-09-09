using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnSendFolioFirstApproverEmailPayload : IJsonOnSerializing {
[JsonPropertyName("697c5846-7ff0-4147-a409-8c32854c427b")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_FolioId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParami_FolioId{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
}

}


}