namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetInvoiceCountDaily : VarsBag {
public string inParami_UserId;
/// <summary>
/// Variable <code>IsCorporativoCxP</code> that represents the Service Studio Boolean
///  <code>IsCorporativoCxP</code> <p>Description: </p>
/// </summary>
public bool varLcIsCorporativoCxP = false;

/// <summary>
/// Variable <code>AppRoleListText</code> that represents the Service Studio Text
///  <code>AppRoleListText</code> <p>Description: ListText</p>
/// </summary>
public string varLcAppRoleListText = "";

/// <summary>
/// Variable <code>UserRolesList</code> that represents the Service Studio UserRoleCodeList
///  <code>UserRolesList</code> <p>Description: List of User Roles</p>
/// </summary>
public RL_97ac86b141c7934fd96d3cf71793066e varLcUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

/// <summary>
/// Variable <code>TelcelDirectionsListText</code> that represents the Service Studio Text
///  <code>TelcelDirectionsListText</code> <p>Description: ListText</p>
/// </summary>
public string varLcTelcelDirectionsListText = "";

/// <summary>
/// Variable <code>CorporativoRegionId</code> that represents the Service Studio RegionIdentifier
///  <code>CorporativoRegionId</code> <p>Description: Region Identifier</p>
/// </summary>
public long varLcCorporativoRegionId = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_768cce162e7c81def144e505024952d1 queryResGetInvoices_outParamList = new RL_768cce162e7c81def144e505024952d1();
public long queryResGetInvoices_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public lcvGetInvoiceCountDaily(string inParami_UserId) {
this.inParami_UserId = inParami_UserId;
}
}
public class lcoGetInvoiceCountDaily : VarsBag {
public RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = new RL_95e11a982864fe07082eb4aea44bdce2();

public lcoGetInvoiceCountDaily() {
}
}
/// <summary>
/// Action <code>GetInvoiceCountDaily</code> that represents the Service Studio action
///  <code>GetInvoiceCountDaily</code> <p> Description: </p>
/// </summary>
public static async Task<RL_95e11a982864fe07082eb4aea44bdce2> ActionGetInvoiceCountDaily(IRequestContext requestContext,string inParami_UserId,CancellationToken cancellationToken) {
RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = default;
lcoGetInvoiceCountDaily result = new lcoGetInvoiceCountDaily();
lcvGetInvoiceCountDaily localVars = new lcvGetInvoiceCountDaily(inParami_UserId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetInvoiceCountDaily", "fa1bcb21-4b48-4532-992a-d3a178ee1e7c"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetInvoiceCountDaily", "fa1bcb21-4b48-4532-992a-d3a178ee1e7c", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionGetInvoiceCountDaily.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,localVars.inParami_UserId,cancellationToken);

// Query datasetGetUserApplicationRoleTempByConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempByConcepts_maxRecords = 0;
int datasetGetUserApplicationRoleTempByConcepts_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList,localVars.queryResGetUserApplicationRoleTempByConcepts_outParamCount) = await FuncActionGetInvoiceCountDaily.datasetGetUserApplicationRoleTempByConcepts(requestContext,datasetGetUserApplicationRoleTempByConcepts_maxRecords,datasetGetUserApplicationRoleTempByConcepts_startIndex,IterationMultiplicity.Multiple,localVars.inParami_UserId,cancellationToken);

// UserRolesList = GetRoleConcept.List
localVars.varLcUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// ListAppendAll
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcUserRolesList,(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_3d56036e64426be06ca36c503a3c39e0 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENApplicationRole.ssId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken)),cancellationToken);

// FindIsCorporativoCxP
localVars.resFindIsCorporativoCxP_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => ((p.ssENRegion.ssCommissionRegion=="R0")&&p.ssENApplicationRole.ssIsAreaCxP),cancellationToken);

// GetUserRegionId
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,localVars.inParami_UserId,cancellationToken);

// IsCorporativoCxP = FindIsCorporativoCxP.Position <> -1
localVars.varLcIsCorporativoCxP=(localVars.resFindIsCorporativoCxP_outParamPosition!=(-1));

