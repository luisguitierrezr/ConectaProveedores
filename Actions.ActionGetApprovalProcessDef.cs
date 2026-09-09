namespace ssConectaProveedores;

public partial class Actions {
public class lcvGetApprovalProcessDef : VarsBag {
public string inParamProcessTypeCode;
public long inParami_RegionId;
public string inParami_Area;
public string inParami_Direction;
public long inParami_EntraRoleId;
public long inParami_DepartmentId;
public bool inParami_IsDonation;
public bool inParami_IsApplicant;
public int inParami_ApprovalProcessTypeId;
public bool inParami_IsSearchSpecial;
public long inParami_SpecialWorkflowId;
public RL_21d5457a1d34649ed7b58b58f1d048d5 queryResGetApprovalProcessMatrix3_outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
public long queryResGetApprovalProcessMatrix3_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcessWithGerencia_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcessWithGerencia_outParamCount = 0L;

public RL_21d5457a1d34649ed7b58b58f1d048d5 queryResGetApprovalProcessMatrix_outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
public long queryResGetApprovalProcessMatrix_outParamCount = 0L;

public RL_5e0ca6ca9da3af4b1d8149758c39c2cf queryResGetApprovalProcessWithSpecialWorkflowId_outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
public long queryResGetApprovalProcessWithSpecialWorkflowId_outParamCount = 0L;

public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcessByProcessTypeCode_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcessByProcessTypeCode_outParamCount = 0L;

public RL_21d5457a1d34649ed7b58b58f1d048d5 queryResGetApprovalProcessMatrix2_outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
public long queryResGetApprovalProcessMatrix2_outParamCount = 0L;

public RL_acd66b694d90eb775616e6c6e3f83477 queryResGetApprovalProcessFolioSAE_outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
public long queryResGetApprovalProcessFolioSAE_outParamCount = 0L;

public RL_50f86c7badf933578e482e000d347a03 queryResGetProcessTypeByCode_outParamList = new RL_50f86c7badf933578e482e000d347a03();
public long queryResGetProcessTypeByCode_outParamCount = 0L;

public RL_8dbe9b3349c28479d314d27fe2f03197 queryResGetApprovalProcess_outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
public long queryResGetApprovalProcess_outParamCount = 0L;

public lcvGetApprovalProcessDef(string inParamProcessTypeCode, long inParami_RegionId, string inParami_Area, string inParami_Direction, long inParami_EntraRoleId, long inParami_DepartmentId, bool inParami_IsDonation, bool inParami_IsApplicant, int inParami_ApprovalProcessTypeId, bool inParami_IsSearchSpecial, long inParami_SpecialWorkflowId) {
this.inParamProcessTypeCode = inParamProcessTypeCode;
this.inParami_RegionId = inParami_RegionId;
this.inParami_Area = inParami_Area;
this.inParami_Direction = inParami_Direction;
this.inParami_EntraRoleId = inParami_EntraRoleId;
this.inParami_DepartmentId = inParami_DepartmentId;
this.inParami_IsDonation = inParami_IsDonation;
this.inParami_IsApplicant = inParami_IsApplicant;
this.inParami_ApprovalProcessTypeId = inParami_ApprovalProcessTypeId;
this.inParami_IsSearchSpecial = inParami_IsSearchSpecial;
this.inParami_SpecialWorkflowId = inParami_SpecialWorkflowId;
}
}
public class lcoGetApprovalProcessDef : VarsBag {
public RC_3bc764f67e81a7d7cfa96c1a97a8c95b outParamo_ApprovalProcess = new RC_3bc764f67e81a7d7cfa96c1a97a8c95b();

public ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = new ST_046fb53ebbe142526d95e87ef1ae9711Structure();

public lcoGetApprovalProcessDef() {
}
}
/// <summary>
/// Action <code>GetApprovalProcessDef</code> that represents the Service Studio action
///  <code>GetApprovalProcessDef</code> <p> Description: </p>
/// </summary>
public static async Task<(RC_3bc764f67e81a7d7cfa96c1a97a8c95b,ST_046fb53ebbe142526d95e87ef1ae9711Structure)> ActionGetApprovalProcessDef(IRequestContext requestContext,string inParamProcessTypeCode,long inParami_RegionId,string inParami_Area,string inParami_Direction,long inParami_EntraRoleId,long inParami_DepartmentId,bool inParami_IsDonation,bool inParami_IsApplicant,int inParami_ApprovalProcessTypeId,bool inParami_IsSearchSpecial,long inParami_SpecialWorkflowId,CancellationToken cancellationToken) {
RC_3bc764f67e81a7d7cfa96c1a97a8c95b outParamo_ApprovalProcess = default;
ST_046fb53ebbe142526d95e87ef1ae9711Structure outParamo_Output = default;
lcoGetApprovalProcessDef result = new lcoGetApprovalProcessDef();
lcvGetApprovalProcessDef localVars = new lcvGetApprovalProcessDef(inParamProcessTypeCode, inParami_RegionId, inParami_Area, inParami_Direction, inParami_EntraRoleId, inParami_DepartmentId, inParami_IsDonation, inParami_IsApplicant, inParami_ApprovalProcessTypeId, inParami_IsSearchSpecial, inParami_SpecialWorkflowId);
try {
cancellationToken.ThrowIfCancellationRequested();
using (AppHealthProvider.CreateServerActionMetric("GetApprovalProcessDef", "71a4839a-706b-4958-a88d-043b4023e6a1"))
using (RuntimePlatformSettings.OpenTelemetry.ServerActionIsEnabled.GetValue() ? activitySource.CreateActionActivity("GetApprovalProcessDef", "71a4839a-706b-4958-a88d-043b4023e6a1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828") : null){
// Query datasetGetProcessTypeByCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetProcessTypeByCode_maxRecords = 1;
if (datasetGetProcessTypeByCode_maxRecords < 1) datasetGetProcessTypeByCode_maxRecords = 1;
int datasetGetProcessTypeByCode_startIndex = 0;(localVars.queryResGetProcessTypeByCode_outParamList,localVars.queryResGetProcessTypeByCode_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetProcessTypeByCode(requestContext,datasetGetProcessTypeByCode_maxRecords,datasetGetProcessTypeByCode_startIndex,IterationMultiplicity.Never,localVars.inParamProcessTypeCode,cancellationToken);

// Empty
if((localVars.queryResGetProcessTypeByCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "Process type not found!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("p86UDQX8y0eLX4ew1YaFYQ#Value.502048673.1", "Process type not found!");
} else {
if(((localVars.inParami_ApprovalProcessTypeId!=BuiltInFunction.NullIdentifier ()))) {
// Query datasetGetApprovalProcessFolioSAE
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessFolioSAE_maxRecords = 1;
if (datasetGetApprovalProcessFolioSAE_maxRecords < 1) datasetGetApprovalProcessFolioSAE_maxRecords = 1;
int datasetGetApprovalProcessFolioSAE_startIndex = 0;(localVars.queryResGetApprovalProcessFolioSAE_outParamList,localVars.queryResGetApprovalProcessFolioSAE_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessFolioSAE(requestContext,datasetGetApprovalProcessFolioSAE_maxRecords,datasetGetApprovalProcessFolioSAE_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_ApprovalProcessTypeId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessFolioSAE_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_Output.Message = "No approval workflow defined or configured for this scenario!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("_jzTm_KTNkCv_iOy05ceWw#Value.9822949.1", "No approval workflow defined or configured for this scenario!");
} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessFolioSAE.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessFolioSAE_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessFolioSAE.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessFolioSAE_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessFolioSAE.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessFolioSAE_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
}

} else {
if((localVars.inParami_IsSearchSpecial)) {
// Query datasetGetApprovalProcessWithSpecialWorkflowId
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessWithSpecialWorkflowId_maxRecords = 1;
if (datasetGetApprovalProcessWithSpecialWorkflowId_maxRecords < 1) datasetGetApprovalProcessWithSpecialWorkflowId_maxRecords = 1;
int datasetGetApprovalProcessWithSpecialWorkflowId_startIndex = 0;(localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamList,localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessWithSpecialWorkflowId(requestContext,datasetGetApprovalProcessWithSpecialWorkflowId_maxRecords,datasetGetApprovalProcessWithSpecialWorkflowId_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_IsDonation,localVars.inParami_SpecialWorkflowId,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamList.Empty)) {
// Query datasetGetApprovalProcessWithGerencia
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessWithGerencia_maxRecords = 1;
if (datasetGetApprovalProcessWithGerencia_maxRecords < 1) datasetGetApprovalProcessWithGerencia_maxRecords = 1;
int datasetGetApprovalProcessWithGerencia_startIndex = 0;(localVars.queryResGetApprovalProcessWithGerencia_outParamList,localVars.queryResGetApprovalProcessWithGerencia_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessWithGerencia(requestContext,datasetGetApprovalProcessWithGerencia_maxRecords,datasetGetApprovalProcessWithGerencia_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_DepartmentId,localVars.inParami_EntraRoleId,localVars.inParami_IsApplicant,localVars.inParami_IsDonation,cancellationToken);

// Empty?
if((localVars.queryResGetApprovalProcessWithGerencia_outParamList.Empty)) {
// Query datasetGetApprovalProcess
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcess_maxRecords = 1;
if (datasetGetApprovalProcess_maxRecords < 1) datasetGetApprovalProcess_maxRecords = 1;
int datasetGetApprovalProcess_startIndex = 0;(localVars.queryResGetApprovalProcess_outParamList,localVars.queryResGetApprovalProcess_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcess(requestContext,datasetGetApprovalProcess_maxRecords,datasetGetApprovalProcess_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_EntraRoleId,localVars.inParami_IsApplicant,localVars.inParami_IsDonation,cancellationToken);

// Empty?
if((!(localVars.queryResGetApprovalProcess_outParamList.Empty))) {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcess.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcess.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcess.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcess_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
goto RETURN_STATEMENT;

}

} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessWithGerencia.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessWithGerencia_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessWithGerencia.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessWithGerencia_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessWithGerencia.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessWithGerencia_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
goto RETURN_STATEMENT;

}

} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessWithSpecialWorkflowId.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessWithSpecialWorkflowId.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessWithSpecialWorkflowId.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessWithSpecialWorkflowId_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
goto RETURN_STATEMENT;

}

}

// Query datasetGetApprovalProcessMatrix
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessMatrix_maxRecords = 1;
if (datasetGetApprovalProcessMatrix_maxRecords < 1) datasetGetApprovalProcessMatrix_maxRecords = 1;
int datasetGetApprovalProcessMatrix_startIndex = 0;(localVars.queryResGetApprovalProcessMatrix_outParamList,localVars.queryResGetApprovalProcessMatrix_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessMatrix(requestContext,datasetGetApprovalProcessMatrix_maxRecords,datasetGetApprovalProcessMatrix_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_Area,localVars.inParami_RegionId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessMatrix_outParamList.Empty)) {
// Query datasetGetApprovalProcessMatrix3
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessMatrix3_maxRecords = 1;
if (datasetGetApprovalProcessMatrix3_maxRecords < 1) datasetGetApprovalProcessMatrix3_maxRecords = 1;
int datasetGetApprovalProcessMatrix3_startIndex = 0;(localVars.queryResGetApprovalProcessMatrix3_outParamList,localVars.queryResGetApprovalProcessMatrix3_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessMatrix3(requestContext,datasetGetApprovalProcessMatrix3_maxRecords,datasetGetApprovalProcessMatrix3_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_Direction,localVars.inParami_RegionId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessMatrix3_outParamList.Empty)) {
// Query datasetGetApprovalProcessMatrix2
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessMatrix2_maxRecords = 1;
if (datasetGetApprovalProcessMatrix2_maxRecords < 1) datasetGetApprovalProcessMatrix2_maxRecords = 1;
int datasetGetApprovalProcessMatrix2_startIndex = 0;(localVars.queryResGetApprovalProcessMatrix2_outParamList,localVars.queryResGetApprovalProcessMatrix2_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessMatrix2(requestContext,datasetGetApprovalProcessMatrix2_maxRecords,datasetGetApprovalProcessMatrix2_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,localVars.inParami_RegionId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessMatrix2_outParamList.Empty)) {
// Query datasetGetApprovalProcessByProcessTypeCode
cancellationToken.ThrowIfCancellationRequested();
int datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
if (datasetGetApprovalProcessByProcessTypeCode_maxRecords < 1) datasetGetApprovalProcessByProcessTypeCode_maxRecords = 1;
int datasetGetApprovalProcessByProcessTypeCode_startIndex = 0;(localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList,localVars.queryResGetApprovalProcessByProcessTypeCode_outParamCount) = await FuncActionGetApprovalProcessDef.datasetGetApprovalProcessByProcessTypeCode(requestContext,datasetGetApprovalProcessByProcessTypeCode_maxRecords,datasetGetApprovalProcessByProcessTypeCode_startIndex,IterationMultiplicity.Never,localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssId,cancellationToken);

// Empty
if((localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.Empty)) {
// o_Output
// o_Output.IsSuccess = False
result.outParamo_Output.ssIsSuccess = false;

// o_Output.Message = "No approval workflow defined or configured for this scenario!"
result.outParamo_Output.ssMessage = AppUtils.GetStringResource("izCrcSX3FEOMMb2mpcfLhw#Value.9822949.1", "No approval workflow defined or configured for this scenario!");
} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessByProcessTypeCode.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessByProcessTypeCode.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessByProcessTypeCode.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessByProcessTypeCode_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
}

} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessMatrix2.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessMatrix2_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessMatrix2.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessMatrix2_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessMatrix2.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessMatrix2_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
}

} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessMatrix3.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessMatrix3_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessMatrix3.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessMatrix3_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessMatrix3.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessMatrix3_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
}

} else {
// o_ApprovalProcess
// o_Output.IsSuccess = True
result.outParamo_Output.ssIsSuccess = true;

// o_ApprovalProcess.ProcessTypeCode = GetProcessTypeByCode.List.Current.ProcessType.Code
result.outParamo_ApprovalProcess.ssProcessTypeCode = localVars.queryResGetProcessTypeByCode_outParamList.CurrentRec.ssENProcessType.ssCode;

// o_ApprovalProcess.Version = GetApprovalProcessMatrix.List.Current.ApprovalProcess.Version
result.outParamo_ApprovalProcess.ssVersion = Convert.ToString(localVars.queryResGetApprovalProcessMatrix_outParamList.CurrentRec.ssENApprovalProcess.ssVersion);

// o_ApprovalProcess.ApprovalProcessId = GetApprovalProcessMatrix.List.Current.ApprovalProcess.Id
result.outParamo_ApprovalProcess.ssApprovalProcessId = localVars.queryResGetApprovalProcessMatrix_outParamList.CurrentRec.ssENApprovalProcess.ssId;

// o_ApprovalProcess.IsSpecial = GetApprovalProcessMatrix.List.Current.ApprovalProcess.IsSpecial
result.outParamo_ApprovalProcess.ssIsSpecial = localVars.queryResGetApprovalProcessMatrix_outParamList.CurrentRec.ssENApprovalProcess.ssIsSpecial;
}

}

}

} //close CreateActionActivity using block
} // try

finally {
outParamo_ApprovalProcess = result.outParamo_ApprovalProcess;
outParamo_Output = result.outParamo_Output;
} // inner-finally
RETURN_STATEMENT:
return (outParamo_ApprovalProcess,outParamo_Output);
}

