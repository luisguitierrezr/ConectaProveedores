using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel).Namespace);

    public byte[] varLcl_FileContent;
public string varLcl_FileName;
public int varLcl_TabNumber;
public string varLcl_TableSort;
public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Model varLcGetSettings;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel() {
}



    public ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel(byte[] varLcl_FileContent, string varLcl_FileName, int varLcl_TabNumber, string varLcl_TableSort, ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_DataActionGetSettings_Model varLcGetSettings, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"l_FileContent", "l_FileName", "l_TabNumber", "l_TableSort", "GetSettings", "ClientVars"}, new string[] {"varLcl_FileContent", "varLcl_FileName", "varLcl_TabNumber", "varLcl_TableSort", "varLcGetSettings", "clientVariables"});
this.varLcl_FileContent = varLcl_FileContent;
this.varLcl_FileName = varLcl_FileName;
this.varLcl_TabNumber = varLcl_TabNumber;
this.varLcl_TableSort = varLcl_TableSort;
this.varLcGetSettings = varLcGetSettings;
this.clientVariables = clientVariables;
}



    

    public class lcoGetSettings : VarsBag {
public bool outParamAllowImport = false;

public lcoGetSettings() {
}
}
/// <summary>
/// Action <code>GetSettings</code> that represents the Service Studio action <code>GetSettings</code>
///  <p> Description: </p>
/// </summary>
public async Task<bool> DataActionGetSettings(IRequestContext requestContext,CancellationToken cancellationToken) {
bool outParamAllowImport = default;
lcoGetSettings result = new lcoGetSettings();
ConectaProveedores_h_OrderDistributionConfig_OrderDistributionConfig_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetSettings", "ecfd81d7-6e35-4ec5-bd3e-c2a666f498c5"))
using (activitySource.CreateScreenDataActionActivity("OrderDistributionConfig", "GetSettings")){
// AllowImport = AllowRequestDistributionImport
result.outParamAllowImport=((((bool)AppUtils.SiteProperties[SitePropertiesModel.spAllowRequestDistributionImport])));
} //close CreateActionActivity using block
} // try

finally {
outParamAllowImport = result.outParamAllowImport;
} // inner-finally
RETURN_STATEMENT:
return outParamAllowImport;
}


    public static class FuncDataActionGetSettings {
}


}
