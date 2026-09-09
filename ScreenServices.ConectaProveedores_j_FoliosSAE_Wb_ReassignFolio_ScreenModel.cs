using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel).Namespace);

    public bool inParami_IsSidebarOpen;
public bool inParami_IsInvoiceApproval;
public string varLcl_Motive;
public string varLcl_SourceUserId;
public string varLcl_SubstituteUserId;
public bool varLcl_ShowConfirmPopup;
public string varLcTableSort;
public int varLcStartIndex;
public int varLcMaxRecords;
public bool varLcl_IsSelectAll;
public bool varLcl_IsSelect;
public AggregateRecord<RL_c18f46fc1b14374364595e3e32a1c4d4> ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel() {
}



    public ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel(bool inParami_IsSidebarOpen, bool inParami_IsInvoiceApproval, string varLcl_Motive, string varLcl_SourceUserId, string varLcl_SubstituteUserId, bool varLcl_ShowConfirmPopup, string varLcTableSort, int varLcStartIndex, int varLcMaxRecords, bool varLcl_IsSelectAll, bool varLcl_IsSelect, AggregateRecord<RL_c18f46fc1b14374364595e3e32a1c4d4> ScreenDataSetGetFolioApprovalLevelsByAssignedTo, ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_DataActionGetUserApplicationRoles_Model varLcGetUserApplicationRoles, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_IsSidebarOpen", "i_IsInvoiceApproval", "l_Motive", "l_SourceUserId", "l_SubstituteUserId", "l_ShowConfirmPopup", "TableSort", "StartIndex", "MaxRecords", "l_IsSelectAll", "l_IsSelect", "GetFolioApprovalLevelsByAssignedTo", "GetUserApplicationRoles", "ClientVars"}, new string[] {"inParami_IsSidebarOpen", "inParami_IsInvoiceApproval", "varLcl_Motive", "varLcl_SourceUserId", "varLcl_SubstituteUserId", "varLcl_ShowConfirmPopup", "varLcTableSort", "varLcStartIndex", "varLcMaxRecords", "varLcl_IsSelectAll", "varLcl_IsSelect", "ScreenDataSetGetFolioApprovalLevelsByAssignedTo", "varLcGetUserApplicationRoles", "clientVariables"});
this.inParami_IsSidebarOpen = inParami_IsSidebarOpen;
this.inParami_IsInvoiceApproval = inParami_IsInvoiceApproval;
this.varLcl_Motive = varLcl_Motive;
this.varLcl_SourceUserId = varLcl_SourceUserId;
this.varLcl_SubstituteUserId = varLcl_SubstituteUserId;
this.varLcl_ShowConfirmPopup = varLcl_ShowConfirmPopup;
this.varLcTableSort = varLcTableSort;
this.varLcStartIndex = varLcStartIndex;
this.varLcMaxRecords = varLcMaxRecords;
this.varLcl_IsSelectAll = varLcl_IsSelectAll;
this.varLcl_IsSelect = varLcl_IsSelect;
this.ScreenDataSetGetFolioApprovalLevelsByAssignedTo = ScreenDataSetGetFolioApprovalLevelsByAssignedTo;
this.varLcGetUserApplicationRoles = varLcGetUserApplicationRoles;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_6441282eac0a2260326cac952b2cda40> datasetGetFolioApprovalLevelsByAssignedToReadDbAsync(RC_6441282eac0a2260326cac952b2cda40 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENApprovalStatus.Read( r, ref index);
rec.ssENFolio.Read( r, ref index);
rec.ssENFolioApproval.Read( r, ref index);
rec.ssENFolioApprovalLevel.Read( r, ref index);
rec.ssENFolioStatus.Read( r, ref index);
rec.ssENOrderMain.Read( r, ref index);
rec.ssENSupplier.Read( r, ref index);
rec.ssIsSelected = r.ReadBoolean(index++, "FolioStatusFolioApprovalFolioFolioApprovalLevelApprovalStatusOrderMainApplicationRoleIsSelectedSupplierRecord.IsSelected", false);
return rec;
}
// Query Function "GetFolioApprovalLevelsByAssignedTo" KxisR9g+NUGGYLrKHIKtwQ of Action "Wb_ReassignFolio"
public static async Task<(RL_c18f46fc1b14374364595e3e32a1c4d4,long)> datasetGetFolioApprovalLevelsByAssignedTo(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteAppRoleListText,string qpteEntraRolesListText,long qpdeFolioApprovalLevel_DepartmentId,long qpreGetUserRegionId,bool qpboFolioApprovalLevel_IsInvoiceApproval,string qpusFolioApprovalLevel_AssignedTo,string qpteTableSort,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("j_FoliosSAE.Wb_ReassignFolio.GetFolioApprovalLevelsByAssignedTo", "47ac182b-3ed8-4135-8660-baca1c82adc1");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_ReassignFolio","j_FoliosSAE.Wb_ReassignFolio.GetFolioApprovalLevelsByAssignedTo");
// Query Iterations: Multiple
// Refresh Query wCP4ws09X0mcmK8XeI3MQg Iterations: Multiple
// Refresh Query ubvfkI8OM0ypNTNJU+Gp9w Iterations: Multiple
// Refresh Query 9o28a85k+EG7b+oaaJ0yeQ Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.l4T8OJF2IUm4wQ+berg4zw/ScreenDataSets.KxisR9g+NUGGYLrKHIKtwQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, \"enapprovalstatus33\".\"class\" o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, \"enapprovalstatus33\".\"labeles\" o16, NULL o17, NULL o18, \"enfolio89\".\"folionumber\" o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, \"enfolioapprovallevel48\".\"id\" o47, NULL o48, \"enfolioapprovallevel48\".\"levelnumber\" o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, NULL o57, NULL o58, NULL o59, NULL o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, NULL o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, \"enordermain130\".\"ordernumber\" o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, \"ensupplier135\".\"name\" o104, \"ensupplier135\".\"number\" o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, 0 \"isselected\"");
fromBuilder.Append(" FROM ((((((({FolioApprovalLevel} \"enfolioapprovallevel48\" Left JOIN {FolioApproval} \"enfolioapproval52\" ON (\"enfolioapprovallevel48\".\"folioapprovalid\" = \"enfolioapproval52\".\"id\"))  Left JOIN {Folio} \"enfolio89\" ON (\"enfolioapproval52\".\"folioid\" = \"enfolio89\".\"id\"))  Left JOIN {ApplicationRole} \"enapplicationrole90\" ON (\"enfolioapprovallevel48\".\"applicationroleid\" = \"enapplicationrole90\".\"id\"))  Left JOIN {ApprovalStatus} \"enapprovalstatus33\" ON (\"enfolioapprovallevel48\".\"approvalstatusid\" = \"enapprovalstatus33\".\"id\"))  Left JOIN {FolioStatus} \"enfoliostatus17\" ON (\"enfolio89\".\"foliostatusid\" = \"enfoliostatus17\".\"id\"))  Left JOIN {OrderMain} \"enordermain130\" ON (\"enfolio89\".\"orderid\" = \"enordermain130\".\"id\"))  Left JOIN {Supplier} \"ensupplier135\" ON (\"enordermain130\".\"supplierid\" = \"ensupplier135\".\"id\")) ");
whereBuilder.Append(" WHERE (@qpusFolioApprovalLevel_AssignedTo <> '') AND (\"enfolioapprovallevel48\".\"isinvoiceapproval\" = @qpboFolioApprovalLevel_IsInvoiceApproval) AND (((\"enfolioapprovallevel48\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("D2_uWT_NNEy5Fa5VMXMLBw"))).ssId);
whereBuilder.Append(") OR (\"enfolioapprovallevel48\".\"approvalstatusid\" = ");
whereBuilder.Append((ENApprovalStatusEntity.GetRecordByKey(ObjectKey.Parse("RvhtMOVzUke_jX9z3pm9HA"))).ssId);
whereBuilder.Append(")) AND ((CASE WHEN (\"enfolioapprovallevel48\".\"assignedto\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
sqlCmd.CreateParameterWithoutReplacements("@qpboFolioApprovalLevel_IsInvoiceApproval", DbType.Boolean, qpboFolioApprovalLevel_IsInvoiceApproval);
if ((qpusFolioApprovalLevel_AssignedTo.Trim()!="")) {
whereBuilder.Append("((\"enfolioapprovallevel48\".\"assignedto\" = @qpusFolioApprovalLevel_AssignedTo) AND (\"enfolioapprovallevel48\".\"assignedto\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusFolioApprovalLevel_AssignedTo", DbType.String, qpusFolioApprovalLevel_AssignedTo);
} else {
whereBuilder.Append("(\"enfolioapprovallevel48\".\"assignedto\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ((((((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel48\".\"applicationroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel48\".\"applicationroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteAppRoleListText collate \"default\"))-1) END)) <> (-1)) OR (((CASE WHEN char_length(caseaccent_normalize(cast(\"enfolioapprovallevel48\".\"entraroleid\" as text) collate \"default\"))=0 THEN -1 ELSE (position(caseaccent_normalize(cast(\"enfolioapprovallevel48\".\"entraroleid\" as text) collate \"default\") in caseaccent_normalize(@qpteEntraRolesListText collate \"default\"))-1) END)) <> (-1))) AND ((CASE WHEN (\"enfolioapproval52\".\"regionid\" IS NOT NULL) THEN (CASE WHEN ");
sqlCmd.CreateParameterWithoutReplacements("@qpteAppRoleListText", DbType.String, qpteAppRoleListText);
sqlCmd.CreateParameterWithoutReplacements("@qpteEntraRolesListText", DbType.String, qpteEntraRolesListText);
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enfolioapproval52\".\"regionid\" = @qpreGetUserRegionId) AND (\"enfolioapproval52\".\"regionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enfolioapproval52\".\"regionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) ELSE (CASE WHEN ");
if (qpreGetUserRegionId != 0) {
whereBuilder.Append("((\"enordermain130\".\"divisionid\" = @qpreGetUserRegionId) AND (\"enordermain130\".\"divisionid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreGetUserRegionId", DbType.Int64, qpreGetUserRegionId);
} else {
whereBuilder.Append("(\"enordermain130\".\"divisionid\" IS NULL)");
}
whereBuilder.Append(" THEN 1 ELSE 0 END) END) = 1)) AND ((\"enfolioapprovallevel48\".\"departmentid\" IS NULL) OR ");
if (qpdeFolioApprovalLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enfolioapprovallevel48\".\"departmentid\" = @qpdeFolioApprovalLevel_DepartmentId) AND (\"enfolioapprovallevel48\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeFolioApprovalLevel_DepartmentId", DbType.Int64, qpdeFolioApprovalLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enfolioapprovallevel48\".\"departmentid\" IS NULL)");
}
whereBuilder.Append(")) THEN 1 ELSE 0 END) END) = 1))");
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qpteTableSort, new string[] { "FolioStatus", "FolioApprovalLevel", "Folio", "ApplicationRole", "Supplier", "FolioApproval", "OrderMain", "ApprovalStatus" }, new string[] { "ENFolioStatus17", "ENFolioApprovalLevel48", "ENFolio89", "ENApplicationRole90", "ENSupplier135", "ENFolioApproval52", "ENOrderMain130", "ENApprovalStatus33" }, new System.Collections.Generic.Dictionary<string, string>[] { ENFolioStatusEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalLevelEntity.AttributesToDatabaseNamesMap(), ENFolioEntity.AttributesToDatabaseNamesMap(), ENApplicationRoleEntity.AttributesToDatabaseNamesMap(), ENSupplierEntity.AttributesToDatabaseNamesMap(), ENFolioApprovalEntity.AttributesToDatabaseNamesMap(), ENOrderMainEntity.AttributesToDatabaseNamesMap(), ENApprovalStatusEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByColumns.Add("\"enfolio89\".\"id\" ASC ");
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
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_c18f46fc1b14374364595e3e32a1c4d4 outParamList = new RL_c18f46fc1b14374364595e3e32a1c4d4();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByAssignedToReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[8];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, false, true, true, true, true, true, true, false});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[7] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolio.GetFolioApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_c18f46fc1b14374364595e3e32a1c4d4 _tmp = new RL_c18f46fc1b14374364595e3e32a1c4d4();
_tmp.AlternateReadDbMethodAsync = datasetGetFolioApprovalLevelsByAssignedToReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolio.GetFolioApprovalLevelsByAssignedTo.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_c18f46fc1b14374364595e3e32a1c4d4)_tmp;
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


    public class lcvGetUserApplicationRoles : VarsBag {
public int resListIndexOf_outParamPosition = 0;

public RL_87311ea350338b4dcd53388d23fa3f86 queryResGetUserApplicationRoleTempActive_outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
public long queryResGetUserApplicationRoleTempActive_outParamCount = 0L;

public RL_721bdfcca4a4edbce82baece8dfe837b queryResGetRoleConcept_outParamList = new RL_721bdfcca4a4edbce82baece8dfe837b();
public long queryResGetRoleConcept_outParamCount = 0L;

public lcvGetUserApplicationRoles() {
}
}
public class lcoGetUserApplicationRoles : VarsBag {
public RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = new RL_97ac86b141c7934fd96d3cf71793066e();

public string outParamAppRoleListText = "";

public string outParamEntraRolesListText = "";

public lcoGetUserApplicationRoles() {
}
}
/// <summary>
/// Action <code>GetUserApplicationRoles</code> that represents the Service Studio action
///  <code>GetUserApplicationRoles</code> <p> Description: </p>
/// </summary>
public async Task<(RL_97ac86b141c7934fd96d3cf71793066e,string,string)> DataActionGetUserApplicationRoles(IRequestContext requestContext,CancellationToken cancellationToken) {
RL_97ac86b141c7934fd96d3cf71793066e outParamUserRolesList = default;
string outParamAppRoleListText = default;
string outParamEntraRolesListText = default;
lcoGetUserApplicationRoles result = new lcoGetUserApplicationRoles();
lcvGetUserApplicationRoles localVars = new lcvGetUserApplicationRoles();
ConectaProveedores_j_FoliosSAE_Wb_ReassignFolio_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserApplicationRoles", "2a58e82a-0105-41c8-bf81-cf798fad41a8"))
using (activitySource.CreateScreenDataActionActivity("Wb_ReassignFolio", "GetUserApplicationRoles")){
// Query datasetGetRoleConcept
cancellationToken.ThrowIfCancellationRequested();
int datasetGetRoleConcept_maxRecords = 0;
int datasetGetRoleConcept_startIndex = 0;(localVars.queryResGetRoleConcept_outParamList,localVars.queryResGetRoleConcept_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetRoleConcept(requestContext,datasetGetRoleConcept_maxRecords,datasetGetRoleConcept_startIndex,IterationMultiplicity.Multiple,varLcl_SourceUserId,cancellationToken);

// Query datasetGetUserApplicationRoleTempActive
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserApplicationRoleTempActive_maxRecords = 0;
int datasetGetUserApplicationRoleTempActive_startIndex = 0;(localVars.queryResGetUserApplicationRoleTempActive_outParamList,localVars.queryResGetUserApplicationRoleTempActive_outParamCount) = await FuncDataActionGetUserApplicationRoles.datasetGetUserApplicationRoleTempActive(requestContext,datasetGetUserApplicationRoleTempActive_maxRecords,datasetGetUserApplicationRoleTempActive_startIndex,IterationMultiplicity.Single,varLcl_SourceUserId,cancellationToken);

// UserRolesList = GetRoleConcept.List
result.outParamUserRolesList=(await RL_97ac86b141c7934fd96d3cf71793066e.ConvertAsync(localVars.queryResGetRoleConcept_outParamList, new RL_97ac86b141c7934fd96d3cf71793066e(), async (RC_6d4a92ad9e5239e9c12dd070f5b17d69 source, ST_e39617f0f094a322d4157f34fe424dadStructure target, CancellationToken cancellationToken) => {
target.ssApplicationRoleId = source.ssENRoleConcept.ssApplicationRoleId;
target.ssRoleName = source.ssENApplicationRole.ssName;
target.ssCode = source.ssENApplicationRole.ssCode;
target.ssIsSubstitute = false;
return target;
}, cancellationToken));
// Foreach GetRoleConcept.List
localVars.queryResGetRoleConcept_outParamList.StartIteration();
try {while (!((localVars.queryResGetRoleConcept_outParamList.Eof))) {
// AppRoleListText = AppRoleListText + "," + GetRoleConcept.List.Current.RoleConcept.ApplicationRoleId
result.outParamAppRoleListText=((result.outParamAppRoleListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENRoleConcept.ssApplicationRoleId));

// EntraRolesListText = EntraRolesListText + "," + GetRoleConcept.List.Current.User_Extended_Internal.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetRoleConcept_outParamList.CurrentRec.ssENUser_Extended_Internal.ssEntraRoleId));
localVars.queryResGetRoleConcept_outParamList.Advance();
}

} finally {
localVars.queryResGetRoleConcept_outParamList.EndIteration();
}

// Foreach GetUserApplicationRoleTempActive.List
localVars.queryResGetUserApplicationRoleTempActive_outParamList.StartIteration();
try {while (!((localVars.queryResGetUserApplicationRoleTempActive_outParamList.Eof))) {
// EntraRolesListText = EntraRolesListText + "," + GetUserApplicationRoleTempActive.List.Current.UserApplicationRoleTemp.EntraRoleId
result.outParamEntraRolesListText=((result.outParamEntraRolesListText+",")+BuiltInFunction.LongIntegerToText(localVars.queryResGetUserApplicationRoleTempActive_outParamList.CurrentRec.ssENUserApplicationRoleTemp.ssEntraRoleId));
localVars.queryResGetUserApplicationRoleTempActive_outParamList.Advance();
}

} finally {
localVars.queryResGetUserApplicationRoleTempActive_outParamList.EndIteration();
}

// ListIndexOf
localVars.resListIndexOf_outParamPosition = await ExtendedActions.ListIndexOf(requestContext,localVars.queryResGetRoleConcept_outParamList,async (p, cancellationToken) => p.ssENApplicationRole.ssCanBulkApproveFolios,cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamUserRolesList = result.outParamUserRolesList;
outParamAppRoleListText = result.outParamAppRoleListText;
outParamEntraRolesListText = result.outParamEntraRolesListText;
} // inner-finally
RETURN_STATEMENT:
return (outParamUserRolesList,outParamAppRoleListText,outParamEntraRolesListText);
}


    public static class FuncDataActionGetUserApplicationRoles {

// Query Function "GetUserApplicationRoleTempActive" ZgcmdKd9TEuIkV6+fYXJeQ of Action "GetUserApplicationRoles"
public static async Task<(RL_87311ea350338b4dcd53388d23fa3f86,long)> datasetGetUserApplicationRoleTempActive(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUserId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "74260766-7da7-4b4c-8891-5ebe7d85c979");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetUserApplicationRoleTempActive", "74260766-7da7-4b4c-8891-5ebe7d85c979", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.l4T8OJF2IUm4wQ+berg4zw/DataActions.KuhYKgUByEG_gc95j61BqA/NodesNotShownInESpaceTree.ZgcmdKd9TEuIkV6+fYXJeQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enuserapplicationroletemp15\".\"entraroleid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13");
fromBuilder.Append(" FROM {UserApplicationRoleTemp} \"enuserapplicationroletemp15\"");
whereBuilder.Append(" WHERE ");
if ((qpusUserId.Trim()!="")) {
whereBuilder.Append("((\"enuserapplicationroletemp15\".\"userid\" = @qpusUserId) AND (\"enuserapplicationroletemp15\".\"userid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUserId", DbType.String, qpusUserId);
} else {
whereBuilder.Append("(\"enuserapplicationroletemp15\".\"userid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enuserapplicationroletemp15\".\"rolestatusid\" = ");
whereBuilder.Append(2
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
RL_87311ea350338b4dcd53388d23fa3f86 outParamList = new RL_87311ea350338b4dcd53388d23fa3f86();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_87311ea350338b4dcd53388d23fa3f86 _tmp = new RL_87311ea350338b4dcd53388d23fa3f86();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetUserApplicationRoleTempActive.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_87311ea350338b4dcd53388d23fa3f86)_tmp;
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
// Query Function "GetRoleConcept" An+o3OOE3Ee+9AKT_GUCyg of Action "GetUserApplicationRoles"
public static async Task<(RL_721bdfcca4a4edbce82baece8dfe837b,long)> datasetGetRoleConcept(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetRoleConcept", "dca87f02-84e3-47dc-bef4-0293fc6502ca");
using var queryActivity = activitySource.CreateAggregateQueryActivity("j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetRoleConcept", "dca87f02-84e3-47dc-bef4-0293fc6502ca", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.Utah_tbAdESKIIbIbCGHtg/NodesShownInESpaceTree.l4T8OJF2IUm4wQ+berg4zw/DataActions.KuhYKgUByEG_gc95j61BqA/NodesNotShownInESpaceTree.An+o3OOE3Ee+9AKT_GUCyg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enapplicationrole91\".\"code\" o1, \"enapplicationrole91\".\"name\" o2, NULL o3, NULL o4, NULL o5, \"enapplicationrole91\".\"canbulkapprovefolios\" o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, \"enroleconcept36\".\"applicationroleid\" o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"enuser_extended_internal138\".\"entraroleid\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM ((((({User_Extended_Internal} \"enuser_extended_internal138\" Inner JOIN {User} \"enuser232\" ON (\"enuser_extended_internal138\".\"id\" = \"enuser232\".\"id\"))  Inner JOIN {EntraRole} \"enentrarole83\" ON (\"enuser_extended_internal138\".\"jobtitle\" = \"enentrarole83\".\"rolename\"))  Left JOIN {Region} \"enregion184\" ON (\"enuser_extended_internal138\".\"regionid\" = \"enregion184\".\"id\"))  Left JOIN {RoleConcept} \"enroleconcept36\" ON (\"enentrarole83\".\"id\" = \"enroleconcept36\".\"entraroleid\"))  Left JOIN {ApplicationRole} \"enapplicationrole91\" ON (\"enroleconcept36\".\"applicationroleid\" = \"enapplicationrole91\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser232\".\"id\" = @qpusUser_Id) AND (\"enuser232\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Id", DbType.String, qpusUser_Id);
} else {
whereBuilder.Append("(\"enuser232\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enroleconcept36\".\"conceptid\" = ");
whereBuilder.Append(2
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
opt[2] = new BitArray(new bool[] {true, false, false, true, true, true, false});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query j_FoliosSAE.Wb_ReassignFolio.GetUserApplicationRoles.GetRoleConcept.List", cancellationToken: cancellationToken);
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


}
