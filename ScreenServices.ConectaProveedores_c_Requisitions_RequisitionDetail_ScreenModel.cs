using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel).Namespace);

    public long inParami_RequisitionId;
public bool inParami_IsUploadInvoice;
public RL_7a479a555821b093171c5d3cd3382006 varLcl_AllFiles;
public string varLcl_Attached_Filename;
public byte[] varLcl_AttachedFile_BinaryData;
public bool varLcl_CanEditAccounting;
public bool varLcl_CanEditUserArea;
public bool varLcl_FormIsValid;
public bool varLcl_IsBusy;
public DateTime varLcl_RefreshSideBar;
public RL_88196b1a2e1928c27f6fa3b58c10c14d varLcl_RetentionPercentageList;
public RL_943f36694cec370c0ce0c406bfa23715 varLcl_SelectedCostCentersList;
public bool varLcl_ShowCancelPopup;
public bool varLcl_ShowModifyPopup;
public DateTime varLcl_OriginalDateOfCommitment;
public bool varLcl_ShowSavePendingInfoBtn;
public DateTime varLcl_RefreshRequisitionEntra_Historic;
public bool varLcl_ShowHideSelectReqRegion_Popup;
public long varLcl_RegionId;
public bool varLcl_ShowAssignFirstApproverPopup;
public string varLcl_SelectedAccount;
public string varLcProjectAssetSearchText;
public int varLcProjectAssetMaxRecord;
public bool varLcl_ShowHideSpecialOrNormalWorkflow;
public bool varLcl_NotValid;
public bool varLcl_NotValidPaymentsValue;
public bool varLcl_NotValidContractValue;
public bool varLcl_CanSeeAdvanceWithOrWithoutInvoice;
public bool varLcl_IsToExitCapture;
public bool varLcl_DropdownSupplierValid;
public bool varLcl_AllowActions;
public long varLcl_PreviousSelectedCostCenter;
public AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies;
public AggregateRecord<RL_52a3075ea09fce1b2b3cbeb7d74742be> ScreenDataSetGetUserById;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations;
public AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays;
public AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes;
public AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters;
public AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ScreenDataSetGetDocumentTypeAnticipoKW;
public AggregateRecord<RL_369f9983c2b36180025202f97bb71651> ScreenDataSetGetAccountableGuide;
public AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes;
public AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ScreenDataSetGetSupplierSocieties;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetByRequisition;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions;
public AggregateRecord<RL_c861661ffef6a96c498651ed1efeee53> ScreenDataSetGetSustainabilities;
public AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages;
public AggregateRecord<RL_40d1dae5da886b385f88ea5c5c7574ca> ScreenDataSetGetCostCenterSAPByRequisitionId;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro;
public AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWay99;
public AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes;
public AggregateRecord<RL_2ce058321dad3f60357fc3b3372ccb1e> ScreenDataSetGetServiceFormats;
public AggregateRecord<RL_63e875add2b98c15e5030850edd3b2eb> ScreenDataSetGetDistributions;
public AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories;
public AggregateRecord<RL_b47d9310671b1b627f451a333bb8980a> ScreenDataSetGetRequisitionServicesByRequisitionId;
public AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
public AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole;
public AggregateRecord<RL_a3213f63c9dee3312d82d37ec604d349> ScreenDataSetGetRequisitionCostCentersByRequisitionId;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition;
public AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ScreenDataSetGetDocumentTypeKR;
public AggregateRecord<RL_10b798eceef0c61e2eb85d7fd35e40d6> ScreenDataSetGetSupplierDetailBySociety;
public AggregateRecord<RL_db407242f011e8b84a110f6970108663> ScreenDataSetGetRequisitionById;
public AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Model varLcGetRequisitionContractData;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Model varLcGetShowSelectReqPopup;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Model varLcGetAdvWithoutInvoiceData;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Model varLcGetConfiguration;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Model varLcGetAccountingData;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model varLcGetShowIsDonation;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Model varLcGetRequisitionFiles;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model varLcGetPaymentMethodsBySupplierId;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel(long inParami_RequisitionId, bool inParami_IsUploadInvoice, RL_7a479a555821b093171c5d3cd3382006 varLcl_AllFiles, string varLcl_Attached_Filename, byte[] varLcl_AttachedFile_BinaryData, bool varLcl_CanEditAccounting, bool varLcl_CanEditUserArea, bool varLcl_FormIsValid, bool varLcl_IsBusy, DateTime varLcl_RefreshSideBar, RL_88196b1a2e1928c27f6fa3b58c10c14d varLcl_RetentionPercentageList, RL_943f36694cec370c0ce0c406bfa23715 varLcl_SelectedCostCentersList, bool varLcl_ShowCancelPopup, bool varLcl_ShowModifyPopup, DateTime varLcl_OriginalDateOfCommitment, bool varLcl_ShowSavePendingInfoBtn, DateTime varLcl_RefreshRequisitionEntra_Historic, bool varLcl_ShowHideSelectReqRegion_Popup, long varLcl_RegionId, bool varLcl_ShowAssignFirstApproverPopup, string varLcl_SelectedAccount, string varLcProjectAssetSearchText, int varLcProjectAssetMaxRecord, bool varLcl_ShowHideSpecialOrNormalWorkflow, bool varLcl_NotValid, bool varLcl_NotValidPaymentsValue, bool varLcl_NotValidContractValue, bool varLcl_CanSeeAdvanceWithOrWithoutInvoice, bool varLcl_IsToExitCapture, bool varLcl_DropdownSupplierValid, bool varLcl_AllowActions, long varLcl_PreviousSelectedCostCenter, AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies, AggregateRecord<RL_52a3075ea09fce1b2b3cbeb7d74742be> ScreenDataSetGetUserById, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations, AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays, AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes, AggregateRecord<RL_ec55ed22dae89075d036f3a863173164> ScreenDataSetGetCostCenters, AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ScreenDataSetGetDocumentTypeAnticipoKW, AggregateRecord<RL_369f9983c2b36180025202f97bb71651> ScreenDataSetGetAccountableGuide, AggregateRecord<RL_60b4efe2937800b54618ed04c4847a05> ScreenDataSetGetAccountingAccountsServiceTypes, AggregateRecord<RL_3c0fa01b89994c3e2eaed82b259c3f66> ScreenDataSetGetSupplierSocieties, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetByRequisition, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions, AggregateRecord<RL_c861661ffef6a96c498651ed1efeee53> ScreenDataSetGetSustainabilities, AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages, AggregateRecord<RL_40d1dae5da886b385f88ea5c5c7574ca> ScreenDataSetGetCostCenterSAPByRequisitionId, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro, AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWay99, AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes, AggregateRecord<RL_2ce058321dad3f60357fc3b3372ccb1e> ScreenDataSetGetServiceFormats, AggregateRecord<RL_63e875add2b98c15e5030850edd3b2eb> ScreenDataSetGetDistributions, AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories, AggregateRecord<RL_b47d9310671b1b627f451a333bb8980a> ScreenDataSetGetRequisitionServicesByRequisitionId, AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId, AggregateRecord<RL_ea7d18baeeefa57d5c86706d7efb98e9> ScreenDataSetGetEntraRole, AggregateRecord<RL_a3213f63c9dee3312d82d37ec604d349> ScreenDataSetGetRequisitionCostCentersByRequisitionId, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition, AggregateRecord<RL_f2d249f675a5073e98f93433009d7ad4> ScreenDataSetGetDocumentTypeKR, AggregateRecord<RL_10b798eceef0c61e2eb85d7fd35e40d6> ScreenDataSetGetSupplierDetailBySociety, AggregateRecord<RL_db407242f011e8b84a110f6970108663> ScreenDataSetGetRequisitionById, AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionContractData_Model varLcGetRequisitionContractData, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowSelectReqPopup_Model varLcGetShowSelectReqPopup, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAdvWithoutInvoiceData_Model varLcGetAdvWithoutInvoiceData, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetConfiguration_Model varLcGetConfiguration, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetAccountingData_Model varLcGetAccountingData, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetShowIsDonation_Model varLcGetShowIsDonation, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetRequisitionFiles_Model varLcGetRequisitionFiles, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_c_Requisitions_RequisitionDetail_DataActionGetPaymentMethodsBySupplierId_Model varLcGetPaymentMethodsBySupplierId, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_RequisitionId", "i_IsUploadInvoice", "l_AllFiles", "l_Attached_Filename", "l_AttachedFile_BinaryData", "l_CanEditAccounting", "l_CanEditUserArea", "l_FormIsValid", "l_IsBusy", "l_RefreshSideBar", "l_RetentionPercentageList", "l_SelectedCostCentersList", "l_ShowCancelPopup", "l_ShowModifyPopup", "l_OriginalDateOfCommitment", "l_ShowSavePendingInfoBtn", "l_RefreshRequisitionEntra_Historic", "l_ShowHideSelectReqRegion_Popup", "l_RegionId", "l_ShowAssignFirstApproverPopup", "l_SelectedAccount", "ProjectAssetSearchText", "ProjectAssetMaxRecord", "l_ShowHideSpecialOrNormalWorkflow", "l_NotValid", "l_NotValidPaymentsValue", "l_NotValidContractValue", "l_CanSeeAdvanceWithOrWithoutInvoice", "l_IsToExitCapture", "l_DropdownSupplierValid", "l_AllowActions", "l_PreviousSelectedCostCenter", "GetFrequencies", "GetUserById", "GetPaymentTerms", "GetSpecialPostDeliveryAuthorizations", "GetPaymentWays", "GetAdvancedPaymentTypes", "GetProjectAssetServices", "GetInsuranceTypes", "GetCostCenters", "GetDocumentTypeAnticipoKW", "GetAccountableGuide", "GetAccountingAccountsServiceTypes", "GetSupplierSocieties", "GetProjectAssetByRequisition", "GetCurrencies", "GetPaymentOptions", "GetSustainabilities", "GetInvoiceUsages", "GetCostCenterSAPByRequisitionId", "GetProjectAssetServiceOtro", "GetPaymentWay99", "GetAccountingDataTypes", "GetServiceFormats", "GetDistributions", "GetBusinessValueCategories", "GetRequisitionServicesByRequisitionId", "GetBusinessValueSubcategoriesByCategoryId", "GetEntraRole", "GetRequisitionCostCentersByRequisitionId", "GetSupplierByRequisition", "GetDocumentTypeKR", "GetSupplierDetailBySociety", "GetRequisitionById", "GetDepositTypes", "GetRequisitionContractData", "GetShowSelectReqPopup", "GetAdvWithoutInvoiceData", "GetConfiguration", "GetAccountingData", "GetShowIsDonation", "GetSettings", "GetRequisitionFiles", "GetUserApplicationRoles", "GetPaymentMethodsBySupplierId", "ClientVars"}, new string[] {"inParami_RequisitionId", "inParami_IsUploadInvoice", "varLcl_AllFiles", "varLcl_Attached_Filename", "varLcl_AttachedFile_BinaryData", "varLcl_CanEditAccounting", "varLcl_CanEditUserArea", "varLcl_FormIsValid", "varLcl_IsBusy", "varLcl_RefreshSideBar", "varLcl_RetentionPercentageList", "varLcl_SelectedCostCentersList", "varLcl_ShowCancelPopup", "varLcl_ShowModifyPopup", "varLcl_OriginalDateOfCommitment", "varLcl_ShowSavePendingInfoBtn", "varLcl_RefreshRequisitionEntra_Historic", "varLcl_ShowHideSelectReqRegion_Popup", "varLcl_RegionId", "varLcl_ShowAssignFirstApproverPopup", "varLcl_SelectedAccount", "varLcProjectAssetSearchText", "varLcProjectAssetMaxRecord", "varLcl_ShowHideSpecialOrNormalWorkflow", "varLcl_NotValid", "varLcl_NotValidPaymentsValue", "varLcl_NotValidContractValue", "varLcl_CanSeeAdvanceWithOrWithoutInvoice", "varLcl_IsToExitCapture", "varLcl_DropdownSupplierValid", "varLcl_AllowActions", "varLcl_PreviousSelectedCostCenter", "ScreenDataSetGetFrequencies", "ScreenDataSetGetUserById", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetSpecialPostDeliveryAuthorizations", "ScreenDataSetGetPaymentWays", "ScreenDataSetGetAdvancedPaymentTypes", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetInsuranceTypes", "ScreenDataSetGetCostCenters", "ScreenDataSetGetDocumentTypeAnticipoKW", "ScreenDataSetGetAccountableGuide", "ScreenDataSetGetAccountingAccountsServiceTypes", "ScreenDataSetGetSupplierSocieties", "ScreenDataSetGetProjectAssetByRequisition", "ScreenDataSetGetCurrencies", "ScreenDataSetGetPaymentOptions", "ScreenDataSetGetSustainabilities", "ScreenDataSetGetInvoiceUsages", "ScreenDataSetGetCostCenterSAPByRequisitionId", "ScreenDataSetGetProjectAssetServiceOtro", "ScreenDataSetGetPaymentWay99", "ScreenDataSetGetAccountingDataTypes", "ScreenDataSetGetServiceFormats", "ScreenDataSetGetDistributions", "ScreenDataSetGetBusinessValueCategories", "ScreenDataSetGetRequisitionServicesByRequisitionId", "ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "ScreenDataSetGetEntraRole", "ScreenDataSetGetRequisitionCostCentersByRequisitionId", "ScreenDataSetGetSupplierByRequisition", "ScreenDataSetGetDocumentTypeKR", "ScreenDataSetGetSupplierDetailBySociety", "ScreenDataSetGetRequisitionById", "ScreenDataSetGetDepositTypes", "varLcGetRequisitionContractData", "varLcGetShowSelectReqPopup", "varLcGetAdvWithoutInvoiceData", "varLcGetConfiguration", "varLcGetAccountingData", "varLcGetShowIsDonation", "varLcGetSettings", "varLcGetRequisitionFiles", "varLcGetUserApplicationRoles", "varLcGetPaymentMethodsBySupplierId", "clientVariables"});
this.inParami_RequisitionId = inParami_RequisitionId;
this.inParami_IsUploadInvoice = inParami_IsUploadInvoice;
this.varLcl_AllFiles = varLcl_AllFiles;
this.varLcl_Attached_Filename = varLcl_Attached_Filename;
this.varLcl_AttachedFile_BinaryData = varLcl_AttachedFile_BinaryData;
this.varLcl_CanEditAccounting = varLcl_CanEditAccounting;
this.varLcl_CanEditUserArea = varLcl_CanEditUserArea;
this.varLcl_FormIsValid = varLcl_FormIsValid;
this.varLcl_IsBusy = varLcl_IsBusy;
this.varLcl_RefreshSideBar = varLcl_RefreshSideBar;
this.varLcl_RetentionPercentageList = varLcl_RetentionPercentageList;
this.varLcl_SelectedCostCentersList = varLcl_SelectedCostCentersList;
this.varLcl_ShowCancelPopup = varLcl_ShowCancelPopup;
this.varLcl_ShowModifyPopup = varLcl_ShowModifyPopup;
this.varLcl_OriginalDateOfCommitment = varLcl_OriginalDateOfCommitment;
this.varLcl_ShowSavePendingInfoBtn = varLcl_ShowSavePendingInfoBtn;
this.varLcl_RefreshRequisitionEntra_Historic = varLcl_RefreshRequisitionEntra_Historic;
this.varLcl_ShowHideSelectReqRegion_Popup = varLcl_ShowHideSelectReqRegion_Popup;
this.varLcl_RegionId = varLcl_RegionId;
this.varLcl_ShowAssignFirstApproverPopup = varLcl_ShowAssignFirstApproverPopup;
this.varLcl_SelectedAccount = varLcl_SelectedAccount;
this.varLcProjectAssetSearchText = varLcProjectAssetSearchText;
this.varLcProjectAssetMaxRecord = varLcProjectAssetMaxRecord;
this.varLcl_ShowHideSpecialOrNormalWorkflow = varLcl_ShowHideSpecialOrNormalWorkflow;
this.varLcl_NotValid = varLcl_NotValid;
this.varLcl_NotValidPaymentsValue = varLcl_NotValidPaymentsValue;
this.varLcl_NotValidContractValue = varLcl_NotValidContractValue;
this.varLcl_CanSeeAdvanceWithOrWithoutInvoice = varLcl_CanSeeAdvanceWithOrWithoutInvoice;
this.varLcl_IsToExitCapture = varLcl_IsToExitCapture;
this.varLcl_DropdownSupplierValid = varLcl_DropdownSupplierValid;
this.varLcl_AllowActions = varLcl_AllowActions;
this.varLcl_PreviousSelectedCostCenter = varLcl_PreviousSelectedCostCenter;
this.ScreenDataSetGetFrequencies = ScreenDataSetGetFrequencies;
this.ScreenDataSetGetUserById = ScreenDataSetGetUserById;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetSpecialPostDeliveryAuthorizations = ScreenDataSetGetSpecialPostDeliveryAuthorizations;
this.ScreenDataSetGetPaymentWays = ScreenDataSetGetPaymentWays;
this.ScreenDataSetGetAdvancedPaymentTypes = ScreenDataSetGetAdvancedPaymentTypes;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetInsuranceTypes = ScreenDataSetGetInsuranceTypes;
this.ScreenDataSetGetCostCenters = ScreenDataSetGetCostCenters;
this.ScreenDataSetGetDocumentTypeAnticipoKW = ScreenDataSetGetDocumentTypeAnticipoKW;
this.ScreenDataSetGetAccountableGuide = ScreenDataSetGetAccountableGuide;
this.ScreenDataSetGetAccountingAccountsServiceTypes = ScreenDataSetGetAccountingAccountsServiceTypes;
this.ScreenDataSetGetSupplierSocieties = ScreenDataSetGetSupplierSocieties;
this.ScreenDataSetGetProjectAssetByRequisition = ScreenDataSetGetProjectAssetByRequisition;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetPaymentOptions = ScreenDataSetGetPaymentOptions;
this.ScreenDataSetGetSustainabilities = ScreenDataSetGetSustainabilities;
this.ScreenDataSetGetInvoiceUsages = ScreenDataSetGetInvoiceUsages;
this.ScreenDataSetGetCostCenterSAPByRequisitionId = ScreenDataSetGetCostCenterSAPByRequisitionId;
this.ScreenDataSetGetProjectAssetServiceOtro = ScreenDataSetGetProjectAssetServiceOtro;
this.ScreenDataSetGetPaymentWay99 = ScreenDataSetGetPaymentWay99;
this.ScreenDataSetGetAccountingDataTypes = ScreenDataSetGetAccountingDataTypes;
this.ScreenDataSetGetServiceFormats = ScreenDataSetGetServiceFormats;
this.ScreenDataSetGetDistributions = ScreenDataSetGetDistributions;
this.ScreenDataSetGetBusinessValueCategories = ScreenDataSetGetBusinessValueCategories;
this.ScreenDataSetGetRequisitionServicesByRequisitionId = ScreenDataSetGetRequisitionServicesByRequisitionId;
this.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId = ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
this.ScreenDataSetGetEntraRole = ScreenDataSetGetEntraRole;
this.ScreenDataSetGetRequisitionCostCentersByRequisitionId = ScreenDataSetGetRequisitionCostCentersByRequisitionId;
this.ScreenDataSetGetSupplierByRequisition = ScreenDataSetGetSupplierByRequisition;
this.ScreenDataSetGetDocumentTypeKR = ScreenDataSetGetDocumentTypeKR;
this.ScreenDataSetGetSupplierDetailBySociety = ScreenDataSetGetSupplierDetailBySociety;
this.ScreenDataSetGetRequisitionById = ScreenDataSetGetRequisitionById;
this.ScreenDataSetGetDepositTypes = ScreenDataSetGetDepositTypes;
this.varLcGetRequisitionContractData = varLcGetRequisitionContractData;
this.varLcGetShowSelectReqPopup = varLcGetShowSelectReqPopup;
this.varLcGetAdvWithoutInvoiceData = varLcGetAdvWithoutInvoiceData;
this.varLcGetConfiguration = varLcGetConfiguration;
this.varLcGetAccountingData = varLcGetAccountingData;
this.varLcGetShowIsDonation = varLcGetShowIsDonation;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetRequisitionFiles = varLcGetRequisitionFiles;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.varLcGetPaymentMethodsBySupplierId = varLcGetPaymentMethodsBySupplierId;
this.clientVariables = clientVariables;
}



    
// Query Function "GetFrequencies" o2ftBsusfUus3zibikhnog of Action "RequisitionDetail"
public static async Task<(RL_86161aa08f9858d205ef72cffcb4919d,long)> datasetGetFrequencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetFrequencies", "06ed67a3-accb-4b7d-acdf-389b8a4867a2");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetFrequencies");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.o2ftBsusfUus3zibikhnog, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfrequency7\".\"id\" o0, \"enfrequency7\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Frequency} \"enfrequency7\"");
whereBuilder.Append(" WHERE (\"enfrequency7\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"enfrequency7\".\"order\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_86161aa08f9858d205ef72cffcb4919d outParamList = new RL_86161aa08f9858d205ef72cffcb4919d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetFrequencies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_86161aa08f9858d205ef72cffcb4919d _tmp = new RL_86161aa08f9858d205ef72cffcb4919d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetFrequencies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_86161aa08f9858d205ef72cffcb4919d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_21a885f0bb9cdabb4dd12f34282bebba> datasetGetUserByIdReadDbAsync(RC_21a885f0bb9cdabb4dd12f34282bebba rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENDepartment.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetUserById" l8u3GhKhx0ahvU54eEh+Sg of Action "RequisitionDetail"
public static async Task<(RL_52a3075ea09fce1b2b3cbeb7d74742be,long)> datasetGetUserById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,string qpusUser_Id,string qpusUser_Id1,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetUserById", "1ab7cb97-a112-46c7-a1bd-4e7878487e4a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetUserById");
// Query Iterations: Never
// Refresh Query _GuzxVmsTUOyNiDl+YMLJg Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.l8u3GhKhx0ahvU54eEh+Sg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"endepartment10\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enregion144\".\"name\" o9, NULL o10, \"enregion144\".\"centrortp\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser184\".\"name\" o21, \"enuser184\".\"email\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal113\" Inner JOIN {Department} \"endepartment10\" ON (\"enuser_extended_internal113\".\"departmentid\" = \"endepartment10\".\"id\"))  Inner JOIN {Region} \"enregion144\" ON (\"enuser_extended_internal113\".\"regionid\" = \"enregion144\".\"id\"))  Right JOIN {User} \"enuser184\" ON (\"enuser184\".\"id\" = \"enuser_extended_internal113\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpusUser_Id = '') THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
if ((qpusUser_Id1.Trim()!="")) {
whereBuilder.Append("((\"enuser184\".\"id\" = @qpusUser_Id1) AND (\"enuser184\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id1", DbType.String, qpusUser_Id1);
} else {
whereBuilder.Append("(\"enuser184\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser184\".\"id\" = @qpusUser_Id) AND (\"enuser184\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser184\".\"id\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1) AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_52a3075ea09fce1b2b3cbeb7d74742be outParamList = new RL_52a3075ea09fce1b2b3cbeb7d74742be();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, false, true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetUserById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_52a3075ea09fce1b2b3cbeb7d74742be _tmp = new RL_52a3075ea09fce1b2b3cbeb7d74742be();
_tmp.AlternateReadDbMethodAsync = datasetGetUserByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetUserById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_52a3075ea09fce1b2b3cbeb7d74742be)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentTerms" wZh8Hn0J8kWdnl0Kyh7evA of Action "RequisitionDetail"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetPaymentTerms", "1e7c98c1-097d-45f2-9d9e-5d0aca1edebc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetPaymentTerms");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.wZh8Hn0J8kWdnl0Kyh7evA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms30\".\"id\" o0, \"enpaymentterms30\".\"description\" o1, NULL o2, NULL o3, NULL o4, \"enpaymentterms30\".\"estructuradescripcionprop\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms30\"");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_375b9dd8c8b0d6d7bccf4d550f48644d outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetPaymentTerms.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_375b9dd8c8b0d6d7bccf4d550f48644d _tmp = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetPaymentTerms.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_375b9dd8c8b0d6d7bccf4d550f48644d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetSpecialPostDeliveryAuthorizations" DLFLLR7bB0uopdfd2y1phQ of Action "RequisitionDetail"
public static async Task<(RL_9a84f0ca43f575461143a73bcb506dba,long)> datasetGetSpecialPostDeliveryAuthorizations(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetSpecialPostDeliveryAuthorizations", "2d4bb10c-db1e-4b07-a8a5-d7dddb2d6985");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetSpecialPostDeliveryAuthorizations");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.DLFLLR7bB0uopdfd2y1phQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialpostdeliveryauthorization2\".\"id\" o0, \"enspecialpostdeliveryauthorization2\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialPostDeliveryAuthorization} \"enspecialpostdeliveryauthorization2\"");
whereBuilder.Append(" WHERE (\"enspecialpostdeliveryauthorization2\".\"is_active\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_9a84f0ca43f575461143a73bcb506dba outParamList = new RL_9a84f0ca43f575461143a73bcb506dba();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9a84f0ca43f575461143a73bcb506dba _tmp = new RL_9a84f0ca43f575461143a73bcb506dba();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9a84f0ca43f575461143a73bcb506dba)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentWays" ek2gOQtux0C9xzgUtIpuqQ of Action "RequisitionDetail"
public static async Task<(RL_d98dc7eec8c631266895b622203a6db3,long)> datasetGetPaymentWays(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetPaymentWays", "39a04d7a-6e0b-40c7-bdc7-3814b48a6ea9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetPaymentWays");
// Query Iterations: Multiple
// Refresh Query IT_iwCxOtUWw+JZcByqnNg Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.ek2gOQtux0C9xzgUtIpuqQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentways4\".\"id\" o0, NULL o1, \"enpaymentways4\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentWays} \"enpaymentways4\"");
whereBuilder.Append(" WHERE ((\"enpaymentways4\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentways4\".\"id\" = @qppaId) AND (\"enpaymentways4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentways4\".\"id\" IS NULL)");
}
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d98dc7eec8c631266895b622203a6db3 outParamList = new RL_d98dc7eec8c631266895b622203a6db3();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetPaymentWays.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d98dc7eec8c631266895b622203a6db3 _tmp = new RL_d98dc7eec8c631266895b622203a6db3();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetPaymentWays.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d98dc7eec8c631266895b622203a6db3)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetAdvancedPaymentTypes" Paq_PERsKUGHzjwjzF+F3g of Action "RequisitionDetail"
public static async Task<(RL_0d443dd02abe633532f6b939b4573e00,long)> datasetGetAdvancedPaymentTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetAdvancedPaymentTypes", "3cbfaa3d-6c44-4129-87ce-3c23cc5f85de");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetAdvancedPaymentTypes");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Paq_PERsKUGHzjwjzF+F3g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enadvancepaymenttype5\".\"id\" o0, \"enadvancepaymenttype5\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {AdvancePaymentType} \"enadvancepaymenttype5\"");
whereBuilder.Append(" WHERE (\"enadvancepaymenttype5\".\"is_active\" = 1) AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0d443dd02abe633532f6b939b4573e00 outParamList = new RL_0d443dd02abe633532f6b939b4573e00();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0d443dd02abe633532f6b939b4573e00 _tmp = new RL_0d443dd02abe633532f6b939b4573e00();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0d443dd02abe633532f6b939b4573e00)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetProjectAssetServices" Vvr7Qnr4a0qxXjAEcVxoWA of Action "RequisitionDetail"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteProjectAssetSearchText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetProjectAssetServices", "42fbfa56-f87a-4a6b-b15e-3004715c6858");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetProjectAssetServices");
// Query Iterations: Multiple
// Refresh Query s6HNVCIIiUStd2MZKm6+Aw Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Vvr7Qnr4a0qxXjAEcVxoWA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service20\".\"id\" o0, \"enproject_asset_service20\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service20\"");
if (qpteProjectAssetSearchText != "") {
whereBuilder.Append(" WHERE ");
if (qpteProjectAssetSearchText != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproject_asset_service20\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qpteProjectAssetSearchText) || '%') collate \"default\"))");
sqlCmd.CreateParameterWithoutReplacements("@qpteProjectAssetSearchText", DbType.String, qpteProjectAssetSearchText);
}
}
orderByBuilder.Append(" ORDER BY \"enproject_asset_service20\".\"isothers\" ASC , \"enproject_asset_service20\".\"description\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_39dc6f4415ce9196844d0ada601cc72b outParamList = new RL_39dc6f4415ce9196844d0ada601cc72b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dc6f4415ce9196844d0ada601cc72b _tmp = new RL_39dc6f4415ce9196844d0ada601cc72b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetProjectAssetServices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dc6f4415ce9196844d0ada601cc72b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetInsuranceTypes" +Wp2RrlfoUudGUtgO4NV7A of Action "RequisitionDetail"
public static async Task<(RL_32b3fec96f8ddbf444444f34b158e188,long)> datasetGetInsuranceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetInsuranceTypes", "46766af9-5fb9-4ba1-9d19-4b603b8355ec");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetInsuranceTypes");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.+Wp2RrlfoUudGUtgO4NV7A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninsurancetype2\".\"id\" o0, \"eninsurancetype2\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {InsuranceType} \"eninsurancetype2\"");
whereBuilder.Append(" WHERE (\"eninsurancetype2\".\"is_active\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_32b3fec96f8ddbf444444f34b158e188 outParamList = new RL_32b3fec96f8ddbf444444f34b158e188();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetInsuranceTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_32b3fec96f8ddbf444444f34b158e188 _tmp = new RL_32b3fec96f8ddbf444444f34b158e188();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetInsuranceTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_32b3fec96f8ddbf444444f34b158e188)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetCostCenters" +pJ9R3qq1EaykAH4etSTxw of Action "RequisitionDetail"
public static async Task<(RL_ec55ed22dae89075d036f3a863173164,long)> datasetGetCostCenters(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpcoCompanyId,long qpreRegionId,long qpcoId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetCostCenters", "477d92fa-aa7a-46d4-b290-01f87ad493c7");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetCostCenters");
// Query Iterations: Multiple
// Refresh Query xq4RnJZMkkmYw6k_4ItMoQ Iterations: Multiple
// Refresh Query 08hAEIVB8U29Yl0MI9g4Rw Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.+pJ9R3qq1EaykAH4etSTxw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encostcentersap17\".\"id\" o0, NULL o1, NULL o2, NULL o3, \"encostcentersap17\".\"div_\" o4, NULL o5, \"encostcentersap17\".\"ce_coste\" o6, \"encostcentersap17\".\"cebe\" o7, \"encostcentersap17\".\"denominacion\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM {CostCenterSAP} \"encostcentersap17\"");
whereBuilder.Append(" WHERE ");
if (qpreRegionId != 0) {
whereBuilder.Append("((\"encostcentersap17\".\"regionid\" = @qpreRegionId) AND (\"encostcentersap17\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegionId", DbType.Int64, qpreRegionId);
} else {
whereBuilder.Append("(\"encostcentersap17\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpcoCompanyId != 0) {
whereBuilder.Append("((\"encostcentersap17\".\"companyid\" = @qpcoCompanyId) AND (\"encostcentersap17\".\"companyid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoCompanyId", DbType.Int64, qpcoCompanyId);
} else {
whereBuilder.Append("(\"encostcentersap17\".\"companyid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"encostcentersap17\".\"isactive\" = 1) OR ");
if (qpcoId != 0) {
whereBuilder.Append("((\"encostcentersap17\".\"id\" = @qpcoId) AND (\"encostcentersap17\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoId", DbType.Int64, qpcoId);
} else {
whereBuilder.Append("(\"encostcentersap17\".\"id\" IS NULL)");
}
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ec55ed22dae89075d036f3a863173164 outParamList = new RL_ec55ed22dae89075d036f3a863173164();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, false, true, false, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetCostCenters.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ec55ed22dae89075d036f3a863173164 _tmp = new RL_ec55ed22dae89075d036f3a863173164();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetCostCenters.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ec55ed22dae89075d036f3a863173164)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetDocumentTypeAnticipoKW" DvY4ULck5UOmxLYmUX7Hlg of Action "RequisitionDetail"
public static async Task<(RL_f2d249f675a5073e98f93433009d7ad4,long)> datasetGetDocumentTypeAnticipoKW(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetDocumentTypeAnticipoKW", "5038f60e-24b7-43e5-a6c4-b626517ec796");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetDocumentTypeAnticipoKW");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.DvY4ULck5UOmxLYmUX7Hlg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endocumenttype2\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {DocumentType} \"endocumenttype2\"");
whereBuilder.Append(" WHERE (\"endocumenttype2\".\"classe\" = 'KW')");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_f2d249f675a5073e98f93433009d7ad4 outParamList = new RL_f2d249f675a5073e98f93433009d7ad4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetDocumentTypeAnticipoKW.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f2d249f675a5073e98f93433009d7ad4 _tmp = new RL_f2d249f675a5073e98f93433009d7ad4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetDocumentTypeAnticipoKW.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f2d249f675a5073e98f93433009d7ad4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetAccountableGuide" _1BPXSLMcEaDDn2JISeqfw of Action "RequisitionDetail"
public static async Task<(RL_369f9983c2b36180025202f97bb71651,long)> datasetGetAccountableGuide(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProject_Asset_ServiceId,long qpsuSupplierId,string qpteAccount,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountableGuide", "5d4f50ff-cc22-4670-830e-7d892127aa7f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetAccountableGuide");
// Query Iterations: Never
// Refresh Query gbdu34QP106+N2MOXfkHCA Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets._1BPXSLMcEaDDn2JISeqfw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enaccountableguide\".\"costcentersapid\" o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {AccountableGuide} \"enaccountableguide\"");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierId != 0) {
whereBuilder.Append("((\"enaccountableguide\".\"supplierid\" = @qpsuSupplierId) AND (\"enaccountableguide\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
} else {
whereBuilder.Append("(\"enaccountableguide\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpprProject_Asset_ServiceId != 0) {
whereBuilder.Append("((\"enaccountableguide\".\"project_asset_serviceid\" = @qpprProject_Asset_ServiceId) AND (\"enaccountableguide\".\"project_asset_serviceid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProject_Asset_ServiceId", DbType.Int64, qpprProject_Asset_ServiceId);
} else {
whereBuilder.Append("(\"enaccountableguide\".\"project_asset_serviceid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enaccountableguide\".\"account\" = @qpteAccount)");
sqlCmd.CreateParameterWithoutReplacements("@qpteAccount", DbType.String, qpteAccount);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_369f9983c2b36180025202f97bb71651 outParamList = new RL_369f9983c2b36180025202f97bb71651();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountableGuide.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_369f9983c2b36180025202f97bb71651 _tmp = new RL_369f9983c2b36180025202f97bb71651();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountableGuide.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_369f9983c2b36180025202f97bb71651)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetAccountingAccountsServiceTypes" obbIX3IN6keHv0UBMghUtg of Action "RequisitionDetail"
public static async Task<(RL_60b4efe2937800b54618ed04c4847a05,long)> datasetGetAccountingAccountsServiceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingAccountsServiceTypes", "5fc8b6a1-0d72-47ea-87bf-4501320854b6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetAccountingAccountsServiceTypes");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.obbIX3IN6keHv0UBMghUtg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingaccounts_servicetype13\".\"id\" o0, \"enaccountingaccounts_servicetype13\".\"cc\" o1, \"enaccountingaccounts_servicetype13\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype13\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND (\"enaccountingaccounts_servicetype13\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"enaccountingaccounts_servicetype13\".\"description\" ASC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_60b4efe2937800b54618ed04c4847a05 outParamList = new RL_60b4efe2937800b54618ed04c4847a05();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_60b4efe2937800b54618ed04c4847a05 _tmp = new RL_60b4efe2937800b54618ed04c4847a05();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingAccountsServiceTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_60b4efe2937800b54618ed04c4847a05)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_5df7bb5aa64fe06d5d087faa4a2fd561> datasetGetSupplierSocietiesReadDbAsync(RC_5df7bb5aa64fe06d5d087faa4a2fd561 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENSupplierDetail.Read( r, ref index);
return rec;
}
// Query Function "GetSupplierSocieties" Zc4AZrikE0WboKdG+iVvBA of Action "RequisitionDetail"
public static async Task<(RL_3c0fa01b89994c3e2eaed82b259c3f66,long)> datasetGetSupplierSocieties(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuSupplierDetail_SupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetSupplierSocieties", "6600ce65-a4b8-4513-9ba0-a746fa256f04");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetSupplierSocieties");
// Query Iterations: Multiple
// Refresh Query nB5M61V5mEqa5Rr94rkvyw Iterations: Multiple
// Refresh Query qs1hZyA+e0uqtdd3WSpA4g Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Zc4AZrikE0WboKdG+iVvBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encompany50\".\"id\" o0, \"encompany50\".\"externalid\" o1, \"encompany50\".\"description\" o2, \"encompany50\".\"rfc\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36");
fromBuilder.Append(" FROM ({SupplierDetail} \"ensupplierdetail6\" Left JOIN {Company} \"encompany50\" ON (\"ensupplierdetail6\".\"sociedadeid\" = \"encompany50\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierDetail_SupplierId != 0) {
whereBuilder.Append("((\"ensupplierdetail6\".\"supplierid\" = @qpsuSupplierDetail_SupplierId) AND (\"ensupplierdetail6\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierDetail_SupplierId", DbType.Int64, qpsuSupplierDetail_SupplierId);
} else {
whereBuilder.Append("(\"ensupplierdetail6\".\"supplierid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"encompany50\".\"externalid\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_3c0fa01b89994c3e2eaed82b259c3f66 outParamList = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSupplierSocietiesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetSupplierSocieties.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c0fa01b89994c3e2eaed82b259c3f66 _tmp = new RL_3c0fa01b89994c3e2eaed82b259c3f66();
_tmp.AlternateReadDbMethodAsync = datasetGetSupplierSocietiesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetSupplierSocieties.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c0fa01b89994c3e2eaed82b259c3f66)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetProjectAssetByRequisition" J+0qaOqcBki6bla49Jf4HQ of Action "RequisitionDetail"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetByRequisition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetProjectAssetByRequisition", "682aed27-9cea-4806-ba6e-56b8f497f81d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetProjectAssetByRequisition");
// Query Iterations: Never
// Refresh Query Y6bM_JswJU29HKDA+Ez3Bw Iterations: Never
// Refresh Query RvHVhDm0u0ywzlpNNcGgcA Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.J+0qaOqcBki6bla49Jf4HQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enproject_asset_service21\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service21\"");
whereBuilder.Append(" WHERE ");
if (qpprId != 0) {
whereBuilder.Append("((\"enproject_asset_service21\".\"id\" = @qpprId) AND (\"enproject_asset_service21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprId", DbType.Int64, qpprId);
} else {
whereBuilder.Append("(\"enproject_asset_service21\".\"id\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enproject_asset_service21\".\"isothers\" ASC , \"enproject_asset_service21\".\"description\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_39dc6f4415ce9196844d0ada601cc72b outParamList = new RL_39dc6f4415ce9196844d0ada601cc72b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetProjectAssetByRequisition.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dc6f4415ce9196844d0ada601cc72b _tmp = new RL_39dc6f4415ce9196844d0ada601cc72b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetProjectAssetByRequisition.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dc6f4415ce9196844d0ada601cc72b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetCurrencies" zLyOcXQZwUGCOaEfvYnedw of Action "RequisitionDetail"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetCurrencies", "718ebccc-1974-41c1-8239-a11fbd89de77");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetCurrencies");
// Query Iterations: Multiple
// Refresh Query 706zCF2vxEmE_mnhVgnJnA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.zLyOcXQZwUGCOaEfvYnedw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency26\".\"code\" o0, \"encurrency26\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency26\"");
whereBuilder.Append(" WHERE (\"encurrency26\".\"isactive\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_1353a59e0688582d82bbddc41b47193e outParamList = new RL_1353a59e0688582d82bbddc41b47193e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetCurrencies.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1353a59e0688582d82bbddc41b47193e _tmp = new RL_1353a59e0688582d82bbddc41b47193e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetCurrencies.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1353a59e0688582d82bbddc41b47193e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentOptions" egardFxTcU2LaElv2W+aLw of Action "RequisitionDetail"
public static async Task<(RL_251acb2daece433ee402c9709ec88356,long)> datasetGetPaymentOptions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetPaymentOptions", "74ab067a-535c-4d71-8b68-496fd96f9a2f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetPaymentOptions");
// Query Iterations: Multiple
// Refresh Query J45NmJMozEOwQwUqqjtdhA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.egardFxTcU2LaElv2W+aLw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentoptions4\".\"id\" o0, NULL o1, \"enpaymentoptions4\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentOptions} \"enpaymentoptions4\"");
whereBuilder.Append(" WHERE ((\"enpaymentoptions4\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentoptions4\".\"id\" = @qppaId) AND (\"enpaymentoptions4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentoptions4\".\"id\" IS NULL)");
}
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_251acb2daece433ee402c9709ec88356 outParamList = new RL_251acb2daece433ee402c9709ec88356();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetPaymentOptions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_251acb2daece433ee402c9709ec88356 _tmp = new RL_251acb2daece433ee402c9709ec88356();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetPaymentOptions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_251acb2daece433ee402c9709ec88356)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetSustainabilities" i_0je1lV80+rV8KN8N1_KQ of Action "RequisitionDetail"
public static async Task<(RL_c861661ffef6a96c498651ed1efeee53,long)> datasetGetSustainabilities(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetSustainabilities", "7b23fd8b-5559-4ff3-ab57-c28df0dd7f29");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetSustainabilities");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.i_0je1lV80+rV8KN8N1_KQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensustainability\".\"id\" o0, \"ensustainability\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Sustainability} \"ensustainability\"");
whereBuilder.Append(" WHERE (\"ensustainability\".\"isactive\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_c861661ffef6a96c498651ed1efeee53 outParamList = new RL_c861661ffef6a96c498651ed1efeee53();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetSustainabilities.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c861661ffef6a96c498651ed1efeee53 _tmp = new RL_c861661ffef6a96c498651ed1efeee53();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetSustainabilities.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c861661ffef6a96c498651ed1efeee53)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetInvoiceUsages" cwyDfH9R9kCod6TIAPQKfQ of Action "RequisitionDetail"
public static async Task<(RL_1078cb2b44dad3e211c3325e839a4151,long)> datasetGetInvoiceUsages(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetInvoiceUsages", "7c830c73-517f-40f6-a877-a4c800f40a7d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetInvoiceUsages");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.cwyDfH9R9kCod6TIAPQKfQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceusage7\".\"id\" o0, NULL o1, \"eninvoiceusage7\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {InvoiceUsage} \"eninvoiceusage7\"");
whereBuilder.Append(" WHERE (\"eninvoiceusage7\".\"isactive\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_1078cb2b44dad3e211c3325e839a4151 outParamList = new RL_1078cb2b44dad3e211c3325e839a4151();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetInvoiceUsages.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_1078cb2b44dad3e211c3325e839a4151 _tmp = new RL_1078cb2b44dad3e211c3325e839a4151();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetInvoiceUsages.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_1078cb2b44dad3e211c3325e839a4151)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_cc5b09a13023b24fea23c488b525369e> datasetGetCostCenterSAPByRequisitionIdReadDbAsync(RC_cc5b09a13023b24fea23c488b525369e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
return rec;
}
// Query Function "GetCostCenterSAPByRequisitionId" GaXrgDXNjUe83yeZZZmSWg of Action "RequisitionDetail"
public static async Task<(RL_40d1dae5da886b385f88ea5c5c7574ca,long)> datasetGetCostCenterSAPByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetCostCenterSAPByRequisitionId", "80eba519-cd35-478d-bcdf-27996599925a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetCostCenterSAPByRequisitionId");
// Query Iterations: Never
// Refresh Query _8jLyX+uFk+3aQOnCDI3mg Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.GaXrgDXNjUe83yeZZZmSWg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"encostcentersap18\".\"denominacion\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82");
fromBuilder.Append(" FROM ({CostCenterSAP} \"encostcentersap18\" Left JOIN {Requisition} \"enrequisition115\" ON (\"encostcentersap18\".\"id\" = \"enrequisition115\".\"costcenterid\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition115\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition115\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition115\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_40d1dae5da886b385f88ea5c5c7574ca outParamList = new RL_40d1dae5da886b385f88ea5c5c7574ca();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetCostCenterSAPByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetCostCenterSAPByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_40d1dae5da886b385f88ea5c5c7574ca _tmp = new RL_40d1dae5da886b385f88ea5c5c7574ca();
_tmp.AlternateReadDbMethodAsync = datasetGetCostCenterSAPByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetCostCenterSAPByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_40d1dae5da886b385f88ea5c5c7574ca)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetProjectAssetServiceOtro" 35OyhQCry0qj_zbuolTN9A of Action "RequisitionDetail"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServiceOtro(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetProjectAssetServiceOtro", "85b293df-ab00-4acb-a3ff-36eea254cdf4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetProjectAssetServiceOtro");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.35OyhQCry0qj_zbuolTN9A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service22\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service22\"");
whereBuilder.Append(" WHERE (\"enproject_asset_service22\".\"isothers\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_39dc6f4415ce9196844d0ada601cc72b outParamList = new RL_39dc6f4415ce9196844d0ada601cc72b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_39dc6f4415ce9196844d0ada601cc72b _tmp = new RL_39dc6f4415ce9196844d0ada601cc72b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_39dc6f4415ce9196844d0ada601cc72b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetPaymentWay99" mQVLoYoMHUCyDBuGbtl91A of Action "RequisitionDetail"
public static async Task<(RL_d98dc7eec8c631266895b622203a6db3,long)> datasetGetPaymentWay99(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetPaymentWay99", "a14b0599-0c8a-401d-b20c-1b866ed97dd4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetPaymentWay99");
// Query Iterations: Never
// Refresh Query DpYfbCXBq0aBeCth1yynWw Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.mQVLoYoMHUCyDBuGbtl91A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentWays} \"enpaymentways5\"");
whereBuilder.Append(" WHERE (\"enpaymentways5\".\"code\" = cast(99 as text))");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d98dc7eec8c631266895b622203a6db3 outParamList = new RL_d98dc7eec8c631266895b622203a6db3();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetPaymentWay99.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d98dc7eec8c631266895b622203a6db3 _tmp = new RL_d98dc7eec8c631266895b622203a6db3();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetPaymentWay99.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d98dc7eec8c631266895b622203a6db3)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetAccountingDataTypes" Q+L+ph1EVEmNYC5T+uvwDQ of Action "RequisitionDetail"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingDataTypes", "a6fee243-441d-4954-8d60-2e53faebf00d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetAccountingDataTypes");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Q+L+ph1EVEmNYC5T+uvwDQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype12\".\"id\" o0, \"enaccountingdatatype12\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype12\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype12\".\"is_active\" = 1) AND (\"enaccountingdatatype12\".\"isestim_equal_agreed\" = 1) AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d567d658fa66fc955f880e37985e7f35 outParamList = new RL_d567d658fa66fc955f880e37985e7f35();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d567d658fa66fc955f880e37985e7f35 _tmp = new RL_d567d658fa66fc955f880e37985e7f35();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d567d658fa66fc955f880e37985e7f35)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetServiceFormats" 8n1Nq0UGq0OUVg5C6FRbvA of Action "RequisitionDetail"
public static async Task<(RL_2ce058321dad3f60357fc3b3372ccb1e,long)> datasetGetServiceFormats(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetServiceFormats", "ab4d7df2-0645-43ab-9456-0e42e8545bbc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetServiceFormats");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.8n1Nq0UGq0OUVg5C6FRbvA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enserviceformat\".\"id\" o0, \"enserviceformat\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {ServiceFormat} \"enserviceformat\"");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2ce058321dad3f60357fc3b3372ccb1e outParamList = new RL_2ce058321dad3f60357fc3b3372ccb1e();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetServiceFormats.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2ce058321dad3f60357fc3b3372ccb1e _tmp = new RL_2ce058321dad3f60357fc3b3372ccb1e();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetServiceFormats.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2ce058321dad3f60357fc3b3372ccb1e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetDistributions" 1+GrsZMTJkGNzZyJGcGNvQ of Action "RequisitionDetail"
public static async Task<(RL_63e875add2b98c15e5030850edd3b2eb,long)> datasetGetDistributions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetDistributions", "b1abe1d7-1393-4126-8dcd-9c8919c18dbd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetDistributions");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.1+GrsZMTJkGNzZyJGcGNvQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endistribution3\".\"id\" o0, \"endistribution3\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Distribution} \"endistribution3\"");
whereBuilder.Append(" WHERE (\"endistribution3\".\"is_active\" = 1)");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_63e875add2b98c15e5030850edd3b2eb outParamList = new RL_63e875add2b98c15e5030850edd3b2eb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetDistributions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_63e875add2b98c15e5030850edd3b2eb _tmp = new RL_63e875add2b98c15e5030850edd3b2eb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetDistributions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_63e875add2b98c15e5030850edd3b2eb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetBusinessValueCategories" IWU6vmWe5kK6aN8ta7OBxA of Action "RequisitionDetail"
public static async Task<(RL_901339470d357e86e0df985d0e6489f6,long)> datasetGetBusinessValueCategories(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetBusinessValueCategories", "be3a6521-9e65-42e6-ba68-df2d6bb381c4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetBusinessValueCategories");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.IWU6vmWe5kK6aN8ta7OBxA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluecategory4\".\"id\" o0, \"enbusinessvaluecategory4\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {BusinessValueCategory} \"enbusinessvaluecategory4\"");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_901339470d357e86e0df985d0e6489f6 outParamList = new RL_901339470d357e86e0df985d0e6489f6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_901339470d357e86e0df985d0e6489f6 _tmp = new RL_901339470d357e86e0df985d0e6489f6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_901339470d357e86e0df985d0e6489f6)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetRequisitionServicesByRequisitionId" lUEMwOHwrE+oK8Q0QX7lTA of Action "RequisitionDetail"
public static async Task<(RL_b47d9310671b1b627f451a333bb8980a,long)> datasetGetRequisitionServicesByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionServicesByRequisitionId", "c00c4195-f0e1-4fac-a82b-c434417ee54c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetRequisitionServicesByRequisitionId");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.lUEMwOHwrE+oK8Q0QX7lTA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionservice4\".\"id\" o0, \"enrequisitionservice4\".\"requisitionid\" o1, \"enrequisitionservice4\".\"accountingservicetypeid\" o2, \"enrequisitionservice4\".\"frequencyid\" o3, trim_scale(\"enrequisitionservice4\".\"amount\"::numeric) o4, \"enrequisitionservice4\".\"description\" o5, \"enrequisitionservice4\".\"invoiceusageid\" o6");
fromBuilder.Append(" FROM {RequisitionService} \"enrequisitionservice4\"");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionservice4\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionservice4\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionservice4\".\"requisitionid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_b47d9310671b1b627f451a333bb8980a outParamList = new RL_b47d9310671b1b627f451a333bb8980a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b47d9310671b1b627f451a333bb8980a _tmp = new RL_b47d9310671b1b627f451a333bb8980a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionServicesByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b47d9310671b1b627f451a333bb8980a)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetBusinessValueSubcategoriesByCategoryId" YMDkwa8sHkC00OYQyk3gCQ of Action "RequisitionDetail"
public static async Task<(RL_2d11b20156650990ba0f3131aaaad2ea,long)> datasetGetBusinessValueSubcategoriesByCategoryId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpbuCategoryId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetBusinessValueSubcategoriesByCategoryId", "c1e4c060-2caf-401e-b4d0-e610ca4de009");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetBusinessValueSubcategoriesByCategoryId");
// Query Iterations: Multiple
// Refresh Query KQoAUo3+sk6WER7QwmGfHA Iterations: Multiple
// Refresh Query CakNchBvY0iDEM3J1Y39Zw Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.YMDkwa8sHkC00OYQyk3gCQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluesubcategory4\".\"id\" o0, \"enbusinessvaluesubcategory4\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {BusinessValueSubcategory} \"enbusinessvaluesubcategory4\"");
whereBuilder.Append(" WHERE ");
if (qpbuCategoryId != 0) {
whereBuilder.Append("((\"enbusinessvaluesubcategory4\".\"categoryid\" = @qpbuCategoryId) AND (\"enbusinessvaluesubcategory4\".\"categoryid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbuCategoryId", DbType.Int64, qpbuCategoryId);
} else {
whereBuilder.Append("(\"enbusinessvaluesubcategory4\".\"categoryid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_2d11b20156650990ba0f3131aaaad2ea outParamList = new RL_2d11b20156650990ba0f3131aaaad2ea();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_2d11b20156650990ba0f3131aaaad2ea _tmp = new RL_2d11b20156650990ba0f3131aaaad2ea();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_2d11b20156650990ba0f3131aaaad2ea)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_2d026dc77741fad17a11f0df63aa3b4b> datasetGetEntraRoleReadDbAsync(RC_2d026dc77741fad17a11f0df63aa3b4b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetEntraRole" mPHRxH2850Wj86IDQnrDBA of Action "RequisitionDetail"
public static async Task<(RL_ea7d18baeeefa57d5c86706d7efb98e9,long)> datasetGetEntraRole(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetEntraRole", "c4d1f198-bc7d-45e7-a3f3-a203427ac304");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetEntraRole");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.mPHRxH2850Wj86IDQnrDBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enentrarole59\".\"isareacxp\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM ({User_Extended_Internal} \"enuser_extended_internal114\" Inner JOIN {EntraRole} \"enentrarole59\" ON (\"enentrarole59\".\"rolename\" = \"enuser_extended_internal114\".\"jobtitle\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal114\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal114\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal114\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_ea7d18baeeefa57d5c86706d7efb98e9 outParamList = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetEntraRoleReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetEntraRole.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_ea7d18baeeefa57d5c86706d7efb98e9 _tmp = new RL_ea7d18baeeefa57d5c86706d7efb98e9();
_tmp.AlternateReadDbMethodAsync = datasetGetEntraRoleReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetEntraRole.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_ea7d18baeeefa57d5c86706d7efb98e9)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_7c130c22cc39a396afe0c98666f27e02> datasetGetRequisitionCostCentersByRequisitionIdReadDbAsync(RC_7c130c22cc39a396afe0c98666f27e02 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCostCenterSAP.Read( r, ref index);
rec.ssENRequisitionCostCenter.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionCostCentersByRequisitionId" Z6M20iCZcUGyDJOx3_Veyg of Action "RequisitionDetail"
public static async Task<(RL_a3213f63c9dee3312d82d37ec604d349,long)> datasetGetRequisitionCostCentersByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionCostCenter_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionCostCentersByRequisitionId", "d236a367-9920-4171-b20c-93b1dff55eca");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetRequisitionCostCentersByRequisitionId");
// Query Iterations: Multiple
// Refresh Query w9WvecfQpESkGLsAK47lXg Iterations: Multiple
// Refresh Query gYZA_HlUxU2OL4zq_LG4fQ Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Z6M20iCZcUGyDJOx3_Veyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM ({RequisitionCostCenter} \"enrequisitioncostcenter2\" Left JOIN {CostCenterSAP} \"encostcentersap19\" ON (\"enrequisitioncostcenter2\".\"costcentersap\" = \"encostcentersap19\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionCostCenter_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncostcenter2\".\"requisitionid\" = @qpreRequisitionCostCenter_RequisitionId) AND (\"enrequisitioncostcenter2\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionCostCenter_RequisitionId", DbType.Int64, qpreRequisitionCostCenter_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncostcenter2\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpboCheckUserSession = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_a3213f63c9dee3312d82d37ec604d349 outParamList = new RL_a3213f63c9dee3312d82d37ec604d349();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionCostCentersByRequisitionIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_a3213f63c9dee3312d82d37ec604d349 _tmp = new RL_a3213f63c9dee3312d82d37ec604d349();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionCostCentersByRequisitionIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionCostCentersByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_a3213f63c9dee3312d82d37ec604d349)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetSupplierByRequisition" akvu2XlSTE2_EVxqVvWynw of Action "RequisitionDetail"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierByRequisition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetSupplierByRequisition", "d9ee4b6a-5279-4d4c-bf11-5c6a56f5b29f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetSupplierByRequisition");
// Query Iterations: Never
// Refresh Query AvyJrcXxoUmHVAcwu3zlNA Iterations: Never
// Refresh Query MgStDyfRGEmuCYk3vB8puA Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.akvu2XlSTE2_EVxqVvWynw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"ensupplier112\".\"id\" o0, NULL o1, \"ensupplier112\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"ensupplier112\".\"pais\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier112\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier112\".\"id\" = @qpsuId) AND (\"ensupplier112\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier112\".\"id\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_d5c1b2482ff109e80580d8b5fb920193 outParamList = new RL_d5c1b2482ff109e80580d8b5fb920193();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d5c1b2482ff109e80580d8b5fb920193 _tmp = new RL_d5c1b2482ff109e80580d8b5fb920193();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d5c1b2482ff109e80580d8b5fb920193)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetDocumentTypeKR" 8D+64mVydECARUvo8+taiA of Action "RequisitionDetail"
public static async Task<(RL_f2d249f675a5073e98f93433009d7ad4,long)> datasetGetDocumentTypeKR(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetDocumentTypeKR", "e2ba3ff0-7265-4074-8045-4be8f3eb5a88");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetDocumentTypeKR");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.8D+64mVydECARUvo8+taiA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endocumenttype3\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {DocumentType} \"endocumenttype3\"");
whereBuilder.Append(" WHERE (\"endocumenttype3\".\"classe\" = 'KR')");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_f2d249f675a5073e98f93433009d7ad4 outParamList = new RL_f2d249f675a5073e98f93433009d7ad4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetDocumentTypeKR.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f2d249f675a5073e98f93433009d7ad4 _tmp = new RL_f2d249f675a5073e98f93433009d7ad4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetDocumentTypeKR.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f2d249f675a5073e98f93433009d7ad4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetSupplierDetailBySociety" XtPv487lg0yajX9A3nXQcA of Action "RequisitionDetail"
public static async Task<(RL_10b798eceef0c61e2eb85d7fd35e40d6,long)> datasetGetSupplierDetailBySociety(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpcoSociedadeId,long qpsuSupplierId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetSupplierDetailBySociety", "e3efd35e-e5ce-4c83-9a8d-7f40de75d070");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetSupplierDetailBySociety");
// Query Iterations: Never
// Refresh Query ZDiHBRzrekeS0+McBevOkg Iterations: Never
// Refresh Query z2Uh8pLcQkeZ18Hk9kqtIA Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.XtPv487lg0yajX9A3nXQcA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, \"ensupplierdetail7\".\"cond_pago\" o17, \"ensupplierdetail7\".\"viasdepago\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25");
fromBuilder.Append(" FROM {SupplierDetail} \"ensupplierdetail7\"");
whereBuilder.Append(" WHERE ");
if (qpsuSupplierId != 0) {
whereBuilder.Append("((\"ensupplierdetail7\".\"supplierid\" = @qpsuSupplierId) AND (\"ensupplierdetail7\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplierId", DbType.Int64, qpsuSupplierId);
} else {
whereBuilder.Append("(\"ensupplierdetail7\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpcoSociedadeId != 0) {
whereBuilder.Append("((\"ensupplierdetail7\".\"sociedadeid\" = @qpcoSociedadeId) AND (\"ensupplierdetail7\".\"sociedadeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcoSociedadeId", DbType.Int64, qpcoSociedadeId);
} else {
whereBuilder.Append("(\"ensupplierdetail7\".\"sociedadeid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_10b798eceef0c61e2eb85d7fd35e40d6 outParamList = new RL_10b798eceef0c61e2eb85d7fd35e40d6();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetSupplierDetailBySociety.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_10b798eceef0c61e2eb85d7fd35e40d6 _tmp = new RL_10b798eceef0c61e2eb85d7fd35e40d6();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetSupplierDetailBySociety.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_10b798eceef0c61e2eb85d7fd35e40d6)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_db730a379abf48e3725f395a2176e12f> datasetGetRequisitionByIdReadDbAsync(RC_db730a379abf48e3725f395a2176e12f rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENCompany.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApproval.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENRequisitionStatus.Read( r, ref index);
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssShowCancelButton = r.ReadBoolean(index++, "RequisitionRequisitionApprovalLevelRequisitionApprovalRequisitionStatusShowCancelButtonCompanySupplierTelcelDirectionSegmentAccGroupPaymentTermsSegmentAccGroupTelcelDirRecord.ShowCancelButton", false);
return rec;
}
// Query Function "GetRequisitionById" 0BSH5+AGKU2WKropQy2u+g of Action "RequisitionDetail"
public static async Task<(RL_db407242f011e8b84a110f6970108663,long)> datasetGetRequisitionById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckProveedorRole,bool qpboCheckUserSession,bool qpboCanUploadInvoices,bool qpboIsCorporativoCxP,long qpenRequisitionApprovalLevel_EntraRoleId,string qpusGetUserId,long qpapRequisitionApprovalLevel_ApplicationRoleId,long qpapRequisitionApprovalLevel_ApplicationRoleId1,long qpapRequisitionApprovalLevel_ApplicationRoleId2,long qpapRequisitionApprovalLevel_ApplicationRoleId3,long qpsuRequisition_SupplierId,long qpreRequisition_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionById", "e78714d0-06e0-4d29-962a-ba29432daefa");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetRequisitionById");
// Query Iterations: Never
// Refresh Query 1aOU6qHaOE2zB8Xvr5vpGA Iterations: Never
// Refresh Query MSZhVjWABkKvOBYYy5vIuw Iterations: Never
// Refresh Query cpM5xwtUz0+2FjJiekuU7Q Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.0BSH5+AGKU2WKropQy2u+g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"encompany51\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, \"enrequisition116\".\"id\" o22, \"enrequisition116\".\"name\" o23, \"enrequisition116\".\"counter\" o24, \"enrequisition116\".\"requisitionstatusid\" o25, \"enrequisition116\".\"supplierid\" o26, \"enrequisition116\".\"regionid\" o27, \"enrequisition116\".\"accountingregionid\" o28, \"enrequisition116\".\"applicantid\" o29, \"enrequisition116\".\"maxdatefinishcapture\" o30, \"enrequisition116\".\"projectassetserviceid\" o31, \"enrequisition116\".\"projectassetservice\" o32, \"enrequisition116\".\"projectdescription\" o33, \"enrequisition116\".\"frequencyid\" o34, \"enrequisition116\".\"issustainability\" o35, \"enrequisition116\".\"sustainabilityid\" o36, \"enrequisition116\".\"businessvaluecategoryid\" o37, \"enrequisition116\".\"businessvaluesubcategoryid\" o38, trim_scale(\"enrequisition116\".\"totalamount\"::numeric) o39, \"enrequisition116\".\"currencyid\" o40, \"enrequisition116\".\"distributionid\" o41, \"enrequisition116\".\"costcenterid\" o42, \"enrequisition116\".\"hascontract\" o43, \"enrequisition116\".\"iscontractpending\" o44, \"enrequisition116\".\"hasdeposit\" o45, \"enrequisition116\".\"hasinsurance\" o46, \"enrequisition116\".\"hasadvancepayment\" o47, \"enrequisition116\".\"accountingservicetypeid_depr\" o48, \"enrequisition116\".\"servicedescription_deprec\" o49, \"enrequisition116\".\"invoiceusageid_deprec\" o50, \"enrequisition116\".\"serviceformatid\" o51, \"enrequisition116\".\"companyid\" o52, trim_scale(\"enrequisition116\".\"retentionrate\"::numeric) o53, trim_scale(\"enrequisition116\".\"negotiatedexchangerate\"::numeric) o54, \"enrequisition116\".\"paymentmethodid\" o55, \"enrequisition116\".\"paymenttermsid\" o56, \"enrequisition116\".\"isautomaticaccounting\" o57, \"enrequisition116\".\"createdby\" o58, \"enrequisition116\".\"createdon\" o59, \"enrequisition116\".\"updatedon\" o60, \"enrequisition116\".\"updatedby\" o61, \"enrequisition116\".\"createdbyapplicationrole\" o62, \"enrequisition116\".\"dateofcommitment\" o63, \"enrequisition116\".\"hascontractfileuploaded\" o64, \"enrequisition116\".\"hasupdateddateofcommitment\" o65, \"enrequisition116\".\"submittedon\" o66, \"enrequisition116\".\"isdonation\" o67, \"enrequisition116\".\"advwithoutinvoice\" o68, \"enrequisition116\".\"wasadvwithoutinvoice\" o69, \"enrequisition116\".\"isadvanced\" o70, \"enrequisition116\".\"documenttypeid\" o71, \"enrequisition116\".\"iscreatedbyanassistente\" o72, \"enrequisition116\".\"telceldirectionid\" o73, \"enrequisition116\".\"hasmultiupload\" o74, \"enrequisition116\".\"accountingdate\" o75, \"enrequisition116\".\"paymentoptionsid\" o76, \"enrequisition116\".\"paymentwaysid\" o77, \"enrequisition116\".\"buydocnumber\" o78, \"enrequisition116\".\"buydocposition\" o79, \"enrequisitionapproval31\".\"id\" o80, NULL o81, NULL o82, NULL o83, NULL o84, \"enrequisitionapproval31\".\"currentlevel\" o85, \"enrequisitionapproval31\".\"maxlevel\" o86, NULL o87, NULL o88, \"enrequisitionapproval31\".\"hasstartedaccounting\" o89, \"enrequisitionapprovallevel26\".\"id\" o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, \"enrequisitionapprovallevel26\".\"assignedto\" o100, NULL o101, \"enrequisitionapprovallevel26\".\"approvalstatusid\" o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, \"enrequisitionapprovallevel26\".\"isaccounting\" o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, \"enrequisitionstatus4\".\"id\" o116, \"enrequisitionstatus4\".\"label\" o117, \"enrequisitionstatus4\".\"class\" o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, (CASE WHEN (((");
if (qpapRequisitionApprovalLevel_ApplicationRoleId3 != 0) {
selectBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId3);
} else {
selectBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
selectBuilder.Append(" OR ");
if (qpapRequisitionApprovalLevel_ApplicationRoleId1 != 0) {
selectBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId1) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId1", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId1);
} else {
selectBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
selectBuilder.Append(") AND (\"enrequisition116\".\"requisitionstatusid\" = ");
selectBuilder.Append((ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("GxzelG_MJUCC7GqpNLMaDw"))).ssId);
selectBuilder.Append(")) AND (\"enrequisitionapprovallevel26\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(")) THEN 1 ELSE 0 END) \"showcancelbutton\"");
fromBuilder.Append(" FROM ((((((((({Requisition} \"enrequisition116\" Left JOIN {RequisitionStatus} \"enrequisitionstatus4\" ON (\"enrequisition116\".\"requisitionstatusid\" = \"enrequisitionstatus4\".\"id\"))  Left JOIN {RequisitionApproval} \"enrequisitionapproval31\" ON (\"enrequisition116\".\"id\" = \"enrequisitionapproval31\".\"requisitionid\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel26\" ON (((\"enrequisitionapproval31\".\"id\" = \"enrequisitionapprovallevel26\".\"requisitionapprovalid\") AND ((CASE WHEN (\"enrequisitionapprovallevel26\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"assignedto\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"approvedby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(" OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"canceledby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"canceledby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ((\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL) AND (");
if (qpapRequisitionApprovalLevel_ApplicationRoleId2 != 0) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId2) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId2", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId2);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
fromBuilder.Append(" OR ");
if (qpapRequisitionApprovalLevel_ApplicationRoleId != 0) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId3) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId3", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
fromBuilder.Append("))) OR ");
if (qpenRequisitionApprovalLevel_EntraRoleId != 0) {
fromBuilder.Append("((\"enrequisitionapprovallevel26\".\"entraroleid\" = @qpenRequisitionApprovalLevel_EntraRoleId) AND (\"enrequisitionapprovallevel26\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenRequisitionApprovalLevel_EntraRoleId", DbType.Int64, qpenRequisitionApprovalLevel_EntraRoleId);
} else {
fromBuilder.Append("(\"enrequisitionapprovallevel26\".\"entraroleid\" IS NULL)");
}
fromBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)) AND ((((\"enrequisitionapprovallevel26\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(") OR (\"enrequisitionapprovallevel26\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("rkrV30n0cEiW8dttOKG0gw"))).ssId);
fromBuilder.Append(")) OR (\"enrequisitionapprovallevel26\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("A8ye9hhImUaVe0wa+Rtbjg"))).ssId);
fromBuilder.Append(")) OR (\"enrequisitionapprovallevel26\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("YBJlnXS8SkKRSq9aruxhkg"))).ssId);
fromBuilder.Append("))))  Left JOIN {Company} \"encompany51\" ON (\"enrequisition116\".\"companyid\" = \"encompany51\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms31\" ON (\"enrequisition116\".\"paymenttermsid\" = \"enpaymentterms31\".\"id\"))  Left JOIN {Supplier} \"ensupplier113\" ON (\"enrequisition116\".\"supplierid\" = \"ensupplier113\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection15\" ON (\"enrequisition116\".\"telceldirectionid\" = \"entelceldirection15\".\"id\"))  Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir7\" ON (\"entelceldirection15\".\"id\" = \"ensegmentaccgrouptelceldir7\".\"telceldirectionid\"))  Left JOIN {SegmentAccGroup} \"ensegmentaccgroup7\" ON (\"ensegmentaccgrouptelceldir7\".\"segmentaccgroupid\" = \"ensegmentaccgroup7\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisition_Id != 0) {
whereBuilder.Append("((\"enrequisition116\".\"id\" = @qpreRequisition_Id) AND (\"enrequisition116\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_Id", DbType.Int64, qpreRequisition_Id);
} else {
whereBuilder.Append("(\"enrequisition116\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN (@qpboCheckProveedorRole = 1) THEN (CASE WHEN (");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckProveedorRole", DbType.Boolean, qpboCheckProveedorRole);
if (qpsuRequisition_SupplierId != 0) {
whereBuilder.Append("((\"enrequisition116\".\"supplierid\" = @qpsuRequisition_SupplierId) AND (\"enrequisition116\".\"supplierid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
} else {
whereBuilder.Append("(\"enrequisition116\".\"supplierid\" IS NULL)");
}
whereBuilder.Append(" AND (@qpsuRequisition_SupplierId <> 0)) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((");
sqlCmd.CreateParameterWithoutReplacements("@qpsuRequisition_SupplierId", DbType.Int64, qpsuRequisition_SupplierId);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisition116\".\"applicantid\" = @qpusGetUserId) AND (\"enrequisition116\".\"applicantid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enrequisition116\".\"applicantid\" IS NULL)");
}
whereBuilder.Append(" OR (@qpboIsCorporativoCxP = 1)) OR (@qpboCanUploadInvoices = 1)) THEN 1 ELSE (CASE WHEN ((\"enrequisitionapprovallevel26\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (((((CASE WHEN (\"enrequisitionapprovallevel26\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboCanUploadInvoices", DbType.Boolean, qpboCanUploadInvoices);
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"assignedto\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((");
if (qpapRequisitionApprovalLevel_ApplicationRoleId3 != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId3);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpapRequisitionApprovalLevel_ApplicationRoleId1 != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"applicationroleid\" = @qpapRequisitionApprovalLevel_ApplicationRoleId1) AND (\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapRequisitionApprovalLevel_ApplicationRoleId1", DbType.Int64, qpapRequisitionApprovalLevel_ApplicationRoleId1);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"applicationroleid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpenRequisitionApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"entraroleid\" = @qpenRequisitionApprovalLevel_EntraRoleId) AND (\"enrequisitionapprovallevel26\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenRequisitionApprovalLevel_EntraRoleId", DbType.Int64, qpenRequisitionApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1) OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"approvedby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"approvedby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"requesttomodifyby\" IS NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enrequisitionapprovallevel26\".\"canceledby\" = @qpusGetUserId) AND (\"enrequisitionapprovallevel26\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enrequisitionapprovallevel26\".\"canceledby\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enrequisitionapprovallevel26\".\"levelnumber\" DESC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_db407242f011e8b84a110f6970108663 outParamList = new RL_db407242f011e8b84a110f6970108663();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[10];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, false, true, false, true, true, true, true, true, true, false, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, false, false, true, true, false});
opt[3] = new BitArray(new bool[] {false, false, false, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_db407242f011e8b84a110f6970108663 _tmp = new RL_db407242f011e8b84a110f6970108663();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_db407242f011e8b84a110f6970108663)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetDepositTypes" Tmxk+Xwd0kWTxzi46_UHQw of Action "RequisitionDetail"
public static async Task<(RL_cda7ed93cc851adc2316965418c61e6f,long)> datasetGetDepositTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("c_Requisitions.RequisitionDetail.GetDepositTypes", "f9646c4e-1d7c-45d2-93c7-38b8ebf50743");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("RequisitionDetail","c_Requisitions.RequisitionDetail.GetDepositTypes");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/ScreenDataSets.Tmxk+Xwd0kWTxzi46_UHQw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endeposittype2\".\"id\" o0, \"endeposittype2\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {DepositType} \"endeposittype2\"");
whereBuilder.Append(" WHERE (\"endeposittype2\".\"is_active\" = 1) AND (\"endeposittype2\".\"id\" <> ");
whereBuilder.Append(1
);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_cda7ed93cc851adc2316965418c61e6f outParamList = new RL_cda7ed93cc851adc2316965418c61e6f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetDepositTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cda7ed93cc851adc2316965418c61e6f _tmp = new RL_cda7ed93cc851adc2316965418c61e6f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetDepositTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cda7ed93cc851adc2316965418c61e6f)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}


    public class lcvGetRequisitionContractData : VarsBag {
public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetRequisitionFilesById_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetRequisitionFilesById_outParamCount = 0L;

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterDeposit_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterContract_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterAdvancePayment_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterPendingJustif_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterNullIdentifier_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterInsurance_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public lcvGetRequisitionContractData() {
}
}
public class lcoGetRequisitionContractData : VarsBag {
public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractFile = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public RL_7a479a555821b093171c5d3cd3382006 outParamo_AttachFilesList = new RL_7a479a555821b093171c5d3cd3382006();

public RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractDepositList = new RL_7a479a555821b093171c5d3cd3382006();

public RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractInsuranceList = new RL_7a479a555821b093171c5d3cd3382006();

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractAdvancePayment = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractPendingJustification = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public lcoGetRequisitionContractData() {
}
}
/// <summary>
/// Action <code>GetRequisitionContractData</code> that represents the Service Studio action
///  <code>GetRequisitionContractData</code> <p> Description: Data Action that fetchs Requisitio
/// n Contract Data.</p>
/// </summary>
public async Task<(ST_26b16bea631cbd94cf555acb5c7a4be3Structure,RL_7a479a555821b093171c5d3cd3382006,RL_7a479a555821b093171c5d3cd3382006,RL_7a479a555821b093171c5d3cd3382006,ST_26b16bea631cbd94cf555acb5c7a4be3Structure,ST_26b16bea631cbd94cf555acb5c7a4be3Structure)> DataActionGetRequisitionContractData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractFile = default;
RL_7a479a555821b093171c5d3cd3382006 outParamo_AttachFilesList = default;
RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractDepositList = default;
RL_7a479a555821b093171c5d3cd3382006 outParamo_ContractInsuranceList = default;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractAdvancePayment = default;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ContractPendingJustification = default;
lcoGetRequisitionContractData result = new lcoGetRequisitionContractData();
lcvGetRequisitionContractData localVars = new lcvGetRequisitionContractData();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionContractData", "01c453bf-8e37-4702-806a-345645cc9d0d"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetRequisitionContractData")){
// Query datasetGetRequisitionFilesById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFilesById_maxRecords = 0;
int datasetGetRequisitionFilesById_startIndex = 0;(localVars.queryResGetRequisitionFilesById_outParamList,localVars.queryResGetRequisitionFilesById_outParamCount) = await FuncDataActionGetRequisitionContractData.datasetGetRequisitionFilesById(requestContext,datasetGetRequisitionFilesById_maxRecords,datasetGetRequisitionFilesById_startIndex,IterationMultiplicity.Multiple,inParami_RequisitionId,cancellationToken);

// ListFilterDeposit
localVars.resListFilterDeposit_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("LL0EEo6QjEia4MHtbq4Wcg"))).ssId), cancellationToken)));

