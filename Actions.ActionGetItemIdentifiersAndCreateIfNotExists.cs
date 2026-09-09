namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetItemIdentifiersAndCreateIfNotExists : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public bool inParamCreateIfNotExists;
public long resServiceAccountingAccounts_ServiceTypeCreateOrUpdat_outParamId = 0L;

public long resServiceDocumentTypeCreateOrUpdate_outParamId = 0L;

public RL_0a57e83422b4463daf632e7f94ace47e queryResGetItemsIdentifiers_outParamList = new RL_0a57e83422b4463daf632e7f94ace47e();
public long queryResGetItemsIdentifiers_outParamCount = 0L;

public lcvGetItemIdentifiersAndCreateIfNotExists(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data, bool inParamCreateIfNotExists) {
this.inParami_Data = inParami_Data;
this.inParamCreateIfNotExists = inParamCreateIfNotExists;
}
}
public class lcoGetItemIdentifiersAndCreateIfNotExists : VarsBag {
public RC_98e72683eb82d34cf7fcf42a642043ce outParamResult = new RC_98e72683eb82d34cf7fcf42a642043ce();

public lcoGetItemIdentifiersAndCreateIfNotExists() {
}
}
/// <summary>
/// Action <code>GetItemIdentifiersAndCreateIfNotExists</code> that represents the Service Studio
///  action <code>GetItemIdentifiersAndCreateIfNotExists</code> <p> Description: </p>
/// </summary>
public static async Task<RC_98e72683eb82d34cf7fcf42a642043ce> ActionGetItemIdentifiersAndCreateIfNotExists(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,bool inParamCreateIfNotExists,CancellationToken cancellationToken) {
RC_98e72683eb82d34cf7fcf42a642043ce outParamResult = default;
lcoGetItemIdentifiersAndCreateIfNotExists result = new lcoGetItemIdentifiersAndCreateIfNotExists();
lcvGetItemIdentifiersAndCreateIfNotExists localVars = new lcvGetItemIdentifiersAndCreateIfNotExists(inParami_Data, inParamCreateIfNotExists);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetItemIdentifiersAndCreateIfNotExists", "b55f824d-ca27-4179-99fc-e69ac875be1f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetItemIdentifiersAndCreateIfNotExists", "b55f824d-ca27-4179-99fc-e69ac875be1f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query QueryGetItemsIdentifiers
cancellationToken.ThrowIfCancellationRequested();
int QueryGetItemsIdentifiers_maxRecords = 1;
if (QueryGetItemsIdentifiers_maxRecords < 1) QueryGetItemsIdentifiers_maxRecords = 1;
int QueryGetItemsIdentifiers_startIndex = 0;(localVars.queryResGetItemsIdentifiers_outParamList,localVars.queryResGetItemsIdentifiers_outParamCount) = await FuncActionGetItemIdentifiersAndCreateIfNotExists.QueryGetItemsIdentifiers(requestContext,QueryGetItemsIdentifiers_maxRecords,QueryGetItemsIdentifiers_startIndex,IterationMultiplicity.Never,BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssDocumentClass),BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssCostCenter),BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssCenter),BuiltInFunction.TextToIdentifier (BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssUnitType))),BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssGLAccountNumber),BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssBusinessArea),cancellationToken);

// Result.CostCenterSAPId = LongIntegerToIdentifier
result.outParamResult.ssCostCenterSAPId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTCostCenterId.ssValue);

// Result.RegionId = LongIntegerToIdentifier
result.outParamResult.ssRegionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTRegionId.ssValue);

// Result.GLAccountId = LongIntegerToIdentifier
result.outParamResult.ssGLAccountId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTServiceTypeId.ssValue);

// Result.DocumentClassId = LongIntegerToIdentifier
result.outParamResult.ssDocumentClassId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTDocumentClassId.ssValue);

// Result.DivisionId = LongIntegerToIdentifier
result.outParamResult.ssDivisionId = BuiltInFunction.LongIntegerToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTDivisionId.ssValue);

// Result.CurrencyId = TextToIdentifier
result.outParamResult.ssCurrencyId = BuiltInFunction.TextToIdentifier (localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTCurrencyId.ssValue);
if((((localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTServiceTypeId.ssValue==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&localVars.inParamCreateIfNotExists))) {
// ServiceAccountingAccounts_ServiceTypeCreateOrUpdat
localVars.resServiceAccountingAccounts_ServiceTypeCreateOrUpdat_outParamId = await ServiceAPIs.ServiceAPIServiceAccountingAccounts_ServiceTypeCreateOrUpdat(requestContext,new EN_7d4692fd3a99ff3b1c123c777f28bd70EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssCC = BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssGLAccountNumber)), ssDescription = BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Data.ssOrderItems.CurrentRec.ssGLAccountNumber)), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssUpdatedBy = BuiltInFunction.GetUserId (), ssUpdatedOn = BuiltInFunction.CurrDateTime () },cancellationToken);

