namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrdersImport_Validations : VarsBag {
public ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data;
public Actions.lcoOrdersImport_Validations_BItems resOrdersImport_Validations_BItems =  new Actions.lcoOrdersImport_Validations_BItems();
public Actions.lcoOrdersImport_Validations_AMain resOrdersImport_Validations_AMain =  new Actions.lcoOrdersImport_Validations_AMain();
public lcvOrdersImport_Validations(ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data) {
this.inParami_Data = inParami_Data;
}
}
public class lcoOrdersImport_Validations : VarsBag {
public ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = new ST_5a17d82af8397abda9cf3915ce9c082fStructure();

public lcoOrdersImport_Validations() {
}
}
/// <summary>
/// Action <code>OrdersImport_Validations</code> that represents the Service Studio action
///  <code>OrdersImport_Validations</code> <p> Description: Action to validate Order Request.</p>
/// </summary>
public static async Task<ST_5a17d82af8397abda9cf3915ce9c082fStructure> ActionOrdersImport_Validations(IRequestContext requestContext,ST_9c87dd52bd762501ef8a064794927f08Structure inParami_Data,CancellationToken cancellationToken) {
ST_5a17d82af8397abda9cf3915ce9c082fStructure outParamo_ValidationResult = default;
lcoOrdersImport_Validations result = new lcoOrdersImport_Validations();
lcvOrdersImport_Validations localVars = new lcvOrdersImport_Validations(inParami_Data);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrdersImport_Validations", "b0ed5ae2-eb27-440b-bf47-8384c5012123"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrdersImport_Validations", "b0ed5ae2-eb27-440b-bf47-8384c5012123", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// OrdersImport_Validations_AMain
(localVars.resOrdersImport_Validations_AMain.outParamo_ValidationResult,localVars.resOrdersImport_Validations_AMain.outParamOrderMainId) = await Actions.ActionOrdersImport_Validations_AMain(requestContext,localVars.inParami_Data,cancellationToken);

// error?
if(((!localVars.resOrdersImport_Validations_AMain.outParamo_ValidationResult.ssHasSuccess))) {
// o_ValidationResult = OrdersImport_Validations_AMain.o_ValidationResult
result.outParamo_ValidationResult=localVars.resOrdersImport_Validations_AMain.outParamo_ValidationResult;
} else {
if(((localVars.resOrdersImport_Validations_AMain.outParamOrderMainId==Convert.ToInt64(BuiltInFunction.NullIdentifier ())))) {
// Foreach i_Data.OrderItems
localVars.inParami_Data.ssOrderItems.StartIteration();
try {while (!((localVars.inParami_Data.ssOrderItems.Eof))) {
// OrdersImport_Validations_BItems
localVars.resOrdersImport_Validations_BItems.outParamo_ValidationResult = await Actions.ActionOrdersImport_Validations_BItems(requestContext,localVars.inParami_Data,cancellationToken);

// error?
if(((!localVars.resOrdersImport_Validations_BItems.outParamo_ValidationResult.ssHasSuccess))) {
// o_ValidationResult = OrdersImport_Validations_BItems.o_ValidationResult
result.outParamo_ValidationResult=localVars.resOrdersImport_Validations_BItems.outParamo_ValidationResult;
goto RETURN_STATEMENT;

}

localVars.inParami_Data.ssOrderItems.Advance();
}

} finally {
localVars.inParami_Data.ssOrderItems.EndIteration();
}

}

// o_ValidationResult.OrderNumber = i_Data.OrderNumber
result.outParamo_ValidationResult.ssOrderNumber = localVars.inParami_Data.ssOrderNumber;

// o_ValidationResult.HasSuccess = True
result.outParamo_ValidationResult.ssHasSuccess = true;

// o_ValidationResult.ErrorMessage = ""
result.outParamo_ValidationResult.ssErrorMessage = "";
}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ValidationResult = result.outParamo_ValidationResult;
} // inner-finally
RETURN_STATEMENT:
return outParamo_ValidationResult;
}

public static class FuncActionOrdersImport_Validations {



}


}
