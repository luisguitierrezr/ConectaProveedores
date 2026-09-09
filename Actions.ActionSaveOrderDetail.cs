namespace ssConectaProveedores;

public partial class Actions {
public class lcvSaveOrderDetail : VarsBag {
public EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain;
public EN_26f696e758428762fc617e811634d15dEntityRecord inParamOrderDetail;
public RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderMainItemList;
public RL_3d745491e03d6d19ccc0e1b33a371ccc inParamOrderFiles;
public EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamOrderAccounting;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_EstimEqualAg;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_CreditNote;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Voucher;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Finiquito;
public RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Anticipo;
public RL_9d3b4c4e80b371ac0dc01854afca347a inParamOrderRequestFiles;
public bool inParamIsFinish;
public Actions.lcoOrderAccountingCreateOrUpdate resOrderAccountingCreateOrUpdate =  new Actions.lcoOrderAccountingCreateOrUpdate();
public Actions.lcoApprovRejectOrder resApprovRejectOrder =  new Actions.lcoApprovRejectOrder();
public Actions.lcoOrderLogAdd resOrderLogAdd3 =  new Actions.lcoOrderLogAdd();
public RL_3c2483fef931c35c62e6128a52ac9903 queryResGetOrderApprovalLevelIsComplement_outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
public long queryResGetOrderApprovalLevelIsComplement_outParamCount = 0L;

public Actions.lcoOrderMainItemCreateOrUpdate resOrderMainItemCreateOrUpdate =  new Actions.lcoOrderMainItemCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public Actions.lcoSaveOrderFiles resSaveOrderFiles =  new Actions.lcoSaveOrderFiles();
public Actions.lcoOrderMainCreateOrUpdate resOrderMainCreateOrUpdate =  new Actions.lcoOrderMainCreateOrUpdate();
public Actions.lcoOrderLogAdd resOrderLogAdd2 =  new Actions.lcoOrderLogAdd();
public Actions.lcoSaveOrderAccConcepts resSaveOrderAccConcepts =  new Actions.lcoSaveOrderAccConcepts();
public Actions.lcoOrderDetailCreateOrUpdate resOrderDetailCreateOrUpdate =  new Actions.lcoOrderDetailCreateOrUpdate();
public lcvSaveOrderDetail(EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain, EN_26f696e758428762fc617e811634d15dEntityRecord inParamOrderDetail, RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderMainItemList, RL_3d745491e03d6d19ccc0e1b33a371ccc inParamOrderFiles, EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamOrderAccounting, RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_EstimEqualAg, RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_CreditNote, RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Voucher, RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Finiquito, RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Anticipo, RL_9d3b4c4e80b371ac0dc01854afca347a inParamOrderRequestFiles, bool inParamIsFinish) {
this.inParamOrderMain = inParamOrderMain;
this.inParamOrderDetail = inParamOrderDetail;
this.inParamOrderMainItemList = inParamOrderMainItemList;
this.inParamOrderFiles = inParamOrderFiles;
this.inParamOrderAccounting = inParamOrderAccounting;
this.inParamOrderAccConcept_EstimEqualAg = inParamOrderAccConcept_EstimEqualAg;
this.inParamOrderAccConcept_CreditNote = inParamOrderAccConcept_CreditNote;
this.inParamOrderAccConcept_Voucher = inParamOrderAccConcept_Voucher;
this.inParamOrderAccConcept_Finiquito = inParamOrderAccConcept_Finiquito;
this.inParamOrderAccConcept_Anticipo = inParamOrderAccConcept_Anticipo;
this.inParamOrderRequestFiles = inParamOrderRequestFiles;
this.inParamIsFinish = inParamIsFinish;
}
}
public class lcoSaveOrderDetail : VarsBag {
public string outParamErrorMsg = "";

public lcoSaveOrderDetail() {
}
}
/// <summary>
/// Action <code>SaveOrderDetail</code> that represents the Service Studio action
///  <code>SaveOrderDetail</code> <p> Description: Save Order Complete data</p>
/// </summary>
public static async Task<string> ActionSaveOrderDetail(IRequestContext requestContext,EN_60ac8edd9cebe2b65e0fbac94d8f3554EntityRecord inParamOrderMain,EN_26f696e758428762fc617e811634d15dEntityRecord inParamOrderDetail,RL_36053b0a011ac5d2d2fe088489de85e6 inParamOrderMainItemList,RL_3d745491e03d6d19ccc0e1b33a371ccc inParamOrderFiles,EN_8c7f7609e4f1bd7b3e09bb763d792390EntityRecord inParamOrderAccounting,RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_EstimEqualAg,RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_CreditNote,RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Voucher,RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Finiquito,RC_dd1ef552e394be88b7a9660ce51d9447 inParamOrderAccConcept_Anticipo,RL_9d3b4c4e80b371ac0dc01854afca347a inParamOrderRequestFiles,bool inParamIsFinish,CancellationToken cancellationToken) {
string outParamErrorMsg = default;
lcoSaveOrderDetail result = new lcoSaveOrderDetail();
lcvSaveOrderDetail localVars = new lcvSaveOrderDetail(inParamOrderMain, inParamOrderDetail, inParamOrderMainItemList, inParamOrderFiles, inParamOrderAccounting, inParamOrderAccConcept_EstimEqualAg, inParamOrderAccConcept_CreditNote, inParamOrderAccConcept_Voucher, inParamOrderAccConcept_Finiquito, inParamOrderAccConcept_Anticipo, inParamOrderRequestFiles, inParamIsFinish);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("SaveOrderDetail", "ba84f7cd-e8b0-45d8-abff-3522d8c21e17"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("SaveOrderDetail", "ba84f7cd-e8b0-45d8-abff-3522d8c21e17", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// OrderMainCreateOrUpdate
(localVars.resOrderMainCreateOrUpdate.outParamId,localVars.resOrderMainCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainCreateOrUpdate.outParamErrorMessage,localVars.resOrderMainCreateOrUpdate.outParamSource_Out) = await Actions.ActionOrderMainCreateOrUpdate(requestContext,localVars.inParamOrderMain,cancellationToken);

// OrderMain = OrderMainCreateOrUpdate.Source_Out
localVars.inParamOrderMain=localVars.resOrderMainCreateOrUpdate.outParamSource_Out;

// OrderDetail.OrderId = OrderMainCreateOrUpdate.Id
localVars.inParamOrderDetail.ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId;
// OrderDetailCreateOrUpdate
(localVars.resOrderDetailCreateOrUpdate.outParamId,localVars.resOrderDetailCreateOrUpdate.outParamHasSuccess,localVars.resOrderDetailCreateOrUpdate.outParamErrorMessage) = await Actions.ActionOrderDetailCreateOrUpdate(requestContext,localVars.inParamOrderDetail,cancellationToken);

// Foreach OrderMainItemList
localVars.inParamOrderMainItemList.StartIteration();
try {while (!((localVars.inParamOrderMainItemList.Eof))) {
// OrderMainItemCreateOrUpdate
(localVars.resOrderMainItemCreateOrUpdate.outParamId,localVars.resOrderMainItemCreateOrUpdate.outParamHasSuccess,localVars.resOrderMainItemCreateOrUpdate.outParamErrorMessage) = await Actions.ActionOrderMainItemCreateOrUpdate(requestContext,localVars.inParamOrderMainItemList.CurrentRec,cancellationToken);

localVars.inParamOrderMainItemList.Advance();
}

} finally {
localVars.inParamOrderMainItemList.EndIteration();
}

// SaveOrderFiles
localVars.resSaveOrderFiles.outParamErrorMsg = await Actions.ActionSaveOrderFiles(requestContext,localVars.resOrderMainCreateOrUpdate.outParamId,new RC_b64b49f04ca283a60f06aecf635b2100(){ ssRLAllFiles = localVars.inParamOrderFiles, ssENOrderDetail = localVars.inParamOrderDetail, ssENOrdersConcept = localVars.inParamOrderMain },cancellationToken);

// SaveOrderRequestFiles
await Actions.ActionSaveOrderRequestFiles(requestContext,localVars.inParamOrderMain.ssId,localVars.inParamOrderRequestFiles,cancellationToken);

// error?
if(((localVars.resSaveOrderFiles.outParamErrorMsg!=""))) {
// ErrorMsg = SaveOrderFiles.ErrorMsg
result.outParamErrorMsg=localVars.resSaveOrderFiles.outParamErrorMsg;
} else {
// NullOrderAccounting
if(((localVars.inParamOrderAccounting.ssId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// OrderAccounting.OrderId = OrderMain.Id
localVars.inParamOrderAccounting.ssOrderId = localVars.inParamOrderMain.ssId;
}

// OrderAccountingCreateOrUpdate
localVars.resOrderAccountingCreateOrUpdate.outParamId = await Actions.ActionOrderAccountingCreateOrUpdate(requestContext,localVars.inParamOrderAccounting,cancellationToken);

// MainAccConcepts OrderAccountingId
// OrderAccConcept_EstimEqualAg.MainAccConcepts.OrderAccountingId = OrderAccountingCreateOrUpdate.Id
localVars.inParamOrderAccConcept_EstimEqualAg.ssENMainAccConcepts.ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId;

// OrderAccConcept_CreditNote.MainAccConcepts.OrderAccountingId = OrderAccountingCreateOrUpdate.Id
localVars.inParamOrderAccConcept_CreditNote.ssENMainAccConcepts.ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId;

// OrderAccConcept_Voucher.MainAccConcepts.OrderAccountingId = OrderAccountingCreateOrUpdate.Id
localVars.inParamOrderAccConcept_Voucher.ssENMainAccConcepts.ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId;

// OrderAccConcept_Finiquito.MainAccConcepts.OrderAccountingId = OrderAccountingCreateOrUpdate.Id
localVars.inParamOrderAccConcept_Finiquito.ssENMainAccConcepts.ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId;

// OrderAccConcept_Anticipo.MainAccConcepts.OrderAccountingId = OrderAccountingCreateOrUpdate.Id
localVars.inParamOrderAccConcept_Anticipo.ssENMainAccConcepts.ssOrderAccountingId = localVars.resOrderAccountingCreateOrUpdate.outParamId;
// SaveOrderAccConcepts
(localVars.resSaveOrderAccConcepts.outParamErrorMsg,localVars.resSaveOrderAccConcepts.outParamWithError,localVars.resSaveOrderAccConcepts.outParamIsEstimEqualAgEmpty,localVars.resSaveOrderAccConcepts.outParamIsFiniquitoEmpty) = await Actions.ActionSaveOrderAccConcepts(requestContext,localVars.resOrderMainCreateOrUpdate.outParamId,localVars.inParamOrderAccConcept_EstimEqualAg,localVars.inParamOrderAccConcept_CreditNote,localVars.inParamOrderAccConcept_Voucher,localVars.inParamOrderAccConcept_Finiquito,localVars.inParamOrderAccConcept_Anticipo,cancellationToken);

// error?
if((((localVars.resSaveOrderAccConcepts.outParamWithError||(localVars.resSaveOrderAccConcepts.outParamIsEstimEqualAgEmpty&&localVars.resSaveOrderAccConcepts.outParamIsFiniquitoEmpty))&&localVars.inParamIsFinish))) {
// RaiseError ErrorSaving
throw new Ex_ErrorSavingUserException (AppUtils.GetStringResource("kkgFAUqODE67hIn94LM3wQ#Message.-246665552.1", "You need to select at least one payment. You need at least one payment of Estimation/Equalization/AgreedPayments or Settlement."));

} else {
// CommitTransaction
await ExtendedActions.CommitTransaction(requestContext,cancellationToken);

// IsFinish?
if((localVars.inParamIsFinish)) {
// OrderMainValidateAllFilesApproved
await Actions.ActionOrderMainValidateAllFilesApproved(requestContext,localVars.inParamOrderMain.ssId,cancellationToken);

// Query datasetGetOrderApprovalLevelIsComplement
cancellationToken.ThrowIfCancellationRequested();
int datasetGetOrderApprovalLevelIsComplement_maxRecords = 1;
if (datasetGetOrderApprovalLevelIsComplement_maxRecords < 1) datasetGetOrderApprovalLevelIsComplement_maxRecords = 1;
int datasetGetOrderApprovalLevelIsComplement_startIndex = 0;(localVars.queryResGetOrderApprovalLevelIsComplement_outParamList,localVars.queryResGetOrderApprovalLevelIsComplement_outParamCount) = await FuncActionSaveOrderDetail.datasetGetOrderApprovalLevelIsComplement(requestContext,datasetGetOrderApprovalLevelIsComplement_maxRecords,datasetGetOrderApprovalLevelIsComplement_startIndex,IterationMultiplicity.Never,localVars.inParamOrderMain.ssId,cancellationToken);

// ApprovRejectOrder
localVars.resApprovRejectOrder.outParamo_Output = await Actions.ActionApprovRejectOrder(requestContext,localVars.inParamOrderMain.ssId,localVars.queryResGetOrderApprovalLevelIsComplement_outParamList.CurrentRec.ssENOrderApprovalLevel.ssId,true,"",cancellationToken);

// IsSuccess?
if((localVars.resApprovRejectOrder.outParamo_Output.ssIsSuccess)) {
// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId, ssMessage = (((localVars.inParamOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId)) ? ((((((AppUtils.GetStringResource("DS01AXDDwUWp0L2sRn2oAg#Value.76453678.1", "Order")+" ")+localVars.inParamOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("DS01AXDDwUWp0L2sRn2oAg#Value.471966874.1", "reinitiated approval process"))+".")) : ((((((AppUtils.GetStringResource("DS01AXDDwUWp0L2sRn2oAg#Value.76453678.2", "Order")+" ")+localVars.inParamOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("DS01AXDDwUWp0L2sRn2oAg#Value.1108394023.1", "initiated approval process"))+"."))) },cancellationToken);

} else {
// OrderLogAdd2
localVars.resOrderLogAdd2.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId, ssMessage = (((localVars.inParamOrderMain.ssOrderStatusId==(ENOrderStatusEntity.GetRecordByKey(ObjectKey.Parse("tHv4kUvgmkqPOOg5tKJOyQ"))).ssId)) ? (((((((AppUtils.GetStringResource("GzsPNWQgf06e5FePg2DalA#Value.76453678.1", "Order")+" ")+localVars.inParamOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("GzsPNWQgf06e5FePg2DalA#Value.1728822957.1", "failed to reinitialize approval process"))+": ")+localVars.resApprovRejectOrder.outParamo_Output.ssMessage)) : (((((((AppUtils.GetStringResource("GzsPNWQgf06e5FePg2DalA#Value.76453678.2", "Order")+" ")+localVars.inParamOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("GzsPNWQgf06e5FePg2DalA#Value.-2084854720.1", "failed to initialize approval process"))+": ")+localVars.resApprovRejectOrder.outParamo_Output.ssMessage))) },cancellationToken);

// ErrorMsg = ApprovRejectOrder.o_Output.Message
result.outParamErrorMsg=localVars.resApprovRejectOrder.outParamo_Output.ssMessage;
}

} else {
// OrderLogAdd3
localVars.resOrderLogAdd3.outParamId = await Actions.ActionOrderLogAdd(requestContext,new EN_a8e484428097204171df8a1feecb2534EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssOrderId = localVars.resOrderMainCreateOrUpdate.outParamId, ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssMessage = (((((AppUtils.GetStringResource("aE9UeLct4kKWxVegSBFXwQ#Value.76453678.1", "Order")+" ")+localVars.inParamOrderMain.ssOrderNumber)+" ")+AppUtils.GetStringResource("aE9UeLct4kKWxVegSBFXwQ#Value.1660323562.1", "changes saved"))+".") },cancellationToken);

}

}

}

} //close CreateActionActivity using block
} // try

catch (Exception ex) {
ApplicationLogger.Error(ex, "Error executing action");
requestContext.LastException = ex;

// Error Handler
await DatabaseAccess.RollbackAllTransactionsAsync(cancellationToken);

// ErrorMsg = AllExceptions.ExceptionMessage
result.outParamErrorMsg=ex.Message;
goto RETURN_STATEMENT;

} // Catch
finally {
outParamErrorMsg = result.outParamErrorMsg;
cancellationToken.ThrowIfCancellationRequested();
} // inner-finally
RETURN_STATEMENT:
return outParamErrorMsg;
}

public static class FuncActionSaveOrderDetail {

private static async Task<RC_2929b54077988f623db253f22a62f498> datasetGetOrderApprovalLevelIsComplementReadDbAsync(RC_2929b54077988f623db253f22a62f498 rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENOrderApproval.Read( r, ref index);
rec.ssENOrderApprovalLevel.Read( r, ref index);
return rec;
}
// Query Function "GetOrderApprovalLevelIsComplement" ljA8VpgWG0ypk+ANybRAwg of Action "SaveOrderDetail"
public static async Task<(RL_3c2483fef931c35c62e6128a52ac9903,long)> datasetGetOrderApprovalLevelIsComplement(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qporOrderApproval_OrderId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("SaveOrderDetail.GetOrderApprovalLevelIsComplement", "563c3096-1698-4c1b-a993-e00dc9b440c2");
using var queryActivity = activitySource.CreateAggregateQueryActivity("SaveOrderDetail.GetOrderApprovalLevelIsComplement", "563c3096-1698-4c1b-a993-e00dc9b440c2", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
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
selectBuilder.Append("/* /UserActions.zfeEurDo2EWr_zUi2MIeFw/NodesNotShownInESpaceTree.ljA8VpgWG0ypk+ANybRAwg, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT NULL o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enorderapprovallevel13\".\"id\" o8, NULL o9, NULL o10, NULL o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24");
fromBuilder.Append(" FROM ({OrderApprovalLevel} \"enorderapprovallevel13\" Left JOIN {OrderApproval} \"enorderapproval14\" ON (\"enorderapprovallevel13\".\"orderapprovalid\" = \"enorderapproval14\".\"id\")) ");
whereBuilder.Append(" WHERE (\"enorderapprovallevel13\".\"iscomplement\" = 1) AND ");
if (qporOrderApproval_OrderId != 0) {
whereBuilder.Append("((\"enorderapproval14\".\"orderid\" = @qporOrderApproval_OrderId) AND (\"enorderapproval14\".\"orderid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qporOrderApproval_OrderId", DbType.Int64, qporOrderApproval_OrderId);
} else {
whereBuilder.Append("(\"enorderapproval14\".\"orderid\" IS NULL)");
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
RL_3c2483fef931c35c62e6128a52ac9903 outParamList = new RL_3c2483fef931c35c62e6128a52ac9903();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelIsComplementReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query SaveOrderDetail.GetOrderApprovalLevelIsComplement.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_3c2483fef931c35c62e6128a52ac9903 _tmp = new RL_3c2483fef931c35c62e6128a52ac9903();
_tmp.AlternateReadDbMethodAsync = datasetGetOrderApprovalLevelIsComplementReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query SaveOrderDetail.GetOrderApprovalLevelIsComplement.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_3c2483fef931c35c62e6128a52ac9903)_tmp;
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
