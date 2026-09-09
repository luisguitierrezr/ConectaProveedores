using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28> ScreenDataSetGetFolioById;
[JsonProperty("GetOrderMains")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_8e32b78ccc2e260e65e10c5d6c59046d> ScreenDataSetGetOrderMains;
[JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce> ScreenDataSetGetSuppliers;
[JsonProperty("GetFolioApprovalLevels")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd> ScreenDataSetGetFolioApprovalLevels;
[JsonProperty("GetFolioItemsByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2> ScreenDataSetGetFolioItemsByFolioId;
[JsonProperty("GetCurrencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> ScreenDataSetGetCurrencies;
[JsonProperty("GetCompanies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383> ScreenDataSetGetCompanies;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("l_RefreshOrderEntra_Historic")]
public String varLcl_RefreshOrderEntra_Historic;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("MaxRecords")]
public int? varLcMaxRecords;
[JsonProperty("TableSort2")]
public string varLcTableSort2;
[JsonProperty("IsReadOnly2")]
public bool? varLcIsReadOnly2;
[JsonProperty("ShowCancelFolioPopup")]
public bool? varLcShowCancelFolioPopup;
[JsonProperty("IsExecuting")]
public bool? varLcIsExecuting;
[JsonProperty("FolioReject")]
public ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject;
[JsonProperty("I_CanReject")]
public bool? varLcI_CanReject;
[JsonProperty("I_CanCancelIncoice")]
public bool? varLcI_CanCancelIncoice;
[JsonProperty("GetUserData")]
public RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs varLcGetUserData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
DateTime varLcl_RefreshOrderEntra_Historic = variables.varLcl_RefreshOrderEntra_Historic == null ? BuiltInFunction.CurrDateTime () : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefreshOrderEntra_Historic, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
int varLcMaxRecords = variables.varLcMaxRecords == null ? 50 : variables.varLcMaxRecords.Value;
string varLcTableSort2 = variables.varLcTableSort2 == null ? "" : variables.varLcTableSort2;
bool varLcIsReadOnly2 = variables.varLcIsReadOnly2 == null ? false : variables.varLcIsReadOnly2.Value;
bool varLcShowCancelFolioPopup = variables.varLcShowCancelFolioPopup == null ? false : variables.varLcShowCancelFolioPopup.Value;
bool varLcIsExecuting = variables.varLcIsExecuting == null ? false : variables.varLcIsExecuting.Value;
ST_e54bcdc56c6f092fdfed672ad024bfa4Structure varLcFolioReject = ssConectaProveedores.RestRecords.RESTST_e54bcdc56c6f092fdfed672ad024bfa4Structure.ToStructure(variables.varLcFolioReject);
bool varLcI_CanReject = variables.varLcI_CanReject == null ? false : variables.varLcI_CanReject.Value;
bool varLcI_CanCancelIncoice = variables.varLcI_CanCancelIncoice == null ? false : variables.varLcI_CanCancelIncoice.Value;
AggregateRecord<RL_906cfbdbf8c03778600b870bd5d6309b> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_906cfbdbf8c03778600b870bd5d6309b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3c4405ea19e4fb66009c54078ab80e28.ToStructure);
}
) : null;
AggregateRecord<RL_1751b6fc487a87e5015dd52d099b7396> _ScreenDataSetGetOrderMains = (variables.ScreenDataSetGetOrderMains != null) ? variables.ScreenDataSetGetOrderMains.FromJS((array) => {
return RL_1751b6fc487a87e5015dd52d099b7396.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_8e32b78ccc2e260e65e10c5d6c59046d.ToStructure);
}
) : null;
AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_d5c1b2482ff109e80580d8b5fb920193.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.ToStructure);
}
) : null;
AggregateRecord<RL_a811b54d11345a2c46a0dc7830ffa1de> _ScreenDataSetGetFolioApprovalLevels = (variables.ScreenDataSetGetFolioApprovalLevels != null) ? variables.ScreenDataSetGetFolioApprovalLevels.FromJS((array) => {
return RL_a811b54d11345a2c46a0dc7830ffa1de.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e40e190961051a83f0f95a5985af6cdd.ToStructure);
}
) : null;
AggregateRecord<RL_a968cf9f63475dc9358672149b11245a> _ScreenDataSetGetFolioItemsByFolioId = (variables.ScreenDataSetGetFolioItemsByFolioId != null) ? variables.ScreenDataSetGetFolioItemsByFolioId.FromJS((array) => {
return RL_a968cf9f63475dc9358672149b11245a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_95110bc97f34f4c1561c8cbf2b5015b2.ToStructure);
}
) : null;
AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> _ScreenDataSetGetCurrencies = (variables.ScreenDataSetGetCurrencies != null) ? variables.ScreenDataSetGetCurrencies.FromJS((array) => {
return RL_1353a59e0688582d82bbddc41b47193e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.ToStructure);
}
) : null;
AggregateRecord<RL_1409548829f9518cbebb0e467312ef87> _ScreenDataSetGetCompanies = (variables.ScreenDataSetGetCompanies != null) ? variables.ScreenDataSetGetCompanies.FromJS((array) => {
return RL_1409548829f9518cbebb0e467312ef87.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_06b38e19582fc855dd67cd4191332383.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Model _varLcGetUserData = (variables.varLcGetUserData != null) ? RESTConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_DataActionGetUserData_Outputs.ToModel(variables.varLcGetUserData) : null;
ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_PreApprovalFolioDetail_ScreenModel(inParami_FolioId, varLcl_RefreshOrderEntra_Historic, varLcTableSort, varLcStartIndex, varLcMaxRecords, varLcTableSort2, varLcIsReadOnly2, varLcShowCancelFolioPopup, varLcIsExecuting, varLcFolioReject, varLcI_CanReject, varLcI_CanCancelIncoice, _ScreenDataSetGetFolioById, _ScreenDataSetGetOrderMains, _ScreenDataSetGetSuppliers, _ScreenDataSetGetFolioApprovalLevels, _ScreenDataSetGetFolioItemsByFolioId, _ScreenDataSetGetCurrencies, _ScreenDataSetGetCompanies, _varLcGetUserData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
