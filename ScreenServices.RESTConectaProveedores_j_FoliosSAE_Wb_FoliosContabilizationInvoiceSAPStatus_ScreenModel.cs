using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f> ScreenDataSetGetInvoicesByFolioId;
[JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f049d8b2272822e744e04ef94d71a8ef> ScreenDataSetGetFolioById;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("l_CanUploadInvoice")]
public bool? varLcl_CanUploadInvoice;
[JsonProperty("l_IsInvoiceRetryAccountingRefresh")]
public bool? varLcl_IsInvoiceRetryAccountingRefresh;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
bool varLcl_CanUploadInvoice = variables.varLcl_CanUploadInvoice == null ? true : variables.varLcl_CanUploadInvoice.Value;
bool varLcl_IsInvoiceRetryAccountingRefresh = variables.varLcl_IsInvoiceRetryAccountingRefresh == null ? false : variables.varLcl_IsInvoiceRetryAccountingRefresh.Value;
AggregateRecord<RL_4c91727910427c345e342c96f50fbfbf> _ScreenDataSetGetInvoicesByFolioId = (variables.ScreenDataSetGetInvoicesByFolioId != null) ? variables.ScreenDataSetGetInvoicesByFolioId.FromJS((array) => {
return RL_4c91727910427c345e342c96f50fbfbf.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cad676a01e44d775889bfdee9f2eda1f.ToStructure);
}
) : null;
AggregateRecord<RL_66bb1349260f72f9d01bbe22c0aaf421> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_66bb1349260f72f9d01bbe22c0aaf421.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f049d8b2272822e744e04ef94d71a8ef.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FoliosContabilizationInvoiceSAPStatus_ScreenModel(inParami_FolioId, varLcl_CanUploadInvoice, varLcl_IsInvoiceRetryAccountingRefresh, _ScreenDataSetGetInvoicesByFolioId, _ScreenDataSetGetFolioById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
