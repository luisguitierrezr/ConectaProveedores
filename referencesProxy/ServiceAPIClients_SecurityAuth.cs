using System.Collections.ObjectModel;
using OutSystems.RESTService.Runtime.Core;
using OutSystems.RESTService.Runtime.Core.Controllers.ServiceActions;

using ssConectaProveedores.ReferencesProxy;

namespace ssConectaProveedores {
    public partial class RsseSpaceSecurityAuth {
        public class SecurityAuthServiceAPIClients : AbstractServiceApiClient {
            private static readonly SecurityAuthServiceAPIClients Instance = new();
            private SecurityAuthServiceAPIClients() : base(
                ObjectKey.Parse("97b32a7a-5154-4364-bb42-14d1f0d1f962"),
                "SecurityAuth",
                "ssConectaProveedores.SecurityAuthServiceAPIClients",
                ExceptionsMapping.GeneratedExceptionsClientMapping
            ) { }

            public class S4PIGetMaxSavedOldPasswordsInput {
public S4PIGetMaxSavedOldPasswordsInput() {
}

}

public class S4PIGetMaxSavedOldPasswordsOutput {
[JsonProperty("Value")]
public int outParamValue;
public S4PIGetMaxSavedOldPasswordsOutput(int outParamValue) {
this.outParamValue = outParamValue;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: GetMaxSavedOldPasswords
/// </summary>
public static async Task<int> GetMaxSavedOldPasswords(IRequestContext requestContext,CancellationToken cancellationToken) {
int outParamValue = default;
outParamValue = 0;

var serviceActionName = "GetMaxSavedOldPasswords";
var serviceActionKey = "0ed17075-cf0f-4a22-ae1f-a7edf1f58f99";
var inputs = new S4PIGetMaxSavedOldPasswordsInput();
var outputs = await Instance.InvokeServiceActionAsync<S4PIGetMaxSavedOldPasswordsInput, S4PIGetMaxSavedOldPasswordsOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamValue = outputs.outParamValue;
await Task.Yield();

return outParamValue;
}
public class S4PICheckOldPasswordInput {
[JsonProperty("i_Password")]
public string inParami_Password;
[JsonProperty("i_Email")]
public string inParami_Email;
public S4PICheckOldPasswordInput(string inParami_Password, string inParami_Email) {
this.inParami_Password = inParami_Password;
this.inParami_Email = inParami_Email;
}

}

public class S4PICheckOldPasswordOutput {
[JsonProperty("o_IsOld")]
public bool outParamo_IsOld;
public S4PICheckOldPasswordOutput(bool outParamo_IsOld) {
this.outParamo_IsOld = outParamo_IsOld;
}

public S4PICheckOldPasswordOutput() {
this.outParamo_IsOld = false;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: CheckOldPassword
/// </summary>
public static async Task<bool> CheckOldPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsOld = default;
outParamo_IsOld = false;

var serviceActionName = "CheckOldPassword";
var serviceActionKey = "10ecfa9b-484b-4230-a05a-9b00d75e9948";
var inputs = new S4PICheckOldPasswordInput(inParami_Password, inParami_Email);
var outputs = await Instance.InvokeServiceActionAsync<S4PICheckOldPasswordInput, S4PICheckOldPasswordOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_IsOld = outputs.outParamo_IsOld;
await Task.Yield();

return outParamo_IsOld;
}
public class S4PIServiceUserApplicationRoleTempRevokeInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource;
public S4PIServiceUserApplicationRoleTempRevokeInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource) {
this.inParamSource = inParamSource;
}

}

public class S4PIServiceUserApplicationRoleTempRevokeOutput {
[JsonProperty("Id")]
public long outParamId;
[JsonProperty("Output")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamOutput;
public S4PIServiceUserApplicationRoleTempRevokeOutput(long outParamId, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamOutput) {
this.outParamId = outParamId;
this.outParamOutput = outParamOutput;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceUserApplicationRoleTempRevoke
/// </summary>
public static async Task<(long,ST_346a76e47f982dbf41625f8a893affccStructure)> ServiceUserApplicationRoleTempRevoke(IRequestContext requestContext,EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource,CancellationToken cancellationToken) {
long outParamId = default;
ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput = default;
outParamId = 0L;

outParamOutput = new ST_346a76e47f982dbf41625f8a893affccStructure();

var serviceActionName = "ServiceUserApplicationRoleTempRevoke";
var serviceActionKey = "10fcff27-dd9e-4f9c-b738-da87c907599a";
var inputs = new S4PIServiceUserApplicationRoleTempRevokeInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(inParamSource, ServiceConfiguration));
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceUserApplicationRoleTempRevokeInput, S4PIServiceUserApplicationRoleTempRevokeOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
outParamOutput = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.ToStructure(outputs.outParamOutput, ServiceConfiguration);
await Task.Yield();

return (outParamId,outParamOutput);
}
public class S4PIServiceGrantFoliosInput {
[JsonProperty("Userid")]
public string inParamUserid;
public S4PIServiceGrantFoliosInput(string inParamUserid) {
this.inParamUserid = inParamUserid;
}

}

public class S4PIServiceGrantFoliosOutput {
public S4PIServiceGrantFoliosOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGrantFolios
/// </summary>
public static async Task ServiceGrantFolios(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var serviceActionName = "ServiceGrantFolios";
var serviceActionKey = "16c66d45-ae11-4e79-8310-fdd2fb43b7aa";
var inputs = new S4PIServiceGrantFoliosInput(inParamUserid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGrantFoliosInput, S4PIServiceGrantFoliosOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceUserApplicationRoleTempAssignInput {
[JsonProperty("Source")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource;
[JsonProperty("UserId")]
public string inParamUserId;
public S4PIServiceUserApplicationRoleTempAssignInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource, string inParamUserId) {
this.inParamSource = inParamSource;
this.inParamUserId = inParamUserId;
}

}

public class S4PIServiceUserApplicationRoleTempAssignOutput {
[JsonProperty("Id")]
public long outParamId;
[JsonProperty("Output")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamOutput;
public S4PIServiceUserApplicationRoleTempAssignOutput(long outParamId, ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamOutput) {
this.outParamId = outParamId;
this.outParamOutput = outParamOutput;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceUserApplicationRoleTempAssign
/// </summary>
public static async Task<(long,ST_346a76e47f982dbf41625f8a893affccStructure)> ServiceUserApplicationRoleTempAssign(IRequestContext requestContext,EN_20bdea9cf8f17569719f414a83b584b6EntityRecord inParamSource,string inParamUserId,CancellationToken cancellationToken) {
long outParamId = default;
ST_346a76e47f982dbf41625f8a893affccStructure outParamOutput = default;
outParamId = 0L;

outParamOutput = new ST_346a76e47f982dbf41625f8a893affccStructure();

var serviceActionName = "ServiceUserApplicationRoleTempAssign";
var serviceActionKey = "316139a0-14dd-4750-81a2-0f6f06a49e8b";
var inputs = new S4PIServiceUserApplicationRoleTempAssignInput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONEN_20bdea9cf8f17569719f414a83b584b6EntityRecord.FromStructure(inParamSource, ServiceConfiguration), inParamUserId);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceUserApplicationRoleTempAssignInput, S4PIServiceUserApplicationRoleTempAssignOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamId = outputs.outParamId;
outParamOutput = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.ToStructure(outputs.outParamOutput, ServiceConfiguration);
await Task.Yield();

return (outParamId,outParamOutput);
}
public class S4PIServiceRevokeProveedoresInput {
[JsonProperty("Userid")]
public string inParamUserid;
public S4PIServiceRevokeProveedoresInput(string inParamUserid) {
this.inParamUserid = inParamUserid;
}

}

public class S4PIServiceRevokeProveedoresOutput {
public S4PIServiceRevokeProveedoresOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceRevokeProveedores
/// </summary>
public static async Task ServiceRevokeProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var serviceActionName = "ServiceRevokeProveedores";
var serviceActionKey = "5adf4df4-e478-4162-99a7-d94392f926f2";
var inputs = new S4PIServiceRevokeProveedoresInput(inParamUserid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceRevokeProveedoresInput, S4PIServiceRevokeProveedoresOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PICheckLastPasswordInput {
[JsonProperty("i_Password")]
public string inParami_Password;
[JsonProperty("i_Email")]
public string inParami_Email;
public S4PICheckLastPasswordInput(string inParami_Password, string inParami_Email) {
this.inParami_Password = inParami_Password;
this.inParami_Email = inParami_Email;
}

}

public class S4PICheckLastPasswordOutput {
[JsonProperty("o_IsCorrect")]
public bool outParamo_IsCorrect;
public S4PICheckLastPasswordOutput(bool outParamo_IsCorrect) {
this.outParamo_IsCorrect = outParamo_IsCorrect;
}

public S4PICheckLastPasswordOutput() {
this.outParamo_IsCorrect = false;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: CheckLastPassword
/// </summary>
public static async Task<bool> CheckLastPassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
bool outParamo_IsCorrect = default;
outParamo_IsCorrect = false;

var serviceActionName = "CheckLastPassword";
var serviceActionKey = "5d2fc31d-7d9e-4c06-8af6-0f1692d49b10";
var inputs = new S4PICheckLastPasswordInput(inParami_Password, inParami_Email);
var outputs = await Instance.InvokeServiceActionAsync<S4PICheckLastPasswordInput, S4PICheckLastPasswordOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_IsCorrect = outputs.outParamo_IsCorrect;
await Task.Yield();

return outParamo_IsCorrect;
}
public class S4PIServiceGrantRequisicionesInput {
[JsonProperty("Userid")]
public string inParamUserid;
public S4PIServiceGrantRequisicionesInput(string inParamUserid) {
this.inParamUserid = inParamUserid;
}

}

public class S4PIServiceGrantRequisicionesOutput {
public S4PIServiceGrantRequisicionesOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGrantRequisiciones
/// </summary>
public static async Task ServiceGrantRequisiciones(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var serviceActionName = "ServiceGrantRequisiciones";
var serviceActionKey = "5e2e9313-e645-4844-aa9e-b9662ebcd7e0";
var inputs = new S4PIServiceGrantRequisicionesInput(inParamUserid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGrantRequisicionesInput, S4PIServiceGrantRequisicionesOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceSupplierCodeValidateInput {
[JsonProperty("UserEmail")]
public string inParamUserEmail;
[JsonProperty("Code")]
public string inParamCode;
public S4PIServiceSupplierCodeValidateInput(string inParamUserEmail, string inParamCode) {
this.inParamUserEmail = inParamUserEmail;
this.inParamCode = inParamCode;
}

}

public class S4PIServiceSupplierCodeValidateOutput {
[JsonProperty("IsValid")]
public bool outParamIsValid;
public S4PIServiceSupplierCodeValidateOutput(bool outParamIsValid) {
this.outParamIsValid = outParamIsValid;
}

public S4PIServiceSupplierCodeValidateOutput() {
this.outParamIsValid = false;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceSupplierCodeValidate
/// </summary>
public static async Task<bool> ServiceSupplierCodeValidate(IRequestContext requestContext,string inParamUserEmail,string inParamCode,CancellationToken cancellationToken) {
bool outParamIsValid = default;
outParamIsValid = false;

var serviceActionName = "ServiceSupplierCodeValidate";
var serviceActionKey = "6ab51d40-15c3-460f-b8ed-e5187ab2b7d7";
var inputs = new S4PIServiceSupplierCodeValidateInput(inParamUserEmail, inParamCode);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceSupplierCodeValidateInput, S4PIServiceSupplierCodeValidateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamIsValid = outputs.outParamIsValid;
await Task.Yield();

return outParamIsValid;
}
public class S4PIServiceSetSupplierLoginCodeInput {
[JsonProperty("Email")]
public string inParamEmail;
public S4PIServiceSetSupplierLoginCodeInput(string inParamEmail) {
this.inParamEmail = inParamEmail;
}

}

public class S4PIServiceSetSupplierLoginCodeOutput {
[JsonProperty("Code")]
public string outParamCode;
public S4PIServiceSetSupplierLoginCodeOutput(string outParamCode) {
this.outParamCode = outParamCode;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceSetSupplierLoginCode
/// </summary>
public static async Task<string> ServiceSetSupplierLoginCode(IRequestContext requestContext,string inParamEmail,CancellationToken cancellationToken) {
string outParamCode = default;
outParamCode = "";

var serviceActionName = "ServiceSetSupplierLoginCode";
var serviceActionKey = "6b653782-1ea3-4636-bb53-1980da43abdf";
var inputs = new S4PIServiceSetSupplierLoginCodeInput(inParamEmail);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceSetSupplierLoginCodeInput, S4PIServiceSetSupplierLoginCodeOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamCode = outputs.outParamCode;
await Task.Yield();

return outParamCode;
}
public class S4PISavePasswordInput {
[JsonProperty("i_Password")]
public string inParami_Password;
[JsonProperty("i_Email")]
public string inParami_Email;
public S4PISavePasswordInput(string inParami_Password, string inParami_Email) {
this.inParami_Password = inParami_Password;
this.inParami_Email = inParami_Email;
}

}

public class S4PISavePasswordOutput {
public S4PISavePasswordOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: SavePassword
/// </summary>
public static async Task SavePassword(IRequestContext requestContext,string inParami_Password,string inParami_Email,CancellationToken cancellationToken) {
var serviceActionName = "SavePassword";
var serviceActionKey = "8620b947-ec2a-47aa-9c8d-fe884bfe492e";
var inputs = new S4PISavePasswordInput(inParami_Password, inParami_Email);
var outputs = await Instance.InvokeServiceActionAsync<S4PISavePasswordInput, S4PISavePasswordOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceEntraRoleCreateInput {
[JsonProperty("i_RoleName")]
public string inParami_RoleName;
public S4PIServiceEntraRoleCreateInput(string inParami_RoleName) {
this.inParami_RoleName = inParami_RoleName;
}

}

public class S4PIServiceEntraRoleCreateOutput {
[JsonProperty("o_output")]
public ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamo_output;
[JsonProperty("HasBeenCreated")]
public bool outParamHasBeenCreated;
[JsonProperty("EntraRoleId")]
public long outParamEntraRoleId;
public S4PIServiceEntraRoleCreateOutput(ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure outParamo_output, bool outParamHasBeenCreated, long outParamEntraRoleId) {
this.outParamo_output = outParamo_output;
this.outParamHasBeenCreated = outParamHasBeenCreated;
this.outParamEntraRoleId = outParamEntraRoleId;
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceEntraRoleCreate
/// </summary>
public static async Task<(ST_346a76e47f982dbf41625f8a893affccStructure,bool,long)> ServiceEntraRoleCreate(IRequestContext requestContext,string inParami_RoleName,CancellationToken cancellationToken) {
ST_346a76e47f982dbf41625f8a893affccStructure outParamo_output = default;
bool outParamHasBeenCreated = default;
long outParamEntraRoleId = default;
outParamo_output = new ST_346a76e47f982dbf41625f8a893affccStructure();

outParamHasBeenCreated = false;

outParamEntraRoleId = 0L;

var serviceActionName = "ServiceEntraRoleCreate";
var serviceActionKey = "a8c8440b-8633-41be-b9d2-76339768ef2f";
var inputs = new S4PIServiceEntraRoleCreateInput(inParami_RoleName);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceEntraRoleCreateInput, S4PIServiceEntraRoleCreateOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
outParamo_output = ssConectaProveedores.ReferencesProxy.RestRecords.JSONST_346a76e47f982dbf41625f8a893affccStructure.ToStructure(outputs.outParamo_output, ServiceConfiguration);
outParamHasBeenCreated = outputs.outParamHasBeenCreated;
outParamEntraRoleId = outputs.outParamEntraRoleId;
await Task.Yield();

return (outParamo_output,outParamHasBeenCreated,outParamEntraRoleId);
}
public class S4PIServiceGrantProveedoresInput {
[JsonProperty("Userid")]
public string inParamUserid;
public S4PIServiceGrantProveedoresInput(string inParamUserid) {
this.inParamUserid = inParamUserid;
}

}

public class S4PIServiceGrantProveedoresOutput {
public S4PIServiceGrantProveedoresOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGrantProveedores
/// </summary>
public static async Task ServiceGrantProveedores(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var serviceActionName = "ServiceGrantProveedores";
var serviceActionKey = "bd963439-0d2b-49e5-bbbb-559975db79f9";
var inputs = new S4PIServiceGrantProveedoresInput(inParamUserid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGrantProveedoresInput, S4PIServiceGrantProveedoresOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}
public class S4PIServiceGrantPedidosInput {
[JsonProperty("Userid")]
public string inParamUserid;
public S4PIServiceGrantPedidosInput(string inParamUserid) {
this.inParamUserid = inParamUserid;
}

}

public class S4PIServiceGrantPedidosOutput {
public S4PIServiceGrantPedidosOutput() {
}

}

/// <summary>
/// ReferenceServiceAPIMethod: ServiceGrantPedidos
/// </summary>
public static async Task ServiceGrantPedidos(IRequestContext requestContext,string inParamUserid,CancellationToken cancellationToken) {
var serviceActionName = "ServiceGrantPedidos";
var serviceActionKey = "f406c4de-80f9-4639-ac10-33554089c5a0";
var inputs = new S4PIServiceGrantPedidosInput(inParamUserid);
var outputs = await Instance.InvokeServiceActionAsync<S4PIServiceGrantPedidosInput, S4PIServiceGrantPedidosOutput >(requestContext, inputs, serviceActionName, serviceActionKey, cancellationToken);
await Task.Yield();

return;
}

        }
    }
}
