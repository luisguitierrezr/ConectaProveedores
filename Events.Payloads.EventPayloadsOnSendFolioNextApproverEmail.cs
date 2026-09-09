using System.Text.Json.Serialization;

namespace ssConectaProveedores;

public static partial class EventPayloads {
    public class GlobalEventOnSendFolioNextApproverEmailPayload : IJsonOnSerializing {
[JsonPropertyName("50016398-20ef-4a56-9555-ea4de4a8f575")]
[System.ComponentModel.DataAnnotations.Display(Name = "i_FolioId")]
[System.Text.Json.Serialization.JsonRequired()]
public long? inParami_FolioId{get; set;} = default;
void IJsonOnSerializing.OnSerializing() {
}

}


}