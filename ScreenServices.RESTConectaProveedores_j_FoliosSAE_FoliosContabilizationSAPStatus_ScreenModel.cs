using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSpecialApprovals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5> ScreenDataSetGetSpecialApprovals;
[JsonProperty("GetCurrencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> ScreenDataSetGetCurrencies;
[JsonProperty("GetInvoicesSAP")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d920d0aa189b36e12964653ae47b2e42> ScreenDataSetGetInvoicesSAP;
[JsonProperty("GetFrequencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf> ScreenDataSetGetFrequencies;
[JsonProperty("GetInvoiceStatus")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940> ScreenDataSetGetInvoiceStatus;
[JsonProperty("GetAccountingDataTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c> ScreenDataSetGetAccountingDataTypes;
[JsonProperty("l_ColumnJSONVar")]
public string varLcl_ColumnJSONVar;
[JsonProperty("l_CountAfterFetch")]
public int? varLcl_CountAfterFetch;
[JsonProperty("l_Loading")]
public bool? varLcl_Loading;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_StartIndex")]
public int? varLcl_StartIndex;
[JsonProperty("l_TableSort")]
public string varLcl_TableSort;
[JsonProperty("l_IsSelected")]
public bool? varLcl_IsSelected;
[JsonProperty("l_IsSelectAll")]
public bool? varLcl_IsSelectAll;
[JsonProperty("l_IsShowSelectAll")]
public bool? varLcl_IsShowSelectAll;
[JsonProperty("l_ShowFilters")]
public bool? varLcl_ShowFilters;
[JsonProperty("SelectedIds")]
public string varLcSelectedIds;
[JsonProperty("l_ShowDetails")]
public bool? varLcl_ShowDetails;
[JsonProperty("l_InvoiceId")]
public long? varLcl_InvoiceId;
[JsonProperty("IsAnyBulkApprovable")]
public bool? varLcIsAnyBulkApprovable;
[JsonProperty("l_FolioId")]
public long? varLcl_FolioId;
[JsonProperty("l_AmountFromText")]
public string varLcl_AmountFromText;
[JsonProperty("l_AmountToText")]
public string varLcl_AmountToText;
[JsonProperty("l_TotalsList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d> varLcl_TotalsList;
[JsonProperty("l_IsCalculating")]
public bool? varLcl_IsCalculating;
[JsonProperty("l_TotalSelected")]
public int? varLcl_TotalSelected;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel ToModel() {string varLcl_ColumnJSONVar = variables.varLcl_ColumnJSONVar == null ? "" : variables.varLcl_ColumnJSONVar;
int varLcl_CountAfterFetch = variables.varLcl_CountAfterFetch == null ? 0 : variables.varLcl_CountAfterFetch.Value;
bool varLcl_Loading = variables.varLcl_Loading == null ? false : variables.varLcl_Loading.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
int varLcl_StartIndex = variables.varLcl_StartIndex == null ? 0 : variables.varLcl_StartIndex.Value;
string varLcl_TableSort = variables.varLcl_TableSort == null ? "" : variables.varLcl_TableSort;
bool varLcl_IsSelected = variables.varLcl_IsSelected == null ? false : variables.varLcl_IsSelected.Value;
bool varLcl_IsSelectAll = variables.varLcl_IsSelectAll == null ? false : variables.varLcl_IsSelectAll.Value;
bool varLcl_IsShowSelectAll = variables.varLcl_IsShowSelectAll == null ? false : variables.varLcl_IsShowSelectAll.Value;
bool varLcl_ShowFilters = variables.varLcl_ShowFilters == null ? false : variables.varLcl_ShowFilters.Value;
string varLcSelectedIds = variables.varLcSelectedIds == null ? "" : variables.varLcSelectedIds;
bool varLcl_ShowDetails = variables.varLcl_ShowDetails == null ? false : variables.varLcl_ShowDetails.Value;
long varLcl_InvoiceId = variables.varLcl_InvoiceId == null ? 0L : variables.varLcl_InvoiceId.Value;
bool varLcIsAnyBulkApprovable = variables.varLcIsAnyBulkApprovable == null ? false : variables.varLcIsAnyBulkApprovable.Value;
long varLcl_FolioId = variables.varLcl_FolioId == null ? 0L : variables.varLcl_FolioId.Value;
string varLcl_AmountFromText = variables.varLcl_AmountFromText == null ? "" : variables.varLcl_AmountFromText;
string varLcl_AmountToText = variables.varLcl_AmountToText == null ? "" : variables.varLcl_AmountToText;
RL_8e14ec72aef34f71202ab5fcdfb4c9b8 varLcl_TotalsList = RL_8e14ec72aef34f71202ab5fcdfb4c9b8.FromRestList(variables.varLcl_TotalsList, ssConectaProveedores.RestRecords.RESTRC_4d06af040e4a89ed9c35b745b328b97d.ToStructure);
bool varLcl_IsCalculating = variables.varLcl_IsCalculating == null ? false : variables.varLcl_IsCalculating.Value;
int varLcl_TotalSelected = variables.varLcl_TotalSelected == null ? 0 : variables.varLcl_TotalSelected.Value;
AggregateRecord<RL_0204de281fa136fb826199f876159fe4> _ScreenDataSetGetSpecialApprovals = (variables.ScreenDataSetGetSpecialApprovals != null) ? variables.ScreenDataSetGetSpecialApprovals.FromJS((array) => {
return RL_0204de281fa136fb826199f876159fe4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5.ToStructure);
}
) : null;
AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> _ScreenDataSetGetCurrencies = (variables.ScreenDataSetGetCurrencies != null) ? variables.ScreenDataSetGetCurrencies.FromJS((array) => {
return RL_1353a59e0688582d82bbddc41b47193e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.ToStructure);
}
) : null;
AggregateRecord<RL_036b78d631cef153f668611e54d43e5d> _ScreenDataSetGetInvoicesSAP = (variables.ScreenDataSetGetInvoicesSAP != null) ? variables.ScreenDataSetGetInvoicesSAP.FromJS((array) => {
return RL_036b78d631cef153f668611e54d43e5d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d920d0aa189b36e12964653ae47b2e42.ToStructure);
}
) : null;
AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> _ScreenDataSetGetFrequencies = (variables.ScreenDataSetGetFrequencies != null) ? variables.ScreenDataSetGetFrequencies.FromJS((array) => {
return RL_86161aa08f9858d205ef72cffcb4919d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf.ToStructure);
}
) : null;
AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> _ScreenDataSetGetInvoiceStatus = (variables.ScreenDataSetGetInvoiceStatus != null) ? variables.ScreenDataSetGetInvoiceStatus.FromJS((array) => {
return RL_3262178c68dd5ed5c99ed4279a563975.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_6edb17c5bf63452ff4ac24d41991a940.ToStructure);
}
) : null;
AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> _ScreenDataSetGetAccountingDataTypes = (variables.ScreenDataSetGetAccountingDataTypes != null) ? variables.ScreenDataSetGetAccountingDataTypes.FromJS((array) => {
return RL_d567d658fa66fc955f880e37985e7f35.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel(varLcl_ColumnJSONVar, varLcl_CountAfterFetch, varLcl_Loading, varLcl_ReInvokeToggler, varLcl_StartIndex, varLcl_TableSort, varLcl_IsSelected, varLcl_IsSelectAll, varLcl_IsShowSelectAll, varLcl_ShowFilters, varLcSelectedIds, varLcl_ShowDetails, varLcl_InvoiceId, varLcIsAnyBulkApprovable, varLcl_FolioId, varLcl_AmountFromText, varLcl_AmountToText, varLcl_TotalsList, varLcl_IsCalculating, varLcl_TotalSelected, _ScreenDataSetGetSpecialApprovals, _ScreenDataSetGetCurrencies, _ScreenDataSetGetInvoicesSAP, _ScreenDataSetGetFrequencies, _ScreenDataSetGetInvoiceStatus, _ScreenDataSetGetAccountingDataTypes, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
