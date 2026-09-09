using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067> outParamList;
[JsonProperty("Count")]
public int? outParamCount;
[JsonProperty("Sum")]
public decimal? outParamSum;


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_6fbd57060cf755f3c77e73cfe2e2b04c outParamList, int outParamCount, decimal outParamSum) {RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067 tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENBank to the tmpoutParamListElement.AttrBank
tmpoutParamListElement.AttrBank = new ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
// Write optimized tmpoutParamListElement.AttrBank.AttrId
tmpoutParamListElement.AttrBank.AttrId = (long?) 0L;
tmpoutParamListElement.AttrBank.AttrName = outParamList.CurrentRec.ssENBank.ssName;
// Write optimized tmpoutParamListElement.AttrBank.AttrShortName
tmpoutParamListElement.AttrBank.AttrShortName = "";
// Write optimized tmpoutParamListElement.AttrBank.AttrCode
tmpoutParamListElement.AttrBank.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrBank.AttrIsActive
tmpoutParamListElement.AttrBank.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrBank.AttrOrder
tmpoutParamListElement.AttrBank.AttrOrder = (int?) 0;
// Write the needed fields of the record outParamList.CurrentRec.ssENUploadedBy to the tmpoutParamListElement.AttrUploadedBy
tmpoutParamListElement.AttrUploadedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrId
tmpoutParamListElement.AttrUploadedBy.AttrId = "";
tmpoutParamListElement.AttrUploadedBy.AttrName = outParamList.CurrentRec.ssENUploadedBy.ssName;
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrEmail
tmpoutParamListElement.AttrUploadedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUploadedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrUsername
tmpoutParamListElement.AttrUploadedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposal to the tmpoutParamListElement.AttrProposal
tmpoutParamListElement.AttrProposal = new ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
tmpoutParamListElement.AttrProposal.AttrId = (long?) outParamList.CurrentRec.ssENProposal.ssId;
tmpoutParamListElement.AttrProposal.AttrName = outParamList.CurrentRec.ssENProposal.ssName;
tmpoutParamListElement.AttrProposal.AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENProposal.ssPaymentDate);
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
tmpoutParamListElement.AttrProposal.AttrTotalValueML = (decimal?) outParamList.CurrentRec.ssENProposal.ssTotalValueML;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueMD
tmpoutParamListElement.AttrProposal.AttrTotalValueMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCurrencyId
tmpoutParamListElement.AttrProposal.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrRegionId
tmpoutParamListElement.AttrProposal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedBy
tmpoutParamListElement.AttrProposal.AttrCreatedBy = "";
tmpoutParamListElement.AttrProposal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENProposal.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn
tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges
tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrAssignedToId
tmpoutParamListElement.AttrProposal.AttrAssignedToId = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFileExtended to the tmpoutParamListElement.AttrFileExtended
tmpoutParamListElement.AttrFileExtended = new ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrId
tmpoutParamListElement.AttrFileExtended.AttrId = (long?) 0L;
tmpoutParamListElement.AttrFileExtended.AttrFilename = outParamList.CurrentRec.ssENFileExtended.ssFilename;
tmpoutParamListElement.AttrFileExtended.AttrIsProcessed = (bool?) outParamList.CurrentRec.ssENFileExtended.ssIsProcessed;
tmpoutParamListElement.AttrFileExtended.AttrHasError = (bool?) outParamList.CurrentRec.ssENFileExtended.ssHasError;
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrErrorMessage
tmpoutParamListElement.AttrFileExtended.AttrErrorMessage = "";
tmpoutParamListElement.AttrFileExtended.AttrUploadedBy = outParamList.CurrentRec.ssENFileExtended.ssUploadedBy;
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrUploadedOn
tmpoutParamListElement.AttrFileExtended.AttrUploadedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalType to the tmpoutParamListElement.AttrProposalType
tmpoutParamListElement.AttrProposalType = new ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalType.AttrId
tmpoutParamListElement.AttrProposalType.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalType.AttrLabel = outParamList.CurrentRec.ssENProposalType.ssLabel;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrOrder
tmpoutParamListElement.AttrProposalType.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrIs_Active
tmpoutParamListElement.AttrProposalType.AttrIs_Active = (bool?) false;
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
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCode
tmpoutParamListElement.AttrRegion.AttrCode = "";
tmpoutParamListElement.AttrRegion.AttrName = outParamList.CurrentRec.ssENRegion.ssName;
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = outParamList.CurrentRec.ssENRegion.ssCommissionRegion;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsActive
tmpoutParamListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedOn
tmpoutParamListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedBy
tmpoutParamListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedOn
tmpoutParamListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedBy
tmpoutParamListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFsP
tmpoutParamListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFcP
tmpoutParamListElement.AttrRegion.AttrIsFcP = (bool?) false;
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067>(new ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
tmpoutParamListElement.AttrCurrency.AttrCode = outParamList.CurrentRec.ssENCurrency.ssCode;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENBank to the tmpoutParamListElement.AttrBank
tmpoutParamListElement.AttrBank = new ssConectaProveedores.RestRecords.RESTEN_5044fe38c06ec03c59e11b8f67cd6134EntityRecord();
// Write optimized tmpoutParamListElement.AttrBank.AttrId
tmpoutParamListElement.AttrBank.AttrId = (long?) 0L;
tmpoutParamListElement.AttrBank.AttrName = outParamList.CurrentRec.ssENBank.ssName;
// Write optimized tmpoutParamListElement.AttrBank.AttrShortName
tmpoutParamListElement.AttrBank.AttrShortName = "";
// Write optimized tmpoutParamListElement.AttrBank.AttrCode
tmpoutParamListElement.AttrBank.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrBank.AttrIsActive
tmpoutParamListElement.AttrBank.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrBank.AttrOrder
tmpoutParamListElement.AttrBank.AttrOrder = (int?) 0;
// Write the needed fields of the record outParamList.CurrentRec.ssENUploadedBy to the tmpoutParamListElement.AttrUploadedBy
tmpoutParamListElement.AttrUploadedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrId
tmpoutParamListElement.AttrUploadedBy.AttrId = "";
tmpoutParamListElement.AttrUploadedBy.AttrName = outParamList.CurrentRec.ssENUploadedBy.ssName;
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrEmail
tmpoutParamListElement.AttrUploadedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUploadedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUploadedBy.AttrUsername
tmpoutParamListElement.AttrUploadedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENProposal to the tmpoutParamListElement.AttrProposal
tmpoutParamListElement.AttrProposal = new ssConectaProveedores.RestRecords.RESTEN_6685f94d2d1a5765c3a7324a32847b2cEntityRecord();
tmpoutParamListElement.AttrProposal.AttrId = (long?) outParamList.CurrentRec.ssENProposal.ssId;
tmpoutParamListElement.AttrProposal.AttrName = outParamList.CurrentRec.ssENProposal.ssName;
tmpoutParamListElement.AttrProposal.AttrPaymentDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(outParamList.CurrentRec.ssENProposal.ssPaymentDate);
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
tmpoutParamListElement.AttrProposal.AttrTotalValueML = (decimal?) outParamList.CurrentRec.ssENProposal.ssTotalValueML;
// Write optimized tmpoutParamListElement.AttrProposal.AttrTotalValueMD
tmpoutParamListElement.AttrProposal.AttrTotalValueMD = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCurrencyId
tmpoutParamListElement.AttrProposal.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrProposal.AttrRegionId
tmpoutParamListElement.AttrProposal.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrProposal.AttrCreatedBy
tmpoutParamListElement.AttrProposal.AttrCreatedBy = "";
tmpoutParamListElement.AttrProposal.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENProposal.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn
tmpoutParamListElement.AttrProposal.AttrLastUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges
tmpoutParamListElement.AttrProposal.AttrMaxDatePaymentChanges = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrProposal.AttrAssignedToId
tmpoutParamListElement.AttrProposal.AttrAssignedToId = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFileExtended to the tmpoutParamListElement.AttrFileExtended
tmpoutParamListElement.AttrFileExtended = new ssConectaProveedores.RestRecords.RESTEN_dcebdd8ba305133f41b1e1804925997fEntityRecord();
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrId
tmpoutParamListElement.AttrFileExtended.AttrId = (long?) 0L;
tmpoutParamListElement.AttrFileExtended.AttrFilename = outParamList.CurrentRec.ssENFileExtended.ssFilename;
tmpoutParamListElement.AttrFileExtended.AttrIsProcessed = (bool?) outParamList.CurrentRec.ssENFileExtended.ssIsProcessed;
tmpoutParamListElement.AttrFileExtended.AttrHasError = (bool?) outParamList.CurrentRec.ssENFileExtended.ssHasError;
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrErrorMessage
tmpoutParamListElement.AttrFileExtended.AttrErrorMessage = "";
tmpoutParamListElement.AttrFileExtended.AttrUploadedBy = outParamList.CurrentRec.ssENFileExtended.ssUploadedBy;
// Write optimized tmpoutParamListElement.AttrFileExtended.AttrUploadedOn
tmpoutParamListElement.AttrFileExtended.AttrUploadedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssENProposalType to the tmpoutParamListElement.AttrProposalType
tmpoutParamListElement.AttrProposalType = new ssConectaProveedores.RestRecords.RESTEN_7de728375ec552c47f71bca85f9991d9EntityRecord();
// Write optimized tmpoutParamListElement.AttrProposalType.AttrId
tmpoutParamListElement.AttrProposalType.AttrId = (int?) 0;
tmpoutParamListElement.AttrProposalType.AttrLabel = outParamList.CurrentRec.ssENProposalType.ssLabel;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrOrder
tmpoutParamListElement.AttrProposalType.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrProposalType.AttrIs_Active
tmpoutParamListElement.AttrProposalType.AttrIs_Active = (bool?) false;
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
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCode
tmpoutParamListElement.AttrRegion.AttrCode = "";
tmpoutParamListElement.AttrRegion.AttrName = outParamList.CurrentRec.ssENRegion.ssName;
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = outParamList.CurrentRec.ssENRegion.ssCommissionRegion;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsActive
tmpoutParamListElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedOn
tmpoutParamListElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrCreatedBy
tmpoutParamListElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedOn
tmpoutParamListElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrRegion.AttrUpdatedBy
tmpoutParamListElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFsP
tmpoutParamListElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamListElement.AttrRegion.AttrIsFcP
tmpoutParamListElement.AttrRegion.AttrIsFcP = (bool?) false;
tmpoutParamList1List.Add(tmpoutParamListElement);
outParamList.Advance();
}

} finally {
outParamList.EndIteration();
}

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067));
}

result.outParamCount = (int?) outParamCount;
result.outParamSum = (decimal?) outParamSum;
return result;
}


    public static ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model ToModel(RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs variables) {ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model result = new ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model();
result.outParamList = variables == null ? new RL_6fbd57060cf755f3c77e73cfe2e2b04c() : RL_6fbd57060cf755f3c77e73cfe2e2b04c.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067.ToStructure);
result.outParamCount = variables == null || variables.outParamCount == null ? 0 : variables.outParamCount.Value;
result.outParamSum = variables == null || variables.outParamSum == null ? 0.0M : variables.outParamSum.Value;
return result;
}


    public static RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs result = new RESTConectaProveedores_b_CyA_AdminCommissionsLeasing_ProposalsList_DataActionGetProposal_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067>(ssConectaProveedores.RestRecords.RESTRC_8d415889034a2c958f8f82d7128f2067.FromStructureDelegate(conf));
result.outParamCount = (int?) screenModel.outParamCount;
result.outParamSum = (decimal?) screenModel.outParamSum;
return result;
}

}