public static class FuncActionGetApprovalProcessDef {

private static async Task<RC_01911a773916dfcf99bb546f23183cea> datasetGetApprovalProcessMatrix3ReadDbAsync(RC_01911a773916dfcf99bb546f23183cea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessMatrix.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessMatrix3" u3p3DqPbdUyiEB75GRs+wQ of Action "GetApprovalProcessDef"
public static async Task<(RL_21d5457a1d34649ed7b58b58f1d048d5,long)> datasetGetApprovalProcessMatrix3(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcessMatrix_ProcessTypeId,string qpteApprovalProcessMatrix_TelcelDirection,long qpreRegion_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessMatrix3", "0e777abb-dba3-4c75-a210-1ef9191b3ec1");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessMatrix3", "0e777abb-dba3-4c75-a210-1ef9191b3ec1", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.u3p3DqPbdUyiEB75GRs+wQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess9\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess9\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess9\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess9\" Left JOIN {ApprovalProcessMatrix} \"enapprovalprocessmatrix\" ON (\"enapprovalprocess9\".\"id\" = \"enapprovalprocessmatrix\".\"approvalprocessid\"))  Left JOIN {Region} \"enregion29\" ON (\"enapprovalprocessmatrix\".\"region\" = \"enregion29\".\"commissionregion\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcessMatrix_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocessmatrix\".\"processtypeid\" = @qpprApprovalProcessMatrix_ProcessTypeId) AND (\"enapprovalprocessmatrix\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcessMatrix_ProcessTypeId", DbType.Int64, qpprApprovalProcessMatrix_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocessmatrix\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocessmatrix\".\"isactive\" = 1) AND ");
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion29\".\"id\" = @qpreRegion_Id) AND (\"enregion29\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion29\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocessmatrix\".\"telceldirection\" = @qpteApprovalProcessMatrix_TelcelDirection) AND (NOT (\"enapprovalprocess9\".\"isspecial\" = 1)) AND ((trim(\"enapprovalprocessmatrix\".\"area\")) = '')");
sqlCmd.CreateParameterWithoutReplacements("@qpteApprovalProcessMatrix_TelcelDirection", DbType.String, qpteApprovalProcessMatrix_TelcelDirection);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_21d5457a1d34649ed7b58b58f1d048d5 outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix3ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessMatrix3.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_21d5457a1d34649ed7b58b58f1d048d5 _tmp = new RL_21d5457a1d34649ed7b58b58f1d048d5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix3ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessMatrix3.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_21d5457a1d34649ed7b58b58f1d048d5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessWithGerenciaReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessWithGerencia" uqu1FSlgHUe9_5aarGhH_w of Action "GetApprovalProcessDef"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcessWithGerencia(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpdeApprovalProcessLevel_DepartmentId,long qpenApprovalProcessLevel_EntraRoleId,bool qpboApprovalProcessLevel_IsApplicant,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessWithGerencia", "15b5abba-6029-471d-bdff-969aac6847ff");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessWithGerencia", "15b5abba-6029-471d-bdff-969aac6847ff", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.uqu1FSlgHUe9_5aarGhH_w, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess10\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess10\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess10\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess10\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel3\" ON (\"enapprovalprocess10\".\"id\" = \"enapprovalprocesslevel3\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess10\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess10\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess10\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel3\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel3\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel3\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess10\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess10\".\"isactive\" = 1) AND (\"enapprovalprocess10\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel3\".\"isapplicant\" = @qpboApprovalProcessLevel_IsApplicant) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsApplicant", DbType.Boolean, qpboApprovalProcessLevel_IsApplicant);
if (qpdeApprovalProcessLevel_DepartmentId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel3\".\"departmentid\" = @qpdeApprovalProcessLevel_DepartmentId) AND (\"enapprovalprocesslevel3\".\"departmentid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpdeApprovalProcessLevel_DepartmentId", DbType.Int64, qpdeApprovalProcessLevel_DepartmentId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel3\".\"departmentid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessWithGerenciaReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessWithGerencia.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessWithGerenciaReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessWithGerencia.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_01911a773916dfcf99bb546f23183cea> datasetGetApprovalProcessMatrixReadDbAsync(RC_01911a773916dfcf99bb546f23183cea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessMatrix.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessMatrix" sV06Lsj+9kGQYU+7hZ1HMQ of Action "GetApprovalProcessDef"
public static async Task<(RL_21d5457a1d34649ed7b58b58f1d048d5,long)> datasetGetApprovalProcessMatrix(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcessMatrix_ProcessTypeId,string qpteApprovalProcessMatrix_Area,long qpreRegion_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessMatrix", "2e3a5db1-fec8-41f6-9061-4fbb859d4731");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessMatrix", "2e3a5db1-fec8-41f6-9061-4fbb859d4731", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.sV06Lsj+9kGQYU+7hZ1HMQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess11\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess11\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess11\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess11\" Left JOIN {ApprovalProcessMatrix} \"enapprovalprocessmatrix1\" ON (\"enapprovalprocess11\".\"id\" = \"enapprovalprocessmatrix1\".\"approvalprocessid\"))  Left JOIN {Region} \"enregion30\" ON (\"enapprovalprocessmatrix1\".\"region\" = \"enregion30\".\"commissionregion\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcessMatrix_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocessmatrix1\".\"processtypeid\" = @qpprApprovalProcessMatrix_ProcessTypeId) AND (\"enapprovalprocessmatrix1\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcessMatrix_ProcessTypeId", DbType.Int64, qpprApprovalProcessMatrix_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocessmatrix1\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocessmatrix1\".\"isactive\" = 1) AND ");
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion30\".\"id\" = @qpreRegion_Id) AND (\"enregion30\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion30\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocessmatrix1\".\"area\" = @qpteApprovalProcessMatrix_Area) AND (NOT (\"enapprovalprocess11\".\"isspecial\" = 1)) AND ((trim(\"enapprovalprocessmatrix1\".\"telceldirection\")) = '')");
sqlCmd.CreateParameterWithoutReplacements("@qpteApprovalProcessMatrix_Area", DbType.String, qpteApprovalProcessMatrix_Area);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_21d5457a1d34649ed7b58b58f1d048d5 outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrixReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessMatrix.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_21d5457a1d34649ed7b58b58f1d048d5 _tmp = new RL_21d5457a1d34649ed7b58b58f1d048d5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrixReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessMatrix.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_21d5457a1d34649ed7b58b58f1d048d5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetApprovalProcessWithSpecialWorkflowId" gEeunVIfSU6E75jLEYNfIQ of Action "GetApprovalProcessDef"
public static async Task<(RL_5e0ca6ca9da3af4b1d8149758c39c2cf,long)> datasetGetApprovalProcessWithSpecialWorkflowId(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprProcessTypeId,bool qpboIsDonation,long qpspSpecialWorkflowId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessWithSpecialWorkflowId", "9dae4780-1f52-4e49-84ef-98cb11835f21");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessWithSpecialWorkflowId", "9dae4780-1f52-4e49-84ef-98cb11835f21", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.gEeunVIfSU6E75jLEYNfIQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess12\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess12\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess12\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18");
fromBuilder.Append(" FROM {ApprovalProcess} \"enapprovalprocess12\"");
whereBuilder.Append(" WHERE ");
if (qpprProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess12\".\"processtypeid\" = @qpprProcessTypeId) AND (\"enapprovalprocess12\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprProcessTypeId", DbType.Int64, qpprProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess12\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess12\".\"isdonation\" = @qpboIsDonation) AND (\"enapprovalprocess12\".\"isactive\" = 1) AND (\"enapprovalprocess12\".\"isspecial\" = 1) AND ");
sqlCmd.CreateParameterWithoutReplacements("@qpboIsDonation", DbType.Boolean, qpboIsDonation);
if (qpspSpecialWorkflowId != 0) {
whereBuilder.Append("((\"enapprovalprocess12\".\"specialworkflowid\" = @qpspSpecialWorkflowId) AND (\"enapprovalprocess12\".\"specialworkflowid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpspSpecialWorkflowId", DbType.Int64, qpspSpecialWorkflowId);
} else {
whereBuilder.Append("(\"enapprovalprocess12\".\"specialworkflowid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf outParamList = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessWithSpecialWorkflowId.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_5e0ca6ca9da3af4b1d8149758c39c2cf _tmp = new RL_5e0ca6ca9da3af4b1d8149758c39c2cf();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessWithSpecialWorkflowId.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_5e0ca6ca9da3af4b1d8149758c39c2cf)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_9c2c2f8777df5db915ea9753325ce8dd> datasetGetApprovalProcessByProcessTypeCodeReadDbAsync(RC_9c2c2f8777df5db915ea9753325ce8dd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessByProcessTypeCode" ZGhyuEHc6kyIdCgcMccG9A of Action "GetApprovalProcessDef"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcessByProcessTypeCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessByProcessTypeCode", "b8726864-dc41-4cea-8874-281c31c706f4");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessByProcessTypeCode", "b8726864-dc41-4cea-8874-281c31c706f4", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.ZGhyuEHc6kyIdCgcMccG9A, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess13\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess13\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess13\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess13\" Inner JOIN {ProcessType} \"enprocesstype3\" ON (\"enapprovalprocess13\".\"processtypeid\" = \"enprocesstype3\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess13\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess13\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess13\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess13\".\"isactive\" = 1) AND (NOT (\"enapprovalprocess13\".\"isspecial\" = 1))");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_acd66b694d90eb775616e6c6e3f83477 outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessByProcessTypeCodeReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acd66b694d90eb775616e6c6e3f83477 _tmp = new RL_acd66b694d90eb775616e6c6e3f83477();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessByProcessTypeCodeReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessByProcessTypeCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acd66b694d90eb775616e6c6e3f83477)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_01911a773916dfcf99bb546f23183cea> datasetGetApprovalProcessMatrix2ReadDbAsync(RC_01911a773916dfcf99bb546f23183cea rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessMatrix.Read( r, ref index);
rec.ssENRegion.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessMatrix2" tHU9u0fvb0Waf1mGJ01+7g of Action "GetApprovalProcessDef"
public static async Task<(RL_21d5457a1d34649ed7b58b58f1d048d5,long)> datasetGetApprovalProcessMatrix2(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcessMatrix_ProcessTypeId,long qpreRegion_Id,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessMatrix2", "bb3d75b4-ef47-456f-9a7f-5986274d7eee");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessMatrix2", "bb3d75b4-ef47-456f-9a7f-5986274d7eee", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.tHU9u0fvb0Waf1mGJ01+7g, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess14\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess14\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess14\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43");
fromBuilder.Append(" FROM (({ApprovalProcess} \"enapprovalprocess14\" Left JOIN {ApprovalProcessMatrix} \"enapprovalprocessmatrix2\" ON (\"enapprovalprocess14\".\"id\" = \"enapprovalprocessmatrix2\".\"approvalprocessid\"))  Left JOIN {Region} \"enregion31\" ON (\"enapprovalprocessmatrix2\".\"region\" = \"enregion31\".\"commissionregion\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcessMatrix_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocessmatrix2\".\"processtypeid\" = @qpprApprovalProcessMatrix_ProcessTypeId) AND (\"enapprovalprocessmatrix2\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcessMatrix_ProcessTypeId", DbType.Int64, qpprApprovalProcessMatrix_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocessmatrix2\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocessmatrix2\".\"isactive\" = 1) AND ");
if (qpreRegion_Id != 0) {
whereBuilder.Append("((\"enregion31\".\"id\" = @qpreRegion_Id) AND (\"enregion31\".\"id\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpreRegion_Id", DbType.Int64, qpreRegion_Id);
} else {
whereBuilder.Append("(\"enregion31\".\"id\" IS NULL)");
}
whereBuilder.Append(" AND ((trim(\"enapprovalprocessmatrix2\".\"area\")) = '') AND (NOT (\"enapprovalprocess14\".\"isspecial\" = 1)) AND ((trim(\"enapprovalprocessmatrix2\".\"telceldirection\")) = '')");
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_21d5457a1d34649ed7b58b58f1d048d5 outParamList = new RL_21d5457a1d34649ed7b58b58f1d048d5();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix2ReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[3];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true});
opt[2] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessMatrix2.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_21d5457a1d34649ed7b58b58f1d048d5 _tmp = new RL_21d5457a1d34649ed7b58b58f1d048d5();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessMatrix2ReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessMatrix2.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_21d5457a1d34649ed7b58b58f1d048d5)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_9c2c2f8777df5db915ea9753325ce8dd> datasetGetApprovalProcessFolioSAEReadDbAsync(RC_9c2c2f8777df5db915ea9753325ce8dd rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENProcessType.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcessFolioSAE" tUQsxi6cvEOuoMWjjH6ACQ of Action "GetApprovalProcessDef"
public static async Task<(RL_acd66b694d90eb775616e6c6e3f83477,long)> datasetGetApprovalProcessFolioSAE(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,int qpapApprovalProcess_ApprovalProcessTypeId,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcessFolioSAE", "c62c44b5-9c2e-43bc-aea0-c5a38c7e8009");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcessFolioSAE", "c62c44b5-9c2e-43bc-aea0-c5a38c7e8009", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.tUQsxi6cvEOuoMWjjH6ACQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess15\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess15\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess15\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess15\" Inner JOIN {ProcessType} \"enprocesstype4\" ON (\"enapprovalprocess15\".\"processtypeid\" = \"enprocesstype4\".\"id\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess15\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess15\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess15\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess15\".\"isactive\" = 1) AND ");
if (qpapApprovalProcess_ApprovalProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess15\".\"approvalprocesstypeid\" = @qpapApprovalProcess_ApprovalProcessTypeId) AND (\"enapprovalprocess15\".\"approvalprocesstypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpapApprovalProcess_ApprovalProcessTypeId", DbType.Int32, qpapApprovalProcess_ApprovalProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess15\".\"approvalprocesstypeid\" IS NULL)");
}
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_acd66b694d90eb775616e6c6e3f83477 outParamList = new RL_acd66b694d90eb775616e6c6e3f83477();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessFolioSAEReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcessFolioSAE.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_acd66b694d90eb775616e6c6e3f83477 _tmp = new RL_acd66b694d90eb775616e6c6e3f83477();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessFolioSAEReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcessFolioSAE.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_acd66b694d90eb775616e6c6e3f83477)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

