using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_Report62_DateFrom")]
public String inParami_Report62_DateFrom;
[JsonProperty("i_Report62_DateTo")]
public String inParami_Report62_DateTo;
[JsonProperty("i_Report62_RegionId")]
public long? inParami_Report62_RegionId;
[JsonProperty("i_Report62_SupplierId")]
public long? inParami_Report62_SupplierId;
[JsonProperty("i_OffsetUtc")]
public int? inParami_OffsetUtc;


    public static RESTConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Model ToModel() {ConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Model result = new ConectaProveedores_g_Reports_LinesReport_ActionGenerateLinesReport62_Model();
result.inParami_Report62_DateFrom = inParami_Report62_DateFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_Report62_DateFrom);
result.inParami_Report62_DateTo = inParami_Report62_DateTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_Report62_DateTo);
result.inParami_Report62_RegionId = inParami_Report62_RegionId == null ? 0L : inParami_Report62_RegionId.Value;
result.inParami_Report62_SupplierId = inParami_Report62_SupplierId == null ? 0L : inParami_Report62_SupplierId.Value;
result.inParami_OffsetUtc = inParami_OffsetUtc == null ? 0 : inParami_OffsetUtc.Value;
return result;
}

}
