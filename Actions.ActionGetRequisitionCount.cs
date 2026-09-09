namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetRequisitionCount : VarsBag {
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

public Actions.lcoGetUserRegionId resGetUserRegionId =  new Actions.lcoGetUserRegionId();
public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetRequisitionsCount_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetRequisitionsCount_outParamCount = 0L;

public int resFindIsCorporativoCxP_outParamPosition = 0;

public RL_0b9ed344d44b60e0112a22c99132ee6b queryResGetRequisitionsCount2_outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
public long queryResGetRequisitionsCount2_outParamCount = 0L;

public RL_b9107f331631f30bcef7fe9d900d99ae queryResGetUserApplicationRoleTempByConcepts_outParamList = new RL_b9107f331631f30bcef7fe9d900d99ae();
public long queryResGetUserApplicationRoleTempByConcepts_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public RL_4b6f9359ce9887bc6f37c96ecf62266d queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList = new RL_4b6f9359ce9887bc6f37c96ecf62266d();
public long queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount = 0L;

public lcvGetRequisitionCount() {
}
}
public class lcoGetRequisitionCount : VarsBag {
public RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = new RL_95e11a982864fe07082eb4aea44bdce2();

public lcoGetRequisitionCount() {
}
}
/// <summary>
/// Action <code>GetRequisitionCount</code> that represents the Service Studio action
///  <code>GetRequisitionCount</code> <p> Description: </p>
/// </summary>
public static async Task<RL_95e11a982864fe07082eb4aea44bdce2> ActionGetRequisitionCount(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_95e11a982864fe07082eb4aea44bdce2 outParamHomepageKPI = default;
lcoGetRequisitionCount result = new lcoGetRequisitionCount();
lcvGetRequisitionCount localVars = new lcvGetRequisitionCount();
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetRequisitionCount", "dba457a4-786f-4428-a030-c2f4fb50c892"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetRequisitionCount", "dba457a4-786f-4428-a030-c2f4fb50c892", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncActionGetRequisitionCount.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

// Query datasetGetUserApplicationRoleTempByConcepts
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempByConcepts_maxRecords = 0;
int datasetGetUserApplicationRoleTempByConcepts_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempByConcepts_outParamList,localVars.queryResGetUserApplicationRoleTempByConcepts_outParamCount) = await FuncActionGetRequisitionCount.datasetGetUserApplicationRoleTempByConcepts(requestContext,datasetGetUserApplicationRoleTempByConcepts_maxRecords,datasetGetUserApplicationRoleTempByConcepts_startIndex,IterationMultiplicity.Multiple,BuiltInFunction.GetUserId (),cancellationToken);

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
localVars.resGetUserRegionId.outParamo_RegionId = await Actions.ActionGetUserRegionId(requestContext,"",cancellationToken);

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
int datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex = 0;(localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamList,localVars.queryResGetSegmentAccGroupTelcelDirectionsByDepartment_outParamCount) = await FuncActionGetRequisitionCount.datasetGetSegmentAccGroupTelcelDirectionsByDepartment(requestContext,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_maxRecords,datasetGetSegmentAccGroupTelcelDirectionsByDepartment_startIndex,IterationMultiplicity.Single,(await Functions.ActionGetUserDepartmentName(requestContext,"",cancellationToken)),cancellationToken);

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