// Query Function "GetProcessTypeByCode" bWO93pV1nECeo845m9alZQ of Action "GetApprovalProcessDef"
public static async Task<(RL_50f86c7badf933578e482e000d347a03,long)> datasetGetProcessTypeByCode(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,string qpteCode,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetProcessTypeByCode", "debd636d-7595-409c-9ea3-ce399bd6a565");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetProcessTypeByCode", "debd636d-7595-409c-9ea3-ce399bd6a565", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.bWO93pV1nECeo845m9alZQ, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enprocesstype5\".\"id\" o0, \"enprocesstype5\".\"code\" o1, NULL o2, NULL o3, NULL o4");
fromBuilder.Append(" FROM {ProcessType} \"enprocesstype5\"");
whereBuilder.Append(" WHERE (\"enprocesstype5\".\"is_active\" = 1) AND (\"enprocesstype5\".\"code\" = @qpteCode)");
sqlCmd.CreateParameterWithoutReplacements("@qpteCode", DbType.String, qpteCode);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_50f86c7badf933578e482e000d347a03 outParamList = new RL_50f86c7badf933578e482e000d347a03();
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[1];
opt[0] = new BitArray(new bool[] {false, false, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_50f86c7badf933578e482e000d347a03 _tmp = new RL_50f86c7badf933578e482e000d347a03();
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetProcessTypeByCode.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_50f86c7badf933578e482e000d347a03)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}

