using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure> outParamList;
[JsonProperty("TotalCount")]
public int? outParamTotalCount;
[JsonProperty("SortClause")]
public string outParamSortClause;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_00620735fb8e7105f7e39e5561e40930 outParamList, int outParamTotalCount, string outParamSortClause) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure();
tmpoutParamListElement.AttrRequisitionId = (long?) outParamList.CurrentRec.ssRequisitionId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevelId
tmpoutParamListElement.AttrRequisitionApprovalLevelId = (long?) 0L;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrRequisitionStatusId = (int?) outParamList.CurrentRec.ssRequisitionStatusId;
tmpoutParamListElement.AttrRequisitionStatus = outParamList.CurrentRec.ssRequisitionStatus;
tmpoutParamListElement.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssApprovalStatusId;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
tmpoutParamListElement.AttrApprovalStatusClass = outParamList.CurrentRec.ssApprovalStatusClass;
tmpoutParamListElement.AttrApplicantId = outParamList.CurrentRec.ssApplicantId;
tmpoutParamListElement.AttrApplicantName = outParamList.CurrentRec.ssApplicantName;
tmpoutParamListElement.AttrProjectDescription = outParamList.CurrentRec.ssProjectDescription;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
tmpoutParamListElement.AttrRegionId = (long?) outParamList.CurrentRec.ssRegionId;
tmpoutParamListElement.AttrRegionCode = outParamList.CurrentRec.ssRegionCode;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrencyCode = outParamList.CurrentRec.ssCurrencyCode;
tmpoutParamListElement.AttrCostCenterSAPDenominacion = outParamList.CurrentRec.ssCostCenterSAPDenominacion;
tmpoutParamListElement.AttrCompanyDescription = outParamList.CurrentRec.ssCompanyDescription;
tmpoutParamListElement.AttrAdvWithoutInvoice = (bool?) outParamList.CurrentRec.ssAdvWithoutInvoice;
tmpoutParamListElement.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssIsAccounting;
tmpoutParamListElement.AttrAccountingRegionId = (long?) outParamList.CurrentRec.ssAccountingRegionId;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
tmpoutParamListElement.AttrIsContractPending = (bool?) outParamList.CurrentRec.ssIsContractPending;
tmpoutParamListElement.AttrHasContractFileUploaded = (bool?) outParamList.CurrentRec.ssHasContractFileUploaded;
tmpoutParamListElement.AttrApproveAsAreaUsuaria = (bool?) outParamList.CurrentRec.ssApproveAsAreaUsuaria;
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrUpdatedBy = outParamList.CurrentRec.ssUpdatedBy;
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssUpdatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrDontShowAction = (bool?) outParamList.CurrentRec.ssDontShowAction;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure>(new ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure();
tmpoutParamListElement.AttrRequisitionId = (long?) outParamList.CurrentRec.ssRequisitionId;
// Write optimized tmpoutParamListElement.AttrRequisitionApprovalLevelId
tmpoutParamListElement.AttrRequisitionApprovalLevelId = (long?) 0L;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrRequisitionStatusId = (int?) outParamList.CurrentRec.ssRequisitionStatusId;
tmpoutParamListElement.AttrRequisitionStatus = outParamList.CurrentRec.ssRequisitionStatus;
tmpoutParamListElement.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssApprovalStatusId;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
tmpoutParamListElement.AttrApprovalStatusClass = outParamList.CurrentRec.ssApprovalStatusClass;
tmpoutParamListElement.AttrApplicantId = outParamList.CurrentRec.ssApplicantId;
tmpoutParamListElement.AttrApplicantName = outParamList.CurrentRec.ssApplicantName;
tmpoutParamListElement.AttrProjectDescription = outParamList.CurrentRec.ssProjectDescription;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
tmpoutParamListElement.AttrRegionId = (long?) outParamList.CurrentRec.ssRegionId;
tmpoutParamListElement.AttrRegionCode = outParamList.CurrentRec.ssRegionCode;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrencyCode = outParamList.CurrentRec.ssCurrencyCode;
tmpoutParamListElement.AttrCostCenterSAPDenominacion = outParamList.CurrentRec.ssCostCenterSAPDenominacion;
tmpoutParamListElement.AttrCompanyDescription = outParamList.CurrentRec.ssCompanyDescription;
tmpoutParamListElement.AttrAdvWithoutInvoice = (bool?) outParamList.CurrentRec.ssAdvWithoutInvoice;
tmpoutParamListElement.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssIsAccounting;
tmpoutParamListElement.AttrAccountingRegionId = (long?) outParamList.CurrentRec.ssAccountingRegionId;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
tmpoutParamListElement.AttrIsContractPending = (bool?) outParamList.CurrentRec.ssIsContractPending;
tmpoutParamListElement.AttrHasContractFileUploaded = (bool?) outParamList.CurrentRec.ssHasContractFileUploaded;
tmpoutParamListElement.AttrApproveAsAreaUsuaria = (bool?) outParamList.CurrentRec.ssApproveAsAreaUsuaria;
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrUpdatedBy = outParamList.CurrentRec.ssUpdatedBy;
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssUpdatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrDontShowAction = (bool?) outParamList.CurrentRec.ssDontShowAction;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure));
}

result.outParamTotalCount = (int?) outParamTotalCount;
// Write optimized result.outParamSortClause
result.outParamSortClause = "";
return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model();
result.outParamList = variables == null ? new RL_00620735fb8e7105f7e39e5561e40930() : RL_00620735fb8e7105f7e39e5561e40930.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure.ToStructure);
result.outParamTotalCount = variables == null || variables.outParamTotalCount == null ? 0 : variables.outParamTotalCount.Value;
result.outParamSortClause = variables == null || variables.outParamSortClause == null ? "" : variables.outParamSortClause;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitions_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure>(ssConectaProveedores.RestRecords.RESTST_23b064f7387b135df7725dcd963884ceStructure.FromStructureDelegate(conf));
result.outParamTotalCount = (int?) screenModel.outParamTotalCount;
result.outParamSortClause = screenModel.outParamSortClause;
return result;
}

}
