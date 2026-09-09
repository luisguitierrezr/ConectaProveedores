using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFoliosBySupplierId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_def4a4b06f199364b3c4464c2355286a> ScreenDataSetGetFoliosBySupplierId;
[JsonProperty("OrderId")]
public long? inParamOrderId;
[JsonProperty("TableSort")]
public string varLcTableSort;
[JsonProperty("StartIndex")]
public int? varLcStartIndex;
[JsonProperty("l_ReInvokeToggler")]
public bool? varLcl_ReInvokeToggler;
[JsonProperty("l_ColumnJSONVarGetFolios")]
public string varLcl_ColumnJSONVarGetFolios;
[JsonProperty("l_FolioIdSelectedToCancel")]
public long? varLcl_FolioIdSelectedToCancel;
[JsonProperty("l_ShowCancellationConfirmPopup")]
public bool? varLcl_ShowCancellationConfirmPopup;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel ToModel() {long inParamOrderId = variables.inParamOrderId == null ? 0L : variables.inParamOrderId.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
int varLcStartIndex = variables.varLcStartIndex == null ? 0 : variables.varLcStartIndex.Value;
bool varLcl_ReInvokeToggler = variables.varLcl_ReInvokeToggler == null ? false : variables.varLcl_ReInvokeToggler.Value;
string varLcl_ColumnJSONVarGetFolios = variables.varLcl_ColumnJSONVarGetFolios == null ? "" : variables.varLcl_ColumnJSONVarGetFolios;
long varLcl_FolioIdSelectedToCancel = variables.varLcl_FolioIdSelectedToCancel == null ? 0L : variables.varLcl_FolioIdSelectedToCancel.Value;
bool varLcl_ShowCancellationConfirmPopup = variables.varLcl_ShowCancellationConfirmPopup == null ? false : variables.varLcl_ShowCancellationConfirmPopup.Value;
AggregateRecord<RL_fbe5076a8f56e344f72f9258ea487c5d> _ScreenDataSetGetFoliosBySupplierId = (variables.ScreenDataSetGetFoliosBySupplierId != null) ? variables.ScreenDataSetGetFoliosBySupplierId.FromJS((array) => {
return RL_fbe5076a8f56e344f72f9258ea487c5d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_def4a4b06f199364b3c4464c2355286a.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_ScreenModel(inParamOrderId, varLcTableSort, varLcStartIndex, varLcl_ReInvokeToggler, varLcl_ColumnJSONVarGetFolios, varLcl_FolioIdSelectedToCancel, varLcl_ShowCancellationConfirmPopup, _ScreenDataSetGetFoliosBySupplierId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
