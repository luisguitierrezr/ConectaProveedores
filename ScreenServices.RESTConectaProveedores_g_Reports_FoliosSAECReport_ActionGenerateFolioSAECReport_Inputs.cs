using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_OffsetUtc")]
public int? inParami_OffsetUtc;
[JsonProperty("IsToEmpty")]
public bool? inParamIsToEmpty;
[JsonProperty("SupplierId")]
public long? inParamSupplierId;
[JsonProperty("UserRegion")]
public long? inParamUserRegion;
[JsonProperty("IsAllRegions")]
public bool? inParamIsAllRegions;
[JsonProperty("Report60_OrderNumber")]
public string inParamReport60_OrderNumber;
[JsonProperty("Report60_SupplierId")]
public long? inParamReport60_SupplierId;
[JsonProperty("Report60_StartDate")]
public String inParamReport60_StartDate;
[JsonProperty("Report60_EndDate")]
public String inParamReport60_EndDate;
[JsonProperty("Report60_RegionId")]
public long? inParamReport60_RegionId;
[JsonProperty("Report60_StatusId")]
public int? inParamReport60_StatusId;
[JsonProperty("Report60_SociedadId")]
public long? inParamReport60_SociedadId;
[JsonProperty("Report60_Applicant")]
public string inParamReport60_Applicant;
[JsonProperty("Report60_AreaId")]
public long? inParamReport60_AreaId;


    public static RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Model ToModel() {ConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Model result = new ConectaProveedores_g_Reports_FoliosSAECReport_ActionGenerateFolioSAECReport_Model();
result.inParami_OffsetUtc = inParami_OffsetUtc == null ? 0 : inParami_OffsetUtc.Value;
result.inParamIsToEmpty = inParamIsToEmpty == null ? false : inParamIsToEmpty.Value;
result.inParamSupplierId = inParamSupplierId == null ? 0L : inParamSupplierId.Value;
result.inParamUserRegion = inParamUserRegion == null ? 0L : inParamUserRegion.Value;
result.inParamIsAllRegions = inParamIsAllRegions == null ? false : inParamIsAllRegions.Value;
result.inParamReport60_OrderNumber = inParamReport60_OrderNumber == null ? "" : inParamReport60_OrderNumber;
result.inParamReport60_SupplierId = inParamReport60_SupplierId == null ? 0L : inParamReport60_SupplierId.Value;
result.inParamReport60_StartDate = inParamReport60_StartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamReport60_StartDate);
result.inParamReport60_EndDate = inParamReport60_EndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamReport60_EndDate);
result.inParamReport60_RegionId = inParamReport60_RegionId == null ? 0L : inParamReport60_RegionId.Value;
result.inParamReport60_StatusId = inParamReport60_StatusId == null ? 0 : inParamReport60_StatusId.Value;
result.inParamReport60_SociedadId = inParamReport60_SociedadId == null ? 0L : inParamReport60_SociedadId.Value;
result.inParamReport60_Applicant = inParamReport60_Applicant == null ? "" : inParamReport60_Applicant;
result.inParamReport60_AreaId = inParamReport60_AreaId == null ? 0L : inParamReport60_AreaId.Value;
return result;
}

}
