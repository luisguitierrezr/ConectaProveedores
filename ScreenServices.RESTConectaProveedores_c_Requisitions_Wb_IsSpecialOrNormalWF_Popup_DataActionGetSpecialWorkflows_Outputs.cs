using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ApprovalProcessList")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> outParamApprovalProcessList;


    public static RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessList) {RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs();
// Write the needed fields of the list outParamApprovalProcessList to the result.outParamApprovalProcessList
ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord tmpoutParamApprovalProcessListElement;
if(outParamApprovalProcessList.Empty) {
// Write the needed fields of the record outParamApprovalProcessList.CurrentRec to the tmpoutParamApprovalProcessListElement
tmpoutParamApprovalProcessListElement = new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
tmpoutParamApprovalProcessListElement.AttrId = (long?) outParamApprovalProcessList.CurrentRec.ssId;
// Write optimized tmpoutParamApprovalProcessListElement.AttrProcessTypeId
tmpoutParamApprovalProcessListElement.AttrProcessTypeId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrSpecialWorkflowId
tmpoutParamApprovalProcessListElement.AttrSpecialWorkflowId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrApprovalProcessTypeId
tmpoutParamApprovalProcessListElement.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamApprovalProcessListElement.AttrRegionId
tmpoutParamApprovalProcessListElement.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrAccountingRegionId
tmpoutParamApprovalProcessListElement.AttrAccountingRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrGroup
tmpoutParamApprovalProcessListElement.AttrGroup = "";
tmpoutParamApprovalProcessListElement.AttrCode = outParamApprovalProcessList.CurrentRec.ssCode;
// Write optimized tmpoutParamApprovalProcessListElement.AttrVersion
tmpoutParamApprovalProcessListElement.AttrVersion = (int?) 0;
tmpoutParamApprovalProcessListElement.AttrDescription = outParamApprovalProcessList.CurrentRec.ssDescription;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsActive
tmpoutParamApprovalProcessListElement.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsSpecial
tmpoutParamApprovalProcessListElement.AttrIsSpecial = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsDonation
tmpoutParamApprovalProcessListElement.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsCxPCorporativo_DEPREC
tmpoutParamApprovalProcessListElement.AttrIsCxPCorporativo_DEPREC = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrCreatedBy
tmpoutParamApprovalProcessListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamApprovalProcessListElement.AttrCreatedOn
tmpoutParamApprovalProcessListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessListElement.AttrUpdatedBy
tmpoutParamApprovalProcessListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamApprovalProcessListElement.AttrUpdatedOn
tmpoutParamApprovalProcessListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
tmpoutParamApprovalProcessListElement.AttrIsSelectFirstApprover = (bool?) outParamApprovalProcessList.CurrentRec.ssIsSelectFirstApprover;
result.outParamApprovalProcessList = new RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord[] {}, tmpoutParamApprovalProcessListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>
 tmpoutParamApprovalProcessList1List = new List<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>
();
try {outParamApprovalProcessList.StartIteration();
while (!(outParamApprovalProcessList.Eof)) {
// Write the needed fields of the record outParamApprovalProcessList.CurrentRec to the tmpoutParamApprovalProcessListElement
tmpoutParamApprovalProcessListElement = new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
tmpoutParamApprovalProcessListElement.AttrId = (long?) outParamApprovalProcessList.CurrentRec.ssId;
// Write optimized tmpoutParamApprovalProcessListElement.AttrProcessTypeId
tmpoutParamApprovalProcessListElement.AttrProcessTypeId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrSpecialWorkflowId
tmpoutParamApprovalProcessListElement.AttrSpecialWorkflowId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrApprovalProcessTypeId
tmpoutParamApprovalProcessListElement.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamApprovalProcessListElement.AttrRegionId
tmpoutParamApprovalProcessListElement.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrAccountingRegionId
tmpoutParamApprovalProcessListElement.AttrAccountingRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessListElement.AttrGroup
tmpoutParamApprovalProcessListElement.AttrGroup = "";
tmpoutParamApprovalProcessListElement.AttrCode = outParamApprovalProcessList.CurrentRec.ssCode;
// Write optimized tmpoutParamApprovalProcessListElement.AttrVersion
tmpoutParamApprovalProcessListElement.AttrVersion = (int?) 0;
tmpoutParamApprovalProcessListElement.AttrDescription = outParamApprovalProcessList.CurrentRec.ssDescription;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsActive
tmpoutParamApprovalProcessListElement.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsSpecial
tmpoutParamApprovalProcessListElement.AttrIsSpecial = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsDonation
tmpoutParamApprovalProcessListElement.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrIsCxPCorporativo_DEPREC
tmpoutParamApprovalProcessListElement.AttrIsCxPCorporativo_DEPREC = (bool?) false;
// Write optimized tmpoutParamApprovalProcessListElement.AttrCreatedBy
tmpoutParamApprovalProcessListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamApprovalProcessListElement.AttrCreatedOn
tmpoutParamApprovalProcessListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessListElement.AttrUpdatedBy
tmpoutParamApprovalProcessListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamApprovalProcessListElement.AttrUpdatedOn
tmpoutParamApprovalProcessListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
tmpoutParamApprovalProcessListElement.AttrIsSelectFirstApprover = (bool?) outParamApprovalProcessList.CurrentRec.ssIsSelectFirstApprover;
tmpoutParamApprovalProcessList1List.Add(tmpoutParamApprovalProcessListElement);
outParamApprovalProcessList.Advance();
}

} finally {
outParamApprovalProcessList.EndIteration();
}

result.outParamApprovalProcessList = new RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(tmpoutParamApprovalProcessList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord));
}

return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model result = new ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model();
result.outParamApprovalProcessList = variables == null ? new RL_ce09c545b541edeabab89435c34c64f0() : RL_ce09c545b541edeabab89435c34c64f0.FromRestList(variables.outParamApprovalProcessList, ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure);
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_IsSpecialOrNormalWF_Popup_DataActionGetSpecialWorkflows_Outputs();
result.outParamApprovalProcessList = screenModel.outParamApprovalProcessList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructureDelegate(conf));
return result;
}

}
