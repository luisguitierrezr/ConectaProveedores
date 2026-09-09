namespace ssConectaProveedores;

public partial class Actions {
public class lcvFolioRoleIsNeeded_Configs : VarsBag {
public EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio;
public EN_1d28318723f39133c60733b3cce8955eEntityRecord inParamApprovalProcessLevel;
public lcvFolioRoleIsNeeded_Configs(EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio, EN_1d28318723f39133c60733b3cce8955eEntityRecord inParamApprovalProcessLevel) {
this.inParami_Folio = inParami_Folio;
this.inParamApprovalProcessLevel = inParamApprovalProcessLevel;
}
}
public class lcoFolioRoleIsNeeded_Configs : VarsBag {
public bool outParamIsOk = false;

public lcoFolioRoleIsNeeded_Configs() {
}
}
/// <summary>
/// Action <code>FolioRoleIsNeeded_Configs</code> that represents the Service Studio action
///  <code>FolioRoleIsNeeded_Configs</code> <p> Description: </p>
/// </summary>
public static async Task<bool> ActionFolioRoleIsNeeded_Configs(IRequestContext requestContext,EN_764a7cdbc8a8735aa4be34db0d0a0f0aEntityRecord inParami_Folio,EN_1d28318723f39133c60733b3cce8955eEntityRecord inParamApprovalProcessLevel,CancellationToken cancellationToken) {
bool outParamIsOk = default;
lcoFolioRoleIsNeeded_Configs result = new lcoFolioRoleIsNeeded_Configs();
lcvFolioRoleIsNeeded_Configs localVars = new lcvFolioRoleIsNeeded_Configs(inParami_Folio, inParamApprovalProcessLevel);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("FolioRoleIsNeeded_Configs", "e23b2f37-b0c2-44bf-95b9-f613c7dbd0a0"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("FolioRoleIsNeeded_Configs", "e23b2f37-b0c2-44bf-95b9-f613c7dbd0a0", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if((((localVars.inParamApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.inParamApprovalProcessLevel.ssMaxAmount!=(((decimal)0)))))) {
// IsOk = i_Folio.TotalAmount > ApprovalProcessLevel.MinAmount and i_Folio.TotalAmount < ApprovalProcessLevel.MaxAmount
result.outParamIsOk=((localVars.inParami_Folio.ssTotalAmount>localVars.inParamApprovalProcessLevel.ssMinAmount)&&(localVars.inParami_Folio.ssTotalAmount<localVars.inParamApprovalProcessLevel.ssMaxAmount));
} else {
if(((localVars.inParamApprovalProcessLevel.ssMinAmount==(((decimal)0)))&&(localVars.inParamApprovalProcessLevel.ssMaxAmount!=(((decimal)0))))) {
// IsOk = i_Folio.TotalAmount < ApprovalProcessLevel.MaxAmount
result.outParamIsOk=(localVars.inParami_Folio.ssTotalAmount<localVars.inParamApprovalProcessLevel.ssMaxAmount);
} else {
if(((localVars.inParamApprovalProcessLevel.ssMinAmount!=(((decimal)0)))&&(localVars.inParamApprovalProcessLevel.ssMaxAmount==(((decimal)0))))) {
// IsOk = i_Folio.TotalAmount > ApprovalProcessLevel.MinAmount
result.outParamIsOk=(localVars.inParami_Folio.ssTotalAmount>localVars.inParamApprovalProcessLevel.ssMinAmount);
} else {
// False
// IsOk = False
result.outParamIsOk=false;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamIsOk = result.outParamIsOk;
} // inner-finally
RETURN_STATEMENT:
return outParamIsOk;
}

public static class FuncActionFolioRoleIsNeeded_Configs {



}


}