if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_Dashboard]))))) {
// Query QueryGetRequisitionsCount
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsCount_maxRecords = 0;
int QueryGetRequisitionsCount_startIndex = 0;(localVars.queryResGetRequisitionsCount_outParamList,localVars.queryResGetRequisitionsCount_outParamCount) = await FuncActionGetRequisitionCount.QueryGetRequisitionsCount(requestContext,QueryGetRequisitionsCount_maxRecords,QueryGetRequisitionsCount_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.varLcIsCorporativoCxP,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.varLcTelcelDirectionsListText,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId,localVars.varLcAppRoleListText,BuiltInFunction.GetUserId (),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,localVars.resGetUserRegionId.outParamo_RegionId,localVars.varLcCorporativoRegionId,cancellationToken);

// HomepageKPI = GetRequisitionsCount.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetRequisitionsCount_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
} else {
// Query QueryGetRequisitionsCount2
cancellationToken.ThrowIfCancellationRequested();
int QueryGetRequisitionsCount2_maxRecords = 0;
int QueryGetRequisitionsCount2_startIndex = 0;(localVars.queryResGetRequisitionsCount2_outParamList,localVars.queryResGetRequisitionsCount2_outParamCount) = await FuncActionGetRequisitionCount.QueryGetRequisitionsCount2(requestContext,QueryGetRequisitionsCount2_maxRecords,QueryGetRequisitionsCount2_startIndex,IterationMultiplicity.Multiple,(await Functions.ActionCheckUserSession(requestContext,cancellationToken)),localVars.varLcIsCorporativoCxP,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsSegmentationCorporativo]))),localVars.varLcTelcelDirectionsListText,(ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("fEmjvBqEH0eHrf5_YVeo0g"))).ssId,localVars.varLcAppRoleListText,BuiltInFunction.GetUserId (),(ENRequisitionStatusEntity.GetRecordByKey(ObjectKey.Parse("pBDtHOXH_kG10TWqeiPa0A"))).ssId,localVars.resGetUserRegionId.outParamo_RegionId,localVars.varLcCorporativoRegionId,cancellationToken);

// HomepageKPI = GetRequisitionsCount2.List
result.outParamHomepageKPI=(await RL_95e11a982864fe07082eb4aea44bdce2.ConvertAsync(localVars.queryResGetRequisitionsCount2_outParamList, new RL_95e11a982864fe07082eb4aea44bdce2(), async (RC_073e413c5402df3d82c2d65d0628594a source, ST_0c64d21ad7602c08489bb9a5fcfb0fe0Structure target, CancellationToken cancellationToken) => {
target = source;
return target;
}, cancellationToken));
}

} //close CreateActionActivity using block
} // try

finally {
outParamHomepageKPI = result.outParamHomepageKPI;
} // inner-finally
RETURN_STATEMENT:
return outParamHomepageKPI;
}

public static class FuncActionGetRequisitionCount {

// Query Function "GetRequisitionsCount" Pwm_UnnP_0+mk9GlC_X1IQ of Action "GetRequisitionCount"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetRequisitionsCount(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,bool qpboIsCorporativoCxP,bool qpboIsSegmentationCorporativo,string qpteTelcelDirectionsListText,int qpapNotApprovedStatusId,string qpteAppRoleListText,string qpusGetUserId,int qpreRequisitionStatusDataCapture,long qpreGetUserRegionId,long qpreCorporativoRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetRequisitionCount.GetRequisitionsCount", "52bf093f-cf79-4fff-a693-d1a50bf5f521");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetRequisitionCount.GetRequisitionsCount", "52bf093f-cf79-4fff-a693-d1a50bf5f521", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
sqlCmd.CreateParameter("@qpapNotApprovedStatusId", DbType.Int32, qpapNotApprovedStatusId);
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameter("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCmd.CreateParameter("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "SELECT  \n    COUNT(1) AS \"count\", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + " AS \"labeles\" \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " = @qpapNotApprovedStatusId \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nINNER JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nWHERE \n@qpboCheckUserSession = 1 \nAND \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n    OR \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n) \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboIsCorporativoCxP = 0 \n            OR @qpteTelcelDirectionsListText = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreCorporativoRegionId \n                AND STRPOS(@qpteTelcelDirectionsListText,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboIsCorporativoCxP = 1 \n        ) \n         \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n \nGROUP BY  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + "";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionCount.GetRequisitionsCount.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionCount.GetRequisitionsCount.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsCount in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  INNER JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  INNER JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] = @NotApprovedStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )          )       ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  INNER JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  INNER JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] = @NotApprovedStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )          )       ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  INNER JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  INNER JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] = @NotApprovedStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )          )       ...): " + aqExcep.Message));
}
}
}

