using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("InvoiceById")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af> outParamInvoiceById;
[JsonProperty("IsUserCxp")]
public bool? outParamIsUserCxp;
[JsonProperty("IsActiveUser")]
public bool? outParamIsActiveUser;
[JsonProperty("IsAllowed")]
public bool? outParamIsAllowed;
[JsonProperty("IsProveedor")]
public bool? outParamIsProveedor;
[JsonProperty("IsDEV")]
public bool? outParamIsDEV;
[JsonProperty("IsActiveDEV_AccountingCeBe")]
public bool? outParamIsActiveDEV_AccountingCeBe;


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_e6ad6603ac07123d4d7c5f1b4a760912 outParamInvoiceById, bool outParamIsUserCxp, bool outParamIsActiveUser, bool outParamIsAllowed, bool outParamIsProveedor, bool outParamIsDEV, bool outParamIsActiveDEV_AccountingCeBe) {RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs();
// Write the needed fields of the list outParamInvoiceById to the result.outParamInvoiceById
ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af tmpoutParamInvoiceByIdElement;
if(outParamInvoiceById.Empty) {
// Write the needed fields of the record outParamInvoiceById.CurrentRec to the tmpoutParamInvoiceByIdElement
tmpoutParamInvoiceByIdElement = new ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af();
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENInvoice to the tmpoutParamInvoiceByIdElement.AttrInvoice
tmpoutParamInvoiceByIdElement.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrId = (long?) 0L;
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrName = outParamInvoiceById.CurrentRec.ssENInvoice.ssName;
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrRequisitionId = (long?) outParamInvoiceById.CurrentRec.ssENInvoice.ssRequisitionId;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrFolioId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderMainId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCFDITypeId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrTotalAmount
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCurrency
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCurrency = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrInvoiceStatusId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingDateTime
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrPaymentDateTime
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrSubmittedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrIsNewVersion
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA_SAP
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrDoc51
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrDoc51 = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingError
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingError = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderAccConceptsID
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAmortization
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreditNoteInvoiceId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENInvoiceStatus to the tmpoutParamInvoiceByIdElement.AttrInvoiceStatus
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus = new ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrId
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrId = (int?) 0;
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabel = outParamInvoiceById.CurrentRec.ssENInvoiceStatus.ssLabel;
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrClass = outParamInvoiceById.CurrentRec.ssENInvoiceStatus.ssClass;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrOrder
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIs_Active
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIsInAccounting
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIsInAccounting = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabelES
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabelES = "";
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENRequisition to the tmpoutParamInvoiceByIdElement.AttrRequisition
tmpoutParamInvoiceByIdElement.AttrRequisition = new ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrName
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrName = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCounter
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCounter = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRequisitionStatusId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRequisitionStatusId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSupplierId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRegionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingRegionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingRegionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrApplicantId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrApplicantId = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrMaxDateFinishCapture
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrMaxDateFinishCapture = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetServiceId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetService
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetService = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectDescription
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectDescription = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrFrequencyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrFrequencyId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsSustainability
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsSustainability = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSustainabilityId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSustainabilityId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueCategoryId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueSubcategoryId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueSubcategoryId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTotalAmount
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCurrencyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCurrencyId = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDistributionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCostCenterId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContract
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContract = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsContractPending
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasDeposit
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasInsurance
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasAdvancePayment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceDescription_DEPREC
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceDescription_DEPREC = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrInvoiceUsageId_DEPREC
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrInvoiceUsageId_DEPREC = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceFormatId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceFormatId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCompanyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRetentionRate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrNegotiatedExchangeRate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentMethodId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentTermsId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAutomaticAccounting
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAutomaticAccounting = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedByApplicationRole
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedByApplicationRole = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDateOfCommitment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContractFileUploaded
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasUpdatedDateOfCommitment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasUpdatedDateOfCommitment = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSubmittedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsDonation
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAdvWithoutInvoice
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrWasAdvWithoutInvoice
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrWasAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAdvanced
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAdvanced = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDocumentTypeId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsCreatedByAnAssistente
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsCreatedByAnAssistente = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTelcelDirectionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasMultiUpload
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasMultiUpload = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingDate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentOptionsId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentWaysId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocNumber
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocNumber = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocPosition
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocPosition = "";
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENSupplier to the tmpoutParamInvoiceByIdElement.AttrSupplier
tmpoutParamInvoiceByIdElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrId
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTratamiento
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrName = outParamInvoiceById.CurrentRec.ssENSupplier.ssName;
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrNumber = outParamInvoiceById.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCalle_Numero
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrDistrito
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPais = outParamInvoiceById.CurrentRec.ssENSupplier.ssPais;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegion_
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIdioma
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTelefono
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrExtension
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrFax
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCliente
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrClavedegrupo
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrClavedegrupo = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrN_ident_fis_1 = outParamInvoiceById.CurrentRec.ssENSupplier.ssN_ident_fis_1;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPersonafisica
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRamo
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrGrupodeporte
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrEmail
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIsActive
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegionId
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENRegion to the tmpoutParamInvoiceByIdElement.AttrRegion
tmpoutParamInvoiceByIdElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrId
tmpoutParamInvoiceByIdElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCode = outParamInvoiceById.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrName
tmpoutParamInvoiceByIdElement.AttrRegion.AttrName = "";
tmpoutParamInvoiceByIdElement.AttrRegion.AttrDivisionFI = outParamInvoiceById.CurrentRec.ssENRegion.ssDivisionFI;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCentroRTP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCommissionRegion
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsActive
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFsP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFcP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFcP = (bool?) false;
result.outParamInvoiceById = new RestList<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af>(new ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af[] {}, tmpoutParamInvoiceByIdElement);
} else {
List<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af>
 tmpoutParamInvoiceById1List = new List<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af>
();
try {outParamInvoiceById.StartIteration();
while (!(outParamInvoiceById.Eof)) {
// Write the needed fields of the record outParamInvoiceById.CurrentRec to the tmpoutParamInvoiceByIdElement
tmpoutParamInvoiceByIdElement = new ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af();
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENInvoice to the tmpoutParamInvoiceByIdElement.AttrInvoice
tmpoutParamInvoiceByIdElement.AttrInvoice = new ssConectaProveedores.RestRecords.RESTEN_d1d0320db36efbb094ad0082361435a0EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrId = (long?) 0L;
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrName = outParamInvoiceById.CurrentRec.ssENInvoice.ssName;
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrRequisitionId = (long?) outParamInvoiceById.CurrentRec.ssENInvoice.ssRequisitionId;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrFolioId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrFolioId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderMainId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderMainId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCFDITypeId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCFDITypeId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrTotalAmount
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCurrency
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCurrency = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrInvoiceStatusId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrInvoiceStatusId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingDateTime
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrPaymentDateTime
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrPaymentDateTime = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrSubmittedOn
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrIsNewVersion
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrIsNewVersion = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA_SAP
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrID_POLIZA_SAP = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrDoc51
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrDoc51 = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingError
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAccountingError = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderAccConceptsID
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrOrderAccConceptsID = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAmortization
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrAmortization = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreditNoteInvoiceId
tmpoutParamInvoiceByIdElement.AttrInvoice.AttrCreditNoteInvoiceId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENInvoiceStatus to the tmpoutParamInvoiceByIdElement.AttrInvoiceStatus
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus = new ssConectaProveedores.RestRecords.RESTEN_63492c7b1e0aca9e542a86e1f5a48570EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrId
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrId = (int?) 0;
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabel = outParamInvoiceById.CurrentRec.ssENInvoiceStatus.ssLabel;
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrClass = outParamInvoiceById.CurrentRec.ssENInvoiceStatus.ssClass;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrOrder
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrOrder = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIs_Active
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIs_Active = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIsInAccounting
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrIsInAccounting = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabelES
tmpoutParamInvoiceByIdElement.AttrInvoiceStatus.AttrLabelES = "";
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENRequisition to the tmpoutParamInvoiceByIdElement.AttrRequisition
tmpoutParamInvoiceByIdElement.AttrRequisition = new ssConectaProveedores.RestRecords.RESTEN_98680591dcf3728e0877a90eb5e1e552EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrName
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrName = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCounter
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCounter = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRequisitionStatusId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRequisitionStatusId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSupplierId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSupplierId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRegionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingRegionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingRegionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrApplicantId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrApplicantId = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrMaxDateFinishCapture
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrMaxDateFinishCapture = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetServiceId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetServiceId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetService
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectAssetService = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectDescription
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrProjectDescription = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrFrequencyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrFrequencyId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsSustainability
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsSustainability = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSustainabilityId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSustainabilityId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueCategoryId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueCategoryId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueSubcategoryId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBusinessValueSubcategoryId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTotalAmount
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTotalAmount = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCurrencyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCurrencyId = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDistributionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDistributionId = (int?) 0;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCostCenterId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCostCenterId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContract
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContract = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsContractPending
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsContractPending = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasDeposit
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasDeposit = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasInsurance
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasInsurance = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasAdvancePayment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasAdvancePayment = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingServiceTypeId_DEPR = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceDescription_DEPREC
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceDescription_DEPREC = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrInvoiceUsageId_DEPREC
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrInvoiceUsageId_DEPREC = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceFormatId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrServiceFormatId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCompanyId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRetentionRate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrRetentionRate = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrNegotiatedExchangeRate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrNegotiatedExchangeRate = (decimal?) 0.0M;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentMethodId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentMethodId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentTermsId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentTermsId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAutomaticAccounting
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAutomaticAccounting = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedByApplicationRole
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrCreatedByApplicationRole = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDateOfCommitment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDateOfCommitment = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContractFileUploaded
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasContractFileUploaded = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasUpdatedDateOfCommitment
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasUpdatedDateOfCommitment = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSubmittedOn
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrSubmittedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsDonation
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsDonation = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAdvWithoutInvoice
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrWasAdvWithoutInvoice
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrWasAdvWithoutInvoice = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAdvanced
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsAdvanced = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDocumentTypeId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrDocumentTypeId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsCreatedByAnAssistente
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrIsCreatedByAnAssistente = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTelcelDirectionId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrTelcelDirectionId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasMultiUpload
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrHasMultiUpload = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingDate
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrAccountingDate = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateToText(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc));
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentOptionsId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentOptionsId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentWaysId
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrPaymentWaysId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocNumber
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocNumber = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocPosition
tmpoutParamInvoiceByIdElement.AttrRequisition.AttrBuyDocPosition = "";
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENSupplier to the tmpoutParamInvoiceByIdElement.AttrSupplier
tmpoutParamInvoiceByIdElement.AttrSupplier = new ssConectaProveedores.RestRecords.RESTEN_9d6ffd765945bcc9a7f807d4f431bd00EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrId
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrId = (long?) 0L;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTratamiento
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTratamiento = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrName = outParamInvoiceById.CurrentRec.ssENSupplier.ssName;
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrNumber = outParamInvoiceById.CurrentRec.ssENSupplier.ssNumber;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrConceptobusq_1_2
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrConceptobusq_1_2 = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCalle_Numero
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCalle_Numero = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrDistrito
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrDistrito = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCodigopostal_Pobl_
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCodigopostal_Pobl_ = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPais = outParamInvoiceById.CurrentRec.ssENSupplier.ssPais;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegion_
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegion_ = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIdioma
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIdioma = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTelefono
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrTelefono = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrExtension
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrExtension = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrFax
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrFax = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCliente
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCliente = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrSoc_GLasociada
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrSoc_GLasociada = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrClavedegrupo
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrClavedegrupo = "";
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrN_ident_fis_1 = outParamInvoiceById.CurrentRec.ssENSupplier.ssN_ident_fis_1;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPersonafisica
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrPersonafisica = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRamo
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRamo = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrGrupodeporte
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrGrupodeporte = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrEmail
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrEmail = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIsActive
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegionId
tmpoutParamInvoiceByIdElement.AttrSupplier.AttrRegionId = (long?) 0L;
// Write the needed fields of the record outParamInvoiceById.CurrentRec.ssENRegion to the tmpoutParamInvoiceByIdElement.AttrRegion
tmpoutParamInvoiceByIdElement.AttrRegion = new ssConectaProveedores.RestRecords.RESTEN_31f501c551d210017fcb34b5237e3390EntityRecord();
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrId
tmpoutParamInvoiceByIdElement.AttrRegion.AttrId = (long?) 0L;
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCode = outParamInvoiceById.CurrentRec.ssENRegion.ssCode;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrName
tmpoutParamInvoiceByIdElement.AttrRegion.AttrName = "";
tmpoutParamInvoiceByIdElement.AttrRegion.AttrDivisionFI = outParamInvoiceById.CurrentRec.ssENRegion.ssDivisionFI;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCentroRTP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCentroRTP = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCommissionRegion
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCommissionRegion = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsActive
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsActive = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedOn
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedBy
tmpoutParamInvoiceByIdElement.AttrRegion.AttrCreatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedOn
tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedBy
tmpoutParamInvoiceByIdElement.AttrRegion.AttrUpdatedBy = "";
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFsP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFsP = (bool?) false;
// Write optimized tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFcP
tmpoutParamInvoiceByIdElement.AttrRegion.AttrIsFcP = (bool?) false;
tmpoutParamInvoiceById1List.Add(tmpoutParamInvoiceByIdElement);
outParamInvoiceById.Advance();
}

} finally {
outParamInvoiceById.EndIteration();
}

result.outParamInvoiceById = new RestList<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af>(tmpoutParamInvoiceById1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af));
}

