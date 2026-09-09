using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_Login_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_Login_ScreenModel).Namespace);

    public bool inParamIsResetPassword;
public string varLcUserEmail;
public string varLcPassword;
public bool varLcIsExecuting;
public bool varLcMakePasswordVisible;
public bool varLcRememberMe;
public bool varLcIsEnabled;
public bool varLcShowSelectUserPopup;
public int varLcStep;
public string varLcUserCode;
public bool varLcIsEnabledCode;
public bool varLcIsExecutingCodeRequest;
public string varLcUserExternalEmail;
public string varLcRegionToBeAssign;
public string varLcMsg;
public AggregateRecord<RL_e8fb9c349f962da0bba19bd202a05712> ScreenDataSetGetUserExtendedInternals;
public ConectaProveedores_a_Common_Login_DataActionGet2FA_Model varLcGet2FA;
public ConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_Login_ScreenModel() {
}



    public ConectaProveedores_a_Common_Login_ScreenModel(bool inParamIsResetPassword, string varLcUserEmail, string varLcPassword, bool varLcIsExecuting, bool varLcMakePasswordVisible, bool varLcRememberMe, bool varLcIsEnabled, bool varLcShowSelectUserPopup, int varLcStep, string varLcUserCode, bool varLcIsEnabledCode, bool varLcIsExecutingCodeRequest, string varLcUserExternalEmail, string varLcRegionToBeAssign, string varLcMsg, AggregateRecord<RL_e8fb9c349f962da0bba19bd202a05712> ScreenDataSetGetUserExtendedInternals, ConectaProveedores_a_Common_Login_DataActionGet2FA_Model varLcGet2FA, ConectaProveedores_a_Common_Login_DataActionGetSettingsEnviroment_Model varLcGetSettingsEnviroment, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"IsResetPassword", "UserEmail", "Password", "IsExecuting", "MakePasswordVisible", "RememberMe", "IsEnabled", "ShowSelectUserPopup", "Step", "UserCode", "IsEnabledCode", "IsExecutingCodeRequest", "UserExternalEmail", "RegionToBeAssign", "Msg", "GetUserExtendedInternals", "Get2FA", "GetSettingsEnviroment", "ClientVars"}, new string[] {"inParamIsResetPassword", "varLcUserEmail", "varLcPassword", "varLcIsExecuting", "varLcMakePasswordVisible", "varLcRememberMe", "varLcIsEnabled", "varLcShowSelectUserPopup", "varLcStep", "varLcUserCode", "varLcIsEnabledCode", "varLcIsExecutingCodeRequest", "varLcUserExternalEmail", "varLcRegionToBeAssign", "varLcMsg", "ScreenDataSetGetUserExtendedInternals", "varLcGet2FA", "varLcGetSettingsEnviroment", "clientVariables"});
