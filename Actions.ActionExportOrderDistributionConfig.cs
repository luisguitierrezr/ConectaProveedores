namespace ssConectaProveedores;

public partial class Actions {
public class lcvExportOrderDistributionConfig : VarsBag {
public long inParami_OrderId;
public int inParami_TabNumber;
public string inParami_TableSort;
public string inParami_OrderDistributionConfig_Applicant;
public string inParami_OrderDistributionConfig_ApplicantDescription;
public string inParami_OrderDistributionConfig_Direction;
public string inParami_OrderDistributionConfig_Division;
public string inParami_OrderDistributionConfig_Role;
/// <summary>
/// Variable <code>l_OrderDistributionImportList</code> that represents the Service Studio
///  OrderDistributionImportStrucList <code>l_OrderDistributionImportList</code> <p>Description
/// : OrderDistributionImportStruc List.</p>
/// </summary>
public RL_e5599d6b39ff4d762401f24c2e9326ab varLcl_OrderDistributionImportList = new RL_e5599d6b39ff4d762401f24c2e9326ab();

public Actions.lcoExportStructOld resExportStructOld =  new Actions.lcoExportStructOld();
public byte[] resRecordListToExcel_outParamOut = new byte[] {};
public RL_fad66e2f0a5803b0832cea3f3e9146e2 queryResGetOrderDistributionConfig_outParamList = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
public long queryResGetOrderDistributionConfig_outParamCount = 0L;

public lcvExportOrderDistributionConfig(long inParami_OrderId, int inParami_TabNumber, string inParami_TableSort, string inParami_OrderDistributionConfig_Applicant, string inParami_OrderDistributionConfig_ApplicantDescription, string inParami_OrderDistributionConfig_Direction, string inParami_OrderDistributionConfig_Division, string inParami_OrderDistributionConfig_Role) {
this.inParami_OrderId = inParami_OrderId;
this.inParami_TabNumber = inParami_TabNumber;
this.inParami_TableSort = inParami_TableSort;
this.inParami_OrderDistributionConfig_Applicant = inParami_OrderDistributionConfig_Applicant;
this.inParami_OrderDistributionConfig_ApplicantDescription = inParami_OrderDistributionConfig_ApplicantDescription;
this.inParami_OrderDistributionConfig_Direction = inParami_OrderDistributionConfig_Direction;
this.inParami_OrderDistributionConfig_Division = inParami_OrderDistributionConfig_Division;
this.inParami_OrderDistributionConfig_Role = inParami_OrderDistributionConfig_Role;
}
}
public class lcoExportOrderDistributionConfig : VarsBag {
public ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = new ST_a158c76eb93396680623c04244f48b6cStructure();

public lcoExportOrderDistributionConfig() {
}
}
/// <summary>
/// Action <code>ExportOrderDistributionConfig</code> that represents the Service Studio action
///  <code>ExportOrderDistributionConfig</code> <p> Description: </p>
/// </summary>
public static async Task<ST_a158c76eb93396680623c04244f48b6cStructure> ActionExportOrderDistributionConfig(IRequestContext requestContext,long inParami_OrderId,int inParami_TabNumber,string inParami_TableSort,string inParami_OrderDistributionConfig_Applicant,string inParami_OrderDistributionConfig_ApplicantDescription,string inParami_OrderDistributionConfig_Direction,string inParami_OrderDistributionConfig_Division,string inParami_OrderDistributionConfig_Role,CancellationToken cancellationToken) {
ST_a158c76eb93396680623c04244f48b6cStructure outParamo_File = default;
lcoExportOrderDistributionConfig result = new lcoExportOrderDistributionConfig();
lcvExportOrderDistributionConfig localVars = new lcvExportOrderDistributionConfig(inParami_OrderId, inParami_TabNumber, inParami_TableSort, inParami_OrderDistributionConfig_Applicant, inParami_OrderDistributionConfig_ApplicantDescription, inParami_OrderDistributionConfig_Direction, inParami_OrderDistributionConfig_Division, inParami_OrderDistributionConfig_Role);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ExportOrderDistributionConfig", "4eb277e3-b4fb-4e9c-9011-7b8db52a4dd0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ExportOrderDistributionConfig", "4eb277e3-b4fb-4e9c-9011-7b8db52a4dd0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// IsACtiveDev_ExportOrderDistributionConfig
if((((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsACtiveDev_ExportOrderDistributionConfig]))))) {
// Query datasetGetOrderDistributionConfig
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderDistributionConfig_maxRecords = 999999999;
if (datasetGetOrderDistributionConfig_maxRecords < 1) datasetGetOrderDistributionConfig_maxRecords = 1;
int datasetGetOrderDistributionConfig_startIndex = 0;(localVars.queryResGetOrderDistributionConfig_outParamList,localVars.queryResGetOrderDistributionConfig_outParamCount) = await FuncActionExportOrderDistributionConfig.datasetGetOrderDistributionConfig(requestContext,datasetGetOrderDistributionConfig_maxRecords,datasetGetOrderDistributionConfig_startIndex,IterationMultiplicity.Multiple,localVars.inParami_OrderDistributionConfig_Applicant,localVars.inParami_OrderDistributionConfig_ApplicantDescription,localVars.inParami_OrderDistributionConfig_Direction,localVars.inParami_OrderDistributionConfig_Division,localVars.inParami_OrderDistributionConfig_Role,localVars.inParami_OrderId,localVars.inParami_TableSort,localVars.inParami_TabNumber,cancellationToken);

// Tranform
await ExtendedActions.ListAppendAll(requestContext,localVars.varLcl_OrderDistributionImportList,(await RL_e5599d6b39ff4d762401f24c2e9326ab.ConvertAsync(localVars.queryResGetOrderDistributionConfig_outParamList, new RL_e5599d6b39ff4d762401f24c2e9326ab(), async (RC_c1e2ad1f67f216fd0b4fb3f61e1c54ad source, ST_eeea109a56651eacd7e36d2408b5b781Structure target, CancellationToken cancellationToken) => {
target.ssDivision = source.ssENRegion.ssDivisionFI;
target.ssApplicant = source.ssENOrderDistributionConfig.ssApplicant;
target.ssApplicantDescription = source.ssENOrderDistributionConfig.ssApplicantDescription;
target.ssDirection = source.ssENTelcelDirection.ssName;
target.ssFirstContact = source.ssENFirstContactEntraRole.ssRoleName;
target.ssSecondContact = source.ssENSecondContactEntraRole.ssRoleName;
target.ssFirstApprover = source.ssENFirstApproverEntraRole.ssRoleName;
target.ssSecondApprover = source.ssENSecondApproverEntraRole.ssRoleName;
return target;
}, cancellationToken)),cancellationToken);

// RecordListToExcel RLToExcelExportOrderDistributionConfigRecordListToExcel
localVars.resRecordListToExcel_outParamOut = await FuncActionExportOrderDistributionConfig.RLToExcelExportOrderDistributionConfigRecordListToExcel(requestContext,localVars.varLcl_OrderDistributionImportList,cancellationToken);

// o_File.BinaryData = RecordListToExcel
result.outParamo_File.ssBinaryData = localVars.resRecordListToExcel_outParamOut;

// o_File.Name = "OrderDistributionConfig.xlsx"
result.outParamo_File.ssName = AppUtils.GetStringResource("gBIKi1KwkUKWyaHtxaE8UQ#Value.335842131.1", "OrderDistributionConfig.xlsx");
} else {
// ExportStructOld
localVars.resExportStructOld.outParamStruct = await Actions.ActionExportStructOld(requestContext,cancellationToken);

// o_File.BinaryData = ExportStructOld.Struct
result.outParamo_File.ssBinaryData = localVars.resExportStructOld.outParamStruct;

// o_File.Name = "OrderDistributionConfig.xlsx"
result.outParamo_File.ssName = AppUtils.GetStringResource("j89Q7Xf7q0O9CV2zG5MB7w#Value.335842131.1", "OrderDistributionConfig.xlsx");
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_File = result.outParamo_File;
} // inner-finally
RETURN_STATEMENT:
return outParamo_File;
}

