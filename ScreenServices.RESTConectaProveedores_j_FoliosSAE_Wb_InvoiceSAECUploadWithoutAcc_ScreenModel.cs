using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("ShowTitle")]
public bool? inParamShowTitle;
[JsonProperty("OrderId")]
public long? inParamOrderId;
[JsonProperty("OrderAccConceptsId")]
public long? inParamOrderAccConceptsId;
[JsonProperty("AccountingDataTypeId")]
public int? inParamAccountingDataTypeId;
[JsonProperty("ErrorMsg")]
public string varLcErrorMsg;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("IsOpenPopupForeigner")]
public bool? varLcIsOpenPopupForeigner;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
[JsonProperty("GetSupplier")]
public RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_DataActionGetSupplier_Outputs varLcGetSupplier;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel ToModel() {bool inParamShowTitle = variables.inParamShowTitle == null ? false : variables.inParamShowTitle.Value;
long inParamOrderId = variables.inParamOrderId == null ? 0L : variables.inParamOrderId.Value;
long inParamOrderAccConceptsId = variables.inParamOrderAccConceptsId == null ? 0L : variables.inParamOrderAccConceptsId.Value;
int inParamAccountingDataTypeId = variables.inParamAccountingDataTypeId == null ? 0 : variables.inParamAccountingDataTypeId.Value;
string varLcErrorMsg = variables.varLcErrorMsg == null ? "" : variables.varLcErrorMsg;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
bool varLcIsOpenPopupForeigner = variables.varLcIsOpenPopupForeigner == null ? false : variables.varLcIsOpenPopupForeigner.Value;
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeign);
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_DataActionGetSupplier_Model _varLcGetSupplier = (variables.varLcGetSupplier != null) ? RESTConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_DataActionGetSupplier_Outputs.ToModel(variables.varLcGetSupplier) : null;
ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUploadWithoutAcc_ScreenModel(inParamShowTitle, inParamOrderId, inParamOrderAccConceptsId, inParamAccountingDataTypeId, varLcErrorMsg, varLcFilesList, varLcIsOpenPopupForeigner, varLcInvoiceForeign, _varLcGetSupplier, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
