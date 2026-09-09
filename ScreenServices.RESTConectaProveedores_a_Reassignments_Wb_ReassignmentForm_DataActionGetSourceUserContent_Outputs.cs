using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("ReqList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643> outParamReqList;
[JsonProperty("InvList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580> outParamInvList;


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_6f013a7f2ef00b964b6e71f1ec07b189 outParamReqList, RL_8c69b09c6d811e27e13cdf810a622fb2 outParamInvList) {RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs result = new RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs();
// Write the needed fields of the list outParamReqList to the result.outParamReqList
ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643 tmpoutParamReqListElement;
if(outParamReqList.Empty) {
// Write the needed fields of the record outParamReqList.CurrentRec to the tmpoutParamReqListElement
tmpoutParamReqListElement = new ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643();
tmpoutParamReqListElement.AttrRequisitionApprovalLevelId = (long?) outParamReqList.CurrentRec.ssRequisitionApprovalLevelId;
tmpoutParamReqListElement.AttrRequisitionId = (long?) outParamReqList.CurrentRec.ssRequisitionId;
tmpoutParamReqListElement.AttrRequisitionName = outParamReqList.CurrentRec.ssRequisitionName;
tmpoutParamReqListElement.AttrIsAccounting = (bool?) outParamReqList.CurrentRec.ssIsAccounting;
tmpoutParamReqListElement.AttrIsSelected = (bool?) outParamReqList.CurrentRec.ssIsSelected;
result.outParamReqList = new RestList<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643>(new ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643[] {}, tmpoutParamReqListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643>
 tmpoutParamReqList1List = new List<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643>
();
try {outParamReqList.StartIteration();
while (!(outParamReqList.Eof)) {
// Write the needed fields of the record outParamReqList.CurrentRec to the tmpoutParamReqListElement
tmpoutParamReqListElement = new ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643();
tmpoutParamReqListElement.AttrRequisitionApprovalLevelId = (long?) outParamReqList.CurrentRec.ssRequisitionApprovalLevelId;
tmpoutParamReqListElement.AttrRequisitionId = (long?) outParamReqList.CurrentRec.ssRequisitionId;
tmpoutParamReqListElement.AttrRequisitionName = outParamReqList.CurrentRec.ssRequisitionName;
tmpoutParamReqListElement.AttrIsAccounting = (bool?) outParamReqList.CurrentRec.ssIsAccounting;
tmpoutParamReqListElement.AttrIsSelected = (bool?) outParamReqList.CurrentRec.ssIsSelected;
tmpoutParamReqList1List.Add(tmpoutParamReqListElement);
outParamReqList.Advance();
}

} finally {
outParamReqList.EndIteration();
}

result.outParamReqList = new RestList<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643>(tmpoutParamReqList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643));
}

// Write the needed fields of the list outParamInvList to the result.outParamInvList
ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580 tmpoutParamInvListElement;
if(outParamInvList.Empty) {
// Write the needed fields of the record outParamInvList.CurrentRec to the tmpoutParamInvListElement
tmpoutParamInvListElement = new ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580();
tmpoutParamInvListElement.AttrInvoiceApprovalLevelId = (long?) outParamInvList.CurrentRec.ssInvoiceApprovalLevelId;
tmpoutParamInvListElement.AttrInvoiceId = (long?) outParamInvList.CurrentRec.ssInvoiceId;
tmpoutParamInvListElement.AttrInvoiceName = outParamInvList.CurrentRec.ssInvoiceName;
tmpoutParamInvListElement.AttrIsAccounting = (bool?) outParamInvList.CurrentRec.ssIsAccounting;
tmpoutParamInvListElement.AttrIsSelected = (bool?) outParamInvList.CurrentRec.ssIsSelected;
result.outParamInvList = new RestList<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580>(new ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580[] {}, tmpoutParamInvListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580>
 tmpoutParamInvList1List = new List<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580>
();
try {outParamInvList.StartIteration();
while (!(outParamInvList.Eof)) {
// Write the needed fields of the record outParamInvList.CurrentRec to the tmpoutParamInvListElement
tmpoutParamInvListElement = new ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580();
tmpoutParamInvListElement.AttrInvoiceApprovalLevelId = (long?) outParamInvList.CurrentRec.ssInvoiceApprovalLevelId;
tmpoutParamInvListElement.AttrInvoiceId = (long?) outParamInvList.CurrentRec.ssInvoiceId;
tmpoutParamInvListElement.AttrInvoiceName = outParamInvList.CurrentRec.ssInvoiceName;
tmpoutParamInvListElement.AttrIsAccounting = (bool?) outParamInvList.CurrentRec.ssIsAccounting;
tmpoutParamInvListElement.AttrIsSelected = (bool?) outParamInvList.CurrentRec.ssIsSelected;
tmpoutParamInvList1List.Add(tmpoutParamInvListElement);
outParamInvList.Advance();
}

} finally {
outParamInvList.EndIteration();
}

result.outParamInvList = new RestList<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580>(tmpoutParamInvList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580));
}

return result;
}


    public static ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model ToModel(RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs variables) {ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model result = new ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model();
result.outParamReqList = variables == null ? new RL_6f013a7f2ef00b964b6e71f1ec07b189() : RL_6f013a7f2ef00b964b6e71f1ec07b189.FromRestList(variables.outParamReqList, ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643.ToStructure);
result.outParamInvList = variables == null ? new RL_8c69b09c6d811e27e13cdf810a622fb2() : RL_8c69b09c6d811e27e13cdf810a622fb2.FromRestList(variables.outParamInvList, ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580.ToStructure);
return result;
}


    public static RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs result = new RESTConectaProveedores_a_Reassignments_Wb_ReassignmentForm_DataActionGetSourceUserContent_Outputs();
result.outParamReqList = screenModel.outParamReqList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643>(ssConectaProveedores.RestRecords.RESTRC_da31ba4ed131103eb5a5b5464cca7643.FromStructureDelegate(conf));
result.outParamInvList = screenModel.outParamInvList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580>(ssConectaProveedores.RestRecords.RESTRC_9f414d82ade67cb4131fecd8fda64580.FromStructureDelegate(conf));
return result;
}

}