public static class FuncActionExportOrderDistributionConfig {

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
// Query Function "GetOrderDistributionConfig" ZwvXiImP3ky1cVrgeSN7ng of Action "ExportOrderDistributionConfig"
public static async Task<(RL_fad66e2f0a5803b0832cea3f3e9146e2,long)> datasetGetOrderDistributionConfig(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qptei_OrderDistributionConfig_Applicant,string qptei_OrderDistributionConfig_ApplicantDescription,string qptei_OrderDistributionConfig_Direction,string qptei_OrderDistributionConfig_Division,string qptei_OrderDistributionConfig_Role,long qpori_OrderId,string qptei_TableSort,int qpini_TabNumber,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("ExportOrderDistributionConfig.GetOrderDistributionConfig", "88d70b67-8f89-4cde-b571-5ae079237b9e");
using var queryActivity = activitySource.CreateAggregateQueryActivity("ExportOrderDistributionConfig.GetOrderDistributionConfig", "88d70b67-8f89-4cde-b571-5ae079237b9e", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.43eyTvu0nE6QEXuNtSpN0A/NodesNotShownInESpaceTree.ZwvXiImP3ky1cVrgeSN7ng, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enfirstapproverentrarole\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, \"enfirstcontactentrarole\".\"rolename\" o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, \"enorderdistributionconfig1\".\"applicant\" o14, \"enorderdistributionconfig1\".\"applicantdescription\" o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, \"enregion17\".\"divisionfi\" o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, \"ensecondapproverentrarole\".\"rolename\" o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, \"ensecondcontactentrarole\".\"rolename\" o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, \"entelceldirection6\".\"name\" o51, NULL o52, NULL o53, NULL o54, NULL o55, NULL o56, (substring(\"enregion17\".\"code\" from (2) + 1 for 2)) \"regionnumber\"");
fromBuilder.Append(" FROM (((((({OrderDistributionConfig} \"enorderdistributionconfig1\" Left JOIN {Region} \"enregion17\" ON (\"enorderdistributionconfig1\".\"regionid\" = \"enregion17\".\"id\"))  Left JOIN {TelcelDirection} \"entelceldirection6\" ON (\"enorderdistributionconfig1\".\"directionid\" = \"entelceldirection6\".\"id\"))  Left JOIN {EntraRole} \"enfirstcontactentrarole\" ON (\"enorderdistributionconfig1\".\"firstcontact_entraroleid\" = \"enfirstcontactentrarole\".\"id\"))  Left JOIN {EntraRole} \"ensecondcontactentrarole\" ON (\"enorderdistributionconfig1\".\"secondcontact_entraroleid\" = \"ensecondcontactentrarole\".\"id\"))  Left JOIN {EntraRole} \"enfirstapproverentrarole\" ON (\"enorderdistributionconfig1\".\"firstapprover_entraroleid\" = \"enfirstapproverentrarole\".\"id\"))  Left JOIN {EntraRole} \"ensecondapproverentrarole\" ON (\"enorderdistributionconfig1\".\"secondapprover_entraroleid\" = \"ensecondapproverentrarole\".\"id\")) ");
whereBuilder.Append(" WHERE ((CASE WHEN (@qpini_TabNumber = 0) THEN (CASE WHEN (@qpori_OrderId <> 0) THEN (CASE WHEN (((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) = '00') OR ((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) = '09')) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) = '00') THEN 1 ELSE 0 END) END) ELSE (CASE WHEN (@qpini_TabNumber = 2) THEN (CASE WHEN ((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) = '09') THEN 1 ELSE 0 END) ELSE (CASE WHEN (((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) <> '00') AND ((substring(\"enregion17\".\"code\" from (2) + 1 for 2)) <> '09')) THEN 1 ELSE 0 END) END) END) = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpini_TabNumber", DbType.Int32, qpini_TabNumber);
sqlCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
if (qptei_OrderDistributionConfig_Applicant != "" && qptei_OrderDistributionConfig_Applicant != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdistributionconfig1\".\"applicant\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Applicant) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderDistributionConfig_Applicant", DbType.String, qptei_OrderDistributionConfig_Applicant);
}
if (qptei_OrderDistributionConfig_ApplicantDescription != "" && qptei_OrderDistributionConfig_ApplicantDescription != "") {
whereBuilder.Append("(caseaccent_normalize(\"enorderdistributionconfig1\".\"applicantdescription\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_ApplicantDescription) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderDistributionConfig_ApplicantDescription", DbType.String, qptei_OrderDistributionConfig_ApplicantDescription);
}
if (qptei_OrderDistributionConfig_Direction != "" && qptei_OrderDistributionConfig_Direction != "") {
whereBuilder.Append("(caseaccent_normalize(\"entelceldirection6\".\"name\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Direction) || '%') collate \"default\")) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderDistributionConfig_Direction", DbType.String, qptei_OrderDistributionConfig_Direction);
}
if (qptei_OrderDistributionConfig_Division != "") {
whereBuilder.Append("((CASE WHEN ((@qpori_OrderId <> 0) AND ((substring(@qptei_OrderDistributionConfig_Division from (2) + 1 for 2)) = '00')) THEN (CASE WHEN (((substring(\"enregion17\".\"divisionfi\" from (2) + 1 for 2)) = '00') OR ((substring(\"enregion17\".\"divisionfi\" from (2) + 1 for 2)) = '09')) THEN 1 ELSE 0 END) ELSE (CASE WHEN ((substring(\"enregion17\".\"divisionfi\" from (2) + 1 for 2)) = (substring(@qptei_OrderDistributionConfig_Division from (2) + 1 for 2))) THEN 1 ELSE 0 END) END) = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpori_OrderId", DbType.Int64, qpori_OrderId);
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderDistributionConfig_Division", DbType.String, qptei_OrderDistributionConfig_Division);
}
if (qptei_OrderDistributionConfig_Role != "" && qptei_OrderDistributionConfig_Role != "" && qptei_OrderDistributionConfig_Role != "" && qptei_OrderDistributionConfig_Role != "" && qptei_OrderDistributionConfig_Role != "") {
whereBuilder.Append("((((caseaccent_normalize(\"enfirstapproverentrarole\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Role) || '%') collate \"default\")) OR (caseaccent_normalize(\"ensecondapproverentrarole\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Role) || '%') collate \"default\"))) OR (caseaccent_normalize(\"enfirstcontactentrarole\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Role) || '%') collate \"default\"))) OR (caseaccent_normalize(\"ensecondcontactentrarole\".\"rolename\" collate \"default\") like caseaccent_normalize((('%' || @qptei_OrderDistributionConfig_Role) || '%') collate \"default\")))");
sqlCmd.CreateParameterWithoutReplacements("@qptei_OrderDistributionConfig_Role", DbType.String, qptei_OrderDistributionConfig_Role);
}
string whereBuilderString = whereBuilder.ToString();
if (whereBuilderString.EndsWith(" AND ")) {
whereBuilder.Remove(whereBuilderString.Length - 5, 5);
}
orderByBuilder.Append(" ORDER BY ");
List<string> orderByColumns = new List<string>();
orderByColumns.Add("\"enregion17\".\"code\" DESC ");
orderByColumns.AddRange(BaseAppUtils.ReplaceEntityReferencesAndAttributesInOrderBy(DatabaseAccess.ForRuntimeDatabase.DatabaseServices.DMLService.Identifiers, qptei_TableSort, new string[] { "OrderDistributionConfig", "TelcelDirection", "FirstContactEntraRole", "SecondContactEntraRole", "Region", "SecondApproverEntraRole", "FirstApproverEntraRole" }, new string[] { "ENOrderDistributionConfig1", "ENTelcelDirection6", "ENFirstContactEntraRole", "ENSecondContactEntraRole", "ENRegion17", "ENSecondApproverEntraRole", "ENFirstApproverEntraRole" }, new System.Collections.Generic.Dictionary<string, string>[] { ENOrderDistributionConfigEntity.AttributesToDatabaseNamesMap(), ENTelcelDirectionEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENRegionEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap(), ENEntraRoleEntity.AttributesToDatabaseNamesMap() }).Split(','));
orderByBuilder.Append(BaseAppUtils.GetOrderByColumnsWithoutDuplicates(orderByColumns));
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
RL_fad66e2f0a5803b0832cea3f3e9146e2 outParamList = new RL_fad66e2f0a5803b0832cea3f3e9146e2();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderDistributionConfigReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, true, false, false, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, false, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query ExportOrderDistributionConfig.GetOrderDistributionConfig.List", cancellationToken: cancellationToken);
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
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query ExportOrderDistributionConfig.GetOrderDistributionConfig.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_fad66e2f0a5803b0832cea3f3e9146e2)_tmp;
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


