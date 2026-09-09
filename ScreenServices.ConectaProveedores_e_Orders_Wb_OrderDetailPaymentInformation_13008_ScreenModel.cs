using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel).Namespace);

    public long inParami_OrderId;
public DateTime inParami_ForceRefresh;
public bool varLcl_CanEditForm;
public RL_3d745491e03d6d19ccc0e1b33a371ccc varLcFilesList;
public bool varLcl_FormIsValid;
public RL_9d3b4c4e80b371ac0dc01854afca347a varLcl_OrderRequestFiles;
public bool varLcShowOrderReject_Popup;
public string varLcDependentFoliosText;
public string varLcl_RequestDocsErrorMessage;
public bool varLcl_IsValidReqDoc;
public bool varLcl_CanUploadContract;
public bool varLcl_IsSavingContractFile;
public bool varLcl_IsMissingEstimEqualAgFiniquito;
public AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals;
public AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes;
public AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes;
public AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations;
public AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> ScreenDataSetGetContractStatuses;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition;
public AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> ScreenDataSetGetOrderMainById;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages;
public AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> ScreenDataSetGetOrderRetentionTypes;
public AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes;
public AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies;
public AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions;
public AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays;
public AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> ScreenDataSetGetOrderMainItemsByOrderMainId;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes;
public AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods;
public AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetOrderFilesList_Model varLcGetOrderFilesList;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model varLcGetPaymentTermSpecial;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetAccountingData_Model varLcGetAccountingData;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetOrderContractData_Model varLcGetOrderContractData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel(long inParami_OrderId, DateTime inParami_ForceRefresh, bool varLcl_CanEditForm, RL_3d745491e03d6d19ccc0e1b33a371ccc varLcFilesList, bool varLcl_FormIsValid, RL_9d3b4c4e80b371ac0dc01854afca347a varLcl_OrderRequestFiles, bool varLcShowOrderReject_Popup, string varLcDependentFoliosText, string varLcl_RequestDocsErrorMessage, bool varLcl_IsValidReqDoc, bool varLcl_CanUploadContract, bool varLcl_IsSavingContractFile, bool varLcl_IsMissingEstimEqualAgFiniquito, AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals, AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes, AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes, AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations, AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> ScreenDataSetGetContractStatuses, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers, AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition, AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> ScreenDataSetGetOrderMainById, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages, AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> ScreenDataSetGetOrderRetentionTypes, AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes, AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies, AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions, AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays, AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> ScreenDataSetGetOrderMainItemsByOrderMainId, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes, AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods, AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetOrderFilesList_Model varLcGetOrderFilesList, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetPaymentTermSpecial_Model varLcGetPaymentTermSpecial, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetAccountingData_Model varLcGetAccountingData, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_DataActionGetOrderContractData_Model varLcGetOrderContractData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "i_ForceRefresh", "l_CanEditForm", "FilesList", "l_FormIsValid", "l_OrderRequestFiles", "ShowOrderReject_Popup", "DependentFoliosText", "l_RequestDocsErrorMessage", "l_IsValidReqDoc", "l_CanUploadContract", "l_IsSavingContractFile", "l_IsMissingEstimEqualAgFiniquito", "GetSpecialApprovals", "GetAccountingDataTypes", "GetAdvancedPaymentTypes", "GetSpecialPostDeliveryAuthorizations", "GetContractStatuses", "GetProjectAssetServiceOtro", "GetSuppliers", "GetBusinessValueSubcategoriesByCategoryId", "GetSupplierByRequisition", "GetOrderMainById", "GetProjectAssetServices", "GetInvoiceUsages", "GetOrderRetentionTypes", "GetBusinessValueCategories", "GetPaymentTerms", "GetInsuranceTypes", "GetFrequencies", "GetPaymentOptions", "GetPaymentWays", "GetOrderMainItemsByOrderMainId", "GetCurrencies", "GetDepositTypes", "GetPaymentMethods", "GetRejectComment", "GetOrderFilesList", "GetPaymentTermSpecial", "GetAccountingData", "GetOrderContractData", "ClientVars"}, new string[] {"inParami_OrderId", "inParami_ForceRefresh", "varLcl_CanEditForm", "varLcFilesList", "varLcl_FormIsValid", "varLcl_OrderRequestFiles", "varLcShowOrderReject_Popup", "varLcDependentFoliosText", "varLcl_RequestDocsErrorMessage", "varLcl_IsValidReqDoc", "varLcl_CanUploadContract", "varLcl_IsSavingContractFile", "varLcl_IsMissingEstimEqualAgFiniquito", "ScreenDataSetGetSpecialApprovals", "ScreenDataSetGetAccountingDataTypes", "ScreenDataSetGetAdvancedPaymentTypes", "ScreenDataSetGetSpecialPostDeliveryAuthorizations", "ScreenDataSetGetContractStatuses", "ScreenDataSetGetProjectAssetServiceOtro", "ScreenDataSetGetSuppliers", "ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "ScreenDataSetGetSupplierByRequisition", "ScreenDataSetGetOrderMainById", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetInvoiceUsages", "ScreenDataSetGetOrderRetentionTypes", "ScreenDataSetGetBusinessValueCategories", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetInsuranceTypes", "ScreenDataSetGetFrequencies", "ScreenDataSetGetPaymentOptions", "ScreenDataSetGetPaymentWays", "ScreenDataSetGetOrderMainItemsByOrderMainId", "ScreenDataSetGetCurrencies", "ScreenDataSetGetDepositTypes", "ScreenDataSetGetPaymentMethods", "ScreenDataSetGetRejectComment", "varLcGetOrderFilesList", "varLcGetPaymentTermSpecial", "varLcGetAccountingData", "varLcGetOrderContractData", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.inParami_ForceRefresh = inParami_ForceRefresh;
this.varLcl_CanEditForm = varLcl_CanEditForm;
this.varLcFilesList = varLcFilesList;
this.varLcl_FormIsValid = varLcl_FormIsValid;
this.varLcl_OrderRequestFiles = varLcl_OrderRequestFiles;
this.varLcShowOrderReject_Popup = varLcShowOrderReject_Popup;
this.varLcDependentFoliosText = varLcDependentFoliosText;
this.varLcl_RequestDocsErrorMessage = varLcl_RequestDocsErrorMessage;
this.varLcl_IsValidReqDoc = varLcl_IsValidReqDoc;
this.varLcl_CanUploadContract = varLcl_CanUploadContract;
this.varLcl_IsSavingContractFile = varLcl_IsSavingContractFile;
this.varLcl_IsMissingEstimEqualAgFiniquito = varLcl_IsMissingEstimEqualAgFiniquito;
this.ScreenDataSetGetSpecialApprovals = ScreenDataSetGetSpecialApprovals;
this.ScreenDataSetGetAccountingDataTypes = ScreenDataSetGetAccountingDataTypes;
this.ScreenDataSetGetAdvancedPaymentTypes = ScreenDataSetGetAdvancedPaymentTypes;
this.ScreenDataSetGetSpecialPostDeliveryAuthorizations = ScreenDataSetGetSpecialPostDeliveryAuthorizations;
this.ScreenDataSetGetContractStatuses = ScreenDataSetGetContractStatuses;
this.ScreenDataSetGetProjectAssetServiceOtro = ScreenDataSetGetProjectAssetServiceOtro;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId = ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
this.ScreenDataSetGetSupplierByRequisition = ScreenDataSetGetSupplierByRequisition;
this.ScreenDataSetGetOrderMainById = ScreenDataSetGetOrderMainById;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetInvoiceUsages = ScreenDataSetGetInvoiceUsages;
this.ScreenDataSetGetOrderRetentionTypes = ScreenDataSetGetOrderRetentionTypes;
this.ScreenDataSetGetBusinessValueCategories = ScreenDataSetGetBusinessValueCategories;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetInsuranceTypes = ScreenDataSetGetInsuranceTypes;
this.ScreenDataSetGetFrequencies = ScreenDataSetGetFrequencies;
this.ScreenDataSetGetPaymentOptions = ScreenDataSetGetPaymentOptions;
this.ScreenDataSetGetPaymentWays = ScreenDataSetGetPaymentWays;
this.ScreenDataSetGetOrderMainItemsByOrderMainId = ScreenDataSetGetOrderMainItemsByOrderMainId;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetDepositTypes = ScreenDataSetGetDepositTypes;
this.ScreenDataSetGetPaymentMethods = ScreenDataSetGetPaymentMethods;
this.ScreenDataSetGetRejectComment = ScreenDataSetGetRejectComment;
this.varLcGetOrderFilesList = varLcGetOrderFilesList;
this.varLcGetPaymentTermSpecial = varLcGetPaymentTermSpecial;
this.varLcGetAccountingData = varLcGetAccountingData;
this.varLcGetOrderContractData = varLcGetOrderContractData;
this.clientVariables = clientVariables;
}



    
// Query Function "GetSpecialApprovals" WgoKAcsot0i6MFplQOh5qw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_0204de281fa136fb826199f876159fe4,long)> datasetGetSpecialApprovals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialApprovals", "010a0a5a-28cb-48b7-ba30-5a6540e879ab");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialApprovals");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.WgoKAcsot0i6MFplQOh5qw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialapproval1\".\"id\" o0, \"enspecialapproval1\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialApproval} \"enspecialapproval1\"");
whereBuilder.Append(" WHERE (\"enspecialapproval1\".\"is_active\" = 1)");
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
RL_0204de281fa136fb826199f876159fe4 outParamList = new RL_0204de281fa136fb826199f876159fe4();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialApprovals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0204de281fa136fb826199f876159fe4 _tmp = new RL_0204de281fa136fb826199f876159fe4();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialApprovals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0204de281fa136fb826199f876159fe4)_tmp;
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

// Query Function "GetAccountingDataTypes" TtnQBxQNCE6XQuNkifc_Pw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingDataTypes", "07d0d94e-0d14-4e08-9742-e36489f73f3f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingDataTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.TtnQBxQNCE6XQuNkifc_Pw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype10\".\"id\" o0, \"enaccountingdatatype10\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype10\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype10\".\"is_active\" = 1) AND (\"enaccountingdatatype10\".\"isestim_equal_agreed\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetAdvancedPaymentTypes" TQmXE52HCU2xIrFREPbMsA of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_0d443dd02abe633532f6b939b4573e00,long)> datasetGetAdvancedPaymentTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAdvancedPaymentTypes", "1397094d-879d-4d09-b122-b15110f6ccb0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAdvancedPaymentTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.TQmXE52HCU2xIrFREPbMsA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enadvancepaymenttype3\".\"id\" o0, \"enadvancepaymenttype3\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {AdvancePaymentType} \"enadvancepaymenttype3\"");
whereBuilder.Append(" WHERE (\"enadvancepaymenttype3\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetSpecialPostDeliveryAuthorizations" 3d0ZMhjX9k2sivyAHNDc2A of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_9a84f0ca43f575461143a73bcb506dba,long)> datasetGetSpecialPostDeliveryAuthorizations(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialPostDeliveryAuthorizations", "3219dddd-d718-4df6-ac8a-fc801cd0dcd8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialPostDeliveryAuthorizations");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.3d0ZMhjX9k2sivyAHNDc2A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialpostdeliveryauthorization\".\"id\" o0, \"enspecialpostdeliveryauthorization\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialPostDeliveryAuthorization} \"enspecialpostdeliveryauthorization\"");
whereBuilder.Append(" WHERE (\"enspecialpostdeliveryauthorization\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
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

// Query Function "GetContractStatuses" oPXgNstYgkCPRzePDKO3vQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_b597b6c7f7b0a874a3717792e87892bb,long)> datasetGetContractStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetContractStatuses", "36e0f5a0-58cb-4082-8f47-378f0ca3b7bd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetContractStatuses");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.oPXgNstYgkCPRzePDKO3vQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encontractstatus\".\"id\" o0, \"encontractstatus\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ContractStatus} \"encontractstatus\"");
whereBuilder.Append(" WHERE (\"encontractstatus\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"encontractstatus\".\"order\" ASC ");
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
RL_b597b6c7f7b0a874a3717792e87892bb outParamList = new RL_b597b6c7f7b0a874a3717792e87892bb();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetContractStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b597b6c7f7b0a874a3717792e87892bb _tmp = new RL_b597b6c7f7b0a874a3717792e87892bb();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetContractStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b597b6c7f7b0a874a3717792e87892bb)_tmp;
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

