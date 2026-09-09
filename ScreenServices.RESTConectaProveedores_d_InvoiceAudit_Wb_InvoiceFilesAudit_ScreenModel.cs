using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("InvoiceFilesById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_eb0c76f6f640a3fe05b6e66cf112863f> ScreenDataSetInvoiceFilesById;
[JsonProperty("i_InvoiceId")]
public long? inParami_InvoiceId;
[JsonProperty("i_InvoiceName")]
public string inParami_InvoiceName;
[JsonProperty("i_IsSaveAllFiles")]
public bool? inParami_IsSaveAllFiles;
[JsonProperty("i_IsSaveSelectedFiles")]
public bool? inParami_IsSaveSelectedFiles;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel ToModel() {long inParami_InvoiceId = variables.inParami_InvoiceId == null ? 0L : variables.inParami_InvoiceId.Value;
string inParami_InvoiceName = variables.inParami_InvoiceName == null ? "" : variables.inParami_InvoiceName;
bool inParami_IsSaveAllFiles = variables.inParami_IsSaveAllFiles == null ? false : variables.inParami_IsSaveAllFiles.Value;
bool inParami_IsSaveSelectedFiles = variables.inParami_IsSaveSelectedFiles == null ? false : variables.inParami_IsSaveSelectedFiles.Value;
AggregateRecord<RL_a8a8885e97333843e8d61cbbac75c28c> _ScreenDataSetInvoiceFilesById = (variables.ScreenDataSetInvoiceFilesById != null) ? variables.ScreenDataSetInvoiceFilesById.FromJS((array) => {
return RL_a8a8885e97333843e8d61cbbac75c28c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_eb0c76f6f640a3fe05b6e66cf112863f.ToStructure);
}
) : null;
ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel screenModel = new ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_ScreenModel(inParami_InvoiceId, inParami_InvoiceName, inParami_IsSaveAllFiles, inParami_IsSaveSelectedFiles, _ScreenDataSetInvoiceFilesById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
