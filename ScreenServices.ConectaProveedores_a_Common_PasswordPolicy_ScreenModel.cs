using System.Diagnostics;

using ssConectaProveedores;


namespace ssConectaProveedores.ScreenServices;

public class ConectaProveedores_a_Common_PasswordPolicy_ScreenModel : VarsBag {

    private static readonly ActivitySource activitySource = new(typeof(ConectaProveedores_a_Common_PasswordPolicy_ScreenModel).Namespace);

    public string inParamPassword;
public ST_0774152396050b877fe73fc0db09d4f4Structure varLcPasswordComplexityPolicy;
public ST_b9e6959231369ae517164f0fb8e8606dStructure varLcPasswordValidationResult;
public bool varLcIsValidPassword;
public bool varLcIsMissingSpecialCharacter;
public ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model varLcGetMaxSavedOldPasswords;
public ConectaProveedores_ClientVariables clientVariables;


    public ConectaProveedores_a_Common_PasswordPolicy_ScreenModel() {
}



    public ConectaProveedores_a_Common_PasswordPolicy_ScreenModel(string inParamPassword, ST_0774152396050b877fe73fc0db09d4f4Structure varLcPasswordComplexityPolicy, ST_b9e6959231369ae517164f0fb8e8606dStructure varLcPasswordValidationResult, bool varLcIsValidPassword, bool varLcIsMissingSpecialCharacter, ConectaProveedores_a_Common_PasswordPolicy_DataActionGetMaxSavedOldPasswords_Model varLcGetMaxSavedOldPasswords, ConectaProveedores_ClientVariables clientVariables) {
Init(new string[] {"Password", "PasswordComplexityPolicy", "PasswordValidationResult", "IsValidPassword", "IsMissingSpecialCharacter", "GetMaxSavedOldPasswords", "ClientVars"}, new string[] {"inParamPassword", "varLcPasswordComplexityPolicy", "varLcPasswordValidationResult", "varLcIsValidPassword", "varLcIsMissingSpecialCharacter", "varLcGetMaxSavedOldPasswords", "clientVariables"});
this.inParamPassword = inParamPassword;
this.varLcPasswordComplexityPolicy = varLcPasswordComplexityPolicy;
this.varLcPasswordValidationResult = varLcPasswordValidationResult;
this.varLcIsValidPassword = varLcIsValidPassword;
this.varLcIsMissingSpecialCharacter = varLcIsMissingSpecialCharacter;
this.varLcGetMaxSavedOldPasswords = varLcGetMaxSavedOldPasswords;
this.clientVariables = clientVariables;
}



    

    public class lcvGetMaxSavedOldPasswords : VarsBag {
public int resGetMaxSavedOldPasswords_outParamValue = 0;

public lcvGetMaxSavedOldPasswords() {
}
}
public class lcoGetMaxSavedOldPasswords : VarsBag {
public int outParamValue = 0;

public lcoGetMaxSavedOldPasswords() {
}
}
/// <summary>
/// Action <code>GetMaxSavedOldPasswords</code> that represents the Service Studio action
///  <code>GetMaxSavedOldPasswords</code> <p> Description: </p>
/// </summary>
public async Task<int> DataActionGetMaxSavedOldPasswords(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamValue = default;
lcoGetMaxSavedOldPasswords result = new lcoGetMaxSavedOldPasswords();
lcvGetMaxSavedOldPasswords localVars = new lcvGetMaxSavedOldPasswords();
ConectaProveedores_a_Common_PasswordPolicy_ScreenModel model = this;

try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateScreenServiceDataActionMetric("GetMaxSavedOldPasswords", "cec9ea1c-8d2b-414c-b2f2-2e0be51e85ac"))
using (activitySource.CreateScreenDataActionActivity("PasswordPolicy", "GetMaxSavedOldPasswords")){
// GetMaxSavedOldPasswords
localVars.resGetMaxSavedOldPasswords_outParamValue = await ServiceAPIs.ServiceAPIGetMaxSavedOldPasswords(requestContext,cancellationToken);

// Value = GetMaxSavedOldPasswords.Value
result.outParamValue=localVars.resGetMaxSavedOldPasswords_outParamValue;
} //close CreateActionActivity using block
} // try

finally {
outParamValue = result.outParamValue;
} // inner-finally
RETURN_STATEMENT:
return outParamValue;
}


    public static class FuncDataActionGetMaxSavedOldPasswords {
}


}
