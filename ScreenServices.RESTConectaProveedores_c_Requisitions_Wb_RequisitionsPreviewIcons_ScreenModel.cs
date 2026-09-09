using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("RequisitionFilesById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c> ScreenDataSetRequisitionFilesById;
[JsonProperty("RequisitionId")]
public long? inParamRequisitionId;
[JsonProperty("RequisitionName")]
public string inParamRequisitionName;
[JsonProperty("l_PreviewFilesToggler")]
public bool? varLcl_PreviewFilesToggler;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel ToModel() {long inParamRequisitionId = variables.inParamRequisitionId == null ? 0L : variables.inParamRequisitionId.Value;
string inParamRequisitionName = variables.inParamRequisitionName == null ? "" : variables.inParamRequisitionName;
bool varLcl_PreviewFilesToggler = variables.varLcl_PreviewFilesToggler == null ? false : variables.varLcl_PreviewFilesToggler.Value;
AggregateRecord<RL_dcf9165e080aea63f7a9b95efcf09ef4> _ScreenDataSetRequisitionFilesById = (variables.ScreenDataSetRequisitionFilesById != null) ? variables.ScreenDataSetRequisitionFilesById.FromJS((array) => {
return RL_dcf9165e080aea63f7a9b95efcf09ef4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_dc345357879dcb92e41eacae4ac8926c.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewIcons_ScreenModel(inParamRequisitionId, inParamRequisitionName, varLcl_PreviewFilesToggler, _ScreenDataSetRequisitionFilesById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
