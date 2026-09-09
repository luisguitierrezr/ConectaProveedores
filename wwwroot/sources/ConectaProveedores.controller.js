import { DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Logger as OS$Logger, Exceptions as OS$Exceptions, Controller as OS$Controller, SystemActions as OS$SystemActions, Flow as OS$Flow, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Authorization as OS$Authorization, SystemStructures as OS$SystemStructures } from "@outsystems/runtime-core-js";
import ConectaProveedores_controller_Base64ToBinary_GetAsBinaryJS from "./ConectaProveedores.controller$Base64ToBinary.GetAsBinaryJS.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { ST_f9f8b40f5330871047e55e068d129447Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_controller_HideLoading_HideDivJS from "./ConectaProveedores.controller$HideLoading.HideDivJS.js";
import ConectaProveedores_controller_ShowLoading_ShowDivJS from "./ConectaProveedores.controller$ShowLoading.ShowDivJS.js";
import ConectaProveedores_controller_TransformMaterialCode_JavaScriptJS from "./ConectaProveedores.controller$TransformMaterialCode.JavaScriptJS.js";
import ConectaProveedores_Controller_translationsResources from "./ConectaProveedores.controller$translationsResources.js";

class Controller extends 
OS$Controller.BaseModuleController {
constructor(model, messagesProvider, idService, translationResources) {
super(model, messagesProvider, idService, translationResources);
}

get clientActionProxies() {if(!(this.hasOwnProperty("_clientActionProxies"))) {
this._clientActionProxies = {};
}

return this._clientActionProxies;
}set clientActionProxies(value) {this._clientActionProxies = value;
}

checkConectaProveedoresRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ConectaProveedores.roleKey
});
return outVars;

}

checkHistoricoRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Historico.roleKey
});
return outVars;

}

checkComissionesArrendamientosViewerRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ComissionesArrendamientosViewer.roleKey
});
return outVars;

}

checkConectaProveedoresAdminRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ConectaProveedoresAdmin.roleKey
});
return outVars;

}

checkComissionesArrendamientosRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ComissionesArrendamientos.roleKey
});
return outVars;

}

checkFoliosRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Folios.roleKey
});
return outVars;

}

checkComissionesArrendamientosAdminRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ComissionesArrendamientosAdmin.roleKey
});
return outVars;

}

checkAlmacenRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Almacen.roleKey
});
return outVars;

}

checkReportesRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Reportes.roleKey
});
return outVars;

}

checkConectaProveedoresAdminViewerRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.ConectaProveedoresAdminViewer.roleKey
});
return outVars;

}

checkPedidosRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Pedidos.roleKey
});
return outVars;

}

checkTesoreriaRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Tesoreria.roleKey
});
return outVars;

}

checkDesviacionesRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Desviaciones.roleKey
});
return outVars;

}

checkProveedorRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Proveedor.roleKey
});
return outVars;

}

checkSAPImportOrdersRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.SAPImportOrders.roleKey
});
return outVars;

}

checkRequisicionesRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.Requisiciones.roleKey
});
return outVars;

}

checkTelcelUserAuditorRole$Action(callContext) {
var outVars = new OS$SystemStructures.HasRoleResultRec();
outVars.hasRoleOut = OS$Authorization.hasRole({
roleKey: this.roles.TelcelUserAuditor.roleKey
});
return outVars;

}


get roles() {if(!(this.hasOwnProperty("_roles"))) {
this._roles = {
ConectaProveedores: {
roleKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828.ab2a6b39-1f30-4f20-a069-cf5d18b076f4",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("ConectaProveedores.NotConectaProveedores", "ConectaProveedores role required")
},
Historico: {
roleKey: "16f016a3-8a05-49c8-b466-604e4b49fc9b.ab2a6b39-1f30-4f20-a069-cf5d18b076f4",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("Historico.NotHistorico", "Historico role required")
},
ComissionesArrendamientosViewer: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.1955aaab-bab8-4256-8271-f6a652e160a2",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotComissionesArrendamientosViewer", "ComissionesArrendamientosViewer role required")
},
ConectaProveedoresAdmin: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.4537b835-af2c-44d8-8c81-07366dca170b",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotConectaProveedoresAdmin", "ConectaProveedoresAdmin role required")
},
ComissionesArrendamientos: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.4cccd23d-b2a2-458c-ab41-171a0c4b11c1",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotComissionesArrendamientos", "ComissionesArrendamientos role required")
},
Folios: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.4e8019b3-a11c-4cab-9c84-d5734ccff1b7",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotFolios", "Folios role required")
},
ComissionesArrendamientosAdmin: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.5d28b79f-52bf-4ca8-b423-0663a3247cc0",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotComissionesArrendamientosAdmin", "ComissionesArrendamientosAdmin role required")
},
Almacen: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.78ed663d-72f7-4542-82e0-d905baffab28",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotAlmacen", "Almacen role required")
},
Reportes: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.80402494-fde0-44cf-8e53-6cbe04981508",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotReportes", "Reportes role required")
},
ConectaProveedoresAdminViewer: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.80823de3-27f5-4167-bc84-b83d4cf96875",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotConectaProveedoresAdminViewer", "ConectaProveedoresAdminViewer role required")
},
Pedidos: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.81bb9fa7-0723-4789-a274-d6a79e66f8d3",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotPedidos", "Pedidos role required")
},
Tesoreria: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.96518fda-3b92-4bee-8244-685b82a41876",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotTesoreria", "Tesoreria role required")
},
Desviaciones: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.b2c09cc7-11c7-409b-882b-ce6b2f5d89cf",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotDesviaciones", "Desviaciones role required")
},
Proveedor: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.ba07b766-1450-472a-b89f-5373332a8e70",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotProveedor", "Proveedor role required")
},
SAPImportOrders: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.df64733a-7f25-4feb-acc8-b55e115f80d4",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotSAPImportOrders", "SAPImportOrders role required")
},
Requisiciones: {
roleKey: "97b32a7a-5154-4364-bb42-14d1f0d1f962.fc2294dd-bd3e-43f8-844d-1189dad57953",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotRequisiciones", "Requisiciones role required")
},
TelcelUserAuditor: {
roleKey: "abbc6e11-902c-4319-878b-9d0fec641e61.83a0de9c-e92d-40d6-be3e-064ea822b257",
roleException: new OS$Exceptions.Exceptions.NotRegisteredException("TelCelUsersManagement.NotTelcelUserAuditor", "TelcelUserAuditor role required")
}
};
}

