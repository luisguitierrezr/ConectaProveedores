using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetAllPositionContacts")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d> ScreenDataSetGetAllPositionContacts;
[JsonProperty("GetPositionContactsById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d> ScreenDataSetGetPositionContactsById;
[JsonProperty("PositionContactId")]
public long? inParamPositionContactId;
[JsonProperty("Label")]
public string inParamLabel;
[JsonProperty("ReadOnly")]
public bool? inParamReadOnly;
[JsonProperty("ShowLabelFirst")]
public bool? inParamShowLabelFirst;
[JsonProperty("AllowAddNew")]
public bool? inParamAllowAddNew;
[JsonProperty("IsMandatory")]
public bool? inParamIsMandatory;
[JsonProperty("AddNew")]
public bool? varLcAddNew;
[JsonProperty("Editable")]
public bool? varLcEditable;
[JsonProperty("NewPositionContact")]
public string varLcNewPositionContact;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel ToModel() {long inParamPositionContactId = variables.inParamPositionContactId == null ? 0L : variables.inParamPositionContactId.Value;
string inParamLabel = variables.inParamLabel == null ? "" : variables.inParamLabel;
bool inParamReadOnly = variables.inParamReadOnly == null ? false : variables.inParamReadOnly.Value;
bool inParamShowLabelFirst = variables.inParamShowLabelFirst == null ? true : variables.inParamShowLabelFirst.Value;
bool inParamAllowAddNew = variables.inParamAllowAddNew == null ? false : variables.inParamAllowAddNew.Value;
bool inParamIsMandatory = variables.inParamIsMandatory == null ? false : variables.inParamIsMandatory.Value;
bool varLcAddNew = variables.varLcAddNew == null ? false : variables.varLcAddNew.Value;
bool varLcEditable = variables.varLcEditable == null ? false : variables.varLcEditable.Value;
string varLcNewPositionContact = variables.varLcNewPositionContact == null ? "" : variables.varLcNewPositionContact;
AggregateRecord<RL_084ec93001d810170970c8007b50b58f> _ScreenDataSetGetAllPositionContacts = (variables.ScreenDataSetGetAllPositionContacts != null) ? variables.ScreenDataSetGetAllPositionContacts.FromJS((array) => {
return RL_084ec93001d810170970c8007b50b58f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d.ToStructure);
}
) : null;
AggregateRecord<RL_084ec93001d810170970c8007b50b58f> _ScreenDataSetGetPositionContactsById = (variables.ScreenDataSetGetPositionContactsById != null) ? variables.ScreenDataSetGetPositionContactsById.FromJS((array) => {
return RL_084ec93001d810170970c8007b50b58f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_3ae851ff8b62d3b4ff8041de781ce47d.ToStructure);
}
) : null;
ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel screenModel = new ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel(inParamPositionContactId, inParamLabel, inParamReadOnly, inParamShowLabelFirst, inParamAllowAddNew, inParamIsMandatory, varLcAddNew, varLcEditable, varLcNewPositionContact, _ScreenDataSetGetAllPositionContacts, _ScreenDataSetGetPositionContactsById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
