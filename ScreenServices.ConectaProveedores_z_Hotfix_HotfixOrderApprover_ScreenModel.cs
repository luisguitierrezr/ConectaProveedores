using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel).Namespace);

    public string varLcUserOriginal;
public string varLcUserSubstitute;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public string varLcOrderNumberFilter;
public int varLcOrderStatusId;
public AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ScreenDataSetGetUserOriginal;
public AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> ScreenDataSetGetOrderStatuses;
public AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoices;
public AggregateRecord<RL_6a0d508a138cc1e49e6d938f0b4069dd> ScreenDataSetGetOrderApprovalLevelsByAssignedTo;
public ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Model varLcGetRequisitions;
public ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel() {
}



    public ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel(string varLcUserOriginal, string varLcUserSubstitute, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, string varLcOrderNumberFilter, int varLcOrderStatusId, AggregateRecord<RL_bc2063fe1d05aa544017f329fb1e030b> ScreenDataSetGetUserOriginal, AggregateRecord<RL_cf716c649767b1312d0b25fa52ff2f38> ScreenDataSetGetOrderStatuses, AggregateRecord<RL_c5ca0a80d78493d156f2b1a68d86a831> ScreenDataSetGetInvoices, AggregateRecord<RL_6a0d508a138cc1e49e6d938f0b4069dd> ScreenDataSetGetOrderApprovalLevelsByAssignedTo, ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetRequisitions_Model varLcGetRequisitions, ConectaProveedores_z_Hotfix_HotfixOrderApprover_DataActionGetUserApplicationRolesAndMore_Model varLcGetUserApplicationRolesAndMore, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"UserOriginal", "UserSubstitute", "TableSort", "StartIndex", "MaxRecords", "OrderNumberFilter", "OrderStatusId", "GetUserOriginal", "GetOrderStatuses", "GetInvoices", "GetOrderApprovalLevelsByAssignedTo", "GetRequisitions", "GetUserApplicationRolesAndMore", "ClientVars"}, new string[] {"varLcUserOriginal", "varLcUserSubstitute", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcOrderNumberFilter", "varLcOrderStatusId", "ScreenDataSetGetUserOriginal", "ScreenDataSetGetOrderStatuses", "ScreenDataSetGetInvoices", "ScreenDataSetGetOrderApprovalLevelsByAssignedTo", "varLcGetRequisitions", "varLcGetUserApplicationRolesAndMore", "clientVariables"});
this.varLcUserOriginal = varLcUserOriginal;
this.varLcUserSubstitute = varLcUserSubstitute;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcOrderNumberFilter = varLcOrderNumberFilter;
this.varLcOrderStatusId = varLcOrderStatusId;
this.ScreenDataSetGetUserOriginal = ScreenDataSetGetUserOriginal;
this.ScreenDataSetGetOrderStatuses = ScreenDataSetGetOrderStatuses;
this.ScreenDataSetGetInvoices = ScreenDataSetGetInvoices;
this.ScreenDataSetGetOrderApprovalLevelsByAssignedTo = ScreenDataSetGetOrderApprovalLevelsByAssignedTo;
this.varLcGetRequisitions = varLcGetRequisitions;
this.varLcGetUserApplicationRolesAndMore = varLcGetUserApplicationRolesAndMore;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_184336c68155ad9e77005f91e8e8b363> datasetGetUserOriginalReadDbAsync(RC_184336c68155ad9e77005f91e8e8b363 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserExtension.Read( r, ref index);
return rec;
}
// Query Function "GetUserOriginal" iWdac5Ml9kaNUqmMcv527Q of Action "HotfixOrderApprover"
public static async Task<(RL_bc2063fe1d05aa544017f329fb1e030b,long)> datasetGetUserOriginal(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("z_Hotfix.HotfixOrderApprover.GetUserOriginal", "735a6789-2593-46f6-8d52-a98c72fe76ed");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("HotfixOrderApprover","z_Hotfix.HotfixOrderApprover.GetUserOriginal");
// Query Iterations: Never
// Refresh Query 3uFCFFnex0Cicra8ECmLnA Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/ScreenDataSets.iWdac5Ml9kaNUqmMcv527Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enuser_extended_internal120\".\"regionid\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, \"enuser_extended_internal120\".\"entraroleid\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27");
fromBuilder.Append(" FROM (({User} \"enuser189\" Left JOIN {User_Extended_Internal} \"enuser_extended_internal120\" ON (\"enuser189\".\"id\" = \"enuser_extended_internal120\".\"id\"))  Left JOIN {UserExtension} \"enuserextension76\" ON (\"enuser189\".\"id\" = \"enuserextension76\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser189\".\"id\" = @qpusUser_Id) AND (\"enuser189\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser189\".\"id\" IS NULL)");
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
RL_bc2063fe1d05aa544017f329fb1e030b outParamList = new RL_bc2063fe1d05aa544017f329fb1e030b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserOriginalReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetUserOriginal.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_bc2063fe1d05aa544017f329fb1e030b _tmp = new RL_bc2063fe1d05aa544017f329fb1e030b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserOriginalReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetUserOriginal.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_bc2063fe1d05aa544017f329fb1e030b)_tmp;
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

// Query Function "GetOrderStatuses" lf2gnGQ+80uofd7HHKeuqA of Action "HotfixOrderApprover"
public static async Task<(RL_cf716c649767b1312d0b25fa52ff2f38,long)> datasetGetOrderStatuses(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("z_Hotfix.HotfixOrderApprover.GetOrderStatuses", "9ca0fd95-3e64-4bf3-a87d-dec71ca7aea8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("HotfixOrderApprover","z_Hotfix.HotfixOrderApprover.GetOrderStatuses");
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/ScreenDataSets.lf2gnGQ+80uofd7HHKeuqA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enorderstatus15\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, \"enorderstatus15\".\"labeles\" o5");
fromBuilder.Append(" FROM {OrderStatus} \"enorderstatus15\"");
whereBuilder.Append(" WHERE (\"enorderstatus15\".\"is_active\" = 1)");
orderByBuilder.Append(" ORDER BY \"enorderstatus15\".\"labeles\" ASC ");
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
RL_cf716c649767b1312d0b25fa52ff2f38 outParamList = new RL_cf716c649767b1312d0b25fa52ff2f38();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetOrderStatuses.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_cf716c649767b1312d0b25fa52ff2f38 _tmp = new RL_cf716c649767b1312d0b25fa52ff2f38();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetOrderStatuses.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_cf716c649767b1312d0b25fa52ff2f38)_tmp;
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

private static async Task<RC_acb134934352a9d72fd2cc0509d2f469> datasetGetInvoicesReadDbAsync(RC_acb134934352a9d72fd2cc0509d2f469 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENCompany.Read( r, ref index);
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceAccounting.Read( r, ref index);
rec.ssENInvoiceApproval.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENInvoiceStatus.Read( r, ref index);
rec.ssENProject_Asset_Service.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssDontShowAction = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.DontShowAction", false);
rec.ssIsSelected = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsSelected", false);
rec.ssIsUserFromThisRegion = r.ReadBoolean(index++, "UserInvoiceInvoiceApprovalInvoiceStatusApprovalStatusRequisitionInvoiceApprovalLevelInvoiceAccountingApplicationRoleDontShowActionIsSelectedIsUserFromThisRegionCompanySupplierProject_Asset_ServiceRegionRecord.IsUserFromThisRegion", false);
return rec;
}
// Query Function "GetInvoices" TQjz1mlSQEKrBSwFw0imCg of Action "HotfixOrderApprover"
public static async Task<(RL_c5ca0a80d78493d156f2b1a68d86a831,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRolesListText,long qpreCorporativoRegionId,bool qpboIsCorporativoCxP,string qpteTelcelDirectionsListText,long qpreGetUserRegionId,long qpreRequisition_RegionId,string qpusUserOriginal,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("z_Hotfix.HotfixOrderApprover.GetInvoices", "d6f3084d-5269-4240-ab05-2c05c348a60a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("HotfixOrderApprover","z_Hotfix.HotfixOrderApprover.GetInvoices");
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/ScreenDataSets.TQjz1mlSQEKrBSwFw0imCg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, NULL o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, NULL o151, NULL o152, NULL o153, NULL o154, NULL o155, NULL o156, NULL o157, NULL o158, NULL o159, NULL o160, NULL o161, NULL o162, NULL o163, NULL o164, NULL o165, NULL o166, NULL o167, NULL o168, NULL o169, NULL o170, NULL o171, NULL o172, NULL o173, NULL o174, NULL o175, NULL o176, NULL o177, NULL o178, NULL o179, NULL o180, NULL o181, NULL o182, NULL o183, NULL o184, NULL o185, NULL o186, NULL o187, NULL o188, NULL o189, NULL o190, NULL o191, NULL o192, NULL o193, NULL o194, NULL o195, NULL o196, NULL o197, NULL o198, NULL o199, NULL o200, NULL o201, NULL o202, NULL o203, NULL o204, NULL o205, NULL o206, NULL o207, NULL o208, NULL o209, NULL o210, NULL o211, NULL o212, NULL o213, NULL o214, NULL o215, NULL o216, NULL o217, NULL o218, NULL o219, NULL o220, NULL o221, NULL o222, NULL o223, NULL o224, NULL o225, (CASE WHEN (\"eninvoiceapprovallevel40\".\"approvalstatusid\" IS NULL) THEN 1 ELSE 0 END) \"dontshowaction\", 0 \"isselected\", (CASE WHEN (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition117\".\"regionid\" = @qpreGetUserRegionId) AND (\"enrequisition117\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition117\".\"regionid\" IS NULL)");
}
selectBuilder.Append(" OR (");
if (qpreGetUserRegionId != 0) {
selectBuilder.Append("((\"enrequisition117\".\"accountingregionid\" = @qpreGetUserRegionId) AND (\"enrequisition117\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
selectBuilder.Append("(\"enrequisition117\".\"accountingregionid\" IS NULL)");
}
selectBuilder.Append(" AND (\"enrequisition117\".\"accountingregionid\" IS NOT NULL))) THEN 1 ELSE 0 END) \"isuserfromthisregion\"");
fromBuilder.Append(" FROM (((((((((((({Invoice} \"eninvoice135\" Left JOIN {InvoiceApproval} \"eninvoiceapproval42\" ON (\"eninvoice135\".\"id\" = \"eninvoiceapproval42\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel40\" ON ((\"eninvoiceapprovallevel40\".\"invoiceapprovalid\" = \"eninvoiceapproval42\".\"id\") AND ((\"eninvoiceapprovallevel40\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel40\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusUserOriginal.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel40\".\"assignedto\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel40\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel40\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel40\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRolesListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRolesListText", DbType.String, qpteAppRolesListText);
if ((qpusUserOriginal.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel40\".\"approvedby\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel40\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusUserOriginal.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel40\".\"requesttomodifyby\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel40\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusUserOriginal.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel40\".\"canceledby\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel40\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {Requisition} \"enrequisition117\" ON (\"eninvoice135\".\"requisitionid\" = \"enrequisition117\".\"id\"))  Left JOIN {Supplier} \"ensupplier114\" ON (\"enrequisition117\".\"supplierid\" = \"ensupplier114\".\"id\"))  Left JOIN {InvoiceStatus} \"eninvoicestatus16\" ON (\"eninvoice135\".\"invoicestatusid\" = \"eninvoicestatus16\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole68\" ON (\"eninvoiceapprovallevel40\".\"applicationroleid\" = \"enapplicationrole68\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus18\" ON (\"eninvoiceapprovallevel40\".\"approvalstatusid\" = \"enapprovalstatus18\".\"id\"))  Left JOIN {InvoiceAccounting} \"eninvoiceaccounting36\" ON (\"eninvoice135\".\"id\" = \"eninvoiceaccounting36\".\"invoiceid\"))  Left JOIN {Region} \"enregion147\" ON (\"enrequisition117\".\"regionid\" = \"enregion147\".\"id\"))  Left JOIN {Company} \"encompany53\" ON (\"enrequisition117\".\"companyid\" = \"encompany53\".\"id\"))  Left JOIN {Project_Asset_Service} \"enproject_asset_service24\" ON (\"enrequisition117\".\"projectassetserviceid\" = \"enproject_asset_service24\".\"id\"))  Left JOIN {User} \"enuser190\" ON (\"eninvoiceapprovallevel40\".\"assignedto\" = \"enuser190\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice135\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND ((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (1 = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition117\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition117\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition117\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition117\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition117\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition117\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition117\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition117\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition117\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition117\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition117\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusUserOriginal.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel40\".\"assignedto\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel40\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition117\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition117\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition117\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel40\".\"id\" IS NOT NULL)) OR ");
if ((qpusUserOriginal.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel40\".\"assignedto\" = @qpusUserOriginal) AND (\"eninvoiceapprovallevel40\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserOriginal", DbType.String, qpusUserOriginal);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel40\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
orderByBuilder.Append(" ORDER BY \"eninvoicestatus16\".\"isinaccounting\" DESC , \"enregion147\".\"code\" ASC , \"enapprovalstatus18\".\"order\" ASC , \"eninvoice135\".\"createdon\" DESC ");
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_c5ca0a80d78493d156f2b1a68d86a831 outParamList = new RL_c5ca0a80d78493d156f2b1a68d86a831();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[13];
opt[0] = new BitArray(new bool[] {true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[8] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[9] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true});
opt[10] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[11] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[12] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c5ca0a80d78493d156f2b1a68d86a831 _tmp = new RL_c5ca0a80d78493d156f2b1a68d86a831();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c5ca0a80d78493d156f2b1a68d86a831)_tmp;
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

private static async Task<RC_a2ea85a9f362412e4b6f04be74bb4c8a> datasetGetOrderApprovalLevelsByAssignedToReadDbAsync(RC_a2ea85a9f362412e4b6f04be74bb4c8a rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENEntraRole.Read( r, ref index);
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevelsByAssignedTo" HKI+6QnnMUGrGZoncxNWhw of Action "HotfixOrderApprover"
public static async Task<(RL_6a0d508a138cc1e49e6d938f0b4069dd,long)> datasetGetOrderApprovalLevelsByAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenOrderApprovalLevel_EntraRoleId,long qpreOrderMain_DivisionId,string qpteOrderNumberFilter,int qporOrderMain_OrderStatusId,string qpteTableSort,string qpusOrderApprovalLevel_AssignedTo,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo", "e93ea21c-e709-4131-ab19-9a2773135687");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("HotfixOrderApprover","z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo");
// Query Iterations: Multiple
// Refresh Query 0o5W7_Z0mECCXeqcYfv7ww Iterations: Multiple
// Refresh Query mxK+LUqpXU+jn5ZQr9CQPg Iterations: Multiple
// Refresh Query vxBKxA5RnkWUApzGg2yW5Q Iterations: Multiple
// Refresh Query pRFmcrc9vkCO2EMG64gb0g Iterations: Multiple
// Refresh Query Wl4QDRY43UyTe+KWS6RQuQ Iterations: Multiple
// Refresh Query jiNhpdnR+UmD6ejPEwyK+w Iterations: Multiple
// Refresh Query jQj0jSU3I0ueqP_OvnB_lg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/ScreenDataSets.HKI+6QnnMUGrGZoncxNWhw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole65\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderapprovallevel32\".\"id\" o14, NULL o15, \"enorderapprovallevel32\".\"levelnumber\" o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enordermain109\".\"ordernumber\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, \"enuser191\".\"name\" o61, NULL o62, NULL o63, NULL o64");
fromBuilder.Append(" FROM (((({OrderApprovalLevel} \"enorderapprovallevel32\" Left JOIN {OrderApproval} \"enorderapproval33\" ON (\"enorderapprovallevel32\".\"orderapprovalid\" = \"enorderapproval33\".\"id\"))  Left JOIN {EntraRole} \"enentrarole65\" ON (\"enorderapprovallevel32\".\"entraroleid\" = \"enentrarole65\".\"id\"))  Left JOIN {User} \"enuser191\" ON (\"enorderapprovallevel32\".\"assignedto\" = \"enuser191\".\"id\"))  Left JOIN {OrderMain} \"enordermain109\" ON (\"enorderapproval33\".\"orderid\" = \"enordermain109\".\"id\")) ");
whereBuilder.Append(" WHERE (");
if ((qpusOrderApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enorderapprovallevel32\".\"assignedto\" = @qpusOrderApprovalLevel_AssignedTo) AND (\"enorderapprovallevel32\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
sqlCountCmd.CreateParameterWithoutReplacements("@qpusOrderApprovalLevel_AssignedTo", DbType.String, qpusOrderApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enorderapprovallevel32\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" OR (");
if (qpenOrderApprovalLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enorderapprovallevel32\".\"entraroleid\" = @qpenOrderApprovalLevel_EntraRoleId) AND (\"enorderapprovallevel32\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpenOrderApprovalLevel_EntraRoleId", DbType.Int64, qpenOrderApprovalLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enorderapprovallevel32\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpreOrderMain_DivisionId != 0) {
whereBuilder.Append("((\"enordermain109\".\"divisionid\" = @qpreOrderMain_DivisionId) AND (\"enordermain109\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpreOrderMain_DivisionId", DbType.Int64, qpreOrderMain_DivisionId);
} else {
whereBuilder.Append("(\"enordermain109\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(")) AND ");
if (qpteOrderNumberFilter != "" && qpteOrderNumberFilter != "") {
whereBuilder.Append("(caseaccent_normalize(\"enordermain109\".\"ordernumber\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderNumberFilter) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderNumberFilter", DbType.String, qpteOrderNumberFilter);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderNumberFilter", DbType.String, qpteOrderNumberFilter);
}
if (qporOrderMain_OrderStatusId != BuiltInFunction.NullIdentifier()) {
if (qporOrderMain_OrderStatusId != 0) {
whereBuilder.Append("((\"enordermain109\".\"orderstatusid\" = @qporOrderMain_OrderStatusId) AND (\"enordermain109\".\"orderstatusid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_OrderStatusId", DbType.Int32, qporOrderMain_OrderStatusId);
sqlCountCmd.CreateParameterWithoutReplacements("@qporOrderMain_OrderStatusId", DbType.Int32, qporOrderMain_OrderStatusId);
} else {
whereBuilder.Append("(\"enordermain109\".\"orderstatusid\" IS NULL)");
}
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "User", "OrderApproval", "OrderApprovalLevel", "EntraRole", "OrderMain" }, new string[] { "ENUser191", "ENOrderApproval33", "ENOrderApprovalLevel32", "ENEntraRole65", "ENOrderMain109" }, new System.Collections.Generic.Dictionary<string, string>[] { ENUserEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enorderapprovallevel32\".\"id\" DESC ");
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_6a0d508a138cc1e49e6d938f0b4069dd outParamList = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsByAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_6a0d508a138cc1e49e6d938f0b4069dd _tmp = new RL_6a0d508a138cc1e49e6d938f0b4069dd();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelsByAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_6a0d508a138cc1e49e6d938f0b4069dd)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query z_Hotfix.HotfixOrderApprover.GetOrderApprovalLevelsByAssignedTo.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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


    public class lcvGetRequisitions : VarsBag {
public RL_50b9c4d0facccc9677374d1779eeeebb queryResGetRequisitionsList_outParamList = new RL_50b9c4d0facccc9677374d1779eeeebb();
public long queryResGetRequisitionsList_outParamCount = 0L;

public lcvGetRequisitions() {
}
}
public class lcoGetRequisitions : VarsBag {
public RL_f2eeb002682d9f8c7bb8a8168b7aea5f outParamList = new RL_f2eeb002682d9f8c7bb8a8168b7aea5f();

public lcoGetRequisitions() {
}
}
/// <summary>
/// Action <code>GetRequisitions</code> that represents the Service Studio action
///  <code>GetRequisitions</code> <p> Description: </p>
/// </summary>
public async Task<RL_f2eeb002682d9f8c7bb8a8168b7aea5f> DataActionGetRequisitions(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_f2eeb002682d9f8c7bb8a8168b7aea5f outParamList = default;
lcoGetRequisitions result = new lcoGetRequisitions();
lcvGetRequisitions localVars = new lcvGetRequisitions();
ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetRequisitions", "99ece280-b3ea-4b77-9d07-cafd63529978"))
using (activitySource.CreateScreenDataActionActivity("HotfixOrderApprover", "GetRequisitions")){
// Query QueryGetRequisitionsList
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsList_maxRecords = 999999999;
if (QueryGetRequisitionsList_maxRecords < 1) QueryGetRequisitionsList_maxRecords = 1;
int QueryGetRequisitionsList_startIndex = 0;(localVars.queryResGetRequisitionsList_outParamList,localVars.queryResGetRequisitionsList_outParamCount) = await FuncDataActionGetRequisitions.QueryGetRequisitionsList(requestContext,QueryGetRequisitionsList_maxRecords,QueryGetRequisitionsList_startIndex,IterationMultiplicity.Single,varLcUserOriginal,(await Functions.ActionGetUserRegionId(requestContext,varLcUserOriginal,cancellationToken)),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,true,varLcGetUserApplicationRolesAndMore.outParamAppRolesListText,varLcGetUserApplicationRolesAndMore.outParamTelcelDirectionsListText,varLcGetUserApplicationRolesAndMore.outParamIsCorporativoCxP,varLcGetUserApplicationRolesAndMore.outParamCorporativoRegionId,cancellationToken);

// List = GetRequisitionsList.List
result.outParamList=(await RL_f2eeb002682d9f8c7bb8a8168b7aea5f.ConvertAsync(localVars.queryResGetRequisitionsList_outParamList, new RL_f2eeb002682d9f8c7bb8a8168b7aea5f(), async (RC_26eb8683712e8211ad6c0f473a3d11d4 source, RC_4f0d40ef248987564be81ff3e7fa1eab target, CancellationToken cancellationToken) => {
target.ssENApplicationRole = source.ssENApplicationRole;
target.ssENApprovalStatus = source.ssENApprovalStatus;
target.ssENCompany = source.ssENCompany;
target.ssENCostCenterSAP = source.ssENCostCenterSAP;
target.ssENCurrency = source.ssENCurrency;
target.ssENProject_Asset_Service = source.ssENProject_Asset_Service;
target.ssENRegion = source.ssENRegion;
target.ssENRequisition = source.ssENRequisition;
target.ssENRequisitionApproval = source.ssENRequisitionApproval;
target.ssENRequisitionApprovalLevel = source.ssENRequisitionApprovalLevel;
target.ssENRequisitionStatus = source.ssENRequisitionStatus;
target.ssENSegmentAccGroup = source.ssENSegmentAccGroup;
target.ssENSegmentAccGroupTelcelDir = source.ssENSegmentAccGroupTelcelDir;
target.ssENSupplier = source.ssENSupplier;
target.ssENTelcelDirection = source.ssENTelcelDirection;
target.ssENUser_Applicant = source.ssENUser_Applicant;
target.ssENUser_UpdatedBy = source.ssENUser_UpdatedBy;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamList = result.outParamList;
} // inner-finally
RETURN_STATEMENT:
return outParamList;
}
public class lcvGetUserApplicationRolesAndMore : VarsBag {
public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public lcvGetUserApplicationRolesAndMore() {
}
}
public class lcoGetUserApplicationRolesAndMore : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRolesListText = "";

public bool outParamIsCorporativoCxP = false;

public bool outParamo_CanUploadInvoices = false;

public string outParamTelcelDirectionsListText = "";

public long outParamCorporativoRegionId = 0L;

public long outParamUserRegion = 0L;

public lcoGetUserApplicationRolesAndMore() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRolesAndMore</code> that represents the Service Studio action
///  <code>GetUserApplicationRolesAndMore</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,bool,bool,string,long,long)> DataActionGetUserApplicationRolesAndMore(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRolesListText = default;
bool outParamIsCorporativoCxP = default;
bool outParamo_CanUploadInvoices = default;
string outParamTelcelDirectionsListText = default;
long outParamCorporativoRegionId = default;
long outParamUserRegion = default;
lcoGetUserApplicationRolesAndMore result = new lcoGetUserApplicationRolesAndMore();
lcvGetUserApplicationRolesAndMore localVars = new lcvGetUserApplicationRolesAndMore();
ConectaProveedores_z_Hotfix_HotfixOrderApprover_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRolesAndMore", "f1e5d87d-eaf5-4e84-85aa-12876c64f347"))
using (activitySource.CreateScreenDataActionActivity("HotfixOrderApprover", "GetUserApplicationRolesAndMore")){
// o_CanUploadInvoices = False
result.outParamo_CanUploadInvoices=false;

// UserRegion = GetUserRegionId(UserOriginal)
result.outParamUserRegion=(await Functions.ActionGetUserRegionId(requestContext,varLcUserOriginal,cancellationToken));
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,varLcUserOriginal,cancellationToken);

// Query datasetGetUserApplicationRoleTempByConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempByConcepts_maxRecords = 0;
int datasetGetUserApplicationRoleTempByConcepts_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList,localVars.queryResGetUserApplicationRoleTempByConcepts_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetUserApplicationRoleTempByConcepts(requestContext,datasetGetUserApplicationRoleTempByConcepts_maxRecords,datasetGetUserApplicationRoleTempByConcepts_startIndex,IterationMultiplicity.Multiple,varLcUserOriginal,cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,result.outParamUserRolesList,(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_3d56036e64426be06ca36c503a3c39e0 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENApplicationRole.ssId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken)),cancellationToken);

// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
result.outParamIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
result.outParamCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Foreach UserRolesList
result.outParamUserRolesList.StartIteration();
try {while (!((result.outParamUserRolesList.Eof))) {
// AppRolesListText = AppRolesListText + "," + UserRolesList.Current.ApplicationRoleId
result.outParamAppRolesListText=((result.outParamAppRolesListText+",")+BuiltInFunction.LongIntegerToText(result.outParamUserRolesList.CurrentRec.ssApplicationRoleId));
result.outParamUserRolesList.Advance();
}

} finally {
result.outParamUserRolesList.EndIteration();
}

if((result.outParamIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncDataActionGetUserApplicationRolesAndMore.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,varLcUserOriginal,cancellationToken)),cancellationToken);

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

// LogMessage
await ExtendedActions.LogMessage(requestContext,result.outParamTelcelDirectionsListText,"TelcelDirectionIds",cancellationToken);

}

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRolesListText = result.outParamAppRolesListText;
outParamIsCorporativoCxP = result.outParamIsCorporativoCxP;
outParamo_CanUploadInvoices = result.outParamo_CanUploadInvoices;
outParamTelcelDirectionsListText = result.outParamTelcelDirectionsListText;
outParamCorporativoRegionId = result.outParamCorporativoRegionId;
outParamUserRegion = result.outParamUserRegion;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRolesListText,outParamIsCorporativoCxP,outParamo_CanUploadInvoices,outParamTelcelDirectionsListText,outParamCorporativoRegionId,outParamUserRegion);
}


    public static class FuncDataActionGetRequisitions {

private static async Task<RC_26eb8683712e8211ad6c0f473a3d11d4> QueryGetRequisitionsListReadDbAsync(RC_26eb8683712e8211ad6c0f473a3d11d4 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENRequisition.Read(r, ref index);
rec.ssENRequisitionApproval.Read(r, ref index);
rec.ssENRequisitionApprovalLevel.Read(r, ref index);
rec.ssENApprovalStatus.Read(r, ref index);
rec.ssENApplicationRole.Read(r, ref index);
rec.ssENRequisitionStatus.Read(r, ref index);
rec.ssENUser_Applicant.Read(r, ref index);
rec.ssENCompany.Read(r, ref index);
rec.ssENUser_UpdatedBy.Read(r, ref index);
rec.ssENProject_Asset_Service.Read(r, ref index);
rec.ssENSupplier.Read(r, ref index);
rec.ssENRegion.Read(r, ref index);
rec.ssENCurrency.Read(r, ref index);
rec.ssENCostCenterSAP.Read(r, ref index);
rec.ssENTelcelDirection.Read(r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read(r, ref index);
rec.ssENSegmentAccGroup.Read(r, ref index);
rec.ssSTDontShowAction.Read(r, ref index);
rec.ssSTIsUserFromThisRegion.Read(r, ref index);
return rec;
}
// Query Function "GetRequisitionsList" tgqF+zchDE+uilwMca7QIA of Action "GetRequisitions"
public static async Task<(RL_50b9c4d0facccc9677374d1779eeeebb,long)> QueryGetRequisitionsList(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusGetUserId,long qpreGetUserRegionId,int qpreRequisitionStatusDataCapture,int qpapApprovalStatusPending,bool qpboIsSegmentationCorporativo,string qpteGetUserApplicationRolesAndMoreAppRoleListText,string qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,bool qpboGetUserApplicationRolesAndMoreIsCorporativoCxP,long qpreGetUserApplicationRolesAndMoreCorporativoRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("z_Hotfix.HotfixOrderApprover.GetRequisitions.GetRequisitionsList", "fb850ab6-2137-4f0c-ae8a-5c0c71aed020");
using var queryActivity = activitySource.CreateSqlQueryActivity("z_Hotfix.HotfixOrderApprover.GetRequisitions.GetRequisitionsList", "fb850ab6-2137-4f0c-ae8a-5c0c71aed020", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Single
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreAppRoleListText", DbType.String, qpteGetUserApplicationRolesAndMoreAppRoleListText);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpapApprovalStatusPending", DbType.Int32, qpapApprovalStatusPending);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboGetUserApplicationRolesAndMoreIsCorporativoCxP", DbType.Boolean, qpboGetUserApplicationRolesAndMoreIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList", DbType.String, qpteGetUserApplicationRolesAndMoreTelcelDirectionsList);
sqlCmd.CreateParameter("@qpreGetUserApplicationRolesAndMoreCorporativoRegionId", DbType.Int64, qpreGetUserApplicationRolesAndMoreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "SELECT  \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"counter\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"maxdatefinishcapture\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetservice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectdescription\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"frequencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"issustainability\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"sustainabilityid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluecategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"businessvaluesubcategoryid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"totalamount\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"distributionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscontractpending\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasdeposit\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasinsurance\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasadvancepayment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingservicetypeid_depr\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"servicedescription_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"invoiceusageid_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"serviceformatid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"retentionrate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"negotiatedexchangerate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentmethodid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymenttermsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isautomaticaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"createdbyapplicationrole\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"dateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hascontractfileuploaded\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasupdateddateofcommitment\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"submittedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isdonation\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"advwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"wasadvwithoutinvoice\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"isadvanced\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"documenttypeid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"iscreatedbyanassistente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"hasmultiupload\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingdate\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentoptionsid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"paymentwaysid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"buydocposition\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"aprovalprocessid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"processtypecode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"approvalprocessversion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"currentlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"maxlevel\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"startedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"finishedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"hasstartedaccounting\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrajobtitle\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"departmentid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"managementid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"subdirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entraroleid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"entrausername\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"needscontract\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_deprec\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isstartaccounting\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledon_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approveasareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"ismandatory\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"isreassigned\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"issubstitutefor\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscya\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"iscyaapproval\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isreq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"isinv\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareausuaria\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"isareacxp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"canbulkapprovefolios\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"label\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"class\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"order\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"is_active\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"labeles\"") + ", \nUser_Applicant.*, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"externalid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"rfc\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"postalcode\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"cyaimport\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"fspuse\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"updatedby\"") + ", \nUpdatedBy.*, \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"description\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"isothers\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"tratamiento\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"number\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"conceptobusq_1_2\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"calle_numero\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"distrito\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"codigopostal_pobl_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"pais\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"region_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"idioma\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"telefono\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"extension\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"fax\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"cliente\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"soc_glasociada\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"clavedegrupo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"n_ident_fis_1\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"personafisica\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"ramo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"grupodeporte\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"email\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"regionid\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"commissionregion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfsp\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"isfcp\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"symbol\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"minorunitdecimals\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"regionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"companyid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"soc_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"div_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"area\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"cebe\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"denominacion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"descripcion\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"responsable\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ceco\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprim_reales_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_reales_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosreales_ind_debloqueo\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"actualiz_comprom__ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costesprimariosplan_ind_debl\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"costessecund_plan_ind_debloq\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ingresosplan_ind_debloqueo_\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"autor\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"updatedby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"isactive\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"name\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"updatedby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"createdby\"") + ", \n " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"groupname\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"isactive\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"createdby\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedon\"") + ", " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"updatedby\"") + ", \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " IS NULL \n    OR \n    ( \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n            AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " <> @qpusGetUserId \n        ) \n        OR \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n            AND STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) = 0 \n        ) \n    ) \n) AS DontShowAction, \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n    OR \n    ( \n         " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " IS NOT NULL \n    ) \n) AS IsUserFromThisRegion \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapApprovalStatusPending \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteGetUserApplicationRolesAndMoreAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \nWHERE \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 0 \n            OR @qpteGetUserApplicationRolesAndMoreTelcelDirectionsList = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n                AND STRPOS(@qpteGetUserApplicationRolesAndMoreTelcelDirectionsList,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreGetUserApplicationRolesAndMoreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n         \n        AND \n \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboGetUserApplicationRolesAndMoreIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n)";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_50b9c4d0facccc9677374d1779eeeebb outParamList = new RL_50b9c4d0facccc9677374d1779eeeebb();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[19];
opt[0] = new BitArray(new bool[] {false, false, false, false, false});
opt[1] = new BitArray(new bool[] {false, false, false, false, false});
opt[2] = new BitArray(new bool[] {false, false, false, false, false});
opt[3] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[4] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[5] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[6] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false});
opt[7] = new BitArray(new bool[] {false, false, false, false, false, false});
opt[8] = new BitArray(new bool[] {false});
opt[9] = new BitArray(new bool[] {false});
opt[10] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[11] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false});
opt[12] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[13] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false});
opt[14] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[15] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[16] = new BitArray(new bool[] {false, false, false, false, false, false, false});
opt[17] = new BitArray(new bool[] {false, false, false, false, false});
opt[18] = new BitArray(new bool[] {false, false, false, false, false, false, false, false, false, false, false, false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_50b9c4d0facccc9677374d1779eeeebb _tmp = new RL_50b9c4d0facccc9677374d1779eeeebb();
_tmp.AlternateReadDbMethodAsync = QueryGetRequisitionsListReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetRequisitions.GetRequisitionsList.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_50b9c4d0facccc9677374d1779eeeebb)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsList in GetRequisitions in HotfixOrderApprover in z_Hotfix in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  User_Applicant.*,  {Company}.*,  UpdatedBy.*,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR      (          {Requisition}.[AccountingRegionId] = @GetUserRegionId          A ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in HotfixOrderApprover in z_Hotfix in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  User_Applicant.*,  {Company}.*,  UpdatedBy.*,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR      (          {Requisition}.[AccountingRegionId] = @GetUserRegionId          A ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsList in GetRequisitions in HotfixOrderApprover in z_Hotfix in ConectaProveedores (SELECT   {Requisition}.*,  {RequisitionApproval}.*,  {RequisitionApprovalLevel}.*,  {ApprovalStatus}.*,  {ApplicationRole}.*,  {RequisitionStatus}.*,  User_Applicant.*,  {Company}.*,  UpdatedBy.*,  {Project_Asset_Service}.*,  {Supplier}.*,  {Region}.*,  {Currency}.*,  {CostCenterSAP}.*,  {TelcelDirection}.*,  {SegmentAccGroupTelcelDir}.*,  {SegmentAccGroup}.*,  (      {RequisitionApprovalLevel}.[ApprovalStatusId] IS NULL      OR      (          (              {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL              AND {RequisitionApprovalLevel}.[AssignedTo] <> @GetUserId          )          OR          (              {RequisitionApprovalLevel}.[AssignedTo] IS NULL              AND STRPOS(@GetUserApplicationRolesAndMoreAppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) = 0          )      )  ) AS DontShowAction,  (      {Requisition}.[RegionId] = @GetUserRegionId      OR      (          {Requisition}.[AccountingRegionId] = @GetUserRegionId          A ...): " + aqExcep.Message));
}
}
}
}
public static class FuncDataActionGetUserApplicationRolesAndMore {

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
// Query Function "GetRoleConcept" 6d9FKg80h0Wfp4JQUEHMbg of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetRoleConcept", "2a45dfe9-340f-4587-9fa7-82505041cc6e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetRoleConcept", "2a45dfe9-340f-4587-9fa7-82505041cc6e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/DataActions.fdjl8fXqhE6FqhKHbGTzRw/NodesNotShownInESpaceTree.6d9FKg80h0Wfp4JQUEHMbg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole69\".\"code\" o1, \"enapplicationrole69\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole69\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion148\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept25\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal121\" Inner JOIN {User} \"enuser192\" ON (\"enuser_extended_internal121\".\"id\" = \"enuser192\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole66\" ON (\"enuser_extended_internal121\".\"jobtitle\" = \"enentrarole66\".\"rolename\"))  Left JOIN {Region} \"enregion148\" ON (\"enuser_extended_internal121\".\"regionid\" = \"enregion148\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept25\" ON (\"enentrarole66\".\"id\" = \"enroleconcept25\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole69\" ON (\"enroleconcept25\".\"applicationroleid\" = \"enapplicationrole69\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser192\".\"id\" = @qpusUser_Id) AND (\"enuser192\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser192\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept25\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetRoleConcept.List", cancellationToken: cancellationToken);
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

private static async Task<RC_dbac6e35b37e102dd601262a956066d2> datasetGetSegmentAccGroupTelcelDirectionsByDepartmentReadDbAsync(RC_dbac6e35b37e102dd601262a956066d2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENSegmentAccGroup.Read( r, ref index);
rec.ssENSegmentAccGroupTelcelDir.Read( r, ref index);
return rec;
}
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" HJ64W9S8wE+vmVUDSpHJrg of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "5bb89e1c-bcd4-4fc0-af99-55034a91c9ae");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment", "5bb89e1c-bcd4-4fc0-af99-55034a91c9ae", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/DataActions.fdjl8fXqhE6FqhKHbGTzRw/NodesNotShownInESpaceTree.HJ64W9S8wE+vmVUDSpHJrg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir10\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup10\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir10\" ON (\"ensegmentaccgroup10\".\"id\" = \"ensegmentaccgrouptelceldir10\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup10\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup10\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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

private static async Task<RC_3d56036e64426be06ca36c503a3c39e0> datasetGetUserApplicationRoleTempByConceptsReadDbAsync(RC_3d56036e64426be06ca36c503a3c39e0 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENUserApplicationRoleTemp.Read( r, ref index);
rec.ssENUserApplicationRoleTempByConcept.Read( r, ref index);
return rec;
}
// Query Function "GetUserApplicationRoleTempByConcepts" 7cVznfnrCUKx_mdIgpN5og of Action "GetUserApplicationRolesAndMore"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "9d73c5ed-ebf9-4209-b1fe-6748829379a2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts", "9d73c5ed-ebf9-4209-b1fe-6748829379a2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.EDb7WBWIEEiXMM8Aei_lQg/NodesShownInESpaceTree.1p4vj8ZnrE6M1+qa4gpxDw/DataActions.fdjl8fXqhE6FqhKHbGTzRw/NodesNotShownInESpaceTree.7cVznfnrCUKx_mdIgpN5og, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole70\".\"id\" o0, \"enapplicationrole70\".\"code\" o1, \"enapplicationrole70\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept8\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp12\" ON (\"enuserapplicationroletempbyconcept8\".\"userapplicationroletempid\" = \"enuserapplicationroletemp12\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole70\" ON (\"enuserapplicationroletempbyconcept8\".\"applicationroleid\" = \"enapplicationrole70\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp12\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp12\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp12\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp12\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept8\".\"conceptid\" = ");
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
RL_b9107f331631f30bcef7fe9d900d99ae outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, false, false, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_b9107f331631f30bcef7fe9d900d99ae _tmp = new RL_b9107f331631f30bcef7fe9d900d99ae();
_tmp.AlternateReadDbMethodAsync = datasetGetUserApplicationRoleTempByConceptsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query z_Hotfix.HotfixOrderApprover.GetUserApplicationRolesAndMore.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_b9107f331631f30bcef7fe9d900d99ae)_tmp;
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
