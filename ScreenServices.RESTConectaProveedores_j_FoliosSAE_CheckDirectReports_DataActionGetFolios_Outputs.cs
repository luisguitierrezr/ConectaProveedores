using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("List")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d> outParamList;


    public static RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_d6c492838bba25b2d8eac44d00689146 outParamList) {RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs result = new RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs();
// Write the needed fields of the list outParamList to the result.outParamList
ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d tmpoutParamListElement;
if(outParamList.Empty) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
// Write optimized tmpoutParamListElement.AttrCurrency.AttrCode
tmpoutParamListElement.AttrCurrency.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENUser_CreatedBy to the tmpoutParamListElement.AttrUser_CreatedBy
tmpoutParamListElement.AttrUser_CreatedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrId
tmpoutParamListElement.AttrUser_CreatedBy.AttrId = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrName
tmpoutParamListElement.AttrUser_CreatedBy.AttrName = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrEmail
tmpoutParamListElement.AttrUser_CreatedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUser_CreatedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrUsername
tmpoutParamListElement.AttrUser_CreatedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENUser_UpdatedBy to the tmpoutParamListElement.AttrUser_UpdatedBy
tmpoutParamListElement.AttrUser_UpdatedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrId
tmpoutParamListElement.AttrUser_UpdatedBy.AttrId = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrName
tmpoutParamListElement.AttrUser_UpdatedBy.AttrName = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrEmail
tmpoutParamListElement.AttrUser_UpdatedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUser_UpdatedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrUsername
tmpoutParamListElement.AttrUser_UpdatedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioStatus to the tmpoutParamListElement.AttrFolioStatus
tmpoutParamListElement.AttrFolioStatus = new ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrId
tmpoutParamListElement.AttrFolioStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrFolioStatus.AttrLabel = outParamList.CurrentRec.ssENFolioStatus.ssLabel;
tmpoutParamListElement.AttrFolioStatus.AttrClass = outParamList.CurrentRec.ssENFolioStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrOrder
tmpoutParamListElement.AttrFolioStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrIs_Active
tmpoutParamListElement.AttrFolioStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrLabelES
tmpoutParamListElement.AttrFolioStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioApproval to the tmpoutParamListElement.AttrFolioApproval
tmpoutParamListElement.AttrFolioApproval = new ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrId
tmpoutParamListElement.AttrFolioApproval.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrFolioId
tmpoutParamListElement.AttrFolioApproval.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessId
tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrProcessTypeCode
tmpoutParamListElement.AttrFolioApproval.AttrProcessTypeCode = "";
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessVersion
tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessVersion = "";
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrCurrentLevel
tmpoutParamListElement.AttrFolioApproval.AttrCurrentLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrMaxLevel
tmpoutParamListElement.AttrFolioApproval.AttrMaxLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrStartedOn
tmpoutParamListElement.AttrFolioApproval.AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrFinishedOn
tmpoutParamListElement.AttrFolioApproval.AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrRegionId
tmpoutParamListElement.AttrFolioApproval.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENFolio to the tmpoutParamListElement.AttrFolio
tmpoutParamListElement.AttrFolio = new ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
tmpoutParamListElement.AttrFolio.AttrId = (long?) outParamList.CurrentRec.ssENFolio.ssId;
// Write optimized tmpoutParamListElement.AttrFolio.AttrIsDraft
tmpoutParamListElement.AttrFolio.AttrIsDraft = (bool?) false;
tmpoutParamListElement.AttrFolio.AttrFolioNumber = outParamList.CurrentRec.ssENFolio.ssFolioNumber;
// Write optimized tmpoutParamListElement.AttrFolio.AttrCanProveedorCancel
tmpoutParamListElement.AttrFolio.AttrCanProveedorCancel = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolio.AttrOrderId
tmpoutParamListElement.AttrFolio.AttrOrderId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrSupplierId
tmpoutParamListElement.AttrFolio.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrCompanyId
tmpoutParamListElement.AttrFolio.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrFolioStatusId
tmpoutParamListElement.AttrFolio.AttrFolioStatusId = (int?) 0;
tmpoutParamListElement.AttrFolio.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENFolio.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrFolio.AttrTotalIVA_Amount
tmpoutParamListElement.AttrFolio.AttrTotalIVA_Amount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrFolio.AttrPartialAmount
tmpoutParamListElement.AttrFolio.AttrPartialAmount = (decimal?) 0.0M;
tmpoutParamListElement.AttrFolio.AttrCurrencyId = outParamList.CurrentRec.ssENFolio.ssCurrencyId;
// Write optimized tmpoutParamListElement.AttrFolio.AttrFirstApproverUserId
tmpoutParamListElement.AttrFolio.AttrFirstApproverUserId = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrApprovalProcessTypeId
tmpoutParamListElement.AttrFolio.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolio.AttrSAPEntryError
tmpoutParamListElement.AttrFolio.AttrSAPEntryError = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrCreatedBy
tmpoutParamListElement.AttrFolio.AttrCreatedBy = "";
tmpoutParamListElement.AttrFolio.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENFolio.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolio.AttrUpdatedBy
tmpoutParamListElement.AttrFolio.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrUpdatedOn
tmpoutParamListElement.AttrFolio.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolio.AttrMinuteSelected
tmpoutParamListElement.AttrFolio.AttrMinuteSelected = (int?) 0;
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioApprovalLevel to the tmpoutParamListElement.AttrFolioApprovalLevel
tmpoutParamListElement.AttrFolioApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrFolioApprovalId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrFolioApprovalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrLevelNumber
tmpoutParamListElement.AttrFolioApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApplicationRoleId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraJobTitle
tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraJobTitle = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraRoleId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrDepartmentId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrAssignedTo
tmpoutParamListElement.AttrFolioApprovalLevel.AttrAssignedTo = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovalStatusId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsMandatory
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsMandatory = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsReassigned
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsSubstituteFor
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsSubstituteFor = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectReason
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectReason = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsInvoiceApproval
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsInvoiceApproval = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderMain to the tmpoutParamListElement.AttrOrderMain
tmpoutParamListElement.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrId
tmpoutParamListElement.AttrOrderMain.AttrId = (long?) 0L;
tmpoutParamListElement.AttrOrderMain.AttrOrderNumber = outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderDate
tmpoutParamListElement.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode
tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSupplierId
tmpoutParamListElement.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCompanyId
tmpoutParamListElement.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId
tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCurrencyId
tmpoutParamListElement.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup
tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCountry
tmpoutParamListElement.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsDeleted
tmpoutParamListElement.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsReleased
tmpoutParamListElement.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrExchangeRate
tmpoutParamListElement.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTotalAmount
tmpoutParamListElement.AttrOrderMain.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz
tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrRegionId
tmpoutParamListElement.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDivisionId
tmpoutParamListElement.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrApplicant
tmpoutParamListElement.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedBy
tmpoutParamListElement.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedOn
tmpoutParamListElement.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy
tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn
tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrDescription
tmpoutParamListElement.AttrCompany.AttrDescription = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSupplier to the tmpoutParamListElement.AttrSupplier
tmpoutParamListElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamListElement.AttrSupplier.AttrId
tmpoutParamListElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTratamiento
tmpoutParamListElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamListElement.AttrSupplier.AttrName = outParamList.CurrentRec.ssENSupplier.ssName;
tmpoutParamListElement.AttrSupplier.AttrNumber = outParamList.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCalle_Numero
tmpoutParamListElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrDistrito
tmpoutParamListElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPais
tmpoutParamListElement.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegion_
tmpoutParamListElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIdioma
tmpoutParamListElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTelefono
tmpoutParamListElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrExtension
tmpoutParamListElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrFax
tmpoutParamListElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCliente
tmpoutParamListElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrClavedegrupo
tmpoutParamListElement.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1
tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPersonafisica
tmpoutParamListElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRamo
tmpoutParamListElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrGrupodeporte
tmpoutParamListElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrEmail
tmpoutParamListElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIsActive
tmpoutParamListElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedOn
tmpoutParamListElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedBy
tmpoutParamListElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedOn
tmpoutParamListElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedBy
tmpoutParamListElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegionId
tmpoutParamListElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRegion.AttrCode = outParamList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamListElement.AttrRegion.AttrName
tmpoutParamListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCommissionRegion
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = "";
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
result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d>(new ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d[] {}, tmpoutParamListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d>
 tmpoutParamList1List = new List<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d>
();
try {outParamList.StartIteration();
while (!(outParamList.Eof)) {
// Write the needed fields of the record outParamList.CurrentRec to the tmpoutParamListElement
tmpoutParamListElement = new ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d();
// Write the needed fields of the record outParamList.CurrentRec.ssENCurrency to the tmpoutParamListElement.AttrCurrency
tmpoutParamListElement.AttrCurrency = new ssConectaProveedores.RestRecords.RESTEN_327b52812b8badb247bde4975c10d441EntityRecord();
// Write optimized tmpoutParamListElement.AttrCurrency.AttrCode
tmpoutParamListElement.AttrCurrency.AttrCode = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrName
tmpoutParamListElement.AttrCurrency.AttrName = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrSymbol
tmpoutParamListElement.AttrCurrency.AttrSymbol = "";
// Write optimized tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals
tmpoutParamListElement.AttrCurrency.AttrMinorUnitDecimals = (int?) 0;
// Write optimized tmpoutParamListElement.AttrCurrency.AttrIsActive
tmpoutParamListElement.AttrCurrency.AttrIsActive = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENUser_CreatedBy to the tmpoutParamListElement.AttrUser_CreatedBy
tmpoutParamListElement.AttrUser_CreatedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrId
tmpoutParamListElement.AttrUser_CreatedBy.AttrId = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrName
tmpoutParamListElement.AttrUser_CreatedBy.AttrName = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrEmail
tmpoutParamListElement.AttrUser_CreatedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUser_CreatedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUser_CreatedBy.AttrUsername
tmpoutParamListElement.AttrUser_CreatedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENUser_UpdatedBy to the tmpoutParamListElement.AttrUser_UpdatedBy
tmpoutParamListElement.AttrUser_UpdatedBy = new ssConectaProveedores.RestRecords.RESTENUserEntityRecord();
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrId
tmpoutParamListElement.AttrUser_UpdatedBy.AttrId = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrName
tmpoutParamListElement.AttrUser_UpdatedBy.AttrName = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrEmail
tmpoutParamListElement.AttrUser_UpdatedBy.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrPhotoUrl
tmpoutParamListElement.AttrUser_UpdatedBy.AttrPhotoUrl = "";
// Write optimized tmpoutParamListElement.AttrUser_UpdatedBy.AttrUsername
tmpoutParamListElement.AttrUser_UpdatedBy.AttrUsername = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioStatus to the tmpoutParamListElement.AttrFolioStatus
tmpoutParamListElement.AttrFolioStatus = new ssConectaProveedores.RestRecords.RESTEN_0166b83cc2b4e9cd5e682934c3330deaEntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrId
tmpoutParamListElement.AttrFolioStatus.AttrId = (int?) 0;
tmpoutParamListElement.AttrFolioStatus.AttrLabel = outParamList.CurrentRec.ssENFolioStatus.ssLabel;
tmpoutParamListElement.AttrFolioStatus.AttrClass = outParamList.CurrentRec.ssENFolioStatus.ssClass;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrOrder
tmpoutParamListElement.AttrFolioStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrIs_Active
tmpoutParamListElement.AttrFolioStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioStatus.AttrLabelES
tmpoutParamListElement.AttrFolioStatus.AttrLabelES = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioApproval to the tmpoutParamListElement.AttrFolioApproval
tmpoutParamListElement.AttrFolioApproval = new ssConectaProveedores.RestRecords.RESTEN_c25f8de5b0102aa0cdbbfebfa3b44478EntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrId
tmpoutParamListElement.AttrFolioApproval.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrFolioId
tmpoutParamListElement.AttrFolioApproval.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessId
tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrProcessTypeCode
tmpoutParamListElement.AttrFolioApproval.AttrProcessTypeCode = "";
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessVersion
tmpoutParamListElement.AttrFolioApproval.AttrApprovalProcessVersion = "";
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrCurrentLevel
tmpoutParamListElement.AttrFolioApproval.AttrCurrentLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrMaxLevel
tmpoutParamListElement.AttrFolioApproval.AttrMaxLevel = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrStartedOn
tmpoutParamListElement.AttrFolioApproval.AttrStartedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrFinishedOn
tmpoutParamListElement.AttrFolioApproval.AttrFinishedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApproval.AttrRegionId
tmpoutParamListElement.AttrFolioApproval.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENFolio to the tmpoutParamListElement.AttrFolio
tmpoutParamListElement.AttrFolio = new ssConectaProveedores.RestRecords.RESTEN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord();
tmpoutParamListElement.AttrFolio.AttrId = (long?) outParamList.CurrentRec.ssENFolio.ssId;
// Write optimized tmpoutParamListElement.AttrFolio.AttrIsDraft
tmpoutParamListElement.AttrFolio.AttrIsDraft = (bool?) false;
tmpoutParamListElement.AttrFolio.AttrFolioNumber = outParamList.CurrentRec.ssENFolio.ssFolioNumber;
// Write optimized tmpoutParamListElement.AttrFolio.AttrCanProveedorCancel
tmpoutParamListElement.AttrFolio.AttrCanProveedorCancel = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolio.AttrOrderId
tmpoutParamListElement.AttrFolio.AttrOrderId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrSupplierId
tmpoutParamListElement.AttrFolio.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrCompanyId
tmpoutParamListElement.AttrFolio.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolio.AttrFolioStatusId
tmpoutParamListElement.AttrFolio.AttrFolioStatusId = (int?) 0;
tmpoutParamListElement.AttrFolio.AttrTotalAmount = (decimal?) outParamList.CurrentRec.ssENFolio.ssTotalAmount;
// Write optimized tmpoutParamListElement.AttrFolio.AttrTotalIVA_Amount
tmpoutParamListElement.AttrFolio.AttrTotalIVA_Amount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrFolio.AttrPartialAmount
tmpoutParamListElement.AttrFolio.AttrPartialAmount = (decimal?) 0.0M;
tmpoutParamListElement.AttrFolio.AttrCurrencyId = outParamList.CurrentRec.ssENFolio.ssCurrencyId;
// Write optimized tmpoutParamListElement.AttrFolio.AttrFirstApproverUserId
tmpoutParamListElement.AttrFolio.AttrFirstApproverUserId = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrApprovalProcessTypeId
tmpoutParamListElement.AttrFolio.AttrApprovalProcessTypeId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolio.AttrSAPEntryError
tmpoutParamListElement.AttrFolio.AttrSAPEntryError = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrCreatedBy
tmpoutParamListElement.AttrFolio.AttrCreatedBy = "";
tmpoutParamListElement.AttrFolio.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamList.CurrentRec.ssENFolio.ssCreatedOn, conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolio.AttrUpdatedBy
tmpoutParamListElement.AttrFolio.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrFolio.AttrUpdatedOn
tmpoutParamListElement.AttrFolio.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolio.AttrMinuteSelected
tmpoutParamListElement.AttrFolio.AttrMinuteSelected = (int?) 0;
// Write the needed fields of the record outParamList.CurrentRec.ssENFolioApprovalLevel to the tmpoutParamListElement.AttrFolioApprovalLevel
tmpoutParamListElement.AttrFolioApprovalLevel = new ssConectaProveedores.RestRecords.RESTEN_56525280d5afaeb9a135e3fb7b34064bEntityRecord();
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrFolioApprovalId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrFolioApprovalId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrLevelNumber
tmpoutParamListElement.AttrFolioApprovalLevel.AttrLevelNumber = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApplicationRoleId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApplicationRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraJobTitle
tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraJobTitle = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraRoleId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrEntraRoleId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrDepartmentId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrDepartmentId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrAssignedTo
tmpoutParamListElement.AttrFolioApprovalLevel.AttrAssignedTo = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovalStatusId
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovalStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsMandatory
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsMandatory = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsReassigned
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsReassigned = (bool?) false;
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrApprovedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrCanceledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedBy
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedBy = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedOn
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsSubstituteFor
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsSubstituteFor = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectReason
tmpoutParamListElement.AttrFolioApprovalLevel.AttrRejectReason = "";
// Write optimized tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsInvoiceApproval
tmpoutParamListElement.AttrFolioApprovalLevel.AttrIsInvoiceApproval = (bool?) false;
// Write the needed fields of the record outParamList.CurrentRec.ssENOrderMain to the tmpoutParamListElement.AttrOrderMain
tmpoutParamListElement.AttrOrderMain = new ssConectaProveedores.RestRecords.RESTEN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord();
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrId
tmpoutParamListElement.AttrOrderMain.AttrId = (long?) 0L;
tmpoutParamListElement.AttrOrderMain.AttrOrderNumber = outParamList.CurrentRec.ssENOrderMain.ssOrderNumber;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderDate
tmpoutParamListElement.AttrOrderMain.AttrOrderDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId
tmpoutParamListElement.AttrOrderMain.AttrPreviousOrderStatusId = (int?) 0;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode
tmpoutParamListElement.AttrOrderMain.AttrAssignmentCode = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSupplierId
tmpoutParamListElement.AttrOrderMain.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCompanyId
tmpoutParamListElement.AttrOrderMain.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId
tmpoutParamListElement.AttrOrderMain.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCurrencyId
tmpoutParamListElement.AttrOrderMain.AttrCurrencyId = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId
tmpoutParamListElement.AttrOrderMain.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup
tmpoutParamListElement.AttrOrderMain.AttrProcurementGroup = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPNumber = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName
tmpoutParamListElement.AttrOrderMain.AttrCreatorSAPName = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCountry
tmpoutParamListElement.AttrOrderMain.AttrCountry = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsDeleted
tmpoutParamListElement.AttrOrderMain.AttrIsDeleted = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrIsReleased
tmpoutParamListElement.AttrOrderMain.AttrIsReleased = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrExchangeRate
tmpoutParamListElement.AttrOrderMain.AttrExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilityCategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory
tmpoutParamListElement.AttrOrderMain.AttrSustainabilitySubcategory = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrTotalAmount
tmpoutParamListElement.AttrOrderMain.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz
tmpoutParamListElement.AttrOrderMain.AttrFromCosmoz = (bool?) false;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrRegionId
tmpoutParamListElement.AttrOrderMain.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrDivisionId
tmpoutParamListElement.AttrOrderMain.AttrDivisionId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrApplicant
tmpoutParamListElement.AttrOrderMain.AttrApplicant = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedBy
tmpoutParamListElement.AttrOrderMain.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrCreatedOn
tmpoutParamListElement.AttrOrderMain.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy
tmpoutParamListElement.AttrOrderMain.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn
tmpoutParamListElement.AttrOrderMain.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write the needed fields of the record outParamList.CurrentRec.ssENCompany to the tmpoutParamListElement.AttrCompany
tmpoutParamListElement.AttrCompany = new ssConectaProveedores.RestRecords.RESTEN_872b903971b8f9f3fa6f6f2160ac37b6EntityRecord();
// Write optimized tmpoutParamListElement.AttrCompany.AttrId
tmpoutParamListElement.AttrCompany.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrCompany.AttrExternalId
tmpoutParamListElement.AttrCompany.AttrExternalId = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrDescription
tmpoutParamListElement.AttrCompany.AttrDescription = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrRFC
tmpoutParamListElement.AttrCompany.AttrRFC = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrPostalCode
tmpoutParamListElement.AttrCompany.AttrPostalCode = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrCyAImport
tmpoutParamListElement.AttrCompany.AttrCyAImport = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrFsPUse
tmpoutParamListElement.AttrCompany.AttrFsPUse = (bool?) false;
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedOn
tmpoutParamListElement.AttrCompany.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrCreatedBy
tmpoutParamListElement.AttrCompany.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedOn
tmpoutParamListElement.AttrCompany.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrCompany.AttrUpdatedBy
tmpoutParamListElement.AttrCompany.AttrUpdatedBy = "";
// Write the needed fields of the record outParamList.CurrentRec.ssENSupplier to the tmpoutParamListElement.AttrSupplier
tmpoutParamListElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamListElement.AttrSupplier.AttrId
tmpoutParamListElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTratamiento
tmpoutParamListElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamListElement.AttrSupplier.AttrName = outParamList.CurrentRec.ssENSupplier.ssName;
tmpoutParamListElement.AttrSupplier.AttrNumber = outParamList.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamListElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCalle_Numero
tmpoutParamListElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrDistrito
tmpoutParamListElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamListElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPais
tmpoutParamListElement.AttrSupplier.AttrPais = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegion_
tmpoutParamListElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIdioma
tmpoutParamListElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrTelefono
tmpoutParamListElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrExtension
tmpoutParamListElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrFax
tmpoutParamListElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCliente
tmpoutParamListElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamListElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrClavedegrupo
tmpoutParamListElement.AttrSupplier.AttrClavedegrupo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1
tmpoutParamListElement.AttrSupplier.AttrN_ident_fis_1 = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrPersonafisica
tmpoutParamListElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRamo
tmpoutParamListElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrGrupodeporte
tmpoutParamListElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrEmail
tmpoutParamListElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrIsActive
tmpoutParamListElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedOn
tmpoutParamListElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrCreatedBy
tmpoutParamListElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedOn
tmpoutParamListElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamListElement.AttrSupplier.AttrUpdatedBy
tmpoutParamListElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamListElement.AttrSupplier.AttrRegionId
tmpoutParamListElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamList.CurrentRec.ssENRegion to the tmpoutParamListElement.AttrRegion
tmpoutParamListElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamListElement.AttrRegion.AttrId
tmpoutParamListElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamListElement.AttrRegion.AttrCode = outParamList.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamListElement.AttrRegion.AttrName
tmpoutParamListElement.AttrRegion.AttrName = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrDivisionFI
tmpoutParamListElement.AttrRegion.AttrDivisionFI = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCentroRTP
tmpoutParamListElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamListElement.AttrRegion.AttrCommissionRegion
tmpoutParamListElement.AttrRegion.AttrCommissionRegion = "";
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

result.outParamList = new RestList<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d>(tmpoutParamList1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d));
}

return result;
}


    public static ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model ToModel(RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs variables) {ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model result = new ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model();
result.outParamList = variables == null ? new RL_d6c492838bba25b2d8eac44d00689146() : RL_d6c492838bba25b2d8eac44d00689146.FromRestList(variables.outParamList, ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d.ToStructure);
return result;
}


    public static RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs result = new RESTConectaProveedores_j_FoliosSAE_CheckDirectReports_DataActionGetFolios_Outputs();
result.outParamList = screenModel.outParamList.ToRestList<ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d>(ssConectaProveedores.RestRecords.RESTRC_9387247c408750aafc8750d323f6a93d.FromStructureDelegate(conf));
return result;
}

}
