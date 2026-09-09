namespace ssConectaProveedores;

public partial class Actions {
public class lcvValidateProposalLine : VarsBag {
public ST_0a2958ff44247d7464fd88ba7a80597cStructure inParami_FileLine;
public RL_c137814ac517b1e8679b0756ef62a588 inParami_CompaniesList;
public string inParami_ProposalRegion;
public Actions.lcoValidateRegion resValidateRegion =  new Actions.lcoValidateRegion();
public Actions.lcoValidateCompanyPermission resValidateCompanyPermission =  new Actions.lcoValidateCompanyPermission();
public Actions.lcoValidateSupplier resValidateSupplier =  new Actions.lcoValidateSupplier();
public Actions.lcoValidateLineByDate resValidateLineByDate =  new Actions.lcoValidateLineByDate();
public Actions.lcoValidateLineByDocAndYear resValidateLineByDocAndYear =  new Actions.lcoValidateLineByDocAndYear();
public lcvValidateProposalLine(ST_0a2958ff44247d7464fd88ba7a80597cStructure inParami_FileLine, RL_c137814ac517b1e8679b0756ef62a588 inParami_CompaniesList, string inParami_ProposalRegion) {
this.inParami_FileLine = inParami_FileLine;
this.inParami_CompaniesList = inParami_CompaniesList;
this.inParami_ProposalRegion = inParami_ProposalRegion;
}
}
public class lcoValidateProposalLine : VarsBag {
public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoValidateProposalLine() {
}
}
/// <summary>
/// Action <code>ValidateProposalLine</code> that represents the Service Studio action
///  <code>ValidateProposalLine</code> <p> Description: </p>
/// </summary>
public static async Task<ST_046fb53ebbe142526d95e87ef1ae9711Structure> ActionValidateProposalLine(IRequestContext requestContext,ST_0a2958ff44247d7464fd88ba7a80597cStructure inParami_FileLine,RL_c137814ac517b1e8679b0756ef62a588 inParami_CompaniesList,string inParami_ProposalRegion,CancellationToken cancellationToken) {
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoValidateProposalLine result = new lcoValidateProposalLine();
lcvValidateProposalLine localVars = new lcvValidateProposalLine(inParami_FileLine, inParami_CompaniesList, inParami_ProposalRegion);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("ValidateProposalLine", "9186f6be-ab1b-45b7-989d-74f48fd6dbb3"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("ValidateProposalLine", "9186f6be-ab1b-45b7-989d-74f48fd6dbb3", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;
// ValidateCompanyPermission
localVars.resValidateCompanyPermission.outParamo_IsAllowed = await Actions.ActionValidateCompanyPermission(requestContext,localVars.inParami_CompaniesList,localVars.inParami_FileLine.ssSoc,cancellationToken);

if(((!localVars.resValidateCompanyPermission.outParamo_IsAllowed))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "La sociedad " + i_FileLine.Soc + " no está permitida."
result.outParamo_Output.ssMessage = (("La sociedad "+localVars.inParami_FileLine.ssSoc)+" no está permitida.");
}

// ValidateLineByDocAndYear
localVars.resValidateLineByDocAndYear.outParamo_IsValid = await Actions.ActionValidateLineByDocAndYear(requestContext,localVars.inParami_FileLine.ssNDoc,BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.inParami_FileLine.ssFeContab)),cancellationToken);

if(((!localVars.resValidateLineByDocAndYear.outParamo_IsValid))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = o_Output.Message + "Número de documento duplicado:" + " " + i_FileLine.NDoc + " " + "en el año fiscal:" + " " + Year
result.outParamo_Output.ssMessage = (((((((result.outParamo_Output.ssMessage+"Número de documento duplicado:")+" ")+localVars.inParami_FileLine.ssNDoc)+" ")+"en el año fiscal:")+" ")+Convert.ToString(BuiltInFunction.Year (BuiltInFunction.TextToDate (localVars.inParami_FileLine.ssFeContab))));
}

// ValidateSupplier
localVars.resValidateSupplier.outParamo_IsValid = await Actions.ActionValidateSupplier(requestContext,localVars.inParami_FileLine.ssCuenta,cancellationToken);

if(((!localVars.resValidateSupplier.outParamo_IsValid))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = o_Output.Message + "El proveedor '" + i_FileLine.Nombre1 + i_FileLine.Nombre2 + " (" + i_FileLine.Cuenta + ")'" + " no existe en nuestra base de datos."
result.outParamo_Output.ssMessage = (((((((result.outParamo_Output.ssMessage+"El proveedor '")+localVars.inParami_FileLine.ssNombre1)+localVars.inParami_FileLine.ssNombre2)+" (")+localVars.inParami_FileLine.ssCuenta)+")'")+" no existe en nuestra base de datos.");
}

// ValidateLineByDate
localVars.resValidateLineByDate.outParamo_IsValid = await Actions.ActionValidateLineByDate(requestContext,BuiltInFunction.Trim (localVars.inParami_FileLine.ssEjMes),cancellationToken);

if((((!localVars.resValidateLineByDate.outParamo_IsValid)&&(!((((bool)AppUtils.SiteProperties[SitePropertiesModel.spIsActiveSkipDateValidationProposalsUpload]))))))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = o_Output.Message + "La fecha de la línea de la propuesta no coincide con el mes actual."
result.outParamo_Output.ssMessage = (result.outParamo_Output.ssMessage+AppUtils.GetStringResource("gbadyl4tEkGAo6Vfbz7k1g#Value.-1985533735.1", "La fecha de la línea de la propuesta no coincide con el mes actual."));
}

// ValidateRegion
localVars.resValidateRegion.outParamo_IsValid = await Actions.ActionValidateRegion(requestContext,BuiltInFunction.Trim (localVars.inParami_ProposalRegion),BuiltInFunction.Trim (localVars.inParami_FileLine.ssDiv),cancellationToken);

if(((!localVars.resValidateRegion.outParamo_IsValid))) {
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = o_Output.Message + "La región de la línea de la propuesta no coincide con la región de la propuesta."
result.outParamo_Output.ssMessage = (result.outParamo_Output.ssMessage+AppUtils.GetStringResource("bTwqZIQ9XkOsYtgJN4zMyg#Value.-532458528.1", "La región de la línea de la propuesta no coincide con la región de la propuesta."));
}

// o_Output.IsSuccess = o_Output.IsSuccess
result.outParamo_Output.ssIsSuccess = result.outParamo_Output.ssIsSuccess;
} //close CreateActionActivity using block
} // try

finally {
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return outParamo_Output;
}

public static class FuncActionValidateProposalLine {



}


}