// Query Function "GetProjectAssetServiceOtro" 43k3TPsee0eDdPZbOkdxHA of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServiceOtro(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServiceOtro", "4c3779e3-1efb-477b-8374-f65b3a47711c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServiceOtro");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.43k3TPsee0eDdPZbOkdxHA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service11\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service11\"");
whereBuilder.Append(" WHERE (\"enproject_asset_service11\".\"isothers\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
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

private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSuppliersReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSuppliers" 9+IjWJSPN0+STOz2mZsA8A of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,long qpreSupplier_RegionId2,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSuppliers", "5823e2f7-8f94-4f37-924c-ecf6999b00f0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSuppliers");
// Query Iterations: Never
// Refresh Query u_qW3tsw7EG3wjblGfHrYg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.9+IjWJSPN0+STOz2mZsA8A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier95\" Left JOIN {Region} \"enregion126\" ON (\"ensupplier95\".\"regionid\" = \"enregion126\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier95\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier95\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier95\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ((((@qpreSupplier_RegionId1 = @qpreSupplier_RegionId2) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId2);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier95\".\"regionid\" = @qpreSupplier_RegionId2) AND (\"ensupplier95\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier95\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId2 != 0) {
whereBuilder.Append("((\"ensupplier95\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier95\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId2);
} else {
whereBuilder.Append("(\"ensupplier95\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier95\".\"regionid\" IS NULL)))");
orderByBuilder.Append(" ORDER BY \"ensupplier95\".\"name\" ASC ");
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
RL_f647e8c4990b814587d1a017e4c9dd44 outParamList = new RL_f647e8c4990b814587d1a017e4c9dd44();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSuppliers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f647e8c4990b814587d1a017e4c9dd44 _tmp = new RL_f647e8c4990b814587d1a017e4c9dd44();
_tmp.AlternateReadDbMethodAsync = datasetGetSuppliersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSuppliers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f647e8c4990b814587d1a017e4c9dd44)_tmp;
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

// Query Function "GetBusinessValueSubcategoriesByCategoryId" 15ifaXxxjEufZSCkiuQFOQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_2d11b20156650990ba0f3131aaaad2ea,long)> datasetGetBusinessValueSubcategoriesByCategoryId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpbuCategoryId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueSubcategoriesByCategoryId", "699f98d7-717c-4b8c-9f65-20a48ae40539");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueSubcategoriesByCategoryId");
// Query Iterations: Multiple
// Refresh Query _Y8iQQIdoUqzBjxtMbdSGw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.15ifaXxxjEufZSCkiuQFOQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluesubcategory2\".\"id\" o0, \"enbusinessvaluesubcategory2\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {BusinessValueSubcategory} \"enbusinessvaluesubcategory2\"");
whereBuilder.Append(" WHERE ");
if (qpbuCategoryId != 0) {
whereBuilder.Append("((\"enbusinessvaluesubcategory2\".\"categoryid\" = @qpbuCategoryId) AND (\"enbusinessvaluesubcategory2\".\"categoryid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbuCategoryId", DbType.Int64, qpbuCategoryId);
} else {
whereBuilder.Append("(\"enbusinessvaluesubcategory2\".\"categoryid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
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

// Query Function "GetSupplierByRequisition" D_SMj82Nk06mxw1SjC8rFQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierByRequisition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSupplierByRequisition", "8f8cf40f-8dcd-4e93-a6c7-0d528c2f2b15");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSupplierByRequisition");
// Query Iterations: Never
// Refresh Query MV4sytNkhEmyEVNozmivYw Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.D_SMj82Nk06mxw1SjC8rFQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier96\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier96\".\"id\" = @qpsuId) AND (\"ensupplier96\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier96\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
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

private static async Task<RC_655f10514459daf453e41f31c05184fc> datasetGetOrderMainByIdReadDbAsync(RC_655f10514459daf453e41f31c05184fc rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENOrderStatus.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENSupplierUser.Read( r, ref index);
rec.ssIsCurrentApprover = r.ReadBoolean(index++, "OrderStatusOrderApprovalOrderMainOrderDetailOrderApprovalLevelIsCurrentApproverSupplierUserSupplierRecord.IsCurrentApprover", false);
return rec;
}
// Query Function "GetOrderMainById" eiOsnkGJJkCozcf_jTKzqw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_c5285652b7692ee7ff416f77dcd1fe1c,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboGetIsCxP_RequestErrorDistribution,long qpenOrderApprovalLevel_EntraRoleId,string qpusGetUserId,long qpreGetUserRegionId,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainById", "9eac237a-8941-4026-a8cd-c7ff8d32b3ab");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainById");
// Query Iterations: Never
// Refresh Query A3Yoa3DxOEaEnJ4QZGnukQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.eiOsnkGJJkCozcf_jTKzqw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval27\".\"id\" o0, NULL o1, \"enorderapproval27\".\"currentlevel\" o2, \"enorderapproval27\".\"maxlevel\" o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel26\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderapprovallevel26\".\"approvalstatusid\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enorderdetail15\".\"orderid\" o25, \"enorderdetail15\".\"isapprovalfromuserarea\" o26, \"enorderdetail15\".\"projectassetserviceid\" o27, \"enorderdetail15\".\"projectassetservice\" o28, \"enorderdetail15\".\"projectdescription\" o29, \"enorderdetail15\".\"businessvaluecategoryid\" o30, \"enorderdetail15\".\"businessvaluesubcategoryid\" o31, \"enorderdetail15\".\"paymenttermsid\" o32, \"enorderdetail15\".\"paymentmethodid\" o33, trim_scale(\"enorderdetail15\".\"negotiatedexchangerate\"::numeric) o34, \"enorderdetail15\".\"contractstatus\" o35, \"enorderdetail15\".\"dateofcommitment\" o36, \"enorderdetail15\".\"hasdeposit\" o37, \"enorderdetail15\".\"hasinsurance\" o38, \"enorderdetail15\".\"distributionid\" o39, \"enorderdetail15\".\"hasadvancepayment\" o40, trim_scale(\"enorderdetail15\".\"retentionrate\"::numeric) o41, \"enorderdetail15\".\"hasbasedate\" o42, \"enorderdetail15\".\"startbasedate\" o43, \"enorderdetail15\".\"endbasedate\" o44, \"enorderdetail15\".\"contractnumber\" o45, \"enorderdetail15\".\"isretentionapplied\" o46, \"enorderdetail15\".\"frequency\" o47, \"enorderdetail15\".\"period\" o48, \"enorderdetail15\".\"orderretentiontypeid\" o49, \"enorderdetail15\".\"paymentoptionsid\" o50, \"enorderdetail15\".\"paymentwaysid\" o51, \"enorderdetail15\".\"orderscontract\" o52, trim_scale(\"enorderdetail15\".\"contractamount\"::numeric) o53, trim_scale(\"enorderdetail15\".\"contracttarif\"::numeric) o54, \"enorderdetail15\".\"contractsupplier\" o55, \"enorderdetail15\".\"isdependentfromfolios\" o56, \"enorderdetail15\".\"specialapprovalid\" o57, \"enorderdetail15\".\"createdby\" o58, \"enorderdetail15\".\"createdon\" o59, \"enorderdetail15\".\"updatedby\" o60, \"enorderdetail15\".\"updatedon\" o61, \"enorderdetail15\".\"allcontactfilesvalidated\" o62, \"enorderdetail15\".\"hasntrequestdocuments\" o63, \"enordermain96\".\"id\" o64, \"enordermain96\".\"ordernumber\" o65, \"enordermain96\".\"orderdate\" o66, \"enordermain96\".\"orderstatusid\" o67, \"enordermain96\".\"previousorderstatusid\" o68, \"enordermain96\".\"assignmentcode\" o69, \"enordermain96\".\"supplierid\" o70, \"enordermain96\".\"companyid\" o71, \"enordermain96\".\"documenttypeid\" o72, \"enordermain96\".\"currencyid\" o73, \"enordermain96\".\"telceldirectionid\" o74, \"enordermain96\".\"procurementgroup\" o75, \"enordermain96\".\"creatorsapnumber\" o76, \"enordermain96\".\"creatorsapname\" o77, \"enordermain96\".\"country\" o78, \"enordermain96\".\"isdeleted\" o79, \"enordermain96\".\"isreleased\" o80, trim_scale(\"enordermain96\".\"exchangerate\"::numeric) o81, \"enordermain96\".\"sustainabilitycategory\" o82, \"enordermain96\".\"sustainabilitysubcategory\" o83, trim_scale(\"enordermain96\".\"totalamount\"::numeric) o84, \"enordermain96\".\"fromcosmoz\" o85, \"enordermain96\".\"regionid\" o86, \"enordermain96\".\"divisionid\" o87, \"enordermain96\".\"applicant\" o88, \"enordermain96\".\"createdby\" o89, \"enordermain96\".\"createdon\" o90, \"enordermain96\".\"updatedby\" o91, \"enordermain96\".\"updatedon\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, \"ensupplier97\".\"pais\" o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, (CASE WHEN ((");
if ((qpusGetUserId.Trim()!="")) {
selectBuilder.Append("((\"enorderapprovallevel26\".\"assignedto\" = @qpusGetUserId) AND (\"enorderapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
selectBuilder.Append("(\"enorderapprovallevel26\".\"assignedto\" IS NULL)");
}
selectBuilder.Append(" OR (((\"enorderapprovallevel26\".\"assignedto\" IS NULL) AND (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain96\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain96\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain96\".\"divisionid\" IS NULL)");
}
selectBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain96\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain96\".\"regionid\" IS NULL)");
}
selectBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
selectBuilder.Append("((\"enorderapprovallevel26\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel26\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
selectBuilder.Append("(\"enorderapprovallevel26\".\"entraroleid\" IS NULL)");
}
selectBuilder.Append(")) AND ((\"enorderapprovallevel26\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enorderapprovallevel26\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"iscurrentapprover\"");
fromBuilder.Append(" FROM (((((({OrderApprovalLevel} \"enorderapprovallevel26\" Left JOIN {OrderApproval} \"enorderapproval27\" ON (\"enorderapproval27\".\"id\" = \"enorderapprovallevel26\".\"orderapprovalid\"))  Right JOIN {OrderMain} \"enordermain96\" ON (\"enordermain96\".\"id\" = \"enorderapproval27\".\"orderid\"))  Left JOIN {OrderStatus} \"enorderstatus7\" ON (\"enordermain96\".\"orderstatusid\" = \"enorderstatus7\".\"id\"))  Left JOIN {Supplier} \"ensupplier97\" ON (\"enordermain96\".\"supplierid\" = \"ensupplier97\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail15\" ON (\"enordermain96\".\"id\" = \"enorderdetail15\".\"orderid\"))  Left JOIN {SupplierUser} \"ensupplieruser21\" ON (\"ensupplier97\".\"id\" = \"ensupplieruser21\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain96\".\"id\" = @qporOrderMain_Id) AND (\"enordermain96\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain96\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser21\".\"userid\" = @qpusGetUserId) AND (\"ensupplieruser21\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"ensupplieruser21\".\"userid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE (CASE WHEN (((\"enorderapprovallevel26\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel26\".\"assignedto\" = @qpusGetUserId) AND (\"enorderapprovallevel26\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel26\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (((\"enorderapprovallevel26\".\"assignedto\" IS NULL) AND (");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain96\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain96\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain96\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain96\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain96\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain96\".\"regionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel26\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel26\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel26\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append("))) OR ((\"enordermain96\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") OR ((\"enordermain96\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
whereBuilder.Append(") AND (@qpboGetIsCxP_RequestErrorDistribution = 1)))) THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel26\".\"levelnumber\" DESC ");
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCxP_RequestErrorDistribution", DbType.Boolean, qpboGetIsCxP_RequestErrorDistribution);
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
RL_c5285652b7692ee7ff416f77dcd1fe1c outParamList = new RL_c5285652b7692ee7ff416f77dcd1fe1c();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, false, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5285652b7692ee7ff416f77dcd1fe1c _tmp = new RL_c5285652b7692ee7ff416f77dcd1fe1c();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5285652b7692ee7ff416f77dcd1fe1c)_tmp;
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

// Query Function "GetProjectAssetServices" Ma9Vnx+OWUqebX0kdCB+kQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServices", "9f55af31-8e1f-4a59-9e6d-7d2474207e91");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.Ma9Vnx+OWUqebX0kdCB+kQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service12\".\"id\" o0, \"enproject_asset_service12\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service12\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service12\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceUsages" B4ftomBm9ESLRJfMSMocAQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_1078cb2b44dad3e211c3325e839a4151,long)> datasetGetInvoiceUsages(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInvoiceUsages", "a2ed8707-6660-44f4-8b44-97cc48ca1c01");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInvoiceUsages");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.B4ftomBm9ESLRJfMSMocAQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceusage3\".\"id\" o0, \"eninvoiceusage3\".\"key\" o1, \"eninvoiceusage3\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {InvoiceUsage} \"eninvoiceusage3\"");
whereBuilder.Append(" WHERE (\"eninvoiceusage3\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"eninvoiceusage3\".\"key\" ASC ");
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
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInvoiceUsages.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInvoiceUsages.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderRetentionTypes" NxDgoyFAt06yKwUPkFx78Q of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_d6a865b9451603b2b07820fedb283c87,long)> datasetGetOrderRetentionTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderRetentionTypes", "a3e01037-4021-4eb7-b22b-050f905c7bf1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderRetentionTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.NxDgoyFAt06yKwUPkFx78Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderretentiontype\".\"id\" o0, \"enorderretentiontype\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {OrderRetentionType} \"enorderretentiontype\"");
whereBuilder.Append(" WHERE (\"enorderretentiontype\".\"is_active\" = 1)");
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
RL_d6a865b9451603b2b07820fedb283c87 outParamList = new RL_d6a865b9451603b2b07820fedb283c87();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderRetentionTypes.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_d6a865b9451603b2b07820fedb283c87 _tmp = new RL_d6a865b9451603b2b07820fedb283c87();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderRetentionTypes.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_d6a865b9451603b2b07820fedb283c87)_tmp;
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

