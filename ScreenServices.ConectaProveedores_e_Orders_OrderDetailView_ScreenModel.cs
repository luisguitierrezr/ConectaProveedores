using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_e_Orders_OrderDetailView_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_e_Orders_OrderDetailView_ScreenModel).Namespace);

    public long inParami_OrderId;
public ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_e_Orders_OrderDetailView_ScreenModel() {
}



    public ConectaProveedores_e_Orders_OrderDetailView_ScreenModel(long inParami_OrderId, ConectaProveedores_e_Orders_OrderDetailView_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"i_OrderId", "GetSettings", "ClientVars"}, new string[] {"inParami_OrderId", "varLcGetSettings", "clientVariables"});
this.inParami_OrderId = inParami_OrderId;
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettings : VarsBag {
public bool outParamo_IsActiveDEV_HU13008_Complement = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamo_IsActiveDEV_HU13008_Complement = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_e_Orders_OrderDetailView_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "a3e2975b-e63b-4ef3-91b0-73c733787358"))
using (activitySource.CreateScreenDataActionActivity("OrderDetailView", "GetSettings")){
// o_IsActiveDEV_HU13008_Complement = IsActiveDEV_HU13008_Complement
result.outParamo_IsActiveDEV_HU13008_Complement=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_HU13008_Complement])));
} //close CreateActionActivity using block
} // try

finally {
outParamo_IsActiveDEV_HU13008_Complement = result.outParamo_IsActiveDEV_HU13008_Complement;
} // inner-finally
RETURN_STATEMENT:
return outParamo_IsActiveDEV_HU13008_Complement;
}


    public static class FuncDataActionGetSettings {
}


}
