using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord> outParamList;


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_58f754227b79b8198980a29045fa5b11 outParamList) {RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
tmpoutParamListElement.AttrId = (long?) outParamList.CurrentRec.ssId;
tmpoutParamListElement.AttrDescription = outParamList.CurrentRec.ssDescription;
// Write optimized tmpoutParamListElement.AttrExternalId
tmpoutParamListElement.AttrExternalId = "";
// Write optimized tmpoutParamListElement.AttrIsFCP
tmpoutParamListElement.AttrIsFCP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCreatedOn
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCreatedBy
tmpoutParamListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrUpdatedOn
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrUpdatedBy
tmpoutParamListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrIsActive
tmpoutParamListElement.AttrIsActive = (bool?) false;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord();
tmpoutParamListElement.AttrId = (long?) outParamList.CurrentRec.ssId;
tmpoutParamListElement.AttrDescription = outParamList.CurrentRec.ssDescription;
// Write optimized tmpoutParamListElement.AttrExternalId
tmpoutParamListElement.AttrExternalId = "";
// Write optimized tmpoutParamListElement.AttrIsFCP
tmpoutParamListElement.AttrIsFCP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCreatedOn
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCreatedBy
tmpoutParamListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrUpdatedOn
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrUpdatedBy
tmpoutParamListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrIsActive
tmpoutParamListElement.AttrIsActive = (bool?) false;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord));
}

return result;
}


    public static ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model ToModel(RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs variables) {ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model result = new ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model();
result.outParamList = variables == null ? new RL_58f754227b79b8198980a29045fa5b11() : RL_58f754227b79b8198980a29045fa5b11.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.ToStructure);
return result;
}


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs result = new RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord>(ssConectaProveedores.RestRecords.RESTEN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord.FromStructureDelegate(conf));
return result;
}

}