// Query Function "GetBusinessValueCategories" i2G0rKmXvk6hurmJBwUaaw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_901339470d357e86e0df985d0e6489f6,long)> datasetGetBusinessValueCategories(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueCategories", "acb4618b-97a9-4ebe-a1ba-b98907051a6b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueCategories");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.i2G0rKmXvk6hurmJBwUaaw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluecategory2\".\"id\" o0, \"enbusinessvaluecategory2\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {BusinessValueCategory} \"enbusinessvaluecategory2\"");
orderByBuilder.Append(" ORDER BY \"enbusinessvaluecategory2\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentTerms" 8i9rrsDYOUimLZLkpJkphg of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTerms", "ae6b2ff2-d8c0-4839-a62d-92e4a4992986");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTerms");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.8i9rrsDYOUimLZLkpJkphg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms22\".\"id\" o0, \"enpaymentterms22\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms22\"");
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
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTerms.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTerms.List", cancellationToken: cancellationToken);
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

// Query Function "GetInsuranceTypes" uNoKs1sUKkiJ2B7jCmOsew of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_32b3fec96f8ddbf444444f34b158e188,long)> datasetGetInsuranceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInsuranceTypes", "b30adab8-145b-482a-89d8-1ee30a63ac7b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInsuranceTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.uNoKs1sUKkiJ2B7jCmOsew, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninsurancetype\".\"id\" o0, \"eninsurancetype\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {InsuranceType} \"eninsurancetype\"");
whereBuilder.Append(" WHERE (\"eninsurancetype\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInsuranceTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetInsuranceTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetFrequencies" x+t7tGYW+kSvkB+zUxsABw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_86161aa08f9858d205ef72cffcb4919d,long)> datasetGetFrequencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetFrequencies", "b47bebc7-1666-44fa-af90-1fb3531b0007");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetFrequencies");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.x+t7tGYW+kSvkB+zUxsABw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfrequency5\".\"id\" o0, \"enfrequency5\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Frequency} \"enfrequency5\"");
whereBuilder.Append(" WHERE (\"enfrequency5\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"enfrequency5\".\"order\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetFrequencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetFrequencies.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentOptions" 5srTuwXzvUGlOAWZaMQyZQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_251acb2daece433ee402c9709ec88356,long)> datasetGetPaymentOptions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentOptions", "bbd3cae6-f305-41bd-a538-059968c43265");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentOptions");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.5srTuwXzvUGlOAWZaMQyZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentoptions2\".\"id\" o0, NULL o1, \"enpaymentoptions2\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentOptions} \"enpaymentoptions2\"");
whereBuilder.Append(" WHERE ((\"enpaymentoptions2\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentoptions2\".\"id\" = @qppaId) AND (\"enpaymentoptions2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentoptions2\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentOptions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentOptions.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentWays" +6VEvBTjLU+5ILyZk6NSaw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_d98dc7eec8c631266895b622203a6db3,long)> datasetGetPaymentWays(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentWays", "bc44a5fb-e314-4f2d-b920-bc9993a3526b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentWays");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.+6VEvBTjLU+5ILyZk6NSaw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentways2\".\"id\" o0, \"enpaymentways2\".\"code\" o1, \"enpaymentways2\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentWays} \"enpaymentways2\"");
whereBuilder.Append(" WHERE ((\"enpaymentways2\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentways2\".\"id\" = @qppaId) AND (\"enpaymentways2\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentways2\".\"id\" IS NULL)");
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
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentWays.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentWays.List", cancellationToken: cancellationToken);
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

private static async Task<RC_16678e1ac2e17d1b5db4a9a7f4681e64> datasetGetOrderMainItemsByOrderMainIdReadDbAsync(RC_16678e1ac2e17d1b5db4a9a7f4681e64 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENInvoiceUsage.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId" 3Jc30pFdTkenHAMTWzluEQ of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_663d4acde686fb13f7cb44965555ab7f,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainItemsByOrderMainId", "d23797dc-5d91-474e-a71c-03135b396e11");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainItemsByOrderMainId");
// Query Iterations: Multiple
// Refresh Query azw08VhyMkOGls85KOxU1Q Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.3Jc30pFdTkenHAMTWzluEQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype11\".\"cc\" o1, \"enaccountingaccounts_servicetype11\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"eninvoiceusage4\".\"key\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enordermainitem21\".\"id\" o18, \"enordermainitem21\".\"ordermainid\" o19, \"enordermainitem21\".\"position\" o20, \"enordermainitem21\".\"materialcode\" o21, \"enordermainitem21\".\"materialdescription\" o22, \"enordermainitem21\".\"assigmnentcode\" o23, \"enordermainitem21\".\"documentclassid\" o24, \"enordermainitem21\".\"deliverydate\" o25, trim_scale(\"enordermainitem21\".\"quantity\"::numeric) o26, \"enordermainitem21\".\"unittype\" o27, trim_scale(\"enordermainitem21\".\"unitprice\"::numeric) o28, \"enordermainitem21\".\"basequantity\" o29, \"enordermainitem21\".\"isdeleted\" o30, \"enordermainitem21\".\"isblocked\" o31, \"enordermainitem21\".\"isfinaldelivery\" o32, \"enordermainitem21\".\"glaccountid\" o33, \"enordermainitem21\".\"costcenterid\" o34, \"enordermainitem21\".\"fundscenter\" o35, \"enordermainitem21\".\"fund\" o36, \"enordermainitem21\".\"commitmentitem\" o37, \"enordermainitem21\".\"vatindicator\" o38, \"enordermainitem21\".\"vatprocedure\" o39, trim_scale(\"enordermainitem21\".\"vatrate\"::numeric) o40, \"enordermainitem21\".\"purchaserequisitionnumber\" o41, \"enordermainitem21\".\"purchaserequisitionitemnr\" o42, \"enordermainitem21\".\"regionid\" o43, \"enordermainitem21\".\"center\" o44, \"enordermainitem21\".\"pepelement\" o45, trim_scale(\"enordermainitem21\".\"quantitydelivered\"::numeric) o46, \"enordermainitem21\".\"orderunitofmeasure\" o47, \"enordermainitem21\".\"applicant\" o48, \"enordermainitem21\".\"direction\" o49, \"enordermainitem21\".\"contractnumber\" o50, \"enordermainitem21\".\"contractposition\" o51, \"enordermainitem21\".\"contractstartdate\" o52, \"enordermainitem21\".\"contractenddate\" o53, trim_scale(\"enordermainitem21\".\"contractplannedvalue\"::numeric) o54, \"enordermainitem21\".\"positiontype\" o55, \"enordermainitem21\".\"serialnumberprofile\" o56, \"enordermainitem21\".\"batchmanaged\" o57, \"enordermainitem21\".\"materialtype\" o58, \"enordermainitem21\".\"itemgroup\" o59, \"enordermainitem21\".\"orderrequestcreatorsapnumber\" o60, \"enordermainitem21\".\"ismultipleimputation\" o61, \"enordermainitem21\".\"invoiceusageid\" o62, \"enordermainitem21\".\"ordermainitemstatusid\" o63, \"enordermainitem21\".\"divisionid\" o64, \"enordermainitem21\".\"createdby\" o65, \"enordermainitem21\".\"createdon\" o66, \"enordermainitem21\".\"updatedby\" o67, \"enordermainitem21\".\"updatedon\" o68");
fromBuilder.Append(" FROM (({OrderMainItem} \"enordermainitem21\" Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype11\" ON (\"enordermainitem21\".\"glaccountid\" = \"enaccountingaccounts_servicetype11\".\"id\"))  Left JOIN {InvoiceUsage} \"eninvoiceusage4\" ON (\"enordermainitem21\".\"invoiceusageid\" = \"eninvoiceusage4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem21\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem21\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem21\".\"ordermainid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enordermainitem21\".\"position\" ASC ");
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
RL_663d4acde686fb13f7cb44965555ab7f outParamList = new RL_663d4acde686fb13f7cb44965555ab7f();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, false, false, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_663d4acde686fb13f7cb44965555ab7f _tmp = new RL_663d4acde686fb13f7cb44965555ab7f();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainItemsByOrderMainIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_663d4acde686fb13f7cb44965555ab7f)_tmp;
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

// Query Function "GetCurrencies" MVFD2K3VCUGlvS9gNZBMCw of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetCurrencies", "d8435131-d5ad-4109-a5bd-2f6035904c0b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.MVFD2K3VCUGlvS9gNZBMCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency18\".\"code\" o0, \"encurrency18\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency18\"");
whereBuilder.Append(" WHERE (\"encurrency18\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetCurrencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetCurrencies.List", cancellationToken: cancellationToken);
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

// Query Function "GetDepositTypes" N3F75GY_vU6yR+1XfAkN1g of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_cda7ed93cc851adc2316965418c61e6f,long)> datasetGetDepositTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetDepositTypes", "e47b7137-3f66-4ebd-b247-ed577c090dd6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetDepositTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.N3F75GY_vU6yR+1XfAkN1g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endeposittype\".\"id\" o0, \"endeposittype\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {DepositType} \"endeposittype\"");
whereBuilder.Append(" WHERE (\"endeposittype\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetDepositTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetDepositTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentMethods" 1j5+5as2iE2wYhJ663A36Q of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethods(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentMethods", "e57e3ed6-36ab-4d88-b062-127aeb7037e9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentMethods");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.1j5+5as2iE2wYhJ663A36Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentmethods11\".\"id\" o0, \"enpaymentmethods11\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods11\"");
whereBuilder.Append(" WHERE (\"enpaymentmethods11\".\"isfcp\" = 1)");
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
RL_0dcbcba642ca8b22e87f690d4de9d077 outParamList = new RL_0dcbcba642ca8b22e87f690d4de9d077();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentMethods.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentMethods.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0dcbcba642ca8b22e87f690d4de9d077)_tmp;
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