// Foreach ListFilterDeposit.FilteredList
localVars.resListFilterDeposit_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterDeposit_outParamFilteredList.Eof))) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractDepositList,new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(){ ssRequisitionContractFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENRequisitionContractFile, ssRequisitionFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENRequisitionFile2, ssBinary = BuiltInFunction.NullBinary () },cancellationToken);

localVars.resListFilterDeposit_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterDeposit_outParamFilteredList.EndIteration();
}

// ListFilterInsurance
localVars.resListFilterInsurance_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("r4jSUQNmxUqnB9v839cdug"))).ssId), cancellationToken)));

// Foreach ListFilterInsurance.FilteredList
localVars.resListFilterInsurance_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterInsurance_outParamFilteredList.Eof))) {
// ListAppend2
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractInsuranceList,new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(){ ssRequisitionContractFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENRequisitionContractFile, ssRequisitionFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENRequisitionFile2, ssBinary = BuiltInFunction.NullBinary () },cancellationToken);

localVars.resListFilterInsurance_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterInsurance_outParamFilteredList.EndIteration();
}

// ListFilterAdvancePayment
localVars.resListFilterAdvancePayment_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"))).ssId), cancellationToken)));

// ListFilterNullIdentifier
localVars.resListFilterNullIdentifier_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==BuiltInFunction.NullIdentifier ()), cancellationToken)));