// Query Function "GetRequisitionsCount2" QmHrersT5Eax46f563asJg of Action "GetRequisitionCount"
public static async Task<(RL_0b9ed344d44b60e0112a22c99132ee6b,long)> QueryGetRequisitionsCount2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,bool qpboCheckUserSession,bool qpboIsCorporativoCxP,bool qpboIsSegmentationCorporativo,string qpteTelcelDirectionsListText,int qpapPendingApprovalStatusId,string qpteAppRoleListText,string qpusGetUserId,int qpreRequisitionStatusDataCapture,long qpreGetUserRegionId,long qpreCorporativoRegionId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetRequisitionCount.GetRequisitionsCount2", "7aeb6142-13bb-46e4-b1e3-a7f9eb76ac26");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetRequisitionCount.GetRequisitionsCount2", "7aeb6142-13bb-46e4-b1e3-a7f9eb76ac26", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Multiple
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityApprovalStatus = AppUtils.Instance.RuntimeEntityReplace("ApprovalStatus");
string entityRequisition = AppUtils.Instance.RuntimeEntityReplace("Requisition");
string entityRequisitionApproval = AppUtils.Instance.RuntimeEntityReplace("RequisitionApproval");
string entityRequisitionApprovalLevel = AppUtils.Instance.RuntimeEntityReplace("RequisitionApprovalLevel");
string entityApplicationRole = AppUtils.Instance.RuntimeEntityReplace("ApplicationRole");
string entityRequisitionStatus = AppUtils.Instance.RuntimeEntityReplace("RequisitionStatus");
string entityUser = AppUtils.Instance.RuntimeEntityReplace("User");
string entityCompany = AppUtils.Instance.RuntimeEntityReplace("Company");
string entityProject_Asset_Service = AppUtils.Instance.RuntimeEntityReplace("Project_Asset_Service");
string entitySupplier = AppUtils.Instance.RuntimeEntityReplace("Supplier");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityTelcelDirection = AppUtils.Instance.RuntimeEntityReplace("TelcelDirection");
string entitySegmentAccGroupTelcelDir = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroupTelcelDir");
string entitySegmentAccGroup = AppUtils.Instance.RuntimeEntityReplace("SegmentAccGroup");
sqlCmd.CreateParameter("@qpapPendingApprovalStatusId", DbType.Int32, qpapPendingApprovalStatusId);
sqlCmd.CreateParameter("@qpusGetUserId", DbType.String, qpusGetUserId);
sqlCmd.CreateParameter("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameter("@qpboCheckUserSession", DbType.Boolean, qpboCheckUserSession);
sqlCmd.CreateParameter("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
sqlCmd.CreateParameter("@qpboIsSegmentationCorporativo", DbType.Boolean, qpboIsSegmentationCorporativo);
sqlCmd.CreateParameter("@qpboIsCorporativoCxP", DbType.Boolean, qpboIsCorporativoCxP);
sqlCmd.CreateParameter("@qpteTelcelDirectionsListText", DbType.String, qpteTelcelDirectionsListText);
sqlCmd.CreateParameter("@qpreCorporativoRegionId", DbType.Int64, qpreCorporativoRegionId);
sqlCmd.CreateParameter("@qpreRequisitionStatusDataCapture", DbType.Int32, qpreRequisitionStatusDataCapture);
string sql = "";
string advSql = "SELECT  \n    COUNT(1) AS \"count\", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + " AS \"labeles\" \n \nFROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"requisitionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " ON  \n( \n    SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \n    FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,"") + " \n    WHERE \n        " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requisitionapprovalid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApproval,".\"id\"") + " \n        AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " <> @qpapPendingApprovalStatusId \n        AND \n        ( \n            ( \n                " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NOT NULL \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            ) \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " IS NULL \n                AND \n                ( \n                    STRPOS(@qpteAppRoleListText, CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " AS TEXT)) <> 0 \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvedby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"requesttomodifyby\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"canceledby\"") + " = @qpusGetUserId \n        ) \n    ORDER BY  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"levelnumber\"") + " DESC \n    LIMIT 1 \n) =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"approvalstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApplicationRole,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"applicationroleid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionStatus,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " User_Applicant ON User_Applicant.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCompany,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"companyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityUser,"") + " UpdatedBy ON UpdatedBy.\"id\" =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"updatedby\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityProject_Asset_Service,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"projectassetserviceid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySupplier,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"supplierid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"currencyid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"costcenterid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"telceldirectionid\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityTelcelDirection,".\"id\"") + " \nLEFT JOIN  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,"") + " ON  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroup,".\"id\"") + " =  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entitySegmentAccGroupTelcelDir,".\"segmentaccgroupid\"") + " \n \nWHERE \n@qpboCheckUserSession = 1 \nAND \n( \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n    OR \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"accountingregionid\"") + " = @qpreGetUserRegionId \n) \nAND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + " IS NOT NULL \nAND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + " <> '' \nAND \n( \n    ( \n        ( \n            @qpboIsSegmentationCorporativo = 0 \n            OR @qpboIsCorporativoCxP = 0 \n            OR @qpteTelcelDirectionsListText = '' \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreCorporativoRegionId \n                AND STRPOS(@qpteTelcelDirectionsListText,',' || CAST( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"telceldirectionid\"") + " AS TEXT) || ',') <> 0 \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " <> @qpreCorporativoRegionId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n        ) \n         \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"requisitionstatusid\"") + " <> @qpreRequisitionStatusDataCapture \n                AND \n                ( \n                    @qpboIsCorporativoCxP = 1 \n                    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                ) \n            ) \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR @qpboIsCorporativoCxP = 1 \n        ) \n         \n        AND \n        ( \n             " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n            OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"assignedto\"") + " = @qpusGetUserId \n            OR \n            ( \n                 " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"regionid\"") + " = @qpreGetUserRegionId \n                AND  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisitionApprovalLevel,".\"id\"") + " IS NOT NULL \n            ) \n            OR @qpboIsCorporativoCxP = 1 \n        ) \n    ) \n    OR  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRequisition,".\"applicantid\"") + " = @qpusGetUserId \n) \n \nGROUP BY  \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"id\"") + ", \n     " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityApprovalStatus,".\"labeles\"") + "";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0b9ed344d44b60e0112a22c99132ee6b outParamList = new RL_0b9ed344d44b60e0112a22c99132ee6b();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionCount.GetRequisitionsCount2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0b9ed344d44b60e0112a22c99132ee6b _tmp = new RL_0b9ed344d44b60e0112a22c99132ee6b();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionCount.GetRequisitionsCount2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0b9ed344d44b60e0112a22c99132ee6b)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetRequisitionsCount2 in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @PendingApprovalStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )               ...): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount2 in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @PendingApprovalStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )               ...): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetRequisitionsCount2 in GetRequisitionCount in ConectaProveedores (SELECT       COUNT(1) AS [Count],      {ApprovalStatus}.[LabelES] AS [LabelES]    FROM {Requisition}  LEFT JOIN {RequisitionApproval} ON {RequisitionApproval}.[RequisitionId] = {Requisition}.[Id]  LEFT JOIN {RequisitionApprovalLevel} ON   (      SELECT {RequisitionApprovalLevel}.[Id]      FROM {RequisitionApprovalLevel}      WHERE         {RequisitionApprovalLevel}.[RequisitionApprovalId] = {RequisitionApproval}.[Id]          AND {RequisitionApprovalLevel}.[ApprovalStatusId] <> @PendingApprovalStatusId          AND          (              (                 {RequisitionApprovalLevel}.[AssignedTo] IS NOT NULL                  AND {RequisitionApprovalLevel}.[AssignedTo] = @GetUserId              )              OR              (                  {RequisitionApprovalLevel}.[AssignedTo] IS NULL                  AND                  (                      STRPOS(@AppRoleListText, CAST({RequisitionApprovalLevel}.[ApplicationRoleId] AS TEXT)) <> 0                  )              )               ...): " + aqExcep.Message));
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
// Query Function "GetUserApplicationRoleTempByConcepts" Af7BnDwDDEuXETTFwJwZiQ of Action "GetRequisitionCount"
public static async Task<(RL_b9107f331631f30bcef7fe9d900d99ae,long)> datasetGetUserApplicationRoleTempByConcepts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserApplicationRoleTemp_UserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRequisitionCount.GetUserApplicationRoleTempByConcepts", "9cc1fe01-033c-4b0c-9711-34c5c09c1989");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRequisitionCount.GetUserApplicationRoleTempByConcepts", "9cc1fe01-033c-4b0c-9711-34c5c09c1989", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pFek2294KESgMML0+1DIkg/NodesNotShownInESpaceTree.Af7BnDwDDEuXETTFwJwZiQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapplicationrole32\".\"id\" o0, \"enapplicationrole32\".\"code\" o1, \"enapplicationrole32\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM (({UserApplicationRoleTempByConcept} \"enuserapplicationroletempbyconcept3\" Left JOIN {UserApplicationRoleTemp} \"enuserapplicationroletemp5\" ON (\"enuserapplicationroletempbyconcept3\".\"userapplicationroletempid\" = \"enuserapplicationroletemp5\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole32\" ON (\"enuserapplicationroletempbyconcept3\".\"applicationroleid\" = \"enapplicationrole32\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUserApplicationRoleTemp_UserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp5\".\"userid\" = @qpusUserApplicationRoleTemp_UserId) AND (\"enuserapplicationroletemp5\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserApplicationRoleTemp_UserId", DbType.String, qpusUserApplicationRoleTemp_UserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp5\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp5\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(") AND (\"enuserapplicationroletempbyconcept3\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionCount.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionCount.GetUserApplicationRoleTempByConcepts.List", cancellationToken: cancellationToken);
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
// Query Function "GetRoleConcept" USJMsJXJUUauxliiaPyjjQ of Action "GetRequisitionCount"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRequisitionCount.GetRoleConcept", "b04c2251-c995-4651-aec6-58a268fca38d");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRequisitionCount.GetRoleConcept", "b04c2251-c995-4651-aec6-58a268fca38d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pFek2294KESgMML0+1DIkg/NodesNotShownInESpaceTree.USJMsJXJUUauxliiaPyjjQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole33\".\"code\" o1, \"enapplicationrole33\".\"name\" o2, NULL o3, NULL o4, \"enapplicationrole33\".\"isareacxp\" o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, \"enregion53\".\"commissionregion\" o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept12\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal71\" Inner JOIN {User} \"enuser121\" ON (\"enuser_extended_internal71\".\"id\" = \"enuser121\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole34\" ON (\"enuser_extended_internal71\".\"jobtitle\" = \"enentrarole34\".\"rolename\"))  Left JOIN {Region} \"enregion53\" ON (\"enuser_extended_internal71\".\"regionid\" = \"enregion53\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept12\" ON (\"enentrarole34\".\"id\" = \"enroleconcept12\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole33\" ON (\"enroleconcept12\".\"applicationroleid\" = \"enapplicationrole33\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser121\".\"id\" = @qpusUser_Id) AND (\"enuser121\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser121\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept12\".\"conceptid\" = ");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionCount.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionCount.GetRoleConcept.List", cancellationToken: cancellationToken);
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
// Query Function "GetSegmentAccGroupTelcelDirectionsByDepartment" 22SW6+8v4EaAzFknt9VSJw of Action "GetRequisitionCount"
public static async Task<(RL_4b6f9359ce9887bc6f37c96ecf62266d,long)> datasetGetSegmentAccGroupTelcelDirectionsByDepartment(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteSegmentAccGroup_GroupName,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetRequisitionCount.GetSegmentAccGroupTelcelDirectionsByDepartment", "eb9664db-2fef-46e0-80cc-5927b7d55227");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetRequisitionCount.GetSegmentAccGroupTelcelDirectionsByDepartment", "eb9664db-2fef-46e0-80cc-5927b7d55227", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.pFek2294KESgMML0+1DIkg/NodesNotShownInESpaceTree.22SW6+8v4EaAzFknt9VSJw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"ensegmentaccgrouptelceldir2\".\"telceldirectionid\" o9, NULL o10, NULL o11");
fromBuilder.Append(" FROM ({SegmentAccGroup} \"ensegmentaccgroup2\" Left JOIN {SegmentAccGroupTelcelDir} \"ensegmentaccgrouptelceldir2\" ON (\"ensegmentaccgroup2\".\"id\" = \"ensegmentaccgrouptelceldir2\".\"segmentaccgroupid\")) ");
whereBuilder.Append(" WHERE (caseaccent_normalize((Upper((trim(\"ensegmentaccgroup2\".\"groupname\")))) collate \"default\") like caseaccent_normalize((Upper((trim(@qpteSegmentAccGroup_GroupName)))) collate \"default\")) AND (\"ensegmentaccgroup2\".\"isactive\" = 1)");
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetRequisitionCount.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetRequisitionCount.GetSegmentAccGroupTelcelDirectionsByDepartment.List", cancellationToken: cancellationToken);
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



}


}
