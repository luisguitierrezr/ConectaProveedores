namespace ssConectaProveedores;

public partial class Actions {
public class lcvDateValidate : VarsBag {
public string inParamInputText;
public string inParamExpectedFormat;
public bool inParamIsMandatory;
/// <summary>
/// Variable <code>NormalizeText</code> that represents the Service Studio Text
///  <code>NormalizeText</code> <p>Description: </p>
/// </summary>
public string varLcNormalizeText = "";

public lcvDateValidate(string inParamInputText, string inParamExpectedFormat, bool inParamIsMandatory) {
this.inParamInputText = inParamInputText;
this.inParamExpectedFormat = inParamExpectedFormat;
this.inParamIsMandatory = inParamIsMandatory;
}
}
public class lcoDateValidate : VarsBag {
public ST_360c3a66fc9951d9de7870c1f87f9bf6Structure outParamResult = new ST_360c3a66fc9951d9de7870c1f87f9bf6Structure();

public lcoDateValidate() {
}
}
/// <summary>
/// Action <code>DateValidate</code> that represents the Service Studio action
///  <code>DateValidate</code> <p> Description: </p>
/// </summary>
public static async Task<ST_360c3a66fc9951d9de7870c1f87f9bf6Structure> ActionDateValidate(IRequestContext requestContext,string inParamInputText,string inParamExpectedFormat,bool inParamIsMandatory,CancellationToken cancellationToken) {
ST_360c3a66fc9951d9de7870c1f87f9bf6Structure outParamResult = default;
lcoDateValidate result = new lcoDateValidate();
lcvDateValidate localVars = new lcvDateValidate(inParamInputText, inParamExpectedFormat, inParamIsMandatory);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("DateValidate", "aa5d7e40-bf81-4100-ae67-deb100aeccea"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("DateValidate", "aa5d7e40-bf81-4100-ae67-deb100aeccea", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
if(((localVars.inParamInputText!=""))) {
// Result.IsValid = False
result.outParamResult.ssIsValid = false;

// InputText = Replace
localVars.inParamInputText=BuiltInFunction.Replace (BuiltInFunction.Replace (localVars.inParamInputText, ".", "-"), "/", "-");

// ExpectedFormat = Replace
localVars.inParamExpectedFormat=BuiltInFunction.Replace (BuiltInFunction.Replace (localVars.inParamExpectedFormat, ".", "-"), "/", "-");

// InputText = If
localVars.inParamInputText=((((BuiltInFunction.IndexSC (localVars.inParamExpectedFormat, "-", 0, false, false)==(-1))&&(BuiltInFunction.IndexSC (localVars.inParamInputText, "-", 0, false, false)==(-1)))) ? ((((localVars.inParamExpectedFormat=="yyyyMMdd")) ? (((((BuiltInFunction.SubstrSC (localVars.inParamInputText, 0, 4)+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 4, 2))+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 6, 2))) : (((((BuiltInFunction.SubstrSC (localVars.inParamInputText, 0, 2)+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 2, 2))+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 4, 4))))) : (localVars.inParamInputText));

// Result.ErrorMessage = "Date is invalid"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("FekrgfFJUUCFvruVH4ke3Q#Value.1781528723.1", "Date is invalid");
if(((((localVars.inParamExpectedFormat=="dd-MM-yyyy")||(localVars.inParamExpectedFormat=="ddMMyyyy"))&&(BuiltInFunction.IndexSC (localVars.inParamInputText, "-", 0, false, false)!=(-1))))) {
// Set Date
// NormalizeText = Substr + "-" + Substr + "-" + Substr
localVars.varLcNormalizeText=((((BuiltInFunction.SubstrSC (localVars.inParamInputText, 6, 4)+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 3, 2))+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 0, 2));
} else {
if((((localVars.inParamExpectedFormat=="yyyy-MM-dd")||(localVars.inParamExpectedFormat=="yyyyMMdd"))&&(BuiltInFunction.IndexSC (localVars.inParamInputText, "-", 0, false, false)!=(-1)))) {
// Set Date
// NormalizeText = InputText
localVars.varLcNormalizeText=localVars.inParamInputText;
} else {
if((((localVars.inParamExpectedFormat=="MM-dd-yyyy")||(localVars.inParamExpectedFormat=="MMddyyyy"))&&(BuiltInFunction.IndexSC (localVars.inParamInputText, "-", 0, false, false)!=(-1)))) {
// Set Date
// NormalizeText = Substr + "-" + Substr + "-" + Substr
localVars.varLcNormalizeText=((((BuiltInFunction.SubstrSC (localVars.inParamInputText, 6, 4)+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 0, 2))+"-")+BuiltInFunction.SubstrSC (localVars.inParamInputText, 3, 2));
} else {
// Result.IsValid = True
result.outParamResult.ssIsValid = true;

// Result.Date = TextToDate
result.outParamResult.ssDate = BuiltInFunction.TextToDate (localVars.varLcNormalizeText);

// Result.ErrorMessage = "Date format is invalid"
result.outParamResult.ssErrorMessage = AppUtils.GetStringResource("z7oNlgGk_EipEQBcP8yNDw#Value.82047224.1", "Date format is invalid");
goto RETURN_STATEMENT;

}

}

}

if((BuiltInFunction.TextToDateTimeValidate(localVars.varLcNormalizeText))) {
// Result.IsValid = True
result.outParamResult.ssIsValid = true;

// Result.Date = TextToDate
result.outParamResult.ssDate = BuiltInFunction.TextToDate (localVars.varLcNormalizeText);

// Result.ErrorMessage = ""
result.outParamResult.ssErrorMessage = "";
}

} else {
// Result.IsValid = notIsMandatory
result.outParamResult.ssIsValid = (!localVars.inParamIsMandatory);

// Result.Date = NullDate
result.outParamResult.ssDate = BuiltInFunction.NullDate ();

// Result.ErrorMessage = If
result.outParamResult.ssErrorMessage = ((localVars.inParamIsMandatory) ? (AppUtils.GetStringResource("N93LEyyCakuvABixvN12Rg#Value.2105514325.1", "Date is Mandatory")) : (""));
}

} //close CreateActionActivity using block
} // try

finally {
outParamResult = result.outParamResult;
} // inner-finally
RETURN_STATEMENT:
return outParamResult;
}

public static class FuncActionDateValidate {



}


}