// CorporativoRegionId = GetMR00RegionId()
localVars.varLcCorporativoRegionId=(await Functions.ActionGetMR00RegionId(requestContext,cancellationToken));
// Foreach UserRolesList
localVars.varLcUserRolesList.StartIteration();
try {while (!((localVars.varLcUserRolesList.Eof))) {
// AppRoleListText = AppRoleListText + "," + UserRolesList.Current.ApplicationRoleId
localVars.varLcAppRoleListText=((localVars.varLcAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.varLcUserRolesList.CurrentRec.ssApplicationRoleId));
localVars.varLcUserRolesList.Advance();
}

} finally {
localVars.varLcUserRolesList.EndIteration();
}

if((localVars.varLcIsCorporativoCxP)) {
// Query datasetGetSegmentAccGroupTelcelDirectionsByDepartment
cancellationToken.ThrowIfCancellationRequested();
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords = 0;
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncActionGetInvoiceCountDaily.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

// Foreach GetSegmentAccGroupTelcelDirectionsByDepartment.List
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.StartIteration();
try {while (!((localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Eof))) {
// TelcelDirectionsListText = TelcelDirectionsListText + "," + GetSegmentAccGroupTelcelDirectionsByDepartment.List.Current.SegmentAccGroupTelcelDir.TelcelDirectionId + ","
localVars.varLcTelcelDirectionsListText=(((localVars.varLcTelcelDirectionsListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.CurrentRec.ssENSegmentAccGroupTelcelDir.ssTelcelDirectionId))+",");
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.Advance();
}

} finally {
localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList.EndIteration();
}

}

// Query datasetGetInvoices
cancellationToken.ThrowIfCancellationRequested();
int datasetGetInvoices_maxRecords = 0;
int datasetGetInvoices_startIndex = 0;(localVars.queryResGetInvoices_outParamList,localVars.queryResGetInvoices_outParamCount) = await FuncActionGetInvoiceCountDaily.datasetGetInvoices(requestContext,datasetGetInvoices_maxRecords,datasetGetInvoices_startIndex,IterationMultiplicity.Single,localVars.varLcAppRoleListText,localVars.varLcCorporativoRegionId,BuiltInFunction.GetUserId (),localVars.resGetUserRegionId.outParamo_RegionId,(await Functions.ActionGetUserRegionId(requestContext,"",cancellationToken)),localVars.inParami_UserId,localVars.varLcIsCorporativoCxP,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.varLcTelcelDirectionsListText,cancellationToken);

// HomepageKPI = GetInvoices.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetInvoices_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_95c68a20cdfa1714694774ffd45b1c33 source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
target.ssCount = BuiltInFunction.LongIntegerToInteger (source.ssCount);
target.ssLabel = source.ssLabelES;
return target;
}, cancellationToken));
} //close CreateActionActivity using block
} // try

finally {
outParamHomepageKPI = result.outParamHomepageKPI;
} // inner-finally
RETURN_STATEMENT:
return outParamHomepageKPI;
}

