namespace ssConectaProveedores;

public partial class Actions {
public class lcvOrderMainItemCreate : VarsBag {
public EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource;
public long resCreateOrderMainItem_outParamId = 0L;

public lcvOrderMainItemCreate(EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}
}
public class lcoOrderMainItemCreate : VarsBag {
public long outParamId = 0L;

public lcoOrderMainItemCreate() {
}
}
/// <summary>
/// Action <code>OrderMainItemCreate</code> that represents the Service Studio action
///  <code>OrderMainItemCreate</code> <p> Description: Encapsulates the Create entity action, enablin
/// g logic to run consistently before and after a record is created.</p>
/// </summary>
public static async Task<long> ActionOrderMainItemCreate(IRequestContext requestContext,EN_ee41f56b159211a8b1cf5323f3a74af4EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
lcoOrderMainItemCreate result = new lcoOrderMainItemCreate();
lcvOrderMainItemCreate localVars = new lcvOrderMainItemCreate(inParamSource);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("OrderMainItemCreate", "fa93bae9-9898-4853-af93-5735746f0820"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("OrderMainItemCreate", "fa93bae9-9898-4853-af93-5735746f0820", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Mandatory attributes validation
if((((localVars.inParamSource.ssPurchaseRequisitionNumber!="")&&(localVars.inParamSource.ssOrderUnitOfMeasure!="")))) {
// Set basic audit attributes
// Source.CreatedBy = GetUserId
localVars.inParamSource.ssCreatedBy = BuiltInFunction.GetUserId ();

// Source.CreatedOn = CurrDateTime
localVars.inParamSource.ssCreatedOn = BuiltInFunction.CurrDateTime ();

// Source.UpdatedBy = GetUserId
localVars.inParamSource.ssUpdatedBy = BuiltInFunction.GetUserId ();

// Source.UpdatedOn = CurrDateTime
localVars.inParamSource.ssUpdatedOn = BuiltInFunction.CurrDateTime ();
// CreateOrderMainItem
localVars.resCreateOrderMainItem_outParamId = await ExtendedActions.CreateOrderMainItem(requestContext,(((RC_c4cc207f9017de4e013fabcf1e8ebeaf)localVars.inParamSource)),cancellationToken);

// Set Id
// Id = CreateOrderMainItem.Id
result.outParamId=localVars.resCreateOrderMainItem_outParamId;
} else {
// RaiseError EntityException
throw new Ex_EntityExceptionUserException ("Mandatory fields are required");

}

} //close CreateActionActivity using block
} // try

finally {
outParamId = result.outParamId;
} // inner-finally
RETURN_STATEMENT:
return outParamId;
}

public static class FuncActionOrderMainItemCreate {



}


}