private static async Task<RC_1c307c6ba13b1609f542644719b6e56b> datasetGetApprovalProcessReadDbAsync(RC_1c307c6ba13b1609f542644719b6e56b rec, DbDataReader r, CancellationToken cancellationToken) {
int index = 0;
rec.ssENApprovalProcess.Read( r, ref index);
rec.ssENApprovalProcessLevel.Read( r, ref index);
return rec;
}
// Query Function "GetApprovalProcess" rasX8BunI0WeZ_56_R7Lbw of Action "GetApprovalProcessDef"
public static async Task<(RL_8dbe9b3349c28479d314d27fe2f03197,long)> datasetGetApprovalProcess(IRequestContext requestContext,int maxRecords,int startIndex,IterationMultiplicity multiplicity,long qpprApprovalProcess_ProcessTypeId,long qpenApprovalProcessLevel_EntraRoleId,bool qpboApprovalProcessLevel_IsApplicant,bool qpboApprovalProcess_IsDonation,CancellationToken cancellationToken) {
long outParamCount = default;
using var appHealthMetric = AppHealthProvider.CreateServerQueryAggregateMetric("GetApprovalProcessDef.GetApprovalProcess", "f017abad-a71b-4523-9e67-fe7afd1ecb6f");
using var queryActivity = activitySource.CreateAggregateQueryActivity("GetApprovalProcessDef.GetApprovalProcess", "f017abad-a71b-4523-9e67-fe7afd1ecb6f", "ConectaProveedores", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
// Query Iterations: Never
if (multiplicity == IterationMultiplicity.Never) {
maxRecords = 1;
}
outParamCount = -1;
await using var trans = await DatabaseAccess.ForRuntimeDatabase.GetReadOnlyTransactionAsync(cancellationToken);
await using(var sqlCmd = trans.CreateCommand()){
string sql = "";
var selectBuilder = new StringBuilder();
var fromBuilder = new StringBuilder();
var whereBuilder = new StringBuilder();
var orderByBuilder = new StringBuilder();
var groupByBuilder = new StringBuilder();
var havingBuilder = new StringBuilder();
selectBuilder.Append("/* /UserActions.moOkcWtwWEmojQQ7QCPmoQ/NodesNotShownInESpaceTree.rasX8BunI0WeZ_56_R7Lbw, 588dd3e9-ffc1-4591-bd4e-2f57e6c30828 */");
selectBuilder.Append("SELECT \"enapprovalprocess16\".\"id\" o0, NULL o1, NULL o2, NULL o3, NULL o4, NULL o5, NULL o6, NULL o7, \"enapprovalprocess16\".\"version\" o8, NULL o9, NULL o10, \"enapprovalprocess16\".\"isspecial\" o11, NULL o12, NULL o13, NULL o14, NULL o15, NULL o16, NULL o17, NULL o18, NULL o19, NULL o20, NULL o21, NULL o22, NULL o23, NULL o24, NULL o25, NULL o26, NULL o27, NULL o28, NULL o29, NULL o30, NULL o31, NULL o32, NULL o33, NULL o34, NULL o35, NULL o36, NULL o37, NULL o38, NULL o39, NULL o40, NULL o41, NULL o42, NULL o43, NULL o44");
fromBuilder.Append(" FROM ({ApprovalProcess} \"enapprovalprocess16\" Left JOIN {ApprovalProcessLevel} \"enapprovalprocesslevel4\" ON (\"enapprovalprocess16\".\"id\" = \"enapprovalprocesslevel4\".\"approvalprocessid\")) ");
whereBuilder.Append(" WHERE ");
if (qpprApprovalProcess_ProcessTypeId != 0) {
whereBuilder.Append("((\"enapprovalprocess16\".\"processtypeid\" = @qpprApprovalProcess_ProcessTypeId) AND (\"enapprovalprocess16\".\"processtypeid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpprApprovalProcess_ProcessTypeId", DbType.Int64, qpprApprovalProcess_ProcessTypeId);
} else {
whereBuilder.Append("(\"enapprovalprocess16\".\"processtypeid\" IS NULL)");
}
whereBuilder.Append(" AND ");
if (qpenApprovalProcessLevel_EntraRoleId != 0) {
whereBuilder.Append("((\"enapprovalprocesslevel4\".\"entraroleid\" = @qpenApprovalProcessLevel_EntraRoleId) AND (\"enapprovalprocesslevel4\".\"entraroleid\" IS NOT NULL))");
sqlCmd.CreateParameterWithoutReplacements("@qpenApprovalProcessLevel_EntraRoleId", DbType.Int64, qpenApprovalProcessLevel_EntraRoleId);
} else {
whereBuilder.Append("(\"enapprovalprocesslevel4\".\"entraroleid\" IS NULL)");
}
whereBuilder.Append(" AND (\"enapprovalprocess16\".\"isdonation\" = @qpboApprovalProcess_IsDonation) AND (\"enapprovalprocess16\".\"isactive\" = 1) AND (\"enapprovalprocess16\".\"isspecial\" = 1) AND (\"enapprovalprocesslevel4\".\"isapplicant\" = @qpboApprovalProcessLevel_IsApplicant)");
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcess_IsDonation", DbType.Boolean, qpboApprovalProcess_IsDonation);
sqlCmd.CreateParameterWithoutReplacements("@qpboApprovalProcessLevel_IsApplicant", DbType.Boolean, qpboApprovalProcessLevel_IsApplicant);
if (maxRecords > 0) {
orderByBuilder.Append(" LIMIT ");
orderByBuilder.Append(maxRecords);
}
sql = selectBuilder.Append(fromBuilder).Append(whereBuilder).Append(groupByBuilder).Append(havingBuilder).Append(orderByBuilder).ToString();
string advSql = sql;
sql = AppUtils.Instance.ReplaceEntityReferences(requestContext, advSql);
sqlCmd.CommandText = sql;
queryActivity.AddSqlActivityTags(sql);
try {
RL_8dbe9b3349c28479d314d27fe2f03197 outParamList = new RL_8dbe9b3349c28479d314d27fe2f03197();
if (multiplicity != IterationMultiplicity.Multiple) {
outParamList.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
}
outParamList.Transaction = trans;
BitArray[] opt = new BitArray[2];
opt[0] = new BitArray(new bool[] {true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true});
opt[1] = new BitArray(new bool[] {false, true, true, true, true, true, true, true, false, true, true, false, true, true, true, true, true, true, true});
outParamList.AllOptimizedAttributes = opt;
if (multiplicity == IterationMultiplicity.Never) {
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, outParamList, "Query GetApprovalProcessDef.GetApprovalProcess.List", cancellationToken: cancellationToken);
await outParamList.LoadFromDatabase(cancellationToken);
outParamList.MaxRecords = maxRecords;
return (outParamList,outParamCount);
} finally {
await outParamList.CloseDataReaderAsync();
}
} else {
RL_8dbe9b3349c28479d314d27fe2f03197 _tmp = new RL_8dbe9b3349c28479d314d27fe2f03197();
_tmp.AlternateReadDbMethodAsync = datasetGetApprovalProcessReadDbAsync;
_tmp.Transaction = trans;
_tmp.AllOptimizedAttributes = opt;
_tmp.MaxRecords = maxRecords;
try {
await DatabaseAccess.ForRuntimeDatabase.ExecuteQueryAsync(sqlCmd, _tmp, "Query GetApprovalProcessDef.GetApprovalProcess.List", cancellationToken: cancellationToken);
await _tmp.LoadFromDatabase(cancellationToken);
outParamList = (RL_8dbe9b3349c28479d314d27fe2f03197)_tmp;
return (outParamList,outParamCount);
} finally {
await _tmp.CloseDataReaderAsync();
}
}
} catch (Exception e) {
throw DatabaseErrorsHelper.QueryError(e);
}
}
}



}


}
