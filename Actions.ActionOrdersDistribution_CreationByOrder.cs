namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersDistribution_CreationByOrder : VarsBag {
public EN_8c3668a93870461b8ea1216c2848f298EntityRecord inParami_OrdersImportRequest;
public RL_9f98927ca09897763d4f4dec24a42220 inParami_RequestDistributionConfigs;
public long inParami_OrderMainId;
public string inParami_OrderNumber;
public long inParami_RegionId;
public string inParami_Applicant;
/// <summary>
/// Variable <code>LogMessageText</code> that represents the Service Studio Text
///  <code>LogMessageText</code> <p>Description: </p>
/// </summary>
public string varLcLogMessageText = "";

/// <summary>
/// Variable <code>OrderLogs</code> that represents the Service Studio OrderLogs <code>OrderLogs</code>
///  <p>Description: RequisitionLogs record to create or modify</p>
/// </summary>
public EN_a8e484428097204171df8a1feecb2534EntityRecord varLcOrderLogs = new EN_a8e484428097204171df8a1feecb2534EntityRecord();

/// <summary>
/// Variable <code>OrderDistributionConfigId</code> that represents the Service Studio
///  OrderDistributionConfigIdentifier <code>OrderDistributionConfigId</code> <p>Description: </p>
/// </summary>
public long varLcOrderDistributionConfigId = 0L;

public Actions.lcoOrdersDistribution_Assignment resOrdersDistribution_Assignment =  new Actions.lcoOrdersDistribution_Assignment();
public RL_9f98927ca09897763d4f4dec24a42220 resGetDistributionOrder_OnRegion9_outParamFilteredList = new RL_9f98927ca09897763d4f4dec24a42220();

public Actions.lcoOrdersImport_RequestUpdateStatus resOrdersImport_RequestUpdateStatus =  new Actions.lcoOrdersImport_RequestUpdateStatus();
public Actions.lcoOrderLogAdd resOrderLogAdd =  new Actions.lcoOrderLogAdd();
public RL_9f98927ca09897763d4f4dec24a42220 resGetDistributionOrder_outParamFilteredList = new RL_9f98927ca09897763d4f4dec24a42220();

public lcvOrdersDistribution_CreationByOrder(EN_8c3668a93870461b8ea1216c2848f298EntityRecord inParami_OrdersImportRequest, RL_9f98927ca09897763d4f4dec24a42220 inParami_RequestDistributionConfigs, long inParami_OrderMainId, string inParami_OrderNumber, long inParami_RegionId, string inParami_Applicant) {
this.inParami_OrdersImportRequest = inParami_OrdersImportRequest;
this.inParami_RequestDistributionConfigs = inParami_RequestDistributionConfigs;
this.inParami_OrderMainId = inParami_OrderMainId;
this.inParami_OrderNumber = inParami_OrderNumber;
this.inParami_RegionId = inParami_RegionId;
this.inParami_Applicant = inParami_Applicant;
}
}
/// <summary>
/// Action <code>OrdersDistribution_CreationByOrder</code> that represents the Service Studio action
///  <code>OrdersDistribution_CreationByOrder</code> <p> Description: </p>
/// </summary>
public static async Task ActionOrdersDistribution_CreationByOrder(IRequestContext requestContext,EN_8c3668a93870461b8ea1216c2848f298EntityRecord inParami_OrdersImportRequest,RL_9f98927ca09897763d4f4dec24a42220 inParami_RequestDistributionConfigs,long inParami_OrderMainId,string inParami_OrderNumber,long inParami_RegionId,string inParami_Applicant,CancellationToken cancellationToken) {
lcvOrdersDistribution_CreationByOrder localVars = new lcvOrdersDistribution_CreationByOrder(inParami_OrdersImportRequest, inParami_RequestDistributionConfigs, inParami_OrderMainId, inParami_OrderNumber, inParami_RegionId, inParami_Applicant);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersDistribution_CreationByOrder", "f0cc1ad9-0950-47f9-9e31-f749c4a27e90"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersDistribution_CreationByOrder", "f0cc1ad9-0950-47f9-9e31-f749c4a27e90", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
do {
// GetDistributionOrder
localVars.resGetDistributionOrder_outParamFilteredList = (((RL_9f98927ca09897763d4f4dec24a42220)await  localVars.inParami_RequestDistributionConfigs.FilterAsync(async (p, cancellationToken) => ((p.ssRegionId==localVars.inParami_RegionId)&&(BuiltInFunction.ToUpper (BuiltInFunction.Trim (p.ssApplicant))==BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Applicant)))), cancellationToken)));

