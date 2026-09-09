using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ActionString_Split_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRCTextRecord> outParamList;


    public static RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ActionString_Split_Outputs FromOutputs(IBehaviorsConfiguration conf, RLTextRecordList outParamList) {RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ActionString_Split_Outputs result = new RESTConectaProveedores_z_TableDownloadsPDF_TableDownloadFolioScreenPDF_ActionString_Split_Outputs();
conf.IncludeBinariesURL = false;
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRCTextRecord tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRCTextRecord();
// Write the needed fields of the record outParamList.CurrentRec.ssSTText2 to the tmpoutParamListElement.AttrText2
tmpoutParamListElement.AttrText2 = new ssConectaProveedores.RestRecords.RESTSTTextStructure();
tmpoutParamListElement.AttrText2.AttrValue = outParamList.CurrentRec.ssSTText2.ssValue;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRCTextRecord>(new ssConectaProveedores.RestRecords.RESTRCTextRecord[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRCTextRecord>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRCTextRecord>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRCTextRecord();
// Write the needed fields of the record outParamList.CurrentRec.ssSTText2 to the tmpoutParamListElement.AttrText2
tmpoutParamListElement.AttrText2 = new ssConectaProveedores.RestRecords.RESTSTTextStructure();
tmpoutParamListElement.AttrText2.AttrValue = outParamList.CurrentRec.ssSTText2.ssValue;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRCTextRecord>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRCTextRecord));
}

return result;
}


    

    
}