// Foreach ListFilterNullIdentifier.FilteredList
localVars.resListFilterNullIdentifier_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterNullIdentifier_outParamFilteredList.Eof))) {
// ListAppend3
await ExtendedActions.ListAppend(requestContext,result.outParamo_AttachFilesList,new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(){ ssRequisitionContractFile = localVars.resListFilterNullIdentifier_outParamFilteredList.CurrentRec.ssENRequisitionContractFile, ssRequisitionFile = localVars.resListFilterNullIdentifier_outParamFilteredList.CurrentRec.ssENRequisitionFile2, ssBinary = BuiltInFunction.NullBinary () },cancellationToken);

localVars.resListFilterNullIdentifier_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterNullIdentifier_outParamFilteredList.EndIteration();
}

// ListFilterContract
localVars.resListFilterContract_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("G8yzk1VC6kuuzlQ40OJi8Q"))).ssId), cancellationToken)));

// ListFilterPendingJustif
localVars.resListFilterPendingJustif_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("KQCdGM5P7k+IR4O+zSRfKA"))).ssId), cancellationToken)));

// Output
// o_ContractAdvancePayment = ListFilterAdvancePayment.FilteredList.Current
result.outParamo_ContractAdvancePayment=(await RecordUtils.ConvertAsync(localVars.resListFilterAdvancePayment_outParamFilteredList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));

