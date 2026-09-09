using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel).Namespace);

    public string varLcl_ColumnJSONVar;
public int varLcl_CountAfterFetch;
public bool varLcl_Loading;
public bool varLcl_ReInvokeToggler;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public bool varLcl_IsSelected;
public bool varLcl_IsSelectAll;
public bool varLcl_IsShowSelectAll;
public bool varLcl_ShowFilters;
public string varLcSelectedIds;
public bool varLcl_ShowDetails;
public long varLcl_InvoiceId;
public bool varLcIsAnyBulkApprovable;
public long varLcl_FolioId;
public string varLcl_AmountFromText;
public string varLcl_AmountToText;
public RL_8e14ec72aef34f71202ab5fcdfb4c9b8 varLcl_TotalsList;
public bool varLcl_IsCalculating;
public int varLcl_TotalSelected;
public AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals;
public AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies;
public AggregateRecord<RL_036b78d631cef153f668611e54d43e5d> ScreenDataSetGetInvoicesSAP;
public AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies;
public AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ScreenDataSetGetInvoiceStatus;
public AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_FoliosContabilizationSAPStatus_ScreenModel(string varLcl_ColumnJSONVar, int varLcl_CountAfterFetch, bool varLcl_Loading, bool varLcl_ReInvokeToggler, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_IsSelected, bool varLcl_IsSelectAll, bool varLcl_IsShowSelectAll, bool varLcl_ShowFilters, string varLcSelectedIds, bool varLcl_ShowDetails, long varLcl_InvoiceId, bool varLcIsAnyBulkApprovable, long varLcl_FolioId, string varLcl_AmountFromText, string varLcl_AmountToText, RL_8e14ec72aef34f71202ab5fcdfb4c9b8 varLcl_TotalsList, bool varLcl_IsCalculating, int varLcl_TotalSelected, AggregateRecord<RL_0204de281fa136fb826199f876159fe4> ScreenDataSetGetSpecialApprovals, AggregateRecord<RL_1353a59e0688582d82bbddc41b47193e> ScreenDataSetGetCurrencies, AggregateRecord<RL_036b78d631cef153f668611e54d43e5d> ScreenDataSetGetInvoicesSAP, AggregateRecord<RL_86161aa08f9858d205ef72cffcb4919d> ScreenDataSetGetFrequencies, AggregateRecord<RL_3262178c68dd5ed5c99ed4279a563975> ScreenDataSetGetInvoiceStatus, AggregateRecord<RL_d567d658fa66fc955f880e37985e7f35> ScreenDataSetGetAccountingDataTypes, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_ColumnJSONVar", "l_CountAfterFetch", "l_Loading", "l_ReInvokeToggler", "l_StartIndex", "l_TableSort", "l_IsSelected", "l_IsSelectAll", "l_IsShowSelectAll", "l_ShowFilters", "SelectedIds", "l_ShowDetails", "l_InvoiceId", "IsAnyBulkApprovable", "l_FolioId", "l_AmountFromText", "l_AmountToText", "l_TotalsList", "l_IsCalculating", "l_TotalSelected", "GetSpecialApprovals", "GetCurrencies", "GetInvoicesSAP", "GetFrequencies", "GetInvoiceStatus", "GetAccountingDataTypes", "ClientVars"}, new string[] {"varLcl_ColumnJSONVar", "varLcl_CountAfterFetch", "varLcl_Loading", "varLcl_ReInvokeToggler", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_IsSelected", "varLcl_IsSelectAll", "varLcl_IsShowSelectAll", "varLcl_ShowFilters", "varLcSelectedIds", "varLcl_ShowDetails", "varLcl_InvoiceId", "varLcIsAnyBulkApprovable", "varLcl_FolioId", "varLcl_AmountFromText", "varLcl_AmountToText", "varLcl_TotalsList", "varLcl_IsCalculating", "varLcl_TotalSelected", "ScreenDataSetGetSpecialApprovals", "ScreenDataSetGetCurrencies", "ScreenDataSetGetInvoicesSAP", "ScreenDataSetGetFrequencies", "ScreenDataSetGetInvoiceStatus", "ScreenDataSetGetAccountingDataTypes", "clientVariables"});
this.varLcl_ColumnJSONVar = varLcl_ColumnJSONVar;
this.varLcl_CountAfterFetch = varLcl_CountAfterFetch;
this.varLcl_Loading = varLcl_Loading;
this.varLcl_ReInvokeToggler = varLcl_ReInvokeToggler;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_IsSelected = varLcl_IsSelected;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsShowSelectAll = varLcl_IsShowSelectAll;
this.varLcl_ShowFilters = varLcl_ShowFilters;
this.varLcSelectedIds = varLcSelectedIds;
this.varLcl_ShowDetails = varLcl_ShowDetails;
this.varLcl_InvoiceId = varLcl_InvoiceId;
this.varLcIsAnyBulkApprovable = varLcIsAnyBulkApprovable;
this.varLcl_FolioId = varLcl_FolioId;
this.varLcl_AmountFromText = varLcl_AmountFromText;
this.varLcl_AmountToText = varLcl_AmountToText;
this.varLcl_TotalsList = varLcl_TotalsList;
this.varLcl_IsCalculating = varLcl_IsCalculating;
this.varLcl_TotalSelected = varLcl_TotalSelected;
this.ScreenDataSetGetSpecialApprovals = ScreenDataSetGetSpecialApprovals;
this.ScreenDataSetGetCurrencies = ScreenDataSetGetCurrencies;
this.ScreenDataSetGetInvoicesSAP = ScreenDataSetGetInvoicesSAP;
this.ScreenDataSetGetFrequencies = ScreenDataSetGetFrequencies;
this.ScreenDataSetGetInvoiceStatus = ScreenDataSetGetInvoiceStatus;
this.ScreenDataSetGetAccountingDataTypes = ScreenDataSetGetAccountingDataTypes;
this.clientVariables = clientVariables;
}



    
// Query Function "GetSpecialApprovals" 3OdCGQWuZUqmslnUTNIoCw of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_0204de281fa136fb826199f876159fe4,long)> datasetGetSpecialApprovals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetSpecialApprovals", "1942e7dc-ae05-4a65-a6b2-59d44cd2280b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetSpecialApprovals");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets.3OdCGQWuZUqmslnUTNIoCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enspecialapproval3\".\"id\" o0, \"enspecialapproval3\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {SpecialApproval} \"enspecialapproval3\"");
whereBuilder.Append(" WHERE (\"enspecialapproval3\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetSpecialApprovals.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetSpecialApprovals.List", cancellationToken: cancellationToken);
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

