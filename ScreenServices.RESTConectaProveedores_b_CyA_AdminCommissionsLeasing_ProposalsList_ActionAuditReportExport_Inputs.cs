using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Inputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("i_AmountMLFrom_Filter")]
public decimal? inParami_AmountMLFrom_Filter;
[JsonProperty("i_AmountMLTo_Filter")]
public decimal? inParami_AmountMLTo_Filter;
[JsonProperty("i_Bank_Filter")]
public long? inParami_Bank_Filter;
[JsonProperty("i_PaymentDate_FilterFrom")]
public String inParami_PaymentDate_FilterFrom;
[JsonProperty("i_PaymentDate_FilterTo")]
public String inParami_PaymentDate_FilterTo;
[JsonProperty("i_Region_Filter")]
public string inParami_Region_Filter;
[JsonProperty("i_Status_Filter")]
public string inParami_Status_Filter;
[JsonProperty("i_ProposalTypeId")]
public int? inParami_ProposalTypeId;
[JsonProperty("i_Currency_Filter")]
public string inParami_Currency_Filter;
[JsonProperty("i_Search_Filter")]
public string inParami_Search_Filter;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Inputs FromJSON(JObject inputParameters, JsonSerializer settings) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Inputs result = inputParameters.ToObject<RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Inputs>(settings);
return result;
}


    public ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Model ToModel() {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_ActionAuditReportExport_Model();
result.inParami_AmountMLFrom_Filter = inParami_AmountMLFrom_Filter == null ? 0.0M : inParami_AmountMLFrom_Filter.Value;
result.inParami_AmountMLTo_Filter = inParami_AmountMLTo_Filter == null ? 0.0M : inParami_AmountMLTo_Filter.Value;
result.inParami_Bank_Filter = inParami_Bank_Filter == null ? 0L : inParami_Bank_Filter.Value;
result.inParami_PaymentDate_FilterFrom = inParami_PaymentDate_FilterFrom == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_PaymentDate_FilterFrom);
result.inParami_PaymentDate_FilterTo = inParami_PaymentDate_FilterTo == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(inParami_PaymentDate_FilterTo);
result.inParami_Region_Filter = inParami_Region_Filter == null ? "" : inParami_Region_Filter;
result.inParami_Status_Filter = inParami_Status_Filter == null ? "" : inParami_Status_Filter;
result.inParami_ProposalTypeId = inParami_ProposalTypeId == null ? 0 : inParami_ProposalTypeId.Value;
result.inParami_Currency_Filter = inParami_Currency_Filter == null ? "" : inParami_Currency_Filter;
result.inParami_Search_Filter = inParami_Search_Filter == null ? "" : inParami_Search_Filter;
return result;
}

}
