using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInvoicesByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5> ScreenDataSetGetInvoicesByFolioId;
[JsonProperty("GetFolioFilesByFolioId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e> ScreenDataSetGetFolioFilesByFolioId;
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("ZipName")]
public string inParamZipName;
[JsonProperty("ButtonName")]
public string inParamButtonName;
[JsonProperty("FileJsonList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure> varLcFileJsonList;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
string inParamZipName = variables.inParamZipName == null ? "" : variables.inParamZipName;
string inParamButtonName = variables.inParamButtonName == null ? "" : variables.inParamButtonName;
RL_e2f87228588c7237002d108caedf9018 varLcFileJsonList = RL_e2f87228588c7237002d108caedf9018.FromRestList(variables.varLcFileJsonList, ssConectaProveedores.RestRecords.RESTST_6c0a0d3b1d72414f90bb9301bad200fbStructure.ToStructure);
AggregateRecord<RL_9d61cc7501a4784be77b036c540a3e93> _ScreenDataSetGetInvoicesByFolioId = (variables.ScreenDataSetGetInvoicesByFolioId != null) ? variables.ScreenDataSetGetInvoicesByFolioId.FromJS((array) => {
return RL_9d61cc7501a4784be77b036c540a3e93.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_d0f36b0aa01c99a6864922a3e47b0bc5.ToStructure);
}
) : null;
AggregateRecord<RL_599a55f2ca551e3817b27381ea3fcd80> _ScreenDataSetGetFolioFilesByFolioId = (variables.ScreenDataSetGetFolioFilesByFolioId != null) ? variables.ScreenDataSetGetFolioFilesByFolioId.FromJS((array) => {
return RL_599a55f2ca551e3817b27381ea3fcd80.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_db98be0f77f582e2a41dd64bb6a4005e.ToStructure);
}
) : null;
ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel screenModel = new ConectaProveedores_s_Storage_wb_DownloadAllFolioFilesByInvoiceId_ScreenModel(inParamInvoiceId, inParamZipName, inParamButtonName, varLcFileJsonList, _ScreenDataSetGetInvoicesByFolioId, _ScreenDataSetGetFolioFilesByFolioId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