// Query Function "GetRejectComment" AqsS_orDA02kvmDc9HjbzA of Action "Wb_OrderDetailPaymentInformation_13008"
public static async Task<(RL_17d8289ea48572225dc9530a5725652a,long)> datasetGetRejectComment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetRejectComment", "fe12ab02-c38a-4d03-a4be-60dcf478dbcc");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation_13008","e_Orders.Wb_OrderDetailPaymentInformation_13008.GetRejectComment");
// Query Iterations: Never
// Refresh Query KFYxSFhVt0GQnFy1_F1g9w Iterations: Never
// Refresh Query Ya3gQpb1G0iuhFJVnD3Psg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/ScreenDataSets.AqsS_orDA02kvmDc9HjbzA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {OrderComment} \"enordercomment\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enordercomment\".\"orderid\" = @qporOrderId) AND (\"enordercomment\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enordercomment\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercomment\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enordercomment\".\"id\" DESC ");
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
RL_17d8289ea48572225dc9530a5725652a outParamList = new RL_17d8289ea48572225dc9530a5725652a();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetRejectComment.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_17d8289ea48572225dc9530a5725652a _tmp = new RL_17d8289ea48572225dc9530a5725652a();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetRejectComment.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_17d8289ea48572225dc9530a5725652a)_tmp;
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


    public class lcvGetOrderFilesList : VarsBag {
public RL_eeab316051f92c8094cbc73a8650f55b queryResGetOrderFinanceFile_outParamList = new RL_eeab316051f92c8094cbc73a8650f55b();
public long queryResGetOrderFinanceFile_outParamCount = 0L;

public RL_5305c20f972277b55d855aa236dd3fba queryResGetOrderForeignResidenceFile_outParamList = new RL_5305c20f972277b55d855aa236dd3fba();
public long queryResGetOrderForeignResidenceFile_outParamCount = 0L;

public lcvGetOrderFilesList() {
}
}
public class lcoGetOrderFilesList : VarsBag {
public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_FinanceAuthorization = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ProofOfForeignResidence = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public lcoGetOrderFilesList() {
}
}
/// <summary>
/// Action <code>GetOrderFilesList</code> that represents the Service Studio action
///  <code>GetOrderFilesList</code> <p> Description: Data Action that fetchs Order Files.</p>
/// </summary>
public async Task<(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure,ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)> DataActionGetOrderFilesList(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_FinanceAuthorization = default;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ProofOfForeignResidence = default;
lcoGetOrderFilesList result = new lcoGetOrderFilesList();
lcvGetOrderFilesList localVars = new lcvGetOrderFilesList();
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderFilesList", "1929719e-01a7-45ed-8a8f-2618ca6b512c"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation_13008", "GetOrderFilesList")){
// Query datasetGetOrderFinanceFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderFinanceFile_maxRecords = 1;
if (datasetGetOrderFinanceFile_maxRecords < 1) datasetGetOrderFinanceFile_maxRecords = 1;
int datasetGetOrderFinanceFile_startIndex = 0;(localVars.queryResGetOrderFinanceFile_outParamList,localVars.queryResGetOrderFinanceFile_outParamCount) = await FuncDataActionGetOrderFilesList.datasetGetOrderFinanceFile(requestContext,datasetGetOrderFinanceFile_maxRecords,datasetGetOrderFinanceFile_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_OrderId,cancellationToken);

// Query datasetGetOrderForeignResidenceFile
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderForeignResidenceFile_maxRecords = 1;
if (datasetGetOrderForeignResidenceFile_maxRecords < 1) datasetGetOrderForeignResidenceFile_maxRecords = 1;
int datasetGetOrderForeignResidenceFile_startIndex = 0;(localVars.queryResGetOrderForeignResidenceFile_outParamList,localVars.queryResGetOrderForeignResidenceFile_outParamCount) = await FuncDataActionGetOrderFilesList.datasetGetOrderForeignResidenceFile(requestContext,datasetGetOrderForeignResidenceFile_maxRecords,datasetGetOrderForeignResidenceFile_startIndex,IterationMultiplicity.Never,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),inParami_OrderId,cancellationToken);

// o_FinanceAuthorization = GetOrderFinanceFile.List.Current
result.outParamo_FinanceAuthorization=(await RecordUtils.ConvertAsync(localVars.queryResGetOrderFinanceFile_outParamList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_041cacb77c43fb5e1fc788222594e8fd source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFinanceFile;
target.ssOrderFile = source.ssENOrderFinanceFile;
return target;
}, cancellationToken));