return this._roles;
}set roles(value) {this._roles = value;
}

get defaultTimeout() {if(!(this.hasOwnProperty("_defaultTimeout"))) {
this._defaultTimeout = 60;
}

return this._defaultTimeout;
}set defaultTimeout(value) {this._defaultTimeout = value;
}

getDefaultTimeout() {
return this.defaultTimeout;
}

}

var ConectaProveedoresController = new Controller(ConectaProveedores_Controller_translationsResources);

var controller = ConectaProveedoresController;
export function base64ToBinary$Action(base64In, callContext) {
return OS$Logger.startActiveSpan("Base64ToBinary", function (span) {
if(span) {
span.setAttribute("code.function", "Base64ToBinary");
span.setAttribute("outsystems.function.key", "1959f3fd-baf3-450d-8381-2ea7b0ee1fcc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.Base64ToBinary$vars"))());
vars.value.base64InLocal = base64In;
var getAsBinaryJSResult = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.Base64ToBinary$outVars"))());
getAsBinaryJSResult.value = OS$Logger.startActiveSpan("GetAsBinary", function (span) {
if(span) {
span.setAttribute("code.function", "GetAsBinary");
span.setAttribute("outsystems.function.key", "c556a190-e1f9-4fc8-a093-841b93f48609");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_controller_Base64ToBinary_GetAsBinaryJS, "GetAsBinary", "Base64ToBinary", {
Base64: OS$DataConversion.JSNodeParamConverter.to(vars.value.base64InLocal, OS$DataTypes.DataTypes.Text),
Binary: OS$DataConversion.JSNodeParamConverter.to(OS$DataTypes.BinaryData.defaultValue, OS$DataTypes.DataTypes.BinaryData)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.Base64ToBinary$getAsBinaryJSResult"))();
jsNodeResult.binaryOut = OS$DataConversion.JSNodeParamConverter.from($parameters.Binary, OS$DataTypes.DataTypes.BinaryData);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// Binary = GetAsBinary.Binary
outVars.value.binaryOut = getAsBinaryJSResult.value.binaryOut;
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.Base64ToBinary$vars", [{
name: "Base64",
attrName: "base64InLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.Base64ToBinary$getAsBinaryJSResult", [{
name: "Binary",
attrName: "binaryOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.Base64ToBinary$outVars", [{
name: "Binary",
attrName: "binaryOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
export function base64ToBinary$Action$Proxy(base64In) {
base64In = (base64In === undefined) ? "" : base64In;
return controller.executeActionInsideJSNode(base64ToBinary$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(base64In, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Binary: OS$DataConversion.JSNodeParamConverter.to(actionResults.binaryOut, OS$DataTypes.DataTypes.BinaryData)
};
});
};


export function doLogin$Action(usernameIn, passwordIn, environmentIn, callContext) {
return OS$Logger.startActiveSpan("DoLogin", function (span) {
if(span) {
span.setAttribute("code.function", "DoLogin");
span.setAttribute("outsystems.function.key", "c45e4ea0-ddd3-4e73-abfc-ba43af7d5ab7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

return OS$Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.DoLogin$vars"))());
vars.value.usernameInLocal = usernameIn;
vars.value.passwordInLocal = passwordIn;
vars.value.environmentInLocal = environmentIn;
var loginVar = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.DoLogin$outVars"))());
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: Login
return OS$SystemActions.login(vars.value.usernameInLocal, vars.value.passwordInLocal, callContext).then(function (value) {
loginVar.value = value;
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((loginVar.value.userLoginResultOut.successAttr)) {
// Success = True
// Success = True
outVars.value.successOut = true;
} else {
// Too many failed login attempts?
return OS$Flow.executeSequence(function () {
if((loginVar.value.userLoginResultOut.userLoginFailureReasonAttr.tooManyFailedLoginAttemptsAttr)) {
// Set error message
// ErrorMessage = "The account has been blocked for exceeding the number of allowed attempts, in accordance with the defined security policies. Retry in " + " " + Round + " " + "minutes"
outVars.value.errorMessageOut = ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Act6g0oRUUSWXjgcidUTgA#Value.-189464785.1", "The account has been blocked for exceeding the number of allowed attempts, in accordance with the defined security policies. Retry in ") + " ") + OS$BuiltinFunctions.decimalToText(OS$BuiltinFunctions.round(OS$BuiltinFunctions.integerToDecimal(loginVar.value.userLoginResultOut.retryAfterSecondsAttr).div(OS$BuiltinFunctions.integerToDecimal(60)).plus(OS$BuiltinFunctions.integerToDecimal(1)), 0))) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Act6g0oRUUSWXjgcidUTgA#Value.1064901855.1", "minutes"));
// BlockedAccount = True
outVars.value.blockedAccountOut = true;
// TimeLeft = Login.UserLoginResult.RetryAfterSeconds
outVars.value.timeLeftOut = loginVar.value.userLoginResultOut.retryAfterSecondsAttr;
// Execute Action: SendLoginAlert
return sendLoginAlert$ServerAction(vars.value.usernameInLocal, vars.value.environmentInLocal, callContext);
} else {
// Invalid credentials?
if((loginVar.value.userLoginResultOut.userLoginFailureReasonAttr.invalidCredentialsAttr)) {
// Set error message
// ErrorMessage = "Check Fields"
outVars.value.errorMessageOut = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hDy+QgHcK0uaDF0MWFUDAw#Value.-1121515247.1", "Check Fields");
} else {
// Set error message
// ErrorMessage = "Login operation failed."
outVars.value.errorMessageOut = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("iJPucXP03kykA9tDP5KOqQ#Value.1534292161.1", "Login operation failed.");
// UserId = Login.UserLoginResult.UserId
outVars.value.userIdOut = loginVar.value.userLoginResultOut.userIdAttr;
}

}

});
}

});
});
}).then(function () {
return outVars.value;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.DoLogin$vars", [{
name: "Username",
attrName: "usernameInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Password",
attrName: "passwordInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Environment",
attrName: "environmentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.DoLogin$outVars", [{
name: "Success",
attrName: "successOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "ErrorMessage",
attrName: "errorMessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "UserId",
attrName: "userIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "BlockedAccount",
attrName: "blockedAccountOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "TimeLeft",
attrName: "timeLeftOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
export function doLogin$Action$Proxy(usernameIn, passwordIn, environmentIn) {
usernameIn = (usernameIn === undefined) ? "" : usernameIn;
passwordIn = (passwordIn === undefined) ? "" : passwordIn;
environmentIn = (environmentIn === undefined) ? "" : environmentIn;
return controller.executeActionInsideJSNode(doLogin$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(usernameIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(passwordIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(environmentIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Success: OS$DataConversion.JSNodeParamConverter.to(actionResults.successOut, OS$DataTypes.DataTypes.Boolean),
ErrorMessage: OS$DataConversion.JSNodeParamConverter.to(actionResults.errorMessageOut, OS$DataTypes.DataTypes.Text),
UserId: actionResults.userIdOut,
BlockedAccount: OS$DataConversion.JSNodeParamConverter.to(actionResults.blockedAccountOut, OS$DataTypes.DataTypes.Boolean),
TimeLeft: OS$DataConversion.JSNodeParamConverter.to(actionResults.timeLeftOut, OS$DataTypes.DataTypes.Integer)
};
});
};


export function file_Validate$Action(fileSizeIn, filesMaxSizeIn, fileContentIn, acceptedFileTypesIn, fileTypeIn, callContext) {
return OS$Logger.startActiveSpan("File_Validate", function (span) {
if(span) {
span.setAttribute("code.function", "File_Validate");
span.setAttribute("outsystems.function.key", "a57c3752-ba69-4e74-aba6-a4da0b3452e0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.File_Validate$vars"))());
vars.value.fileSizeInLocal = fileSizeIn;
vars.value.filesMaxSizeInLocal = filesMaxSizeIn;
vars.value.fileContentInLocal = fileContentIn;
vars.value.acceptedFileTypesInLocal = acceptedFileTypesIn;
vars.value.fileTypeInLocal = fileTypeIn;
var validateFileTypeVar = new OS$DataTypes.VariableHolder();
var validateFileSizeVar = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.File_Validate$outVars"))());
if((((vars.value.filesMaxSizeInLocal) !== (0)))) {
// Execute Action: ValidateFileSize
validateFileSizeVar.value = validateFileSize$Action(vars.value.fileSizeInLocal, vars.value.filesMaxSizeInLocal, callContext);

// ValidFileSize?
if((!(validateFileSizeVar.value.isValidOut))) {
// Set Max File Size Defined error
// Error.Success = False
outVars.value.errorOut.successAttr = false;
// Error.ErrorMessage = "File exceeds the max file size defined! Max:" + " " + FormatDecimal + "MB"
outVars.value.errorOut.errorMessageAttr = (((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("FfGhfJHs80S2mGMR5YyYRA#Value.-182760109.1", "File exceeds the max file size defined! Max:") + " ") + OS$BuiltinFunctions.formatDecimal(OS$BuiltinFunctions.integerToDecimal(vars.value.filesMaxSizeInLocal).div(OS$BuiltinFunctions.integerToDecimal(1048576)), 0, "", "")) + "MB");
return outVars.value;

}

}

// EmptyAcceptedFileTypes?
if((!((vars.value.acceptedFileTypesInLocal === "")))) {
// Execute Action: ValidateFileType
validateFileTypeVar.value = validateFileType$Action(vars.value.fileTypeInLocal, vars.value.acceptedFileTypesInLocal, callContext);

// ValidFileType
if((!(validateFileTypeVar.value.isValidOut))) {
// Set ErrorMessage
// Error.Success = False
outVars.value.errorOut.successAttr = false;
// Error.ErrorMessage = "File doesn't correspond to the accepted files type to accept"
outVars.value.errorOut.errorMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("j6zXi4IwMUSc_+xgX8FwMQ#Value.-625141692.1", "File doesn\'t correspond to the accepted files type to accept");
return outVars.value;

}

}

// Set ValidBase64 & Success = True
// ValidBase64 = Substr
outVars.value.validBase64Out = OS$BuiltinFunctions.substr(vars.value.fileContentInLocal, (OS$BuiltinFunctions.index(vars.value.fileContentInLocal, ",", 0, false, false) + 1), OS$BuiltinFunctions.length(vars.value.fileContentInLocal));
// Error.Success = True
outVars.value.errorOut.successAttr = true;
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.File_Validate$vars", [{
name: "FileSize",
attrName: "fileSizeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "FilesMaxSize",
attrName: "filesMaxSizeInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "FileContent",
attrName: "fileContentInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "AcceptedFileTypes",
attrName: "acceptedFileTypesInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "FileType",
attrName: "fileTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.File_Validate$outVars", [{
name: "ValidBase64",
attrName: "validBase64Out",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "Error",
attrName: "errorOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_f9f8b40f5330871047e55e068d129447Structure();
},
complexType: ST_f9f8b40f5330871047e55e068d129447Structure
}]);
export function file_Validate$Action$Proxy(fileSizeIn, filesMaxSizeIn, fileContentIn, acceptedFileTypesIn, fileTypeIn) {
fileSizeIn = (fileSizeIn === undefined) ? 0 : fileSizeIn;
filesMaxSizeIn = (filesMaxSizeIn === undefined) ? 0 : filesMaxSizeIn;
fileContentIn = (fileContentIn === undefined) ? "" : fileContentIn;
acceptedFileTypesIn = (acceptedFileTypesIn === undefined) ? "" : acceptedFileTypesIn;
fileTypeIn = (fileTypeIn === undefined) ? "" : fileTypeIn;
return controller.executeActionInsideJSNode(file_Validate$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(fileSizeIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(filesMaxSizeIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(fileContentIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(acceptedFileTypesIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(fileTypeIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
ValidBase64: OS$DataConversion.JSNodeParamConverter.to(actionResults.validBase64Out, OS$DataTypes.DataTypes.Text),
Error: actionResults.errorOut
};
});
};


export function formatEmpty$Action(i_TextIn, callContext) {
return OS$Logger.startActiveSpan("FormatEmpty", function (span) {
if(span) {
span.setAttribute("code.function", "FormatEmpty");
span.setAttribute("outsystems.function.key", "805fc817-4a57-4113-9618-3042050f6e02");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.FormatEmpty$vars"))());
vars.value.i_TextInLocal = i_TextIn;
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.FormatEmpty$outVars"))());
// o_Output = If
outVars.value.o_OutputOut = (((OS$BuiltinFunctions.trim(vars.value.i_TextInLocal) === "")) ? ("-") : (vars.value.i_TextInLocal));
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.FormatEmpty$vars", [{
name: "i_Text",
attrName: "i_TextInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.FormatEmpty$outVars", [{
name: "o_Output",
attrName: "o_OutputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
export function formatEmpty$Action$Proxy(i_TextIn) {
i_TextIn = (i_TextIn === undefined) ? "" : i_TextIn;
return controller.executeActionInsideJSNode(formatEmpty$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(i_TextIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
o_Output: OS$DataConversion.JSNodeParamConverter.to(actionResults.o_OutputOut, OS$DataTypes.DataTypes.Text)
};
});
};


export function generateReqName$Action(i_RegionIdIn, callContext) {
return OS$Logger.startActiveSpan("GenerateReqName", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReqName");
span.setAttribute("outsystems.function.key", "578aaf8e-9662-492b-9014-e8d71f276380");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

return OS$Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GenerateReqName$vars"))());
vars.value.i_RegionIdInLocal = i_RegionIdIn;
var generateReqNameVar = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GenerateReqName$outVars"))());
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GenerateReqName
return generateReqName$ServerAction(vars.value.i_RegionIdInLocal, callContext).then(function (value) {
generateReqNameVar.value = value;
}).then(function () {
// o_Name = GenerateReqName.o_Name
outVars.value.o_NameOut = generateReqNameVar.value.o_NameOut;
// o_Counter = GenerateReqName.o_Counter
outVars.value.o_CounterOut = generateReqNameVar.value.o_CounterOut;
});
}).then(function () {
return outVars.value;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GenerateReqName$vars", [{
name: "i_RegionId",
attrName: "i_RegionIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GenerateReqName$outVars", [{
name: "o_Name",
attrName: "o_NameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_Counter",
attrName: "o_CounterOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
export function generateReqName$Action$Proxy(i_RegionIdIn) {
i_RegionIdIn = (i_RegionIdIn === undefined) ? OS$DataTypes.LongInteger.defaultValue : i_RegionIdIn;
return controller.executeActionInsideJSNode(generateReqName$Action.bind(controller, i_RegionIdIn), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
o_Name: OS$DataConversion.JSNodeParamConverter.to(actionResults.o_NameOut, OS$DataTypes.DataTypes.Text),
o_Counter: OS$DataConversion.JSNodeParamConverter.to(actionResults.o_CounterOut, OS$DataTypes.DataTypes.Integer)
};
});
};


export function getClientTimeouts$Action(callContext) {
return OS$Logger.startActiveSpan("GetClientTimeouts", function (span) {
if(span) {
span.setAttribute("code.function", "GetClientTimeouts");
span.setAttribute("outsystems.function.key", "23887137-9642-41f9-a7fa-d8d4052bce55");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetClientTimeouts$outVars"))());
// ValueWarning = TimeToWarning
outVars.value.valueWarningOut = ConectaProveedoresClientVariables.getTimeToWarning();
// ValueLogout = TimeToLogout
outVars.value.valueLogoutOut = ConectaProveedoresClientVariables.getTimeToLogout();
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetClientTimeouts$outVars", [{
name: "ValueWarning",
attrName: "valueWarningOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}, {
name: "ValueLogout",
attrName: "valueLogoutOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
export function getClientTimeouts$Action$Proxy() {
return controller.executeActionInsideJSNode(getClientTimeouts$Action.bind(controller), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
ValueWarning: OS$DataConversion.JSNodeParamConverter.to(actionResults.valueWarningOut, OS$DataTypes.DataTypes.DateTime),
ValueLogout: OS$DataConversion.JSNodeParamConverter.to(actionResults.valueLogoutOut, OS$DataTypes.DataTypes.DateTime)
};
});
};


export function getEnviroment$Action(callContext) {
return OS$Logger.startActiveSpan("GetEnviroment", function (span) {
if(span) {
span.setAttribute("code.function", "GetEnviroment");
span.setAttribute("outsystems.function.key", "50f05309-07e4-4704-bd8d-cdb9ded25d46");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetEnviroment$outVars"))());
// Enviroment = Enviroment
outVars.value.enviromentOut = ConectaProveedoresClientVariables.getEnviroment();
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetEnviroment$outVars", [{
name: "Enviroment",
attrName: "enviromentOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
export function getEnviroment$Action$Proxy() {
return controller.executeActionInsideJSNode(getEnviroment$Action.bind(controller), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Enviroment: OS$DataConversion.JSNodeParamConverter.to(actionResults.enviromentOut, OS$DataTypes.DataTypes.Text)
};
});
};


export function getFileChunk$Action(fileIdIn, chunkIndexIn, totalChunksIn, guidIn, callContext) {
return OS$Logger.startActiveSpan("GetFileChunk", function (span) {
if(span) {
span.setAttribute("code.function", "GetFileChunk");
span.setAttribute("outsystems.function.key", "caca78d7-973d-409d-9df9-c042a12bf749");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

return OS$Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetFileChunk$vars"))());
vars.value.fileIdInLocal = fileIdIn;
vars.value.chunkIndexInLocal = chunkIndexIn;
vars.value.totalChunksInLocal = totalChunksIn;
vars.value.guidInLocal = guidIn;
var serviceStorageGetFileByPartsVar = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetFileChunk$outVars"))());
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ServiceStorageGetFileByParts
return serviceStorageGetFileByParts$ServerAction(OS$BuiltinFunctions.longIntegerToIdentifier(vars.value.fileIdInLocal), vars.value.chunkIndexInLocal, vars.value.totalChunksInLocal, vars.value.guidInLocal, callContext).then(function (value) {
serviceStorageGetFileByPartsVar.value = value;
}).then(function () {
// ChunkText = ServiceStorageGetFileByParts.o_fileInText
outVars.value.chunkTextOut = serviceStorageGetFileByPartsVar.value.o_fileInTextOut;
});
}).then(function () {
return outVars.value;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetFileChunk$vars", [{
name: "fileId",
attrName: "fileIdInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}, {
name: "chunkIndex",
attrName: "chunkIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "totalChunks",
attrName: "totalChunksInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Guid",
attrName: "guidInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetFileChunk$outVars", [{
name: "ChunkText",
attrName: "chunkTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
export function getFileChunk$Action$Proxy(fileIdIn, chunkIndexIn, totalChunksIn, guidIn) {
fileIdIn = (fileIdIn === undefined) ? OS$DataTypes.LongInteger.defaultValue : fileIdIn;
chunkIndexIn = (chunkIndexIn === undefined) ? 0 : chunkIndexIn;
totalChunksIn = (totalChunksIn === undefined) ? 0 : totalChunksIn;
guidIn = (guidIn === undefined) ? "" : guidIn;
return controller.executeActionInsideJSNode(getFileChunk$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(fileIdIn, OS$DataTypes.DataTypes.LongInteger), OS$DataConversion.JSNodeParamConverter.from(chunkIndexIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(totalChunksIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(guidIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
ChunkText: OS$DataConversion.JSNodeParamConverter.to(actionResults.chunkTextOut, OS$DataTypes.DataTypes.Text)
};
});
};


export function getNextMonday$Action(baseDateTimeIn, callContext) {
return OS$Logger.startActiveSpan("GetNextMonday", function (span) {
if(span) {
span.setAttribute("code.function", "GetNextMonday");
span.setAttribute("outsystems.function.key", "f30ba018-51a6-4c72-b8f6-3d62fae84d55");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetNextMonday$vars"))());
vars.value.baseDateTimeInLocal = baseDateTimeIn;
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetNextMonday$outVars"))());
// Days = Mod
outVars.value.daysOut = OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.mod(OS$BuiltinFunctions.integerToDecimal((8 - OS$BuiltinFunctions.dayOfWeek(vars.value.baseDateTimeInLocal))), OS$BuiltinFunctions.integerToDecimal(7))));
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetNextMonday$vars", [{
name: "BaseDateTime",
attrName: "baseDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetNextMonday$outVars", [{
name: "Days",
attrName: "daysOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
export function getNextMonday$Action$Proxy(baseDateTimeIn) {
baseDateTimeIn = (baseDateTimeIn === undefined) ? OS$DataTypes.DateTime.defaultValue : baseDateTimeIn;
return controller.executeActionInsideJSNode(getNextMonday$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(baseDateTimeIn, OS$DataTypes.DataTypes.DateTime)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Days: OS$DataConversion.JSNodeParamConverter.to(actionResults.daysOut, OS$DataTypes.DataTypes.Integer)
};
});
};


export function getUserRegion$Action(callContext) {
return OS$Logger.startActiveSpan("GetUserRegion", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserRegion");
span.setAttribute("outsystems.function.key", "fc28f619-6624-4d8a-8ffd-a75cfd10a9b0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

return OS$Flow.tryFinally(function () {
callContext = controller.callContext(callContext);
var getUserLoggedRegionVar = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.GetUserRegion$outVars"))());
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: GetUserLoggedRegion
return getUserRegionId$ServerAction("", callContext).then(function (value) {
getUserLoggedRegionVar.value = value;
}).then(function () {
// RegionId = GetUserLoggedRegion.o_RegionId
outVars.value.regionIdOut = getUserLoggedRegionVar.value.o_RegionIdOut;
});
}).then(function () {
return outVars.value;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.GetUserRegion$outVars", [{
name: "RegionId",
attrName: "regionIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
export function getUserRegion$Action$Proxy() {
return controller.executeActionInsideJSNode(getUserRegion$Action.bind(controller), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
RegionId: actionResults.regionIdOut
};
});
};


export function hideLoading$Action(callContext) {
return OS$Logger.startActiveSpan("HideLoading", function (span) {
if(span) {
span.setAttribute("code.function", "HideLoading");
span.setAttribute("outsystems.function.key", "8c4d794d-f068-4c72-8f27-c01ba778ff2c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("HideDiv", function (span) {
if(span) {
span.setAttribute("code.function", "HideDiv");
span.setAttribute("outsystems.function.key", "5115d5cf-6794-4775-872c-1d0daefc5a88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_controller_HideLoading_HideDivJS, "HideDiv", "HideLoading", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return ;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


export function hideLoading$Action$Proxy() {
return controller.executeActionInsideJSNode(hideLoading$Action.bind(controller), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {};
});
};


export function isListValid$Action(listIn, callContext) {
return OS$Logger.startActiveSpan("IsListValid", function (span) {
if(span) {
span.setAttribute("code.function", "IsListValid");
span.setAttribute("outsystems.function.key", "7bece566-45a7-4847-aae9-71fb5c60d098");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.IsListValid$vars"))());
vars.value.listInLocal = listIn.clone();
var listAnyEmpty_Var = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.IsListValid$outVars"))());
// Execute Action: ListAnyEmpty_
listAnyEmpty_Var.value = OS$SystemActions.listAny(vars.value.listInLocal, function (p) {
return (OS$BuiltinFunctions.trim(p) === "");
}, callContext);

// Result = notListAnyEmpty_.Result
outVars.value.resultOut = (!(listAnyEmpty_Var.value.resultOut));
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.IsListValid$vars", [{
name: "List",
attrName: "listInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new OS$DataTypes.TextList();
},
complexType: OS$DataTypes.TextList
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.IsListValid$outVars", [{
name: "Result",
attrName: "resultOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
export function isListValid$Action$Proxy(listIn) {
listIn = (listIn === undefined) ? new OS$DataTypes.TextList() : listIn;
return controller.executeActionInsideJSNode(isListValid$Action.bind(controller, listIn), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Result: OS$DataConversion.JSNodeParamConverter.to(actionResults.resultOut, OS$DataTypes.DataTypes.Boolean)
};
});
};


export function setClientTimeouts$Action(valueWarningIn, valueLogoutIn, callContext) {
return OS$Logger.startActiveSpan("SetClientTimeouts", function (span) {
if(span) {
span.setAttribute("code.function", "SetClientTimeouts");
span.setAttribute("outsystems.function.key", "0f8f153d-7336-4f22-96ed-4da3d8dcbb3d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.SetClientTimeouts$vars"))());
vars.value.valueWarningInLocal = valueWarningIn;
vars.value.valueLogoutInLocal = valueLogoutIn;
// TimeToWarning = ValueWarning
ConectaProveedoresClientVariables.setTimeToWarning(vars.value.valueWarningInLocal);
// TimeToLogout = ValueLogout
ConectaProveedoresClientVariables.setTimeToLogout(vars.value.valueLogoutInLocal);
return ;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.SetClientTimeouts$vars", [{
name: "ValueWarning",
attrName: "valueWarningInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}, {
name: "ValueLogout",
attrName: "valueLogoutInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
export function setClientTimeouts$Action$Proxy(valueWarningIn, valueLogoutIn) {
valueWarningIn = (valueWarningIn === undefined) ? OS$DataTypes.DateTime.defaultValue : valueWarningIn;
valueLogoutIn = (valueLogoutIn === undefined) ? OS$DataTypes.DateTime.defaultValue : valueLogoutIn;
return controller.executeActionInsideJSNode(setClientTimeouts$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(valueWarningIn, OS$DataTypes.DataTypes.DateTime), OS$DataConversion.JSNodeParamConverter.from(valueLogoutIn, OS$DataTypes.DataTypes.DateTime)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {};
});
};


export function showLoading$Action(callContext) {
return OS$Logger.startActiveSpan("ShowLoading", function (span) {
if(span) {
span.setAttribute("code.function", "ShowLoading");
span.setAttribute("outsystems.function.key", "4ea15a48-4700-434e-b947-5b5994aa6529");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
OS$Logger.startActiveSpan("ShowDiv", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDiv");
span.setAttribute("outsystems.function.key", "68754610-2a1b-4736-9117-e746f1881df0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_controller_ShowLoading_ShowDivJS, "ShowDiv", "ShowLoading", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
return ;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


export function showLoading$Action$Proxy() {
return controller.executeActionInsideJSNode(showLoading$Action.bind(controller), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {};
});
};


export function transformMaterialCode$Action(textInIn, callContext) {
return OS$Logger.startActiveSpan("TransformMaterialCode", function (span) {
if(span) {
span.setAttribute("code.function", "TransformMaterialCode");
span.setAttribute("outsystems.function.key", "fbc482cb-cce2-4998-9095-d6d27c966d1e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.TransformMaterialCode$vars"))());
vars.value.textInInLocal = textInIn;
var javaScriptJSResult = new OS$DataTypes.VariableHolder();
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.TransformMaterialCode$outVars"))());
javaScriptJSResult.value = OS$Logger.startActiveSpan("JavaScript", function (span) {
if(span) {
span.setAttribute("code.function", "JavaScript");
span.setAttribute("outsystems.function.key", "44ea45ec-f9cc-46d8-8c1b-a8b51aa3c65d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_controller_TransformMaterialCode_JavaScriptJS, "JavaScript", "TransformMaterialCode", {
InString: OS$DataConversion.JSNodeParamConverter.to(vars.value.textInInLocal, OS$DataTypes.DataTypes.Text),
OutString: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.TransformMaterialCode$javaScriptJSResult"))();
jsNodeResult.outStringOut = OS$DataConversion.JSNodeParamConverter.from($parameters.OutString, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// TextOut = JavaScript.OutString
outVars.value.textOutOut = javaScriptJSResult.value.outStringOut;
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.TransformMaterialCode$vars", [{
name: "TextIn",
attrName: "textInInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.TransformMaterialCode$javaScriptJSResult", [{
name: "OutString",
attrName: "outStringOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.TransformMaterialCode$outVars", [{
name: "TextOut",
attrName: "textOutOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
export function transformMaterialCode$Action$Proxy(textInIn) {
textInIn = (textInIn === undefined) ? "" : textInIn;
return controller.executeActionInsideJSNode(transformMaterialCode$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(textInIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
TextOut: OS$DataConversion.JSNodeParamConverter.to(actionResults.textOutOut, OS$DataTypes.DataTypes.Text)
};
});
};


export function transformTime$Action(startDateIn, endDateIn, callContext) {
return OS$Logger.startActiveSpan("TransformTime", function (span) {
if(span) {
span.setAttribute("code.function", "TransformTime");
span.setAttribute("outsystems.function.key", "5ea0d44c-9c21-4eca-bdbf-94a6a98f2152");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.TransformTime$vars"))());
vars.value.startDateInLocal = startDateIn;
vars.value.endDateInLocal = endDateIn;
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.TransformTime$outVars"))());
// TempDate = StartDate
vars.value.tempDateVar = OS$BuiltinFunctions.dateTimeToDate(vars.value.startDateInLocal);
while ((OS$BuiltinFunctions.addYears(vars.value.tempDateVar, 1).lte(vars.value.endDateInLocal))) {
// TempDate = AddYears
vars.value.tempDateVar = OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addYears(vars.value.tempDateVar, 1));
// Years = Years + 1
vars.value.yearsVar = (vars.value.yearsVar + 1);
}

while ((OS$BuiltinFunctions.addMonths(vars.value.tempDateVar, 1).lte(vars.value.endDateInLocal))) {
// TempDate = AddMonths
vars.value.tempDateVar = OS$BuiltinFunctions.dateTimeToDate(OS$BuiltinFunctions.addMonths(vars.value.tempDateVar, 1));
// Months = Months + 1
vars.value.monthsVar = (vars.value.monthsVar + 1);
}

// Days = Abs
vars.value.daysVar = OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.abs(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.diffDays(vars.value.endDateInLocal, vars.value.tempDateVar)))));
// Output = If + If + Days + " days"
outVars.value.outputOut = ((((((vars.value.yearsVar > 0)) ? (((vars.value.yearsVar).toString() + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kIUfXEYDu0uUjdMP9PsE4g#Value.-1361214550.1", " years, "))) : ("")) + (((vars.value.monthsVar > 0)) ? (((vars.value.monthsVar).toString() + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kIUfXEYDu0uUjdMP9PsE4g#Value.1385361174.1", " months and "))) : (""))) + (vars.value.daysVar).toString()) + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kIUfXEYDu0uUjdMP9PsE4g#Value.32628855.1", " days"));
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.TransformTime$vars", [{
name: "StartDate",
attrName: "startDateInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}, {
name: "EndDate",
attrName: "endDateInLocal",
mandatory: false,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}, {
name: "TempDate",
attrName: "tempDateVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}, {
name: "Years",
attrName: "yearsVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Months",
attrName: "monthsVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "Days",
attrName: "daysVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.TransformTime$outVars", [{
name: "Output",
attrName: "outputOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
export function transformTime$Action$Proxy(startDateIn, endDateIn) {
startDateIn = (startDateIn === undefined) ? OS$DataTypes.DateTime.defaultValue : startDateIn;
endDateIn = (endDateIn === undefined) ? OS$DataTypes.DateTime.defaultValue : endDateIn;
return controller.executeActionInsideJSNode(transformTime$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(startDateIn, OS$DataTypes.DataTypes.DateTime), OS$DataConversion.JSNodeParamConverter.from(endDateIn, OS$DataTypes.DataTypes.DateTime)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
Output: OS$DataConversion.JSNodeParamConverter.to(actionResults.outputOut, OS$DataTypes.DataTypes.Text)
};
});
};


export function validateFileSize$Action(fileSizeIn, maxFileSizeIn, callContext) {
return OS$Logger.startActiveSpan("ValidateFileSize", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFileSize");
span.setAttribute("outsystems.function.key", "d679f63f-b4fe-4435-b254-f60c54739e8b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.ValidateFileSize$vars"))());
vars.value.fileSizeInLocal = fileSizeIn;
vars.value.maxFileSizeInLocal = maxFileSizeIn;
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.ValidateFileSize$outVars"))());
// IsValid = FileSize <= MaxFileSize
outVars.value.isValidOut = (vars.value.fileSizeInLocal <= vars.value.maxFileSizeInLocal);
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.ValidateFileSize$vars", [{
name: "FileSize",
attrName: "fileSizeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}, {
name: "MaxFileSize",
attrName: "maxFileSizeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.ValidateFileSize$outVars", [{
name: "IsValid",
attrName: "isValidOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
export function validateFileSize$Action$Proxy(fileSizeIn, maxFileSizeIn) {
fileSizeIn = (fileSizeIn === undefined) ? 0 : fileSizeIn;
maxFileSizeIn = (maxFileSizeIn === undefined) ? 0 : maxFileSizeIn;
return controller.executeActionInsideJSNode(validateFileSize$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(fileSizeIn, OS$DataTypes.DataTypes.Integer), OS$DataConversion.JSNodeParamConverter.from(maxFileSizeIn, OS$DataTypes.DataTypes.Integer)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
IsValid: OS$DataConversion.JSNodeParamConverter.to(actionResults.isValidOut, OS$DataTypes.DataTypes.Boolean)
};
});
};


export function validateFileType$Action(fileTypeIn, acceptedFileTypesIn, callContext) {
return OS$Logger.startActiveSpan("ValidateFileType", function (span) {
if(span) {
span.setAttribute("code.function", "ValidateFileType");
span.setAttribute("outsystems.function.key", "deb13117-3c00-4d44-b876-586337cffd5a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_ACTION");
}

try {callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.ValidateFileType$vars"))());
vars.value.fileTypeInLocal = fileTypeIn;
vars.value.acceptedFileTypesInLocal = acceptedFileTypesIn;
var outVars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.ValidateFileType$outVars"))());
// HasAcceptAllImages?
if((((OS$BuiltinFunctions.index(vars.value.acceptedFileTypesInLocal, "image/*", 0, false, false)) !== ((-1))))) {
// IsImage?
if((((OS$BuiltinFunctions.index(vars.value.fileTypeInLocal, "image/", 0, false, false)) !== ((-1))))) {
// Set IsValid
// IsValid = True
outVars.value.isValidOut = true;
return outVars.value;

}

}

// Set IsValid
// IsValid = Index <> -1
outVars.value.isValidOut = ((OS$BuiltinFunctions.index(vars.value.acceptedFileTypesInLocal, vars.value.fileTypeInLocal, 0, false, true)) !== ((-1)));
return outVars.value;
} finally {
if(span) {
span.end();
}

}

}, 1);
};


ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.ValidateFileType$vars", [{
name: "FileType",
attrName: "fileTypeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "AcceptedFileTypes",
attrName: "acceptedFileTypesInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores.ValidateFileType$outVars", [{
name: "IsValid",
attrName: "isValidOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
export function validateFileType$Action$Proxy(fileTypeIn, acceptedFileTypesIn) {
fileTypeIn = (fileTypeIn === undefined) ? "" : fileTypeIn;
acceptedFileTypesIn = (acceptedFileTypesIn === undefined) ? "" : acceptedFileTypesIn;
return controller.executeActionInsideJSNode(validateFileType$Action.bind(controller, OS$DataConversion.JSNodeParamConverter.from(fileTypeIn, OS$DataTypes.DataTypes.Text), OS$DataConversion.JSNodeParamConverter.from(acceptedFileTypesIn, OS$DataTypes.DataTypes.Text)), OS$Controller.BaseViewController.activeScreen ? OS$Controller.BaseViewController.activeScreen.callContext() : undefined, function (actionResults) {
return {
IsValid: OS$DataConversion.JSNodeParamConverter.to(actionResults.isValidOut, OS$DataTypes.DataTypes.Boolean)
};
});
};



function generateReqName$ServerAction(i_RegionIdIn, callContext) {
return OS$Logger.startActiveSpan("GenerateReqName", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateReqName");
span.setAttribute("outsystems.function.key", "92a16bed-3e80-403a-b46c-a883e610f89a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_RegionId: OS$DataConversion.ServerDataConverter.to(i_RegionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateReqName", "screenservices/ConectaProveedores/ActionGenerateReqName", "cRTbA+D73Mh15dOFKbk6xg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores$ActionGenerateReqName"))();
executeServerActionResult.o_NameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Name, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_CounterOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Counter, OS$DataTypes.DataTypes.Integer);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores$ActionGenerateReqName", [{
name: "o_Name",
attrName: "o_NameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_Counter",
attrName: "o_CounterOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
function getUserRegionId$ServerAction(i_GetUserIdIn, callContext) {
return OS$Logger.startActiveSpan("GetUserRegionId", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserRegionId");
span.setAttribute("outsystems.function.key", "1361cbfb-8120-4b0d-848b-a7005a0f511b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_GetUserId: OS$DataConversion.ServerDataConverter.to(i_GetUserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetUserRegionId", "screenservices/ConectaProveedores/ActionGetUserRegionId", "eZ_gO_yW0xiFjgXIIvaL_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores$ActionGetUserRegionId"))();
executeServerActionResult.o_RegionIdOut = OS$DataConversion.ServerDataConverter.from(outputs.o_RegionId, OS$DataTypes.DataTypes.LongInteger);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores$ActionGetUserRegionId", [{
name: "o_RegionId",
attrName: "o_RegionIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
function sendLoginAlert$ServerAction(usernameIn, environmentIn, callContext) {
return OS$Logger.startActiveSpan("SendLoginAlert", function (span) {
if(span) {
span.setAttribute("code.function", "SendLoginAlert");
span.setAttribute("outsystems.function.key", "795eb1a6-8c8e-4c1b-8092-78f715eb12b7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Username: OS$DataConversion.ServerDataConverter.to(usernameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Environment: OS$DataConversion.ServerDataConverter.to(environmentIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SendLoginAlert", "screenservices/ConectaProveedores/ActionSendLoginAlert", "01EvpqiB+5Vj8CbesQdDGw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
function serviceStorageGetFileByParts$ServerAction(i_StorageIdIn, i_ChunkNumberIn, i_TotalChunksIn, i_GuidIn, callContext) {
return OS$Logger.startActiveSpan("ServiceStorageGetFileByParts", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceStorageGetFileByParts");
span.setAttribute("outsystems.function.key", "6c2e0606-2231-4906-aa11-d5df091a784b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_StorageId: OS$DataConversion.ServerDataConverter.to(i_StorageIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
}),
i_ChunkNumber: OS$DataConversion.ServerDataConverter.to(i_ChunkNumberIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_TotalChunks: OS$DataConversion.ServerDataConverter.to(i_TotalChunksIn, {
dataType: OS$DataTypes.DataTypes.Integer,
pendingPromises: pendingPromises
}),
i_Guid: OS$DataConversion.ServerDataConverter.to(i_GuidIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceStorageGetFileByParts", "screenservices/ConectaProveedores/ServiceAPIServiceStorageGetFileByParts", "Vp6_dh1Cmm3j52pTGr+pBQ", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores$ServiceAPIServiceStorageGetFileByParts"))();
executeServerActionResult.o_FileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_File, OS$DataTypes.DataTypes.BinaryData);
executeServerActionResult.o_filenameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_filename, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_fileInTextOut = OS$DataConversion.ServerDataConverter.from(outputs.o_fileInText, OS$DataTypes.DataTypes.Text);
executeServerActionResult.isBinaryOut = OS$DataConversion.ServerDataConverter.from(outputs.IsBinary, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
};
ConectaProveedoresController.constructor.registerVariableGroupType("ConectaProveedores$ServiceAPIServiceStorageGetFileByParts", [{
name: "o_File",
attrName: "o_FileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}, {
name: "o_filename",
attrName: "o_filenameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_fileInText",
attrName: "o_fileInTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "IsBinary",
attrName: "isBinaryOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

export default ConectaProveedoresController;