result.outParamIsUserCxp = (bool?) outParamIsUserCxp;
result.outParamIsActiveUser = (bool?) outParamIsActiveUser;
result.outParamIsAllowed = (bool?) outParamIsAllowed;
result.outParamIsProveedor = (bool?) outParamIsProveedor;
// Write optimized result.outParamIsDEV
result.outParamIsDEV = (bool?) false;
result.outParamIsActiveDEV_AccountingCeBe = (bool?) outParamIsActiveDEV_AccountingCeBe;
return result;
}


    public static ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model ToModel(RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs variables) {ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model result = new ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model();
result.outParamInvoiceById = variables == null ? new RL_e6ad6603ac07123d4d7c5f1b4a760912() : RL_e6ad6603ac07123d4d7c5f1b4a760912.FromRestList(variables.outParamInvoiceById, ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af.ToStructure);
result.outParamIsUserCxp = variables == null || variables.outParamIsUserCxp == null ? false : variables.outParamIsUserCxp.Value;
result.outParamIsActiveUser = variables == null || variables.outParamIsActiveUser == null ? false : variables.outParamIsActiveUser.Value;
result.outParamIsAllowed = variables == null || variables.outParamIsAllowed == null ? false : variables.outParamIsAllowed.Value;
result.outParamIsProveedor = variables == null || variables.outParamIsProveedor == null ? false : variables.outParamIsProveedor.Value;
result.outParamIsDEV = variables == null || variables.outParamIsDEV == null ? false : variables.outParamIsDEV.Value;
result.outParamIsActiveDEV_AccountingCeBe = variables == null || variables.outParamIsActiveDEV_AccountingCeBe == null ? false : variables.outParamIsActiveDEV_AccountingCeBe.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs result = new RESTConectaProveedores_d_Invoices_Invoices_Detail_DataActionGetInitializationData_Outputs();
result.outParamInvoiceById = screenModel.outParamInvoiceById.ToRestList<ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af>(ssConectaProveedores.RestRecords.RESTRC_42a47f09e8ab03d8e9c2d1f2f5aa06af.FromStructureDelegate(conf));
result.outParamIsUserCxp = (bool?) screenModel.outParamIsUserCxp;
result.outParamIsActiveUser = (bool?) screenModel.outParamIsActiveUser;
result.outParamIsAllowed = (bool?) screenModel.outParamIsAllowed;
result.outParamIsProveedor = (bool?) screenModel.outParamIsProveedor;
result.outParamIsDEV = (bool?) screenModel.outParamIsDEV;
result.outParamIsActiveDEV_AccountingCeBe = (bool?) screenModel.outParamIsActiveDEV_AccountingCeBe;
return result;
}

}
