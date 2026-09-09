using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetSupplierById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce> ScreenDataSetGetSupplierById;
[JsonProperty("l_IsOpenPopUp")]
public bool? varLcl_IsOpenPopUp;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel ToModel() {bool varLcl_IsOpenPopUp = variables.varLcl_IsOpenPopUp == null ? false : variables.varLcl_IsOpenPopUp.Value;
AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> _ScreenDataSetGetSupplierById = (variables.ScreenDataSetGetSupplierById != null) ? variables.ScreenDataSetGetSupplierById.FromJS((array) => {
return RL_d5c1b2482ff109e80580d8b5fb920193.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.ToStructure);
}
) : null;
ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel screenModel = new ConectaProveedores_a_Common_WB_ExternalUserProfile_ScreenModel(varLcl_IsOpenPopUp, _ScreenDataSetGetSupplierById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
