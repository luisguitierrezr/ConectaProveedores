using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Reassignments_Reassignments_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Reassignments_Reassignments_ScreenModel).Namespace);

    public int varLcl_StartIndex;
public ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent;
public bool varLcl_IsSidebarOpen;
public AggregateRecord<RL_9b70977d6dab04293e9e952de2a92b65> ScreenDataSetGetReassignmentsByCreatedBy;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Reassignments_Reassignments_ScreenModel() {
}



    public ConectaProveedores_a_Reassignments_Reassignments_ScreenModel(int varLcl_StartIndex, ST_6fc999fa8f6e0055c73f2f167c4bad19Structure varLcNotifContent, bool varLcl_IsSidebarOpen, AggregateRecord<RL_9b70977d6dab04293e9e952de2a92b65> ScreenDataSetGetReassignmentsByCreatedBy, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_StartIndex", "NotifContent", "l_IsSidebarOpen", "GetReassignmentsByCreatedBy", "ClientVars"}, new string[] {"varLcl_StartIndex", "varLcNotifContent", "varLcl_IsSidebarOpen", "ScreenDataSetGetReassignmentsByCreatedBy", "clientVariables"});
this.varLcl_StartIndex = varLcl_StartIndex;
this.varLcNotifContent = varLcNotifContent;
this.varLcl_IsSidebarOpen = varLcl_IsSidebarOpen;
this.ScreenDataSetGetReassignmentsByCreatedBy = ScreenDataSetGetReassignmentsByCreatedBy;
this.clientVariables = clientVariables;
}



    
private static async Task<RC_cf466c446053e827622ddde1ad0222be> datasetGetReassignmentsByCreatedByReadDbAsync(RC_cf466c446053e827622ddde1ad0222be rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENInvoice.Read( r, ref index);
rec.ssENInvoiceApprovalLevel.Read( r, ref index);
rec.ssENReassignments.Read( r, ref index);
rec.ssENRequisition.Read( r, ref index);
rec.ssENRequisitionApprovalLevel.Read( r, ref index);
rec.ssENUserSource.Read( r, ref index);
rec.ssENUserTarget.Read( r, ref index);
return rec;
}
// Query Function "GetReassignmentsByCreatedBy" 1VOo7sTDek+ekSMHh48LRA of Action "Reassignments"
public static async Task<(RL_9b70977d6dab04293e9e952de2a92b65,long)> datasetGetReassignmentsByCreatedBy(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpusReassignments_CreatedBy,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateScreenServiceAggregateMetric("a_Reassignments.Reassignments.GetReassignmentsByCreatedBy", "eea853d5-c3c4-4f7a-9e91-2307878f0b44");
using var queryActivity = activitySource.CreateScreenAggregateQueryActivity("Reassignments","a_Reassignments.Reassignments.GetReassignmentsByCreatedBy");
// Query Iterations: Multiple
// Refresh Query L1VFVwd17kWTHj+JMGtBeg Iterations: Multiple
// Refresh Query 0c1bP14HDE+gOleFU4cYXg Iterations: Multiple
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
selectBuilder.Append("/* /NRWebFlows.Qvz9+rKa_kOxTGMcUzy7oA/NodesShownInESpaceTree.s9uYf2ZYk0eec+rQ2jUU2Q/ScreenDataSets.1VOo7sTDek+ekSMHh48LRA, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, \"eninvoice143\".\"name\" o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, NULL o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, \"eninvoiceapprovallevel43\".\"approvalstatusid\" o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44, NULL o45, NULL o46, NULL o47, NULL o48, \"enreassignments2\".\"id\" o49, NULL o50, NULL o51, \"enreassignments2\".\"requisitionid\" o52, \"enreassignments2\".\"requisitionapprovallevelid\" o53, NULL o54, NULL o55, \"enreassignments2\".\"reason\" o56, NULL o57, \"enreassignments2\".\"createdon\" o58, \"enreassignments2\".\"revokedby\" o59, \"enreassignments2\".\"revokedon\" o60, NULL o61, NULL o62, NULL o63, NULL o64, NULL o65, NULL o66, \"enrequisition127\".\"name\" o67, NULL o68, NULL o69, NULL o70, NULL o71, NULL o72, NULL o73, NULL o74, NULL o75, NULL o76, NULL o77, NULL o78, NULL o79, NULL o80, NULL o81, NULL o82, NULL o83, NULL o84, NULL o85, NULL o86, NULL o87, NULL o88, NULL o89, NULL o90, NULL o91, NULL o92, NULL o93, NULL o94, NULL o95, NULL o96, NULL o97, NULL o98, NULL o99, NULL o100, NULL o101, NULL o102, NULL o103, NULL o104, NULL o105, NULL o106, NULL o107, NULL o108, NULL o109, NULL o110, NULL o111, NULL o112, NULL o113, NULL o114, NULL o115, NULL o116, NULL o117, NULL o118, NULL o119, NULL o120, NULL o121, NULL o122, NULL o123, NULL o124, NULL o125, NULL o126, NULL o127, NULL o128, NULL o129, NULL o130, NULL o131, NULL o132, NULL o133, NULL o134, NULL o135, \"enrequisitionapprovallevel29\".\"approvalstatusid\" o136, NULL o137, NULL o138, NULL o139, NULL o140, NULL o141, NULL o142, NULL o143, NULL o144, NULL o145, NULL o146, NULL o147, NULL o148, NULL o149, NULL o150, \"enusersource\".\"name\" o151, NULL o152, NULL o153, NULL o154, NULL o155, \"enusertarget\".\"name\" o156, NULL o157, NULL o158, NULL o159");
fromBuilder.Append(" FROM (((((({Reassignments} \"enreassignments2\" Left JOIN {User} \"enusersource\" ON (\"enreassignments2\".\"sourceuserid\" = \"enusersource\".\"id\"))  Left JOIN {User} \"enusertarget\" ON (\"enreassignments2\".\"targetuserid\" = \"enusertarget\".\"id\"))  Left JOIN {Requisition} \"enrequisition127\" ON (\"enreassignments2\".\"requisitionid\" = \"enrequisition127\".\"id\"))  Left JOIN {Invoice} \"eninvoice143\" ON (\"enreassignments2\".\"invoiceid\" = \"eninvoice143\".\"id\"))  Left JOIN {InvoiceApprovalLevel} \"eninvoiceapprovallevel43\" ON (\"enreassignments2\".\"invoiceapprovallevelid\" = \"eninvoiceapprovallevel43\".\"id\"))  Left JOIN {RequisitionApprovalLevel} \"enrequisitionapprovallevel29\" ON (\"enreassignments2\".\"requisitionapprovallevelid\" = \"enrequisitionapprovallevel29\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if ((qpusReassignments_CreatedBy.Trim()!="")) {
whereBuilder.Append("((\"enreassignments2\".\"createdby\" = @qpusReassignments_CreatedBy) AND (\"enreassignments2\".\"createdby\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpusReassignments_CreatedBy", DbType.String, qpusReassignments_CreatedBy);
} else {
whereBuilder.Append("(\"enreassignments2\".\"createdby\" IS NULL)");
}
orderByBuilder.Append(" ORDER BY \"enreassignments2\".\"createdon\" DESC ");
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
RL_9b70977d6dab04293e9e952de2a92b65 outParamList = new RL_9b70977d6dab04293e9e952de2a92b65();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetReassignmentsByCreatedByReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[7];
opt[0] = new BitArray(new bool[] {true, false, true, true, true});
opt[1] = new BitArray(new bool[] {true, false, true, true, true});
opt[2] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[3] = new BitArray(new bool[] {false, true, true, false, false, true, true, false, true, false, false, false, true, true, true, true, true});
opt[4] = new BitArray(new bool[] {true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[5] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[6] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, false, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query a_Reassignments.Reassignments.GetReassignmentsByCreatedBy.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_9b70977d6dab04293e9e952de2a92b65 _tmp = new RL_9b70977d6dab04293e9e952de2a92b65();
_tmp.AlternateReadDbMethodAsync = datasetGetReassignmentsByCreatedByReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query a_Reassignments.Reassignments.GetReassignmentsByCreatedBy.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_9b70977d6dab04293e9e952de2a92b65)_tmp;
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
