using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure> outParamList;
[JsonProperty("SortClause")]
public string outParamSortClause;


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_5cba7bdf2f2718a3daba441ead02b59b outParamList, string outParamSortClause) {RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure();
tmpoutParamListElement.AttrRequisitionId = (long?) outParamList.CurrentRec.ssRequisitionId;
tmpoutParamListElement.AttrRequisitionApprovalLevelId = (long?) outParamList.CurrentRec.ssRequisitionApprovalLevelId;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrRequisitionStatusId = (int?) outParamList.CurrentRec.ssRequisitionStatusId;
tmpoutParamListElement.AttrRequisitionStatus = outParamList.CurrentRec.ssRequisitionStatus;
tmpoutParamListElement.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssApprovalStatusId;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
// Write optimized tmpoutParamListElement.AttrApprovalStatusClass
tmpoutParamListElement.AttrApprovalStatusClass = "";
tmpoutParamListElement.AttrApplicantId = outParamList.CurrentRec.ssApplicantId;
tmpoutParamListElement.AttrApplicantName = outParamList.CurrentRec.ssApplicantName;
tmpoutParamListElement.AttrProjectDescription = outParamList.CurrentRec.ssProjectDescription;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
// Write optimized tmpoutParamListElement.AttrRegionId
tmpoutParamListElement.AttrRegionId = (long?) 0L;
tmpoutParamListElement.AttrRegionCode = outParamList.CurrentRec.ssRegionCode;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrencyCode = outParamList.CurrentRec.ssCurrencyCode;
tmpoutParamListElement.AttrCostCenterSAPDenominacion = outParamList.CurrentRec.ssCostCenterSAPDenominacion;
tmpoutParamListElement.AttrCompanyDescription = outParamList.CurrentRec.ssCompanyDescription;
// Write optimized tmpoutParamListElement.AttrAdvWithoutInvoice
tmpoutParamListElement.AttrAdvWithoutInvoice = (bool?) false;
tmpoutParamListElement.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssIsAccounting;
// Write optimized tmpoutParamListElement.AttrAccountingRegionId
tmpoutParamListElement.AttrAccountingRegionId = (long?) 0L;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
// Write optimized tmpoutParamListElement.AttrIsContractPending
tmpoutParamListElement.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamListElement.AttrHasContractFileUploaded
tmpoutParamListElement.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApproveAsAreaUsuaria
tmpoutParamListElement.AttrApproveAsAreaUsuaria = (bool?) false;
tmpoutParamListElement.AttrLastApproverName = outParamList.CurrentRec.ssLastApproverName;
tmpoutParamListElement.AttrLastApproverApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssLastApproverApprovedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrPolizaSAP_SentWhen = outParamList.CurrentRec.ssPolizaSAP_SentWhen;
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrUpdatedBy = outParamList.CurrentRec.ssUpdatedBy;
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssUpdatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrDontShowAction
tmpoutParamListElement.AttrDontShowAction = (bool?) false;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure>(new ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure();
tmpoutParamListElement.AttrRequisitionId = (long?) outParamList.CurrentRec.ssRequisitionId;
tmpoutParamListElement.AttrRequisitionApprovalLevelId = (long?) outParamList.CurrentRec.ssRequisitionApprovalLevelId;
tmpoutParamListElement.AttrRequisitionName = outParamList.CurrentRec.ssRequisitionName;
tmpoutParamListElement.AttrRequisitionStatusId = (int?) outParamList.CurrentRec.ssRequisitionStatusId;
tmpoutParamListElement.AttrRequisitionStatus = outParamList.CurrentRec.ssRequisitionStatus;
tmpoutParamListElement.AttrApprovalStatusId = (int?) outParamList.CurrentRec.ssApprovalStatusId;
tmpoutParamListElement.AttrApprovalStatus = outParamList.CurrentRec.ssApprovalStatus;
// Write optimized tmpoutParamListElement.AttrApprovalStatusClass
tmpoutParamListElement.AttrApprovalStatusClass = "";
tmpoutParamListElement.AttrApplicantId = outParamList.CurrentRec.ssApplicantId;
tmpoutParamListElement.AttrApplicantName = outParamList.CurrentRec.ssApplicantName;
tmpoutParamListElement.AttrProjectDescription = outParamList.CurrentRec.ssProjectDescription;
tmpoutParamListElement.AttrSupplierName = outParamList.CurrentRec.ssSupplierName;
tmpoutParamListElement.AttrSupplierNumber = outParamList.CurrentRec.ssSupplierNumber;
// Write optimized tmpoutParamListElement.AttrRegionId
tmpoutParamListElement.AttrRegionId = (long?) 0L;
tmpoutParamListElement.AttrRegionCode = outParamList.CurrentRec.ssRegionCode;
tmpoutParamListElement.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssTotalAmount;
tmpoutParamListElement.AttrCurrencyCode = outParamList.CurrentRec.ssCurrencyCode;
tmpoutParamListElement.AttrCostCenterSAPDenominacion = outParamList.CurrentRec.ssCostCenterSAPDenominacion;
tmpoutParamListElement.AttrCompanyDescription = outParamList.CurrentRec.ssCompanyDescription;
// Write optimized tmpoutParamListElement.AttrAdvWithoutInvoice
tmpoutParamListElement.AttrAdvWithoutInvoice = (bool?) false;
tmpoutParamListElement.AttrIsAccounting = (bool?) outParamList.CurrentRec.ssIsAccounting;
// Write optimized tmpoutParamListElement.AttrAccountingRegionId
tmpoutParamListElement.AttrAccountingRegionId = (long?) 0L;
tmpoutParamListElement.AttrAssignedTo = outParamList.CurrentRec.ssAssignedTo;
// Write optimized tmpoutParamListElement.AttrIsContractPending
tmpoutParamListElement.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamListElement.AttrHasContractFileUploaded
tmpoutParamListElement.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApproveAsAreaUsuaria
tmpoutParamListElement.AttrApproveAsAreaUsuaria = (bool?) false;
tmpoutParamListElement.AttrLastApproverName = outParamList.CurrentRec.ssLastApproverName;
tmpoutParamListElement.AttrLastApproverApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssLastApproverApprovedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrPolizaSAP_SentWhen = outParamList.CurrentRec.ssPolizaSAP_SentWhen;
tmpoutParamListElement.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamListElement.AttrUpdatedBy = outParamList.CurrentRec.ssUpdatedBy;
tmpoutParamListElement.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssUpdatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrDontShowAction
tmpoutParamListElement.AttrDontShowAction = (bool?) false;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure));
}

// Write optimized result.outParamSortClause
result.outParamSortClause = "";
return result;
}


    public static ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model ToModel(RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs variables) {ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model result = new ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model();
result.outParamList = variables == null ? new RL_5cba7bdf2f2718a3daba441ead02b59b() : RL_5cba7bdf2f2718a3daba441ead02b59b.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure.ToStructure);
result.outParamSortClause = variables == null || variables.outParamSortClause == null ? "" : variables.outParamSortClause;
return result;
}


    public static RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs result = new RESTConectaProveedores_c_Requisitions_Wb_RequisitionsList_Internal_DataActionGetRequisitionsFull_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure>(ssConectaProveedores.RestRecords.RESTST_4b0669d4e8a5d503dc5477cdc7b3957dStructure.FromStructureDelegate(conf));
result.outParamSortClause = screenModel.outParamSortClause;
return result;
}

}
