namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_Validations_AMain : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public Actions.lcoOrdersImport_Validations_AMainNew resOrdersImport_Validations_AMainNew =  new Actions.lcoOrdersImport_Validations_AMainNew();
public Actions.lcoGetHeaderIdentifiersAndCreateIfNotExists resGetHeaderIdentifiersAndCreateIfNotExists =  new Actions.lcoGetHeaderIdentifiersAndCreateIfNotExists();
public lcvOrdersImport_Validations_AMain(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data) {
this.inParami_Data = inParami_Data;
}
}
public class lcoOrdersImport_Validations_AMain : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public long outParamOrderMainId = 0L;

public lcoOrdersImport_Validations_AMain() {
}
}
/// <summary>
/// Action <code>OrdersImport_Validations_AMain</code> that represents the Service Studio action
///  <code>OrdersImport_Validations_AMain</code> <p> Description: </p>
/// </summary>
public static async Task<(ST_5a17d82af8397abda9cf3915ce9c082fStructure,long)> ActionOrdersImport_Validations_AMain(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = default;
long outParamOrderMainId = default;
lcoOrdersImport_Validations_AMain result = new lcoOrdersImport_Validations_AMain();
lcvOrdersImport_Validations_AMain localVars = new lcvOrdersImport_Validations_AMain(inParami_Data);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_Validations_AMain", "a4d9c573-f061-4746-b570-274c1848513f"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_Validations_AMain", "a4d9c573-f061-4746-b570-274c1848513f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// GetHeaderIdentifiersAndCreateIfNotExists
localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult = await Actions.ActionGetHeaderIdentifiersAndCreateIfNotExists(requestContext,localVars.inParami_Data,true,cancellationToken);

// OrderMainId = GetHeaderIdentifiersAndCreateIfNotExists.Result.OrderMainId
result.outParamOrderMainId=localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult.ssOrderMainId;
// Is New?
if(((localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult.ssOrderMainId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// OrdersImport_Validations_AMainNew
localVars.resOrdersImport_Validations_AMainNew.outParamo_ValidationResult = await Actions.ActionOrdersImport_Validations_AMainNew(requestContext,localVars.inParami_Data,localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult,cancellationToken);

// error?
if(((!localVars.resOrdersImport_Validations_AMainNew.outParamo_ValidationResult.ssHasSuccess))) {
// o_ValidationResult = OrdersImport_Validations_AMainNew.o_ValidationResult
result.outParamo_ValidationResult=localVars.resOrdersImport_Validations_AMainNew.outParamo_ValidationResult;
goto RETURN_STATEMENT;

}

}

// Released
if(((((((localVars.inParami_Data.ssReleased!="")&&(localVars.inParami_Data.ssReleased!="X"))&&(localVars.inParami_Data.ssReleased!="S"))||((localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult.ssOrderMainId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.inParami_Data.ssReleased=="X")))||((localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult.ssOrderMainId!=Convert.ToInt64(BuiltInFunction.NullIdentifier ()))&&(localVars.inParami_Data.ssReleased==""))))) {
// 014
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 014 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Released" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 014 - "+AppUtils.GetStringResource("OUNbKV63gUyXQu7V3+EP+g#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("OUNbKV63gUyXQu7V3+EP+g#Value.-2081819197.1", "field Released"))+".");
} else {
// ProcurementGroup
if((((localVars.inParami_Data.ssProcurementGroup!="")&&(localVars.resGetHeaderIdentifiersAndCreateIfNotExists.outParamResult.ssRegionId==Convert.ToInt64(BuiltInFunction.NullIdentifier ()))))) {
// 020
// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = False
result.outParamo_ValidationResult.ssHasSuccess = false;

// o_ValidationResult.ErrorMessage = "E - 020 - " + "Error validating Order" + " " + i_Data.OrderNumber + " - " + "field Procurement Group without Region association" + "."
result.outParamo_ValidationResult.ssErrorMessage = (((((("E - 020 - "+AppUtils.GetStringResource("IAlrRDnmxUyV+TFUhyOFdg#Value.99423321.1", "Error validating Order"))+" ")+localVars.inParami_Data.ssOrderNumber)+" - ")+AppUtils.GetStringResource("IAlrRDnmxUyV+TFUhyOFdg#Value.433671972.1", "field Procurement Group without Region association"))+".");
} else {
// o_ValidationResult.HasSuccess = True
result.outParamo_ValidationResult.ssHasSuccess = true;
}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ValidationResult = result.outParamo_ValidationResult;
outParamOrderMainId = result.outParamOrderMainId;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ValidationResult,outParamOrderMainId);
}

public static class FuncActionOrdersImport_Validations_AMain {



}


}
