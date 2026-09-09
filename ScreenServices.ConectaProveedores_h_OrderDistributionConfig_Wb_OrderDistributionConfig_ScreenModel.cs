using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel).Namespace);

    public long inParami_OrderId;
public bool inParami_InPopup;
public int varLcl_TabNumber;
public int varLcl_StartIndex;
public string varLcl_TableSort;
public bool varLcl_ShowAudit;
public DateTime varLcl_AuditInitialDateTime;
public DateTime varLcl_AuditFinalDateTime;
public bool varLcl_IsOrderRejected;
public bool varLcIsOpenPopupConfirmation;
public long varLcRequestDistributionConfigId_ToSave;
public long varLcOrderMainId_ToSave;
public AggregateRecord<RL_fad66e2f0a5803b0832cea3f3e9146e2> ScreenDataSetGetOrderDistributionConfig;
public AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions;
public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Model varLcGetOrderMainDataOnInput;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel() {
}



    public ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel(long inParami_OrderId, bool inParami_InPopup, int varLcl_TabNumber, int varLcl_StartIndex, string varLcl_TableSort, bool varLcl_ShowAudit, DateTime varLcl_AuditInitialDateTime, DateTime varLcl_AuditFinalDateTime, bool varLcl_IsOrderRejected, bool varLcIsOpenPopupConfirmation, long varLcRequestDistributionConfigId_ToSave, long varLcOrderMainId_ToSave, AggregateRecord<RL_fad66e2f0a5803b0832cea3f3e9146e2> ScreenDataSetGetOrderDistributionConfig, AggregateRecord<RL_5d3a02aa993c7474297e33d992f39ad0> ScreenDataSetGetRegions, ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_DataActionGetOrderMainDataOnInput_Model varLcGetOrderMainDataOnInput, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "i_InPopup", "l_TabNumber", "l_StartIndex", "l_TableSort", "l_ShowAudit", "l_AuditInitialDateTime", "l_AuditFinalDateTime", "l_IsOrderRejected", "IsOpenPopupConfirmation", "RequestDistributionConfigId_ToSave", "OrderMainId_ToSave", "GetOrderDistributionConfig", "GetRegions", "GetOrderMainDataOnInput", "ClientVars"}, new string[] {"inParami_OrderId", "inParami_InPopup", "varLcl_TabNumber", "varLcl_StartIndex", "varLcl_TableSort", "varLcl_ShowAudit", "varLcl_AuditInitialDateTime", "varLcl_AuditFinalDateTime", "varLcl_IsOrderRejected", "varLcIsOpenPopupConfirmation", "varLcRequestDistributionConfigId_ToSave", "varLcOrderMainId_ToSave", "ScreenDataSetGetOrderDistributionConfig", "ScreenDataSetGetRegions", "varLcGetOrderMainDataOnInput", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.inParami_InPopup = inParami_InPopup;
this.varLcl_TabNumber = varLcl_TabNumber;
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcl_ShowAudit = varLcl_ShowAudit;
this.varLcl_AuditInitialDateTime = varLcl_AuditInitialDateTime;
this.varLcl_AuditFinalDateTime = varLcl_AuditFinalDateTime;
this.varLcl_IsOrderRejected = varLcl_IsOrderRejected;
this.varLcIsOpenPopupConfirmation = varLcIsOpenPopupConfirmation;
this.varLcRequestDistributionConfigId_ToSave = varLcRequestDistributionConfigId_ToSave;
this.varLcOrderMainId_ToSave = varLcOrderMainId_ToSave;
this.ScreenDataSetGetOrderDistributionConfig = ScreenDataSetGetOrderDistributionConfig;
this.ScreenDataSetGetRegions = ScreenDataSetGetRegions;
this.varLcGetOrderMainDataOnInput = varLcGetOrderMainDataOnInput;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad> datasetGetOrderDistributionConfigReadDbAsync(RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENFirstApproverEntraRole.Read( r, ref index);
rec.ssENFirstContactEntraRole.Read( r, ref index);
rec.ssENOrderDistributionConfig.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENSecondApproverEntraRole.Read( r, ref index);
rec.ssENSecondContactEntraRole.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssRegionNumber = r.ReadText(index++, "OrderDistributionConfigFirstApproverEntraRoleFirstContactEntraRoleSecondApproverEntraRoleSecondContactEntraRoleRegionNumberTelcelDirectionRegionRecord.RegionNumber", "");
return rec;
}
// Query Function "GetOrderDistributionConfig" GMyAaHfaw0qofaqi2tGR1Q of Action "Wb_OrderDistributionConfig"
public static async Task<(RL_fad66e2f0a5803b0832cea3f3e9146e2,long)> datasetGetOrderDistributionConfig(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteOrderDistributionConfig_Applicant,string qpteOrderDistributionConfig_ApplicantDescription,string qpteOrderDistributionConfig_Direction,string qpteOrderDistributionConfig_Division,string qpteOrderDistributionConfig_Role,long qpori_OrderId,string qptel_TableSort,int qpinl_TabNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig", "6880cc18-da77-4ac3-a87d-aaa2dad191d5");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDistributionConfig","h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig");
// Query Iterations: Multiple
// Refresh Query a1Fhj6swG0yCYC0LmoNUQQ Iterations: Multiple
// Refresh Query g49+I1Hfa0ui3GLvwNJYoA Iterations: Multiple
// Refresh Query EcHN_Bh560+IfVUKnRCCzQ Iterations: Multiple
// Refresh Query JI5xDBp1UkqWbnjqvnM2jg Iterations: Multiple
// Refresh Query eMHkZ2zwv0ekShIBXN9rTA Iterations: Multiple
// Refresh Query qTxLZ+d8O0+hjcyMyVJfjw Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.E2gsPBPOqE+VSTtE3kA0fA/ScreenDataSets.GMyAaHfaw0qofaqi2tGR1Q, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfirstapproverentrarole1\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, \"enfirstcontactentrarole1\".\"id\" o6, \"enfirstcontactentrarole1\".\"rolename\" o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enorderdistributionconfig5\".\"id\" o12, NULL o13, \"enorderdistributionconfig5\".\"applicant\" o14, \"enorderdistributionconfig5\".\"applicantdescription\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enregion134\".\"divisionfi\" o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"ensecondapproverentrarole1\".\"rolename\" o39, NULL o40, NULL o41, NULL o42, NULL o43, \"ensecondcontactentrarole1\".\"id\" o44, \"ensecondcontactentrarole1\".\"rolename\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"entelceldirection12\".\"name\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, (substring(\"enregion134\".\"code\" from (2) + 1 for 2)) \"regionnumber\"");
fromBuilder.Append(" FROM (((((({OrderDistributionConfig} \"enorderdistributionconfig5\" Left JOIN {Region} \"enregion134\" ON (\"enorderdistributionconfig5\".\"regionid\" = \"enregion134\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection12\" ON (\"enorderdistributionconfig5\".\"directionid\" = \"entelceldirection12\".\"id\"))  Left JOIN {EntraRole} \"enfirstcontactentrarole1\" ON (\"enorderdistributionconfig5\".\"firstcontact_entraroleid\" = \"enfirstcontactentrarole1\".\"id\"))  Left JOIN {EntraRole} \"ensecondcontactentrarole1\" ON (\"enorderdistributionconfig5\".\"secondcontact_entraroleid\" = \"ensecondcontactentrarole1\".\"id\"))  Left JOIN {EntraRole} \"enfirstapproverentrarole1\" ON (\"enorderdistributionconfig5\".\"firstapprover_entraroleid\" = \"enfirstapproverentrarole1\".\"id\"))  Left JOIN {EntraRole} \"ensecondapproverentrarole1\" ON (\"enorderdistributionconfig5\".\"secondapprover_entraroleid\" = \"ensecondapproverentrarole1\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpinl_TabNumber = 0) THEN (CASE WHEN (@qpori_OrderId <> 0) THEN (CASE WHEN (((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) = '00') OR ((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) = '09')) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) = '00') THEN 1 ELSE 0 END) END) ELSE (CASE WHEN (@qpinl_TabNumber = 2) THEN (CASE WHEN ((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) = '09') THEN 1 ELSE 0 END) ELSE (CASE WHEN (((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) <> '00') AND ((substring(\"enregion134\".\"code\" from (2) + 1 for 2)) <> '09')) THEN 1 ELSE 0 END) END) END) = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpinl_TabNumber", DbType.Int32, qpinl_TabNumber);
sqlCountCmd.CreateParameterWithoutReplacements("@qpinl_TabNumber", DbType.Int32, qpinl_TabNumber);
sqlCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
if (qpteOrderDistributionConfig_Applicant != "" && qpteOrderDistributionConfig_Applicant != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdistributionconfig5\".\"applicant\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Applicant) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Applicant", DbType.String, qpteOrderDistributionConfig_Applicant);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Applicant", DbType.String, qpteOrderDistributionConfig_Applicant);
}
if (qpteOrderDistributionConfig_ApplicantDescription != "" && qpteOrderDistributionConfig_ApplicantDescription != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdistributionconfig5\".\"applicantdescription\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_ApplicantDescription) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_ApplicantDescription", DbType.String, qpteOrderDistributionConfig_ApplicantDescription);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_ApplicantDescription", DbType.String, qpteOrderDistributionConfig_ApplicantDescription);
}
if (qpteOrderDistributionConfig_Direction != "" && qpteOrderDistributionConfig_Direction != "") {
whereBuilder.Append("(caseaccent_normalize(\"entelceldirection12\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Direction) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Direction", DbType.String, qpteOrderDistributionConfig_Direction);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Direction", DbType.String, qpteOrderDistributionConfig_Direction);
}
if (qpteOrderDistributionConfig_Division != "") {
whereBuilder.Append("((CASE WHEN ((@qpori_OrderId <> 0) AND ((substring(@qpteOrderDistributionConfig_Division from (2) + 1 for 2)) = '00')) THEN (CASE WHEN (((substring(\"enregion134\".\"divisionfi\" from (2) + 1 for 2)) = '00') OR ((substring(\"enregion134\".\"divisionfi\" from (2) + 1 for 2)) = '09')) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((substring(\"enregion134\".\"divisionfi\" from (2) + 1 for 2)) = (substring(@qpteOrderDistributionConfig_Division from (2) + 1 for 2))) THEN 1 ELSE 0 END) END) = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
sqlCountCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Division", DbType.String, qpteOrderDistributionConfig_Division);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Division", DbType.String, qpteOrderDistributionConfig_Division);
}
if (qpteOrderDistributionConfig_Role != "" && qpteOrderDistributionConfig_Role != "" && qpteOrderDistributionConfig_Role != "" && qpteOrderDistributionConfig_Role != "" && qpteOrderDistributionConfig_Role != "") {
whereBuilder.Append("((((caseaccent_normalize(\"enfirstapproverentrarole1\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Role) || '%') collate \"default\")) OR (caseaccent_normalize(\"ensecondapproverentrarole1\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Role) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enfirstcontactentrarole1\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Role) || '%') collate \"default\"))) OR (caseaccent_normalize(\"ensecondcontactentrarole1\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qpteOrderDistributionConfig_Role) || '%') collate \"default\")))");
sqlCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Role", DbType.String, qpteOrderDistributionConfig_Role);
sqlCountCmd.CreateParameterWithoutReplacements("@qpteOrderDistributionConfig_Role", DbType.String, qpteOrderDistributionConfig_Role);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"enregion134\".\"code\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptel_TableSort, new string[] { "OrderDistributionConfig", "SecondApproverEntraRole", "FirstContactEntraRole", "FirstApproverEntraRole", "TelcelDirection", "Region", "SecondContactEntraRole" }, new string[] { "ENOrderDistributionConfig5", "ENSecondApproverEntraRole1", "ENFirstContactEntraRole1", "ENFirstApproverEntraRole1", "ENTelcelDirection12", "ENRegion134", "ENSecondContactEntraRole1" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderDistributionConfigEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENTelcelDirectionEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap() }).Split(','));
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
RL_fad66e2f0a5803b0832cea3f3e9146e2 outParamList = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderDistributionConfigReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {false, true, false, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {false, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {false, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_fad66e2f0a5803b0832cea3f3e9146e2 _tmp = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderDistributionConfigReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fad66e2f0a5803b0832cea3f3e9146e2)_tmp;
outParamCount = Convert.ToInt64((await sqlCountCmd.ExecuteScalarAsync<object>(description: "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderDistributionConfig.Count", isApplication: true, skipLog: false, applyTransformationsToParameters: false, cancellationToken: cancellationToken)).ToString());
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

// Query Function "GetRegions" y+tf9Qk6Q0ysx0bdSUVSWg of Action "Wb_OrderDistributionConfig"
public static async Task<(RL_5d3a02aa993c7474297e33d992f39ad0,long)> datasetGetRegions(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetRegions", "f55febcb-3a09-4c43-acc7-46dd4945525a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_OrderDistributionConfig","h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetRegions");
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.E2gsPBPOqE+VSTtE3kA0fA/ScreenDataSets.y+tf9Qk6Q0ysx0bdSUVSWg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enregion135\".\"divisionfi\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12");
fromBuilder.Append(" FROM {Region} \"enregion135\"");
orderByBuilder.Append(" ORDER BY \"enregion135\".\"divisionfi\" ASC ");
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
RL_5d3a02aa993c7474297e33d992f39ad0 outParamList = new RL_5d3a02aa993c7474297e33d992f39ad0();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetRegions.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5d3a02aa993c7474297e33d992f39ad0 _tmp = new RL_5d3a02aa993c7474297e33d992f39ad0();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetRegions.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5d3a02aa993c7474297e33d992f39ad0)_tmp;
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


    public class lcvGetOrderMainDataOnInput : VarsBag {
public RL_e927228371816df5f25c7471220fa6c2 queryResGetOrderMainById_outParamList = new RL_e927228371816df5f25c7471220fa6c2();
public long queryResGetOrderMainById_outParamCount = 0L;

public lcvGetOrderMainDataOnInput() {
}
}
public class lcoGetOrderMainDataOnInput : VarsBag {
public ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure outParamOutFilters = new ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure();

public bool outParamIsOrderRejected = false;

public lcoGetOrderMainDataOnInput() {
}
}
/// <summary>
/// Action <code>GetOrderMainDataOnInput</code> that represents the Service Studio action
///  <code>GetOrderMainDataOnInput</code> <p> Description: </p>
/// </summary>
public async Task<(ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure,bool)> DataActionGetOrderMainDataOnInput(IRequestContext requestContext,CancellationToken cancellationToken) {
ST_6981d7cc6c4cb540deb9cf4d07aa35b9Structure outParamOutFilters = default;
bool outParamIsOrderRejected = default;
lcoGetOrderMainDataOnInput result = new lcoGetOrderMainDataOnInput();
lcvGetOrderMainDataOnInput localVars = new lcvGetOrderMainDataOnInput();
ConectaProveedores_h_OrderDistributionConfig_Wb_OrderDistributionConfig_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetOrderMainDataOnInput", "7fb8d008-c676-4928-9e1a-7082226725a4"))
using (activitySource.CreateScreenDataActionActivity("Wb_OrderDistributionConfig", "GetOrderMainDataOnInput")){
// i_null?
if(((inParami_OrderId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Query datasetGetOrderMainById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderMainById_maxRecords = 0;
int datasetGetOrderMainById_startIndex = 0;(localVars.queryResGetOrderMainById_outParamList,localVars.queryResGetOrderMainById_outParamCount) = await FuncDataActionGetOrderMainDataOnInput.datasetGetOrderMainById(requestContext,datasetGetOrderMainById_maxRecords,datasetGetOrderMainById_startIndex,IterationMultiplicity.Never,inParami_OrderId,cancellationToken);

// l_IsOrderRejected = True
// IsOrderRejected = GetOrderMainById.List.Current.OrderMain.OrderStatusId = Rejected
result.outParamIsOrderRejected=(localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("bRJk2wDqy0yRFZotyjWZ5Q"))).ssId);
// OutFilters
// OutFilters.Division = GetOrderMainById.List.Current.Region.DivisionFI
result.outParamOutFilters.ssDivision = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// OutFilters.TabNumber = GetOrderMainById.List.Current.TabNumber
result.outParamOutFilters.ssTabNumber = localVars.queryResGetOrderMainById_outParamList.CurrentRec.ssTabNumber;
} else {
// OutFilters
// OutFilters.Division = ""
result.outParamOutFilters.ssDivision = "";

// OutFilters.Applicant = ""
result.outParamOutFilters.ssApplicant = "";

// OutFilters.Direction = ""
result.outParamOutFilters.ssDirection = "";

// OutFilters.ApplicantDescription = ""
result.outParamOutFilters.ssApplicantDescription = "";

// OutFilters.TabNumber = 0
result.outParamOutFilters.ssTabNumber = 0;

// IsOrderRejected = True
result.outParamIsOrderRejected=true;
}

} //close CreateActionActivity using block
} // try

finally {
outParamOutFilters = result.outParamOutFilters;
outParamIsOrderRejected = result.outParamIsOrderRejected;
} // inner-finally
RETURN_STATEMENT:
return (outParamOutFilters,outParamIsOrderRejected);
}


    public static class FuncDataActionGetOrderMainDataOnInput {

private static async Task<RC_0d0a8c249b32cb294d6fd424b17f5c4d> datasetGetOrderMainByIdReadDbAsync(RC_0d0a8c249b32cb294d6fd424b17f5c4d rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderMain.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENTelcelDirection.Read( r, ref index);
rec.ssTabNumber = r.ReadInteger(index++, "OrderMainTabNumberTelcelDirectionRegionRecord.TabNumber", 0);
return rec;
}
// Query Function "GetOrderMainById" xdsAhprxHECDLj2k8MaiFA of Action "GetOrderMainDataOnInput"
public static async Task<(RL_e927228371816df5f25c7471220fa6c2,long)> datasetGetOrderMainById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderMain_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderMainDataOnInput.GetOrderMainById", "8600dbc5-f19a-401c-832e-3da4f0c6a214");
using var queryActivity = activitySource.CreateAggregateQueryActivity("h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderMainDataOnInput.GetOrderMainById", "8600dbc5-f19a-401c-832e-3da4f0c6a214", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.E2gsPBPOqE+VSTtE3kA0fA/DataActions.CNC4f3bGKEmeGnCCImclpA/NodesNotShownInESpaceTree.xdsAhprxHECDLj2k8MaiFA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, \"enordermain108\".\"orderstatusid\" o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, \"enregion136\".\"divisionfi\" o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, (CASE WHEN ((substring(\"enregion136\".\"centrortp\" from (2) + 1 for 2)) = '00') THEN 0 ELSE (CASE WHEN ((substring(\"enregion136\".\"centrortp\" from (2) + 1 for 2)) = '09') THEN 2 ELSE 1 END) END) \"tabnumber\"");
fromBuilder.Append(" FROM (({OrderMain} \"enordermain108\" Left JOIN {Region} \"enregion136\" ON (\"enordermain108\".\"regionid\" = \"enregion136\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection13\" ON (\"enordermain108\".\"telceldirectionid\" = \"entelceldirection13\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qporOrderMain_Id != 0) {
whereBuilder.Append("((\"enordermain108\".\"id\" = @qporOrderMain_Id) AND (\"enordermain108\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderMain_Id", DbType.Int64, qporOrderMain_Id);
} else {
whereBuilder.Append("(\"enordermain108\".\"id\" IS NULL)");
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
RL_e927228371816df5f25c7471220fa6c2 outParamList = new RL_e927228371816df5f25c7471220fa6c2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderMainDataOnInput.GetOrderMainById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e927228371816df5f25c7471220fa6c2 _tmp = new RL_e927228371816df5f25c7471220fa6c2();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderMainByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.Wb_OrderDistributionConfig.GetOrderMainDataOnInput.GetOrderMainById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e927228371816df5f25c7471220fa6c2)_tmp;
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
