using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9> ScreenDataSetGetInvoicesApprovalLevels;
[JsonProperty("GetInvoiceById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a> ScreenDataSetGetInvoiceById;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_RefreshWB")]
public String inParami_RefreshWB;
[JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure> varLcList;
[JsonProperty("GetEntraUserManagerList")]
public RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Outputs varLcGetEntraUserManagerList;
[JsonProperty("GetSpecialApprovalLevels")]
public RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs varLcGetSpecialApprovalLevels;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
DateTime inParami_RefreshWB = variables.inParami_RefreshWB == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_RefreshWB, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
RL_4af3045b114dbc57d1481fed5aceb93a varLcList = RL_4af3045b114dbc57d1481fed5aceb93a.FromRestList(variables.varLcList, ssConectaProveedores.RestRecords.RESTST_34625f5643caa3d12448dcec7dd4c7d3Structure.ToStructure);
AggregateRecord<RL_68b561fd1c8e1947226d48378281e5a1> _ScreenDataSetGetInvoicesApprovalLevels = (variables.ScreenDataSetGetInvoicesApprovalLevels != null) ? variables.ScreenDataSetGetInvoicesApprovalLevels.FromJS((array) => {
return RL_68b561fd1c8e1947226d48378281e5a1.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_605897e6a4b36a23ebf729de65626af9.ToStructure);
}
) : null;
AggregateRecord<RL_41aa9995b50bccef3903021154e98b17> _ScreenDataSetGetInvoiceById = (variables.ScreenDataSetGetInvoiceById != null) ? variables.ScreenDataSetGetInvoiceById.FromJS((array) => {
return RL_41aa9995b50bccef3903021154e98b17.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0bd21c095360ef78cf6d0f1777ecf52a.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Model _varLcGetEntraUserManagerList = (variables.varLcGetEntraUserManagerList != null) ? RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetEntraUserManagerList_Outputs.ToModel(variables.varLcGetEntraUserManagerList) : null;
ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Model _varLcGetSpecialApprovalLevels = (variables.varLcGetSpecialApprovalLevels != null) ? RESTConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_DataActionGetSpecialApprovalLevels_Outputs.ToModel(variables.varLcGetSpecialApprovalLevels) : null;
ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_ScreenModel(inParami_InvoiceId, inParami_RefreshWB, varLcList, _ScreenDataSetGetInvoicesApprovalLevels, _ScreenDataSetGetInvoiceById, _varLcGetEntraUserManagerList, _varLcGetSpecialApprovalLevels, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
