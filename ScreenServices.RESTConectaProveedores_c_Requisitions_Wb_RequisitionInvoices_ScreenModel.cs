using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesByRequisitionId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29> ScreenDataSetGetInvoicesByRequisitionId;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("l_CanUploadInvoice")]
public bool? varLcl_CanUploadInvoice;
[JsonProperty("l_IsOpenPopupInvoices")]
public bool? varLcl_IsOpenPopupInvoices;
[JsonProperty("l_InvoiceIdToPopup")]
public long? varLcl_InvoiceIdToPopup;
[JsonProperty("l_InvoiceStatusIdToPopup")]
public int? varLcl_InvoiceStatusIdToPopup;
[JsonProperty("l_IsOpenPopupMultiupload")]
public bool? varLcl_IsOpenPopupMultiupload;
[JsonProperty("GetRequisitionData")]
public RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs varLcGetRequisitionData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel ToModel() {long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
bool varLcl_CanUploadInvoice = variables.varLcl_CanUploadInvoice == null ? false : variables.varLcl_CanUploadInvoice.Value;
bool varLcl_IsOpenPopupInvoices = variables.varLcl_IsOpenPopupInvoices == null ? false : variables.varLcl_IsOpenPopupInvoices.Value;
long varLcl_InvoiceIdToPopup = variables.varLcl_InvoiceIdToPopup == null ? 0L : variables.varLcl_InvoiceIdToPopup.Value;
int varLcl_InvoiceStatusIdToPopup = variables.varLcl_InvoiceStatusIdToPopup == null ? 0 : variables.varLcl_InvoiceStatusIdToPopup.Value;
bool varLcl_IsOpenPopupMultiupload = variables.varLcl_IsOpenPopupMultiupload == null ? false : variables.varLcl_IsOpenPopupMultiupload.Value;
AggregateRecord<RL_9f948f770ba4600f86dd29332a1a7e00> _ScreenDataSetGetInvoicesByRequisitionId = (variables.ScreenDataSetGetInvoicesByRequisitionId != null) ? variables.ScreenDataSetGetInvoicesByRequisitionId.FromJS((array) => {
return RL_9f948f770ba4600f86dd29332a1a7e00.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0034cf2433ba52d290961e6b42045a29.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Model _varLcGetRequisitionData = (variables.varLcGetRequisitionData != null) ? RESTConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_DataActionGetRequisitionData_Outputs.ToModel(variables.varLcGetRequisitionData) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionInvoices_ScreenModel(inParami_RequisitionId, varLcl_CanUploadInvoice, varLcl_IsOpenPopupInvoices, varLcl_InvoiceIdToPopup, varLcl_InvoiceStatusIdToPopup, varLcl_IsOpenPopupMultiupload, _ScreenDataSetGetInvoicesByRequisitionId, _varLcGetRequisitionData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