public static class FuncActionGetInvoiceCountDaily {

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
// Query Function "GetRoleConcept" pfpPCA0stEm5iOaEb9pWZA of Action "GetInvoiceCountDaily"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvoiceCountDaily.GetRoleConcept", "084ffaa5-2c0d-49b4-b988-e6846fda5664");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvoiceCountDaily.GetRoleConcept", "084ffaa5-2c0d-49b4-b988-e6846fda5664", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Icsb+khLMkWZKtOheO4efA/NodesNotShownInESpaceTree.pfpPCA0stEm5iOaEb9pWZA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole36\".\"code\" o1, \"enapplicationrole36\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole36\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion63\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept13\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal85\" Inner JOIN {User} \"enuser141\" ON (\"enuser_extended_internal85\".\"id\" = \"enuser141\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole41\" ON (\"enuser_extended_internal85\".\"jobtitle\" = \"enentrarole41\".\"rolename\"))  Left JOIN {Region} \"enregion63\" ON (\"enuser_extended_internal85\".\"regionid\" = \"enregion63\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept13\" ON (\"enentrarole41\".\"id\" = \"enroleconcept13\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole36\" ON (\"enroleconcept13\".\"applicationroleid\" = \"enapplicationrole36\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser141\".\"id\" = @qpusUser_Id) AND (\"enuser141\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser141\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept13\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvoiceCountDaily.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvoiceCountDaily.GetRoleConcept.List", cancellationToken: cancellationToken);
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

private static async Task<RC_95c68a20cdfa1714694774ffd45b1c33> datasetGetInvoicesReadDbAsync(RC_95c68a20cdfa1714694774ffd45b1c33 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssLabelES = r.ReadText(index++, "LabelESCountRecord.LabelES", "");
rec.ssCount = r.ReadLongInteger(index++, "LabelESCountRecord.Count", 0L);
return rec;
}
// Query Function "GetInvoices" zKf3cEb8UEelFCgo1FzugA of Action "GetInvoiceCountDaily"
public static async Task<(RL_768cce162e7c81def144e505024952d1,long)> datasetGetInvoices(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRoleListText,long qpreCorporativoRegionId,string qpusGetUserId,long qpreo_RegionId,long qpreRequisition_RegionId,string qpusInvoiceApprovalLevel_AssignedTo,bool qpboIsCorporativoCxP,bool qpboIsSegmentationCorporativo,string qpteTelcelDirectionsListText,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvoiceCountDaily.GetInvoices", "70f7a7cc-fc46-4750-a514-2828d45cee80");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvoiceCountDaily.GetInvoices", "70f7a7cc-fc46-4750-a514-2828d45cee80", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Icsb+khLMkWZKtOheO4efA/NodesNotShownInESpaceTree.zKf3cEb8UEelFCgo1FzugA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalstatus2\".\"labeles\" \"labeles\", Count(\"eninvoiceapproval24\".\"id\") \"count\"");
fromBuilder.Append(" FROM (((({Invoice} \"eninvoice76\" Left JOIN {InvoiceApproval} \"eninvoiceapproval24\" ON (\"eninvoice76\".\"id\" = \"eninvoiceapproval24\".\"invoiceid\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel25\" ON ((\"eninvoiceapprovallevel25\".\"invoiceapprovalid\" = \"eninvoiceapproval24\".\"id\") AND ((\"eninvoiceapprovallevel25\".\"approvalstatusid\" <> ");
fromBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId);
fromBuilder.Append(") AND (((((CASE WHEN (\"eninvoiceapprovallevel25\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel25\".\"assignedto\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel25\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel25\".\"assignedto\" IS NULL)");
}
fromBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN (((CASE WHEN char_length(caseaccent_normalize(cast(\"eninvoiceapprovallevel25\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"eninvoiceapprovallevel25\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) THEN 1 ELSE 0 END) END) = 1) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel25\".\"approvedby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel25\".\"approvedby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel25\".\"approvedby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel25\".\"requesttomodifyby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel25\".\"requesttomodifyby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel25\".\"requesttomodifyby\" IS NULL)");
}
fromBuilder.Append(") OR ");
if ((qpusGetUserId.Trim()!="")) {
fromBuilder.Append("((\"eninvoiceapprovallevel25\".\"canceledby\" = @qpusGetUserId) AND (\"eninvoiceapprovallevel25\".\"canceledby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusGetUserId", DbType.String, qpusGetUserId);
} else {
fromBuilder.Append("(\"eninvoiceapprovallevel25\".\"canceledby\" IS NULL)");
}
fromBuilder.Append("))))  Inner JOIN {ApprovalStatus} \"enapprovalstatus2\" ON (\"eninvoiceapprovallevel25\".\"approvalstatusid\" = \"enapprovalstatus2\".\"id\"))  Left JOIN {Requisition} \"enrequisition72\" ON (\"eninvoice76\".\"requisitionid\" = \"enrequisition72\".\"id\")) ");
whereBuilder.Append(" WHERE (\"eninvoice76\".\"invoicestatusid\" <> ");
whereBuilder.Append((ENInvoiceStatusEntity.GetRecordByKey(ObjectKey.Parse("Wo+LRDF_n0O7Fo8ikSEsSA"))).ssId);
whereBuilder.Append(") AND (");
if (qpreo_RegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"regionid\" = @qpreo_RegionId) AND (\"enrequisition72\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreo_RegionId", DbType.Int64, qpreo_RegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreo_RegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"accountingregionid\" = @qpreo_RegionId) AND (\"enrequisition72\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreo_RegionId", DbType.Int64, qpreo_RegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND ((CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpboIsSegmentationCorporativo = 1) THEN (CASE WHEN (@qpboIsCorporativoCxP = 1) THEN (CASE WHEN (@qpteTelcelDirectionsListText = '') THEN 1 ELSE (CASE WHEN ((((");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameterWithoutReplacements("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"regionid\" = @qpreCorporativoRegionId) AND (\"enrequisition72\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" OR ");
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"accountingregionid\" = @qpreCorporativoRegionId) AND (\"enrequisition72\".\"accountingregionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"accountingregionid\" IS NULL)");
}
whereBuilder.Append(") AND (((CASE WHEN char_length(caseaccent_normalize(((',' || cast(\"enrequisition72\".\"telceldirectionid\" as text)) || ',') collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(((',' || cast(\"enrequisition72\".\"telceldirectionid\" as text)) || ',') collate \"default\") in caseaccent_normalize(@qpteTelcelDirectionsListText collate \"default\"))-1) END)) <> (-1))) OR ");
sqlCmd.CreateParameterWithoutReplacements("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
if (qpreCorporativoRegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"regionid\" <> @qpreCorporativoRegionId) OR (\"enrequisition72\".\"regionid\" IS NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"regionid\" IS NOT NULL)");
}
whereBuilder.Append(") OR ");
if ((qpusInvoiceApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel25\".\"assignedto\" = @qpusInvoiceApprovalLevel_AssignedTo) AND (\"eninvoiceapprovallevel25\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusInvoiceApprovalLevel_AssignedTo", DbType.String, qpusInvoiceApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel25\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) ELSE 1 END) ELSE 1 END) ELSE (CASE WHEN ((");
if (qpreRequisition_RegionId != 0) {
whereBuilder.Append("((\"enrequisition72\".\"regionid\" = @qpreRequisition_RegionId) AND (\"enrequisition72\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRequisition_RegionId", DbType.Int64, qpreRequisition_RegionId);
} else {
whereBuilder.Append("(\"enrequisition72\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" AND (\"eninvoiceapprovallevel25\".\"id\" IS NOT NULL)) OR ");
if ((qpusInvoiceApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"eninvoiceapprovallevel25\".\"assignedto\" = @qpusInvoiceApprovalLevel_AssignedTo) AND (\"eninvoiceapprovallevel25\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusInvoiceApprovalLevel_AssignedTo", DbType.String, qpusInvoiceApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"eninvoiceapprovallevel25\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(") THEN 1 ELSE 0 END) END) = 1)");
groupByBuilder.Append(" GROUP BY \"enapprovalstatus2\".\"labeles\"");
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
RL_768cce162e7c81def144e505024952d1 outParamList = new RL_768cce162e7c81def144e505024952d1();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[0];
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvoiceCountDaily.GetInvoices.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_768cce162e7c81def144e505024952d1 _tmp = new RL_768cce162e7c81def144e505024952d1();
_tmp.AlternateReadDbMethodAsync = datasetGetInvoicesReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvoiceCountDaily.GetInvoices.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_768cce162e7c81def144e505024952d1)_tmp;
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
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" qHKq2i+zCk6qlx_jsig8lw of Action "GetInvoiceCountDaily"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvoiceCountDaily.GetSegmentAccGroupTelcelDirectionsByDepartment", "daaa72a8-b32f-4e0a-aa97-1fe3b2283c97");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvoiceCountDaily.GetSegmentAccGroupTelcelDirectionsByDepartment", "daaa72a8-b32f-4e0a-aa97-1fe3b2283c97", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Icsb+khLMkWZKtOheO4efA/NodesNotShownInESpaceTree.qHKq2i+zCk6qlx_jsig8lw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir3\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup3\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir3\" ON (\"ensegmentaccgroup3\".\"id\" = \"ensegmentaccgrouptelceldir3\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup3\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup3\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvoiceCountDaily.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvoiceCountDaily.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
// Query Function "GetUserApplicationRoleTempByConcepts" 1aiy5z1RB02pVemJ+AspAg of Action "GetInvoiceCountDaily"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetInvoiceCountDaily.GetUserApplicationRoleTempByConcepts", "e7b2a8d5-513d-4d07-a955-e989f80b2902");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetInvoiceCountDaily.GetUserApplicationRoleTempByConcepts", "e7b2a8d5-513d-4d07-a955-e989f80b2902", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.Icsb+khLMkWZKtOheO4efA/NodesNotShownInESpaceTree.1aiy5z1RB02pVemJ+AspAg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole37\".\"id\" o0, \"enapplicationrole37\".\"code\" o1, \"enapplicationrole37\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept4\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp6\" ON (\"enuserapplicationroletempbyconcept4\".\"userapplicationroletempid\" = \"enuserapplicationroletemp6\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole37\" ON (\"enuserapplicationroletempbyconcept4\".\"applicationroleid\" = \"enapplicationrole37\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp6\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp6\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp6\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp6\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept4\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetInvoiceCountDaily.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetInvoiceCountDaily.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
