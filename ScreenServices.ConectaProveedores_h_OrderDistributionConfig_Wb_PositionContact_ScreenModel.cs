using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel).Namespace);

    public long inParamPositionContactId;
public string inParamLabel;
public bool inParamReadOnly;
public bool inParamShowLabelFirst;
public bool inParamAllowAddNew;
public bool inParamIsMandatory;
public bool varLcAddNew;
public bool varLcEditable;
public string varLcNewPositionContact;
public AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ScreenDataSetGetAllPositionContacts;
public AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ScreenDataSetGetPositionContactsById;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel() {
}



    public ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_ScreenModel(long inParamPositionContactId, string inParamLabel, bool inParamReadOnly, bool inParamShowLabelFirst, bool inParamAllowAddNew, bool inParamIsMandatory, bool varLcAddNew, bool varLcEditable, string varLcNewPositionContact, AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ScreenDataSetGetAllPositionContacts, AggregateRecord<RL_084ec93001d810170970c8007b50b58f> ScreenDataSetGetPositionContactsById, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"PositionContactId", "Label", "ReadOnly", "ShowLabelFirst", "AllowAddNew", "IsMandatory", "AddNew", "Editable", "NewPositionContact", "GetAllPositionContacts", "GetPositionContactsById", "ClientVars"}, new string[] {"inParamPositionContactId", "inParamLabel", "inParamReadOnly", "inParamShowLabelFirst", "inParamAllowAddNew", "inParamIsMandatory", "varLcAddNew", "varLcEditable", "varLcNewPositionContact", "ScreenDataSetGetAllPositionContacts", "ScreenDataSetGetPositionContactsById", "clientVariables"});
this.inParamPositionContactId = inParamPositionContactId;
this.inParamLabel = inParamLabel;
this.inParamReadOnly = inParamReadOnly;
this.inParamShowLabelFirst = inParamShowLabelFirst;
this.inParamAllowAddNew = inParamAllowAddNew;
this.inParamIsMandatory = inParamIsMandatory;
this.varLcAddNew = varLcAddNew;
this.varLcEditable = varLcEditable;
this.varLcNewPositionContact = varLcNewPositionContact;
this.ScreenDataSetGetAllPositionContacts = ScreenDataSetGetAllPositionContacts;
this.ScreenDataSetGetPositionContactsById = ScreenDataSetGetPositionContactsById;
this.clientVariables = clientVariables;
}



    
// Query Function "GetAllPositionContacts" DRxoO7zsDESllP52B6NUig of Action "Wb_PositionContact"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetAllPositionContacts(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.Wb_PositionContact.GetAllPositionContacts", "3b681c0d-ecbc-440c-a594-fe7607a3548a");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PositionContact","h_OrderDistributionConfig.Wb_PositionContact.GetAllPositionContacts");
// Query Iterations: Multiple
// Refresh Query E6ID_UIgTkyAAL9uQagYlA Iterations: Multiple
// Refresh Query iKa4ry4Ym0m3g4ui4m9XgA Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.NhjBtvoE8UesOj1oWf1sUA/ScreenDataSets.DRxoO7zsDESllP52B6NUig, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enentrarole55\".\"id\" o0, \"enentrarole55\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole55\"");
whereBuilder.Append(" WHERE (\"enentrarole55\".\"isareacxp\" = 1)");
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
RL_084ec93001d810170970c8007b50b58f outParamList = new RL_084ec93001d810170970c8007b50b58f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.Wb_PositionContact.GetAllPositionContacts.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_084ec93001d810170970c8007b50b58f _tmp = new RL_084ec93001d810170970c8007b50b58f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.Wb_PositionContact.GetAllPositionContacts.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_084ec93001d810170970c8007b50b58f)_tmp;
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

// Query Function "GetPositionContactsById" Hc+fYR8hv0qj1J4FIJuHyA of Action "Wb_PositionContact"
public static async Task<(RL_084ec93001d810170970c8007b50b58f,long)> datasetGetPositionContactsById(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpenId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("h_OrderDistributionConfig.Wb_PositionContact.GetPositionContactsById", "619fcf1d-211f-4abf-a3d4-9e05209b87c8");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Wb_PositionContact","h_OrderDistributionConfig.Wb_PositionContact.GetPositionContactsById");
// Query Iterations: Never
// Refresh Query Ly0Rq1V7e0ySJPiOVg3epg Iterations: Never
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
selectBuilder.Append("/* /NRWebFlows.PyjmTESRNEyPpKLcqzADEQ/NodesShownInESpaceTree.NhjBtvoE8UesOj1oWf1sUA/ScreenDataSets.Hc+fYR8hv0qj1J4FIJuHyA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"enentrarole56\".\"rolename\" o1, NULL o2, NULL o3, NULL o4, NULL o5");
fromBuilder.Append(" FROM {EntraRole} \"enentrarole56\"");
whereBuilder.Append(" WHERE ");
if (qpenId != 0) {
whereBuilder.Append("((\"enentrarole56\".\"id\" = @qpenId) AND (\"enentrarole56\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenId", DbType.Int64, qpenId);
} else {
whereBuilder.Append("(\"enentrarole56\".\"id\" IS NULL)");
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
RL_084ec93001d810170970c8007b50b58f outParamList = new RL_084ec93001d810170970c8007b50b58f();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {true, false, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query h_OrderDistributionConfig.Wb_PositionContact.GetPositionContactsById.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_084ec93001d810170970c8007b50b58f _tmp = new RL_084ec93001d810170970c8007b50b58f();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query h_OrderDistributionConfig.Wb_PositionContact.GetPositionContactsById.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_084ec93001d810170970c8007b50b58f)_tmp;
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