// o_ProofOfForeignResidence = GetOrderForeignResidenceFile.List.Current
result.outParamo_ProofOfForeignResidence=(await RecordUtils.ConvertAsync(localVars.queryResGetOrderForeignResidenceFile_outParamList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_55a4f62f090e92d07d40f0b63ffe2d16 source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFileForeignResidence;
target.ssOrderFile = source.ssENOrderFileForeignResidence;
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
public class lcvGetPaymentTermSpecial : VarsBag {
public RL_375b9dd8c8b0d6d7bccf4d550f48644d queryResGetPaymentTermsIsSpecial_outParamList = new RL_375b9dd8c8b0d6d7bccf4d550f48644d();
public long queryResGetPaymentTermsIsSpecial_outParamCount = 0L;

public lcvGetPaymentTermSpecial() {
}
}
public class lcoGetPaymentTermSpecial : VarsBag {
public long outParamId = 0L;

public bool outParamIsActive = false;

public lcoGetPaymentTermSpecial() {
}
}
/// <summary>
/// Action <code>GetPaymentTermSpecial</code> that represents the Service Studio action
///  <code>GetPaymentTermSpecial</code> <p> Description: </p>
/// </summary>
public async Task<(long,bool)> DataActionGetPaymentTermSpecial(IRequestContext requestContext,CancellationToken cancellationToken) {
long outParamId = default;
bool outParamIsActive = default;
lcoGetPaymentTermSpecial result = new lcoGetPaymentTermSpecial();
lcvGetPaymentTermSpecial localVars = new lcvGetPaymentTermSpecial();
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetPaymentTermSpecial", "880dd03d-b54d-4b32-bddb-d9b72fcd7681"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation_13008", "GetPaymentTermSpecial")){
// Query datasetGetPaymentTermsIsSpecial
cancellationToken.ThrowIfCancellationRequested();
int datasetGetPaymentTermsIsSpecial_maxRecords = 1;
if (datasetGetPaymentTermsIsSpecial_maxRecords < 1) datasetGetPaymentTermsIsSpecial_maxRecords = 1;
int datasetGetPaymentTermsIsSpecial_startIndex = 0;(localVars.queryResGetPaymentTermsIsSpecial_outParamList,localVars.queryResGetPaymentTermsIsSpecial_outParamCount) = await FuncDataActionGetPaymentTermSpecial.datasetGetPaymentTermsIsSpecial(requestContext,datasetGetPaymentTermsIsSpecial_maxRecords,datasetGetPaymentTermsIsSpecial_startIndex,IterationMultiplicity.Never,cancellationToken);

// Id = GetPaymentTermsIsSpecial.List.Current.PaymentTerms.Id
result.outParamId=localVars.queryResGetPaymentTermsIsSpecial_outParamList.CurrentRec.ssENPaymentTerms.ssId;

// IsActive = True
result.outParamIsActive=true;
} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
outParamIsActive = result.outParamIsActive;
} // inner-finally
RETURN_STATEMENT:
return (outParamId,outParamIsActive);
}
public class lcvGetAccountingData : VarsBag {
public RL_06217d1a1f91440a5a69e4163e3e2c6f queryResGetOrderMainExchangeRate_outParamList = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
public long queryResGetOrderMainExchangeRate_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsAnticipo_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsAnticipo_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsVoucher_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsVoucher_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsVoucher_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsVoucher_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsFiniquito_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsFiniquito_outParamCount = 0L;

public RL_aedf606f6413243cfacf43ac13db404f queryResGetOrderAccountingsByOrderId_outParamList = new RL_aedf606f6413243cfacf43ac13db404f();
public long queryResGetOrderAccountingsByOrderId_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsCreditNote_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsCreditNote_outParamCount = 0L;

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf queryResGetOrderExchangeRateEvidence_outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
public long queryResGetOrderExchangeRateEvidence_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConcepts_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConcepts_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsAnticipo_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsAnticipo_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsCreditNote_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsCreditNote_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsFiniquito_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsFiniquito_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConcepts_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConcepts_outParamCount = 0L;

public lcvGetAccountingData() {
}
}
public class lcoGetAccountingData : VarsBag {
public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord outParamOrderAccounting = new EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord();

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ExchangeRateEvidence = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Estim_Equal_Agreed = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_CreditNote = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Voucher = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Finiquito = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();

public RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Anticipo = new RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9();

public lcoGetAccountingData() {
}
}
/// <summary>
/// Action <code>GetAccountingData</code> that represents the Service Studio action
///  <code>GetAccountingData</code> <p> Description: Data Action that fetchs Accounting Data.</p>
/// </summary>
public async Task<(EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord,ST_c3df6a1f053620bf8d50da58ff4e41bcStructure,RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9,RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9,RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9,RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9,RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9)> DataActionGetAccountingData(IRequestContext requestContext,CancellationToken cancellationToken) {
EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord outParamOrderAccounting = default;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ExchangeRateEvidence = default;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Estim_Equal_Agreed = default;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_CreditNote = default;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Voucher = default;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Finiquito = default;
RC_9dc9d00c2e8dcb1797f7869ab9e5a7f9 outParamo_Anticipo = default;
lcoGetAccountingData result = new lcoGetAccountingData();
lcvGetAccountingData localVars = new lcvGetAccountingData();
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetAccountingData", "af65a441-b6c8-4417-99c0-4fe4c1e951c9"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation_13008", "GetAccountingData")){
// Query datasetGetOrderAccountingsByOrderId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderAccountingsByOrderId_maxRecords = 1;
if (datasetGetOrderAccountingsByOrderId_maxRecords < 1) datasetGetOrderAccountingsByOrderId_maxRecords = 1;
int datasetGetOrderAccountingsByOrderId_startIndex = 0;(localVars.queryResGetOrderAccountingsByOrderId_outParamList,localVars.queryResGetOrderAccountingsByOrderId_outParamCount) = await FuncDataActionGetAccountingData.datasetGetOrderAccountingsByOrderId(requestContext,datasetGetOrderAccountingsByOrderId_maxRecords,datasetGetOrderAccountingsByOrderId_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetMainOrderAccConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainOrderAccConcepts_maxRecords = 1;
if (datasetGetMainOrderAccConcepts_maxRecords < 1) datasetGetMainOrderAccConcepts_maxRecords = 1;
int datasetGetMainOrderAccConcepts_startIndex = 0;(localVars.queryResGetMainOrderAccConcepts_outParamList,localVars.queryResGetMainOrderAccConcepts_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainOrderAccConcepts(requestContext,datasetGetMainOrderAccConcepts_maxRecords,datasetGetMainOrderAccConcepts_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting.ssId,cancellationToken);

// Query datasetGetSubOrderAccConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubOrderAccConcepts_maxRecords = 0;
int datasetGetSubOrderAccConcepts_startIndex = 0;(localVars.queryResGetSubOrderAccConcepts_outParamList,localVars.queryResGetSubOrderAccConcepts_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubOrderAccConcepts(requestContext,datasetGetSubOrderAccConcepts_maxRecords,datasetGetSubOrderAccConcepts_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainOrderAccConcepts_outParamList.CurrentRec.ssENOrderAccConcepts.ssId,cancellationToken);

// Query datasetGetMainOrderAccConceptsCreditNote
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainOrderAccConceptsCreditNote_maxRecords = 1;
if (datasetGetMainOrderAccConceptsCreditNote_maxRecords < 1) datasetGetMainOrderAccConceptsCreditNote_maxRecords = 1;
int datasetGetMainOrderAccConceptsCreditNote_startIndex = 0;(localVars.queryResGetMainOrderAccConceptsCreditNote_outParamList,localVars.queryResGetMainOrderAccConceptsCreditNote_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainOrderAccConceptsCreditNote(requestContext,datasetGetMainOrderAccConceptsCreditNote_maxRecords,datasetGetMainOrderAccConceptsCreditNote_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting.ssId,cancellationToken);

// Query datasetGetSubOrderAccConceptsCreditNote
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubOrderAccConceptsCreditNote_maxRecords = 0;
int datasetGetSubOrderAccConceptsCreditNote_startIndex = 0;(localVars.queryResGetSubOrderAccConceptsCreditNote_outParamList,localVars.queryResGetSubOrderAccConceptsCreditNote_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubOrderAccConceptsCreditNote(requestContext,datasetGetSubOrderAccConceptsCreditNote_maxRecords,datasetGetSubOrderAccConceptsCreditNote_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainOrderAccConceptsCreditNote_outParamList.CurrentRec.ssENOrderAccConcepts.ssId,cancellationToken);

// Query datasetGetMainOrderAccConceptsVoucher
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainOrderAccConceptsVoucher_maxRecords = 1;
if (datasetGetMainOrderAccConceptsVoucher_maxRecords < 1) datasetGetMainOrderAccConceptsVoucher_maxRecords = 1;
int datasetGetMainOrderAccConceptsVoucher_startIndex = 0;(localVars.queryResGetMainOrderAccConceptsVoucher_outParamList,localVars.queryResGetMainOrderAccConceptsVoucher_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainOrderAccConceptsVoucher(requestContext,datasetGetMainOrderAccConceptsVoucher_maxRecords,datasetGetMainOrderAccConceptsVoucher_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting.ssId,cancellationToken);

// Query datasetGetSubOrderAccConceptsVoucher
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubOrderAccConceptsVoucher_maxRecords = 0;
int datasetGetSubOrderAccConceptsVoucher_startIndex = 0;(localVars.queryResGetSubOrderAccConceptsVoucher_outParamList,localVars.queryResGetSubOrderAccConceptsVoucher_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubOrderAccConceptsVoucher(requestContext,datasetGetSubOrderAccConceptsVoucher_maxRecords,datasetGetSubOrderAccConceptsVoucher_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainOrderAccConceptsVoucher_outParamList.CurrentRec.ssENOrderAccConcepts.ssId,cancellationToken);

// Query datasetGetOrderExchangeRateEvidence
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderExchangeRateEvidence_maxRecords = 1;
if (datasetGetOrderExchangeRateEvidence_maxRecords < 1) datasetGetOrderExchangeRateEvidence_maxRecords = 1;
int datasetGetOrderExchangeRateEvidence_startIndex = 0;(localVars.queryResGetOrderExchangeRateEvidence_outParamList,localVars.queryResGetOrderExchangeRateEvidence_outParamCount) = await FuncDataActionGetAccountingData.datasetGetOrderExchangeRateEvidence(requestContext,datasetGetOrderExchangeRateEvidence_maxRecords,datasetGetOrderExchangeRateEvidence_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Query datasetGetMainOrderAccConceptsFiniquito
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainOrderAccConceptsFiniquito_maxRecords = 1;
if (datasetGetMainOrderAccConceptsFiniquito_maxRecords < 1) datasetGetMainOrderAccConceptsFiniquito_maxRecords = 1;
int datasetGetMainOrderAccConceptsFiniquito_startIndex = 0;(localVars.queryResGetMainOrderAccConceptsFiniquito_outParamList,localVars.queryResGetMainOrderAccConceptsFiniquito_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainOrderAccConceptsFiniquito(requestContext,datasetGetMainOrderAccConceptsFiniquito_maxRecords,datasetGetMainOrderAccConceptsFiniquito_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting.ssId,cancellationToken);

// Query datasetGetSubOrderAccConceptsFiniquito
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubOrderAccConceptsFiniquito_maxRecords = 0;
int datasetGetSubOrderAccConceptsFiniquito_startIndex = 0;(localVars.queryResGetSubOrderAccConceptsFiniquito_outParamList,localVars.queryResGetSubOrderAccConceptsFiniquito_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubOrderAccConceptsFiniquito(requestContext,datasetGetSubOrderAccConceptsFiniquito_maxRecords,datasetGetSubOrderAccConceptsFiniquito_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainOrderAccConceptsFiniquito_outParamList.CurrentRec.ssENOrderAccConcepts.ssId,cancellationToken);

// Query datasetGetMainOrderAccConceptsAnticipo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetMainOrderAccConceptsAnticipo_maxRecords = 1;
if (datasetGetMainOrderAccConceptsAnticipo_maxRecords < 1) datasetGetMainOrderAccConceptsAnticipo_maxRecords = 1;
int datasetGetMainOrderAccConceptsAnticipo_startIndex = 0;(localVars.queryResGetMainOrderAccConceptsAnticipo_outParamList,localVars.queryResGetMainOrderAccConceptsAnticipo_outParamCount) = await FuncDataActionGetAccountingData.datasetGetMainOrderAccConceptsAnticipo(requestContext,datasetGetMainOrderAccConceptsAnticipo_maxRecords,datasetGetMainOrderAccConceptsAnticipo_startIndex,IterationMultiplicity.Never,localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting.ssId,cancellationToken);

// Query datasetGetSubOrderAccConceptsAnticipo
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSubOrderAccConceptsAnticipo_maxRecords = 0;
int datasetGetSubOrderAccConceptsAnticipo_startIndex = 0;(localVars.queryResGetSubOrderAccConceptsAnticipo_outParamList,localVars.queryResGetSubOrderAccConceptsAnticipo_outParamCount) = await FuncDataActionGetAccountingData.datasetGetSubOrderAccConceptsAnticipo(requestContext,datasetGetSubOrderAccConceptsAnticipo_maxRecords,datasetGetSubOrderAccConceptsAnticipo_startIndex,IterationMultiplicity.Multiple,localVars.queryResGetMainOrderAccConceptsAnticipo_outParamList.CurrentRec.ssENOrderAccConcepts.ssId,cancellationToken);

// OrderAccounting = GetOrderAccountingsByOrderId.List.Current.OrderAccounting
result.outParamOrderAccounting=localVars.queryResGetOrderAccountingsByOrderId_outParamList.CurrentRec.ssENOrderAccounting;

// o_Estim_Equal_Agreed.MainAccConcept = GetMainOrderAccConcepts.List.Current.OrderAccConcepts
result.outParamo_Estim_Equal_Agreed.ssENMainAccConcept = localVars.queryResGetMainOrderAccConcepts_outParamList.CurrentRec.ssENOrderAccConcepts;

// o_Estim_Equal_Agreed.SubAccConcepts = GetSubOrderAccConcepts.List
result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts = (await RL_8927ac1c2e0370738b28382fb988b5ee.ConvertAsync(localVars.queryResGetSubOrderAccConcepts_outParamList, new RL_8927ac1c2e0370738b28382fb988b5ee(), async (RC_dc9a6819825fee88eba01192ae9b1890 source, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// o_ExchangeRateEvidence = GetOrderExchangeRateEvidence.List.Current
result.outParamo_ExchangeRateEvidence=(await RecordUtils.ConvertAsync(localVars.queryResGetOrderExchangeRateEvidence_outParamList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));

// o_CreditNote.MainAccConcept = GetMainOrderAccConceptsCreditNote.List.Current.OrderAccConcepts
result.outParamo_CreditNote.ssENMainAccConcept = localVars.queryResGetMainOrderAccConceptsCreditNote_outParamList.CurrentRec.ssENOrderAccConcepts;

// o_CreditNote.SubAccConcepts = GetSubOrderAccConceptsCreditNote.List
result.outParamo_CreditNote.ssRLSubAccConcepts = (await RL_8927ac1c2e0370738b28382fb988b5ee.ConvertAsync(localVars.queryResGetSubOrderAccConceptsCreditNote_outParamList, new RL_8927ac1c2e0370738b28382fb988b5ee(), async (RC_dc9a6819825fee88eba01192ae9b1890 source, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// o_Voucher.MainAccConcept = GetMainOrderAccConceptsVoucher.List.Current.OrderAccConcepts
result.outParamo_Voucher.ssENMainAccConcept = localVars.queryResGetMainOrderAccConceptsVoucher_outParamList.CurrentRec.ssENOrderAccConcepts;

// o_Voucher.SubAccConcepts = GetSubOrderAccConceptsVoucher.List
result.outParamo_Voucher.ssRLSubAccConcepts = (await RL_8927ac1c2e0370738b28382fb988b5ee.ConvertAsync(localVars.queryResGetSubOrderAccConceptsVoucher_outParamList, new RL_8927ac1c2e0370738b28382fb988b5ee(), async (RC_dc9a6819825fee88eba01192ae9b1890 source, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// o_Finiquito.MainAccConcept = GetMainOrderAccConceptsFiniquito.List.Current.OrderAccConcepts
result.outParamo_Finiquito.ssENMainAccConcept = localVars.queryResGetMainOrderAccConceptsFiniquito_outParamList.CurrentRec.ssENOrderAccConcepts;

// o_Finiquito.SubAccConcepts = GetSubOrderAccConceptsFiniquito.List
result.outParamo_Finiquito.ssRLSubAccConcepts = (await RL_8927ac1c2e0370738b28382fb988b5ee.ConvertAsync(localVars.queryResGetSubOrderAccConceptsFiniquito_outParamList, new RL_8927ac1c2e0370738b28382fb988b5ee(), async (RC_dc9a6819825fee88eba01192ae9b1890 source, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));

// o_Anticipo.MainAccConcept = GetMainOrderAccConceptsAnticipo.List.Current.OrderAccConcepts
result.outParamo_Anticipo.ssENMainAccConcept = localVars.queryResGetMainOrderAccConceptsAnticipo_outParamList.CurrentRec.ssENOrderAccConcepts;

// o_Anticipo.SubAccConcepts = GetSubOrderAccConceptsAnticipo.List
result.outParamo_Anticipo.ssRLSubAccConcepts = (await RL_8927ac1c2e0370738b28382fb988b5ee.ConvertAsync(localVars.queryResGetSubOrderAccConceptsAnticipo_outParamList, new RL_8927ac1c2e0370738b28382fb988b5ee(), async (RC_dc9a6819825fee88eba01192ae9b1890 source, EN_3e07a23619060cc7dc5624548803f5fdEntityRecord target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
if((localVars.queryResGetOrderAccountingsByOrderId_outParamList.Empty)) {
// Query datasetGetOrderMainExchangeRate
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainExchangeRate_maxRecords = 1;
if (datasetGetOrderMainExchangeRate_maxRecords < 1) datasetGetOrderMainExchangeRate_maxRecords = 1;
int datasetGetOrderMainExchangeRate_startIndex = 0;(localVars.queryResGetOrderMainExchangeRate_outParamList,localVars.queryResGetOrderMainExchangeRate_outParamCount) = await FuncDataActionGetAccountingData.datasetGetOrderMainExchangeRate(requestContext,datasetGetOrderMainExchangeRate_maxRecords,datasetGetOrderMainExchangeRate_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// Set ExchangeRate if not setted
// OrderAccounting.NegociatedExchangeRateAcc = GetOrderMainExchangeRate.List.Current.ExchangeRate
result.outParamOrderAccounting.ssNegociatedExchangeRateAcc = localVars.queryResGetOrderMainExchangeRate_outParamList.CurrentRec.ssExchangeRate;
}

// GetSubAccConcepts empty?
if((result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts.Empty)) {
// ListAppend
await ExtendedActions.ListAppend(requestContext,result.outParamo_Estim_Equal_Agreed.ssRLSubAccConcepts,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = BuiltInFunction.NullIdentifier (), ssOrderAccConceptsId = localVars.queryResGetMainOrderAccConcepts_outParamList.CurrentRec.ssENOrderAccConcepts.ssId },cancellationToken);

}

// GetSubAccConceptsCreditNote empty?
if((result.outParamo_CreditNote.ssRLSubAccConcepts.Empty)) {
// ListAppendCreditNote
await ExtendedActions.ListAppend(requestContext,result.outParamo_CreditNote.ssRLSubAccConcepts,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = 5, ssOrderAccConceptsId = localVars.queryResGetMainOrderAccConceptsCreditNote_outParamList.CurrentRec.ssENOrderAccConcepts.ssId },cancellationToken);

}

// GetSubAccConceptsVoucher empty?
if((result.outParamo_Voucher.ssRLSubAccConcepts.Empty)) {
// ListAppendVoucher
await ExtendedActions.ListAppend(requestContext,result.outParamo_Voucher.ssRLSubAccConcepts,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = 6, ssOrderAccConceptsId = localVars.queryResGetMainOrderAccConceptsVoucher_outParamList.CurrentRec.ssENOrderAccConcepts.ssId },cancellationToken);

}

// GetSubAccConceptsFiniquito empty?
if((result.outParamo_Finiquito.ssRLSubAccConcepts.Empty)) {
// ListAppendFiniquito
await ExtendedActions.ListAppend(requestContext,result.outParamo_Finiquito.ssRLSubAccConcepts,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = 4, ssOrderAccConceptsId = localVars.queryResGetMainOrderAccConceptsFiniquito_outParamList.CurrentRec.ssENOrderAccConcepts.ssId },cancellationToken);

}

// GetSubAccConceptsAnticipo empty?
if((result.outParamo_Anticipo.ssRLSubAccConcepts.Empty)) {
// ListAppendAnticipo
await ExtendedActions.ListAppend(requestContext,result.outParamo_Anticipo.ssRLSubAccConcepts,new EN_3e07a23619060cc7dc5624548803f5fdEntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssAccountingDataTypeId = 8, ssOrderAccConceptsId = localVars.queryResGetMainOrderAccConceptsAnticipo_outParamList.CurrentRec.ssENOrderAccConcepts.ssId },cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamOrderAccounting = result.outParamOrderAccounting;
outParamo_ExchangeRateEvidence = result.outParamo_ExchangeRateEvidence;
outParamo_Estim_Equal_Agreed = result.outParamo_Estim_Equal_Agreed;
outParamo_CreditNote = result.outParamo_CreditNote;
outParamo_Voucher = result.outParamo_Voucher;
outParamo_Finiquito = result.outParamo_Finiquito;
outParamo_Anticipo = result.outParamo_Anticipo;
} // inner-finally
RETURN_STATEMENT:
return (outParamOrderAccounting,outParamo_ExchangeRateEvidence,outParamo_Estim_Equal_Agreed,outParamo_CreditNote,outParamo_Voucher,outParamo_Finiquito,outParamo_Anticipo);
}
public class lcvGetOrderContractData : VarsBag {
public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterPendingJustif_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterDeposit_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterInsurance_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterAdvancePayment_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterContract_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterNullIdentifier_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf queryResGetOrderFiles_outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
public long queryResGetOrderFiles_outParamCount = 0L;

public lcvGetOrderContractData() {
}
}
public class lcoGetOrderContractData : VarsBag {
public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractFile = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_AttachFilesList = new RL_3d745491e03d6d19ccc0e1b33a371ccc();

public RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractDepositList = new RL_3d745491e03d6d19ccc0e1b33a371ccc();

public RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractInsuranceList = new RL_3d745491e03d6d19ccc0e1b33a371ccc();

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractAdvancePayment = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractPendingJustification = new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure();

public lcoGetOrderContractData() {
}
}
/// <summary>
/// Action <code>GetOrderContractData</code> that represents the Service Studio action
///  <code>GetOrderContractData</code> <p> Description: Data Action that fetchs Order Contrac
/// t Data.</p>
/// </summary>
public async Task<(ST_c3df6a1f053620bf8d50da58ff4e41bcStructure,RL_3d745491e03d6d19ccc0e1b33a371ccc,RL_3d745491e03d6d19ccc0e1b33a371ccc,RL_3d745491e03d6d19ccc0e1b33a371ccc,ST_c3df6a1f053620bf8d50da58ff4e41bcStructure,ST_c3df6a1f053620bf8d50da58ff4e41bcStructure)> DataActionGetOrderContractData(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractFile = default;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_AttachFilesList = default;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractDepositList = default;
RL_3d745491e03d6d19ccc0e1b33a371ccc outParamo_ContractInsuranceList = default;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractAdvancePayment = default;
ST_c3df6a1f053620bf8d50da58ff4e41bcStructure outParamo_ContractPendingJustification = default;
lcoGetOrderContractData result = new lcoGetOrderContractData();
lcvGetOrderContractData localVars = new lcvGetOrderContractData();
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderContractData", "dbee65ff-58a3-452c-a32e-1d32d51c5ac5"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation_13008", "GetOrderContractData")){
// Query datasetGetOrderFiles
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderFiles_maxRecords = 0;
int datasetGetOrderFiles_startIndex = 0;(localVars.queryResGetOrderFiles_outParamList,localVars.queryResGetOrderFiles_outParamCount) = await FuncDataActionGetOrderContractData.datasetGetOrderFiles(requestContext,datasetGetOrderFiles_maxRecords,datasetGetOrderFiles_startIndex,IterationMultiplicity.Multiple,inParami_OrderId,cancellationToken);

// ListFilterDeposit
localVars.resListFilterDeposit_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (localVars.queryResGetOrderFiles_outParamList.CurrentRec.ssENOrderContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("LL0EEo6QjEia4MHtbq4Wcg"))).ssId), cancellationToken)));

// Foreach ListFilterDeposit.FilteredList
localVars.resListFilterDeposit_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterDeposit_outParamFilteredList.Eof))) {
// Has File?
if(((localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ListAppendDeposit
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractDepositList,new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(){ ssOrderContractFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderContractFile, ssOrderFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderFile },cancellationToken);

} else {
// ListAppendDepositNoFile
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractDepositList,new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(){ ssOrderContractFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderContractFile, ssOrderFile = localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderFile },cancellationToken);

}

localVars.resListFilterDeposit_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterDeposit_outParamFilteredList.EndIteration();
}

// ListFilterInsurance
localVars.resListFilterInsurance_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("r4jSUQNmxUqnB9v839cdug"))).ssId), cancellationToken)));

// Foreach ListFilterInsurance.FilteredList
localVars.resListFilterInsurance_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterInsurance_outParamFilteredList.Eof))) {
// Has File?
if(((localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ListAppendInsurance
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractInsuranceList,new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(){ ssOrderContractFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENOrderContractFile, ssOrderFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENOrderFile },cancellationToken);

} else {
// ListAppendInsuranceNoFile
await ExtendedActions.ListAppend(requestContext,result.outParamo_ContractInsuranceList,new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(){ ssOrderContractFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENOrderContractFile, ssOrderFile = localVars.resListFilterInsurance_outParamFilteredList.CurrentRec.ssENOrderFile },cancellationToken);

}

localVars.resListFilterInsurance_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterInsurance_outParamFilteredList.EndIteration();
}

// ListFilterAdvancePayment
localVars.resListFilterAdvancePayment_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("O7ktjb0qHUO1JVHd3pyUOA"))).ssId), cancellationToken)));

