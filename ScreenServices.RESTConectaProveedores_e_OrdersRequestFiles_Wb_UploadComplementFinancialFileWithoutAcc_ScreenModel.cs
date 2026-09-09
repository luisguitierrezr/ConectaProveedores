using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetOrderAccConceptById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f> ScreenDataSetGetOrderAccConceptById;
[JsonProperty("OrderMainId")]
public long? inParamOrderMainId;
[JsonProperty("OrderAccConceptsId")]
public long? inParamOrderAccConceptsId;
[JsonProperty("AccountingDataTypeId")]
public int? inParamAccountingDataTypeId;
[JsonProperty("i_OrderRequestFileId")]
public long? inParami_OrderRequestFileId;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesList;
[JsonProperty("FilesListExtra")]
public RestList<ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure> varLcFilesListExtra;
[JsonProperty("InvoiceForeign")]
public ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign;
[JsonProperty("Invoice")]
public ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoice;
[JsonProperty("AreFilesUploaded")]
public bool? varLcAreFilesUploaded;
[JsonProperty("ClaveProdServ")]
public string varLcClaveProdServ;
[JsonProperty("TipoDeComprobante")]
public string varLcTipoDeComprobante;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel ToModel() {long inParamOrderMainId = variables.inParamOrderMainId == null ? 0L : variables.inParamOrderMainId.Value;
long inParamOrderAccConceptsId = variables.inParamOrderAccConceptsId == null ? 0L : variables.inParamOrderAccConceptsId.Value;
int inParamAccountingDataTypeId = variables.inParamAccountingDataTypeId == null ? 0 : variables.inParamAccountingDataTypeId.Value;
long inParami_OrderRequestFileId = variables.inParami_OrderRequestFileId == null ? 0L : variables.inParami_OrderRequestFileId.Value;
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesList = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
RL_1501ee54ff868a67eff67465502ee3d9 varLcFilesListExtra = RL_1501ee54ff868a67eff67465502ee3d9.FromRestList(variables.varLcFilesListExtra, ssConectaProveedores.RestRecords.RESTST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure.ToStructure);
ST_6f620840109ac6f721328b723ec0152cStructure varLcInvoiceForeign = ssConectaProveedores.RestRecords.RESTST_6f620840109ac6f721328b723ec0152cStructure.ToStructure(variables.varLcInvoiceForeign);
EN_d1d0320db36efbb094ad0082361435a0EntityRecord varLcInvoice = ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord.ToStructure(variables.varLcInvoice);
bool varLcAreFilesUploaded = variables.varLcAreFilesUploaded == null ? false : variables.varLcAreFilesUploaded.Value;
string varLcClaveProdServ = variables.varLcClaveProdServ == null ? "" : variables.varLcClaveProdServ;
string varLcTipoDeComprobante = variables.varLcTipoDeComprobante == null ? "" : variables.varLcTipoDeComprobante;
AggregateRecord<RL_95d1f6e611a5505299d1e9919fa0d9e6> _ScreenDataSetGetOrderAccConceptById = (variables.ScreenDataSetGetOrderAccConceptById != null) ? variables.ScreenDataSetGetOrderAccConceptById.FromJS((array) => {
return RL_95d1f6e611a5505299d1e9919fa0d9e6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ea3a117956fd50e1901759909d3fbc2f.ToStructure);
}
) : null;
ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel screenModel = new ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementFinancialFileWithoutAcc_ScreenModel(inParamOrderMainId, inParamOrderAccConceptsId, inParamAccountingDataTypeId, inParami_OrderRequestFileId, varLcFilesList, varLcFilesListExtra, varLcInvoiceForeign, varLcInvoice, varLcAreFilesUploaded, varLcClaveProdServ, varLcTipoDeComprobante, _ScreenDataSetGetOrderAccConceptById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
