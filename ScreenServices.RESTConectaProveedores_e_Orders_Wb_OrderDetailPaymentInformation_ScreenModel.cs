using System.Diagnostics;
using OutSystems.RESTService.Runtime.Abstractions.Behaviors;
using OutSystems.RESTService.Runtime.Core.Controllers;
using OutSystems.RESTService.Runtime.Core.Controllers.ScreenServices;

namespace ssConectaProveedores.ScreenServices;

public class RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel : ScreenServicesApiController.Payload.IDataPayload {

    public class ScreenModelVariables {
        [JsonProperty("GetInsuranceTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a> ScreenDataSetGetInsuranceTypes;
[JsonProperty("GetDepositTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7> ScreenDataSetGetDepositTypes;
[JsonProperty("GetPaymentWays")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8> ScreenDataSetGetPaymentWays;
[JsonProperty("GetAccountingDataTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c> ScreenDataSetGetAccountingDataTypes;
[JsonProperty("GetBusinessValueCategories")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261> ScreenDataSetGetBusinessValueCategories;
[JsonProperty("GetOrderMainItemsByOrderMainId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64> ScreenDataSetGetOrderMainItemsByOrderMainId;
[JsonProperty("GetAdvancedPaymentTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62> ScreenDataSetGetAdvancedPaymentTypes;
[JsonProperty("GetBusinessValueSubcategoriesByCategoryId")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
[JsonProperty("GetInvoiceUsages")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383> ScreenDataSetGetInvoiceUsages;
[JsonProperty("GetFrequencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf> ScreenDataSetGetFrequencies;
[JsonProperty("GetProjectAssetServices")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServices;
[JsonProperty("GetRejectComment")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6> ScreenDataSetGetRejectComment;
[JsonProperty("GetSupplierByRequisition")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce> ScreenDataSetGetSupplierByRequisition;
[JsonProperty("GetSpecialApprovals")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5> ScreenDataSetGetSpecialApprovals;
[JsonProperty("GetPaymentTerms")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a> ScreenDataSetGetPaymentTerms;
[JsonProperty("GetPaymentMethods")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e> ScreenDataSetGetPaymentMethods;
[JsonProperty("GetOrderRetentionTypes")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42> ScreenDataSetGetOrderRetentionTypes;
[JsonProperty("GetCurrencies")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e> ScreenDataSetGetCurrencies;
[JsonProperty("GetOrderMainById")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_655f10514459daf453e41f31c05184fc> ScreenDataSetGetOrderMainById;
[JsonProperty("GetSpecialPostDeliveryAuthorizations")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb> ScreenDataSetGetSpecialPostDeliveryAuthorizations;
[JsonProperty("GetProjectAssetServiceOtro")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e> ScreenDataSetGetProjectAssetServiceOtro;
[JsonProperty("GetContractStatuses")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333> ScreenDataSetGetContractStatuses;
[JsonProperty("GetSuppliers")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e> ScreenDataSetGetSuppliers;
[JsonProperty("GetPaymentOptions")]
public RESTAggregateRecord<ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797> ScreenDataSetGetPaymentOptions;
[JsonProperty("i_OrderId")]
public long? inParami_OrderId;
[JsonProperty("i_ForceRefresh")]
public String inParami_ForceRefresh;
[JsonProperty("l_CanEditForm")]
public bool? varLcl_CanEditForm;
[JsonProperty("FilesList")]
public RestList<ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure> varLcFilesList;
[JsonProperty("l_FormIsValid")]
public bool? varLcl_FormIsValid;
[JsonProperty("l_OrderRequestFiles")]
public RestList<ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure> varLcl_OrderRequestFiles;
[JsonProperty("ShowOrderReject_Popup")]
public bool? varLcShowOrderReject_Popup;
[JsonProperty("DependentFoliosText")]
public string varLcDependentFoliosText;
[JsonProperty("l_RequestDocsErrorMessage")]
public string varLcl_RequestDocsErrorMessage;
[JsonProperty("l_IsValidReqDoc")]
public bool? varLcl_IsValidReqDoc;
[JsonProperty("l_CanUploadContract")]
public bool? varLcl_CanUploadContract;
[JsonProperty("l_IsSavingContractFile")]
public bool? varLcl_IsSavingContractFile;
[JsonProperty("l_IsMissingEstimEqualAgFiniquito")]
public bool? varLcl_IsMissingEstimEqualAgFiniquito;
[JsonProperty("GetPaymentTermSpecial")]
public RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Outputs varLcGetPaymentTermSpecial;
[JsonProperty("GetOrderContractData")]
public RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Outputs varLcGetOrderContractData;
[JsonProperty("GetOrderFilesList")]
public RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Outputs varLcGetOrderFilesList;
[JsonProperty("GetAccountingData")]
public RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Outputs varLcGetAccountingData;

    }

    [JsonProperty("variables")]
public ScreenModelVariables variables = new ScreenModelVariables();
public RESTConectaProveedores_ClientVariables clientVariables = new RESTConectaProveedores_ClientVariables();


    public static RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel FromJSON(JObject screenModel, JObject clientVars, JsonSerializer settings) {if((screenModel == null)) {
return null;
}

RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel result = screenModel.ToObject<RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel>(settings);
result.clientVariables = RESTConectaProveedores_ClientVariables.FromJSON(clientVars, settings);
return result;
}


    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel ToModel() {long inParami_OrderId = variables.inParami_OrderId == null ? 0L : variables.inParami_OrderId.Value;
DateTime inParami_ForceRefresh = variables.inParami_ForceRefresh == null ? new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc) : OutSystems.RESTService.Runtime.Abstractions.Conversions.TextToDateTime(variables.inParami_ForceRefresh, OutSystems.RESTService.Runtime.Abstractions.Behaviors.DateTimeFormat.ISO);
bool varLcl_CanEditForm = variables.varLcl_CanEditForm == null ? true : variables.varLcl_CanEditForm.Value;
RL_3d745491e03d6d19ccc0e1b33a371ccc varLcFilesList = RL_3d745491e03d6d19ccc0e1b33a371ccc.FromRestList(variables.varLcFilesList, ssConectaProveedores.RestRecords.RESTST_c3df6a1f053620bf8d50da58ff4e41bcStructure.ToStructure);
bool varLcl_FormIsValid = variables.varLcl_FormIsValid == null ? true : variables.varLcl_FormIsValid.Value;
RL_9d3b4c4e80b371ac0dc01854afca347a varLcl_OrderRequestFiles = RL_9d3b4c4e80b371ac0dc01854afca347a.FromRestList(variables.varLcl_OrderRequestFiles, ssConectaProveedores.RestRecords.RESTST_d9010d115c38fb059bccbc457fe11b18Structure.ToStructure);
bool varLcShowOrderReject_Popup = variables.varLcShowOrderReject_Popup == null ? false : variables.varLcShowOrderReject_Popup.Value;
string varLcDependentFoliosText = variables.varLcDependentFoliosText == null ? "Según los folios SAEC que cree el proveedor." : variables.varLcDependentFoliosText;
string varLcl_RequestDocsErrorMessage = variables.varLcl_RequestDocsErrorMessage == null ? "" : variables.varLcl_RequestDocsErrorMessage;
bool varLcl_IsValidReqDoc = variables.varLcl_IsValidReqDoc == null ? false : variables.varLcl_IsValidReqDoc.Value;
bool varLcl_CanUploadContract = variables.varLcl_CanUploadContract == null ? false : variables.varLcl_CanUploadContract.Value;
bool varLcl_IsSavingContractFile = variables.varLcl_IsSavingContractFile == null ? false : variables.varLcl_IsSavingContractFile.Value;
bool varLcl_IsMissingEstimEqualAgFiniquito = variables.varLcl_IsMissingEstimEqualAgFiniquito == null ? false : variables.varLcl_IsMissingEstimEqualAgFiniquito.Value;
AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> _ScreenDataSetGetInsuranceTypes = (variables.ScreenDataSetGetInsuranceTypes != null) ? variables.ScreenDataSetGetInsuranceTypes.FromJS((array) => {
return RL_32b3fec96f8ddbf444444f34b158e188.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_e16f126ae5f7407d32d4a429fb32ca9a.ToStructure);
}
) : null;
AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> _ScreenDataSetGetDepositTypes = (variables.ScreenDataSetGetDepositTypes != null) ? variables.ScreenDataSetGetDepositTypes.FromJS((array) => {
return RL_cda7ed93cc851adc2316965418c61e6f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a8c523bc4a14ce1cf905293530597bc7.ToStructure);
}
) : null;
AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> _ScreenDataSetGetPaymentWays = (variables.ScreenDataSetGetPaymentWays != null) ? variables.ScreenDataSetGetPaymentWays.FromJS((array) => {
return RL_d98dc7eec8c631266895b622203a6db3.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4a8ab393337b882018e44511f7ddbaa8.ToStructure);
}
) : null;
AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> _ScreenDataSetGetAccountingDataTypes = (variables.ScreenDataSetGetAccountingDataTypes != null) ? variables.ScreenDataSetGetAccountingDataTypes.FromJS((array) => {
return RL_d567d658fa66fc955f880e37985e7f35.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a222d17a2b10e551d257fa2f5892499c.ToStructure);
}
) : null;
AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> _ScreenDataSetGetBusinessValueCategories = (variables.ScreenDataSetGetBusinessValueCategories != null) ? variables.ScreenDataSetGetBusinessValueCategories.FromJS((array) => {
return RL_901339470d357e86e0df985d0e6489f6.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c8382e0b08ee9d5965e5aae5b17d6261.ToStructure);
}
) : null;
AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> _ScreenDataSetGetOrderMainItemsByOrderMainId = (variables.ScreenDataSetGetOrderMainItemsByOrderMainId != null) ? variables.ScreenDataSetGetOrderMainItemsByOrderMainId.FromJS((array) => {
return RL_663d4acde686fb13f7cb44965555ab7f.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_16678e1ac2e17d1b5db4a9a7f4681e64.ToStructure);
}
) : null;
AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> _ScreenDataSetGetAdvancedPaymentTypes = (variables.ScreenDataSetGetAdvancedPaymentTypes != null) ? variables.ScreenDataSetGetAdvancedPaymentTypes.FromJS((array) => {
return RL_0d443dd02abe633532f6b939b4573e00.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_ba5df53107d79696b2775256d21bdd62.ToStructure);
}
) : null;
AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> _ScreenDataSetGetBusinessValueSubcategoriesByCategoryId = (variables.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId != null) ? variables.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId.FromJS((array) => {
return RL_2d11b20156650990ba0f3131aaaad2ea.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_87a3063e6674014b4b345dce21ff4d84.ToStructure);
}
) : null;
AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> _ScreenDataSetGetInvoiceUsages = (variables.ScreenDataSetGetInvoiceUsages != null) ? variables.ScreenDataSetGetInvoiceUsages.FromJS((array) => {
return RL_1078cb2b44dad3e211c3325e839a4151.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2512cd3cc7f986e36b4d5edf290d4383.ToStructure);
}
) : null;
AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> _ScreenDataSetGetFrequencies = (variables.ScreenDataSetGetFrequencies != null) ? variables.ScreenDataSetGetFrequencies.FromJS((array) => {
return RL_86161aa08f9858d205ef72cffcb4919d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_f2c609d858f8411e75fbedee60c5dddf.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServices = (variables.ScreenDataSetGetProjectAssetServices != null) ? variables.ScreenDataSetGetProjectAssetServices.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> _ScreenDataSetGetRejectComment = (variables.ScreenDataSetGetRejectComment != null) ? variables.ScreenDataSetGetRejectComment.FromJS((array) => {
return RL_17d8289ea48572225dc9530a5725652a.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_cd61721ee82121e78e4055ba4deb1fa6.ToStructure);
}
) : null;
AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> _ScreenDataSetGetSupplierByRequisition = (variables.ScreenDataSetGetSupplierByRequisition != null) ? variables.ScreenDataSetGetSupplierByRequisition.FromJS((array) => {
return RL_d5c1b2482ff109e80580d8b5fb920193.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_4934ec74dc6a80637b84c0985f5b12ce.ToStructure);
}
) : null;
AggregateRecord<RL_0204de281fa136fb826199f876159fe4> _ScreenDataSetGetSpecialApprovals = (variables.ScreenDataSetGetSpecialApprovals != null) ? variables.ScreenDataSetGetSpecialApprovals.FromJS((array) => {
return RL_0204de281fa136fb826199f876159fe4.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_34acf11553964937c377a82c97a2edf5.ToStructure);
}
) : null;
AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> _ScreenDataSetGetPaymentTerms = (variables.ScreenDataSetGetPaymentTerms != null) ? variables.ScreenDataSetGetPaymentTerms.FromJS((array) => {
return RL_375b9dd8c8b0d6d7bccf4d550f48644d.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_5526bab1a99740bd870dde6a69ba3d9a.ToStructure);
}
) : null;
AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> _ScreenDataSetGetPaymentMethods = (variables.ScreenDataSetGetPaymentMethods != null) ? variables.ScreenDataSetGetPaymentMethods.FromJS((array) => {
return RL_0dcbcba642ca8b22e87f690d4de9d077.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_45208e184b912aa1623cdf19760e8e7e.ToStructure);
}
) : null;
AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> _ScreenDataSetGetOrderRetentionTypes = (variables.ScreenDataSetGetOrderRetentionTypes != null) ? variables.ScreenDataSetGetOrderRetentionTypes.FromJS((array) => {
return RL_d6a865b9451603b2b07820fedb283c87.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_59361fc2fe27e83d1af47e8e07392a42.ToStructure);
}
) : null;
AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> _ScreenDataSetGetCurrencies = (variables.ScreenDataSetGetCurrencies != null) ? variables.ScreenDataSetGetCurrencies.FromJS((array) => {
return RL_1353a59e0688582d82bbddc41b47193e.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_0468f02f35e6ccd6a092f321c5d8a88e.ToStructure);
}
) : null;
AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> _ScreenDataSetGetOrderMainById = (variables.ScreenDataSetGetOrderMainById != null) ? variables.ScreenDataSetGetOrderMainById.FromJS((array) => {
return RL_c5285652b7692ee7ff416f77dcd1fe1c.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_655f10514459daf453e41f31c05184fc.ToStructure);
}
) : null;
AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> _ScreenDataSetGetSpecialPostDeliveryAuthorizations = (variables.ScreenDataSetGetSpecialPostDeliveryAuthorizations != null) ? variables.ScreenDataSetGetSpecialPostDeliveryAuthorizations.FromJS((array) => {
return RL_9a84f0ca43f575461143a73bcb506dba.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_a18bcaa92353126e3b75741517eabbdb.ToStructure);
}
) : null;
AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> _ScreenDataSetGetProjectAssetServiceOtro = (variables.ScreenDataSetGetProjectAssetServiceOtro != null) ? variables.ScreenDataSetGetProjectAssetServiceOtro.FromJS((array) => {
return RL_39dc6f4415ce9196844d0ada601cc72b.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_1b08a2c1cecef1e3b3006a60b97fc68e.ToStructure);
}
) : null;
AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> _ScreenDataSetGetContractStatuses = (variables.ScreenDataSetGetContractStatuses != null) ? variables.ScreenDataSetGetContractStatuses.FromJS((array) => {
return RL_b597b6c7f7b0a874a3717792e87892bb.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_64894cdb6c46279b2d012a58a7771333.ToStructure);
}
) : null;
AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> _ScreenDataSetGetSuppliers = (variables.ScreenDataSetGetSuppliers != null) ? variables.ScreenDataSetGetSuppliers.FromJS((array) => {
return RL_f647e8c4990b814587d1a017e4c9dd44.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_c81aee5ce0504fe68694be6deb703b5e.ToStructure);
}
) : null;
AggregateRecord<RL_251acb2daece433ee402c9709ec88356> _ScreenDataSetGetPaymentOptions = (variables.ScreenDataSetGetPaymentOptions != null) ? variables.ScreenDataSetGetPaymentOptions.FromJS((array) => {
return RL_251acb2daece433ee402c9709ec88356.FromRestList(array, ssConectaProveedores.RestRecords.RESTRC_2813028c34d1b3ce080a3e2c9febe797.ToStructure);
}
) : null;
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Model _varLcGetPaymentTermSpecial = (variables.varLcGetPaymentTermSpecial != null) ? RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Outputs.ToModel(variables.varLcGetPaymentTermSpecial) : null;
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Model _varLcGetOrderContractData = (variables.varLcGetOrderContractData != null) ? RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Outputs.ToModel(variables.varLcGetOrderContractData) : null;
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Model _varLcGetOrderFilesList = (variables.varLcGetOrderFilesList != null) ? RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Outputs.ToModel(variables.varLcGetOrderFilesList) : null;
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Model _varLcGetAccountingData = (variables.varLcGetAccountingData != null) ? RESTConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Outputs.ToModel(variables.varLcGetAccountingData) : null;
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel screenModel = new ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel(inParami_OrderId, inParami_ForceRefresh, varLcl_CanEditForm, varLcFilesList, varLcl_FormIsValid, varLcl_OrderRequestFiles, varLcShowOrderReject_Popup, varLcDependentFoliosText, varLcl_RequestDocsErrorMessage, varLcl_IsValidReqDoc, varLcl_CanUploadContract, varLcl_IsSavingContractFile, varLcl_IsMissingEstimEqualAgFiniquito, _ScreenDataSetGetInsuranceTypes, _ScreenDataSetGetDepositTypes, _ScreenDataSetGetPaymentWays, _ScreenDataSetGetAccountingDataTypes, _ScreenDataSetGetBusinessValueCategories, _ScreenDataSetGetOrderMainItemsByOrderMainId, _ScreenDataSetGetAdvancedPaymentTypes, _ScreenDataSetGetBusinessValueSubcategoriesByCategoryId, _ScreenDataSetGetInvoiceUsages, _ScreenDataSetGetFrequencies, _ScreenDataSetGetProjectAssetServices, _ScreenDataSetGetRejectComment, _ScreenDataSetGetSupplierByRequisition, _ScreenDataSetGetSpecialApprovals, _ScreenDataSetGetPaymentTerms, _ScreenDataSetGetPaymentMethods, _ScreenDataSetGetOrderRetentionTypes, _ScreenDataSetGetCurrencies, _ScreenDataSetGetOrderMainById, _ScreenDataSetGetSpecialPostDeliveryAuthorizations, _ScreenDataSetGetProjectAssetServiceOtro, _ScreenDataSetGetContractStatuses, _ScreenDataSetGetSuppliers, _ScreenDataSetGetPaymentOptions, _varLcGetPaymentTermSpecial, _varLcGetOrderContractData, _varLcGetOrderFilesList, _varLcGetAccountingData, (clientVariables != null) ? clientVariables.ToModel() : null);
return screenModel;
}

}
