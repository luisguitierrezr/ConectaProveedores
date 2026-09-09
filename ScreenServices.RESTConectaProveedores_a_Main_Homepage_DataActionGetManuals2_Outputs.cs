using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ManualsList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5> outParamManualsList;
[JsonProperty("ShowViewAll")]
public bool? outParamShowViewAll;


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_942b1ced293ccdcd219668b20e3afeb8 outParamManualsList, bool outParamShowViewAll) {RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs();
// Write the needed fields of the list outParamManualsList to the result.outParamManualsList
ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5 tmpoutParamManualsListElement;
if(outParamManualsList.Empty) {
// Write the needed fields of the record outParamManualsList.CurrentRec to the tmpoutParamManualsListElement
tmpoutParamManualsListElement = new ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5();
// Write optimized tmpoutParamManualsListElement.AttrDescription
tmpoutParamManualsListElement.AttrDescription = "";
// Write optimized tmpoutParamManualsListElement.AttrShortDescription
tmpoutParamManualsListElement.AttrShortDescription = "";
tmpoutParamManualsListElement.AttrTitle = outParamManualsList.CurrentRec.ssTitle;
// Write optimized tmpoutParamManualsListElement.AttrStar
tmpoutParamManualsListElement.AttrStar = (bool?) false;
tmpoutParamManualsListElement.AttrId = (long?) outParamManualsList.CurrentRec.ssId;
result.outParamManualsList = new RestList<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5>(new ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5[] {}, tmpoutParamManualsListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5>
 tmpoutParamManualsList1List = new List<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5>
();
try {outParamManualsList.StartIteration();
while (!(outParamManualsList.Eof)) {
// Write the needed fields of the record outParamManualsList.CurrentRec to the tmpoutParamManualsListElement
tmpoutParamManualsListElement = new ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5();
// Write optimized tmpoutParamManualsListElement.AttrDescription
tmpoutParamManualsListElement.AttrDescription = "";
// Write optimized tmpoutParamManualsListElement.AttrShortDescription
tmpoutParamManualsListElement.AttrShortDescription = "";
tmpoutParamManualsListElement.AttrTitle = outParamManualsList.CurrentRec.ssTitle;
// Write optimized tmpoutParamManualsListElement.AttrStar
tmpoutParamManualsListElement.AttrStar = (bool?) false;
tmpoutParamManualsListElement.AttrId = (long?) outParamManualsList.CurrentRec.ssId;
tmpoutParamManualsList1List.Add(tmpoutParamManualsListElement);
outParamManualsList.Advance();
}

} finally {
outParamManualsList.EndIteration();
}

result.outParamManualsList = new RestList<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5>(tmpoutParamManualsList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5));
}

// Write optimized result.outParamShowViewAll
result.outParamShowViewAll = (bool?) false;
return result;
}


    public static ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model ToModel(RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs variables) {ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model result = new ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model();
result.outParamManualsList = variables == null ? new RL_942b1ced293ccdcd219668b20e3afeb8() : RL_942b1ced293ccdcd219668b20e3afeb8.FromRestList(variables.outParamManualsList, ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5.ToStructure);
result.outParamShowViewAll = variables == null || variables.outParamShowViewAll == null ? false : variables.outParamShowViewAll.Value;
return result;
}


    public static RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs result = new RESTConectaProveedores_a_Main_Homepage_DataActionGetManuals2_Outputs();
result.outParamManualsList = screenModel.outParamManualsList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5>(ssConectaProveedores.RestRecords.RESTRC_0601d361b69aac23601da3c9e115bec5.FromStructureDelegate(conf));
result.outParamShowViewAll = (bool?) screenModel.outParamShowViewAll;
return result;
}

}