// Query Function "GetCurrencies" _eX9LIucjk+77YowlFrxvw of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_1353a59e0688582d82bbddc41b47193e,long)> datasetGetCurrencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetCurrencies", "2cfde5fd-9c8b-4f8e-bbed-8a30945af1bf");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetCurrencies");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets._eX9LIucjk+77YowlFrxvw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"encurrency43\".\"code\" o0, \"encurrency43\".\"name\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {Currency} \"encurrency43\"");
whereBuilder.Append(" WHERE (\"encurrency43\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetCurrencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetCurrencies.List", cancellationToken: cancellationToken);
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

private static async Task<RC_d920d0aa189b36e12964653ae47b2e42> datasetGetInvoicesSAPReadDbAsync(RC_d920d0aa189b36e12964653ae47b2e42 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENAccountingDataType.Read( r, ref index);
rec.ssENBusinessValueCategory.Read( r, ref index);
rec.ssENBusinessValueSubcategory.Read( r, ref index);
rec.ssENCurrency.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFrequency.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceExtended.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENOrderAccConcepts.Read( r, ref index);
rec.ssENOrderDetail.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENPaymentTerms.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENSpecialApproval.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "CurrencyUserInvoiceInvoiceApprovalInvoiceStatusFolioOrderAccConceptsOrderMainInvoiceApprovalLevelOrderDetailSpecialApprovalInvoiceExtendedIsSelectedAccountingDataTypeSupplierFrequencyProject_Asset_ServicePaymentTermsBusinessValueCategoryBusinessValueSubcategoryRecord.IsSelected", false);
return rec;
}
// Query Function "GetInvoicesSAP" Lh1qNkubfUGcOXYN_CPLMg of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_036b78d631cef153f668611e54d43e5d,long)> datasetGetInvoicesSAP(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,int qpacOrderAccConcepts_AccountingDataTypeId,int qpinFolioContabilization_Filters_AmountFrom,decimal qpcuFolioContabilization_Filters_AmountTo,string qpteFolioContabilization_Filters_AssignedTo,string qpteFolioContabilization_Filters_BusinessValueCategory,string qpteFolioContabilization_Filters_BusinessValueSubCateg,string qpcuCurrency_Code,DateTime qpdaFolioContabilization_Filters_FolioCreatedOn,string qpteFolioContabilization_Filters_FolioNumber,int qpfrFrequency_Id,DateTime qpdaFolioContabilization_Filters_InvoiceCreatedOn,string qpteFolioContabilization_Filters_InvoiceName,int qpinInvoiceStatus_Id,string qpteFolioContabilization_Filters_OrderMainNumber,DateTime qpdaFolioContabilization_Filters_PaidOn,string qpteFolioContabilization_Filters_Period,string qpteFolioContabilization_Filters_Project,int qpspSpecialApproval_Id,long qpsuSupplier_Id,int qpinOffsetUtc,bool qpboGetIsCorporativo,long qpreOrderMain_DivisionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP", "366a1d2e-9b4b-417d-9c39-760dfc23cb32");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP");
// Query Iterations: Multiple
// Refresh Query BmfIAzznikyMuA8jYgzmPQ Iterations: Multiple
// Refresh Query DZ2HXv7EX061Cs6dI41l3Q Iterations: Multiple
// Refresh Query v+5chj7Vd0OU13T2Df+F9g Iterations: Multiple
// Refresh Query W8B5uRUSEEeTlSKlXJu9yw Iterations: Multiple
// Refresh Query JvZrMaJhZUOqSKSMk5ooCA Iterations: Multiple
// Refresh Query 8+k8WGhXakOuBY_5sx7BiA Iterations: Multiple
// Refresh Query dov0dQc+sUOeVZq9TwVDUA Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
await using(var sqlCountCmd = trans.CreateCommand()){
string sql = "";
string sqlCount = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets.Lh1qNkubfUGcOXYN_CPLMg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enaccountingdatatype15\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enbusinessvaluecategory7\".\"description\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enbusinessvaluesubcategory7\".\"description\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"encurrency44\".\"code\" o18, \"encurrency44\".\"name\" o19, \"encurrency44\".\"symbol\" o20, \"encurrency44\".\"minorunitdecimals\" o21, \"encurrency44\".\"isactive\" o22, \"enfolio85\".\"id\" o23, NULL o24, \"enfolio85\".\"folionumber\" o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, \"enfrequency10\".\"label\" o44, NULL o45, NULL o46, \"eninvoice145\".\"id\" o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, trim_scale(\"eninvoice145\".\"totalamount\"::numeric) o53, NULL o54, \"eninvoice145\".\"invoicestatusid\" o55, NULL o56, NULL o57, \"eninvoice145\".\"createdon\" o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, \"eninvoiceextended36\".\"folio\" o108, NULL o109, \"eninvoiceextended36\".\"fechaemision\" o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, \"eninvoicestatus21\".\"id\" o125, \"eninvoicestatus21\".\"label\" o126, \"eninvoicestatus21\".\"class\" o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, \"enorderaccconcepts34\".\"paymenttermcustomdays\" o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, \"enorderdetail20\".\"period\" o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, \"enordermain127\".\"ordernumber\" o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, \"enpaymentterms32\".\"ctd_dias\" o218, NULL o219, \"enpaymentterms32\".\"isspecial\" o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, \"enproject_asset_service28\".\"description\" o226, NULL o227, NULL o228, NULL o229, NULL o230, NULL o231, NULL o232, \"enspecialapproval4\".\"label\" o233, NULL o234, NULL o235, NULL o236, NULL o237, \"ensupplier131\".\"name\" o238, \"ensupplier131\".\"number\" o239, NULL o240, NULL o241, NULL o242, NULL o243, NULL o244, NULL o245, NULL o246, NULL o247, NULL o248, NULL o249, NULL o250, NULL o251, NULL o252, NULL o253, NULL o254, NULL o255, NULL o256, NULL o257, NULL o258, NULL o259, NULL o260, NULL o261, NULL o262, NULL o263, NULL o264, NULL o265, NULL o266, NULL o267, NULL o268, 0 \"isselected\"");
fromBuilder.Append(" FROM (((((((((((((((((({Invoice} \"eninvoice145\" Left JOIN {InvoiceStatus} \"eninvoicestatus21\" ON (\"eninvoice145\".\"invoicestatusid\" = \"eninvoicestatus21\".\"id\"))  Inner JOIN {Folio} \"enfolio85\" ON (\"eninvoice145\".\"folioid\" = \"enfolio85\".\"id\"))  Left JOIN {Supplier} \"ensupplier131\" ON (\"enfolio85\".\"supplierid\" = \"ensupplier131\".\"id\"))  Inner JOIN {OrderMain} \"enordermain127\" ON (\"enfolio85\".\"orderid\" = \"enordermain127\".\"id\"))  Left JOIN {OrderDetail} \"enorderdetail20\" ON (\"enordermain127\".\"id\" = \"enorderdetail20\".\"orderid\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service28\" ON (\"enorderdetail20\".\"projectassetserviceid\" = \"enproject_asset_service28\".\"id\"))  Left JOIN {Frequency} \"enfrequency10\" ON (\"enorderdetail20\".\"frequency\" = \"enfrequency10\".\"id\"))  Left JOIN {InvoiceExtended} \"eninvoiceextended36\" ON (\"eninvoice145\".\"id\" = \"eninvoiceextended36\".\"id\"))  Left JOIN {BusinessValueCategory} \"enbusinessvaluecategory7\" ON (\"enorderdetail20\".\"businessvaluecategoryid\" = \"enbusinessvaluecategory7\".\"id\"))  Left JOIN {BusinessValueSubcategory} \"enbusinessvaluesubcategory7\" ON (\"enorderdetail20\".\"businessvaluesubcategoryid\" = \"enbusinessvaluesubcategory7\".\"id\"))  Left JOIN {InvoiceApproval} \"eninvoiceapproval46\" ON (\"eninvoice145\".\"id\" = \"eninvoiceapproval46\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel45\" ON ((\"eninvoiceapproval46\".\"id\" = \"eninvoiceapprovallevel45\".\"invoiceapprovalid\") AND (\"eninvoiceapprovallevel45\".\"approvalstatusid\" = ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
fromBuilder.Append(")))  Left JOIN {User} \"enuser229\" ON (\"eninvoiceapprovallevel45\".\"assignedto\" = \"enuser229\".\"id\"))  Left JOIN {Currency} \"encurrency44\" ON (\"enfolio85\".\"currencyid\" = \"encurrency44\".\"code\"))  Left JOIN {SpecialApproval} \"enspecialapproval4\" ON (\"enorderdetail20\".\"specialapprovalid\" = \"enspecialapproval4\".\"id\"))  Left JOIN {OrderAccConcepts} \"enorderaccconcepts34\" ON (\"eninvoice145\".\"orderaccconceptsid\" = \"enorderaccconcepts34\".\"id\"))  Left JOIN {AccountingDataType} \"enaccountingdatatype15\" ON (\"enorderaccconcepts34\".\"accountingdatatypeid\" = \"enaccountingdatatype15\".\"id\"))  Left JOIN {PaymentTerms} \"enpaymentterms32\" ON (\"enorderaccconcepts34\".\"paymenttermid\" = \"enpaymentterms32\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpboCheckUserSession = 1) AND ((CASE WHEN (@qpboGetIsCorporativo = 1) THEN 1 ELSE (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpboGetIsCorporativo", DbType.Boolean, qpboGetIsCorporativo);
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain127\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain127\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain127\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1) AND ((((\"eninvoicestatus21\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("CJKmpdl1bUqOtDMY59Vg9Q"))).ssId);
whereBuilder.Append(") OR (\"eninvoicestatus21\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus21\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus21\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("J4p4BoSeP06EZmvoJ_ofhg"))).ssId);
whereBuilder.Append(")) AND ");
if (qpsuSupplier_Id != Convert.ToInt64(BuiltInFunction.NullIdentifier())) {
if (qpsuSupplier_Id != 0) {
whereBuilder.Append("((\"ensupplier131\".\"id\" = @qpsuSupplier_Id) AND (\"ensupplier131\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpsuSupplier_Id", DbType.Int64, qpsuSupplier_Id);
} else {
whereBuilder.Append("(\"ensupplier131\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteFolioContabilization_Filters_InvoiceName != "" && qpteFolioContabilization_Filters_InvoiceName != "") {
whereBuilder.Append("(caseaccent_normalize(\"eninvoice145\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_InvoiceName) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_InvoiceName", DbType.String, qpteFolioContabilization_Filters_InvoiceName);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_InvoiceName", DbType.String, qpteFolioContabilization_Filters_InvoiceName);
}
if (qpteFolioContabilization_Filters_FolioNumber != "" && qpteFolioContabilization_Filters_FolioNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enfolio85\".\"folionumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_FolioNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_FolioNumber", DbType.String, qpteFolioContabilization_Filters_FolioNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_FolioNumber", DbType.String, qpteFolioContabilization_Filters_FolioNumber);
}
if (qpinInvoiceStatus_Id != BuiltInFunction.NullIdentifier()) {
if (qpinInvoiceStatus_Id != 0) {
whereBuilder.Append("((\"eninvoicestatus21\".\"id\" = @qpinInvoiceStatus_Id) AND (\"eninvoicestatus21\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpinInvoiceStatus_Id", DbType.Int32, qpinInvoiceStatus_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinInvoiceStatus_Id", DbType.Int32, qpinInvoiceStatus_Id);
} else {
whereBuilder.Append("(\"eninvoicestatus21\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteFolioContabilization_Filters_OrderMainNumber != "" && qpteFolioContabilization_Filters_OrderMainNumber != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain127\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_OrderMainNumber) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_OrderMainNumber", DbType.String, qpteFolioContabilization_Filters_OrderMainNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_OrderMainNumber", DbType.String, qpteFolioContabilization_Filters_OrderMainNumber);
}
if (qpteFolioContabilization_Filters_AssignedTo != "" && qpteFolioContabilization_Filters_AssignedTo != "") {
whereBuilder.Append("(caseaccent_normalize(\"enuser229\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_AssignedTo) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_AssignedTo", DbType.String, qpteFolioContabilization_Filters_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_AssignedTo", DbType.String, qpteFolioContabilization_Filters_AssignedTo);
}
if (qpteFolioContabilization_Filters_Project != "" && qpteFolioContabilization_Filters_Project != "") {
whereBuilder.Append("(caseaccent_normalize(\"enproject_asset_service28\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_Project) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_Project", DbType.String, qpteFolioContabilization_Filters_Project);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_Project", DbType.String, qpteFolioContabilization_Filters_Project);
}
if (qpteFolioContabilization_Filters_Period != "" && qpteFolioContabilization_Filters_Period != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdetail20\".\"period\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_Period) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_Period", DbType.String, qpteFolioContabilization_Filters_Period);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_Period", DbType.String, qpteFolioContabilization_Filters_Period);
}
if (qpfrFrequency_Id != BuiltInFunction.NullIdentifier()) {
if (qpfrFrequency_Id != 0) {
whereBuilder.Append("((\"enfrequency10\".\"id\" = @qpfrFrequency_Id) AND (\"enfrequency10\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpfrFrequency_Id", DbType.Int32, qpfrFrequency_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpfrFrequency_Id", DbType.Int32, qpfrFrequency_Id);
} else {
whereBuilder.Append("(\"enfrequency10\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpteFolioContabilization_Filters_BusinessValueCategory != "" && qpteFolioContabilization_Filters_BusinessValueCategory != "") {
whereBuilder.Append("(caseaccent_normalize(\"enbusinessvaluecategory7\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_BusinessValueCategory) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_BusinessValueCategory", DbType.String, qpteFolioContabilization_Filters_BusinessValueCategory);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_BusinessValueCategory", DbType.String, qpteFolioContabilization_Filters_BusinessValueCategory);
}
if (qpteFolioContabilization_Filters_BusinessValueSubCateg != "" && qpteFolioContabilization_Filters_BusinessValueSubCateg != "") {
whereBuilder.Append("(caseaccent_normalize(\"enbusinessvaluesubcategory7\".\"description\" collate \"default\") like caseaccent_normalize((('%' || @qpteFolioContabilization_Filters_BusinessValueSubCateg) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_BusinessValueSubCateg", DbType.String, qpteFolioContabilization_Filters_BusinessValueSubCateg);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteFolioContabilization_Filters_BusinessValueSubCateg", DbType.String, qpteFolioContabilization_Filters_BusinessValueSubCateg);
}
if (qpdaFolioContabilization_Filters_PaidOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice145\".\"updatedon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) = @qpdaFolioContabilization_Filters_PaidOn) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_PaidOn", DbType.DateTime, qpdaFolioContabilization_Filters_PaidOn);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_PaidOn", DbType.DateTime, qpdaFolioContabilization_Filters_PaidOn);
}
if (qpinFolioContabilization_Filters_AmountFrom != 0) {
whereBuilder.Append("(\"eninvoice145\".\"totalamount\" >= cast(@qpinFolioContabilization_Filters_AmountFrom as decimal)) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinFolioContabilization_Filters_AmountFrom", DbType.Int32, qpinFolioContabilization_Filters_AmountFrom);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinFolioContabilization_Filters_AmountFrom", DbType.Int32, qpinFolioContabilization_Filters_AmountFrom);
}
if (qpcuFolioContabilization_Filters_AmountTo != (((decimal)0))) {
whereBuilder.Append("(\"eninvoice145\".\"totalamount\" <= @qpcuFolioContabilization_Filters_AmountTo) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpcuFolioContabilization_Filters_AmountTo", DbType.Decimal, qpcuFolioContabilization_Filters_AmountTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcuFolioContabilization_Filters_AmountTo", DbType.Decimal, qpcuFolioContabilization_Filters_AmountTo);
}
if (qpcuCurrency_Code != BuiltInFunction.NullTextIdentifier()) {
if ((qpcuCurrency_Code.Trim()!="")) {
whereBuilder.Append("((\"encurrency44\".\"code\" = @qpcuCurrency_Code) AND (\"encurrency44\".\"code\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpcuCurrency_Code", DbType.String, qpcuCurrency_Code);
sqlCountCmd.CreateParameterWithoutReplacements("@qpcuCurrency_Code", DbType.String, qpcuCurrency_Code);
} else {
whereBuilder.Append("(\"encurrency44\".\"code\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpdaFolioContabilization_Filters_InvoiceCreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"eninvoice145\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) = @qpdaFolioContabilization_Filters_InvoiceCreatedOn) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_InvoiceCreatedOn", DbType.DateTime, qpdaFolioContabilization_Filters_InvoiceCreatedOn);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_InvoiceCreatedOn", DbType.DateTime, qpdaFolioContabilization_Filters_InvoiceCreatedOn);
}
if (qpdaFolioContabilization_Filters_FolioCreatedOn != BuiltInFunction.NullDate()) {
whereBuilder.Append("((cast(((\"enfolio85\".\"createdon\"::timestamptz + ((cast((@qpinOffsetUtc * (-1)) as integer)) * interval '1 hour'))) as date)::timestamptz) = @qpdaFolioContabilization_Filters_FolioCreatedOn) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinOffsetUtc", DbType.Int32, qpinOffsetUtc);
sqlCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_FolioCreatedOn", DbType.DateTime, qpdaFolioContabilization_Filters_FolioCreatedOn);
sqlCountCmd.CreateParameterWithoutReplacements("@qpdaFolioContabilization_Filters_FolioCreatedOn", DbType.DateTime, qpdaFolioContabilization_Filters_FolioCreatedOn);
}
if (qpspSpecialApproval_Id != BuiltInFunction.NullIdentifier()) {
if (qpspSpecialApproval_Id != 0) {
whereBuilder.Append("((\"enspecialapproval4\".\"id\" = @qpspSpecialApproval_Id) AND (\"enspecialapproval4\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpspSpecialApproval_Id", DbType.Int32, qpspSpecialApproval_Id);
sqlCountCmd.CreateParameterWithoutReplacements("@qpspSpecialApproval_Id", DbType.Int32, qpspSpecialApproval_Id);
} else {
whereBuilder.Append("(\"enspecialapproval4\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ");
}
if (qpacOrderAccConcepts_AccountingDataTypeId != BuiltInFunction.NullIdentifier()) {
if (qpacOrderAccConcepts_AccountingDataTypeId != 0) {
whereBuilder.Append("((\"enorderaccconcepts34\".\"accountingdatatypeid\" = @qpacOrderAccConcepts_AccountingDataTypeId) AND (\"enorderaccconcepts34\".\"accountingdatatypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpacOrderAccConcepts_AccountingDataTypeId", DbType.Int32, qpacOrderAccConcepts_AccountingDataTypeId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpacOrderAccConcepts_AccountingDataTypeId", DbType.Int32, qpacOrderAccConcepts_AccountingDataTypeId);
} else {
whereBuilder.Append("(\"enorderaccconcepts34\".\"accountingdatatypeid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY 1 ASC");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
if (startIndex > 0) {
orderByBuilder.Append(" OFFSET ");
orderByBuilder.Append(startIndex);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCount = "SELECT COUNT(1) " + fromBuilder.ToString() + whereBuilder.ToString() + groupByBuilder.ToString() + havingBuilder.ToString();
sqlCount = AppUtils.Instance.ReplaceEntityReferences(requestContext, sqlCount);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
sqlCountCmd.CommandText = sqlCount;
try {
RL_036b78d631cef153f668611e54d43e5d outParamList = new RL_036b78d631cef153f668611e54d43e5d();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesSAPReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[19];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, true, true, true, true, true, false, true, false, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, false, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, false, true, true});
opt[11] = new BitArray(new bool[] {true, true, false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, false, true, true, true});
opt[13] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[14] = new BitArray(new bool[] {true, false, true, true});
opt[15] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[16] = new BitArray(new bool[] {true, true, true, true, false, true, false, true, true, true, true});
opt[17] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[18] = new BitArray(new bool[] {true, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_036b78d631cef153f668611e54d43e5d _tmp = new RL_036b78d631cef153f668611e54d43e5d();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesSAPReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_036b78d631cef153f668611e54d43e5d)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoicesSAP.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetFrequencies" EeQBQ3soP0+ANN4UHzhXeQ of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_86161aa08f9858d205ef72cffcb4919d,long)> datasetGetFrequencies(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetFrequencies", "4301e411-287b-4f3f-8034-de141f385779");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetFrequencies");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets.EeQBQ3soP0+ANN4UHzhXeQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enfrequency11\".\"id\" o0, \"enfrequency11\".\"label\" o1, NULL o2, NULL o3");
fromBuilder.Append(" FROM {Frequency} \"enfrequency11\"");
orderByBuilder.Append(" ORDER BY \"enfrequency11\".\"label\" ASC ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetFrequencies.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetFrequencies.List", cancellationToken: cancellationToken);
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

// Query Function "GetInvoiceStatus" rjS2yUMng0GvIXo0sodong of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_3262178c68dd5ed5c99ed4279a563975,long)> datasetGetInvoiceStatus(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoiceStatus", "c9b634ae-2743-4183-af21-7a34b287689e");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoiceStatus");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets.rjS2yUMng0GvIXo0sodong, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"eninvoicestatus22\".\"id\" o0, \"eninvoicestatus22\".\"label\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6");
fromBuilder.Append(" FROM {InvoiceStatus} \"eninvoicestatus22\"");
whereBuilder.Append(" WHERE ((((\"eninvoicestatus22\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("h+R+u64a50K6vJ2dkkiVXQ"))).ssId);
whereBuilder.Append(") OR (\"eninvoicestatus22\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("CJKmpdl1bUqOtDMY59Vg9Q"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus22\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Tfj332sYfU6orP6hWpZ2sg"))).ssId);
whereBuilder.Append(")) OR (\"eninvoicestatus22\".\"id\" = ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("J4p4BoSeP06EZmvoJ_ofhg"))).ssId);
whereBuilder.Append("))");
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
RL_3262178c68dd5ed5c99ed4279a563975 outParamList = new RL_3262178c68dd5ed5c99ed4279a563975();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoiceStatus.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3262178c68dd5ed5c99ed4279a563975 _tmp = new RL_3262178c68dd5ed5c99ed4279a563975();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetInvoiceStatus.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3262178c68dd5ed5c99ed4279a563975)_tmp;
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

// Query Function "GetAccountingDataTypes" GS7y2BOVR0WLFv5cHcfCCw of Action "FoliosContabilizationSAPStatus"
public static async Task<(RL_d567d658fa66fc955f880e37985e7f35,long)> datasetGetAccountingDataTypes(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.FoliosContabilizationSAPStatus.GetAccountingDataTypes", "d8f22e19-9513-4547-8b16-fe5c1dc7c20b");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("FoliosContabilizationSAPStatus","j_FoliosSAE.FoliosContabilizationSAPStatus.GetAccountingDataTypes");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.DFZ7J0HyYEy6jwZaMi0kxA/ScreenDataSets.GS7y2BOVR0WLFv5cHcfCCw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enaccountingdatatype16\".\"id\" o0, \"enaccountingdatatype16\".\"label\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {AccountingDataType} \"enaccountingdatatype16\"");
whereBuilder.Append(" WHERE (\"enaccountingdatatype16\".\"is_active\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.FoliosContabilizationSAPStatus.GetAccountingDataTypes.List", cancellationToken: cancellationToken);
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


    

    

}
