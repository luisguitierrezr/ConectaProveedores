namespace ssConectaProveedores;

public partial class Actions {
public class lcvInvoiceExtendedItemsTaxCreateOrUpdate : VarsBag {
public RL_052a618537841aabfe590fb1dffa78ab inParamInvoiceExtendedItemTaxList;
public long inParamInvoiceExtendedItemid;
public Actions.lcoInvoiceExtendedItemTaxCreateOrUpdate resInvoiceExtendedItemTaxCreateOrUpdate =  new Actions.lcoInvoiceExtendedItemTaxCreateOrUpdate();
public lcvInvoiceExtendedItemsTaxCreateOrUpdate(RL_052a618537841aabfe590fb1dffa78ab inParamInvoiceExtendedItemTaxList, long inParamInvoiceExtendedItemid) {
this.inParamInvoiceExtendedItemTaxList = inParamInvoiceExtendedItemTaxList;
this.inParamInvoiceExtendedItemid = inParamInvoiceExtendedItemid;
}
}
/// <summary>
/// Action <code>InvoiceExtendedItemsTaxCreateOrUpdate</code> that represents the Service Studio action
///  <code>InvoiceExtendedItemsTaxCreateOrUpdate</code> <p> Description: Encapsulates the CreateOrUpdat
/// e entity action, enabling logic to run consistently before and after a record is created or
///  modified.</p>
/// </summary>
public static async Task ActionInvoiceExtendedItemsTaxCreateOrUpdate(IRequestContext requestContext,RL_052a618537841aabfe590fb1dffa78ab inParamInvoiceExtendedItemTaxList,long inParamInvoiceExtendedItemid,CancellationToken cancellationToken) {
lcvInvoiceExtendedItemsTaxCreateOrUpdate localVars = new lcvInvoiceExtendedItemsTaxCreateOrUpdate(inParamInvoiceExtendedItemTaxList, inParamInvoiceExtendedItemid);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("InvoiceExtendedItemsTaxCreateOrUpdate", "3b33e6be-f382-4a46-9d43-284a18deb77d"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("InvoiceExtendedItemsTaxCreateOrUpdate", "3b33e6be-f382-4a46-9d43-284a18deb77d", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Foreach InvoiceExtendedItemTaxList
localVars.inParamInvoiceExtendedItemTaxList.StartIteration();
try {while (!((localVars.inParamInvoiceExtendedItemTaxList.Eof))) {
// InvoiceExtendedItemTaxList.Current.InvoiceExtendedItemId = InvoiceExtendedItemid
localVars.inParamInvoiceExtendedItemTaxList.CurrentRec.ssInvoiceExtendedItemId = localVars.inParamInvoiceExtendedItemid;
// InvoiceExtendedItemTaxCreateOrUpdate
localVars.resInvoiceExtendedItemTaxCreateOrUpdate.outParamId = await Actions.ActionInvoiceExtendedItemTaxCreateOrUpdate(requestContext,localVars.inParamInvoiceExtendedItemTaxList.CurrentRec,cancellationToken);

localVars.inParamInvoiceExtendedItemTaxList.Advance();
}

} finally {
localVars.inParamInvoiceExtendedItemTaxList.EndIteration();
}

} //close CreateActionActivity using block
} // try

finally {
} // inner-finally
RETURN_STATEMENT:
return;
}

public static class FuncActionInvoiceExtendedItemsTaxCreateOrUpdate {



}


}
