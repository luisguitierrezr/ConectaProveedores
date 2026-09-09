using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetFrequencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf> ScreenDataSetGetFrequencies;
[JsonProperty("GetUserById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba> ScreenDataSetGetUserById;
[JsonProperty("GetPaymentTerms")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> ScreenDataSetGetPaymentTerms;
[JsonProperty("GetSpecialPostDeliveryAuthorizations")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb> ScreenDataSetGetSpecialPostDeliveryAuthorizations;
[JsonProperty("GetPaymentWays")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8> ScreenDataSetGetPaymentWays;
[JsonProperty("GetAdvancedPaymentTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62> ScreenDataSetGetAdvancedPaymentTypes;
[JsonProperty("GetProjectAssetServices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServices;
[JsonProperty("GetInsuranceTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a> ScreenDataSetGetInsuranceTypes;
[JsonProperty("GetCostCenters")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d> ScreenDataSetGetCostCenters;
[JsonProperty("GetDocumentTypeAnticipoKW")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668> ScreenDataSetGetDocumentTypeAnticipoKW;
[JsonProperty("GetAccountableGuide")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7> ScreenDataSetGetAccountableGuide;
[JsonProperty("GetAccountingAccountsServiceTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba> ScreenDataSetGetAccountingAccountsServiceTypes;
[JsonProperty("GetSupplierSocieties")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561> ScreenDataSetGetSupplierSocieties;
[JsonProperty("GetProjectAssetByRequisition")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetByRequisition;
[JsonProperty("GetCurrencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> ScreenDataSetGetCurrencies;
[JsonProperty("GetPaymentOptions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797> ScreenDataSetGetPaymentOptions;
[JsonProperty("GetSustainabilities")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f> ScreenDataSetGetSustainabilities;
[JsonProperty("GetInvoiceUsages")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383> ScreenDataSetGetInvoiceUsages;
[JsonProperty("GetCostCenterSAPByRequisitionId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cc5b09a13023b24fea23c488b525369e> ScreenDataSetGetCostCenterSAPByRequisitionId;
[JsonProperty("GetProjectAssetServiceOtro")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServiceOtro;
[JsonProperty("GetPaymentWay99")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8> ScreenDataSetGetPaymentWay99;
[JsonProperty("GetAccountingDataTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c> ScreenDataSetGetAccountingDataTypes;
[JsonProperty("GetServiceFormats")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df> ScreenDataSetGetServiceFormats;
[JsonProperty("GetDistributions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185> ScreenDataSetGetDistributions;
[JsonProperty("GetBusinessValueCategories")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261> ScreenDataSetGetBusinessValueCategories;
[JsonProperty("GetRequisitionServicesByRequisitionId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6> ScreenDataSetGetRequisitionServicesByRequisitionId;
[JsonProperty("GetBusinessValueSubcategoriesByCategoryId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
[JsonProperty("GetEntraRole")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b> ScreenDataSetGetEntraRole;
[JsonProperty("GetRequisitionCostCentersByRequisitionId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02> ScreenDataSetGetRequisitionCostCentersByRequisitionId;
[JsonProperty("GetSupplierByRequisition")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce> ScreenDataSetGetSupplierByRequisition;
[JsonProperty("GetDocumentTypeKR")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668> ScreenDataSetGetDocumentTypeKR;
[JsonProperty("GetSupplierDetailBySociety")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684> ScreenDataSetGetSupplierDetailBySociety;
[JsonProperty("GetRequisitionById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_db730a379abf48e3725f395a2176e12f> ScreenDataSetGetRequisitionById;
[JsonProperty("GetDepositTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7> ScreenDataSetGetDepositTypes;
[JsonProperty("i_RequisitionId")]
public long? inParami_RequisitionId;
[JsonProperty("i_IsUploadInvoice")]
public bool? inParami_IsUploadInvoice;
[JsonProperty("l_AllFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure> varLcl_AllFiles;
[JsonProperty("l_Attached_Filename")]
public string varLcl_Attached_Filename;
[JsonProperty("l_AttachedFile_BinaryData")]
public byte[] varLcl_AttachedFile_BinaryData;
[JsonProperty("l_CanEditAccounting")]
public bool? varLcl_CanEditAccounting;
[JsonProperty("l_CanEditUserArea")]
public bool? varLcl_CanEditUserArea;
[JsonProperty("l_FormIsValid")]
public bool? varLcl_FormIsValid;
[JsonProperty("l_IsBusy")]
public bool? varLcl_IsBusy;
[JsonProperty("l_RefreshSideBar")]
public String varLcl_RefreshSideBar;
[JsonProperty("l_RetentionPercentageList")]
public RestList<ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74> varLcl_RetentionPercentageList;
[JsonProperty("l_SelectedCostCentersList")]
public RestList<ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord> varLcl_SelectedCostCentersList;
[JsonProperty("l_ShowCancelPopup")]
public bool? varLcl_ShowCancelPopup;
[JsonProperty("l_ShowModifyPopup")]
public bool? varLcl_ShowModifyPopup;
[JsonProperty("l_OriginalDateOfCommitment")]
public String varLcl_OriginalDateOfCommitment;
[JsonProperty("l_ShowSavePendingInfoBtn")]
public bool? varLcl_ShowSavePendingInfoBtn;
[JsonProperty("l_RefreshRequisitionEntra_Historic")]
public String varLcl_RefreshRequisitionEntra_Historic;
[JsonProperty("l_ShowHideSelectReqRegion_Popup")]
public bool? varLcl_ShowHideSelectReqRegion_Popup;
[JsonProperty("l_RegionId")]
public long? varLcl_RegionId;
[JsonProperty("l_ShowAssignFirstApproverPopup")]
public bool? varLcl_ShowAssignFirstApproverPopup;
[JsonProperty("l_SelectedAccount")]
public string varLcl_SelectedAccount;
[JsonProperty("ProjectAssetSearchText")]
public string varLcProjectAssetSearchText;
[JsonProperty("ProjectAssetMaxRecord")]
public int? varLcProjectAssetMaxRecord;
[JsonProperty("l_ShowHideSpecialOrNormalWorkflow")]
public bool? varLcl_ShowHideSpecialOrNormalWorkflow;
[JsonProperty("l_NotValid")]
public bool? varLcl_NotValid;
[JsonProperty("l_NotValidPaymentsValue")]
public bool? varLcl_NotValidPaymentsValue;
[JsonProperty("l_NotValidContractValue")]
public bool? varLcl_NotValidContractValue;
[JsonProperty("l_CanSeeAdvanceWithOrWithoutInvoice")]
public bool? varLcl_CanSeeAdvanceWithOrWithoutInvoice;
[JsonProperty("l_IsToExitCapture")]
public bool? varLcl_IsToExitCapture;
[JsonProperty("l_DropdownSupplierValid")]
public bool? varLcl_DropdownSupplierValid;
[JsonProperty("l_AllowActions")]
public bool? varLcl_AllowActions;
[JsonProperty("l_PreviousSelectedCostCenter")]
public long? varLcl_PreviousSelectedCostCenter;
[JsonProperty("GetRequisitionContractData")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Outputs varLcGetRequisitionContractData;
[JsonProperty("GetShowSelectReqPopup")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Outputs varLcGetShowSelectReqPopup;
[JsonProperty("GetAdvWithoutInvoiceData")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Outputs varLcGetAdvWithoutInvoiceData;
[JsonProperty("GetConfiguration")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Outputs varLcGetConfiguration;
[JsonProperty("GetAccountingData")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Outputs varLcGetAccountingData;
[JsonProperty("GetShowIsDonation")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs varLcGetShowIsDonation;
[JsonProperty("GetSettings")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Outputs varLcGetSettings;
[JsonProperty("GetRequisitionFiles")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Outputs varLcGetRequisitionFiles;
[JsonProperty("GetUserApplicationRoles")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs varLcGetUserApplicationRoles;
[JsonProperty("GetPaymentMethodsBySupplierId")]
public RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs varLcGetPaymentMethodsBySupplierId;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel ToModel() {long inParami_RequisitionId = variables.inParami_RequisitionId == null ? 0L : variables.inParami_RequisitionId.Value;
bool inParami_IsUploadInvoice = variables.inParami_IsUploadInvoice == null ? false : variables.inParami_IsUploadInvoice.Value;
RL_7a479a555821b093171c5d3cd3382006 varLcl_AllFiles = RL_7a479a555821b093171c5d3cd3382006.FromRestList(variables.varLcl_AllFiles, ssConectaProveedores.RestRecords.RESTST_26b16bea631cbd94cf555acb5c7a4be3Structure.ToStructure);
string varLcl_Attached_Filename = variables.varLcl_Attached_Filename == null ? "" : variables.varLcl_Attached_Filename;
byte[] varLcl_AttachedFile_BinaryData = variables.varLcl_AttachedFile_BinaryData == null ? new byte[] {} : variables.varLcl_AttachedFile_BinaryData;
bool varLcl_CanEditAccounting = variables.varLcl_CanEditAccounting == null ? false : variables.varLcl_CanEditAccounting.Value;
bool varLcl_CanEditUserArea = variables.varLcl_CanEditUserArea == null ? false : variables.varLcl_CanEditUserArea.Value;
bool varLcl_FormIsValid = variables.varLcl_FormIsValid == null ? false : variables.varLcl_FormIsValid.Value;
bool varLcl_IsBusy = variables.varLcl_IsBusy == null ? false : variables.varLcl_IsBusy.Value;
DateTime varLcl_RefreshSideBar = variables.varLcl_RefreshSideBar == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefreshSideBar, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
RL_88196b1a2e1928c27f6fa3b58c10c14d varLcl_RetentionPercentageList = RL_88196b1a2e1928c27f6fa3b58c10c14d.FromRestList(variables.varLcl_RetentionPercentageList, ssConectaProveedores.RestRecords.RESTRC_ee67c405f78e15f46603b032a29fae74.ToStructure);
RL_943f36694cec370c0ce0c406bfa23715 varLcl_SelectedCostCentersList = RL_943f36694cec370c0ce0c406bfa23715.FromRestList(variables.varLcl_SelectedCostCentersList, ssConectaProveedores.RestRecords.RESTEN_114fcf95674648310a3efb0d78529a37EntityRecord.ToStructure);
bool varLcl_ShowCancelPopup = variables.varLcl_ShowCancelPopup == null ? false : variables.varLcl_ShowCancelPopup.Value;
bool varLcl_ShowModifyPopup = variables.varLcl_ShowModifyPopup == null ? false : variables.varLcl_ShowModifyPopup.Value;
DateTime varLcl_OriginalDateOfCommitment = variables.varLcl_OriginalDateOfCommitment == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDate(variables.varLcl_OriginalDateOfCommitment);
bool varLcl_ShowSavePendingInfoBtn = variables.varLcl_ShowSavePendingInfoBtn == null ? false : variables.varLcl_ShowSavePendingInfoBtn.Value;
DateTime varLcl_RefreshRequisitionEntra_Historic = variables.varLcl_RefreshRequisitionEntra_Historic == null ? BuiltInFunction.CurrDateTime () : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.varLcl_RefreshRequisitionEntra_Historic, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_ShowHideSelectReqRegion_Popup = variables.varLcl_ShowHideSelectReqRegion_Popup == null ? false : variables.varLcl_ShowHideSelectReqRegion_Popup.Value;
long varLcl_RegionId = variables.varLcl_RegionId == null ? 0L : variables.varLcl_RegionId.Value;
bool varLcl_ShowAssignFirstApproverPopup = variables.varLcl_ShowAssignFirstApproverPopup == null ? false : variables.varLcl_ShowAssignFirstApproverPopup.Value;
string varLcl_SelectedAccount = variables.varLcl_SelectedAccount == null ? "" : variables.varLcl_SelectedAccount;
string varLcProjectAssetSearchText = variables.varLcProjectAssetSearchText == null ? "" : variables.varLcProjectAssetSearchText;
int varLcProjectAssetMaxRecord = variables.varLcProjectAssetMaxRecord == null ? 20 : variables.varLcProjectAssetMaxRecord.Value;
bool varLcl_ShowHideSpecialOrNormalWorkflow = variables.varLcl_ShowHideSpecialOrNormalWorkflow == null ? false : variables.varLcl_ShowHideSpecialOrNormalWorkflow.Value;
bool varLcl_NotValid = variables.varLcl_NotValid == null ? false : variables.varLcl_NotValid.Value;
bool varLcl_NotValidPaymentsValue = variables.varLcl_NotValidPaymentsValue == null ? false : variables.varLcl_NotValidPaymentsValue.Value;
bool varLcl_NotValidContractValue = variables.varLcl_NotValidContractValue == null ? false : variables.varLcl_NotValidContractValue.Value;
bool varLcl_CanSeeAdvanceWithOrWithoutInvoice = variables.varLcl_CanSeeAdvanceWithOrWithoutInvoice == null ? false : variables.varLcl_CanSeeAdvanceWithOrWithoutInvoice.Value;
bool varLcl_IsToExitCapture = variables.varLcl_IsToExitCapture == null ? false : variables.varLcl_IsToExitCapture.Value;
bool varLcl_DropdownSupplierValid = variables.varLcl_DropdownSupplierValid == null ? true : variables.varLcl_DropdownSupplierValid.Value;
bool varLcl_AllowActions = variables.varLcl_AllowActions == null ? false : variables.varLcl_AllowActions.Value;
long varLcl_PreviousSelectedCostCenter = variables.varLcl_PreviousSelectedCostCenter == null ? 0L : variables.varLcl_PreviousSelectedCostCenter.Value;
AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> _ScreenDataSetGetFrequencies = (variables.ScreenDataSetGetFrequencies != null) ? variables.ScreenDataSetGetFrequencies.FromJS((array) => {
return RL_86161aa08f9858d205ef72cffcb4919d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf.ToStructure);
}
) : null;
AggregateRecord<RL_52a3075ea09fce1b2b3cbeb7d74742be> _ScreenDataSetGetUserById = (variables.ScreenDataSetGetUserById != null) ? variables.ScreenDataSetGetUserById.FromJS((array) => {
return RL_52a3075ea09fce1b2b3cbeb7d74742be.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_21a885f0bb9cdabb4dd12f34282bebba.ToStructure);
}
) : null;
AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> _ScreenDataSetGetPaymentTerms = (variables.ScreenDataSetGetPaymentTerms != null) ? variables.ScreenDataSetGetPaymentTerms.FromJS((array) => {
return RL_375b9dd8c8b0d6d7bccf4d550f48644d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.ToStructure);
}
) : null;
AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> _ScreenDataSetGetSpecialPostDeliveryAuthorizations = (variables.ScreenDataSetGetSpecialPostDeliveryAuthorizations != null) ? variables.ScreenDataSetGetSpecialPostDeliveryAuthorizations.FromJS((array) => {
return RL_9a84f0ca43f575461143a73bcb506dba.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb.ToStructure);
}
) : null;
AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> _ScreenDataSetGetPaymentWays = (variables.ScreenDataSetGetPaymentWays != null) ? variables.ScreenDataSetGetPaymentWays.FromJS((array) => {
return RL_d98dc7eec8c631266895b622203a6db3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8.ToStructure);
}
) : null;
AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> _ScreenDataSetGetAdvancedPaymentTypes = (variables.ScreenDataSetGetAdvancedPaymentTypes != null) ? variables.ScreenDataSetGetAdvancedPaymentTypes.FromJS((array) => {
return RL_0d443dd02abe633532f6b939b4573e00.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServices = (variables.ScreenDataSetGetProjectAssetServices != null) ? variables.ScreenDataSetGetProjectAssetServices.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> _ScreenDataSetGetInsuranceTypes = (variables.ScreenDataSetGetInsuranceTypes != null) ? variables.ScreenDataSetGetInsuranceTypes.FromJS((array) => {
return RL_32b3fec96f8ddbf444444f34b158e188.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a.ToStructure);
}
) : null;
AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> _ScreenDataSetGetCostCenters = (variables.ScreenDataSetGetCostCenters != null) ? variables.ScreenDataSetGetCostCenters.FromJS((array) => {
return RL_ec55ed22dae89075d036f3a863173164.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_515e950fe4b29206769e5475135e301d.ToStructure);
}
) : null;
AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> _ScreenDataSetGetDocumentTypeAnticipoKW = (variables.ScreenDataSetGetDocumentTypeAnticipoKW != null) ? variables.ScreenDataSetGetDocumentTypeAnticipoKW.FromJS((array) => {
return RL_f2d249f675a5073e98f93433009d7ad4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668.ToStructure);
}
) : null;
AggregateRecord<RL_369f9983c2b36180025202f97bb71651> _ScreenDataSetGetAccountableGuide = (variables.ScreenDataSetGetAccountableGuide != null) ? variables.ScreenDataSetGetAccountableGuide.FromJS((array) => {
return RL_369f9983c2b36180025202f97bb71651.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5529030b7e85f68f6007e4d32f650ef7.ToStructure);
}
) : null;
AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> _ScreenDataSetGetAccountingAccountsServiceTypes = (variables.ScreenDataSetGetAccountingAccountsServiceTypes != null) ? variables.ScreenDataSetGetAccountingAccountsServiceTypes.FromJS((array) => {
return RL_60b4efe2937800b54618ed04c4847a05.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f52b5cefcfac404122195213ce1b53ba.ToStructure);
}
) : null;
AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> _ScreenDataSetGetSupplierSocieties = (variables.ScreenDataSetGetSupplierSocieties != null) ? variables.ScreenDataSetGetSupplierSocieties.FromJS((array) => {
return RL_3c0fa01b89994c3e2eaed82b259c3f66.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5df7bb5aa64fe06d5d087faa4a2fd561.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetByRequisition = (variables.ScreenDataSetGetProjectAssetByRequisition != null) ? variables.ScreenDataSetGetProjectAssetByRequisition.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> _ScreenDataSetGetCurrencies = (variables.ScreenDataSetGetCurrencies != null) ? variables.ScreenDataSetGetCurrencies.FromJS((array) => {
return RL_1353a59e0688582d82bbddc41b47193e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.ToStructure);
}
) : null;
AggregateRecord<RL_251acb2daece433ee402c9709ec88356> _ScreenDataSetGetPaymentOptions = (variables.ScreenDataSetGetPaymentOptions != null) ? variables.ScreenDataSetGetPaymentOptions.FromJS((array) => {
return RL_251acb2daece433ee402c9709ec88356.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797.ToStructure);
}
) : null;
AggregateRecord<RL_c861661ffef6a96c498651ed1efeee53> _ScreenDataSetGetSustainabilities = (variables.ScreenDataSetGetSustainabilities != null) ? variables.ScreenDataSetGetSustainabilities.FromJS((array) => {
return RL_c861661ffef6a96c498651ed1efeee53.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f677954b3254ea60260cb7baa72dce4f.ToStructure);
}
) : null;
AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> _ScreenDataSetGetInvoiceUsages = (variables.ScreenDataSetGetInvoiceUsages != null) ? variables.ScreenDataSetGetInvoiceUsages.FromJS((array) => {
return RL_1078cb2b44dad3e211c3325e839a4151.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383.ToStructure);
}
) : null;
AggregateRecord<RL_40d1dae5da886b385f88ea5c5c7574ca> _ScreenDataSetGetCostCenterSAPByRequisitionId = (variables.ScreenDataSetGetCostCenterSAPByRequisitionId != null) ? variables.ScreenDataSetGetCostCenterSAPByRequisitionId.FromJS((array) => {
return RL_40d1dae5da886b385f88ea5c5c7574ca.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cc5b09a13023b24fea23c488b525369e.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServiceOtro = (variables.ScreenDataSetGetProjectAssetServiceOtro != null) ? variables.ScreenDataSetGetProjectAssetServiceOtro.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> _ScreenDataSetGetPaymentWay99 = (variables.ScreenDataSetGetPaymentWay99 != null) ? variables.ScreenDataSetGetPaymentWay99.FromJS((array) => {
return RL_d98dc7eec8c631266895b622203a6db3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8.ToStructure);
}
) : null;
AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> _ScreenDataSetGetAccountingDataTypes = (variables.ScreenDataSetGetAccountingDataTypes != null) ? variables.ScreenDataSetGetAccountingDataTypes.FromJS((array) => {
return RL_d567d658fa66fc955f880e37985e7f35.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c.ToStructure);
}
) : null;
AggregateRecord<RL_2ce058321dad3f60357fc3b3372ccb1e> _ScreenDataSetGetServiceFormats = (variables.ScreenDataSetGetServiceFormats != null) ? variables.ScreenDataSetGetServiceFormats.FromJS((array) => {
return RL_2ce058321dad3f60357fc3b3372ccb1e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1356565a59d37b0a56b61edcf3cae9df.ToStructure);
}
) : null;
AggregateRecord<RL_63e875add2b98c15e5030850edd3b2eb> _ScreenDataSetGetDistributions = (variables.ScreenDataSetGetDistributions != null) ? variables.ScreenDataSetGetDistributions.FromJS((array) => {
return RL_63e875add2b98c15e5030850edd3b2eb.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a6482208c24ce2e6c9c6ba16e57b0185.ToStructure);
}
) : null;
AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> _ScreenDataSetGetBusinessValueCategories = (variables.ScreenDataSetGetBusinessValueCategories != null) ? variables.ScreenDataSetGetBusinessValueCategories.FromJS((array) => {
return RL_901339470d357e86e0df985d0e6489f6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261.ToStructure);
}
) : null;
AggregateRecord<RL_b47d9310671b1b627f451a333bb8980a> _ScreenDataSetGetRequisitionServicesByRequisitionId = (variables.ScreenDataSetGetRequisitionServicesByRequisitionId != null) ? variables.ScreenDataSetGetRequisitionServicesByRequisitionId.FromJS((array) => {
return RL_b47d9310671b1b627f451a333bb8980a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_04e7247757060d4016b43102119b0dd6.ToStructure);
}
) : null;
AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> _ScreenDataSetGetBusinessValueSubcategoriesByCategoryId = (variables.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId != null) ? variables.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId.FromJS((array) => {
return RL_2d11b20156650990ba0f3131aaaad2ea.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84.ToStructure);
}
) : null;
AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> _ScreenDataSetGetEntraRole = (variables.ScreenDataSetGetEntraRole != null) ? variables.ScreenDataSetGetEntraRole.FromJS((array) => {
return RL_ea7d18baeeefa57d5c86706d7efb98e9.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2d026dc77741fad17a11f0df63aa3b4b.ToStructure);
}
) : null;
AggregateRecord<RL_a3213f63c9dee3312d82d37ec604d349> _ScreenDataSetGetRequisitionCostCentersByRequisitionId = (variables.ScreenDataSetGetRequisitionCostCentersByRequisitionId != null) ? variables.ScreenDataSetGetRequisitionCostCentersByRequisitionId.FromJS((array) => {
return RL_a3213f63c9dee3312d82d37ec604d349.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_7c130c22cc39a396afe0c98666f27e02.ToStructure);
}
) : null;
AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> _ScreenDataSetGetSupplierByRequisition = (variables.ScreenDataSetGetSupplierByRequisition != null) ? variables.ScreenDataSetGetSupplierByRequisition.FromJS((array) => {
return RL_d5c1b2482ff109e80580d8b5fb920193.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.ToStructure);
}
) : null;
AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> _ScreenDataSetGetDocumentTypeKR = (variables.ScreenDataSetGetDocumentTypeKR != null) ? variables.ScreenDataSetGetDocumentTypeKR.FromJS((array) => {
return RL_f2d249f675a5073e98f93433009d7ad4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_10f704d4de8999e255a09f6b1b9b5668.ToStructure);
}
) : null;
AggregateRecord<RL_10b798eceef0c61e2eb85d7fd35e40d6> _ScreenDataSetGetSupplierDetailBySociety = (variables.ScreenDataSetGetSupplierDetailBySociety != null) ? variables.ScreenDataSetGetSupplierDetailBySociety.FromJS((array) => {
return RL_10b798eceef0c61e2eb85d7fd35e40d6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2a6a47a042b2e84eddb6ad9d86f0a684.ToStructure);
}
) : null;
AggregateRecord<RL_db407242f011e8b84a110f6970108663> _ScreenDataSetGetRequisitionById = (variables.ScreenDataSetGetRequisitionById != null) ? variables.ScreenDataSetGetRequisitionById.FromJS((array) => {
return RL_db407242f011e8b84a110f6970108663.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_db730a379abf48e3725f395a2176e12f.ToStructure);
}
) : null;
AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> _ScreenDataSetGetDepositTypes = (variables.ScreenDataSetGetDepositTypes != null) ? variables.ScreenDataSetGetDepositTypes.FromJS((array) => {
return RL_cda7ed93cc851adc2316965418c61e6f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7.ToStructure);
}
) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Model _varLcGetRequisitionContractData = (variables.varLcGetRequisitionContractData != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Outputs.ToModel(variables.varLcGetRequisitionContractData) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Model _varLcGetShowSelectReqPopup = (variables.varLcGetShowSelectReqPopup != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Outputs.ToModel(variables.varLcGetShowSelectReqPopup) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Model _varLcGetAdvWithoutInvoiceData = (variables.varLcGetAdvWithoutInvoiceData != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Outputs.ToModel(variables.varLcGetAdvWithoutInvoiceData) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Model _varLcGetConfiguration = (variables.varLcGetConfiguration != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Outputs.ToModel(variables.varLcGetConfiguration) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Model _varLcGetAccountingData = (variables.varLcGetAccountingData != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Outputs.ToModel(variables.varLcGetAccountingData) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model _varLcGetShowIsDonation = (variables.varLcGetShowIsDonation != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Outputs.ToModel(variables.varLcGetShowIsDonation) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Model _varLcGetSettings = (variables.varLcGetSettings != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Outputs.ToModel(variables.varLcGetSettings) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Model _varLcGetRequisitionFiles = (variables.varLcGetRequisitionFiles != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Outputs.ToModel(variables.varLcGetRequisitionFiles) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model _varLcGetUserApplicationRoles = (variables.varLcGetUserApplicationRoles != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Outputs.ToModel(variables.varLcGetUserApplicationRoles) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model _varLcGetPaymentMethodsBySupplierId = (variables.varLcGetPaymentMethodsBySupplierId != null) ? RESTConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Outputs.ToModel(variables.varLcGetPaymentMethodsBySupplierId) : null;
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel screenModel = new ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel(inParami_RequisitionId, inParami_IsUploadInvoice, varLcl_AllFiles, varLcl_Attached_Filename, varLcl_AttachedFile_BinaryData, varLcl_CanEditAccounting, varLcl_CanEditUserArea, varLcl_FormIsValid, varLcl_IsBusy, varLcl_RefreshSideBar, varLcl_RetentionPercentageList, varLcl_SelectedCostCentersList, varLcl_ShowCancelPopup, varLcl_ShowModifyPopup, varLcl_OriginalDateOfCommitment, varLcl_ShowSavePendingInfoBtn, varLcl_RefreshRequisitionEntra_Historic, varLcl_ShowHideSelectReqRegion_Popup, varLcl_RegionId, varLcl_ShowAssignFirstApproverPopup, varLcl_SelectedAccount, varLcProjectAssetSearchText, varLcProjectAssetMaxRecord, varLcl_ShowHideSpecialOrNormalWorkflow, varLcl_NotValid, varLcl_NotValidPaymentsValue, varLcl_NotValidContractValue, varLcl_CanSeeAdvanceWithOrWithoutInvoice, varLcl_IsToExitCapture, varLcl_DropdownSupplierValid, varLcl_AllowActions, varLcl_PreviousSelectedCostCenter, _ScreenDataSetGetFrequencies, _ScreenDataSetGetUserById, _ScreenDataSetGetPaymentTerms, _ScreenDataSetGetSpecialPostDeliveryAuthorizations, _ScreenDataSetGetPaymentWays, _ScreenDataSetGetAdvancedPaymentTypes, _ScreenDataSetGetProjectAssetServices, _ScreenDataSetGetInsuranceTypes, _ScreenDataSetGetCostCenters, _ScreenDataSetGetDocumentTypeAnticipoKW, _ScreenDataSetGetAccountableGuide, _ScreenDataSetGetAccountingAccountsServiceTypes, _ScreenDataSetGetSupplierSocieties, _ScreenDataSetGetProjectAssetByRequisition, _ScreenDataSetGetCurrencies, _ScreenDataSetGetPaymentOptions, _ScreenDataSetGetSustainabilities, _ScreenDataSetGetInvoiceUsages, _ScreenDataSetGetCostCenterSAPByRequisitionId, _ScreenDataSetGetProjectAssetServiceOtro, _ScreenDataSetGetPaymentWay99, _ScreenDataSetGetAccountingDataTypes, _ScreenDataSetGetServiceFormats, _ScreenDataSetGetDistributions, _ScreenDataSetGetBusinessValueCategories, _ScreenDataSetGetRequisitionServicesByRequisitionId, _ScreenDataSetGetBusinessValueSubcategoriesByCategoryId, _ScreenDataSetGetEntraRole, _ScreenDataSetGetRequisitionCostCentersByRequisitionId, _ScreenDataSetGetSupplierByRequisition, _ScreenDataSetGetDocumentTypeKR, _ScreenDataSetGetSupplierDetailBySociety, _ScreenDataSetGetRequisitionById, _ScreenDataSetGetDepositTypes, _varLcGetRequisitionContractData, _varLcGetShowSelectReqPopup, _varLcGetAdvWithoutInvoiceData, _varLcGetConfiguration, _varLcGetAccountingData, _varLcGetShowIsDonation, _varLcGetSettings, _varLcGetRequisitionFiles, _varLcGetUserApplicationRoles, _varLcGetPaymentMethodsBySupplierId, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
