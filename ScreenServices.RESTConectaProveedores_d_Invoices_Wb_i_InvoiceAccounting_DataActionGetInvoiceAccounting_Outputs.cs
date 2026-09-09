using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs : ScreenServicesApiController.Payload.IDataPayload {

    [JsonProperty("o_List")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure> outParamo_List;
[JsonProperty("o_InvoiceAccountingId")]
public long? outParamo_InvoiceAccountingId;


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs FromOutputs(IBehaviorsConfiguration conf, RL_c31399d0d7c776731653a069ba32283a outParamo_List, long outParamo_InvoiceAccountingId) {RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs();
// Write the needed fields of the list outParamo_List to the result.outParamo_List
ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure tmpoutParamo_ListElement;
if(outParamo_List.Empty) {
// Write the needed fields of the record outParamo_List.CurrentRec to the tmpoutParamo_ListElement
tmpoutParamo_ListElement = new ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
// Write optimized tmpoutParamo_ListElement.AttrAccountingAccounts_ServiceType
tmpoutParamo_ListElement.AttrAccountingAccounts_ServiceType = "";
tmpoutParamo_ListElement.AttrIsEditAccountingAccounts_ServiceType = (bool?) outParamo_List.CurrentRec.ssIsEditAccountingAccounts_ServiceType;
tmpoutParamo_ListElement.AttrIsErrorAccountingAccounts_ServiceType = (bool?) outParamo_List.CurrentRec.ssIsErrorAccountingAccounts_ServiceType;
tmpoutParamo_ListElement.AttrCostCenterSAP = outParamo_List.CurrentRec.ssCostCenterSAP;
tmpoutParamo_ListElement.AttrBeneficiaryCenterSAP = outParamo_List.CurrentRec.ssBeneficiaryCenterSAP;
tmpoutParamo_ListElement.AttrIsEditCostCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsEditCostCenterSAP;
tmpoutParamo_ListElement.AttrIsErrorCostCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsErrorCostCenterSAP;
tmpoutParamo_ListElement.AttrIsEditBenefitCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsEditBenefitCenterSAP;
tmpoutParamo_ListElement.AttrIsErrorBenefitCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsErrorBenefitCenterSAP;
tmpoutParamo_ListElement.AttrHideAccountingFields = (bool?) outParamo_List.CurrentRec.ssHideAccountingFields;
tmpoutParamo_ListElement.AttrHideServicesFields = (bool?) outParamo_List.CurrentRec.ssHideServicesFields;
// Write the needed fields of the record outParamo_List.CurrentRec.ssInvoiceAccounting to the tmpoutParamo_ListElement.AttrInvoiceAccounting
tmpoutParamo_ListElement.AttrInvoiceAccounting = new ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrInvoiceId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssInvoiceId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSupplierNumber = outParamo_List.CurrentRec.ssInvoiceAccounting.ssSupplierNumber;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceTypeId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceTypeId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrFreeText = outParamo_List.CurrentRec.ssInvoiceAccounting.ssFreeText;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrDivision = outParamo_List.CurrentRec.ssInvoiceAccounting.ssDivision;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIvaAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssIvaAmount;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIva_Old = outParamo_List.CurrentRec.ssInvoiceAccounting.ssIva_Old;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIvaIndicatorId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssIvaIndicatorId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrTotalAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssTotalAmount;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrPaymentMethodId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssPaymentMethodId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrPaymentTermsId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssPaymentTermsId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrICMEIndicator = outParamo_List.CurrentRec.ssInvoiceAccounting.ssICMEIndicator;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrCreatedBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssCreatedBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSubmissionBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssSubmissionBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSubmissionOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssSubmissionOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceCalledBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceCalledBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceCalledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceCalledOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrBuyDocNumber = outParamo_List.CurrentRec.ssInvoiceAccounting.ssBuyDocNumber;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrBuyDocPosition = outParamo_List.CurrentRec.ssInvoiceAccounting.ssBuyDocPosition;
// Write the needed fields of the record outParamo_List.CurrentRec.ssInvoiceAccountingServices to the tmpoutParamo_ListElement.AttrInvoiceAccountingServices
tmpoutParamo_ListElement.AttrInvoiceAccountingServices = new ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrInvoiceAccountingId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssInvoiceAccountingId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrServiceTypeId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssServiceTypeId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrAccount = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssAccount;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrCostCenterId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssCostCenterId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrCeBeCostCenterId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssCeBeCostCenterId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssAmount;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrIVA_Old = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssIVA_Old;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrIVAIndicatorId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssIVAIndicatorId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrBuyDocNumber = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssBuyDocNumber;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrBuyDocPosition = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssBuyDocPosition;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrFreeText = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssFreeText;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrDivision = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssDivision;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrICME = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssICME;
// Write the needed fields of the record outParamo_List.CurrentRec.ssCostCenter to the tmpoutParamo_ListElement.AttrCostCenter
tmpoutParamo_ListElement.AttrCostCenter = new ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrId
tmpoutParamo_ListElement.AttrCostCenter.AttrId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrRegionId
tmpoutParamo_ListElement.AttrCostCenter.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCompanyId
tmpoutParamo_ListElement.AttrCostCenter.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrSoc_
tmpoutParamo_ListElement.AttrCostCenter.AttrSoc_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDiv_
tmpoutParamo_ListElement.AttrCostCenter.AttrDiv_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrArea
tmpoutParamo_ListElement.AttrCostCenter.AttrArea = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCe_coste
tmpoutParamo_ListElement.AttrCostCenter.AttrCe_coste = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCeBe
tmpoutParamo_ListElement.AttrCostCenter.AttrCeBe = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDenominacion
tmpoutParamo_ListElement.AttrCostCenter.AttrDenominacion = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDescripcion
tmpoutParamo_ListElement.AttrCostCenter.AttrDescripcion = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrResponsable
tmpoutParamo_ListElement.AttrCostCenter.AttrResponsable = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCeCo
tmpoutParamo_ListElement.AttrCostCenter.AttrCeCo = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprim_reales_Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprim_reales_Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_reales_Ind_debl
tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_reales_Ind_debl = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosreales_Ind_debloqueo
tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosreales_Ind_debloqueo = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrActualiz_comprom__Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrActualiz_comprom__Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprimariosplan_Ind_debl
tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprimariosplan_Ind_debl = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_plan_Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_plan_Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosplan_Ind_debloqueo_
tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosplan_Ind_debloqueo_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrAutor
tmpoutParamo_ListElement.AttrCostCenter.AttrAutor = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedOn
tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedBy
tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedBy = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedOn
tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedBy
tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIsActive
tmpoutParamo_ListElement.AttrCostCenter.AttrIsActive = (bool?) false;
tmpoutParamo_ListElement.AttrIsEditFreeText = (bool?) outParamo_List.CurrentRec.ssIsEditFreeText;
tmpoutParamo_ListElement.AttrIsErrorFreeText = (bool?) outParamo_List.CurrentRec.ssIsErrorFreeText;
tmpoutParamo_ListElement.AttrIsEditDivision = (bool?) outParamo_List.CurrentRec.ssIsEditDivision;
tmpoutParamo_ListElement.AttrIsErrorDivision = (bool?) outParamo_List.CurrentRec.ssIsErrorDivision;
tmpoutParamo_ListElement.AttrIVAIndicator = outParamo_List.CurrentRec.ssIVAIndicator;
tmpoutParamo_ListElement.AttrIsEditIVA = (bool?) outParamo_List.CurrentRec.ssIsEditIVA;
tmpoutParamo_ListElement.AttrIsEditAmount = (bool?) outParamo_List.CurrentRec.ssIsEditAmount;
tmpoutParamo_ListElement.AttrIsErrorAmount = (bool?) outParamo_List.CurrentRec.ssIsErrorAmount;
tmpoutParamo_ListElement.AttrIsEditTotalAmount = (bool?) outParamo_List.CurrentRec.ssIsEditTotalAmount;
tmpoutParamo_ListElement.AttrIsErrorTotalAmount = (bool?) outParamo_List.CurrentRec.ssIsErrorTotalAmount;
tmpoutParamo_ListElement.AttrPaymentMethod = outParamo_List.CurrentRec.ssPaymentMethod;
tmpoutParamo_ListElement.AttrIsEditPaymentMethod = (bool?) outParamo_List.CurrentRec.ssIsEditPaymentMethod;
tmpoutParamo_ListElement.AttrPaymentTerm = outParamo_List.CurrentRec.ssPaymentTerm;
tmpoutParamo_ListElement.AttrIsEditPaymentTerm = (bool?) outParamo_List.CurrentRec.ssIsEditPaymentTerm;
tmpoutParamo_ListElement.AttrIsEditICME = (bool?) outParamo_List.CurrentRec.ssIsEditICME;
// Write optimized tmpoutParamo_ListElement.AttrIsEditBuyDocNumber
tmpoutParamo_ListElement.AttrIsEditBuyDocNumber = (bool?) false;
// Write optimized tmpoutParamo_ListElement.AttrIsEditBuyDocPosition
tmpoutParamo_ListElement.AttrIsEditBuyDocPosition = (bool?) false;
// Write optimized tmpoutParamo_ListElement.AttrBuyDocNumber
tmpoutParamo_ListElement.AttrBuyDocNumber = "";
// Write optimized tmpoutParamo_ListElement.AttrBuyDocPosition
tmpoutParamo_ListElement.AttrBuyDocPosition = "";
result.outParamo_List = new RestList<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure>(new ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure[] {}, tmpoutParamo_ListElement);
} else {
List<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure>
 tmpoutParamo_List1List = new List<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure>
();
try {outParamo_List.StartIteration();
while (!(outParamo_List.Eof)) {
// Write the needed fields of the record outParamo_List.CurrentRec to the tmpoutParamo_ListElement
tmpoutParamo_ListElement = new ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure();
// Write optimized tmpoutParamo_ListElement.AttrAccountingAccounts_ServiceType
tmpoutParamo_ListElement.AttrAccountingAccounts_ServiceType = "";
tmpoutParamo_ListElement.AttrIsEditAccountingAccounts_ServiceType = (bool?) outParamo_List.CurrentRec.ssIsEditAccountingAccounts_ServiceType;
tmpoutParamo_ListElement.AttrIsErrorAccountingAccounts_ServiceType = (bool?) outParamo_List.CurrentRec.ssIsErrorAccountingAccounts_ServiceType;
tmpoutParamo_ListElement.AttrCostCenterSAP = outParamo_List.CurrentRec.ssCostCenterSAP;
tmpoutParamo_ListElement.AttrBeneficiaryCenterSAP = outParamo_List.CurrentRec.ssBeneficiaryCenterSAP;
tmpoutParamo_ListElement.AttrIsEditCostCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsEditCostCenterSAP;
tmpoutParamo_ListElement.AttrIsErrorCostCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsErrorCostCenterSAP;
tmpoutParamo_ListElement.AttrIsEditBenefitCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsEditBenefitCenterSAP;
tmpoutParamo_ListElement.AttrIsErrorBenefitCenterSAP = (bool?) outParamo_List.CurrentRec.ssIsErrorBenefitCenterSAP;
tmpoutParamo_ListElement.AttrHideAccountingFields = (bool?) outParamo_List.CurrentRec.ssHideAccountingFields;
tmpoutParamo_ListElement.AttrHideServicesFields = (bool?) outParamo_List.CurrentRec.ssHideServicesFields;
// Write the needed fields of the record outParamo_List.CurrentRec.ssInvoiceAccounting to the tmpoutParamo_ListElement.AttrInvoiceAccounting
tmpoutParamo_ListElement.AttrInvoiceAccounting = new ssConectaProveedores.RestRecords.RESTEN_b3917cbd7cc45d0b71b8ce3e028f14a3EntityRecord();
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrInvoiceId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssInvoiceId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSupplierNumber = outParamo_List.CurrentRec.ssInvoiceAccounting.ssSupplierNumber;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceTypeId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceTypeId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrFreeText = outParamo_List.CurrentRec.ssInvoiceAccounting.ssFreeText;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrDivision = outParamo_List.CurrentRec.ssInvoiceAccounting.ssDivision;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIvaAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssIvaAmount;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIva_Old = outParamo_List.CurrentRec.ssInvoiceAccounting.ssIva_Old;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrIvaIndicatorId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssIvaIndicatorId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrTotalAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssTotalAmount;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrPaymentMethodId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssPaymentMethodId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrPaymentTermsId = (long?) outParamo_List.CurrentRec.ssInvoiceAccounting.ssPaymentTermsId;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrICMEIndicator = outParamo_List.CurrentRec.ssInvoiceAccounting.ssICMEIndicator;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrCreatedBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssCreatedBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssCreatedOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSubmissionBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssSubmissionBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrSubmissionOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssSubmissionOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceCalledBy = outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceCalledBy;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrServiceCalledOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(outParamo_List.CurrentRec.ssInvoiceAccounting.ssServiceCalledOn, conf.DateTimeFormat);
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrBuyDocNumber = outParamo_List.CurrentRec.ssInvoiceAccounting.ssBuyDocNumber;
tmpoutParamo_ListElement.AttrInvoiceAccounting.AttrBuyDocPosition = outParamo_List.CurrentRec.ssInvoiceAccounting.ssBuyDocPosition;
// Write the needed fields of the record outParamo_List.CurrentRec.ssInvoiceAccountingServices to the tmpoutParamo_ListElement.AttrInvoiceAccountingServices
tmpoutParamo_ListElement.AttrInvoiceAccountingServices = new ssConectaProveedores.RestRecords.RESTEN_103cfe3736a71d97f9a0699797cf8ac2EntityRecord();
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrInvoiceAccountingId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssInvoiceAccountingId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrServiceTypeId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssServiceTypeId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrAccount = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssAccount;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrCostCenterId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssCostCenterId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrCeBeCostCenterId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssCeBeCostCenterId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrAmount = (decimal?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssAmount;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrIVA_Old = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssIVA_Old;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrIVAIndicatorId = (long?) outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssIVAIndicatorId;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrBuyDocNumber = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssBuyDocNumber;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrBuyDocPosition = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssBuyDocPosition;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrFreeText = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssFreeText;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrDivision = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssDivision;
tmpoutParamo_ListElement.AttrInvoiceAccountingServices.AttrICME = outParamo_List.CurrentRec.ssInvoiceAccountingServices.ssICME;
// Write the needed fields of the record outParamo_List.CurrentRec.ssCostCenter to the tmpoutParamo_ListElement.AttrCostCenter
tmpoutParamo_ListElement.AttrCostCenter = new ssConectaProveedores.RestRecords.RESTEN_a1a752e04a72b49d9ac24eb8f53d0c86EntityRecord();
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrId
tmpoutParamo_ListElement.AttrCostCenter.AttrId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrRegionId
tmpoutParamo_ListElement.AttrCostCenter.AttrRegionId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCompanyId
tmpoutParamo_ListElement.AttrCostCenter.AttrCompanyId = (long?) 0L;
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrSoc_
tmpoutParamo_ListElement.AttrCostCenter.AttrSoc_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDiv_
tmpoutParamo_ListElement.AttrCostCenter.AttrDiv_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrArea
tmpoutParamo_ListElement.AttrCostCenter.AttrArea = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCe_coste
tmpoutParamo_ListElement.AttrCostCenter.AttrCe_coste = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCeBe
tmpoutParamo_ListElement.AttrCostCenter.AttrCeBe = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDenominacion
tmpoutParamo_ListElement.AttrCostCenter.AttrDenominacion = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrDescripcion
tmpoutParamo_ListElement.AttrCostCenter.AttrDescripcion = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrResponsable
tmpoutParamo_ListElement.AttrCostCenter.AttrResponsable = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCeCo
tmpoutParamo_ListElement.AttrCostCenter.AttrCeCo = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprim_reales_Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprim_reales_Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_reales_Ind_debl
tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_reales_Ind_debl = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosreales_Ind_debloqueo
tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosreales_Ind_debloqueo = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrActualiz_comprom__Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrActualiz_comprom__Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprimariosplan_Ind_debl
tmpoutParamo_ListElement.AttrCostCenter.AttrCostesprimariosplan_Ind_debl = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_plan_Ind_debloq
tmpoutParamo_ListElement.AttrCostCenter.AttrCostessecund_plan_Ind_debloq = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosplan_Ind_debloqueo_
tmpoutParamo_ListElement.AttrCostCenter.AttrIngresosplan_Ind_debloqueo_ = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrAutor
tmpoutParamo_ListElement.AttrCostCenter.AttrAutor = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedOn
tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedBy
tmpoutParamo_ListElement.AttrCostCenter.AttrCreatedBy = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedOn
tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedOn = OutSystems.RESTService.Runtime.Abstractions.Conversions.DateTimeToRestType(new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc), conf.DateTimeFormat);
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedBy
tmpoutParamo_ListElement.AttrCostCenter.AttrUpdatedBy = "";
// Write optimized tmpoutParamo_ListElement.AttrCostCenter.AttrIsActive
tmpoutParamo_ListElement.AttrCostCenter.AttrIsActive = (bool?) false;
tmpoutParamo_ListElement.AttrIsEditFreeText = (bool?) outParamo_List.CurrentRec.ssIsEditFreeText;
tmpoutParamo_ListElement.AttrIsErrorFreeText = (bool?) outParamo_List.CurrentRec.ssIsErrorFreeText;
tmpoutParamo_ListElement.AttrIsEditDivision = (bool?) outParamo_List.CurrentRec.ssIsEditDivision;
tmpoutParamo_ListElement.AttrIsErrorDivision = (bool?) outParamo_List.CurrentRec.ssIsErrorDivision;
tmpoutParamo_ListElement.AttrIVAIndicator = outParamo_List.CurrentRec.ssIVAIndicator;
tmpoutParamo_ListElement.AttrIsEditIVA = (bool?) outParamo_List.CurrentRec.ssIsEditIVA;
tmpoutParamo_ListElement.AttrIsEditAmount = (bool?) outParamo_List.CurrentRec.ssIsEditAmount;
tmpoutParamo_ListElement.AttrIsErrorAmount = (bool?) outParamo_List.CurrentRec.ssIsErrorAmount;
tmpoutParamo_ListElement.AttrIsEditTotalAmount = (bool?) outParamo_List.CurrentRec.ssIsEditTotalAmount;
tmpoutParamo_ListElement.AttrIsErrorTotalAmount = (bool?) outParamo_List.CurrentRec.ssIsErrorTotalAmount;
tmpoutParamo_ListElement.AttrPaymentMethod = outParamo_List.CurrentRec.ssPaymentMethod;
tmpoutParamo_ListElement.AttrIsEditPaymentMethod = (bool?) outParamo_List.CurrentRec.ssIsEditPaymentMethod;
tmpoutParamo_ListElement.AttrPaymentTerm = outParamo_List.CurrentRec.ssPaymentTerm;
tmpoutParamo_ListElement.AttrIsEditPaymentTerm = (bool?) outParamo_List.CurrentRec.ssIsEditPaymentTerm;
tmpoutParamo_ListElement.AttrIsEditICME = (bool?) outParamo_List.CurrentRec.ssIsEditICME;
// Write optimized tmpoutParamo_ListElement.AttrIsEditBuyDocNumber
tmpoutParamo_ListElement.AttrIsEditBuyDocNumber = (bool?) false;
// Write optimized tmpoutParamo_ListElement.AttrIsEditBuyDocPosition
tmpoutParamo_ListElement.AttrIsEditBuyDocPosition = (bool?) false;
// Write optimized tmpoutParamo_ListElement.AttrBuyDocNumber
tmpoutParamo_ListElement.AttrBuyDocNumber = "";
// Write optimized tmpoutParamo_ListElement.AttrBuyDocPosition
tmpoutParamo_ListElement.AttrBuyDocPosition = "";
tmpoutParamo_List1List.Add(tmpoutParamo_ListElement);
outParamo_List.Advance();
}

} finally {
outParamo_List.EndIteration();
}

result.outParamo_List = new RestList<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure>(tmpoutParamo_List1List.ToArray(), default(ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure));
}

result.outParamo_InvoiceAccountingId = (long?) outParamo_InvoiceAccountingId;
return result;
}


    public static ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model ToModel(RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs variables) {ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model result = new ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model();
result.outParamo_List = variables == null ? new RL_c31399d0d7c776731653a069ba32283a() : RL_c31399d0d7c776731653a069ba32283a.FromRestList(variables.outParamo_List, ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.ToStructure);
result.outParamo_InvoiceAccountingId = variables == null || variables.outParamo_InvoiceAccountingId == null ? 0L : variables.outParamo_InvoiceAccountingId.Value;
return result;
}


    public static RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs FromModel(IBehaviorsConfiguration conf, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Model screenModel) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs result = new RESTConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_DataActionGetInvoiceAccounting_Outputs();
result.outParamo_List = screenModel.outParamo_List.ToRestList<ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure>(ssConectaProveedores.RestRecords.RESTST_d9cd2417d7f5e39d5d950b6b6b9d1f5cStructure.FromStructureDelegate(conf));
result.outParamo_InvoiceAccountingId = (long?) screenModel.outParamo_InvoiceAccountingId;
return result;
}

}