// Result.GLAccountId = ServiceAccountingAccounts_ServiceTypeCreateOrUpdat.Id
result.outParamResult.ssGLAccountId = localVars.resServiceAccountingAccounts_ServiceTypeCreateOrUpdat_outParamId;
}

if((((localVars.queryResGetItemsIdentifiers_outParamList.CurrentRec.ssSTDocumentClassId.ssValue==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&localVars.inParamCreateIfNotExists))) {
// ServiceDocumentTypeCreateOrUpdate
localVars.resServiceDocumentTypeCreateOrUpdate_outParamId = await ServiceAPIs.ServiceAPIServiceDocumentTypeCreateOrUpdate(requestContext,new EN_a70d553ce1458b3952d039852f258a76EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssClasse = localVars.inParami_Data.ssClassDocument, ssDescription = localVars.inParami_Data.ssClassDocument, ssCreatedOn = BuiltInFunction.CurrDateTime (), ssCreatedBy = BuiltInFunction.GetUserId (), ssUpdatedOn = BuiltInFunction.CurrDateTime (), ssUpdatedBy = BuiltInFunction.GetUserId () },cancellationToken);

// Result.DocumentClassId = ServiceDocumentTypeCreateOrUpdate.Id
result.outParamResult.ssDocumentClassId = localVars.resServiceDocumentTypeCreateOrUpdate_outParamId;
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionGetItemIdentifiersAndCreateIfNotExists {

private static async Task<RC_6238dc44386da10198e9e1b2b81cc9aa> QueryGetItemsIdentifiersReadDbAsync(RC_6238dc44386da10198e9e1b2b81cc9aa rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssSTDocumentClassId.Read(r, ref index);
rec.ssSTCostCenterId.Read(r, ref index);
rec.ssSTRegionId.Read(r, ref index);
rec.ssSTDivisionId.Read(r, ref index);
rec.ssSTCurrencyId.Read(r, ref index);
rec.ssSTServiceTypeId.Read(r, ref index);
return rec;
}
// Query Function "GetItemsIdentifiers" DAPSqVmGgUykhA6mRFIiGw of Action "GetItemIdentifiersAndCreateIfNotExists"
public static async Task<(RL_0a57e83422b4463daf632e7f94ace47e,long)> QueryGetItemsIdentifiers(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteDocumentClass,string qpteCostCenter,string qpteCenter,string qpteUnitType,string qpteGLAccount,string qpteDivision,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQuerySqlMetric("GetItemIdentifiersAndCreateIfNotExists.GetItemsIdentifiers", "a9d2030c-8659-4c81-a484-0ea64452221b");
using var queryActivity = activitySource.CreateSqlQueryActivity("GetItemIdentifiersAndCreateIfNotExists.GetItemsIdentifiers", "a9d2030c-8659-4c81-a484-0ea64452221b", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetRequestTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string entityDocumentType = AppUtils.Instance.RuntimeEntityReplace("DocumentType");
string entityCostCenterSAP = AppUtils.Instance.RuntimeEntityReplace("CostCenterSAP");
string entityRegion = AppUtils.Instance.RuntimeEntityReplace("Region");
string entityCurrency = AppUtils.Instance.RuntimeEntityReplace("Currency");
string entityAccountingAccounts_ServiceType = AppUtils.Instance.RuntimeEntityReplace("AccountingAccounts_ServiceType");
sqlCmd.CreateParameter("@qpteDocumentClass", DbType.String, qpteDocumentClass);
sqlCmd.CreateParameter("@qpteCostCenter", DbType.String, qpteCostCenter);
sqlCmd.CreateParameter("@qpteCenter", DbType.String, qpteCenter);
sqlCmd.CreateParameter("@qpteDivision", DbType.String, qpteDivision);
sqlCmd.CreateParameter("@qpteUnitType", DbType.String, qpteUnitType);
sqlCmd.CreateParameter("@qpteGLAccount", DbType.String, qpteGLAccount);
string sql = "";
string advSql = "SELECT  \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityDocumentType,".\"classe\"") + ")) = UPPER(TRIM(@qpteDocumentClass))) LIMIT 1) \"documentclassid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCostCenterSAP,".\"ce_coste\"") + ")) = UPPER(TRIM(@qpteCostCenter))) LIMIT 1) \"costcenterid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"centrortp\"") + ")) = UPPER(TRIM(@qpteCenter))) LIMIT 1) \"regionid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityRegion,".\"divisionfi\"") + ")) = UPPER(TRIM(@qpteDivision))) LIMIT 1) \"divisionid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"code\"") + ")) = UPPER(TRIM(@qpteUnitType)) and  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityCurrency,".\"isactive\"") + " = 1) LIMIT 1) \"currencyid\", \n    ((SELECT  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,".\"id\"") + " FROM  " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,"") + " WHERE UPPER(TRIM( " + AppUtils.Instance.RuntimeEntityReplaceLinkTable(entityAccountingAccounts_ServiceType,".\"cc\"") + ")) = UPPER(TRIM(@qpteGLAccount))) LIMIT 1) \"servicetypeid\"";
sql = advSql;
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_0a57e83422b4463daf632e7f94ace47e outParamList = new RL_0a57e83422b4463daf632e7f94ace47e();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = QueryGetItemsIdentifiersReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[6];
opt[0] = new BitArray(new bool[] {false});
opt[1] = new BitArray(new bool[] {false});
opt[2] = new BitArray(new bool[] {false});
opt[3] = new BitArray(new bool[] {false});
opt[4] = new BitArray(new bool[] {false});
opt[5] = new BitArray(new bool[] {false});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetItemIdentifiersAndCreateIfNotExists.GetItemsIdentifiers.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_0a57e83422b4463daf632e7f94ace47e _tmp = new RL_0a57e83422b4463daf632e7f94ace47e();
_tmp.AlternateReadDbMethodAsync = QueryGetItemsIdentifiersReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetItemIdentifiersAndCreateIfNotExists.GetItemsIdentifiers.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_0a57e83422b4463daf632e7f94ace47e)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (System.InvalidOperationException aqExcep) {
if (aqExcep.Message.StartsWith("Command parameter[")) {
throw DatabaseErrorsHelper.AdvancedQueryParameterError("GetItemsIdentifiers in GetItemIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@DocumentClass))) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE UPPER(TRIM({CostCenterSAP}.[Ce_coste])) = UPPER(TRIM(@CostCenter))) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[CentroRTP])) = UPPER(TRIM(@Center))) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[DivisionFI])) = UPPER(TRIM(@Division))) LIMIT 1) [DivisionId],      ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@UnitType)) and {Currency}.[IsActive] = 1) LIMIT 1) [CurrencyId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE UPPER(TRIM({AccountingAccounts_ServiceType}.[CC])) = UPPER(TRIM(@GLAccount))) LIMIT 1) [ServiceTypeId]): " + aqExcep.Message);
}
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetItemsIdentifiers in GetItemIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@DocumentClass))) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE UPPER(TRIM({CostCenterSAP}.[Ce_coste])) = UPPER(TRIM(@CostCenter))) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[CentroRTP])) = UPPER(TRIM(@Center))) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[DivisionFI])) = UPPER(TRIM(@Division))) LIMIT 1) [DivisionId],      ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@UnitType)) and {Currency}.[IsActive] = 1) LIMIT 1) [CurrencyId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE UPPER(TRIM({AccountingAccounts_ServiceType}.[CC])) = UPPER(TRIM(@GLAccount))) LIMIT 1) [ServiceTypeId]): " + aqExcep.Message));
} catch (Exception aqExcep) {
throw DatabaseErrorsHelper.QueryError(DatabaseErrorsHelper.AdvancedQueryError("GetItemsIdentifiers in GetItemIdentifiersAndCreateIfNotExists in ConectaProveedores (SELECT       ((SELECT {DocumentType}.[Id] FROM {DocumentType} WHERE UPPER(TRIM({DocumentType}.[Classe])) = UPPER(TRIM(@DocumentClass))) LIMIT 1) [DocumentClassId],      ((SELECT {CostCenterSAP}.[Id] FROM {CostCenterSAP} WHERE UPPER(TRIM({CostCenterSAP}.[Ce_coste])) = UPPER(TRIM(@CostCenter))) LIMIT 1) [CostCenterId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[CentroRTP])) = UPPER(TRIM(@Center))) LIMIT 1) [RegionId],      ((SELECT {Region}.[Id] FROM {Region} WHERE UPPER(TRIM({Region}.[DivisionFI])) = UPPER(TRIM(@Division))) LIMIT 1) [DivisionId],      ((SELECT {Currency}.[Code] FROM {Currency} WHERE UPPER(TRIM({Currency}.[Code])) = UPPER(TRIM(@UnitType)) and {Currency}.[IsActive] = 1) LIMIT 1) [CurrencyId],      ((SELECT {AccountingAccounts_ServiceType}.[Id] FROM {AccountingAccounts_ServiceType} WHERE UPPER(TRIM({AccountingAccounts_ServiceType}.[CC])) = UPPER(TRIM(@GLAccount))) LIMIT 1) [ServiceTypeId]): " + aqExcep.Message));
}
}
}



}


}
