using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("LatestInvoiceComment")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222> ScreenDataSetLatestInvoiceComment;
[JsonProperty("MoreDetails")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b64650646295f01a3e7c46ac44009d3c> ScreenDataSetMoreDetails;
[JsonProperty("InvoiceId")]
public long? inParamInvoiceId;
[JsonProperty("TableSort")]
public string varLcTableSort;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel ToModel() {long inParamInvoiceId = variables.inParamInvoiceId == null ? 0L : variables.inParamInvoiceId.Value;
string varLcTableSort = variables.varLcTableSort == null ? "" : variables.varLcTableSort;
AggregateRecord<RL_2e7f130f9df070446bc2a9ac7dcde539> _ScreenDataSetLatestInvoiceComment = (variables.ScreenDataSetLatestInvoiceComment != null) ? variables.ScreenDataSetLatestInvoiceComment.FromJS((array) => {
return RL_2e7f130f9df070446bc2a9ac7dcde539.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_85ff0b93155717e6346b97d39d3b0222.ToStructure);
}
) : null;
AggregateRecord<RL_555a5d0da2fe2f0e71754918f879d5c3> _ScreenDataSetMoreDetails = (variables.ScreenDataSetMoreDetails != null) ? variables.ScreenDataSetMoreDetails.FromJS((array) => {
return RL_555a5d0da2fe2f0e71754918f879d5c3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b64650646295f01a3e7c46ac44009d3c.ToStructure);
}
) : null;
ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel screenModel = new ConectaProveedores_d_Invoices_Wb_I_MoreDetails_ScreenModel(inParamInvoiceId, varLcTableSort, _ScreenDataSetLatestInvoiceComment, _ScreenDataSetMoreDetails, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
