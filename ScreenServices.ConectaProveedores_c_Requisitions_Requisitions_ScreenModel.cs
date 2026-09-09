using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_c_Requisitions_Requisitions_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_c_Requisitions_Requisitions_ScreenModel).Namespace);

    public ConectaProveedores_c_Requisitions_Requisitions_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_c_Requisitions_Requisitions_ScreenModel() {
}



    public ConectaProveedores_c_Requisitions_Requisitions_ScreenModel(ConectaProveedores_c_Requisitions_Requisitions_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"GetSettings", "ClientVars"}, new string[] {"varLcGetSettings", "clientVariables"});
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettings : VarsBag {
public bool outParamIsActiveDEV_NewVersionScreenDownloads = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamIsActiveDEV_NewVersionScreenDownloads = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_c_Requisitions_Requisitions_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "cddcbcfe-f7eb-4290-895d-0c1c285e59ff"))
using (activitySource.CreateScreenDataActionActivity("Requisitions", "GetSettings")){
// IsActiveDEV_NewVersionScreenDownloads = IsActiveDEV_NewScreenDownloads
result.outParamIsActiveDEV_NewVersionScreenDownloads=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveDEV_NewScreenDownloads])));
} //close CreateActionActivity using block
} // try

finally {
outParamIsActiveDEV_NewVersionScreenDownloads = result.outParamIsActiveDEV_NewVersionScreenDownloads;
} // inner-finally
RETURN_STATEMENT:
return outParamIsActiveDEV_NewVersionScreenDownloads;
}


    public static class FuncDataActionGetSettings {
}


}
