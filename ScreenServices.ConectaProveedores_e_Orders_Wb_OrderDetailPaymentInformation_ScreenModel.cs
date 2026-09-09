using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel).Namespace);

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
public AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes;
public AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes;
public AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays;
public AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes;
public AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories;
public AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> ScreenDataSetGetOrderMainItemsByOrderMainId;
public AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes;
public AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
public AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages;
public AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices;
public AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment;
public AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition;
public AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals;
public AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms;
public AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods;
public AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> ScreenDataSetGetOrderRetentionTypes;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> ScreenDataSetGetOrderMainById;
public AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations;
public AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro;
public AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> ScreenDataSetGetContractStatuses;
public AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers;
public AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Model varLcGetPaymentTermSpecial;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Model varLcGetOrderContractData;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Model varLcGetOrderFilesList;
public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Model varLcGetAccountingData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel() {
}



    public ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel(long inParami_OrderId, DateTime inParami_ForceRefresh, bool varLcl_CanEditForm, RL_3d745491e03d6d19ccc0e1b33a371ccc varLcFilesList, bool varLcl_FormIsValid, RL_9d3b4c4e80b371ac0dc01854afca347a varLcl_OrderRequestFiles, bool varLcShowOrderReject_Popup, string varLcDependentFoliosText, string varLcl_RequestDocsErrorMessage, bool varLcl_IsValidReqDoc, bool varLcl_CanUploadContract, bool varLcl_IsSavingContractFile, bool varLcl_IsMissingEstimEqualAgFiniquito, AggregateRecord<RL_32b3fec96f8ddbf444444f34b158e188> ScreenDataSetGetInsuranceTypes, AggregateRecord<RL_cda7ed93cc851adc2316965418c61e6f> ScreenDataSetGetDepositTypes, AggregateRecord<RL_d98dc7eec8c631266895b622203a6db3> ScreenDataSetGetPaymentWays, AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes, AggregateRecord<RL_901339470d357e86e0df985d0e6489f6> ScreenDataSetGetBusinessValueCategories, AggregateRecord<RL_663d4acde686fb13f7cb44965555ab7f> ScreenDataSetGetOrderMainItemsByOrderMainId, AggregateRecord<RL_0d443dd02abe633532f6b939b4573e00> ScreenDataSetGetAdvancedPaymentTypes, AggregateRecord<RL_2d11b20156650990ba0f3131aaaad2ea> ScreenDataSetGetBusinessValueSubcategoriesByCategoryId, AggregateRecord<RL_1078cb2b44dad3e211c3325e839a4151> ScreenDataSetGetInvoiceUsages, AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServices, AggregateRecord<RL_17d8289ea48572225dc9530a5725652a> ScreenDataSetGetRejectComment, AggregateRecord<RL_d5c1b2482ff109e80580d8b5fb920193> ScreenDataSetGetSupplierByRequisition, AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals, AggregateRecord<RL_375b9dd8c8b0d6d7bccf4d550f48644d> ScreenDataSetGetPaymentTerms, AggregateRecord<RL_0dcbcba642ca8b22e87f690d4de9d077> ScreenDataSetGetPaymentMethods, AggregateRecord<RL_d6a865b9451603b2b07820fedb283c87> ScreenDataSetGetOrderRetentionTypes, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_c5285652b7692ee7ff416f77dcd1fe1c> ScreenDataSetGetOrderMainById, AggregateRecord<RL_9a84f0ca43f575461143a73bcb506dba> ScreenDataSetGetSpecialPostDeliveryAuthorizations, AggregateRecord<RL_39dc6f4415ce9196844d0ada601cc72b> ScreenDataSetGetProjectAssetServiceOtro, AggregateRecord<RL_b597b6c7f7b0a874a3717792e87892bb> ScreenDataSetGetContractStatuses, AggregateRecord<RL_f647e8c4990b814587d1a017e4c9dd44> ScreenDataSetGetSuppliers, AggregateRecord<RL_251acb2daece433ee402c9709ec88356> ScreenDataSetGetPaymentOptions, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetPaymentTermSpecial_Model varLcGetPaymentTermSpecial, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderContractData_Model varLcGetOrderContractData, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetOrderFilesList_Model varLcGetOrderFilesList, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_DataActionGetAccountingData_Model varLcGetAccountingData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "i_ForceRefresh", "l_CanEditForm", "FilesList", "l_FormIsValid", "l_OrderRequestFiles", "ShowOrderReject_Popup", "DependentFoliosText", "l_RequestDocsErrorMessage", "l_IsValidReqDoc", "l_CanUploadContract", "l_IsSavingContractFile", "l_IsMissingEstimEqualAgFiniquito", "GetInsuranceTypes", "GetDepositTypes", "GetPaymentWays", "GetAccountingDataTypes", "GetBusinessValueCategories", "GetOrderMainItemsByOrderMainId", "GetAdvancedPaymentTypes", "GetBusinessValueSubcategoriesByCategoryId", "GetInvoiceUsages", "GetFrequencies", "GetProjectAssetServices", "GetRejectComment", "GetSupplierByRequisition", "GetSpecialApprovals", "GetPaymentTerms", "GetPaymentMethods", "GetOrderRetentionTypes", "GetCurrencies", "GetOrderMainById", "GetSpecialPostDeliveryAuthorizations", "GetProjectAssetServiceOtro", "GetContractStatuses", "GetSuppliers", "GetPaymentOptions", "GetPaymentTermSpecial", "GetOrderContractData", "GetOrderFilesList", "GetAccountingData", "ClientVars"}, new string[] {"inParami_OrderId", "inParami_ForceRefresh", "varLcl_CanEditForm", "varLcFilesList", "varLcl_FormIsValid", "varLcl_OrderRequestFiles", "varLcShowOrderReject_Popup", "varLcDependentFoliosText", "varLcl_RequestDocsErrorMessage", "varLcl_IsValidReqDoc", "varLcl_CanUploadContract", "varLcl_IsSavingContractFile", "varLcl_IsMissingEstimEqualAgFiniquito", "ScreenDataSetGetInsuranceTypes", "ScreenDataSetGetDepositTypes", "ScreenDataSetGetPaymentWays", "ScreenDataSetGetAccountingDataTypes", "ScreenDataSetGetBusinessValueCategories", "ScreenDataSetGetOrderMainItemsByOrderMainId", "ScreenDataSetGetAdvancedPaymentTypes", "ScreenDataSetGetBusinessValueSubcategoriesByCategoryId", "ScreenDataSetGetInvoiceUsages", "ScreenDataSetGetFrequencies", "ScreenDataSetGetProjectAssetServices", "ScreenDataSetGetRejectComment", "ScreenDataSetGetSupplierByRequisition", "ScreenDataSetGetSpecialApprovals", "ScreenDataSetGetPaymentTerms", "ScreenDataSetGetPaymentMethods", "ScreenDataSetGetOrderRetentionTypes", "ScreenDataSetGetCurrencies", "ScreenDataSetGetOrderMainById", "ScreenDataSetGetSpecialPostDeliveryAuthorizations", "ScreenDataSetGetProjectAssetServiceOtro", "ScreenDataSetGetContractStatuses", "ScreenDataSetGetSuppliers", "ScreenDataSetGetPaymentOptions", "varLcGetPaymentTermSpecial", "varLcGetOrderContractData", "varLcGetOrderFilesList", "varLcGetAccountingData", "clientVariables"});
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
this.ScreenDataSetGetInsuranceTypes = ScreenDataSetGetInsuranceTypes;
this.ScreenDataSetGetDepositTypes = ScreenDataSetGetDepositTypes;
this.ScreenDataSetGetPaymentWays = ScreenDataSetGetPaymentWays;
this.ScreenDataSetGetAccountingDataTypes = ScreenDataSetGetAccountingDataTypes;
this.ScreenDataSetGetBusinessValueCategories = ScreenDataSetGetBusinessValueCategories;
this.ScreenDataSetGetOrderMainItemsByOrderMainId = ScreenDataSetGetOrderMainItemsByOrderMainId;
this.ScreenDataSetGetAdvancedPaymentTypes = ScreenDataSetGetAdvancedPaymentTypes;
this.ScreenDataSetGetBusinessValueSubcategoriesByCategoryId = ScreenDataSetGetBusinessValueSubcategoriesByCategoryId;
this.ScreenDataSetGetInvoiceUsages = ScreenDataSetGetInvoiceUsages;
this.ScreenDataSetGetFrequencies = ScreenDataSetGetFrequencies;
this.ScreenDataSetGetProjectAssetServices = ScreenDataSetGetProjectAssetServices;
this.ScreenDataSetGetRejectComment = ScreenDataSetGetRejectComment;
this.ScreenDataSetGetSupplierByRequisition = ScreenDataSetGetSupplierByRequisition;
this.ScreenDataSetGetSpecialApprovals = ScreenDataSetGetSpecialApprovals;
this.ScreenDataSetGetPaymentTerms = ScreenDataSetGetPaymentTerms;
this.ScreenDataSetGetPaymentMethods = ScreenDataSetGetPaymentMethods;
this.ScreenDataSetGetOrderRetentionTypes = ScreenDataSetGetOrderRetentionTypes;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetOrderMainById = ScreenDataSetGetOrderMainById;
this.ScreenDataSetGetSpecialPostDeliveryAuthorizations = ScreenDataSetGetSpecialPostDeliveryAuthorizations;
this.ScreenDataSetGetProjectAssetServiceOtro = ScreenDataSetGetProjectAssetServiceOtro;
this.ScreenDataSetGetContractStatuses = ScreenDataSetGetContractStatuses;
this.ScreenDataSetGetSuppliers = ScreenDataSetGetSuppliers;
this.ScreenDataSetGetPaymentOptions = ScreenDataSetGetPaymentOptions;
this.varLcGetPaymentTermSpecial = varLcGetPaymentTermSpecial;
this.varLcGetOrderContractData = varLcGetOrderContractData;
this.varLcGetOrderFilesList = varLcGetOrderFilesList;
this.varLcGetAccountingData = varLcGetAccountingData;
this.clientVariables = clientVariables;
}



    
// Query Function "GetInsuranceTypes" jVfWCNfvMk2EaAreRQx0nQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_32b3fec96f8ddbf444444f34b158e188,long)> datasetGetInsuranceTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetInsuranceTypes", "08d6578d-efd7-4d32-8468-0ade450c749d");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetInsuranceTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.jVfWCNfvMk2EaAreRQx0nQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninsurancetype1\".\"id\" o0, \"eninsurancetype1\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {InsuranceType} \"eninsurancetype1\"");
whereBuilder.Append(" WHERE (\"eninsurancetype1\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetInsuranceTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetInsuranceTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetDepositTypes" yvZbDtZxVkyYU7HOKZgJaQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_cda7ed93cc851adc2316965418c61e6f,long)> datasetGetDepositTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetDepositTypes", "0e5bf6ca-71d6-4c56-9853-b1ce29980969");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetDepositTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.yvZbDtZxVkyYU7HOKZgJaQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"endeposittype1\".\"id\" o0, \"endeposittype1\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {DepositType} \"endeposittype1\"");
whereBuilder.Append(" WHERE (\"endeposittype1\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetDepositTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetDepositTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentWays" 5HcOJCNaEUi_vQExYxoFJQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_d98dc7eec8c631266895b622203a6db3,long)> datasetGetPaymentWays(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentWays", "240e77e4-5a23-4811-bfbd-0131631a0525");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentWays");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.5HcOJCNaEUi_vQExYxoFJQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentways3\".\"id\" o0, \"enpaymentways3\".\"code\" o1, \"enpaymentways3\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentWays} \"enpaymentways3\"");
whereBuilder.Append(" WHERE ((\"enpaymentways3\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentways3\".\"id\" = @qppaId) AND (\"enpaymentways3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentways3\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentWays.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentWays.List", cancellationToken: cancellationToken);
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

