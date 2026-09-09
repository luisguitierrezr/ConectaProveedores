using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetStorageById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514> ScreenDataSetGetStorageById;
[JsonProperty("i_StorageId")]
public long? inParami_StorageId;
[JsonProperty("i_FileSize")]
public long? inParami_FileSize;
[JsonProperty("i_IsTagStyle")]
public bool? inParami_IsTagStyle;
[JsonProperty("i_TagText")]
public string inParami_TagText;
[JsonProperty("i_ExtendedClass")]
public string inParami_ExtendedClass;
[JsonProperty("l_PopupToggler")]
public bool? varLcl_PopupToggler;
[JsonProperty("FileStruct")]
public ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure varLcFileStruct;
[JsonProperty("XML_Text")]
public string varLcXML_Text;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel ToModel() {long inParami_StorageId = variables.inParami_StorageId == null ? 0L : variables.inParami_StorageId.Value;
long inParami_FileSize = variables.inParami_FileSize == null ? 0L : variables.inParami_FileSize.Value;
bool inParami_IsTagStyle = variables.inParami_IsTagStyle == null ? false : variables.inParami_IsTagStyle.Value;
string inParami_TagText = variables.inParami_TagText == null ? "" : variables.inParami_TagText;
string inParami_ExtendedClass = variables.inParami_ExtendedClass == null ? "" : variables.inParami_ExtendedClass;
bool varLcl_PopupToggler = variables.varLcl_PopupToggler == null ? false : variables.varLcl_PopupToggler.Value;
ST_a158c76eb93396680623c04244f48b6cStructure varLcFileStruct = ssConectaProveedores.RestRecords.RESTST_a158c76eb93396680623c04244f48b6cStructure.ToStructure(variables.varLcFileStruct);
string varLcXML_Text = variables.varLcXML_Text == null ? "" : variables.varLcXML_Text;
AggregateRecord<RL_d3db3806acf82f8f2cc8b7a1ac07805b> _ScreenDataSetGetStorageById = (variables.ScreenDataSetGetStorageById != null) ? variables.ScreenDataSetGetStorageById.FromJS((array) => {
return RL_d3db3806acf82f8f2cc8b7a1ac07805b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_b2edf1939202eb7e60eb499349388514.ToStructure);
}
) : null;
ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel screenModel = new ConectaProveedores_s_Storage_wb_PreviewFile_ScreenModel(inParami_StorageId, inParami_FileSize, inParami_IsTagStyle, inParami_TagText, inParami_ExtendedClass, varLcl_PopupToggler, varLcFileStruct, varLcXML_Text, _ScreenDataSetGetStorageById, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
