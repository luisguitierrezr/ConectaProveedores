using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel).Namespace);

    public bool inParamHasFixedHeader;
public bool inParamEnableAccessibilityFeatures;
public string inParamExtendedClass;
public ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetUserData_Model varLcGetUserData;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel() {
}



    public ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel(bool inParamHasFixedHeader, bool inParamEnableAccessibilityFeatures, string inParamExtendedClass, ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_a_Layouts_LayoutHomepage_DataActionGetUserData_Model varLcGetUserData, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"HasFixedHeader", "EnableAccessibilityFeatures", "ExtendedClass", "GetSettings", "GetUserData", "ClientVars"}, new string[] {"inParamHasFixedHeader", "inParamEnableAccessibilityFeatures", "inParamExtendedClass", "varLcGetSettings", "varLcGetUserData", "clientVariables"});
this.inParamHasFixedHeader = inParamHasFixedHeader;
this.inParamEnableAccessibilityFeatures = inParamEnableAccessibilityFeatures;
this.inParamExtendedClass = inParamExtendedClass;
this.varLcGetSettings = varLcGetSettings;
this.varLcGetUserData = varLcGetUserData;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettings : VarsBag {
public bool outParamo_IsDevEnvironment = false;

public string outParamo_Environment = "";

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: Query to get settings.</p>
/// </summary>
public async Task<(bool,string)> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsDevEnvironment = default;
string outParamo_Environment = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "1628774d-6221-4b08-939e-f0b838637e22"))
using (activitySource.CreateScreenDataActionActivity("LayoutHomepage", "GetSettings")){
// o_IsDevEnvironment = IsDevEnvironment
result.outParamo_IsDevEnvironment=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment])));
// o_Environment = Environment
result.outParamo_Environment=((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsDevEnvironment = result.outParamo_IsDevEnvironment;
outParamo_Environment = result.outParamo_Environment;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_IsDevEnvironment,outParamo_Environment);
}
public class lcvGetUserData : VarsBag {
public RL_5c133fac7a17cbd92cd93716fe198d4b queryResGetUserDataById_outParamList = new RL_5c133fac7a17cbd92cd93716fe198d4b();
public long queryResGetUserDataById_outParamCount = 0L;

public lcvGetUserData() {
}
}
public class lcoGetUserData : VarsBag {
public string outParamo_Region = "";

public bool outParamo_IsCXP = false;

public lcoGetUserData() {
}
}
/// <summary>
/// Action <code>GetUserData</code> that represents the Service Studio action <code>GetUserData</code>
///  <p> Description: Query to fetch User Data.</p>
/// </summary>
public async Task<(string,bool)> DataActionGetUserData(IRequestContext requestContext,CancellationToken cancellationToken) {
string outParamo_Region = default;
bool outParamo_IsCXP = default;
lcoGetUserData result = new lcoGetUserData();
lcvGetUserData localVars = new lcvGetUserData();
ConectaProveedores_a_Layouts_LayoutHomepage_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetUserData", "c662f5a9-f166-48f3-9aea-02b623a49f07"))
using (activitySource.CreateScreenDataActionActivity("LayoutHomepage", "GetUserData")){
// Query datasetGetUserDataById
cancellationToken.ThrowIfCancellationRequested();
int datasetGetUserDataById_maxRecords = 0;
int datasetGetUserDataById_startIndex = 0;(localVars.queryResGetUserDataById_outParamList,localVars.queryResGetUserDataById_outParamCount) = await FuncDataActionGetUserData.datasetGetUserDataById(requestContext,datasetGetUserDataById_maxRecords,datasetGetUserDataById_startIndex,IterationMultiplicity.Never,BuiltInFunction.GetUserId (),cancellationToken);

// o_Region = GetUserDataById.List.Current.Region.DivisionFI
result.outParamo_Region=localVars.queryResGetUserDataById_outParamList.CurrentRec.ssENRegion.ssDivisionFI;

// o_IsCXP = GetUserDataById.List.Current.ApplicationRole.IsAreaCxP
result.outParamo_IsCXP=localVars.queryResGetUserDataById_outParamList.CurrentRec.ssENApplicationRole.ssIsAreaCxP;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Region = result.outParamo_Region;
outParamo_IsCXP = result.outParamo_IsCXP;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_Region,outParamo_IsCXP);
}


    public static class FuncDataActionGetSettings {
}
public static class FuncDataActionGetUserData {

private static async Task<RC_407f3f6863feafe144ff5ca8c500a81b> datasetGetUserDataByIdReadDbAsync(RC_407f3f6863feafe144ff5ca8c500a81b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUserDataById" 0Zhu9zBb_kKDW3YuVRH57g of Action "GetUserData"
public static async Task<(RL_5c133fac7a17cbd92cd93716fe198d4b,long)> datasetGetUserDataById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusUser_Extended_Internal_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("a_Layouts.LayoutHomepage.GetUserData.GetUserDataById", "f76e98d1-5b30-42fe-835b-762e5511f9ee");
using var queryActivity = activitySource.CreateAggregateQueryActivity("a_Layouts.LayoutHomepage.GetUserData.GetUserDataById", "f76e98d1-5b30-42fe-835b-762e5511f9ee", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /NRWebFlows.4kgWaZyB_0eNKLmfv4oUtQ/NodesShownInESpaceTree.AT6_lrEcpEO+Cclc1S47MQ/DataActions.qfVixmbx80ia6gK2I6SfBw/NodesNotShownInESpaceTree.0Zhu9zBb_kKDW3YuVRH57g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, \"enregion149\".\"divisionfi\" o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49");
fromBuilder.Append(" FROM ((({User_Extended_Internal} \"enuser_extended_internal122\" Inner JOIN {Region} \"enregion149\" ON (\"enuser_extended_internal122\".\"regionid\" = \"enregion149\".\"id\"))  Left JOIN {UserApplicationRole} \"enuserapplicationrole23\" ON (\"enuser_extended_internal122\".\"id\" = \"enuserapplicationrole23\".\"userid\"))  Left JOIN {ApplicationRole} \"enapplicationrole71\" ON (\"enuserapplicationrole23\".\"applicationroleid\" = \"enapplicationrole71\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusUser_Extended_Internal_Id.Trim()!="")) {
whereBuilder.Append("((\"enuser_extended_internal122\".\"id\" = @qpusUser_Extended_Internal_Id) AND (\"enuser_extended_internal122\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusUser_Extended_Internal_Id", DbType.String, qpusUser_Extended_Internal_Id);
} else {
whereBuilder.Append("(\"enuser_extended_internal122\".\"id\" IS NULL)");
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
RL_5c133fac7a17cbd92cd93716fe198d4b outParamList = new RL_5c133fac7a17cbd92cd93716fe198d4b();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserDataByIdReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[4];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, false, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Layouts.LayoutHomepage.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5c133fac7a17cbd92cd93716fe198d4b _tmp = new RL_5c133fac7a17cbd92cd93716fe198d4b();
_tmp.AlternateReadDbMethodAsync = datasetGetUserDataByIdReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Layouts.LayoutHomepage.GetUserData.GetUserDataById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5c133fac7a17cbd92cd93716fe198d4b)_tmp;
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