// o_ContractFile = ListFilterContract.FilteredList.Current
result.outParamo_ContractFile=(await RecordUtils.ConvertAsync(localVars.resListFilterContract_outParamFilteredList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));

// o_ContractPendingJustification = ListFilterPendingJustif.FilteredList.Current
result.outParamo_ContractPendingJustification=(await RecordUtils.ConvertAsync(localVars.resListFilterPendingJustif_outParamFilteredList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_ContractFile = result.outParamo_ContractFile;
outParamo_AttachFilesList = result.outParamo_AttachFilesList;
outParamo_ContractDepositList = result.outParamo_ContractDepositList;
outParamo_ContractInsuranceList = result.outParamo_ContractInsuranceList;
outParamo_ContractAdvancePayment = result.outParamo_ContractAdvancePayment;
outParamo_ContractPendingJustification = result.outParamo_ContractPendingJustification;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ContractFile,outParamo_AttachFilesList,outParamo_ContractDepositList,outParamo_ContractInsuranceList,outParamo_ContractAdvancePayment,outParamo_ContractPendingJustification);
}
public class lcoGetShowSelectReqPopup : VarsBag {
public bool outParamIsCorporativo = false;

public lcoGetShowSelectReqPopup() {
}
}
/// <summary>
/// Action <code>GetShowSelectReqPopup</code> that represents the Service Studio action
///  <code>GetShowSelectReqPopup</code> <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetShowSelectReqPopup(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsCorporativo = default;
lcoGetShowSelectReqPopup result = new lcoGetShowSelectReqPopup();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetShowSelectReqPopup", "09d362cc-0168-4c26-9915-415dbc64b361"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetShowSelectReqPopup")){
if(((inParami_RequisitionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// IsCorporativo = GetIsCorporativo()
result.outParamIsCorporativo=(await Functions.ActionGetIsCorporativo(requestContext,cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamIsCorporativo = result.outParamIsCorporativo;
} // inner-finally
RETURN_STATEMENT:
return outParamIsCorporativo;
}
public class lcvGetAdvWithoutInvoiceData : VarsBag {
public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterNullIdentifier_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetRequisitionFilesById_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetRequisitionFilesById_outParamCount = 0L;

public RL_dcf9165e080aea63f7a9b95efcf09ef4 resListFilterAdvancePayment_outParamFilteredList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();

public lcvGetAdvWithoutInvoiceData() {
}
}
public class lcoGetAdvWithoutInvoiceData : VarsBag {
public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_AdvWithoutInvoice = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public lcoGetAdvWithoutInvoiceData() {
}
}
/// <summary>
/// Action <code>GetAdvWithoutInvoiceData</code> that represents the Service Studio action
///  <code>GetAdvWithoutInvoiceData</code> <p> Description: </p>
/// </summary>
public async Task<ST_26b16bea631cbd94cf555acb5c7a4be3Structure> DataActionGetAdvWithoutInvoiceData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_AdvWithoutInvoice = default;
lcoGetAdvWithoutInvoiceData result = new lcoGetAdvWithoutInvoiceData();
lcvGetAdvWithoutInvoiceData localVars = new lcvGetAdvWithoutInvoiceData();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetAdvWithoutInvoiceData", "5173134e-1ec0-4d2c-a95e-39c40168846d"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetAdvWithoutInvoiceData")){
// Query datasetGetRequisitionFilesById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFilesById_maxRecords = 0;
int datasetGetRequisitionFilesById_startIndex = 0;(localVars.queryResGetRequisitionFilesById_outParamList,localVars.queryResGetRequisitionFilesById_outParamCount) = await FuncDataActionGetAdvWithoutInvoiceData.datasetGetRequisitionFilesById(requestContext,datasetGetRequisitionFilesById_maxRecords,datasetGetRequisitionFilesById_startIndex,IterationMultiplicity.Multiple,inParami_RequisitionId,cancellationToken);

// ListFilterAdvancePayment
localVars.resListFilterAdvancePayment_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"))).ssId), cancellationToken)));

// ListFilterNullIdentifier
localVars.resListFilterNullIdentifier_outParamFilteredList = (((RL_dcf9165e080aea63f7a9b95efcf09ef4)await  localVars.queryResGetRequisitionFilesById_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENRequisitionContractFile.ssContractFileTypeId==BuiltInFunction.NullIdentifier ()), cancellationToken)));

// Output
// o_AdvWithoutInvoice = ListFilterAdvancePayment.FilteredList.Current
result.outParamo_AdvWithoutInvoice=(await RecordUtils.ConvertAsync(localVars.resListFilterAdvancePayment_outParamFilteredList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_AdvWithoutInvoice = result.outParamo_AdvWithoutInvoice;
} // inner-finally
RETURN_STATEMENT:
return outParamo_AdvWithoutInvoice;
}
public class lcvGetConfiguration : VarsBag {
public int resServiceGetUploadContractDateLimit_outParamo_Value = 0;

public lcvGetConfiguration() {
}
}
public class lcoGetConfiguration : VarsBag {
public int outParamUploadContractDateLimit = 0;

public lcoGetConfiguration() {
}
}
/// <summary>
/// Action <code>GetConfiguration</code> that represents the Service Studio action
///  <code>GetConfiguration</code> <p> Description: </p>
/// </summary>
public async Task<int> DataActionGetConfiguration(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamUploadContractDateLimit = default;
lcoGetConfiguration result = new lcoGetConfiguration();
lcvGetConfiguration localVars = new lcvGetConfiguration();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetConfiguration", "52c72034-ecbf-48a3-80c4-89986a68b67c"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetConfiguration")){
// ServiceGetUploadContractDateLimit
localVars.resServiceGetUploadContractDateLimit_outParamo_Value = await ServiceAPIs.ServiceAPIServiceGetUploadContractDateLimit(requestContext,cancellationToken);

// UploadContractDateLimit = ServiceGetUploadContractDateLimit.o_Value
result.outParamUploadContractDateLimit=localVars.resServiceGetUploadContractDateLimit_outParamo_Value;
} //close CreateActionActivity using block
} // try