this.inParamIsResetPassword = inParamIsResetPassword;
this.varLcUserEmail = varLcUserEmail;
this.varLcPassword = varLcPassword;
this.varLcIsExecuting = varLcIsExecuting;
this.varLcMakePasswordVisible = varLcMakePasswordVisible;
this.varLcRememberMe = varLcRememberMe;
this.varLcIsEnabled = varLcIsEnabled;
this.varLcShowSelectUserPopup = varLcShowSelectUserPopup;
this.varLcStep = varLcStep;
this.varLcUserCode = varLcUserCode;
this.varLcIsEnabledCode = varLcIsEnabledCode;
this.varLcIsExecutingCodeRequest = varLcIsExecutingCodeRequest;
this.varLcUserExternalEmail = varLcUserExternalEmail;
this.varLcRegionToBeAssign = varLcRegionToBeAssign;
this.varLcMsg = varLcMsg;
this.ScreenDataSetGetUserExtendedInternals = ScreenDataSetGetUserExtendedInternals;
this.varLcGet2FA = varLcGet2FA;
this.varLcGetSettingsEnviroment = varLcGetSettingsEnviroment;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_82a9276cec67a3d539884db9fd67d1e2> datasetGetUserExtendedInternalsReadDbAsync(RC_82a9276cec67a3d539884db9fd67d1e2 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApplicationRole.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
rec.ssENUser.Read( r, ref index);
rec.ssENUser_Extended_Internal.Read( r, ref index);
rec.ssENUserApplicationRole.Read( r, ref index);
return rec;
}
// Query Function "GetUserExtendedInternals" TcgWnWZwgUesZw9xJ+thig of Action "Login"
public static async Task<(RL_e8fb9c349f962da0bba19bd202a05712,long)> datasetGetUserExtendedInternals(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Common.Login.GetUserExtendedInternals", "9d16c84d-7066-4781-ac67-0f7127eb618a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Login","a_Common.Login.GetUserExtendedInternals");
// Query Iterations: Multiple
// Refresh Query PIM1hXS6QU6y2+XP_5Bm0g Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.B4kRGvrnOEmQonA8ir4Pyg/NodesShownInESpaceTree.Me5vGA6JQE6fU_zQUXZ4zA/ScreenDataSets.TcgWnWZwgUesZw9xJ+thig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, \"enapplicationrole44\".\"name\" o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, \"enregion84\".\"commissionregion\" o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, \"enuser152\".\"name\" o21, \"enuser152\".\"email\" o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, NULL o49, NULL o50, NULL o51, NULL o52, NULL o53, NULL o54");
fromBuilder.Append(" FROM (((({User_Extended_Internal} \"enuser_extended_internal92\" Inner JOIN {User} \"enuser152\" ON (\"enuser_extended_internal92\".\"id\" = \"enuser152\".\"id\"))  Left JOIN {Region} \"enregion84\" ON (\"enuser_extended_internal92\".\"regionid\" = \"enregion84\".\"id\"))  Inner JOIN {UserApplicationRole} \"enuserapplicationrole19\" ON (\"enuser152\".\"id\" = \"enuserapplicationrole19\".\"userid\"))  Inner JOIN {ApplicationRole} \"enapplicationrole44\" ON (\"enuserapplicationrole19\".\"applicationroleid\" = \"enapplicationrole44\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enuserapplicationrole19\".\"rolestatusid\" = ");
whereBuilder.Append(2
);
whereBuilder.Append(")");
orderByBuilder.Append(" ORDER BY \"enregion84\".\"commissionregion\" ASC , \"enuser152\".\"name\" ASC ");
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
RL_e8fb9c349f962da0bba19bd202a05712 outParamList = new RL_e8fb9c349f962da0bba19bd202a05712();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[5];
opt[0] = new BitArray(new bool[] {true, false, false, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, false, true, true, true, true});
opt[3] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, true, true, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Common.Login.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_e8fb9c349f962da0bba19bd202a05712 _tmp = new RL_e8fb9c349f962da0bba19bd202a05712();
_tmp.AlternateReadDbMethodAsync = datasetGetUserExtendedInternalsReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Common.Login.GetUserExtendedInternals.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_e8fb9c349f962da0bba19bd202a05712)_tmp;
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


    public class lcoGet2FA : VarsBag {
public bool outParamISactive = false;

public lcoGet2FA() {
}
}
/// <summary>
/// Action <code>Get2FA</code> that represents the Service Studio action <code>Get2FA</code> <p>
///  Description: </p>
/// </summary>
public async Task<bool> DataActionGet2FA(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamISactive = default;
lcoGet2FA result = new lcoGet2FA();
ConectaProveedores_a_Common_Login_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("Get2FA", "8360e4f0-063a-4aeb-8442-839db48a8434"))
using (activitySource.CreateScreenDataActionActivity("Login", "Get2FA")){
// ISactive = Active2FA
result.outParamISactive=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spActive2FA])));
} //close CreateActionActivity using block
} // try

finally {
outParamISactive = result.outParamISactive;
} // inner-finally
RETURN_STATEMENT:
return outParamISactive;
}
public class lcoGetSettingsEnviroment : VarsBag {
public bool outParamIsDevEnvironment = false;

public string outParamEnvironment = "";

public lcoGetSettingsEnviroment() {
}
}
/// <summary>
/// Action <code>GetSettingsEnviroment</code> that represents the Service Studio action
///  <code>GetSettingsEnviroment</code> <p> Description: </p>
/// </summary>
public async Task<(bool,string)> DataActionGetSettingsEnviroment(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsDevEnvironment = default;
string outParamEnvironment = default;
lcoGetSettingsEnviroment result = new lcoGetSettingsEnviroment();
ConectaProveedores_a_Common_Login_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettingsEnviroment", "a23fa804-51a4-4aba-a555-1e580be34752"))
using (activitySource.CreateScreenDataActionActivity("Login", "GetSettingsEnviroment")){
// IsDevEnvironment = IsDevEnvironment
result.outParamIsDevEnvironment=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsDevEnvironment])));
// SetEnviroment
// Environment = Environment
result.outParamEnvironment=((((string)AppUtils.SiteProperties[SitePropertiesModel.spEnvironment])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsDevEnvironment = result.outParamIsDevEnvironment;
outParamEnvironment = result.outParamEnvironment;
} // inner-finally
RETURN_STATEMENT:
return (outParamIsDevEnvironment,outParamEnvironment);
}


    public static class FuncDataActionGet2FA {
}
public static class FuncDataActionGetSettingsEnviroment {
}


}
