using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ApprovalProcessesList")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord> outParamApprovalProcessesList;


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_ce09c545b541edeabab89435c34c64f0 outParamApprovalProcessesList) {RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs();
// Write the needed fields of the list outParamApprovalProcessesList to the result.outParamApprovalProcessesList
ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord tmpoutParamApprovalProcessesListElement;
if(outParamApprovalProcessesList.Empty) {
// Write the needed fields of the record outParamApprovalProcessesList.CurrentRec to the tmpoutParamApprovalProcessesListElement
tmpoutParamApprovalProcessesListElement = new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
tmpoutParamApprovalProcessesListElement.AttrId = (long?) outParamApprovalProcessesList.CurrentRec.ssId;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrProcessTypeId
tmpoutParamApprovalProcessesListElement.AttrProcessTypeId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrSpecialWorkflowId
tmpoutParamApprovalProcessesListElement.AttrSpecialWorkflowId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrApprovalProcessTypeId
tmpoutParamApprovalProcessesListElement.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrRegionId
tmpoutParamApprovalProcessesListElement.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrAccountingRegionId
tmpoutParamApprovalProcessesListElement.AttrAccountingRegionId = (long?) 0L;
tmpoutParamApprovalProcessesListElement.AttrGroup = outParamApprovalProcessesList.CurrentRec.ssGroup;
tmpoutParamApprovalProcessesListElement.AttrCode = outParamApprovalProcessesList.CurrentRec.ssCode;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrVersion
tmpoutParamApprovalProcessesListElement.AttrVersion = (int?) 0;
tmpoutParamApprovalProcessesListElement.AttrDescription = outParamApprovalProcessesList.CurrentRec.ssDescription;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsActive
tmpoutParamApprovalProcessesListElement.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsSpecial
tmpoutParamApprovalProcessesListElement.AttrIsSpecial = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsDonation
tmpoutParamApprovalProcessesListElement.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsCxPCorporativo_DEPREC
tmpoutParamApprovalProcessesListElement.AttrIsCxPCorporativo_DEPREC = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrCreatedBy
tmpoutParamApprovalProcessesListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamApprovalProcessesListElement.AttrCreatedOn
tmpoutParamApprovalProcessesListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessesListElement.AttrUpdatedBy
tmpoutParamApprovalProcessesListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamApprovalProcessesListElement.AttrUpdatedOn
tmpoutParamApprovalProcessesListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsSelectFirstApprover
tmpoutParamApprovalProcessesListElement.AttrIsSelectFirstApprover = (bool?) false;
result.outParamApprovalProcessesList = new RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord[] {}, tmpoutParamApprovalProcessesListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>
 tmpoutParamApprovalProcessesList1List = new List<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>
();
try {outParamApprovalProcessesList.StartIteration();
while (!(outParamApprovalProcessesList.Eof)) {
// Write the needed fields of the record outParamApprovalProcessesList.CurrentRec to the tmpoutParamApprovalProcessesListElement
tmpoutParamApprovalProcessesListElement = new ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord();
tmpoutParamApprovalProcessesListElement.AttrId = (long?) outParamApprovalProcessesList.CurrentRec.ssId;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrProcessTypeId
tmpoutParamApprovalProcessesListElement.AttrProcessTypeId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrSpecialWorkflowId
tmpoutParamApprovalProcessesListElement.AttrSpecialWorkflowId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrApprovalProcessTypeId
tmpoutParamApprovalProcessesListElement.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrRegionId
tmpoutParamApprovalProcessesListElement.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrAccountingRegionId
tmpoutParamApprovalProcessesListElement.AttrAccountingRegionId = (long?) 0L;
tmpoutParamApprovalProcessesListElement.AttrGroup = outParamApprovalProcessesList.CurrentRec.ssGroup;
tmpoutParamApprovalProcessesListElement.AttrCode = outParamApprovalProcessesList.CurrentRec.ssCode;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrVersion
tmpoutParamApprovalProcessesListElement.AttrVersion = (int?) 0;
tmpoutParamApprovalProcessesListElement.AttrDescription = outParamApprovalProcessesList.CurrentRec.ssDescription;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsActive
tmpoutParamApprovalProcessesListElement.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsSpecial
tmpoutParamApprovalProcessesListElement.AttrIsSpecial = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsDonation
tmpoutParamApprovalProcessesListElement.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsCxPCorporativo_DEPREC
tmpoutParamApprovalProcessesListElement.AttrIsCxPCorporativo_DEPREC = (bool?) false;
// Write optimized tmpoutParamApprovalProcessesListElement.AttrCreatedBy
tmpoutParamApprovalProcessesListElement.AttrCreatedBy = "";
// Write optimized tmpoutParamApprovalProcessesListElement.AttrCreatedOn
tmpoutParamApprovalProcessesListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessesListElement.AttrUpdatedBy
tmpoutParamApprovalProcessesListElement.AttrUpdatedBy = "";
// Write optimized tmpoutParamApprovalProcessesListElement.AttrUpdatedOn
tmpoutParamApprovalProcessesListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamApprovalProcessesListElement.AttrIsSelectFirstApprover
tmpoutParamApprovalProcessesListElement.AttrIsSelectFirstApprover = (bool?) false;
tmpoutParamApprovalProcessesList1List.Add(tmpoutParamApprovalProcessesListElement);
outParamApprovalProcessesList.Advance();
}

} finally {
outParamApprovalProcessesList.EndIteration();
}

result.outParamApprovalProcessesList = new RestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(tmpoutParamApprovalProcessesList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model ToModel(RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs variables) {ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model result = new ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model();
result.outParamApprovalProcessesList = variables == null ? new RL_ce09c545b541edeabab89435c34c64f0() : RL_ce09c545b541edeabab89435c34c64f0.FromRestList(variables.outParamApprovalProcessesList, ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs result = new RESTConectaProveedores_j_FoliosSAE_Wb_FlowOptions_DataActionGetApprovalProcesses_Outputs();
result.outParamApprovalProcessesList = screenModel.outParamApprovalProcessesList.ToRestList<ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord>(ssConectaProveedores.RestRecords.RESTEN_b31af3b0976e3bd2f173f02f852fc788EntityRecord.FromStructureDelegate(conf));
return result;
}

}