finally {
outParamUploadContractDateLimit = result.outParamUploadContractDateLimit;
} // inner-finally
RETURN_STATEMENT:
return outParamUploadContractDateLimit;
}
public class lcvGetAccountingData : VarsBag {
public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 queryResGetSubAccConcepts_outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
public long queryResGetSubAccConcepts_outParamCount = 0L;

public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetExchangeRateEvidence_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetExchangeRateEvidence_outParamCount = 0L;

public RL_dcf9165e080aea63f7a9b95efcf09ef4 queryResGetREPSE_outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
public long queryResGetREPSE_outParamCount = 0L;

public RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 queryResGetMainAccConcept_outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
public long queryResGetMainAccConcept_outParamCount = 0L;

public RL_991db829ff4e7fe204109f106256f023 queryResGetRequisitionAccoutingByRequisitionId_outParamList = new RL_991db829ff4e7fe204109f106256f023();
public long queryResGetRequisitionAccoutingByRequisitionId_outParamCount = 0L;

public RL_7c236018492d50b3625a5b0d981eb4eb queryResGetRemaining_outParamList = new RL_7c236018492d50b3625a5b0d981eb4eb();
public long queryResGetRemaining_outParamCount = 0L;

public lcvGetAccountingData() {
}
}
public class lcoGetAccountingData : VarsBag {
public EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord outParamRequisitionAccounting = new EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord();

public RC_cdb29de40f41bea5403aac7edb2d6159 outParamo_Estim_Equal_Agreed = new RC_cdb29de40f41bea5403aac7edb2d6159();

public RL_7c236018492d50b3625a5b0d981eb4eb outParamo_Remaining = new RL_7c236018492d50b3625a5b0d981eb4eb();

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamExchangeRateEvidence = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamREPSE = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public lcoGetAccountingData() {
}
}
/// <summary>
/// Action <code>GetAccountingData</code> that represents the Service Studio action
///  <code>GetAccountingData</code> <p> Description: Data Action that fetchs Accounting Data.</p>
/// </summary>
public async Task<(EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord,RC_cdb29de40f41bea5403aac7edb2d6159,RL_7c236018492d50b3625a5b0d981eb4eb,ST_26b16bea631cbd94cf555acb5c7a4be3Structure,ST_26b16bea631cbd94cf555acb5c7a4be3Structure)> DataActionGetAccountingData(IRequestContext requestContext,CancellationToken cancellationToken) {
EN_3554712eb61e9f0a2132c551df0f1db5EntityRecord outParamRequisitionAccounting = default;
RC_cdb29de40f41bea5403aac7edb2d6159 outParamo_Estim_Equal_Agreed = default;
RL_7c236018492d50b3625a5b0d981eb4eb outParamo_Remaining = default;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamExchangeRateEvidence = default;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamREPSE = default;
lcoGetAccountingData result = new lcoGetAccountingData();
lcvGetAccountingData localVars = new lcvGetAccountingData();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetAccountingData", "62050c81-67d3-4d43-a772-77e491d17cb1"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetAccountingData")){
// Query datasetGetRequisitionAccoutingByRequisitionId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionAccoutingByRequisitionId_maxRecords = 1;
if (datasetGetRequisitionAccoutingByRequisitionId_maxRecords < 1) datasetGetRequisitionAccoutingByRequisitionId_maxRecords = 1;
int datasetGetRequisitionAccoutingByRequisitionId_startIndex = 0;(localVars.queryResGetRequisitionAccoutingByRequisitionId_outParamList,localVars.queryResGetRequisitionAccoutingByRequisitionId_outParamCount) = await FuncDataActionGetAccountingData.datasetGetRequisitionAccoutingByRequisitionId(requestContext,datasetGetRequisitionAccoutingByRequisitionId_maxRecords,datasetGetRequisitionAccoutingByRequisitionId_startIndex,IterationMultiplicity.Never,inParami_RequisitionId,cancellationToken);

// Query datasetGetMainAccConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainAccConcept_maxRecords = 1;
if (datasetGetMainAccConcept_maxRecords < 1) datasetGetMainAccConcept_maxRecords = 1;
int datasetGetMainAccConcept_startIndex = 0;(localVars.queryResGetMainAccConcept_outParamList,localVars.queryResGetMainAccConcept_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainAccConcept(requestContext,datasetGetMainAccConcept_maxRecords,datasetGetMainAccConcept_startIndex,IterationMultiplicity.Never,localVars.queryResGetRequisitionAccoutingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

// Query datasetGetSubAccConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubAccConcepts_maxRecords = 0;
int datasetGetSubAccConcepts_startIndex = 0;(localVars.queryResGetSubAccConcepts_outParamList,localVars.queryResGetSubAccConcepts_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubAccConcepts(requestContext,datasetGetSubAccConcepts_maxRecords,datasetGetSubAccConcepts_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainAccConcept_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssId,cancellationToken);

// Query datasetGetRemaining
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRemaining_maxRecords = 0;
int datasetGetRemaining_startIndex = 0;(localVars.queryResGetRemaining_outParamList,localVars.queryResGetRemaining_outParamCount) = await FuncDataActionGetAccountingData.datasetGetRemaining(requestContext,datasetGetRemaining_maxRecords,datasetGetRemaining_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetRequisitionAccoutingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting.ssId,cancellationToken);

// Query datasetGetExchangeRateEvidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetExchangeRateEvidence_maxRecords = 1;
if (datasetGetExchangeRateEvidence_maxRecords < 1) datasetGetExchangeRateEvidence_maxRecords = 1;
int datasetGetExchangeRateEvidence_startIndex = 0;(localVars.queryResGetExchangeRateEvidence_outParamList,localVars.queryResGetExchangeRateEvidence_outParamCount) = await FuncDataActionGetAccountingData.datasetGetExchangeRateEvidence(requestContext,datasetGetExchangeRateEvidence_maxRecords,datasetGetExchangeRateEvidence_startIndex,IterationMultiplicity.Never,inParami_RequisitionId,cancellationToken);

// Query datasetGetREPSE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetREPSE_maxRecords = 1;
if (datasetGetREPSE_maxRecords < 1) datasetGetREPSE_maxRecords = 1;
int datasetGetREPSE_startIndex = 0;(localVars.queryResGetREPSE_outParamList,localVars.queryResGetREPSE_outParamCount) = await FuncDataActionGetAccountingData.datasetGetREPSE(requestContext,datasetGetREPSE_maxRecords,datasetGetREPSE_startIndex,IterationMultiplicity.Never,inParami_RequisitionId,cancellationToken);

// RequisitionAccounting = GetRequisitionAccoutingByRequisitionId.List.Current.RequisitionAccounting
result.outParamRequisitionAccounting=localVars.queryResGetRequisitionAccoutingByRequisitionId_outParamList.CurrentRec.ssENRequisitionAccounting;

// o_Estim_Equal_Agreed.MainAccConcept = GetMainAccConcept.List.Current.RequisitionAccConcepts
result.outParamo_Estim_Equal_Agreed.ssENMainAccConcept = localVars.queryResGetMainAccConcept_outParamList.CurrentRec.ssENRequisitionAccConcepts;

// o_Estim_Equal_Agreed.SubAccConcepts = GetSubAccConcepts.List
result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts = (await RL_eb1e4f883a237aab70c23418de71281c.ConvertAsync(localVars.queryResGetSubAccConcepts_outParamList, new RL_eb1e4f883a237aab70c23418de71281c(), async (RC_e33b49261cecfe02249fd0f5f57f5dbc source, EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// o_Remaining = GetRemaining.List
result.outParamo_Remaining=localVars.queryResGetRemaining_outParamList;

// ExchangeRateEvidence = GetExchangeRateEvidence.List.Current
result.outParamExchangeRateEvidence=(await RecordUtils.ConvertAsync(localVars.queryResGetExchangeRateEvidence_outParamList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssValid.ssIsValid = true;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));

// REPSE = GetREPSE.List.Current
result.outParamREPSE=(await RecordUtils.ConvertAsync(localVars.queryResGetREPSE_outParamList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_dc345357879dcb92e41eacae4ac8926c source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFile;
target.ssRequisitionFile = source.ssENRequisitionFile2;
target.ssValid.ssIsValid = true;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));
// GetSubAccConcepts empty?
if((result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts.Empty)) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts,new EN_e5ff66566e5f431d75aae3b3535726a7EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = BuiltInFunction.NullIdentifier (), ssRequisitionAccConceptsId = localVars.queryResGetMainAccConcept_outParamList.CurrentRec.ssENRequisitionAccConcepts.ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamRequisitionAccounting = result.outParamRequisitionAccounting;
outParamo_Estim_Equal_Agreed = result.outParamo_Estim_Equal_Agreed;
outParamo_Remaining = result.outParamo_Remaining;
outParamExchangeRateEvidence = result.outParamExchangeRateEvidence;
outParamREPSE = result.outParamREPSE;
} // inner-finally
RETURN_STATEMENT:
return (outParamRequisitionAccounting,outParamo_Estim_Equal_Agreed,outParamo_Remaining,outParamExchangeRateEvidence,outParamREPSE);
}
public class lcoGetShowIsDonation : VarsBag {
public bool outParamo_Show = false;

public lcoGetShowIsDonation() {
}
}
/// <summary>
/// Action <code>GetShowIsDonation</code> that represents the Service Studio action
///  <code>GetShowIsDonation</code> <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetShowIsDonation(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_Show = default;
lcoGetShowIsDonation result = new lcoGetShowIsDonation();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetShowIsDonation", "8f6bd1fe-419d-4923-84fc-ccbe02df5c78"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetShowIsDonation")){
// o_Show = ShowIsDonationSwitch()
result.outParamo_Show=(await Functions.ActionShowIsDonationSwitch(requestContext,cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_Show = result.outParamo_Show;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Show;
}
public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveServiceTypeEXP1 = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveServiceTypeEXP1 = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "a949482b-71ab-4de6-8c5f-d8886958f04b"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetSettings")){
// o_IsActiveServiceTypeEXP1 = IsActiveDEV_ServiceTypeEXP1
result.outParamo_IsActiveServiceTypeEXP1=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_ServiceTypeEXP1])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveServiceTypeEXP1 = result.outParamo_IsActiveServiceTypeEXP1;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveServiceTypeEXP1;
}
public class lcvGetRequisitionFiles : VarsBag {
public RL_bb2966aa0324244d136f889c366ee0f8 queryResGetRequisitionForeignResidenceFile_outParamList = new RL_bb2966aa0324244d136f889c366ee0f8();
public long queryResGetRequisitionForeignResidenceFile_outParamCount = 0L;

public RL_0b64a36c63b61ccaf400e29784570ef4 queryResGetRequisitionFinanceFile_outParamList = new RL_0b64a36c63b61ccaf400e29784570ef4();
public long queryResGetRequisitionFinanceFile_outParamCount = 0L;

public lcvGetRequisitionFiles() {
}
}
public class lcoGetRequisitionFiles : VarsBag {
public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_FinanceAuthorization = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ProofOfForeignResidence = new ST_26b16bea631cbd94cf555acb5c7a4be3Structure();

public lcoGetRequisitionFiles() {
}
}
/// <summary>
/// Action <code>GetRequisitionFiles</code> that represents the Service Studio action
///  <code>GetRequisitionFiles</code> <p> Description: Data Action that fetchs Requisition Files.</p>
/// </summary>
public async Task<(ST_26b16bea631cbd94cf555acb5c7a4be3Structure,ST_26b16bea631cbd94cf555acb5c7a4be3Structure)> DataActionGetRequisitionFiles(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_FinanceAuthorization = default;
ST_26b16bea631cbd94cf555acb5c7a4be3Structure outParamo_ProofOfForeignResidence = default;
lcoGetRequisitionFiles result = new lcoGetRequisitionFiles();
lcvGetRequisitionFiles localVars = new lcvGetRequisitionFiles();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitionFiles", "b5c234d2-fe19-4d90-a9c9-12b17d659288"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetRequisitionFiles")){
// Query datasetGetRequisitionFinanceFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionFinanceFile_maxRecords = 1;
if (datasetGetRequisitionFinanceFile_maxRecords < 1) datasetGetRequisitionFinanceFile_maxRecords = 1;
int datasetGetRequisitionFinanceFile_startIndex = 0;(localVars.queryResGetRequisitionFinanceFile_outParamList,localVars.queryResGetRequisitionFinanceFile_outParamCount) = await FuncDataActionGetRequisitionFiles.datasetGetRequisitionFinanceFile(requestContext,datasetGetRequisitionFinanceFile_maxRecords,datasetGetRequisitionFinanceFile_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_RequisitionId,cancellationToken);

// Query datasetGetRequisitionForeignResidenceFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRequisitionForeignResidenceFile_maxRecords = 1;
if (datasetGetRequisitionForeignResidenceFile_maxRecords < 1) datasetGetRequisitionForeignResidenceFile_maxRecords = 1;
int datasetGetRequisitionForeignResidenceFile_startIndex = 0;(localVars.queryResGetRequisitionForeignResidenceFile_outParamList,localVars.queryResGetRequisitionForeignResidenceFile_outParamCount) = await FuncDataActionGetRequisitionFiles.datasetGetRequisitionForeignResidenceFile(requestContext,datasetGetRequisitionForeignResidenceFile_maxRecords,datasetGetRequisitionForeignResidenceFile_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_RequisitionId,cancellationToken);

// o_FinanceAuthorization = GetRequisitionFinanceFile.List.Current
result.outParamo_FinanceAuthorization=(await RecordUtils.ConvertAsync(localVars.queryResGetRequisitionFinanceFile_outParamList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_818bd4b46f7dc615b92986d5f58cbcb9 source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFileFinance;
target.ssRequisitionFile = source.ssENRequisitionFile2Finance;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));

// o_ProofOfForeignResidence = GetRequisitionForeignResidenceFile.List.Current
result.outParamo_ProofOfForeignResidence=(await RecordUtils.ConvertAsync(localVars.queryResGetRequisitionForeignResidenceFile_outParamList.CurrentRec, new ST_26b16bea631cbd94cf555acb5c7a4be3Structure(), async (RC_ac566b5b63768f933fd7207ce4399046 source, ST_26b16bea631cbd94cf555acb5c7a4be3Structure target, CancellationToken cancellationToken) => {
target.ssRequisitionContractFile = source.ssENRequisitionContractFileForeignResidence;
target.ssRequisitionFile = source.ssENRequisitionFile2ForeignResidence;
target.ssBinary = BuiltInFunction.NullBinary ();
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamo_FinanceAuthorization = result.outParamo_FinanceAuthorization;
outParamo_ProofOfForeignResidence = result.outParamo_ProofOfForeignResidence;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_FinanceAuthorization,outParamo_ProofOfForeignResidence);
}
public class lcvGetUserApplicationRoles : VarsBag {
public Actions.lcoGetCanUploadInvoicesByRequisitionId resGetCanUploadInvoicesByRequisitionId =  new Actions.lcoGetCanUploadInvoicesByRequisitionId();
public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamListText = "";

public bool outParamIsCorporativoCxP = false;

public bool outParamCanUploadInvoices = false;

public string outParamTelcelDirectionsListText = "";

public bool outParamIsSegmentationCorporativo = false;

public long outParamCorporativoRegionId = 0L;

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,bool,bool,string,bool,long)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamListText = default;
bool outParamIsCorporativoCxP = default;
bool outParamCanUploadInvoices = default;
string outParamTelcelDirectionsListText = default;
bool outParamIsSegmentationCorporativo = default;
long outParamCorporativoRegionId = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "cd03034f-02db-4eb3-a7f9-838e0a69264a"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetUserApplicationRoles")){
// GetCanUploadInvoicesByRequisitionId
localVars.resGetCanUploadInvoicesByRequisitionId.outParami_CanUpload = await Actions.ActionGetCanUploadInvoicesByRequisitionId(requestContext,inParami_RequisitionId,cancellationToken);

// CanUploadInvoices = GetCanUploadInvoicesByRequisitionId.i_CanUpload
result.outParamCanUploadInvoices=localVars.resGetCanUploadInvoicesByRequisitionId.outParami_CanUpload;

// IsSegmentationCorporativo = IsSegmentationCorporativo
result.outParamIsSegmentationCorporativo=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo])));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// ListText = ListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamListText=((result.outParamListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId + ","
result.outParamTelcelDirectionsListText=(((result.outParamTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId))+",");
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamListText = result.outParamListText;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamCanUploadInvoices = result.outParamCanUploadInvoices;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamIsSegmentationCorporativo = result.outParamIsSegmentationCorporativo;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamListText,outParamIsCorporativoCxP,outParamCanUploadInvoices,outParamTelcelDirectionsListText,outParamIsSegmentationCorporativo,outParamCorporativoRegionId);
}
public class lcvGetPaymentMethodsBySupplierId : VarsBag {
/// <summary>
/// Variable <code>In</code> that represents the Service Studio Text <code>In</code> <p>Description:
///  </p>
/// </summary>
public string varLcIn = "('";

/// <summary>
/// Variable <code>Index</code> that represents the Service Studio Integer <code>Index</code>
///  <p>Description: </p>
/// </summary>
public int varLcIndex = 0;

/// <summary>
/// Variable <code>Length</code> that represents the Service Studio Integer <code>Length</code>
///  <p>Description: </p>
/// </summary>
public int varLcLength = 0;

public RL_0dcbcba642ca8b22e87f690d4de9d077 queryResGetPaymeentMethods_outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
public long queryResGetPaymeentMethods_outParamCount = 0L;

public lcvGetPaymentMethodsBySupplierId() {
}
}
public class lcoGetPaymentMethodsBySupplierId : VarsBag {
public RL_58f754227b79b8198980a29045fa5b11 outParamList = new RL_58f754227b79b8198980a29045fa5b11();

public lcoGetPaymentMethodsBySupplierId() {
}
}
/// <summary>
/// Action <code>GetPaymentMethodsBySupplierId</code> that represents the Service Studio action
///  <code>GetPaymentMethodsBySupplierId</code> <p> Description: </p>
/// </summary>
public async Task<RL_58f754227b79b8198980a29045fa5b11> DataActionGetPaymentMethodsBySupplierId(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_58f754227b79b8198980a29045fa5b11 outParamList = default;
lcoGetPaymentMethodsBySupplierId result = new lcoGetPaymentMethodsBySupplierId();
lcvGetPaymentMethodsBySupplierId localVars = new lcvGetPaymentMethodsBySupplierId();
ConectaProveedores_c_Requisitions_RequisitionDetail_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetPaymentMethodsBySupplierId", "cec22df2-f6e6-4413-ad70-27a270753e97"))
using (activitySource.CreateScreenDataActionActivity("RequisitionDetail", "GetPaymentMethodsBySupplierId")){
// Length = Length
localVars.varLcLength=BuiltInFunction.LengthSC (BuiltInFunction.Trim (ScreenDataSetGetSupplierDetailBySociety.List.CurrentRec.ssENSupplierDetail.ssViasdepago));
// Length
if(((localVars.varLcLength>0))) {
while ((!((localVars.varLcIndex==localVars.varLcLength)))) {
// In = In + If + Substr + "'"
localVars.varLcIn=(((localVars.varLcIn+(((localVars.varLcIn!="('")) ? (",'") : ("")))+BuiltInFunction.SubstrSC (ScreenDataSetGetSupplierDetailBySociety.List.CurrentRec.ssENSupplierDetail.ssViasdepago, localVars.varLcIndex, 1))+"'");

// Index = Index + 1
localVars.varLcIndex=(localVars.varLcIndex+1);
}

// In = In + ")"
localVars.varLcIn=(localVars.varLcIn+")");
// Query QueryGetPaymeentMethods
cancellationToken.ThrowIfCancellationRequested();
int QueryGetPaymeentMethods_maxRecords = 0;
int QueryGetPaymeentMethods_startIndex = 0;(localVars.queryResGetPaymeentMethods_outParamList,localVars.queryResGetPaymeentMethods_outParamCount) = await FuncDataActionGetPaymentMethodsBySupplierId.QueryGetPaymeentMethods(requestContext,QueryGetPaymeentMethods_maxRecords,QueryGetPaymeentMethods_startIndex,IterationMultiplicity.Multiple,localVars.varLcIn,cancellationToken);

// List = GetPaymeentMethods.List
result.outParamList=(await RL_58f754227b79b8198980a29045fa5b11.ConvertAsync(localVars.queryResGetPaymeentMethods_outParamList, new RL_58f754227b79b8198980a29045fa5b11(), async (RC_45208e184b912aa1623cdf19760e8e7e source, EN_4aece1e343005bf8bf23cf3be5a2cc9aEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}


    public static class FuncDataActionGetRequisitionContractData {

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetRequisitionFilesByIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionFilesById" aW9HCekFnEqyS_0TYwQ58A of Action "GetRequisitionContractData"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionContractData.GetRequisitionFilesById", "09476f69-05e9-4a9c-b24b-fd13630439f0");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetRequisitionContractData.GetRequisitionFilesById", "09476f69-05e9-4a9c-b24b-fd13630439f0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.v1PEATeOAkeAajRWRcydDQ/NodesNotShownInESpaceTree.aW9HCekFnEqyS_0TYwQ58A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile16\".\"id\" o0, \"enrequisitioncontractfile16\".\"requisitionid\" o1, \"enrequisitioncontractfile16\".\"requisitionfileid\" o2, \"enrequisitioncontractfile16\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfile16\".\"amount\"::numeric) o4, \"enrequisitioncontractfile16\".\"currencyid\" o5, \"enrequisitioncontractfile16\".\"deposittypeid\" o6, \"enrequisitioncontractfile16\".\"insurancetypeid\" o7, \"enrequisitioncontractfile16\".\"advancepaymenttypeid\" o8, \"enrequisitionfile213\".\"id\" o9, \"enrequisitionfile213\".\"filename\" o10, \"enrequisitionfile213\".\"vendor\" o11, \"enrequisitionfile213\".\"doc_type\" o12, \"enrequisitionfile213\".\"sap_object\" o13, \"enrequisitionfile213\".\"createdby\" o14, \"enrequisitionfile213\".\"createdon\" o15, \"enrequisitionfile213\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile16\" Inner JOIN {RequisitionFile2} \"enrequisitionfile213\" ON (\"enrequisitioncontractfile16\".\"requisitionfileid\" = \"enrequisitionfile213\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile16\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile16\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile16\".\"requisitionid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enrequisitioncontractfile16\".\"id\" ASC ");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionContractData.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionContractData.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetShowSelectReqPopup {
}
public static class FuncDataActionGetAdvWithoutInvoiceData {

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetRequisitionFilesByIdReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionFilesById" U6r11GaI00CirkwBKnYuew of Action "GetAdvWithoutInvoiceData"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetRequisitionFilesById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAdvWithoutInvoiceData.GetRequisitionFilesById", "d4f5aa53-8866-40d3-a2ae-4c012a762e7b");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAdvWithoutInvoiceData.GetRequisitionFilesById", "d4f5aa53-8866-40d3-a2ae-4c012a762e7b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.ThNzUcAeLE2pXjnEAWiEbQ/NodesNotShownInESpaceTree.U6r11GaI00CirkwBKnYuew, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile17\".\"id\" o0, \"enrequisitioncontractfile17\".\"requisitionid\" o1, \"enrequisitioncontractfile17\".\"requisitionfileid\" o2, \"enrequisitioncontractfile17\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfile17\".\"amount\"::numeric) o4, \"enrequisitioncontractfile17\".\"currencyid\" o5, \"enrequisitioncontractfile17\".\"deposittypeid\" o6, \"enrequisitioncontractfile17\".\"insurancetypeid\" o7, \"enrequisitioncontractfile17\".\"advancepaymenttypeid\" o8, \"enrequisitionfile214\".\"id\" o9, \"enrequisitionfile214\".\"filename\" o10, \"enrequisitionfile214\".\"vendor\" o11, \"enrequisitionfile214\".\"doc_type\" o12, \"enrequisitionfile214\".\"sap_object\" o13, \"enrequisitionfile214\".\"createdby\" o14, \"enrequisitionfile214\".\"createdon\" o15, \"enrequisitionfile214\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile17\" Inner JOIN {RequisitionFile2} \"enrequisitionfile214\" ON (\"enrequisitioncontractfile17\".\"requisitionfileid\" = \"enrequisitionfile214\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile17\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile17\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile17\".\"requisitionid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAdvWithoutInvoiceData.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionFilesByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAdvWithoutInvoiceData.GetRequisitionFilesById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetConfiguration {
}
public static class FuncDataActionGetAccountingData {

// Query Function "GetSubAccConcepts" GYPENP78f0O5k3Yb6lTMHA of Action "GetAccountingData"
public static async Task<(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5,long)> datasetGetSubAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetSubAccConcepts", "34c48319-fcfe-437f-b993-761bea54cc1c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetSubAccConcepts", "34c48319-fcfe-437f-b993-761bea54cc1c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.GYPENP78f0O5k3Yb6lTMHA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccconcepts5\".\"id\" o0, \"enrequisitionaccconcepts5\".\"requisitionaccountingid\" o1, \"enrequisitionaccconcepts5\".\"accountingdatatypeid\" o2, \"enrequisitionaccconcepts5\".\"numberofpayments\" o3, trim_scale(\"enrequisitionaccconcepts5\".\"amount\"::numeric) o4, \"enrequisitionaccconcepts5\".\"currencyid\" o5, \"enrequisitionaccconcepts5\".\"requisitionaccconceptsid\" o6, \"enrequisitionaccconcepts5\".\"isactive\" o7");
fromBuilder.Append(" FROM {RequisitionAccConcepts} \"enrequisitionaccconcepts5\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccConceptsId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts5\".\"requisitionaccconceptsid\" = @qpreRequisitionAccConceptsId) AND (\"enrequisitionaccconcepts5\".\"requisitionaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccConceptsId", DbType.Int64, qpreRequisitionAccConceptsId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts5\".\"requisitionaccconceptsid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetSubAccConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 _tmp = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetSubAccConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67eeb6e2fea6e1fe75fd0bc7d38796a5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetExchangeRateEvidenceReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetExchangeRateEvidence" 9mqbZtHEx0CUQ+Wvpwv+Mg of Action "GetAccountingData"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetExchangeRateEvidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetExchangeRateEvidence", "669b6af6-c4d1-40c7-9443-e5afa70bfe32");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetExchangeRateEvidence", "669b6af6-c4d1-40c7-9443-e5afa70bfe32", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.9mqbZtHEx0CUQ+Wvpwv+Mg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile18\".\"id\" o0, \"enrequisitioncontractfile18\".\"requisitionid\" o1, \"enrequisitioncontractfile18\".\"requisitionfileid\" o2, \"enrequisitioncontractfile18\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfile18\".\"amount\"::numeric) o4, \"enrequisitioncontractfile18\".\"currencyid\" o5, \"enrequisitioncontractfile18\".\"deposittypeid\" o6, \"enrequisitioncontractfile18\".\"insurancetypeid\" o7, \"enrequisitioncontractfile18\".\"advancepaymenttypeid\" o8, \"enrequisitionfile215\".\"id\" o9, \"enrequisitionfile215\".\"filename\" o10, \"enrequisitionfile215\".\"vendor\" o11, \"enrequisitionfile215\".\"doc_type\" o12, \"enrequisitionfile215\".\"sap_object\" o13, \"enrequisitionfile215\".\"createdby\" o14, \"enrequisitionfile215\".\"createdon\" o15, \"enrequisitionfile215\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile18\" Inner JOIN {RequisitionFile2} \"enrequisitionfile215\" ON (\"enrequisitioncontractfile18\".\"requisitionfileid\" = \"enrequisitionfile215\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile18\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile18\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile18\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile18\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("XZ874xvcQ0WEe9IcoUgjqw"))).ssId);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetExchangeRateEvidenceReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetExchangeRateEvidence.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetExchangeRateEvidenceReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetExchangeRateEvidence.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_dc345357879dcb92e41eacae4ac8926c> datasetGetREPSEReadDbAsync(RC_dc345357879dcb92e41eacae4ac8926c rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFile.Read( r, ref index);
rec.ssENRequisitionFile2.Read( r, ref index);
return rec;
}
// Query Function "GetREPSE" jq6fxV1m+kmNyK8+8gF4_A of Action "GetAccountingData"
public static async Task<(RL_dcf9165e080aea63f7a9b95efcf09ef4,long)> datasetGetREPSE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetREPSE", "c59fae8e-665d-49fa-8dc8-af3ef20178fc");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetREPSE", "c59fae8e-665d-49fa-8dc8-af3ef20178fc", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.jq6fxV1m+kmNyK8+8gF4_A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfile19\".\"id\" o0, \"enrequisitioncontractfile19\".\"requisitionid\" o1, \"enrequisitioncontractfile19\".\"requisitionfileid\" o2, \"enrequisitioncontractfile19\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfile19\".\"amount\"::numeric) o4, \"enrequisitioncontractfile19\".\"currencyid\" o5, \"enrequisitioncontractfile19\".\"deposittypeid\" o6, \"enrequisitioncontractfile19\".\"insurancetypeid\" o7, \"enrequisitioncontractfile19\".\"advancepaymenttypeid\" o8, \"enrequisitionfile216\".\"id\" o9, \"enrequisitionfile216\".\"filename\" o10, \"enrequisitionfile216\".\"vendor\" o11, \"enrequisitionfile216\".\"doc_type\" o12, \"enrequisitionfile216\".\"sap_object\" o13, \"enrequisitionfile216\".\"createdby\" o14, \"enrequisitionfile216\".\"createdon\" o15, \"enrequisitionfile216\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfile19\" Inner JOIN {RequisitionFile2} \"enrequisitionfile216\" ON (\"enrequisitioncontractfile19\".\"requisitionfileid\" = \"enrequisitionfile216\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfile19\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfile19\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfile19\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfile19\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("LV+AsPZoqky6GANkYowNLQ"))).ssId);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_dcf9165e080aea63f7a9b95efcf09ef4 outParamList = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetREPSEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetREPSE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_dcf9165e080aea63f7a9b95efcf09ef4 _tmp = new RL_dcf9165e080aea63f7a9b95efcf09ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetREPSEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetREPSE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_dcf9165e080aea63f7a9b95efcf09ef4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetMainAccConcept" qzvU0ZRXkkyD8obUgAv2DA of Action "GetAccountingData"
public static async Task<(RL_67eeb6e2fea6e1fe75fd0bc7d38796a5,long)> datasetGetMainAccConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetMainAccConcept", "d1d43bab-5794-4c92-83f2-86d4800bf60c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetMainAccConcept", "d1d43bab-5794-4c92-83f2-86d4800bf60c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.qzvU0ZRXkkyD8obUgAv2DA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccconcepts6\".\"id\" o0, \"enrequisitionaccconcepts6\".\"requisitionaccountingid\" o1, \"enrequisitionaccconcepts6\".\"accountingdatatypeid\" o2, \"enrequisitionaccconcepts6\".\"numberofpayments\" o3, trim_scale(\"enrequisitionaccconcepts6\".\"amount\"::numeric) o4, \"enrequisitionaccconcepts6\".\"currencyid\" o5, \"enrequisitionaccconcepts6\".\"requisitionaccconceptsid\" o6, \"enrequisitionaccconcepts6\".\"isactive\" o7");
fromBuilder.Append(" FROM {RequisitionAccConcepts} \"enrequisitionaccconcepts6\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccountingId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts6\".\"requisitionaccountingid\" = @qpreRequisitionAccountingId) AND (\"enrequisitionaccconcepts6\".\"requisitionaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccountingId", DbType.Int64, qpreRequisitionAccountingId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts6\".\"requisitionaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitionaccconcepts6\".\"accountingdatatypeid\" = ");
whereBuilder.Append(7
);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 outParamList = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetMainAccConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_67eeb6e2fea6e1fe75fd0bc7d38796a5 _tmp = new RL_67eeb6e2fea6e1fe75fd0bc7d38796a5();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetMainAccConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_67eeb6e2fea6e1fe75fd0bc7d38796a5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetRequisitionAccoutingByRequisitionId" 0jA85VYMMEy5kuCM3a7tVw of Action "GetAccountingData"
public static async Task<(RL_991db829ff4e7fe204109f106256f023,long)> datasetGetRequisitionAccoutingByRequisitionId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetRequisitionAccoutingByRequisitionId", "e53c30d2-0c56-4c30-b992-e08cddaeed57");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetRequisitionAccoutingByRequisitionId", "e53c30d2-0c56-4c30-b992-e08cddaeed57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.0jA85VYMMEy5kuCM3a7tVw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitionaccounting7\".\"id\" o0, \"enrequisitionaccounting7\".\"requisitionid\" o1, \"enrequisitionaccounting7\".\"hasestim_equal_agrepaym_depr\" o2, \"enrequisitionaccounting7\".\"hassettlement_depr\" o3, \"enrequisitionaccounting7\".\"hascreditnote_depr\" o4, \"enrequisitionaccounting7\".\"hasvoucher_depr\" o5, \"enrequisitionaccounting7\".\"hasspecialpostdeliveryauth\" o6, \"enrequisitionaccounting7\".\"specialpostdeliveryauthid\" o7, trim_scale(\"enrequisitionaccounting7\".\"amount_deprec\"::numeric) o8, \"enrequisitionaccounting7\".\"currencyid_deprec\" o9, \"enrequisitionaccounting7\".\"paymentmethodid_deprec\" o10, \"enrequisitionaccounting7\".\"paymenttermid_deprec\" o11, trim_scale(\"enrequisitionaccounting7\".\"negociatedexchangerateacc\"::numeric) o12, \"enrequisitionaccounting7\".\"exchangeratecomment\" o13, \"enrequisitionaccounting7\".\"evidencefileid\" o14, \"enrequisitionaccounting7\".\"hascontract\" o15, \"enrequisitionaccounting7\".\"hasrepse\" o16, \"enrequisitionaccounting7\".\"haspaymentsupplement\" o17, \"enrequisitionaccounting7\".\"hasnoticeofpaymentsuspension\" o18");
fromBuilder.Append(" FROM {RequisitionAccounting} \"enrequisitionaccounting7\"");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionId != 0) {
whereBuilder.Append("((\"enrequisitionaccounting7\".\"requisitionid\" = @qpreRequisitionId) AND (\"enrequisitionaccounting7\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionId", DbType.Int64, qpreRequisitionId);
} else {
whereBuilder.Append("(\"enrequisitionaccounting7\".\"requisitionid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_991db829ff4e7fe204109f106256f023 outParamList = new RL_991db829ff4e7fe204109f106256f023();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetRequisitionAccoutingByRequisitionId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_991db829ff4e7fe204109f106256f023 _tmp = new RL_991db829ff4e7fe204109f106256f023();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetRequisitionAccoutingByRequisitionId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_991db829ff4e7fe204109f106256f023)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_f80fde4acf9a7dc465a1d535c05dfb8e> datasetGetRemainingReadDbAsync(RC_f80fde4acf9a7dc465a1d535c05dfb8e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENRequisitionAccConcepts.Read( r, ref index);
return rec;
}
// Query Function "GetRemaining" +AGh+F1Hw0iMIuDZAGXmJw of Action "GetAccountingData"
public static async Task<(RL_7c236018492d50b3625a5b0d981eb4eb,long)> datasetGetRemaining(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreRequisitionAccConcepts_RequisitionAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetAccountingData.GetRemaining", "f8a101f8-475d-48c3-8c22-e0d90065e627");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetAccountingData.GetRemaining", "f8a101f8-475d-48c3-8c22-e0d90065e627", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.gQwFYtNnQ02ncnfkkdF8sQ/NodesNotShownInESpaceTree.+AGh+F1Hw0iMIuDZAGXmJw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype13\".\"id\" o0, \"enaccountingdatatype13\".\"label\" o1, \"enaccountingdatatype13\".\"order\" o2, \"enaccountingdatatype13\".\"is_active\" o3, \"enaccountingdatatype13\".\"isestim_equal_agreed\" o4, \"enrequisitionaccconcepts7\".\"id\" o5, \"enrequisitionaccconcepts7\".\"requisitionaccountingid\" o6, \"enrequisitionaccconcepts7\".\"accountingdatatypeid\" o7, \"enrequisitionaccconcepts7\".\"numberofpayments\" o8, trim_scale(\"enrequisitionaccconcepts7\".\"amount\"::numeric) o9, \"enrequisitionaccconcepts7\".\"currencyid\" o10, \"enrequisitionaccconcepts7\".\"requisitionaccconceptsid\" o11, \"enrequisitionaccconcepts7\".\"isactive\" o12");
fromBuilder.Append(" FROM ({RequisitionAccConcepts} \"enrequisitionaccconcepts7\" Left JOIN {AccountingDataType} \"enaccountingdatatype13\" ON (\"enrequisitionaccconcepts7\".\"accountingdatatypeid\" = \"enaccountingdatatype13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpreRequisitionAccConcepts_RequisitionAccountingId != 0) {
whereBuilder.Append("((\"enrequisitionaccconcepts7\".\"requisitionaccountingid\" = @qpreRequisitionAccConcepts_RequisitionAccountingId) AND (\"enrequisitionaccconcepts7\".\"requisitionaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionAccConcepts_RequisitionAccountingId", DbType.Int64, qpreRequisitionAccConcepts_RequisitionAccountingId);
} else {
whereBuilder.Append("(\"enrequisitionaccconcepts7\".\"requisitionaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND ((\"enrequisitionaccconcepts7\".\"requisitionaccconceptsid\" IS NULL) AND (\"enrequisitionaccconcepts7\".\"accountingdatatypeid\" <> ");
whereBuilder.Append(7
);
whereBuilder.Append(")) AND (\"enaccountingdatatype13\".\"id\" <> ");
whereBuilder.Append(8
);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_7c236018492d50b3625a5b0d981eb4eb outParamList = new RL_7c236018492d50b3625a5b0d981eb4eb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRemainingReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetRemaining.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_7c236018492d50b3625a5b0d981eb4eb _tmp = new RL_7c236018492d50b3625a5b0d981eb4eb();
_tmp.AlternateReadDbMethodAsync = datasetGetRemainingReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetAccountingData.GetRemaining.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_7c236018492d50b3625a5b0d981eb4eb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetShowIsDonation {
}
public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetRequisitionFiles {

private static async Task<RC_ac566b5b63768f933fd7207ce4399046> datasetGetRequisitionForeignResidenceFileReadDbAsync(RC_ac566b5b63768f933fd7207ce4399046 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFileForeignResidence.Read( r, ref index);
rec.ssENRequisitionFile2ForeignResidence.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionForeignResidenceFile" FL_RUNyIv0iyDnuQ8GT26w of Action "GetRequisitionFiles"
public static async Task<(RL_bb2966aa0324244d136f889c366ee0f8,long)> datasetGetRequisitionForeignResidenceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionForeignResidenceFile", "50d1bf14-88dc-48bf-b20e-7b90f064f6eb");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionForeignResidenceFile", "50d1bf14-88dc-48bf-b20e-7b90f064f6eb", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.0jTCtRn+kE2pyRKxfWWSiA/NodesNotShownInESpaceTree.FL_RUNyIv0iyDnuQ8GT26w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfileforeignresidence\".\"id\" o0, \"enrequisitioncontractfileforeignresidence\".\"requisitionid\" o1, \"enrequisitioncontractfileforeignresidence\".\"requisitionfileid\" o2, \"enrequisitioncontractfileforeignresidence\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfileforeignresidence\".\"amount\"::numeric) o4, \"enrequisitioncontractfileforeignresidence\".\"currencyid\" o5, \"enrequisitioncontractfileforeignresidence\".\"deposittypeid\" o6, \"enrequisitioncontractfileforeignresidence\".\"insurancetypeid\" o7, \"enrequisitioncontractfileforeignresidence\".\"advancepaymenttypeid\" o8, \"enrequisitionfile2foreignresidence\".\"id\" o9, \"enrequisitionfile2foreignresidence\".\"filename\" o10, \"enrequisitionfile2foreignresidence\".\"vendor\" o11, \"enrequisitionfile2foreignresidence\".\"doc_type\" o12, \"enrequisitionfile2foreignresidence\".\"sap_object\" o13, \"enrequisitionfile2foreignresidence\".\"createdby\" o14, \"enrequisitionfile2foreignresidence\".\"createdon\" o15, \"enrequisitionfile2foreignresidence\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfileforeignresidence\" Left JOIN {RequisitionFile2} \"enrequisitionfile2foreignresidence\" ON (\"enrequisitioncontractfileforeignresidence\".\"requisitionfileid\" = \"enrequisitionfile2foreignresidence\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfileforeignresidence\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfileforeignresidence\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfileforeignresidence\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfileforeignresidence\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"))).ssId);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_bb2966aa0324244d136f889c366ee0f8 outParamList = new RL_bb2966aa0324244d136f889c366ee0f8();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionForeignResidenceFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionForeignResidenceFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bb2966aa0324244d136f889c366ee0f8 _tmp = new RL_bb2966aa0324244d136f889c366ee0f8();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionForeignResidenceFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionForeignResidenceFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bb2966aa0324244d136f889c366ee0f8)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_818bd4b46f7dc615b92986d5f58cbcb9> datasetGetRequisitionFinanceFileReadDbAsync(RC_818bd4b46f7dc615b92986d5f58cbcb9 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisitionContractFileFinance.Read( r, ref index);
rec.ssENRequisitionFile2Finance.Read( r, ref index);
return rec;
}
// Query Function "GetRequisitionFinanceFile" A1XGXUdCTkytP7+f3JHqdg of Action "GetRequisitionFiles"
public static async Task<(RL_0b64a36c63b61ccaf400e29784570ef4,long)> datasetGetRequisitionFinanceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qpreRequisitionContractFile_RequisitionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionFinanceFile", "5dc65503-4247-4c4e-ad3f-bf9fdc91ea76");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionFinanceFile", "5dc65503-4247-4c4e-ad3f-bf9fdc91ea76", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.0jTCtRn+kE2pyRKxfWWSiA/NodesNotShownInESpaceTree.A1XGXUdCTkytP7+f3JHqdg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enrequisitioncontractfilefinance\".\"id\" o0, \"enrequisitioncontractfilefinance\".\"requisitionid\" o1, \"enrequisitioncontractfilefinance\".\"requisitionfileid\" o2, \"enrequisitioncontractfilefinance\".\"contractfiletypeid\" o3, trim_scale(\"enrequisitioncontractfilefinance\".\"amount\"::numeric) o4, \"enrequisitioncontractfilefinance\".\"currencyid\" o5, \"enrequisitioncontractfilefinance\".\"deposittypeid\" o6, \"enrequisitioncontractfilefinance\".\"insurancetypeid\" o7, \"enrequisitioncontractfilefinance\".\"advancepaymenttypeid\" o8, \"enrequisitionfile2finance\".\"id\" o9, \"enrequisitionfile2finance\".\"filename\" o10, \"enrequisitionfile2finance\".\"vendor\" o11, \"enrequisitionfile2finance\".\"doc_type\" o12, \"enrequisitionfile2finance\".\"sap_object\" o13, \"enrequisitionfile2finance\".\"createdby\" o14, \"enrequisitionfile2finance\".\"createdon\" o15, \"enrequisitionfile2finance\".\"storageid\" o16");
fromBuilder.Append(" FROM ({RequisitionContractFile} \"enrequisitioncontractfilefinance\" Left JOIN {RequisitionFile2} \"enrequisitionfile2finance\" ON (\"enrequisitioncontractfilefinance\".\"requisitionfileid\" = \"enrequisitionfile2finance\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qpreRequisitionContractFile_RequisitionId != 0) {
whereBuilder.Append("((\"enrequisitioncontractfilefinance\".\"requisitionid\" = @qpreRequisitionContractFile_RequisitionId) AND (\"enrequisitioncontractfilefinance\".\"requisitionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisitionContractFile_RequisitionId", DbType.Int64, qpreRequisitionContractFile_RequisitionId);
} else {
whereBuilder.Append("(\"enrequisitioncontractfilefinance\".\"requisitionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enrequisitioncontractfilefinance\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("V4MNsdNOWkel1Y9wcSEz8Q"))).ssId);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b64a36c63b61ccaf400e29784570ef4 outParamList = new RL_0b64a36c63b61ccaf400e29784570ef4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRequisitionFinanceFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionFinanceFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b64a36c63b61ccaf400e29784570ef4 _tmp = new RL_0b64a36c63b61ccaf400e29784570ef4();
_tmp.AlternateReadDbMethodAsync = datasetGetRequisitionFinanceFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetRequisitionFiles.GetRequisitionFinanceFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b64a36c63b61ccaf400e29784570ef4)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetUserApplicationRoles {

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" 4nVFwQxwE0uKf8elXlXeBw of Action "GetUserApplicationRoles"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetSegmentAccGroupTelcelDirectionsByDepartment", "c14575e2-700c-4b13-8a7f-c7a55e55de07");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetSegmentAccGroupTelcelDirectionsByDepartment", "c14575e2-700c-4b13-8a7f-c7a55e55de07", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.TwMDzdsCs06n+YOOCmkmSg/NodesNotShownInESpaceTree.4nVFwQxwE0uKf8elXlXeBw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir8\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup8\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir8\" ON (\"ensegmentaccgroup8\".\"id\" = \"ensegmentaccgrouptelceldir8\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup8\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup8\".\"isactive\" = 1)");
sqlCmd.CreateParameterWithoutReplacements("@qpteSegmentAccGroup_GroupName", DbType.String, qpteSegmentAccGroup_GroupName);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_4b6f9359ce9887bc6f37c96ecf62266d outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_4b6f9359ce9887bc6f37c96ecf62266d _tmp = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
_tmp.AlternateReadDbMethodAsync = datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_4b6f9359ce9887bc6f37c96ecf62266d)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_6d4a92ad9e5239e9c12dd070f5b17d69> datasetGetRoleConceptReadDbAsync(RC_6d4a92ad9e5239e9c12dd070f5b17d69 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENEntraRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRoleConcept.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
return rec;
}
// Query Function "GetRoleConcept" MdeK9O+_80+L+0Em4Jm4lg of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetRoleConcept", "f48ad731-bfef-4ff3-8bfb-4126e099b896");
using var queryActivity = activitySource.CreateAggregateQueryActivity("c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetRoleConcept", "f48ad731-bfef-4ff3-8bfb-4126e099b896", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.EOyrTn+7d0GbcWjAcO3kyw/NodesShownInESpaceTree.KyDz5SB9_0+qwINHTzZ4mQ/DataActions.TwMDzdsCs06n+YOOCmkmSg/NodesNotShownInESpaceTree.MdeK9O+_80+L+0Em4Jm4lg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole65\".\"code\" o1, \"enapplicationrole65\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole65\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion145\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept23\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal115\" Inner JOIN {User} \"enuser185\" ON (\"enuser_extended_internal115\".\"id\" = \"enuser185\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole60\" ON (\"enuser_extended_internal115\".\"jobtitle\" = \"enentrarole60\".\"rolename\"))  Left JOIN {Region} \"enregion145\" ON (\"enuser_extended_internal115\".\"regionid\" = \"enregion145\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept23\" ON (\"enentrarole60\".\"id\" = \"enroleconcept23\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole65\" ON (\"enroleconcept23\".\"applicationroleid\" = \"enapplicationrole65\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser185\".\"id\" = @qpusUser_Id) AND (\"enuser185\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser185\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept23\".\"conceptid\" = ");
whereBuilder.Append(3
);
whereBuilder.Append(")");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_721bdfcca4a4edbce82baece8dfe837b outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true});
opt[2] = new BitArray(new bool[] {true, false, false, true, true, false, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_721bdfcca4a4edbce82baece8dfe837b _tmp = new RL_721bdfcca4a4edbce82baece8dfe837b();
_tmp.AlternateReadDbMethodAsync = datasetGetRoleConceptReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_721bdfcca4a4edbce82baece8dfe837b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}
}
public static class FuncDataActionGetPaymentMethodsBySupplierId {

// Query Function "GetPaymeentMethods" JMpTZsQxXkakOD0VZt3HTA of Action "GetPaymentMethodsBySupplierId"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> QueryGetPaymeentMethods(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptePayment_Methods,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("c_Requisitions.RequisitionDetail.GetPaymentMethodsBySupplierId.GetPaymeentMethods", "6653ca24-31c4-465e-a438-3d1566ddc74c");
using var queryActivity = activitySource.CreateSqlQueryActivity("c_Requisitions.RequisitionDetail.GetPaymentMethodsBySupplierId.GetPaymeentMethods", "6653ca24-31c4-465e-a438-3d1566ddc74c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityPaymentMethods = AppUtils.Instance.RuntimeEntityReplace("PaymentMethods");
string sql = "";
string advSql = "SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"id\"") + ", \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"externalid\"") + " || ' - ' ||  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"description\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"externalid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"isfcp\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"createdon\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"createdby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"updatedon\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"isactive\"") + " \nfrom  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,"") + " where  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityPaymentMethods,".\"externalid\"") + " in  " + BaseAppUtils.ReplaceEntityReferencesInParameter(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, AppUtils.Instance.ReplaceAttributeReferences(requestContext,qptePayment_Methods)) + "";
advSql = BaseAppUtils.ReplaceEntityIdentifiers(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers,advSql);
advSql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
AppUtils.Instance.CheckReadOnlyEntityReferences(advSql);
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0dcbcba642ca8b22e87f690d4de9d077 outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query c_Requisitions.RequisitionDetail.GetPaymentMethodsBySupplierId.GetPaymeentMethods.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0dcbcba642ca8b22e87f690d4de9d077 _tmp = new RL_0dcbcba642ca8b22e87f690d4de9d077();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query c_Requisitions.RequisitionDetail.GetPaymentMethodsBySupplierId.GetPaymeentMethods.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dcbcba642ca8b22e87f690d4de9d077)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetPaymeentMethods in GetPaymentMethodsBySupplierId in RequisitionDetail in c_Requisitions in ConectaProveedores (SELECT {PaymentMethods}.[Id],          {PaymentMethods}.[ExternalId] || ' - ' || {PaymentMethods}.[Description],  {PaymentMethods}.[ExternalId],  {PaymentMethods}.[IsFCP],  {PaymentMethods}.[CreatedOn],  {PaymentMethods}.[CreatedBy],  {PaymentMethods}.[UpdatedOn],  {PaymentMethods}.[UpdatedBy],  {PaymentMethods}.[IsActive]  from {PaymentMethods} where {PaymentMethods}.[ExternalId] in @Payment_Methods): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPaymeentMethods in GetPaymentMethodsBySupplierId in RequisitionDetail in c_Requisitions in ConectaProveedores (SELECT {PaymentMethods}.[Id],          {PaymentMethods}.[ExternalId] || ' - ' || {PaymentMethods}.[Description],  {PaymentMethods}.[ExternalId],  {PaymentMethods}.[IsFCP],  {PaymentMethods}.[CreatedOn],  {PaymentMethods}.[CreatedBy],  {PaymentMethods}.[UpdatedOn],  {PaymentMethods}.[UpdatedBy],  {PaymentMethods}.[IsActive]  from {PaymentMethods} where {PaymentMethods}.[ExternalId] in @Payment_Methods): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetPaymeentMethods in GetPaymentMethodsBySupplierId in RequisitionDetail in c_Requisitions in ConectaProveedores (SELECT {PaymentMethods}.[Id],          {PaymentMethods}.[ExternalId] || ' - ' || {PaymentMethods}.[Description],  {PaymentMethods}.[ExternalId],  {PaymentMethods}.[IsFCP],  {PaymentMethods}.[CreatedOn],  {PaymentMethods}.[CreatedBy],  {PaymentMethods}.[UpdatedOn],  {PaymentMethods}.[UpdatedBy],  {PaymentMethods}.[IsActive]  from {PaymentMethods} where {PaymentMethods}.[ExternalId] in @Payment_Methods): " + aqExcep.Message));
}
}
}
}


}
