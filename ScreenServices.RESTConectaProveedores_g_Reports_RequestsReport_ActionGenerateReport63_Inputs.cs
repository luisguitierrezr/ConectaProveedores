using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("Report63_StartDate")]
public String inParamReport63_StartDate;
[JsonProperty("Report63_EndDate")]
public String inParamReport63_EndDate;
[JsonProperty("Report63_OrderNumber")]
public string inParamReport63_OrderNumber;
[JsonProperty("Report63_SociedadId")]
public long? inParamReport63_SociedadId;
[JsonProperty("UserRegionId")]
public long? inParamUserRegionId;
[JsonProperty("IsAllRegions")]
public bool? inParamIsAllRegions;
[JsonProperty("Report63_SupplierId")]
public long? inParamReport63_SupplierId;
[JsonProperty("Report63_Applicant")]
public string inParamReport63_Applicant;
[JsonProperty("IsToEmpty")]
public bool? inParamIsToEmpty;
[JsonProperty("Report63_RegionId")]
public long? inParamReport63_RegionId;
[JsonProperty("SupplierId")]
public long? inParamSupplierId;
[JsonProperty("InExcel")]
public bool? inParamInExcel;


    public static RESTConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Inputs result = inputParameters.ToObject<RESTConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Inputs>(settings);
return result;
}


    public ConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Model ToModel() {ConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Model result = new ConectaProveedores_g_Reports_RequestsReport_ActionGenerateReport63_Model();
result.inParamReport63_StartDate = inParamReport63_StartDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamReport63_StartDate);
result.inParamReport63_EndDate = inParamReport63_EndDate == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParamReport63_EndDate);
result.inParamReport63_OrderNumber = inParamReport63_OrderNumber == null ? "" : inParamReport63_OrderNumber;
result.inParamReport63_SociedadId = inParamReport63_SociedadId == null ? 0L : inParamReport63_SociedadId.Value;
result.inParamUserRegionId = inParamUserRegionId == null ? 0L : inParamUserRegionId.Value;
result.inParamIsAllRegions = inParamIsAllRegions == null ? false : inParamIsAllRegions.Value;
result.inParamReport63_SupplierId = inParamReport63_SupplierId == null ? 0L : inParamReport63_SupplierId.Value;
result.inParamReport63_Applicant = inParamReport63_Applicant == null ? "" : inParamReport63_Applicant;
result.inParamIsToEmpty = inParamIsToEmpty == null ? false : inParamIsToEmpty.Value;
result.inParamReport63_RegionId = inParamReport63_RegionId == null ? 0L : inParamReport63_RegionId.Value;
result.inParamSupplierId = inParamSupplierId == null ? 0L : inParamSupplierId.Value;
result.inParamInExcel = inParamInExcel == null ? false : inParamInExcel.Value;
return result;
}

}
