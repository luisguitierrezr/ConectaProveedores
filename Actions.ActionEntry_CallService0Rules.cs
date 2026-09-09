namespace ssConectaProveedores;

public partial class Actions {
public class lcvEntry_CallService0Rules : VarsBag {
public RL_be0bc7b85db7b39f4a70be07d98b5bef inParamData;
/// <summary>
/// Variable <code>IsAllTCD1</code> that represents the Service Studio Boolean <code>IsAllTCD1</code>
///  <p>Description: </p>
/// </summary>
public bool varLcIsAllTCD1 = false;

public RL_be0bc7b85db7b39f4a70be07d98b5bef resListFilter_outParamFilteredList = new RL_be0bc7b85db7b39f4a70be07d98b5bef();

public Actions.lcoLogsAccountingCreate resLogsAccountingCreate =  new Actions.lcoLogsAccountingCreate();
public lcvEntry_CallService0Rules(RL_be0bc7b85db7b39f4a70be07d98b5bef inParamData) {
this.inParamData = inParamData;
}
}
public class lcoEntry_CallService0Rules : VarsBag {
public string outParamServicio = "";

public string outParamPEP_Pedido = "";

public string outParamPEP_Inserido = "";

public string outParamImputationCode = "";

public lcoEntry_CallService0Rules() {
}
}
/// <summary>
/// Action <code>Entry_CallService0Rules</code> that represents the Service Studio action
///  <code>Entry_CallService0Rules</code> <p> Description: </p>
/// </summary>
public static async Task<(string,string,string,string)> ActionEntry_CallService0Rules(IRequestContext requestContext,RL_be0bc7b85db7b39f4a70be07d98b5bef inParamData,CancellationToken cancellationToken) {
string outParamServicio = default;
string outParamPEP_Pedido = default;
string outParamPEP_Inserido = default;
string outParamImputationCode = default;
lcoEntry_CallService0Rules result = new lcoEntry_CallService0Rules();
lcvEntry_CallService0Rules localVars = new lcvEntry_CallService0Rules(inParamData);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("Entry_CallService0Rules", "1f783bb4-4798-45f1-a658-e10e4a5ae05a"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("Entry_CallService0Rules", "1f783bb4-4798-45f1-a658-e10e4a5ae05a", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// ListFilter
localVars.resListFilter_outParamFilteredList = (((RL_be0bc7b85db7b39f4a70be07d98b5bef)await  localVars.inParamData.FilterAsync(async (p, cancellationToken) => (p.ssENOrderMainItem.ssMaterialType=="TCD1"), cancellationToken)));

// IsAllTCD1 = ListFilter.FilteredList.Length = Data.Length and notData.Empty
localVars.varLcIsAllTCD1=((localVars.resListFilter_outParamFilteredList.Length==localVars.inParamData.Length)&&(!localVars.inParamData.Empty));

// PEP_Pedido = Substr
result.outParamPEP_Pedido=BuiltInFunction.SubstrSC (localVars.inParamData.CurrentRec.ssENOrderMainItem.ssPEPElement, 0, 2);

// PEP_Inserido = Substr
result.outParamPEP_Inserido=BuiltInFunction.SubstrSC (localVars.inParamData.CurrentRec.ssENFolioItems.ssPEP, 0, 2);

// ImputationCode = Data.Current.FolioItems.InputationCode
result.outParamImputationCode=localVars.inParamData.CurrentRec.ssENFolioItems.ssInputationCode;
if((((((result.outParamImputationCode=="")||(result.outParamImputationCode=="A"))||((result.outParamImputationCode=="W")&&(!localVars.varLcIsAllTCD1)))||((result.outParamImputationCode=="P")&&((((result.outParamPEP_Pedido=="MO")||(result.outParamPEP_Pedido=="CI"))||(result.outParamPEP_Pedido=="MI"))||(result.outParamPEP_Pedido=="RM")))))) {
// EM
// Servicio = 1
result.outParamServicio=Convert.ToString(1);
} else {
if(((result.outParamImputationCode=="W")&&localVars.varLcIsAllTCD1)) {
// EM_SM_CECO
// Servicio = 2
result.outParamServicio=Convert.ToString(2);
} else {
if((((result.outParamImputationCode=="Q")&&(result.outParamPEP_Inserido=="MO"))&&(result.outParamPEP_Pedido=="PL"))) {
// EM_SM_MO
// Servicio = 3
result.outParamServicio=Convert.ToString(3);
} else {
if((((result.outParamImputationCode=="Q")&&(((result.outParamPEP_Inserido=="CI")||(result.outParamPEP_Inserido=="MI"))||(result.outParamPEP_Inserido=="RM")))&&(result.outParamPEP_Pedido=="PL"))) {
// EM_SM_RM
// Servicio = 4
result.outParamServicio=Convert.ToString(4);
} else {
// dummy
}

}

}

}

// LogsAccountingCreate
localVars.resLogsAccountingCreate.outParamId = await Actions.ActionLogsAccountingCreate(requestContext,new EN_5f34c17a609e6a64501f16f3bfd44bd4EntityRecord(){ ssId = Convert.ToInt64(BuiltInFunction.NullIdentifier ()), ssTitle = "Call Entry Service", ssDescription = ((((((("ImputationCode "+localVars.inParamData.CurrentRec.ssENFolioItems.ssInputationCode)+" // MaterialCode ")+localVars.inParamData.CurrentRec.ssENOrderMainItem.ssMaterialCode)+" // PEP Pedido ")+result.outParamPEP_Pedido)+" // PEP Inserido ")+result.outParamPEP_Inserido), ssCreatedBy = BuiltInFunction.GetUserId (), ssCreatedOn = BuiltInFunction.CurrDateTime (), ssLogsAccountingSubjectId = (ENLogsAccountingSubjectEntity.GetRecordByKey(ObjectKey.Parse("0s8s1whzKkOypjdeQvl1RQ"))).ssId },cancellationToken);

} //close CreateActionActivity using block
} // try

finally {
outParamServicio = result.outParamServicio;
outParamPEP_Pedido = result.outParamPEP_Pedido;
outParamPEP_Inserido = result.outParamPEP_Inserido;
outParamImputationCode = result.outParamImputationCode;
} // inner-finally
RETURN_STATEMENT:
return (outParamServicio,outParamPEP_Pedido,outParamPEP_Inserido,outParamImputationCode);
}

public static class FuncActionEntry_CallService0Rules {



}


}
