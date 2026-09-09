using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_m_Manuals_ManualDetailView_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetManualById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_367437e31e499bf19d13607cb372e4f5> ScreenDataSetGetManualById;
[JsonProperty("i_ManualId")]
public long? inParami_ManualId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_m_Manuals_ManualDetailView_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_m_Manuals_ManualDetailView_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_m_Manuals_ManualDetailView_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel ToModel() {long inParami_ManualId = variables.inParami_ManualId == null ? 0L : variables.inParami_ManualId.Value;
AggregateRecord<RL_d2939f0caa78f2bcae0d5522f32cf37b> _ScreenDataSetGetManualById = (variables.ScreenDataSetGetManualById != null) ? variables.ScreenDataSetGetManualById.FromJS((array) => {
return RL_d2939f0caa78f2bcae0d5522f32cf37b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_367437e31e499bf19d13607cb372e4f5.ToStructure);
}
) : null;
ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel screenModel = new ConectaProveedores_m_Manuals_ManualDetailView_ScreenModel(inParami_ManualId, _ScreenDataSetGetManualById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