// Query Function "GetAccountingDataTypes" _5rSM_X4j0Cv788VBEYOHA of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingDataTypes", "33d29aff-f8f5-408f-afef-cf1504460e1c");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingDataTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets._5rSM_X4j0Cv788VBEYOHA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype11\".\"id\" o0, \"enaccountingdatatype11\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype11\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype11\".\"is_active\" = 1) AND (\"enaccountingdatatype11\".\"isestim_equal_agreed\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetBusinessValueCategories" qKwkQTBVk0eOg5AhPmr+Pw of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_901339470d357e86e0df985d0e6489f6,long)> datasetGetBusinessValueCategories(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueCategories", "4124aca8-5530-4793-8e83-90213e6afe3f");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueCategories");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.qKwkQTBVk0eOg5AhPmr+Pw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluecategory3\".\"id\" o0, \"enbusinessvaluecategory3\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {BusinessValueCategory} \"enbusinessvaluecategory3\"");
orderByBuilder.Append(" ORDER BY \"enbusinessvaluecategory3\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueCategories.List", cancellationToken: cancellationToken);
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

private static async Task<RC_16678e1ac2e17d1b5db4a9a7f4681e64> datasetGetOrderMainItemsByOrderMainIdReadDbAsync(RC_16678e1ac2e17d1b5db4a9a7f4681e64 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingAccounts_ServiceType.Read( r, ref index);
rec.ssENInvoiceUsage.Read( r, ref index);
rec.ssENOrderMainItem.Read( r, ref index);
return rec;
}
// Query Function "GetOrderMainItemsByOrderMainId" +QjqZdK4sEO2QuPFZII_fg of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_663d4acde686fb13f7cb44965555ab7f,long)> datasetGetOrderMainItemsByOrderMainId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMainItem_OrderMainId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainItemsByOrderMainId", "65ea08f9-b8d2-43b0-b642-e3c564823f7e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainItemsByOrderMainId");
// Query Iterations: Multiple
// Refresh Query SNoVucR4uUOisK+hnPIvsQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.+QjqZdK4sEO2QuPFZII_fg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingaccounts_servicetype12\".\"cc\" o1, \"enaccountingaccounts_servicetype12\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"eninvoiceusage5\".\"key\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enordermainitem22\".\"id\" o18, \"enordermainitem22\".\"ordermainid\" o19, \"enordermainitem22\".\"position\" o20, \"enordermainitem22\".\"materialcode\" o21, \"enordermainitem22\".\"materialdescription\" o22, \"enordermainitem22\".\"assigmnentcode\" o23, \"enordermainitem22\".\"documentclassid\" o24, \"enordermainitem22\".\"deliverydate\" o25, trim_scale(\"enordermainitem22\".\"quantity\"::numeric) o26, \"enordermainitem22\".\"unittype\" o27, trim_scale(\"enordermainitem22\".\"unitprice\"::numeric) o28, \"enordermainitem22\".\"basequantity\" o29, \"enordermainitem22\".\"isdeleted\" o30, \"enordermainitem22\".\"isblocked\" o31, \"enordermainitem22\".\"isfinaldelivery\" o32, \"enordermainitem22\".\"glaccountid\" o33, \"enordermainitem22\".\"costcenterid\" o34, \"enordermainitem22\".\"fundscenter\" o35, \"enordermainitem22\".\"fund\" o36, \"enordermainitem22\".\"commitmentitem\" o37, \"enordermainitem22\".\"vatindicator\" o38, \"enordermainitem22\".\"vatprocedure\" o39, trim_scale(\"enordermainitem22\".\"vatrate\"::numeric) o40, \"enordermainitem22\".\"purchaserequisitionnumber\" o41, \"enordermainitem22\".\"purchaserequisitionitemnr\" o42, \"enordermainitem22\".\"regionid\" o43, \"enordermainitem22\".\"center\" o44, \"enordermainitem22\".\"pepelement\" o45, trim_scale(\"enordermainitem22\".\"quantitydelivered\"::numeric) o46, \"enordermainitem22\".\"orderunitofmeasure\" o47, \"enordermainitem22\".\"applicant\" o48, \"enordermainitem22\".\"direction\" o49, \"enordermainitem22\".\"contractnumber\" o50, \"enordermainitem22\".\"contractposition\" o51, \"enordermainitem22\".\"contractstartdate\" o52, \"enordermainitem22\".\"contractenddate\" o53, trim_scale(\"enordermainitem22\".\"contractplannedvalue\"::numeric) o54, \"enordermainitem22\".\"positiontype\" o55, \"enordermainitem22\".\"serialnumberprofile\" o56, \"enordermainitem22\".\"batchmanaged\" o57, \"enordermainitem22\".\"materialtype\" o58, \"enordermainitem22\".\"itemgroup\" o59, \"enordermainitem22\".\"orderrequestcreatorsapnumber\" o60, \"enordermainitem22\".\"ismultipleimputation\" o61, \"enordermainitem22\".\"invoiceusageid\" o62, \"enordermainitem22\".\"ordermainitemstatusid\" o63, \"enordermainitem22\".\"divisionid\" o64, \"enordermainitem22\".\"createdby\" o65, \"enordermainitem22\".\"createdon\" o66, \"enordermainitem22\".\"updatedby\" o67, \"enordermainitem22\".\"updatedon\" o68");
fromBuilder.Append(" FROM (({OrderMainItem} \"enordermainitem22\" Left JOIN {AccountingAccounts_ServiceType} \"enaccountingaccounts_servicetype12\" ON (\"enordermainitem22\".\"glaccountid\" = \"enaccountingaccounts_servicetype12\".\"id\"))  Left JOIN {InvoiceUsage} \"eninvoiceusage5\" ON (\"enordermainitem22\".\"invoiceusageid\" = \"eninvoiceusage5\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMainItem_OrderMainId != 0) {
whereBuilder.Append("((\"enordermainitem22\".\"ordermainid\" = @qporOrderMainItem_OrderMainId) AND (\"enordermainitem22\".\"ordermainid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMainItem_OrderMainId", DbType.Int64, qporOrderMainItem_OrderMainId);
} else {
whereBuilder.Append("(\"enordermainitem22\".\"ordermainid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enordermainitem22\".\"position\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainItemsByOrderMainId.List", cancellationToken: cancellationToken);
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

// Query Function "GetAdvancedPaymentTypes" Ogv3ZdZVcUqIkSGJlBfauw of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_0d443dd02abe633532f6b939b4573e00,long)> datasetGetAdvancedPaymentTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAdvancedPaymentTypes", "65f70b3a-55d6-4a71-8891-21899417dabb");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetAdvancedPaymentTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.Ogv3ZdZVcUqIkSGJlBfauw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enadvancepaymenttype4\".\"id\" o0, \"enadvancepaymenttype4\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {AdvancePaymentType} \"enadvancepaymenttype4\"");
whereBuilder.Append(" WHERE (\"enadvancepaymenttype4\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAdvancedPaymentTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetBusinessValueSubcategoriesByCategoryId" 9r8dbewjvUu953I_DPvtxQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_2d11b20156650990ba0f3131aaaad2ea,long)> datasetGetBusinessValueSubcategoriesByCategoryId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpbuCategoryId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueSubcategoriesByCategoryId", "6d1dbff6-23ec-4bbd-bde7-723f0cfbedc5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueSubcategoriesByCategoryId");
// Query Iterations: Multiple
// Refresh Query hWkXDQNHekavNfcpjRWggg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.9r8dbewjvUu953I_DPvtxQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enbusinessvaluesubcategory3\".\"id\" o0, \"enbusinessvaluesubcategory3\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {BusinessValueSubcategory} \"enbusinessvaluesubcategory3\"");
whereBuilder.Append(" WHERE ");
if (qpbuCategoryId != 0) {
whereBuilder.Append("((\"enbusinessvaluesubcategory3\".\"categoryid\" = @qpbuCategoryId) AND (\"enbusinessvaluesubcategory3\".\"categoryid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpbuCategoryId", DbType.Int64, qpbuCategoryId);
} else {
whereBuilder.Append("(\"enbusinessvaluesubcategory3\".\"categoryid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetBusinessValueSubcategoriesByCategoryId.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceUsages" _ORBce5VM0q6Q55UEql2SA of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_1078cb2b44dad3e211c3325e839a4151,long)> datasetGetInvoiceUsages(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetInvoiceUsages", "7141e4fc-55ee-4a33-ba43-9e5412a97648");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetInvoiceUsages");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets._ORBce5VM0q6Q55UEql2SA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoiceusage6\".\"id\" o0, \"eninvoiceusage6\".\"key\" o1, \"eninvoiceusage6\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9");
fromBuilder.Append(" FROM {InvoiceUsage} \"eninvoiceusage6\"");
whereBuilder.Append(" WHERE (\"eninvoiceusage6\".\"isactive\" = 1)");
orderByBuilder.Append(" ORDER BY \"eninvoiceusage6\".\"key\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetInvoiceUsages.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetInvoiceUsages.List", cancellationToken: cancellationToken);
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

// Query Function "GetFrequencies" 9X4Egn9YzkKpJ7DOLFoGuQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_86161aa08f9858d205ef72cffcb4919d,long)> datasetGetFrequencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetFrequencies", "82047ef5-587f-42ce-a927-b0ce2c5a06b9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetFrequencies");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.9X4Egn9YzkKpJ7DOLFoGuQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfrequency6\".\"id\" o0, \"enfrequency6\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Frequency} \"enfrequency6\"");
whereBuilder.Append(" WHERE (\"enfrequency6\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"enfrequency6\".\"order\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetFrequencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetFrequencies.List", cancellationToken: cancellationToken);
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

// Query Function "GetProjectAssetServices" CWP5kLwiOE2IFxsbbEbRug of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServices", "90f96309-22bc-4d38-8817-1b1b6c46d1ba");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServices");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.CWP5kLwiOE2IFxsbbEbRug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service13\".\"id\" o0, \"enproject_asset_service13\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service13\"");
orderByBuilder.Append(" ORDER BY \"enproject_asset_service13\".\"description\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServices.List", cancellationToken: cancellationToken);
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

// Query Function "GetRejectComment" 694jkdxvd02G4iVfi1ufoA of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_17d8289ea48572225dc9530a5725652a,long)> datasetGetRejectComment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetRejectComment", "9123deeb-6fdc-4d77-86e2-255f8b5b9fa0");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetRejectComment");
// Query Iterations: Never
// Refresh Query eHHJlMIyJUGnLofNH7I5Cw Iterations: Never
// Refresh Query AhlGIDIhRUGugwFLPRMiaA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.694jkdxvd02G4iVfi1ufoA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {OrderComment} \"enordercomment2\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enordercomment2\".\"orderid\" = @qporOrderId) AND (\"enordercomment2\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enordercomment2\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercomment2\".\"commenttypeid\" = ");
whereBuilder.Append((ENCommentTypeEntity.GetRecordByKey(ObjectKey.Parse("r_wbgKYi4kyW+X8YHLObXA"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enordercomment2\".\"id\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetRejectComment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetRejectComment.List", cancellationToken: cancellationToken);
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

// Query Function "GetSupplierByRequisition" FCrLm7Y3lkK5MUin_h2MdA of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_d5c1b2482ff109e80580d8b5fb920193,long)> datasetGetSupplierByRequisition(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpsuId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetSupplierByRequisition", "9bcb2a14-37b6-4296-b931-48a7fe1d8c74");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetSupplierByRequisition");
// Query Iterations: Never
// Refresh Query ttNmkj5+xUu5zRYZUyRjTg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.FCrLm7Y3lkK5MUin_h2MdA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM {Supplier} \"ensupplier103\"");
whereBuilder.Append(" WHERE ");
if (qpsuId != 0) {
whereBuilder.Append("((\"ensupplier103\".\"id\" = @qpsuId) AND (\"ensupplier103\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuId", DbType.Int64, qpsuId);
} else {
whereBuilder.Append("(\"ensupplier103\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSupplierByRequisition.List", cancellationToken: cancellationToken);
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

// Query Function "GetSpecialApprovals" syncqt9huU2hJlDn6vxYoQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_0204de281fa136fb826199f876159fe4,long)> datasetGetSpecialApprovals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialApprovals", "aadc29b3-61df-4db9-a126-50e7eafc58a1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialApprovals");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.syncqt9huU2hJlDn6vxYoQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialapproval2\".\"id\" o0, \"enspecialapproval2\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialApproval} \"enspecialapproval2\"");
whereBuilder.Append(" WHERE (\"enspecialapproval2\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialApprovals.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialApprovals.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentTerms" 2VEwu694mkGlIdVntBDdxA of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTerms(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTerms", "bb3051d9-78af-419a-a521-d567b410ddc4");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTerms");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.2VEwu694mkGlIdVntBDdxA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms24\".\"id\" o0, \"enpaymentterms24\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms24\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTerms.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTerms.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentMethods" LAOQwVHD7U2crymzGfUntg of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_0dcbcba642ca8b22e87f690d4de9d077,long)> datasetGetPaymentMethods(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentMethods", "c190032c-c351-4ded-9caf-29b319f527b6");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentMethods");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.LAOQwVHD7U2crymzGfUntg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentmethods12\".\"id\" o0, \"enpaymentmethods12\".\"description\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8");
fromBuilder.Append(" FROM {PaymentMethods} \"enpaymentmethods12\"");
whereBuilder.Append(" WHERE (\"enpaymentmethods12\".\"isfcp\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentMethods.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentMethods.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderRetentionTypes" hE372LD+V0KCaZU0V+N03w of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_d6a865b9451603b2b07820fedb283c87,long)> datasetGetOrderRetentionTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderRetentionTypes", "d8fb4d84-feb0-4257-8269-953457e374df");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetOrderRetentionTypes");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.hE372LD+V0KCaZU0V+N03w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderretentiontype1\".\"id\" o0, \"enorderretentiontype1\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {OrderRetentionType} \"enorderretentiontype1\"");
whereBuilder.Append(" WHERE (\"enorderretentiontype1\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderRetentionTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderRetentionTypes.List", cancellationToken: cancellationToken);
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

// Query Function "GetCurrencies" rMEq22JXkEapMlv4flLCcQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetCurrencies", "db2ac1ac-5762-4690-a932-5bf87e52c271");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.rMEq22JXkEapMlv4flLCcQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency23\".\"code\" o0, \"encurrency23\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency23\"");
whereBuilder.Append(" WHERE (\"encurrency23\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetCurrencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetCurrencies.List", cancellationToken: cancellationToken);
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
// Query Function "GetOrderMainById" CVEE4aiMJkOU4gQPffhZCw of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_c5285652b7692ee7ff416f77dcd1fe1c,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboGetIsCxP_RequestErrorDistribution,long qpenOrderApprovalLevel_EntraRoleId,string qpusGetUserId,long qpreGetUserRegionId,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainById", "e1045109-8ca8-4326-94e2-040f7df8590b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainById");
// Query Iterations: Never
// Refresh Query haa4VB9JsECEtQ83fZe37g Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.CVEE4aiMJkOU4gQPffhZCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderapproval32\".\"id\" o0, NULL o1, \"enorderapproval32\".\"currentlevel\" o2, \"enorderapproval32\".\"maxlevel\" o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel31\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderapprovallevel31\".\"approvalstatusid\" o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, \"enorderdetail18\".\"orderid\" o25, \"enorderdetail18\".\"isapprovalfromuserarea\" o26, \"enorderdetail18\".\"projectassetserviceid\" o27, \"enorderdetail18\".\"projectassetservice\" o28, \"enorderdetail18\".\"projectdescription\" o29, \"enorderdetail18\".\"businessvaluecategoryid\" o30, \"enorderdetail18\".\"businessvaluesubcategoryid\" o31, \"enorderdetail18\".\"paymenttermsid\" o32, \"enorderdetail18\".\"paymentmethodid\" o33, trim_scale(\"enorderdetail18\".\"negotiatedexchangerate\"::numeric) o34, \"enorderdetail18\".\"contractstatus\" o35, \"enorderdetail18\".\"dateofcommitment\" o36, \"enorderdetail18\".\"hasdeposit\" o37, \"enorderdetail18\".\"hasinsurance\" o38, \"enorderdetail18\".\"distributionid\" o39, \"enorderdetail18\".\"hasadvancepayment\" o40, trim_scale(\"enorderdetail18\".\"retentionrate\"::numeric) o41, \"enorderdetail18\".\"hasbasedate\" o42, \"enorderdetail18\".\"startbasedate\" o43, \"enorderdetail18\".\"endbasedate\" o44, \"enorderdetail18\".\"contractnumber\" o45, \"enorderdetail18\".\"isretentionapplied\" o46, \"enorderdetail18\".\"frequency\" o47, \"enorderdetail18\".\"period\" o48, \"enorderdetail18\".\"orderretentiontypeid\" o49, \"enorderdetail18\".\"paymentoptionsid\" o50, \"enorderdetail18\".\"paymentwaysid\" o51, \"enorderdetail18\".\"orderscontract\" o52, trim_scale(\"enorderdetail18\".\"contractamount\"::numeric) o53, trim_scale(\"enorderdetail18\".\"contracttarif\"::numeric) o54, \"enorderdetail18\".\"contractsupplier\" o55, \"enorderdetail18\".\"isdependentfromfolios\" o56, \"enorderdetail18\".\"specialapprovalid\" o57, \"enorderdetail18\".\"createdby\" o58, \"enorderdetail18\".\"createdon\" o59, \"enorderdetail18\".\"updatedby\" o60, \"enorderdetail18\".\"updatedon\" o61, \"enorderdetail18\".\"allcontactfilesvalidated\" o62, \"enorderdetail18\".\"hasntrequestdocuments\" o63, \"enordermain105\".\"id\" o64, \"enordermain105\".\"ordernumber\" o65, \"enordermain105\".\"orderdate\" o66, \"enordermain105\".\"orderstatusid\" o67, \"enordermain105\".\"previousorderstatusid\" o68, \"enordermain105\".\"assignmentcode\" o69, \"enordermain105\".\"supplierid\" o70, \"enordermain105\".\"companyid\" o71, \"enordermain105\".\"documenttypeid\" o72, \"enordermain105\".\"currencyid\" o73, \"enordermain105\".\"telceldirectionid\" o74, \"enordermain105\".\"procurementgroup\" o75, \"enordermain105\".\"creatorsapnumber\" o76, \"enordermain105\".\"creatorsapname\" o77, \"enordermain105\".\"country\" o78, \"enordermain105\".\"isdeleted\" o79, \"enordermain105\".\"isreleased\" o80, trim_scale(\"enordermain105\".\"exchangerate\"::numeric) o81, \"enordermain105\".\"sustainabilitycategory\" o82, \"enordermain105\".\"sustainabilitysubcategory\" o83, trim_scale(\"enordermain105\".\"totalamount\"::numeric) o84, \"enordermain105\".\"fromcosmoz\" o85, \"enordermain105\".\"regionid\" o86, \"enordermain105\".\"divisionid\" o87, \"enordermain105\".\"applicant\" o88, \"enordermain105\".\"createdby\" o89, \"enordermain105\".\"createdon\" o90, \"enordermain105\".\"updatedby\" o91, \"enordermain105\".\"updatedon\" o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, \"ensupplier104\".\"pais\" o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, (CASE WHEN ((");
if ((qpusGetUserId.Trim()!="")) {
selectBuilder.Append("((\"enorderapprovallevel31\".\"assignedto\" = @qpusGetUserId) AND (\"enorderapprovallevel31\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
selectBuilder.Append("(\"enorderapprovallevel31\".\"assignedto\" IS NULL)");
}
selectBuilder.Append(" OR (((\"enorderapprovallevel31\".\"assignedto\" IS NULL) AND (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain105\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain105\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain105\".\"divisionid\" IS NULL)");
}
selectBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enordermain105\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain105\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enordermain105\".\"regionid\" IS NULL)");
}
selectBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
selectBuilder.Append("((\"enorderapprovallevel31\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel31\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
selectBuilder.Append("(\"enorderapprovallevel31\".\"entraroleid\" IS NULL)");
}
selectBuilder.Append(")) AND ((\"enorderapprovallevel31\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
selectBuilder.Append(") OR (\"enorderapprovallevel31\".\"approvalstatusid\" = ");
selectBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("2bH5k51Eqk+iM0PUO3cbyg"))).ssId);
selectBuilder.Append("))) THEN 1 ELSE 0 END) \"iscurrentapprover\"");
fromBuilder.Append(" FROM (((((({OrderApprovalLevel} \"enorderapprovallevel31\" Left JOIN {OrderApproval} \"enorderapproval32\" ON (\"enorderapproval32\".\"id\" = \"enorderapprovallevel31\".\"orderapprovalid\"))  Right JOIN {OrderMain} \"enordermain105\" ON (\"enordermain105\".\"id\" = \"enorderapproval32\".\"orderid\"))  Left JOIN {OrderStatus} \"enorderstatus14\" ON (\"enordermain105\".\"orderstatusid\" = \"enorderstatus14\".\"id\"))  Left JOIN {Supplier} \"ensupplier104\" ON (\"enordermain105\".\"supplierid\" = \"ensupplier104\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail18\" ON (\"enordermain105\".\"id\" = \"enorderdetail18\".\"orderid\"))  Left JOIN {SupplierUser} \"ensupplieruser23\" ON (\"ensupplier104\".\"id\" = \"ensupplieruser23\".\"supplierid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain105\".\"id\" = @qporOrderMain_Id) AND (\"enordermain105\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain105\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"ensupplieruser23\".\"userid\" = @qpusGetUserId) AND (\"ensupplieruser23\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"ensupplieruser23\".\"userid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE (CASE WHEN (((\"enorderapprovallevel31\".\"approvalstatusid\" <> ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
whereBuilder.Append(") AND (");
if ((qpusGetUserId.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel31\".\"assignedto\" = @qpusGetUserId) AND (\"enorderapprovallevel31\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
whereBuilder.Append("(\"enorderapprovallevel31\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (((\"enorderapprovallevel31\".\"assignedto\" IS NULL) AND (");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain105\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain105\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain105\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain105\".\"regionid\" = @qpreGetUserRegionId) AND (\"enordermain105\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain105\".\"regionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel31\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel31\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel31\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append("))) OR ((\"enordermain105\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("BHvVtSdSlUixsh+41KTCZg"))).ssId);
whereBuilder.Append(") OR ((\"enordermain105\".\"orderstatusid\" = ");
whereBuilder.Append((ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
whereBuilder.Append(") AND (@qpboGetIsCxP_RequestErrorDistribution = 1)))) THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"enorderapprovallevel31\".\"levelnumber\" DESC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainById.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderMainById.List", cancellationToken: cancellationToken);
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

// Query Function "GetSpecialPostDeliveryAuthorizations" MH_U5F9_1k6Ktx9I8qkUBQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_9a84f0ca43f575461143a73bcb506dba,long)> datasetGetSpecialPostDeliveryAuthorizations(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialPostDeliveryAuthorizations", "e4d47f30-7f5f-4ed6-8ab7-1f48f2a91405");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialPostDeliveryAuthorizations");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.MH_U5F9_1k6Ktx9I8qkUBQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialpostdeliveryauthorization1\".\"id\" o0, \"enspecialpostdeliveryauthorization1\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialPostDeliveryAuthorization} \"enspecialpostdeliveryauthorization1\"");
whereBuilder.Append(" WHERE (\"enspecialpostdeliveryauthorization1\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSpecialPostDeliveryAuthorizations.List", cancellationToken: cancellationToken);
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

// Query Function "GetProjectAssetServiceOtro" wLJC5cxgikOo0KKLWeqZ3Q of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_39dc6f4415ce9196844d0ada601cc72b,long)> datasetGetProjectAssetServiceOtro(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServiceOtro", "e542b2c0-60cc-438a-a8d0-a28b59ea99dd");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServiceOtro");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.wLJC5cxgikOo0KKLWeqZ3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enproject_asset_service14\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {Project_Asset_Service} \"enproject_asset_service14\"");
whereBuilder.Append(" WHERE (\"enproject_asset_service14\".\"isothers\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetProjectAssetServiceOtro.List", cancellationToken: cancellationToken);
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

// Query Function "GetContractStatuses" SjJk6ItcqEK0VUxf7lpIgw of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_b597b6c7f7b0a874a3717792e87892bb,long)> datasetGetContractStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetContractStatuses", "e864324a-5c8b-42a8-b455-4c5fee5a4883");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetContractStatuses");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.SjJk6ItcqEK0VUxf7lpIgw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encontractstatus1\".\"id\" o0, \"encontractstatus1\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ContractStatus} \"encontractstatus1\"");
whereBuilder.Append(" WHERE (\"encontractstatus1\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"encontractstatus1\".\"order\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetContractStatuses.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetContractStatuses.List", cancellationToken: cancellationToken);
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

private static async Task<RC_c81aee5ce0504fe68694be6deb703b5e> datasetGetSuppliersReadDbAsync(RC_c81aee5ce0504fe68694be6deb703b5e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRegion.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
return rec;
}
// Query Function "GetSuppliers" dVw9+hRDIEWrbh9XImuZug of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_f647e8c4990b814587d1a017e4c9dd44,long)> datasetGetSuppliers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpreSupplier_RegionId,long qpreSupplier_RegionId1,long qpreSupplier_RegionId2,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetSuppliers", "fa3d5c75-4314-4520-ab6e-1f57226b99ba");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetSuppliers");
// Query Iterations: Never
// Refresh Query BkJKBX6TkkyeNhG7choynQ Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.dVw9+hRDIEWrbh9XImuZug, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40");
fromBuilder.Append(" FROM ({Supplier} \"ensupplier105\" Left JOIN {Region} \"enregion130\" ON (\"ensupplier105\".\"regionid\" = \"enregion130\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if (qpreSupplier_RegionId1 != 0) {
whereBuilder.Append("((\"ensupplier105\".\"regionid\" = @qpreSupplier_RegionId) AND (\"ensupplier105\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId", DbType.Int64, qpreSupplier_RegionId1);
} else {
whereBuilder.Append("(\"ensupplier105\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ((((@qpreSupplier_RegionId1 = @qpreSupplier_RegionId2) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId2);
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
if (qpreSupplier_RegionId != 0) {
whereBuilder.Append("((\"ensupplier105\".\"regionid\" = @qpreSupplier_RegionId2) AND (\"ensupplier105\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId2", DbType.Int64, qpreSupplier_RegionId);
} else {
whereBuilder.Append("(\"ensupplier105\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR ");
if (qpreSupplier_RegionId2 != 0) {
whereBuilder.Append("((\"ensupplier105\".\"regionid\" = @qpreSupplier_RegionId1) AND (\"ensupplier105\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreSupplier_RegionId1", DbType.Int64, qpreSupplier_RegionId2);
} else {
whereBuilder.Append("(\"ensupplier105\".\"regionid\" IS NULL)");
}
whereBuilder.Append(") OR (\"ensupplier105\".\"regionid\" IS NULL)))");
orderByBuilder.Append(" ORDER BY \"ensupplier105\".\"name\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSuppliers.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetSuppliers.List", cancellationToken: cancellationToken);
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

// Query Function "GetPaymentOptions" iPwx_tXlMUaeuSQplXH7yQ of Action "Wb_OrderDetailPaymentInformation"
public static async Task<(RL_251acb2daece433ee402c9709ec88356,long)> datasetGetPaymentOptions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qppaId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentOptions", "fe31fc88-e5d5-4631-9eb9-24299571fbc9");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDetailPaymentInformation","e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentOptions");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/ScreenDataSets.iPwx_tXlMUaeuSQplXH7yQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentoptions3\".\"id\" o0, NULL o1, \"enpaymentoptions3\".\"description\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7");
fromBuilder.Append(" FROM {PaymentOptions} \"enpaymentoptions3\"");
whereBuilder.Append(" WHERE ((\"enpaymentoptions3\".\"isactive\" = 1) OR ");
if (qppaId != 0) {
whereBuilder.Append("((\"enpaymentoptions3\".\"id\" = @qppaId) AND (\"enpaymentoptions3\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qppaId", DbType.Int64, qppaId);
} else {
whereBuilder.Append("(\"enpaymentoptions3\".\"id\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentOptions.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentOptions.List", cancellationToken: cancellationToken);
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
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetPaymentTermSpecial", "2f015864-814c-47e5-a171-47e1decab9a5"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation", "GetPaymentTermSpecial")){
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
public class lcvGetOrderContractData : VarsBag {
public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterDeposit_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterInsurance_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterContract_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterNullIdentifier_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterAdvancePayment_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf queryResGetOrderFiles_outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
public long queryResGetOrderFiles_outParamCount = 0L;

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf resListFilterPendingJustif_outParamFilteredList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();

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
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderContractData", "4ee98934-63eb-4728-810a-ed92cad7e1a6"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation", "GetOrderContractData")){
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
public class lcvGetOrderFilesList : VarsBag {
public RL_5305c20f972277b55d855aa236dd3fba queryResGetOrderForeignResidenceFile_outParamList = new RL_5305c20f972277b55d855aa236dd3fba();
public long queryResGetOrderForeignResidenceFile_outParamCount = 0L;

public RL_eeab316051f92c8094cbc73a8650f55b queryResGetOrderFinanceFile_outParamList = new RL_eeab316051f92c8094cbc73a8650f55b();
public long queryResGetOrderFinanceFile_outParamCount = 0L;

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
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderFilesList", "987c8ff1-edb7-4caa-a02b-04bbd7ea3dd8"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation", "GetOrderFilesList")){
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
public class lcvGetAccountingData : VarsBag {
public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsAnticipo_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsAnticipo_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsVoucher_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsVoucher_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsAnticipo_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsAnticipo_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsCreditNote_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsCreditNote_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConcepts_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConcepts_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConcepts_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConcepts_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsVoucher_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsVoucher_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsFiniquito_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsFiniquito_outParamCount = 0L;

public RL_16bc0f170c91ed9fd3ef42e01c4db2cf queryResGetOrderExchangeRateEvidence_outParamList = new RL_16bc0f170c91ed9fd3ef42e01c4db2cf();
public long queryResGetOrderExchangeRateEvidence_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetSubOrderAccConceptsFiniquito_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetSubOrderAccConceptsFiniquito_outParamCount = 0L;

public RL_06217d1a1f91440a5a69e4163e3e2c6f queryResGetOrderMainExchangeRate_outParamList = new RL_06217d1a1f91440a5a69e4163e3e2c6f();
public long queryResGetOrderMainExchangeRate_outParamCount = 0L;

public RL_f805dfae1f4ccde9f7b0028b80707abe queryResGetMainOrderAccConceptsCreditNote_outParamList = new RL_f805dfae1f4ccde9f7b0028b80707abe();
public long queryResGetMainOrderAccConceptsCreditNote_outParamCount = 0L;

public RL_aedf606f6413243cfacf43ac13db404f queryResGetOrderAccountingsByOrderId_outParamList = new RL_aedf606f6413243cfacf43ac13db404f();
public long queryResGetOrderAccountingsByOrderId_outParamCount = 0L;

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
ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetAccountingData", "f1fb6e5e-e3c5-46e3-8482-1734449b29b9"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDetailPaymentInformation", "GetAccountingData")){
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


    public static class FuncDataActionGetPaymentTermSpecial {

// Query Function "GetPaymentTermsIsSpecial" CTyg6cCyaU6RnKekwASCpA of Action "GetPaymentTermSpecial"
public static async Task<(RL_375b9dd8c8b0d6d7bccf4d550f48644d,long)> datasetGetPaymentTermsIsSpecial(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTermSpecial.GetPaymentTermsIsSpecial", "e9a03c09-b2c0-4e69-919c-a7a4c00482a4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTermSpecial.GetPaymentTermsIsSpecial", "e9a03c09-b2c0-4e69-919c-a7a4c00482a4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.ZFgBL0yB5UehcUfh3sq5pQ/NodesNotShownInESpaceTree.CTyg6cCyaU6RnKekwASCpA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enpaymentterms25\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10");
fromBuilder.Append(" FROM {PaymentTerms} \"enpaymentterms25\"");
whereBuilder.Append(" WHERE (\"enpaymentterms25\".\"isspecial\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTermSpecial.GetPaymentTermsIsSpecial.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetPaymentTermSpecial.GetPaymentTermsIsSpecial.List", cancellationToken: cancellationToken);
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
public static class FuncDataActionGetOrderContractData {

private static async Task<RC_8171c5e0188443e9384b8f5492517b0e> datasetGetOrderFilesReadDbAsync(RC_8171c5e0188443e9384b8f5492517b0e rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFile.Read( r, ref index);
rec.ssENOrderFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFiles" Fj1JzFCp3EGUVb9FXcxThw of Action "GetOrderContractData"
public static async Task<(RL_16bc0f170c91ed9fd3ef42e01c4db2cf,long)> datasetGetOrderFiles(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderContractData.GetOrderFiles", "cc493d16-a950-41dc-9455-bf455dcc5387");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderContractData.GetOrderFiles", "cc493d16-a950-41dc-9455-bf455dcc5387", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.NInpTutjKEeBCu2Sytfhpg/NodesNotShownInESpaceTree.Fj1JzFCp3EGUVb9FXcxThw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfile8\".\"id\" o0, \"enordercontractfile8\".\"orderid\" o1, \"enordercontractfile8\".\"orderfileid\" o2, \"enordercontractfile8\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfile8\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfile8\".\"tarif\"::numeric) o5, \"enordercontractfile8\".\"currencyid\" o6, \"enordercontractfile8\".\"deposittypeid\" o7, \"enordercontractfile8\".\"insurancetypeid\" o8, \"enordercontractfile8\".\"advancepaymenttypeid\" o9, \"enordercontractfile8\".\"startbasedate\" o10, \"enordercontractfile8\".\"endbasedate\" o11, \"enordercontractfile8\".\"paymenttermsid\" o12, \"enordercontractfile8\".\"isforvendorupload\" o13, \"enorderfile9\".\"id\" o14, \"enorderfile9\".\"filename\" o15, \"enorderfile9\".\"vendor\" o16, \"enorderfile9\".\"doc_type\" o17, \"enorderfile9\".\"sap_object\" o18, \"enorderfile9\".\"createdby\" o19, \"enorderfile9\".\"createdon\" o20, \"enorderfile9\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderFile} \"enorderfile9\" Inner JOIN {OrderContractFile} \"enordercontractfile8\" ON (\"enorderfile9\".\"id\" = \"enordercontractfile8\".\"orderfileid\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile8\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile8\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile8\".\"orderid\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enorderfile9\".\"filename\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderContractData.GetOrderFiles.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderContractData.GetOrderFiles.List", cancellationToken: cancellationToken);
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
public static class FuncDataActionGetOrderFilesList {

private static async Task<RC_55a4f62f090e92d07d40f0b63ffe2d16> datasetGetOrderForeignResidenceFileReadDbAsync(RC_55a4f62f090e92d07d40f0b63ffe2d16 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFileForeignResidence.Read( r, ref index);
rec.ssENOrderFileForeignResidence.Read( r, ref index);
return rec;
}
// Query Function "GetOrderForeignResidenceFile" GUhN5gXDv0qTVjo9lSw9pQ of Action "GetOrderFilesList"
public static async Task<(RL_5305c20f972277b55d855aa236dd3fba,long)> datasetGetOrderForeignResidenceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderForeignResidenceFile", "e64d4819-c305-4abf-9356-3a3d952c3da5");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderForeignResidenceFile", "e64d4819-c305-4abf-9356-3a3d952c3da5", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.8Y98mLftqkygKwS71+o92A/NodesNotShownInESpaceTree.GUhN5gXDv0qTVjo9lSw9pQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfileforeignresidence1\".\"id\" o0, \"enordercontractfileforeignresidence1\".\"orderid\" o1, \"enordercontractfileforeignresidence1\".\"orderfileid\" o2, \"enordercontractfileforeignresidence1\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfileforeignresidence1\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfileforeignresidence1\".\"tarif\"::numeric) o5, \"enordercontractfileforeignresidence1\".\"currencyid\" o6, \"enordercontractfileforeignresidence1\".\"deposittypeid\" o7, \"enordercontractfileforeignresidence1\".\"insurancetypeid\" o8, \"enordercontractfileforeignresidence1\".\"advancepaymenttypeid\" o9, \"enordercontractfileforeignresidence1\".\"startbasedate\" o10, \"enordercontractfileforeignresidence1\".\"endbasedate\" o11, \"enordercontractfileforeignresidence1\".\"paymenttermsid\" o12, \"enordercontractfileforeignresidence1\".\"isforvendorupload\" o13, \"enorderfileforeignresidence1\".\"id\" o14, \"enorderfileforeignresidence1\".\"filename\" o15, \"enorderfileforeignresidence1\".\"vendor\" o16, \"enorderfileforeignresidence1\".\"doc_type\" o17, \"enorderfileforeignresidence1\".\"sap_object\" o18, \"enorderfileforeignresidence1\".\"createdby\" o19, \"enorderfileforeignresidence1\".\"createdon\" o20, \"enorderfileforeignresidence1\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderFile} \"enorderfileforeignresidence1\" Left JOIN {OrderContractFile} \"enordercontractfileforeignresidence1\" ON (\"enorderfileforeignresidence1\".\"id\" = \"enordercontractfileforeignresidence1\".\"orderfileid\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfileforeignresidence1\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfileforeignresidence1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfileforeignresidence1\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfileforeignresidence1\".\"contractfiletypeid\" = ");
whereBuilder.Append((ENContractFileTypeEntity.GetRecordByKey(ObjectKey.Parse("DmZNPQ718EWxmSQhfgzeiw"))).ssId);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enorderfileforeignresidence1\".\"filename\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderForeignResidenceFile.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderForeignResidenceFile.List", cancellationToken: cancellationToken);
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

private static async Task<RC_041cacb77c43fb5e1fc788222594e8fd> datasetGetOrderFinanceFileReadDbAsync(RC_041cacb77c43fb5e1fc788222594e8fd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderContractFinanceFile.Read( r, ref index);
rec.ssENOrderFinanceFile.Read( r, ref index);
return rec;
}
// Query Function "GetOrderFinanceFile" Fgr38JMKukm0DLN20H0U3Q of Action "GetOrderFilesList"
public static async Task<(RL_eeab316051f92c8094cbc73a8650f55b,long)> datasetGetOrderFinanceFile(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderFinanceFile", "f0f70a16-0a93-49ba-b40c-b376d07d14dd");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderFinanceFile", "f0f70a16-0a93-49ba-b40c-b376d07d14dd", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.8Y98mLftqkygKwS71+o92A/NodesNotShownInESpaceTree.Fgr38JMKukm0DLN20H0U3Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfinancefile1\".\"id\" o0, \"enordercontractfinancefile1\".\"orderid\" o1, \"enordercontractfinancefile1\".\"orderfileid\" o2, \"enordercontractfinancefile1\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfinancefile1\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfinancefile1\".\"tarif\"::numeric) o5, \"enordercontractfinancefile1\".\"currencyid\" o6, \"enordercontractfinancefile1\".\"deposittypeid\" o7, \"enordercontractfinancefile1\".\"insurancetypeid\" o8, \"enordercontractfinancefile1\".\"advancepaymenttypeid\" o9, \"enordercontractfinancefile1\".\"startbasedate\" o10, \"enordercontractfinancefile1\".\"endbasedate\" o11, \"enordercontractfinancefile1\".\"paymenttermsid\" o12, \"enordercontractfinancefile1\".\"isforvendorupload\" o13, \"enorderfinancefile1\".\"id\" o14, \"enorderfinancefile1\".\"filename\" o15, \"enorderfinancefile1\".\"vendor\" o16, \"enorderfinancefile1\".\"doc_type\" o17, \"enorderfinancefile1\".\"sap_object\" o18, \"enorderfinancefile1\".\"createdby\" o19, \"enorderfinancefile1\".\"createdon\" o20, \"enorderfinancefile1\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfinancefile1\" Left JOIN {OrderFile} \"enorderfinancefile1\" ON (\"enordercontractfinancefile1\".\"orderfileid\" = \"enorderfinancefile1\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfinancefile1\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfinancefile1\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfinancefile1\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfinancefile1\".\"contractfiletypeid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderFinanceFile.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetOrderFilesList.GetOrderFinanceFile.List", cancellationToken: cancellationToken);
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
}
public static class FuncDataActionGetAccountingData {

// Query Function "GetMainOrderAccConceptsAnticipo" HgEWFFk7XkeDUi381BQBuQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsAnticipo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsAnticipo", "1416011e-3b59-475e-8352-2dfcd41401b9");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsAnticipo", "1416011e-3b59-475e-8352-2dfcd41401b9", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.HgEWFFk7XkeDUi381BQBuQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts23\".\"id\" o0, \"enorderaccconcepts23\".\"orderaccountingid\" o1, \"enorderaccconcepts23\".\"accountingdatatypeid\" o2, \"enorderaccconcepts23\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts23\".\"amount\"::numeric) o4, \"enorderaccconcepts23\".\"currencyid\" o5, \"enorderaccconcepts23\".\"orderaccconceptsid\" o6, \"enorderaccconcepts23\".\"applyforrequestproject\" o7, \"enorderaccconcepts23\".\"paymenttermid\" o8, \"enorderaccconcepts23\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts23\".\"isactive\" o10, \"enorderaccconcepts23\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts23\".\"paymentdate\" o12, \"enorderaccconcepts23\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts23\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts23\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts23\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts23\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts23\".\"accountingdatatypeid\" = ");
whereBuilder.Append(8
);
whereBuilder.Append(") AND (\"enorderaccconcepts23\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
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

// Query Function "GetSubOrderAccConceptsVoucher" 5pEmHUnPUEKYDRQlzfxpfg of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsVoucher(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsVoucher", "1d2691e6-cf49-4250-980d-1425cdfc697e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsVoucher", "1d2691e6-cf49-4250-980d-1425cdfc697e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.5pEmHUnPUEKYDRQlzfxpfg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts24\".\"id\" o0, \"enorderaccconcepts24\".\"orderaccountingid\" o1, \"enorderaccconcepts24\".\"accountingdatatypeid\" o2, \"enorderaccconcepts24\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts24\".\"amount\"::numeric) o4, \"enorderaccconcepts24\".\"currencyid\" o5, \"enorderaccconcepts24\".\"orderaccconceptsid\" o6, \"enorderaccconcepts24\".\"applyforrequestproject\" o7, \"enorderaccconcepts24\".\"paymenttermid\" o8, \"enorderaccconcepts24\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts24\".\"isactive\" o10, \"enorderaccconcepts24\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts24\".\"paymentdate\" o12, \"enorderaccconcepts24\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts24\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts24\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts24\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts24\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
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

// Query Function "GetSubOrderAccConceptsAnticipo" SNviOmIP5Uey6EQKz3W4ZQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsAnticipo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsAnticipo", "3ae2db48-0f62-47e5-b2e8-440acf75b865");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsAnticipo", "3ae2db48-0f62-47e5-b2e8-440acf75b865", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.SNviOmIP5Uey6EQKz3W4ZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts25\".\"id\" o0, \"enorderaccconcepts25\".\"orderaccountingid\" o1, \"enorderaccconcepts25\".\"accountingdatatypeid\" o2, \"enorderaccconcepts25\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts25\".\"amount\"::numeric) o4, \"enorderaccconcepts25\".\"currencyid\" o5, \"enorderaccconcepts25\".\"orderaccconceptsid\" o6, \"enorderaccconcepts25\".\"applyforrequestproject\" o7, \"enorderaccconcepts25\".\"paymenttermid\" o8, \"enorderaccconcepts25\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts25\".\"isactive\" o10, \"enorderaccconcepts25\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts25\".\"paymentdate\" o12, \"enorderaccconcepts25\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts25\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts25\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts25\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts25\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsAnticipo.List", cancellationToken: cancellationToken);
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

// Query Function "GetSubOrderAccConceptsCreditNote" 6tqTavw7H0K7FrH_YN8dOg of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsCreditNote(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsCreditNote", "6a93daea-3bfc-421f-bb16-b1ff60df1d3a");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsCreditNote", "6a93daea-3bfc-421f-bb16-b1ff60df1d3a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.6tqTavw7H0K7FrH_YN8dOg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts26\".\"id\" o0, \"enorderaccconcepts26\".\"orderaccountingid\" o1, \"enorderaccconcepts26\".\"accountingdatatypeid\" o2, \"enorderaccconcepts26\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts26\".\"amount\"::numeric) o4, \"enorderaccconcepts26\".\"currencyid\" o5, \"enorderaccconcepts26\".\"orderaccconceptsid\" o6, \"enorderaccconcepts26\".\"applyforrequestproject\" o7, \"enorderaccconcepts26\".\"paymenttermid\" o8, \"enorderaccconcepts26\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts26\".\"isactive\" o10, \"enorderaccconcepts26\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts26\".\"paymentdate\" o12, \"enorderaccconcepts26\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts26\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts26\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts26\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts26\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
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

// Query Function "GetMainOrderAccConcepts" RllibGzJEE6nr1nnMX7dBQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConcepts", "6c625946-c96c-4e10-a7af-59e7317edd05");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConcepts", "6c625946-c96c-4e10-a7af-59e7317edd05", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.RllibGzJEE6nr1nnMX7dBQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts27\".\"id\" o0, \"enorderaccconcepts27\".\"orderaccountingid\" o1, \"enorderaccconcepts27\".\"accountingdatatypeid\" o2, \"enorderaccconcepts27\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts27\".\"amount\"::numeric) o4, \"enorderaccconcepts27\".\"currencyid\" o5, \"enorderaccconcepts27\".\"orderaccconceptsid\" o6, \"enorderaccconcepts27\".\"applyforrequestproject\" o7, \"enorderaccconcepts27\".\"paymenttermid\" o8, \"enorderaccconcepts27\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts27\".\"isactive\" o10, \"enorderaccconcepts27\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts27\".\"paymentdate\" o12, \"enorderaccconcepts27\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts27\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts27\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts27\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts27\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts27\".\"accountingdatatypeid\" = ");
whereBuilder.Append(7
);
whereBuilder.Append(") AND (\"enorderaccconcepts27\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConcepts.List", cancellationToken: cancellationToken);
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

// Query Function "GetSubOrderAccConcepts" ixG5lm9ZekmRwzpQ1+8hQA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConcepts", "96b9118b-596f-497a-91c3-3a50d7ef2140");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConcepts", "96b9118b-596f-497a-91c3-3a50d7ef2140", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.ixG5lm9ZekmRwzpQ1+8hQA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts28\".\"id\" o0, \"enorderaccconcepts28\".\"orderaccountingid\" o1, \"enorderaccconcepts28\".\"accountingdatatypeid\" o2, \"enorderaccconcepts28\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts28\".\"amount\"::numeric) o4, \"enorderaccconcepts28\".\"currencyid\" o5, \"enorderaccconcepts28\".\"orderaccconceptsid\" o6, \"enorderaccconcepts28\".\"applyforrequestproject\" o7, \"enorderaccconcepts28\".\"paymenttermid\" o8, \"enorderaccconcepts28\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts28\".\"isactive\" o10, \"enorderaccconcepts28\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts28\".\"paymentdate\" o12, \"enorderaccconcepts28\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts28\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts28\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts28\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts28\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConcepts.List", cancellationToken: cancellationToken);
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

// Query Function "GetMainOrderAccConceptsVoucher" oI_OlgL6WEew5b4TNgg19A of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsVoucher(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsVoucher", "96ce8fa0-fa02-4758-b0e5-be13360835f4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsVoucher", "96ce8fa0-fa02-4758-b0e5-be13360835f4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.oI_OlgL6WEew5b4TNgg19A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts29\".\"id\" o0, \"enorderaccconcepts29\".\"orderaccountingid\" o1, \"enorderaccconcepts29\".\"accountingdatatypeid\" o2, \"enorderaccconcepts29\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts29\".\"amount\"::numeric) o4, \"enorderaccconcepts29\".\"currencyid\" o5, \"enorderaccconcepts29\".\"orderaccconceptsid\" o6, \"enorderaccconcepts29\".\"applyforrequestproject\" o7, \"enorderaccconcepts29\".\"paymenttermid\" o8, \"enorderaccconcepts29\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts29\".\"isactive\" o10, \"enorderaccconcepts29\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts29\".\"paymentdate\" o12, \"enorderaccconcepts29\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts29\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts29\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts29\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts29\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts29\".\"accountingdatatypeid\" = ");
whereBuilder.Append(6
);
whereBuilder.Append(") AND (\"enorderaccconcepts29\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsVoucher.List", cancellationToken: cancellationToken);
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

// Query Function "GetMainOrderAccConceptsFiniquito" QqDWovqyBU+Pm_LaqtapBA of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsFiniquito(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsFiniquito", "a2d6a042-b2fa-4f05-8f9b-f2daaad6a904");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsFiniquito", "a2d6a042-b2fa-4f05-8f9b-f2daaad6a904", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.QqDWovqyBU+Pm_LaqtapBA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts30\".\"id\" o0, \"enorderaccconcepts30\".\"orderaccountingid\" o1, \"enorderaccconcepts30\".\"accountingdatatypeid\" o2, \"enorderaccconcepts30\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts30\".\"amount\"::numeric) o4, \"enorderaccconcepts30\".\"currencyid\" o5, \"enorderaccconcepts30\".\"orderaccconceptsid\" o6, \"enorderaccconcepts30\".\"applyforrequestproject\" o7, \"enorderaccconcepts30\".\"paymenttermid\" o8, \"enorderaccconcepts30\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts30\".\"isactive\" o10, \"enorderaccconcepts30\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts30\".\"paymentdate\" o12, \"enorderaccconcepts30\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts30\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts30\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts30\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts30\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts30\".\"accountingdatatypeid\" = ");
whereBuilder.Append(4
);
whereBuilder.Append(") AND (\"enorderaccconcepts30\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
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
// Query Function "GetOrderExchangeRateEvidence" 5WdRrCQUZUiepmfzHWcyww of Action "GetAccountingData"
public static async Task<(RL_16bc0f170c91ed9fd3ef42e01c4db2cf,long)> datasetGetOrderExchangeRateEvidence(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderContractFile_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderExchangeRateEvidence", "ac5167e5-1424-4865-9ea6-67f31d6732c3");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderExchangeRateEvidence", "ac5167e5-1424-4865-9ea6-67f31d6732c3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.5WdRrCQUZUiepmfzHWcyww, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordercontractfile9\".\"id\" o0, \"enordercontractfile9\".\"orderid\" o1, \"enordercontractfile9\".\"orderfileid\" o2, \"enordercontractfile9\".\"contractfiletypeid\" o3, trim_scale(\"enordercontractfile9\".\"amount\"::numeric) o4, trim_scale(\"enordercontractfile9\".\"tarif\"::numeric) o5, \"enordercontractfile9\".\"currencyid\" o6, \"enordercontractfile9\".\"deposittypeid\" o7, \"enordercontractfile9\".\"insurancetypeid\" o8, \"enordercontractfile9\".\"advancepaymenttypeid\" o9, \"enordercontractfile9\".\"startbasedate\" o10, \"enordercontractfile9\".\"endbasedate\" o11, \"enordercontractfile9\".\"paymenttermsid\" o12, \"enordercontractfile9\".\"isforvendorupload\" o13, \"enorderfile10\".\"id\" o14, \"enorderfile10\".\"filename\" o15, \"enorderfile10\".\"vendor\" o16, \"enorderfile10\".\"doc_type\" o17, \"enorderfile10\".\"sap_object\" o18, \"enorderfile10\".\"createdby\" o19, \"enorderfile10\".\"createdon\" o20, \"enorderfile10\".\"storageid\" o21");
fromBuilder.Append(" FROM ({OrderContractFile} \"enordercontractfile9\" Left JOIN {OrderFile} \"enorderfile10\" ON (\"enordercontractfile9\".\"orderfileid\" = \"enorderfile10\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderContractFile_OrderId != 0) {
whereBuilder.Append("((\"enordercontractfile9\".\"orderid\" = @qporOrderContractFile_OrderId) AND (\"enordercontractfile9\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderContractFile_OrderId", DbType.Int64, qporOrderContractFile_OrderId);
} else {
whereBuilder.Append("(\"enordercontractfile9\".\"orderid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enordercontractfile9\".\"contractfiletypeid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderExchangeRateEvidence.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderExchangeRateEvidence.List", cancellationToken: cancellationToken);
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

// Query Function "GetSubOrderAccConceptsFiniquito" l_m5yqUwwkON53fp5Uy0lQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetSubOrderAccConceptsFiniquito(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccConceptsId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsFiniquito", "cab9f997-30a5-43c2-8de7-77e9e54cb495");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsFiniquito", "cab9f997-30a5-43c2-8de7-77e9e54cb495", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.l_m5yqUwwkON53fp5Uy0lQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts31\".\"id\" o0, \"enorderaccconcepts31\".\"orderaccountingid\" o1, \"enorderaccconcepts31\".\"accountingdatatypeid\" o2, \"enorderaccconcepts31\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts31\".\"amount\"::numeric) o4, \"enorderaccconcepts31\".\"currencyid\" o5, \"enorderaccconcepts31\".\"orderaccconceptsid\" o6, \"enorderaccconcepts31\".\"applyforrequestproject\" o7, \"enorderaccconcepts31\".\"paymenttermid\" o8, \"enorderaccconcepts31\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts31\".\"isactive\" o10, \"enorderaccconcepts31\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts31\".\"paymentdate\" o12, \"enorderaccconcepts31\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts31\"");
whereBuilder.Append(" WHERE (");
if (qporOrderAccConceptsId != 0) {
whereBuilder.Append("((\"enorderaccconcepts31\".\"orderaccconceptsid\" = @qporOrderAccConceptsId) AND (\"enorderaccconcepts31\".\"orderaccconceptsid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccConceptsId", DbType.Int64, qporOrderAccConceptsId);
} else {
whereBuilder.Append("(\"enorderaccconcepts31\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetSubOrderAccConceptsFiniquito.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderMainExchangeRate" umgP1vC470quJbNm_kznpw of Action "GetAccountingData"
public static async Task<(RL_06217d1a1f91440a5a69e4163e3e2c6f,long)> datasetGetOrderMainExchangeRate(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderMainExchangeRate", "d60f68ba-b8f0-4aef-ae25-b366fe4ce7a7");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderMainExchangeRate", "d60f68ba-b8f0-4aef-ae25-b366fe4ce7a7", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.umgP1vC470quJbNm_kznpw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enordermain106\".\"exchangerate\" \"exchangerate\"");
fromBuilder.Append(" FROM {OrderMain} \"enordermain106\"");
whereBuilder.Append(" WHERE ");
if (qporId != 0) {
whereBuilder.Append("((\"enordermain106\".\"id\" = @qporId) AND (\"enordermain106\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporId", DbType.Int64, qporId);
} else {
whereBuilder.Append("(\"enordermain106\".\"id\" IS NULL)");
}
groupByBuilder.Append(" GROUP BY \"enordermain106\".\"exchangerate\"");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderMainExchangeRate.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderMainExchangeRate.List", cancellationToken: cancellationToken);
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

// Query Function "GetMainOrderAccConceptsCreditNote" LNnB5xuEO0e3MqL+1WRbZQ of Action "GetAccountingData"
public static async Task<(RL_f805dfae1f4ccde9f7b0028b80707abe,long)> datasetGetMainOrderAccConceptsCreditNote(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderAccountingId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsCreditNote", "e7c1d92c-841b-473b-b732-a2fed5645b65");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsCreditNote", "e7c1d92c-841b-473b-b732-a2fed5645b65", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.LNnB5xuEO0e3MqL+1WRbZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccconcepts32\".\"id\" o0, \"enorderaccconcepts32\".\"orderaccountingid\" o1, \"enorderaccconcepts32\".\"accountingdatatypeid\" o2, \"enorderaccconcepts32\".\"numberofpayments\" o3, trim_scale(\"enorderaccconcepts32\".\"amount\"::numeric) o4, \"enorderaccconcepts32\".\"currencyid\" o5, \"enorderaccconcepts32\".\"orderaccconceptsid\" o6, \"enorderaccconcepts32\".\"applyforrequestproject\" o7, \"enorderaccconcepts32\".\"paymenttermid\" o8, \"enorderaccconcepts32\".\"paymenttermcustomdays\" o9, \"enorderaccconcepts32\".\"isactive\" o10, \"enorderaccconcepts32\".\"advancepaymenttypeid\" o11, \"enorderaccconcepts32\".\"paymentdate\" o12, \"enorderaccconcepts32\".\"paymentmethodsidtodelete\" o13");
fromBuilder.Append(" FROM {OrderAccConcepts} \"enorderaccconcepts32\"");
whereBuilder.Append(" WHERE ");
if (qporOrderAccountingId != 0) {
whereBuilder.Append("((\"enorderaccconcepts32\".\"orderaccountingid\" = @qporOrderAccountingId) AND (\"enorderaccconcepts32\".\"orderaccountingid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderAccountingId", DbType.Int64, qporOrderAccountingId);
} else {
whereBuilder.Append("(\"enorderaccconcepts32\".\"orderaccountingid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enorderaccconcepts32\".\"accountingdatatypeid\" = ");
whereBuilder.Append(5
);
whereBuilder.Append(") AND (\"enorderaccconcepts32\".\"orderaccconceptsid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetMainOrderAccConceptsCreditNote.List", cancellationToken: cancellationToken);
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

// Query Function "GetOrderAccountingsByOrderId" XssV8pnB_EmwQ8CzKItlXA of Action "GetAccountingData"
public static async Task<(RL_aedf606f6413243cfacf43ac13db404f,long)> datasetGetOrderAccountingsByOrderId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderAccountingsByOrderId", "f215cb5e-c199-49fc-b043-c0b3288b655c");
using var queryActivity = activitySource.CreateAggregateQueryActivity("e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderAccountingsByOrderId", "f215cb5e-c199-49fc-b043-c0b3288b655c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.5bs2OE6d90GE1lfXbOLs3w/NodesShownInESpaceTree.bLMF8Jkp70OXyG4K22Sghw/DataActions.Xm778cXj40aEghc0RJspuQ/NodesNotShownInESpaceTree.XssV8pnB_EmwQ8CzKItlXA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderaccounting6\".\"id\" o0, \"enorderaccounting6\".\"orderid\" o1, \"enorderaccounting6\".\"hasestim_equal_agrepaym_depr\" o2, \"enorderaccounting6\".\"hassettlement_depr\" o3, \"enorderaccounting6\".\"hascreditnote_depr\" o4, \"enorderaccounting6\".\"hasvoucher_depr\" o5, \"enorderaccounting6\".\"hasspecialpostdeliveryauth\" o6, \"enorderaccounting6\".\"specialpostdeliveryauthid\" o7, trim_scale(\"enorderaccounting6\".\"amount_deprec\"::numeric) o8, \"enorderaccounting6\".\"currencyid_deprec\" o9, \"enorderaccounting6\".\"paymentmethodid_deprec\" o10, \"enorderaccounting6\".\"paymenttermid_deprec\" o11, trim_scale(\"enorderaccounting6\".\"negociatedexchangerateacc\"::numeric) o12, \"enorderaccounting6\".\"exchangeratecomment\" o13, \"enorderaccounting6\".\"evidencefileid\" o14, \"enorderaccounting6\".\"hascontract\" o15, \"enorderaccounting6\".\"hasrepse\" o16, \"enorderaccounting6\".\"haspaymentsupplement\" o17, \"enorderaccounting6\".\"hasnoticeofpaymentsuspension\" o18");
fromBuilder.Append(" FROM {OrderAccounting} \"enorderaccounting6\"");
whereBuilder.Append(" WHERE ");
if (qporOrderId != 0) {
whereBuilder.Append("((\"enorderaccounting6\".\"orderid\" = @qporOrderId) AND (\"enorderaccounting6\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderId", DbType.Int64, qporOrderId);
} else {
whereBuilder.Append("(\"enorderaccounting6\".\"orderid\" IS NULL)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query e_Orders.Wb_OrderDetailPaymentInformation.GetAccountingData.GetOrderAccountingsByOrderId.List", cancellationToken: cancellationToken);
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
}


}
