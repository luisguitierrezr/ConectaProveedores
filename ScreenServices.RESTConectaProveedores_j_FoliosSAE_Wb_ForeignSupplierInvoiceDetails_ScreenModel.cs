using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFolioById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0d7cf510ad0e091abdf9a2eb501fc0e9> ScreenDataSetGetFolioById;
[JsonProperty("i_FolioId")]
public long? inParami_FolioId;
[JsonProperty("TextVar")]
public string varLcTextVar;
[JsonProperty("TextVar2")]
public string varLcTextVar2;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel ToModel() {long inParami_FolioId = variables.inParami_FolioId == null ? 0L : variables.inParami_FolioId.Value;
string varLcTextVar = variables.varLcTextVar == null ? "" : variables.varLcTextVar;
string varLcTextVar2 = variables.varLcTextVar2 == null ? "" : variables.varLcTextVar2;
AggregateRecord<RL_06a48d30ec1735b8ae6350ea4dbe82c6> _ScreenDataSetGetFolioById = (variables.ScreenDataSetGetFolioById != null) ? variables.ScreenDataSetGetFolioById.FromJS((array) => {
return RL_06a48d30ec1735b8ae6350ea4dbe82c6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0d7cf510ad0e091abdf9a2eb501fc0e9.ToStructure);
}
) : null;
ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel screenModel = new ConectaProveedores_j_FoliosSAE_Wb_ForeignSupplierInvoiceDetails_ScreenModel(inParami_FolioId, varLcTextVar, varLcTextVar2, _ScreenDataSetGetFolioById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
