using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb> outParamList;
[JsonProperty("Count")]
public long? outParamCount;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_3d7f0e13438b1662f16b29b5c58fbf9f outParamList, long outParamCount) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb();
// Write the needed fields of the record outParamList.CurrentRec.ssENProposal to the tmpoutParamListElement.AttrProposal
tmpoutParamListElement.AttrProposal = new ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
tmpoutParamListElement.AttrProposal.AttrId = (long?) outParamList.CurrentRec.ssENProposal.ssId;
tmpoutParamListElement.AttrProposal.AttrName = outParamList.CurrentRec.ssENProposal.ssName;
// Write optimized tmpoutParamListElement.AttrProposal.AttrPaymentDate
tmpoutParamListElement.AttrProposal.AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalDate
tmpoutParamListElement.AttrProposal.AttrProposalDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalTypeId
tmpoutParamListElement.AttrProposal.AttrProposalTypeId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrBankId
tmpoutParamListElement.AttrProposal.AttrBankId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalStatusId
tmpoutParamListElement.AttrProposal.AttrProposalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrFileId
tmpoutParamListElement.AttrProposal.AttrFileId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalProposalLines
tmpoutParamListElement.AttrProposal.AttrTotalProposalLines = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueML
tmpoutParamListElement.AttrProposal.AttrTotalValueML = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueMD
tmpoutParamListElement.AttrProposal.AttrTotalValueMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCurrencyId
tmpoutParamListElement.AttrProposal.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrRegionId
tmpoutParamListElement.AttrProposal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedBy
tmpoutParamListElement.AttrProposal.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedOn
tmpoutParamListElement.AttrProposal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn
tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges
tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrAssignedToId
tmpoutParamListElement.AttrProposal.AttrAssignedToId = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalType to the tmpoutParamListElement.AttrProposalType
tmpoutParamListElement.AttrProposalType = new ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalType.AttrId
tmpoutParamListElement.AttrProposalType.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalType.AttrLabel = outParamList.CurrentRec.ssENProposalType.ssLabel;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrOrder
tmpoutParamListElement.AttrProposalType.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrIs_Active
tmpoutParamListElement.AttrProposalType.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApprovalStatus to the tmpoutParamListElement.AttrApprovalStatus
tmpoutParamListElement.AttrApprovalStatus = new ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrId
tmpoutParamListElement.AttrApprovalStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrApprovalStatus.AttrLabel = outParamList.CurrentRec.ssENApprovalStatus.ssLabel;
tmpoutParamListElement.AttrApprovalStatus.AttrClass = outParamList.CurrentRec.ssENApprovalStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrOrder
tmpoutParamListElement.AttrApprovalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active
tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsReq
tmpoutParamListElement.AttrApprovalStatus.AttrIsReq = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsInv
tmpoutParamListElement.AttrApprovalStatus.AttrIsInv = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrLabelES
tmpoutParamListElement.AttrApprovalStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalStatus to the tmpoutParamListElement.AttrProposalStatus
tmpoutParamListElement.AttrProposalStatus = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrId
tmpoutParamListElement.AttrProposalStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalStatus.AttrLabel = outParamList.CurrentRec.ssENProposalStatus.ssLabel;
tmpoutParamListElement.AttrProposalStatus.AttrClass = outParamList.CurrentRec.ssENProposalStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrOrder
tmpoutParamListElement.AttrProposalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrIs_Active
tmpoutParamListElement.AttrProposalStatus.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalLine to the tmpoutParamListElement.AttrProposalLine
tmpoutParamListElement.AttrProposalLine = new ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrId
tmpoutParamListElement.AttrProposalLine.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrProposalId
tmpoutParamListElement.AttrProposalLine.AttrProposalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrApprovalStatusId
tmpoutParamListElement.AttrProposalLine.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrCompanyId
tmpoutParamListElement.AttrProposalLine.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrSupplierId
tmpoutParamListElement.AttrProposalLine.AttrSupplierId = (long?) 0L;
tmpoutParamListElement.AttrProposalLine.AttrFe_contab_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENProposalLine.ssFe_contab_);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrEj__mes
tmpoutParamListElement.AttrProposalLine.AttrEj__mes = "";
tmpoutParamListElement.AttrProposalLine.AttrCuenta = outParamList.CurrentRec.ssENProposalLine.ssCuenta;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrReferencia
tmpoutParamListElement.AttrProposalLine.AttrReferencia = "";
tmpoutParamListElement.AttrProposalLine.AttrNombre1 = outParamList.CurrentRec.ssENProposalLine.ssNombre1;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrNombre2
tmpoutParamListElement.AttrProposalLine.AttrNombre2 = "";
tmpoutParamListElement.AttrProposalLine.AttrN_doc_ = outParamList.CurrentRec.ssENProposalLine.ssN_doc_;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrN_DocType
tmpoutParamListElement.AttrProposalLine.AttrN_DocType = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrImporteenML
tmpoutParamListElement.AttrProposalLine.AttrImporteenML = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrML
tmpoutParamListElement.AttrProposalLine.AttrML = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrImporteenMD
tmpoutParamListElement.AttrProposalLine.AttrImporteenMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrMon_
tmpoutParamListElement.AttrProposalLine.AttrMon_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrSoc_
tmpoutParamListElement.AttrProposalLine.AttrSoc_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrDiv_
tmpoutParamListElement.AttrProposalLine.AttrDiv_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrLib_mayor
tmpoutParamListElement.AttrProposalLine.AttrLib_mayor = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrTextocab_documento
tmpoutParamListElement.AttrProposalLine.AttrTextocab_documento = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrDoc_comp_
tmpoutParamListElement.AttrProposalLine.AttrDoc_comp_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrPaidBy
tmpoutParamListElement.AttrProposalLine.AttrPaidBy = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrPaidOn
tmpoutParamListElement.AttrProposalLine.AttrPaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrUnpaidBy
tmpoutParamListElement.AttrProposalLine.AttrUnpaidBy = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrUnpaidOn
tmpoutParamListElement.AttrProposalLine.AttrUnpaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrHasErrors
tmpoutParamListElement.AttrProposalLine.AttrHasErrors = (bool?) false;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrErrorMessage
tmpoutParamListElement.AttrProposalLine.AttrErrorMessage = "";
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb>(new ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb();
// Write the needed fields of the record outParamList.CurrentRec.ssENProposal to the tmpoutParamListElement.AttrProposal
tmpoutParamListElement.AttrProposal = new ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
tmpoutParamListElement.AttrProposal.AttrId = (long?) outParamList.CurrentRec.ssENProposal.ssId;
tmpoutParamListElement.AttrProposal.AttrName = outParamList.CurrentRec.ssENProposal.ssName;
// Write optimized tmpoutParamListElement.AttrProposal.AttrPaymentDate
tmpoutParamListElement.AttrProposal.AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalDate
tmpoutParamListElement.AttrProposal.AttrProposalDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalTypeId
tmpoutParamListElement.AttrProposal.AttrProposalTypeId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrBankId
tmpoutParamListElement.AttrProposal.AttrBankId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrProposalStatusId
tmpoutParamListElement.AttrProposal.AttrProposalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrFileId
tmpoutParamListElement.AttrProposal.AttrFileId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalProposalLines
tmpoutParamListElement.AttrProposal.AttrTotalProposalLines = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueML
tmpoutParamListElement.AttrProposal.AttrTotalValueML = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueMD
tmpoutParamListElement.AttrProposal.AttrTotalValueMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCurrencyId
tmpoutParamListElement.AttrProposal.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrRegionId
tmpoutParamListElement.AttrProposal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedBy
tmpoutParamListElement.AttrProposal.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedOn
tmpoutParamListElement.AttrProposal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn
tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges
tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrAssignedToId
tmpoutParamListElement.AttrProposal.AttrAssignedToId = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalType to the tmpoutParamListElement.AttrProposalType
tmpoutParamListElement.AttrProposalType = new ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalType.AttrId
tmpoutParamListElement.AttrProposalType.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalType.AttrLabel = outParamList.CurrentRec.ssENProposalType.ssLabel;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrOrder
tmpoutParamListElement.AttrProposalType.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrIs_Active
tmpoutParamListElement.AttrProposalType.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENApprovalStatus to the tmpoutParamListElement.AttrApprovalStatus
tmpoutParamListElement.AttrApprovalStatus = new ssConectaProveedores.RestRecords.RESTEN_e97ac0d21205ff90ab42100bba6097baEntityRecord();
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrId
tmpoutParamListElement.AttrApprovalStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrApprovalStatus.AttrLabel = outParamList.CurrentRec.ssENApprovalStatus.ssLabel;
tmpoutParamListElement.AttrApprovalStatus.AttrClass = outParamList.CurrentRec.ssENApprovalStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrOrder
tmpoutParamListElement.AttrApprovalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active
tmpoutParamListElement.AttrApprovalStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyA = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval
tmpoutParamListElement.AttrApprovalStatus.AttrIsCyAApproval = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsReq
tmpoutParamListElement.AttrApprovalStatus.AttrIsReq = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrIsInv
tmpoutParamListElement.AttrApprovalStatus.AttrIsInv = (bool?) false;
// Write optimized tmpoutParamListElement.AttrApprovalStatus.AttrLabelES
tmpoutParamListElement.AttrApprovalStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalStatus to the tmpoutParamListElement.AttrProposalStatus
tmpoutParamListElement.AttrProposalStatus = new ssConectaProveedores.RestRecords.RESTEN_d93750ea613ab42d0fd6fd042f9184c3EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrId
tmpoutParamListElement.AttrProposalStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalStatus.AttrLabel = outParamList.CurrentRec.ssENProposalStatus.ssLabel;
tmpoutParamListElement.AttrProposalStatus.AttrClass = outParamList.CurrentRec.ssENProposalStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrOrder
tmpoutParamListElement.AttrProposalStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalStatus.AttrIs_Active
tmpoutParamListElement.AttrProposalStatus.AttrIs_Active = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalLine to the tmpoutParamListElement.AttrProposalLine
tmpoutParamListElement.AttrProposalLine = new ssConectaProveedores.RestRecords.RESTEN_7c6b630b015613a6ab404a2bbc3cb9d6EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrId
tmpoutParamListElement.AttrProposalLine.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrProposalId
tmpoutParamListElement.AttrProposalLine.AttrProposalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrApprovalStatusId
tmpoutParamListElement.AttrProposalLine.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrCompanyId
tmpoutParamListElement.AttrProposalLine.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrSupplierId
tmpoutParamListElement.AttrProposalLine.AttrSupplierId = (long?) 0L;
tmpoutParamListElement.AttrProposalLine.AttrFe_contab_ = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENProposalLine.ssFe_contab_);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrEj__mes
tmpoutParamListElement.AttrProposalLine.AttrEj__mes = "";
tmpoutParamListElement.AttrProposalLine.AttrCuenta = outParamList.CurrentRec.ssENProposalLine.ssCuenta;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrReferencia
tmpoutParamListElement.AttrProposalLine.AttrReferencia = "";
tmpoutParamListElement.AttrProposalLine.AttrNombre1 = outParamList.CurrentRec.ssENProposalLine.ssNombre1;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrNombre2
tmpoutParamListElement.AttrProposalLine.AttrNombre2 = "";
tmpoutParamListElement.AttrProposalLine.AttrN_doc_ = outParamList.CurrentRec.ssENProposalLine.ssN_doc_;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrN_DocType
tmpoutParamListElement.AttrProposalLine.AttrN_DocType = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrImporteenML
tmpoutParamListElement.AttrProposalLine.AttrImporteenML = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrML
tmpoutParamListElement.AttrProposalLine.AttrML = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrImporteenMD
tmpoutParamListElement.AttrProposalLine.AttrImporteenMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrMon_
tmpoutParamListElement.AttrProposalLine.AttrMon_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrSoc_
tmpoutParamListElement.AttrProposalLine.AttrSoc_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrDiv_
tmpoutParamListElement.AttrProposalLine.AttrDiv_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrLib_mayor
tmpoutParamListElement.AttrProposalLine.AttrLib_mayor = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrTextocab_documento
tmpoutParamListElement.AttrProposalLine.AttrTextocab_documento = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrDoc_comp_
tmpoutParamListElement.AttrProposalLine.AttrDoc_comp_ = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrPaidBy
tmpoutParamListElement.AttrProposalLine.AttrPaidBy = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrPaidOn
tmpoutParamListElement.AttrProposalLine.AttrPaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrUnpaidBy
tmpoutParamListElement.AttrProposalLine.AttrUnpaidBy = "";
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrUnpaidOn
tmpoutParamListElement.AttrProposalLine.AttrUnpaidOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrHasErrors
tmpoutParamListElement.AttrProposalLine.AttrHasErrors = (bool?) false;
// Write optimized tmpoutParamListElement.AttrProposalLine.AttrErrorMessage
tmpoutParamListElement.AttrProposalLine.AttrErrorMessage = "";
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb));
}

result.outParamCount = (long?) outParamCount;
return result;
}


    public static ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model ToModel(RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs variables) {ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model();
result.outParamList = variables == null ? new RL_3d7f0e13438b1662f16b29b5c58fbf9f() : RL_3d7f0e13438b1662f16b29b5c58fbf9f.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0L : variables.outParamCount.Value;
return result;
}


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_DocumentList_DataActionGetProposalLines_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb>(ssConectaProveedores.RestRecords.RESTRC_ad5e17bc33d6c36e94593cff1d9300bb.FromStructureDelegate(conf));
result.outParamCount = (long?) screenModel.outParamCount;
return result;
}

}