// Has file?
if(((localVars.resListFilterAdvancePayment_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ContractAdvancePayment
// o_ContractAdvancePayment = ListFilterAdvancePayment.FilteredList.Current
result.outParamo_ContractAdvancePayment=(await RecordUtils.ConvertAsync(localVars.resListFilterAdvancePayment_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));
} else {
// ContractAdvancePayment
// o_ContractAdvancePayment = ListFilterAdvancePayment.FilteredList.Current
result.outParamo_ContractAdvancePayment=(await RecordUtils.ConvertAsync(localVars.resListFilterAdvancePayment_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));
}

// ListFilterNullIdentifier
localVars.resListFilterNullIdentifier_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderContractFile.ssContractFileTypeId==BuiltInFunction.NullIdentifier ()), cancellationToken)));

// Foreach ListFilterNullIdentifier.FilteredList
localVars.resListFilterNullIdentifier_outParamFilteredList.StartIteration();
try {while (!((localVars.resListFilterNullIdentifier_outParamFilteredList.Eof))) {
// Has File?
if(((localVars.resListFilterDeposit_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// ListAppendAttachFiles
await ExtendedActions.ListAppend(requestContext,result.outParamo_AttachFilesList,new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(){ ssOrderContractFile = localVars.resListFilterNullIdentifier_outParamFilteredList.CurrentRec.ssENOrderContractFile, ssOrderFile = localVars.resListFilterNullIdentifier_outParamFilteredList.CurrentRec.ssENOrderFile },cancellationToken);

}

localVars.resListFilterNullIdentifier_outParamFilteredList.Advance();
}

} finally {
localVars.resListFilterNullIdentifier_outParamFilteredList.EndIteration();
}

// ListFilterContract
localVars.resListFilterContract_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("G8yzk1VC6kuuzlQ40OJi8Q"))).ssId), cancellationToken)));