/// <summary>
/// RecordList To Excel: RLToExcelExportOrderDistributionConfigRecordListToExcel
///  (K4obOaRZbfUCUJYpgG8tboQ) of Action "ExportOrderDistributionConfig"
/// </summary>
public static async Task<byte[]> RLToExcelExportOrderDistributionConfigRecordListToExcel(IRequestContext requestContext,RL_e5599d6b39ff4d762401f24c2e9326ab ssRecordList,CancellationToken cancellationToken) {
var service = ServiceLocator.GetService<ISpreadsheetService>();
await using var excel = await service.GetWriterAsync(8, cancellationToken);

//Column headers
await excel.CreateRowAsync(0, cancellationToken);
excel.CreateCell("División");
excel.CreateCell("Solicitante");
excel.CreateCell("Descripción de la solicitante");
excel.CreateCell("Dirección");
excel.CreateCell("Primer contacto");
excel.CreateCell("Segundo contacto");
excel.CreateCell("Primer aprobador");
excel.CreateCell("Segundo aprobador");


if(!ssRecordList.Empty) {
	try {
		ssRecordList.StartIteration();
		for (int i = 1; !ssRecordList.Eof; i++) {
            await excel.CreateRowAsync(i, cancellationToken);
            excel.CreateCell(ssRecordList.CurrentRec.ssDivision);
excel.CreateCell(ssRecordList.CurrentRec.ssApplicant);
excel.CreateCell(ssRecordList.CurrentRec.ssApplicantDescription);
excel.CreateCell(ssRecordList.CurrentRec.ssDirection);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstContact);
excel.CreateCell(ssRecordList.CurrentRec.ssSecondContact);
excel.CreateCell(ssRecordList.CurrentRec.ssFirstApprover);
excel.CreateCell(ssRecordList.CurrentRec.ssSecondApprover);

            ssRecordList.Advance(); 
		}
	} finally {
		ssRecordList.EndIteration();
	}
}

return await excel.SaveAsync(cancellationToken);
}


}


}