// --00
if(((localVars.resGetDistributionOrder_outParamFilteredList.Empty&&(BuiltInFunction.SubstrSC ((await Functions.ActionGetRegionCodeById(requestContext,localVars.inParami_RegionId,cancellationToken)), 2, 2)=="00")))) {
// GetDistributionOrder_OnRegion9
localVars.resGetDistributionOrder_OnRegion9_outParamFilteredList = (((RL_9f98927ca09897763d4f4dec24a42220)await  localVars.inParami_RequestDistributionConfigs.FilterAsync(async (p, cancellationToken) => ((p.ssRegionId==(await Functions.ActionGetRegionIdByCode(requestContext,"RG09",cancellationToken)))&&(BuiltInFunction.ToUpper (BuiltInFunction.Trim (p.ssApplicant))==BuiltInFunction.ToUpper (BuiltInFunction.Trim (localVars.inParami_Applicant)))), cancellationToken)));

// not found?
if((!(localVars.resGetDistributionOrder_OnRegion9_outParamFilteredList.Empty))) {
// OrderDistributionConfigId = GetDistributionOrder_OnRegion9.FilteredList.Current.Id
localVars.varLcOrderDistributionConfigId=localVars.resGetDistributionOrder_OnRegion9_outParamFilteredList.CurrentRec.ssId;
break;
}

} else {
// found?
if(((!localVars.resGetDistributionOrder_outParamFilteredList.Empty))) {
// OrderDistributionConfigId = GetDistributionOrder.FilteredList.Current.Id
localVars.varLcOrderDistributionConfigId=localVars.resGetDistributionOrder_outParamFilteredList.CurrentRec.ssId;
break;
}

}

// OrderLogs
// OrderLogs.Id = NullIdentifier
localVars.varLcOrderLogs.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// OrderLogs.OrderId = i_OrdersImportRequest.OrderMainId
localVars.varLcOrderLogs.ssOrderId = localVars.inParami_OrdersImportRequest.ssOrderMainId;

// OrderLogs.CreatedBy = GetUserId
localVars.varLcOrderLogs.ssCreatedBy = BuiltInFunction.GetUserId ();

// OrderLogs.CreatedOn = CurrDateTime
localVars.varLcOrderLogs.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// OrderLogs.Message = "Order" + " " + i_OrderNumber + " " + "not distributed due to configuration not found" + "."
localVars.varLcOrderLogs.ssMessage = (((((AppUtils.GetStringResource("GBPcU9RVykivqlOg0algTA#Value.76453678.1", "Order")+" ")+localVars.inParami_OrderNumber)+" ")+AppUtils.GetStringResource("GBPcU9RVykivqlOg0algTA#Value.204509404.1", "not distributed due to configuration not found"))+".");

// OrderLogs.IsError = True
localVars.varLcOrderLogs.ssIsError = true;
} while(false)
;
// exists?
if(((localVars.varLcOrderDistributionConfigId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// OrdersDistribution_Assignment
(localVars.resOrdersDistribution_Assignment.outParamResult,localVars.resOrdersDistribution_Assignment.outParamPositionFirstContactId) = await Actions.ActionOrdersDistribution_Assignment(requestContext,localVars.varLcOrderDistributionConfigId,localVars.inParami_OrdersImportRequest.ssOrderMainId,false,true,cancellationToken);

// OrderLogs
// OrderLogs.Id = NullIdentifier
localVars.varLcOrderLogs.ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ());

// OrderLogs.OrderId = i_OrderMainId
localVars.varLcOrderLogs.ssOrderId = localVars.inParami_OrderMainId;

// OrderLogs.CreatedBy = GetUserId
localVars.varLcOrderLogs.ssCreatedBy = BuiltInFunction.GetUserId ();

// OrderLogs.CreatedOn = CurrDateTime
localVars.varLcOrderLogs.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// OrderLogs.Message = If
localVars.varLcOrderLogs.ssMessage = ((localVars.resOrdersDistribution_Assignment.outParamResult.ssHasSuccess) ? ((((((AppUtils.GetStringResource("TGI4iO+LzUaap5ccYTSiPQ#Value.76453678.1", "Order")+" ")+localVars.inParami_OrderNumber)+" ")+AppUtils.GetStringResource("TGI4iO+LzUaap5ccYTSiPQ#Value.787928068.1", "distributed successfully"))+".")) : (((((((AppUtils.GetStringResource("TGI4iO+LzUaap5ccYTSiPQ#Value.76453678.2", "Order")+" ")+localVars.inParami_OrderNumber)+" ")+AppUtils.GetStringResource("TGI4iO+LzUaap5ccYTSiPQ#Value.-460306218.1", "not distributed"))+": ")+localVars.resOrdersDistribution_Assignment.outParamResult.ssErrorMessage)));

// OrderLogs.IsError = notOrdersDistribution_Assignment.Result.HasSuccess
localVars.varLcOrderLogs.ssIsError = (!localVars.resOrdersDistribution_Assignment.outParamResult.ssHasSuccess);
}

// ControledLogMessage
await Actions.ActionControledLogMessage(requestContext,((((bool)AppUtils.SiteProperties[SitePropertiesModel.spOrdersImportLog_IsActive]))),localVars.varLcLogMessageText,"OrdersDistribution_CreationByOrder",cancellationToken);

// OrderLogAdd
localVars.resOrderLogAdd.outParamId = await Actions.ActionOrderLogAdd(requestContext,localVars.varLcOrderLogs,cancellationToken);

// OrdersImport_RequestUpdateStatus
localVars.resOrdersImport_RequestUpdateStatus.outParamResult = await Actions.ActionOrdersImport_RequestUpdateStatus(requestContext,localVars.inParami_OrdersImportRequest.ssId,((localVars.varLcOrderLogs.ssIsError) ? ((ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("RuCeyUnezECw7Jj4dcCBmA"))).ssId) : ((ENImportStatusEntity.GetRecordByKey(ObjectKey.Parse("071tbgS1KEa8CNmBFtu49g"))).ssId)),cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionOrdersDistribution_CreationByOrder {



}


}