// Has file?
if(((localVars.resListFilterContract_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Output
// o_ContractFile = ListFilterContract.FilteredList.Current
result.outParamo_ContractFile=(await RecordUtils.ConvertAsync(localVars.resListFilterContract_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));
} else {
// Contract
// o_ContractFile = ListFilterContract.FilteredList.Current
result.outParamo_ContractFile=(await RecordUtils.ConvertAsync(localVars.resListFilterContract_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));
}

// ListFilterPendingJustif
localVars.resListFilterPendingJustif_outParamFilteredList = (((RL_16bc0f170c91ed9fd3ef42e01c4db2cf)await  localVars.queryResGetOrderFiles_outParamList.FilterAsync(async (p, cancellationToken) => (p.ssENOrderContractFile.ssContractFileTypeId==(ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("KQCdGM5P7k+IR4O+zSRfKA"))).ssId), cancellationToken)));

// Has file?
if(((localVars.resListFilterPendingJustif_outParamFilteredList.CurrentRec.ssENOrderFile.ssStorageId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// PendingJustif
// o_ContractPendingJustification = ListFilterPendingJustif.FilteredList.Current
result.outParamo_ContractPendingJustification=(await RecordUtils.ConvertAsync(localVars.resListFilterPendingJustif_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
return target;
}, cancellationToken));
}

// PendingJustif
// o_ContractPendingJustification = ListFilterPendingJustif.FilteredList.Current
result.outParamo_ContractPendingJustification=(await RecordUtils.ConvertAsync(localVars.resListFilterPendingJustif_outParamFilteredList.CurrentRec, new ST_c3df6a1f053620bf8d50da58ff4e41bcStructure(), async (RC_8171c5e0188443e9384b8f5492517b0e source, ST_c3df6a1f053620bf8d50da58ff4e41bcStructure target, CancellationToken cancellationToken) => {
target.ssOrderContractFile = source.ssENOrderContractFile;
target.ssOrderFile = source.ssENOrderFile;
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


    public static class FuncDataActionGetOrderFilesList {

private static async Task<RC_041cacb77c43fb5e1fc788222594e8fd> datasetGetOrderFinanceFileReadDbAsync(RC_041cacb77c43fb5e1fc788222594e8fd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFinanceFile.Read( r, ref index);
rec.ssENOrderFinanceFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFinanceFile" qcozWREluUCMo8orosbOVw of Action "GetOrderFilesList"
public static async Task<(RL_eeab316051f92c8094cbc73a8650f55b,long)> datasetGetOrderFinanceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderFinanceFile", "5933caa9-2511-40b9-8ca3-ca2ba2c6ce57");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderFinanceFile", "5933caa9-2511-40b9-8ca3-ca2ba2c6ce57", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.nnEpGacB7UWKjyYYymtRLA/NodesNotShownInESpaceTree.qcozWREluUCMo8orosbOVw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfinancefile\".\"id\" o0, \"enordercontractfinancefile\".\"orderid\" o1, \"enordercontractfinancefile\".\"orderfileid\" o2, \"enordercontractfinancefile\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfinancefile\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfinancefile\".\"tarif\"::numeric) o5, \"enordercontractfinancefile\".\"currencyid\" o6, \"enordercontractfinancefile\".\"deposittypeid\" o7, \"enordercontractfinancefile\".\"insurancetypeid\" o8, \"enordercontractfinancefile\".\"advancepaymenttypeid\" o9, \"enordercontractfinancefile\".\"startbasedate\" o10, \"enordercontractfinancefile\".\"endbasedate\" o11, \"enordercontractfinancefile\".\"paymenttermsid\" o12, \"enordercontractfinancefile\".\"isforvendorupload\" o13, \"enorderfinancefile\".\"id\" o14, \"enorderfinancefile\".\"filename\" o15, \"enorderfinancefile\".\"vendor\" o16, \"enorderfinancefile\".\"doc_type\" o17, \"enorderfinancefile\".\"sap_object\" o18, \"enorderfinancefile\".\"createdby\" o19, \"enorderfinancefile\".\"createdon\" o20, \"enorderfinancefile\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfinancefile\" Left JOIN {OrderFile} \"enorderfinancefile\" ON (\"enordercontractfinancefile\".\"orderfileid\" = \"enorderfinancefile\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfinancefile\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfinancefile\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfinancefile\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfinancefile\".\"contractfiletypeid\" = ");
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
RL_eeab316051f92c8094cbc73a8650f55b outParamList = new RL_eeab316051f92c8094cbc73a8650f55b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderFinanceFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderFinanceFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_eeab316051f92c8094cbc73a8650f55b _tmp = new RL_eeab316051f92c8094cbc73a8650f55b();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderFinanceFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderFinanceFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_eeab316051f92c8094cbc73a8650f55b)_tmp;
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

private static async Task<RC_55a4f62f090e92d07d40f0b63ffe2d16> datasetGetOrderForeignResidenceFileReadDbAsync(RC_55a4f62f090e92d07d40f0b63ffe2d16 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFileForeignResidence.Read( r, ref index);
rec.ssENOrderFileForeignResidence.Read( r, ref index);
return rec;
}
// Query Function "GetOrderForeignResidenceFile" mKPXadOxIEKNYeQexU+xLw of Action "GetOrderFilesList"
public static async Task<(RL_5305c20f972277b55d855aa236dd3fba,long)> datasetGetOrderForeignResidenceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderForeignResidenceFile", "69d7a398-b1d3-4220-8d61-e41ec54fb12f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderForeignResidenceFile", "69d7a398-b1d3-4220-8d61-e41ec54fb12f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.nnEpGacB7UWKjyYYymtRLA/NodesNotShownInESpaceTree.mKPXadOxIEKNYeQexU+xLw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfileforeignresidence\".\"id\" o0, \"enordercontractfileforeignresidence\".\"orderid\" o1, \"enordercontractfileforeignresidence\".\"orderfileid\" o2, \"enordercontractfileforeignresidence\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfileforeignresidence\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfileforeignresidence\".\"tarif\"::numeric) o5, \"enordercontractfileforeignresidence\".\"currencyid\" o6, \"enordercontractfileforeignresidence\".\"deposittypeid\" o7, \"enordercontractfileforeignresidence\".\"insurancetypeid\" o8, \"enordercontractfileforeignresidence\".\"advancepaymenttypeid\" o9, \"enordercontractfileforeignresidence\".\"startbasedate\" o10, \"enordercontractfileforeignresidence\".\"endbasedate\" o11, \"enordercontractfileforeignresidence\".\"paymenttermsid\" o12, \"enordercontractfileforeignresidence\".\"isforvendorupload\" o13, \"enorderfileforeignresidence\".\"id\" o14, \"enorderfileforeignresidence\".\"filename\" o15, \"enorderfileforeignresidence\".\"vendor\" o16, \"enorderfileforeignresidence\".\"doc_type\" o17, \"enorderfileforeignresidence\".\"sap_object\" o18, \"enorderfileforeignresidence\".\"createdby\" o19, \"enorderfileforeignresidence\".\"createdon\" o20, \"enorderfileforeignresidence\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderFile} \"enorderfileforeignresidence\" Left JOIN {OrderContractFile} \"enordercontractfileforeignresidence\" ON (\"enorderfileforeignresidence\".\"id\" = \"enordercontractfileforeignresidence\".\"orderfileid\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfileforeignresidence\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfileforeignresidence\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfileforeignresidence\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfileforeignresidence\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enorderfileforeignresidence\".\"filename\" ASC ");
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
RL_5305c20f972277b55d855aa236dd3fba outParamList = new RL_5305c20f972277b55d855aa236dd3fba();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderForeignResidenceFileReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderForeignResidenceFile.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5305c20f972277b55d855aa236dd3fba _tmp = new RL_5305c20f972277b55d855aa236dd3fba();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderForeignResidenceFileReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderFilesList.GetOrderForeignResidenceFile.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5305c20f972277b55d855aa236dd3fba)_tmp;
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
public static class FuncDataActionGetPaymentTermSpecial {

// Query Function "GetPaymentTermsIsSpecial" FlXpc4iYakuLA2rQODKv1A of Action "GetPaymentTermSpecial"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTermsIsSpecial(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTermSpecial.GetPaymentTermsIsSpecial", "73e95516-9888-4b6a-8b03-6ad03832afd4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTermSpecial.GetPaymentTermsIsSpecial", "73e95516-9888-4b6a-8b03-6ad03832afd4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.PdANiE21Mku929m3L812gQ/NodesNotShownInESpaceTree.FlXpc4iYakuLA2rQODKv1A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms23\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms23\"");
whereBuilder.Append(" WHERE (\"enpaymentterms23\".\"isspecial\" = 1)");
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
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTermSpecial.GetPaymentTermsIsSpecial.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetPaymentTermSpecial.GetPaymentTermsIsSpecial.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetAccountingData {

// Query Function "GetOrderMainExchangeRate" 0Q6OE1kaN065qXuyM5tpQA of Action "GetAccountingData"
public static async Task<(RL_06217d1a1f91440a5a69e4163e3e2c6f,long)> datasetGetOrderMainExchangeRate(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderMainExchangeRate", "138e0ed1-1a59-4e37-b9a9-7bb2339b6940");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderMainExchangeRate", "138e0ed1-1a59-4e37-b9a9-7bb2339b6940", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.0Q6OE1kaN065qXuyM5tpQA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain97\".\"exchangerate\" \"exchangerate\"");
fromBuilder.Append(" FROM {OrderMain} \"enordermain97\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain97\".\"id\" = @qporId) AND (\"enordermain97\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain97\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enordermain97\".\"exchangerate\"");
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
RL_06217d1a1f91440a5a69e4163e3e2c6f outParamList = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderMainExchangeRate.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_06217d1a1f91440a5a69e4163e3e2c6f _tmp = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderMainExchangeRate.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_06217d1a1f91440a5a69e4163e3e2c6f)_tmp;
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

// Query Function "GetMainOrderAccConceptsAnticipo" ANJWIGLSLE6Yj5Xkr569+g of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsAnticipo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsAnticipo", "2056d200-d262-4e2c-988f-95e4af9ebdfa");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsAnticipo", "2056d200-d262-4e2c-988f-95e4af9ebdfa", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.ANJWIGLSLE6Yj5Xkr569+g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts13\".\"id\" o0, \"enorderaccconcepts13\".\"orderaccountingid\" o1, \"enorderaccconcepts13\".\"accountingdatatypeid\" o2, \"enorderaccconcepts13\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts13\".\"amount\"::numeric) o4, \"enorderaccconcepts13\".\"currencyid\" o5, \"enorderaccconcepts13\".\"orderaccconceptsid\" o6, \"enorderaccconcepts13\".\"applyforrequestproject\" o7, \"enorderaccconcepts13\".\"paymenttermid\" o8, \"enorderaccconcepts13\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts13\".\"isactive\" o10, \"enorderaccconcepts13\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts13\".\"paymentdate\" o12, \"enorderaccconcepts13\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts13\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts13\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts13\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts13\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts13\".\"accountingdatatypeid\" = ");
whereBuilder.Append(8
);
whereBuilder.Append(") AND (\"enorderaccconcepts13\".\"orderaccconceptsid\" IS NULL)");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetSubOrderAccConceptsVoucher" pH_8LGyoZ06bb2XCAkGKVA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsVoucher(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsVoucher", "2cfc7fa4-a86c-4e67-9b6f-65c202418a54");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsVoucher", "2cfc7fa4-a86c-4e67-9b6f-65c202418a54", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.pH_8LGyoZ06bb2XCAkGKVA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts14\".\"id\" o0, \"enorderaccconcepts14\".\"orderaccountingid\" o1, \"enorderaccconcepts14\".\"accountingdatatypeid\" o2, \"enorderaccconcepts14\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts14\".\"amount\"::numeric) o4, \"enorderaccconcepts14\".\"currencyid\" o5, \"enorderaccconcepts14\".\"orderaccconceptsid\" o6, \"enorderaccconcepts14\".\"applyforrequestproject\" o7, \"enorderaccconcepts14\".\"paymenttermid\" o8, \"enorderaccconcepts14\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts14\".\"isactive\" o10, \"enorderaccconcepts14\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts14\".\"paymentdate\" o12, \"enorderaccconcepts14\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts14\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts14\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts14\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts14\".\"orderaccconceptsid\" IS NULL)");
}
whereBuilder.Append(" AND (@qporOrderAccConceptsId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetMainOrderAccConceptsVoucher" RI8pLYUCVUWw9F09OqTqBw of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsVoucher(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsVoucher", "2d298f44-0285-4555-b0f4-5d3d3aa4ea07");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsVoucher", "2d298f44-0285-4555-b0f4-5d3d3aa4ea07", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.RI8pLYUCVUWw9F09OqTqBw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts15\".\"id\" o0, \"enorderaccconcepts15\".\"orderaccountingid\" o1, \"enorderaccconcepts15\".\"accountingdatatypeid\" o2, \"enorderaccconcepts15\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts15\".\"amount\"::numeric) o4, \"enorderaccconcepts15\".\"currencyid\" o5, \"enorderaccconcepts15\".\"orderaccconceptsid\" o6, \"enorderaccconcepts15\".\"applyforrequestproject\" o7, \"enorderaccconcepts15\".\"paymenttermid\" o8, \"enorderaccconcepts15\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts15\".\"isactive\" o10, \"enorderaccconcepts15\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts15\".\"paymentdate\" o12, \"enorderaccconcepts15\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts15\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts15\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts15\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts15\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts15\".\"accountingdatatypeid\" = ");
whereBuilder.Append(6
);
whereBuilder.Append(") AND (\"enorderaccconcepts15\".\"orderaccconceptsid\" IS NULL)");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetSubOrderAccConceptsFiniquito" de63N3rBG0W2MgXllWc0bQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsFiniquito(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsFiniquito", "37b7ee75-c17a-451b-b632-05e59567346d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsFiniquito", "37b7ee75-c17a-451b-b632-05e59567346d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.de63N3rBG0W2MgXllWc0bQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts16\".\"id\" o0, \"enorderaccconcepts16\".\"orderaccountingid\" o1, \"enorderaccconcepts16\".\"accountingdatatypeid\" o2, \"enorderaccconcepts16\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts16\".\"amount\"::numeric) o4, \"enorderaccconcepts16\".\"currencyid\" o5, \"enorderaccconcepts16\".\"orderaccconceptsid\" o6, \"enorderaccconcepts16\".\"applyforrequestproject\" o7, \"enorderaccconcepts16\".\"paymenttermid\" o8, \"enorderaccconcepts16\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts16\".\"isactive\" o10, \"enorderaccconcepts16\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts16\".\"paymentdate\" o12, \"enorderaccconcepts16\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts16\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts16\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts16\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts16\".\"orderaccconceptsid\" IS NULL)");
}
whereBuilder.Append(" AND (@qporOrderAccConceptsId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetOrderAccountingsByOrderId" IttWSspToUmK1buYsjB42Q of Action "GetAccountingData"
public static async Task<(RL_aedf606f6413243cfacf43ac13db404f,long)> datasetGetOrderAccountingsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderAccountingsByOrderId", "4a56db22-53ca-49a1-8ad5-bb98b23078d9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderAccountingsByOrderId", "4a56db22-53ca-49a1-8ad5-bb98b23078d9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.IttWSspToUmK1buYsjB42Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccounting5\".\"id\" o0, \"enorderaccounting5\".\"orderid\" o1, \"enorderaccounting5\".\"hasestim_equal_agrepaym_depr\" o2, \"enorderaccounting5\".\"hassettlement_depr\" o3, \"enorderaccounting5\".\"hascreditnote_depr\" o4, \"enorderaccounting5\".\"hasvoucher_depr\" o5, \"enorderaccounting5\".\"hasspecialpostdeliveryauth\" o6, \"enorderaccounting5\".\"specialpostdeliveryauthid\" o7, trim_scale(\"enorderaccounting5\".\"amount_deprec\"::numeric) o8, \"enorderaccounting5\".\"currencyid_deprec\" o9, \"enorderaccounting5\".\"paymentmethodid_deprec\" o10, \"enorderaccounting5\".\"paymenttermid_deprec\" o11, trim_scale(\"enorderaccounting5\".\"negociatedexchangerateacc\"::numeric) o12, \"enorderaccounting5\".\"exchangeratecomment\" o13, \"enorderaccounting5\".\"evidencefileid\" o14, \"enorderaccounting5\".\"hascontract\" o15, \"enorderaccounting5\".\"hasrepse\" o16, \"enorderaccounting5\".\"haspaymentsupplement\" o17, \"enorderaccounting5\".\"hasnoticeofpaymentsuspension\" o18");
fromBuilder.Append(" FROM {OrderAccounting} \"enorderaccounting5\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderaccounting5\".\"orderid\" = @qporOrderId) AND (\"enorderaccounting5\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderaccounting5\".\"orderid\" IS NULL)");
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
RL_aedf606f6413243cfacf43ac13db404f outParamList = new RL_aedf606f6413243cfacf43ac13db404f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_aedf606f6413243cfacf43ac13db404f _tmp = new RL_aedf606f6413243cfacf43ac13db404f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_aedf606f6413243cfacf43ac13db404f)_tmp;
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

// Query Function "GetMainOrderAccConceptsCreditNote" PdO_T3UMJkCFDufT4OxtjA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsCreditNote(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsCreditNote", "4fbfd33d-0c75-4026-850e-e7d3e0ec6d8c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsCreditNote", "4fbfd33d-0c75-4026-850e-e7d3e0ec6d8c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.PdO_T3UMJkCFDufT4OxtjA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts17\".\"id\" o0, \"enorderaccconcepts17\".\"orderaccountingid\" o1, \"enorderaccconcepts17\".\"accountingdatatypeid\" o2, \"enorderaccconcepts17\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts17\".\"amount\"::numeric) o4, \"enorderaccconcepts17\".\"currencyid\" o5, \"enorderaccconcepts17\".\"orderaccconceptsid\" o6, \"enorderaccconcepts17\".\"applyforrequestproject\" o7, \"enorderaccconcepts17\".\"paymenttermid\" o8, \"enorderaccconcepts17\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts17\".\"isactive\" o10, \"enorderaccconcepts17\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts17\".\"paymentdate\" o12, \"enorderaccconcepts17\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts17\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts17\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts17\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts17\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts17\".\"accountingdatatypeid\" = ");
whereBuilder.Append(5
);
whereBuilder.Append(") AND (\"enorderaccconcepts17\".\"orderaccconceptsid\" IS NULL)");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

private static async Task<RC_8171c5e0188443e9384b8f5492517b0e> datasetGetOrderExchangeRateEvidenceReadDbAsync(RC_8171c5e0188443e9384b8f5492517b0e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderExchangeRateEvidence" KmRJh_p5Mkeq2tWuHVdV7Q of Action "GetAccountingData"
public static async Task<(RL_16bc0f170c91ed9fd3ef42e01c4db2cf,long)> datasetGetOrderExchangeRateEvidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderExchangeRateEvidence", "8749642a-79fa-4732-aada-d5ae1d5755ed");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderExchangeRateEvidence", "8749642a-79fa-4732-aada-d5ae1d5755ed", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.KmRJh_p5Mkeq2tWuHVdV7Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfile6\".\"id\" o0, \"enordercontractfile6\".\"orderid\" o1, \"enordercontractfile6\".\"orderfileid\" o2, \"enordercontractfile6\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfile6\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfile6\".\"tarif\"::numeric) o5, \"enordercontractfile6\".\"currencyid\" o6, \"enordercontractfile6\".\"deposittypeid\" o7, \"enordercontractfile6\".\"insurancetypeid\" o8, \"enordercontractfile6\".\"advancepaymenttypeid\" o9, \"enordercontractfile6\".\"startbasedate\" o10, \"enordercontractfile6\".\"endbasedate\" o11, \"enordercontractfile6\".\"paymenttermsid\" o12, \"enordercontractfile6\".\"isforvendorupload\" o13, \"enorderfile6\".\"id\" o14, \"enorderfile6\".\"filename\" o15, \"enorderfile6\".\"vendor\" o16, \"enorderfile6\".\"doc_type\" o17, \"enorderfile6\".\"sap_object\" o18, \"enorderfile6\".\"createdby\" o19, \"enorderfile6\".\"createdon\" o20, \"enorderfile6\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfile6\" Left JOIN {OrderFile} \"enorderfile6\" ON (\"enordercontractfile6\".\"orderfileid\" = \"enorderfile6\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile6\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile6\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile6\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfile6\".\"contractfiletypeid\" = ");
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
RL_16bc0f170c91ed9fd3ef42e01c4db2cf outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderExchangeRateEvidenceReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderExchangeRateEvidence.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_16bc0f170c91ed9fd3ef42e01c4db2cf _tmp = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderExchangeRateEvidenceReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetOrderExchangeRateEvidence.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_16bc0f170c91ed9fd3ef42e01c4db2cf)_tmp;
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

// Query Function "GetMainOrderAccConcepts" lir2jxLa20C3F_wJiVnBhA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConcepts", "8ff62a96-da12-40db-b717-fc098959c184");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConcepts", "8ff62a96-da12-40db-b717-fc098959c184", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.lir2jxLa20C3F_wJiVnBhA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts18\".\"id\" o0, \"enorderaccconcepts18\".\"orderaccountingid\" o1, \"enorderaccconcepts18\".\"accountingdatatypeid\" o2, \"enorderaccconcepts18\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts18\".\"amount\"::numeric) o4, \"enorderaccconcepts18\".\"currencyid\" o5, \"enorderaccconcepts18\".\"orderaccconceptsid\" o6, \"enorderaccconcepts18\".\"applyforrequestproject\" o7, \"enorderaccconcepts18\".\"paymenttermid\" o8, \"enorderaccconcepts18\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts18\".\"isactive\" o10, \"enorderaccconcepts18\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts18\".\"paymentdate\" o12, \"enorderaccconcepts18\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts18\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts18\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts18\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts18\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts18\".\"accountingdatatypeid\" = ");
whereBuilder.Append(7
);
whereBuilder.Append(") AND (\"enorderaccconcepts18\".\"orderaccconceptsid\" IS NULL)");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetSubOrderAccConceptsAnticipo" se5DvY4H00uDtaQLxy+4Jg of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsAnticipo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsAnticipo", "bd43eeb1-078e-4bd3-83b5-a40bc72fb826");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsAnticipo", "bd43eeb1-078e-4bd3-83b5-a40bc72fb826", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.se5DvY4H00uDtaQLxy+4Jg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts19\".\"id\" o0, \"enorderaccconcepts19\".\"orderaccountingid\" o1, \"enorderaccconcepts19\".\"accountingdatatypeid\" o2, \"enorderaccconcepts19\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts19\".\"amount\"::numeric) o4, \"enorderaccconcepts19\".\"currencyid\" o5, \"enorderaccconcepts19\".\"orderaccconceptsid\" o6, \"enorderaccconcepts19\".\"applyforrequestproject\" o7, \"enorderaccconcepts19\".\"paymenttermid\" o8, \"enorderaccconcepts19\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts19\".\"isactive\" o10, \"enorderaccconcepts19\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts19\".\"paymentdate\" o12, \"enorderaccconcepts19\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts19\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts19\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts19\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts19\".\"orderaccconceptsid\" IS NULL)");
}
whereBuilder.Append(" AND (@qporOrderAccConceptsId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetSubOrderAccConceptsCreditNote" dcfjwBEsV0Gs9fa1HSFpGg of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsCreditNote(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsCreditNote", "c0e3c775-2c11-4157-acf5-f6b51d21691a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsCreditNote", "c0e3c775-2c11-4157-acf5-f6b51d21691a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.dcfjwBEsV0Gs9fa1HSFpGg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts20\".\"id\" o0, \"enorderaccconcepts20\".\"orderaccountingid\" o1, \"enorderaccconcepts20\".\"accountingdatatypeid\" o2, \"enorderaccconcepts20\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts20\".\"amount\"::numeric) o4, \"enorderaccconcepts20\".\"currencyid\" o5, \"enorderaccconcepts20\".\"orderaccconceptsid\" o6, \"enorderaccconcepts20\".\"applyforrequestproject\" o7, \"enorderaccconcepts20\".\"paymenttermid\" o8, \"enorderaccconcepts20\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts20\".\"isactive\" o10, \"enorderaccconcepts20\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts20\".\"paymentdate\" o12, \"enorderaccconcepts20\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts20\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts20\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts20\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts20\".\"orderaccconceptsid\" IS NULL)");
}
whereBuilder.Append(" AND (@qporOrderAccConceptsId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetMainOrderAccConceptsFiniquito" RX7pxCEdu0K0pLqhkAfirw of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsFiniquito(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsFiniquito", "c4e97e45-1d21-42bb-b4a4-baa19007e2af");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsFiniquito", "c4e97e45-1d21-42bb-b4a4-baa19007e2af", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.RX7pxCEdu0K0pLqhkAfirw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts21\".\"id\" o0, \"enorderaccconcepts21\".\"orderaccountingid\" o1, \"enorderaccconcepts21\".\"accountingdatatypeid\" o2, \"enorderaccconcepts21\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts21\".\"amount\"::numeric) o4, \"enorderaccconcepts21\".\"currencyid\" o5, \"enorderaccconcepts21\".\"orderaccconceptsid\" o6, \"enorderaccconcepts21\".\"applyforrequestproject\" o7, \"enorderaccconcepts21\".\"paymenttermid\" o8, \"enorderaccconcepts21\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts21\".\"isactive\" o10, \"enorderaccconcepts21\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts21\".\"paymentdate\" o12, \"enorderaccconcepts21\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts21\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts21\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts21\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts21\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts21\".\"accountingdatatypeid\" = ");
whereBuilder.Append(4
);
whereBuilder.Append(") AND (\"enorderaccconcepts21\".\"orderaccconceptsid\" IS NULL)");
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetMainOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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

// Query Function "GetSubOrderAccConcepts" 4SS57NQQEUWX13eKqHjjtA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConcepts", "ecb924e1-10d4-4511-97d7-778aa878e3b4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConcepts", "ecb924e1-10d4-4511-97d7-778aa878e3b4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions.QaRlr8i2F0SZwE_kwelRyQ/NodesNotShownInESpaceTree.4SS57NQQEUWX13eKqHjjtA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts22\".\"id\" o0, \"enorderaccconcepts22\".\"orderaccountingid\" o1, \"enorderaccconcepts22\".\"accountingdatatypeid\" o2, \"enorderaccconcepts22\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts22\".\"amount\"::numeric) o4, \"enorderaccconcepts22\".\"currencyid\" o5, \"enorderaccconcepts22\".\"orderaccconceptsid\" o6, \"enorderaccconcepts22\".\"applyforrequestproject\" o7, \"enorderaccconcepts22\".\"paymenttermid\" o8, \"enorderaccconcepts22\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts22\".\"isactive\" o10, \"enorderaccconcepts22\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts22\".\"paymentdate\" o12, \"enorderaccconcepts22\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts22\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts22\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts22\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts22\".\"orderaccconceptsid\" IS NULL)");
}
whereBuilder.Append(" AND (@qporOrderAccConceptsId <> 0))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
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
RL_f805dfae1f4ccde9f7b0028b80707abe outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_f805dfae1f4ccde9f7b0028b80707abe _tmp = new RL_f805dfae1f4ccde9f7b0028b80707abe();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetAccountingData.GetSubOrderAccConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_f805dfae1f4ccde9f7b0028b80707abe)_tmp;
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
public static class FuncDataActionGetOrderContractData {

private static async Task<RC_8171c5e0188443e9384b8f5492517b0e> datasetGetOrderFilesReadDbAsync(RC_8171c5e0188443e9384b8f5492517b0e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFiles" Xkid+O_bAEioEBChQJ0u6Q of Action "GetOrderContractData"
public static async Task<(RL_16bc0f170c91ed9fd3ef42e01c4db2cf,long)> datasetGetOrderFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderContractData.GetOrderFiles", "f89d485e-dbef-4800-a810-10a1409d2ee9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderContractData.GetOrderFiles", "f89d485e-dbef-4800-a810-10a1409d2ee9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.7FMArN904EGb+cyaANzIWA/DataActions._2Xu26NYLEWjLh0y1RxaxQ/NodesNotShownInESpaceTree.Xkid+O_bAEioEBChQJ0u6Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfile7\".\"id\" o0, \"enordercontractfile7\".\"orderid\" o1, \"enordercontractfile7\".\"orderfileid\" o2, \"enordercontractfile7\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfile7\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfile7\".\"tarif\"::numeric) o5, \"enordercontractfile7\".\"currencyid\" o6, \"enordercontractfile7\".\"deposittypeid\" o7, \"enordercontractfile7\".\"insurancetypeid\" o8, \"enordercontractfile7\".\"advancepaymenttypeid\" o9, \"enordercontractfile7\".\"startbasedate\" o10, \"enordercontractfile7\".\"endbasedate\" o11, \"enordercontractfile7\".\"paymenttermsid\" o12, \"enordercontractfile7\".\"isforvendorupload\" o13, \"enorderfile7\".\"id\" o14, \"enorderfile7\".\"filename\" o15, \"enorderfile7\".\"vendor\" o16, \"enorderfile7\".\"doc_type\" o17, \"enorderfile7\".\"sap_object\" o18, \"enorderfile7\".\"createdby\" o19, \"enorderfile7\".\"createdon\" o20, \"enorderfile7\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderFile} \"enorderfile7\" Inner JOIN {OrderContractFile} \"enordercontractfile7\" ON (\"enorderfile7\".\"id\" = \"enordercontractfile7\".\"orderfileid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile7\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile7\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile7\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderfile7\".\"filename\" ASC ");
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
RL_16bc0f170c91ed9fd3ef42e01c4db2cf outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderFilesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderContractData.GetOrderFiles.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_16bc0f170c91ed9fd3ef42e01c4db2cf _tmp = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderFilesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation_13008.GetOrderContractData.GetOrderFiles.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_16bc0f170c91ed9fd3ef42e01c4db2cf)_tmp;
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


}
