import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Transitions as OS$Transitions, Navigation as OS$Navigation, FeedbackMessageService as OS$FeedbackMessageService, SystemActions as OS$SystemActions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { dEPRECATED_ShowPassword$Action as OutSystemsUIController$dEPRECATED_ShowPassword$Action, feedbackMessageClose$Action as OutSystemsUIController$feedbackMessageClose$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_a_Common_Login_mvc_TranslationsResources from "./ConectaProveedores.a_Common.Login.mvc$translationsResources.js";
import ConectaProveedores_a_CommonController$default from "./ConectaProveedores.a_Common.controller.js";
import ConectaProveedoresController$default, { doLogin$Action as ConectaProveedoresController$doLogin$Action } from "./ConectaProveedores.controller.js";
import { ST_b1b6df219277397c7c2be747d587880aStructure } from "./Organization.model.js";
import ConectaProveedores_a_Common_Login_mvc_controller_OnInitialize_RememberUserEmailJS from "./ConectaProveedores.a_Common.Login.mvc$controller.OnInitialize.RememberUserEmailJS.js";
import { getCurrentTimezoneOffset$Action as TimezoneUtilsController$getCurrentTimezoneOffset$Action } from "./TimezoneUtils.controller.js";
import ConectaProveedores_a_Common_Login_mvc_controller_LoginOnClick_LocalStorageUserEmailJS from "./ConectaProveedores.a_Common.Login.mvc$controller.LoginOnClick.LocalStorageUserEmailJS.js";
import { SE_proposalStatus as ConectaProveedores_staticEntities_proposalStatus, SE_approvalStatus as ConectaProveedores_staticEntities_approvalStatus } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_a_Common_Login_mvc_controller_LoginOnClick_ResetLocalStorageJS from "./ConectaProveedores.a_Common.Login.mvc$controller.LoginOnClick.ResetLocalStorageJS.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_a_Common_Login_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getUserExtendedInternals$AggrRefresh: -1,
get2FA$DataActRefresh: 0,
getSettingsEnviroment$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getUserExtendedInternals$AggrRefresh: [],
get2FA$DataActRefresh: [],
getSettingsEnviroment$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
getUserPreferences$ServerAction(i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserPreferences", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserPreferences");
span.setAttribute("outsystems.function.key", "4dfd8fd8-42d7-427e-840a-2d04e7149d0b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetUserPreferences", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIGetUserPreferences", "Cc2tNL38BidpqfxXxbgY9w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIGetUserPreferences"))();
executeServerActionResult.o_TableLinesCountOut = OS$DataConversion.ServerDataConverter.from(outputs.o_TableLinesCount, OS$DataTypes.DataTypes.Integer);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
serviceUserManagementLogsCreate$ServerAction(userIdIn, messageIn, ipAddressIn, screenIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceUserManagementLogsCreate", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceUserManagementLogsCreate");
span.setAttribute("outsystems.function.key", "4521be58-38dd-42d5-bc6c-c83be5f26dc0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserId: OS$DataConversion.ServerDataConverter.to(userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Message: OS$DataConversion.ServerDataConverter.to(messageIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
IpAddress: OS$DataConversion.ServerDataConverter.to(ipAddressIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
Screen: OS$DataConversion.ServerDataConverter.to(screenIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceUserManagementLogsCreate", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIServiceUserManagementLogsCreate", "XChAQnXYflYYarSITwmL4w", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceUserManagementLogsCreate"))();
executeServerActionResult.idOut = OS$DataConversion.ServerDataConverter.from(outputs.Id, OS$DataTypes.DataTypes.LongInteger);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
serviceGetUserExtensionExternalEmail$ServerAction(i_UserEmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceGetUserExtensionExternalEmail", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceGetUserExtensionExternalEmail");
span.setAttribute("outsystems.function.key", "54997edb-2f35-4336-bdd3-51725c07fb58");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_UserEmail: OS$DataConversion.ServerDataConverter.to(i_UserEmailIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceGetUserExtensionExternalEmail", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIServiceGetUserExtensionExternalEmail", "gRSH8_dmhspoWc8dntuPzw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceGetUserExtensionExternalEmail"))();
executeServerActionResult.o_ExternalEmailOut = OS$DataConversion.ServerDataConverter.from(outputs.o_ExternalEmail, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_RegionToBeAssignedOut = OS$DataConversion.ServerDataConverter.from(outputs.o_RegionToBeAssigned, OS$DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
loginEntra$ServerAction(i_UserEmailTelcelIn, i_NewRegionIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LoginEntra", function (span) {
if(span) {
span.setAttribute("code.function", "LoginEntra");
span.setAttribute("outsystems.function.key", "f76c7496-be04-493d-8304-d6311a22e35b");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_UserEmailTelcel: OS$DataConversion.ServerDataConverter.to(i_UserEmailTelcelIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_NewRegion: OS$DataConversion.ServerDataConverter.to(i_NewRegionIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("LoginEntra", "screenservices/ConectaProveedores/a_Common/Login/ActionLoginEntra", "tH4G7kWZ0zgPfBw+hfkmqA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ActionLoginEntra"))();
executeServerActionResult.o_MessageOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Message, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_IsSuccessOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsSuccess, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
getUserEntraRoleName$ServerAction(i_GetUserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetUserEntraRoleName", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserEntraRoleName");
span.setAttribute("outsystems.function.key", "4c284589-6055-4013-b96e-63bea4710236");
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
return controller.callServerAction("GetUserEntraRoleName", "screenservices/ConectaProveedores/a_Common/Login/ActionGetUserEntraRoleName", "nxWX9o8d65Sx2hoAD8f0yw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ActionGetUserEntraRoleName"))();
executeServerActionResult.o_EntraRoleNameOut = OS$DataConversion.ServerDataConverter.from(outputs.o_EntraRoleName, OS$DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
checkUser$ServerAction(i_UserEmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckUser", function (span) {
if(span) {
span.setAttribute("code.function", "CheckUser");
span.setAttribute("outsystems.function.key", "ca7111a4-e52a-419d-b6d7-9bbc92df3ada");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_UserEmail: OS$DataConversion.ServerDataConverter.to(i_UserEmailIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CheckUser", "screenservices/ConectaProveedores/a_Common/Login/ActionCheckUser", "+VrU2ayQha_Oe9kCueJMNw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ActionCheckUser"))();
executeServerActionResult.o_RoleOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Role, OS$DataTypes.DataTypes.Text);
executeServerActionResult.o_SuccessOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Success, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.o_UserIdOut = OS$DataConversion.ServerDataConverter.from(outputs.o_UserId, OS$DataTypes.DataTypes.Text);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
grant$ServerAction(emailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Grant", function (span) {
if(span) {
span.setAttribute("code.function", "Grant");
span.setAttribute("outsystems.function.key", "3c34c91b-7989-476c-a9fb-a977f6f1e7ef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Email: OS$DataConversion.ServerDataConverter.to(emailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("Grant", "screenservices/ConectaProveedores/a_Common/Login/ActionGrant", "glDztMTMAV8qGnd945xIuA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
checkLastPassword$ServerAction(i_PasswordIn, i_EmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CheckLastPassword", function (span) {
if(span) {
span.setAttribute("code.function", "CheckLastPassword");
span.setAttribute("outsystems.function.key", "c2faed20-4862-487e-b658-0d955cdbce49");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Password: OS$DataConversion.ServerDataConverter.to(i_PasswordIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_Email: OS$DataConversion.ServerDataConverter.to(i_EmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CheckLastPassword", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPICheckLastPassword", "jf+3bBdlztldhCzGf+FDZw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPICheckLastPassword"))();
executeServerActionResult.o_IsCorrectOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsCorrect, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
sendSupplier2FA$ServerAction(applicationNameIn, customerEmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendSupplier2FA", function (span) {
if(span) {
span.setAttribute("code.function", "SendSupplier2FA");
span.setAttribute("outsystems.function.key", "ceeecfb8-3464-42fa-96b8-606acd054264");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
ApplicationName: OS$DataConversion.ServerDataConverter.to(applicationNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
CustomerEmail: OS$DataConversion.ServerDataConverter.to(customerEmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("SendSupplier2FA", "screenservices/ConectaProveedores/a_Common/Login/ActionSendSupplier2FA", "W0tZnbLm7kaW9YCdrRsIPg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
serviceCheckSupplierUserEmail$ServerAction(i_EmailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceCheckSupplierUserEmail", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceCheckSupplierUserEmail");
span.setAttribute("outsystems.function.key", "4b1ac9f0-75bb-4c36-8435-9308218cf144");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_Email: OS$DataConversion.ServerDataConverter.to(i_EmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceCheckSupplierUserEmail", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIServiceCheckSupplierUserEmail", "ANHLcDZHxZyuiD7lAoTjqA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceCheckSupplierUserEmail"))();
executeServerActionResult.o_NotExistsOut = OS$DataConversion.ServerDataConverter.from(outputs.o_NotExists, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.o_NotActiveOut = OS$DataConversion.ServerDataConverter.from(outputs.o_NotActive, OS$DataTypes.DataTypes.Boolean);
executeServerActionResult.o_IsDeletedOut = OS$DataConversion.ServerDataConverter.from(outputs.o_IsDeleted, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
createUserSession$ServerAction(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CreateUserSession", function (span) {
if(span) {
span.setAttribute("code.function", "CreateUserSession");
span.setAttribute("outsystems.function.key", "e3c53dce-2736-452e-80ae-1eb318075b9e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return controller.callServerAction("CreateUserSession", "screenservices/ConectaProveedores/a_Common/Login/ActionCreateUserSession", "VwGvvsTlztK4t6++f72tAQ", {}, controller.callContext(callContext), undefined, undefined, true, undefined).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
serviceUserProviderSetLastLoginDate$ServerAction(i_userIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceUserProviderSetLastLoginDate", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceUserProviderSetLastLoginDate");
span.setAttribute("outsystems.function.key", "91aa39a8-333a-416b-9818-defbd5ab572c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_userId: OS$DataConversion.ServerDataConverter.to(i_userIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceUserProviderSetLastLoginDate", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIServiceUserProviderSetLastLoginDate", "ht1xhJgb29Mf01kvZ_DBXA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceUserProviderSetLastLoginDate"))();
executeServerActionResult.o_ReturnOut = OS$DataConversion.ServerDataConverter.from(outputs.o_Return, ST_b1b6df219277397c7c2be747d587880aStructure);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
serviceSupplierCodeValidate$ServerAction(userEmailIn, codeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ServiceSupplierCodeValidate", function (span) {
if(span) {
span.setAttribute("code.function", "ServiceSupplierCodeValidate");
span.setAttribute("outsystems.function.key", "34dee38c-d9c6-410c-8baa-e567d8fb3444");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
UserEmail: OS$DataConversion.ServerDataConverter.to(userEmailIn, {
dataType: OS$DataTypes.DataTypes.Email,
pendingPromises: pendingPromises
}),
Code: OS$DataConversion.ServerDataConverter.to(codeIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ServiceSupplierCodeValidate", "screenservices/ConectaProveedores/a_Common/Login/ServiceAPIServiceSupplierCodeValidate", "3eGWCHH164ynb4f7H6Q3eg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceSupplierCodeValidate"))();
executeServerActionResult.isValidOut = OS$DataConversion.ServerDataConverter.from(outputs.IsValid, OS$DataTypes.DataTypes.Boolean);
return executeServerActionResult;
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;

// Aggregates and Data Actions
get getUserExtendedInternals$AggrRefresh() {if(!(this.hasOwnProperty("_getUserExtendedInternals$AggrRefresh"))) {
this._getUserExtendedInternals$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetUserExtendedInternals", "screenservices/ConectaProveedores/a_Common/Login/ScreenDataSetGetUserExtendedInternals", "2gJwDJC7TUW9b8fQ49TzjA", maxRecords, startIndex, function (b) {
model.variables.getUserExtendedInternalsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getUserExtendedInternalsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getUserExtendedInternalsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetUserExtendedInternals", function (span) {
if(span) {
span.setAttribute("code.function", "GetUserExtendedInternals");
span.setAttribute("outsystems.function.key", "9d16c84d-7066-4781-ac67-0f7127eb618a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_AGGREGATE_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getUserExtendedInternals$AggrRefresh;
}set getUserExtendedInternals$AggrRefresh(value) {this._getUserExtendedInternals$AggrRefresh = value;
}

get get2FA$DataActRefresh() {if(!(this.hasOwnProperty("_get2FA$DataActRefresh"))) {
this._get2FA$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGet2FA", "screenservices/ConectaProveedores/a_Common/Login/DataActionGet2FA", "jk_5PkWUPegoSaenv3zNzA", function (b) {
model.variables.get2FADataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.get2FADataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.get2FADataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("Get2FA", function (span) {
if(span) {
span.setAttribute("code.function", "Get2FA");
span.setAttribute("outsystems.function.key", "8360e4f0-063a-4aeb-8442-839db48a8434");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._get2FA$DataActRefresh;
}set get2FA$DataActRefresh(value) {this._get2FA$DataActRefresh = value;
}

get getSettingsEnviroment$DataActRefresh() {if(!(this.hasOwnProperty("_getSettingsEnviroment$DataActRefresh"))) {
this._getSettingsEnviroment$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSettingsEnviroment", "screenservices/ConectaProveedores/a_Common/Login/DataActionGetSettingsEnviroment", "hz8SvQr3tsgaFFBBoTRz0Q", function (b) {
model.variables.getSettingsEnviromentDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSettingsEnviromentDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSettingsEnviromentDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSettingsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSettingsEnviroment", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsEnviroment");
span.setAttribute("outsystems.function.key", "a23fa804-51a4-4aba-a555-1e580be34752");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_DATA_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
return innerBody();
}, function () {
if(span) {
span.end();
}

});
}, 0);

};
}

return this._getSettingsEnviroment$DataActRefresh;
}set getSettingsEnviroment$DataActRefresh(value) {this._getSettingsEnviroment$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getUserExtendedInternals$AggrRefresh", "get2FA$DataActRefresh", "getSettingsEnviroment$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_getSettingsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "3e213851-0266-4e03-92d0-24afdb05e284");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSettingsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Enviroment = If
ConectaProveedoresClientVariables.setEnviroment((((model.variables.getSettingsEnviromentDataAct.environmentOut === "PROD")) ? ("") : ((((model.variables.getSettingsEnviromentDataAct.environmentOut === "DEV")) ? ("DEV") : ("QA")))));
return OS$Flow.executeSequence(function () {
if((model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut)) {
// Refresh Query: GetUserExtendedInternals
var result = controller.getUserExtendedInternals$AggrRefresh(9999, 0, callContext);
model.flush();
return result;
}

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "4c0d5321-e106-4310-91f2-c9da5d907e88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
var rememberUserEmailJSResult = new OS$DataTypes.VariableHolder();
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Destination: /ConectaProveedores/Homepage
return OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true);
} else {
// Fetches the UserEmail in broswer local storage
rememberUserEmailJSResult.value = OS$Logger.startActiveSpan("RememberUserEmail", function (span) {
if(span) {
span.setAttribute("code.function", "RememberUserEmail");
span.setAttribute("outsystems.function.key", "d7f12727-6fe3-4474-ab8b-13d75a673cf3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_Login_mvc_controller_OnInitialize_RememberUserEmailJS, "RememberUserEmail", "OnInitialize", {
UserEmail: OS$DataConversion.JSNodeParamConverter.to("", OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
var jsNodeResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login.OnInitialize$rememberUserEmailJSResult"))();
jsNodeResult.userEmailOut = OS$DataConversion.JSNodeParamConverter.from($parameters.UserEmail, OS$DataTypes.DataTypes.Text);
return jsNodeResult;
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
// SetLastUserEmail
// UserEmail = RememberUserEmail.UserEmail
model.variables.userEmailVar = rememberUserEmailJSResult.value.userEmailOut;
if((model.variables.isResetPasswordIn)) {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DBcNIunanUKz52JCEpWWwA#Message.1417346719.1", "Your password was changed successfully!"), /*Success*/ 1);
}

}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_loginOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LoginOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClick");
span.setAttribute("outsystems.function.key", "4f0af8ba-89c3-42ba-b2f3-c2720d1f1dd3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LoginOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var getUserPreferencesVar = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreateVar = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate6Var = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate2Var = new OS$DataTypes.VariableHolder();
var serviceGetUserExtensionExternalEmailVar = new OS$DataTypes.VariableHolder();
var loginEntraVar = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate4Var = new OS$DataTypes.VariableHolder();
var getUserEntraRoleNameVar = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate3Var = new OS$DataTypes.VariableHolder();
var checkUserVar = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate7Var = new OS$DataTypes.VariableHolder();
var serviceUserManagementLogsCreate5Var = new OS$DataTypes.VariableHolder();
var getCurrentTimezoneOffsetVar = new OS$DataTypes.VariableHolder();
var doLoginVar = new OS$DataTypes.VariableHolder();
var checkConectaProveedoresRoleVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Destination: /ConectaProveedores/Homepage
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Execute Action: GetCurrentTimezoneOffset
getCurrentTimezoneOffsetVar.value = TimezoneUtilsController$getCurrentTimezoneOffset$Action(callContext);

// OffsetUtc = TextToInteger / 60
ConectaProveedoresClientVariables.setOffsetUtc(OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.textToInteger(getCurrentTimezoneOffsetVar.value.currentTimezoneOffsetOut)).div(OS$BuiltinFunctions.integerToDecimal(60)))));
// UserEmail = Trim
model.variables.userEmailVar = OS$BuiltinFunctions.trim(model.variables.userEmailVar);
// Password Empty?
if(((OS$BuiltinFunctions.trim(model.variables.passwordVar) === ""))) {
// Set error message
// Input_Password.Valid = False
model.widgets.get(idService.getId("Input_Password")).validAttr = false;
// Input_Password.ValidationMessage = "Fill password"
model.widgets.get(idService.getId("Input_Password")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RD9cAsWCIk+vfcoQMZXa4w#Value.272586872.1", "Fill password");
}

return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("LoginForm")).validAttr)) {
// IsExecuting = true
// IsExecutingCodeRequest = True
model.variables.isExecutingCodeRequestVar = true;
// Execute Action: FeedbackMessageClose
OutSystemsUIController$feedbackMessageClose$Action(callContext);
// Execute Action: DoLogin
model.flush();
return ConectaProveedoresController$doLogin$Action(model.variables.userEmailVar, model.variables.passwordVar, model.variables.getSettingsEnviromentDataAct.environmentOut, callContext).then(function (value) {
doLoginVar.value = value;
}).then(function () {
// Execute Action: CheckUser
model.flush();
return controller.checkUser$ServerAction(model.variables.userEmailVar, callContext).then(function (value) {
checkUserVar.value = value;
});
}).then(function () {
// Found Email?
return OS$Flow.executeSequence(function () {
if((checkUserVar.value.o_SuccessOut)) {
// Success?
return OS$Flow.executeSequence(function () {
if((doLoginVar.value.successOut)) {
// IsDevEnvironment
return OS$Flow.executeSequence(function () {
if((model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut)) {
// Execute Action: ServiceGetUserExtensionExternalEmail
model.flush();
return controller.serviceGetUserExtensionExternalEmail$ServerAction(model.variables.userEmailVar, callContext).then(function (value) {
serviceGetUserExtensionExternalEmailVar.value = value;
}).then(function () {
// HasExternalEmail?
return OS$Flow.executeSequence(function () {
if((((((serviceGetUserExtensionExternalEmailVar.value.o_ExternalEmailOut) !== ("")) || ((OS$BuiltinFunctions.index(model.variables.userEmailVar, "@telcel.com", 0, false, false)) !== ((-1)))) || ((OS$BuiltinFunctions.index(model.variables.userEmailVar, "@americamovil.com", 0, false, false)) !== ((-1)))))) {
// UserExternalEmail = ServiceGetUserExtensionExternalEmail.o_ExternalEmail
model.variables.userExternalEmailVar = serviceGetUserExtensionExternalEmailVar.value.o_ExternalEmailOut;
// RegionToBeAssign = ServiceGetUserExtensionExternalEmail.o_RegionToBeAssigned
model.variables.regionToBeAssignVar = serviceGetUserExtensionExternalEmailVar.value.o_RegionToBeAssignedOut;
} else {
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
// Execute Action: ServiceUserManagementLogsCreate4
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(checkUserVar.value.o_UserIdOut, OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("qqGAqJAt+0evHhR+rTCI3A#Value.1471587482.1", "This account does not have a Telcel email address associated with it."), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate4Var.value = value;
}).then(function () {
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kR4lnoJX4E2NfM8d_O4Nfw#Message.1493387435.1", "Your account does not have a Telcel email address associated with it. Please contact the administrator."), /*Error*/ 3);
// Execute Action: Logout4
model.flush();
return OS$SystemActions.logout(callContext);
}).then(function () {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
return OS$Flow.returnAsync();

});
}

});
});
}

}).then(function () {
// Execute Action: LoginEntra
model.flush();
return controller.loginEntra$ServerAction(((model.variables.getSettingsEnviromentDataAct.isDevEnvironmentOut) ? (((((OS$BuiltinFunctions.trim(model.variables.userExternalEmailVar)) !== (""))) ? (model.variables.userExternalEmailVar) : (model.variables.userEmailVar))) : (model.variables.userEmailVar)), model.variables.regionToBeAssignVar, callContext).then(function (value) {
loginEntraVar.value = value;
});
}).then(function () {
// Success?
return OS$Flow.executeSequence(function () {
if((loginEntraVar.value.o_IsSuccessOut)) {
// Execute Action: Grant
model.flush();
return controller.grant$ServerAction(model.variables.userEmailVar, callContext).then(function () {
// Execute Action: CheckConectaProveedoresRole
checkConectaProveedoresRoleVar.value = ConectaProveedoresController$default.checkConectaProveedoresRole$Action(callContext);

}).then(function () {
// HasRole?
return OS$Flow.executeSequence(function () {
if((checkConectaProveedoresRoleVar.value.hasRoleOut)) {
// Remember UserEmail?
if((model.variables.rememberMeVar)) {
// Storages the last used UserEmail
OS$Logger.startActiveSpan("LocalStorageUserEmail", function (span) {
if(span) {
span.setAttribute("code.function", "LocalStorageUserEmail");
span.setAttribute("outsystems.function.key", "9350ef6b-f9d9-4454-b724-2b114dd52c1f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_Login_mvc_controller_LoginOnClick_LocalStorageUserEmailJS, "LocalStorageUserEmail", "LoginOnClick", {
UserEmail: OS$DataConversion.JSNodeParamConverter.to(model.variables.userEmailVar, OS$DataTypes.DataTypes.Text)
}, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
} else {
// Resets UserEmail local storage
OS$Logger.startActiveSpan("ResetLocalStorage", function (span) {
if(span) {
span.setAttribute("code.function", "ResetLocalStorage");
span.setAttribute("outsystems.function.key", "870a67fa-c5ac-4404-8a0a-6c1531ab5d56");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "JAVASCRIPT");
}

try {return controller.safeExecuteJSNode(ConectaProveedores_a_Common_Login_mvc_controller_LoginOnClick_ResetLocalStorageJS, "ResetLocalStorage", "LoginOnClick", null, function ($parameters) {
}, {}, {});
} finally {
if(span) {
span.end();
}

}

}, 1);
}

// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
// Execute Action: GetUserPreferences
model.flush();
return controller.getUserPreferences$ServerAction(OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
getUserPreferencesVar.value = value;
}).then(function () {
// MaxRecords = GetUserPreferences.o_TableLinesCount
ConectaProveedoresClientVariables.setMaxRecords(getUserPreferencesVar.value.o_TableLinesCountOut);
// TimeToLogout = NullDate
ConectaProveedoresClientVariables.setTimeToLogout(OS$BuiltinFunctions.nullDate());
// TimeToWarning = NullDate
ConectaProveedoresClientVariables.setTimeToWarning(OS$BuiltinFunctions.nullDate());
// Execute Action: GetUserEntraRoleName
model.flush();
return controller.getUserEntraRoleName$ServerAction("", callContext).then(function (value) {
getUserEntraRoleNameVar.value = value;
});
}).then(function () {
// ApplicationRole = GetUserEntraRoleName.o_EntraRoleName
ConectaProveedoresClientVariables.setApplicationRole(getUserEntraRoleNameVar.value.o_EntraRoleNameOut);
// Set Initial Status
// Treasury_Status = Approved
ConectaProveedoresClientVariables.setTreasury_Status(ConectaProveedores_staticEntities_proposalStatus.approved);
// Commision_Leases_ApprovalStatusId = NotApproved
ConectaProveedoresClientVariables.setCommision_Leases_ApprovalStatusId(ConectaProveedores_staticEntities_approvalStatus.notApproved);
// Execute Action: ServiceUserManagementLogsCreate7
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(OS$BuiltinFunctions.nullTextIdentifier(), OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EM1MUYZs_UmQ9kfwIIAGcA#Value.518472356.1", "The user logged in successfully."), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate7Var.value = value;
});
}).then(function () {
if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut)) {
// Destination: /ConectaProveedores/Requisitions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// Destination: /ConectaProveedores/Homepage
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
}

});
} else {
// Execute Action: ServiceUserManagementLogsCreate6
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(doLoginVar.value.userIdOut, OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("GNyDWi1Sk0iqNcPgPhJuNg#Value.729249462.1", "The user does not have the necessary OutSystems role to log into the application."), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate6Var.value = value;
}).then(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
// ErrorMessage
OS$FeedbackMessageService.showFeedbackMessage(OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6A5qY4rL9UCcQWxIYfCHWQ#Message.-495212341.1", "No role associated to enter in this application"), /*Error*/ 3);
// Execute Action: Logout
model.flush();
return OS$SystemActions.logout(callContext);
}).then(function () {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
});
}

});
});
} else {
// Execute Action: ServiceUserManagementLogsCreate5
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(doLoginVar.value.userIdOut, OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("rJAzgfEWCk2SOP0UsmOBIw#Value.-1228773910.1", "We were unable to validate the user in the Azure login service."), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate5Var.value = value;
}).then(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
// ErrorMessage
OS$FeedbackMessageService.showFeedbackMessage(loginEntraVar.value.o_MessageOut, /*Error*/ 3);
// Execute Action: Logout3
model.flush();
return OS$SystemActions.logout(callContext);
}).then(function () {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
});
}

});
});
} else {
return OS$Flow.executeSequence(function () {
if((doLoginVar.value.blockedAccountOut)) {
OS$FeedbackMessageService.showFeedbackMessage(doLoginVar.value.errorMessageOut, /*Error*/ 3);
// Execute Action: ServiceUserManagementLogsCreate2
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(checkUserVar.value.o_UserIdOut, ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("4Hul4RSz8UCq4iCWK7sXbQ#Value.-638988759.1", "The account is locked, the user cannot access the system:") + " ") + model.variables.userEmailVar), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate2Var.value = value;
}).then(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
});
} else {
// Execute Action: ServiceUserManagementLogsCreate3
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(checkUserVar.value.o_UserIdOut, ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yuhOsGjln0W8KSu4FsKKNQ#Value.-612584584.1", "Unable to access the system:") + " ") + doLoginVar.value.errorMessageOut), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreate3Var.value = value;
}).then(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
// ErrorMessage
OS$FeedbackMessageService.showFeedbackMessage(doLoginVar.value.errorMessageOut, /*Error*/ 3);
});
}

}).then(function () {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
});
}

});
} else {
// Execute Action: ServiceUserManagementLogsCreate
model.flush();
return controller.serviceUserManagementLogsCreate$ServerAction(OS$BuiltinFunctions.nullTextIdentifier(), ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pNKk7Boy_U29rGaq1V+Q_Q#Value.-681370638.1", "The User with email:") + " ") + model.variables.userEmailVar) + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("pNKk7Boy_U29rGaq1V+Q_Q#Value.-861244737.1", "tried to access the system, but the email does not exists")), "", "", callContext).then(function (value) {
serviceUserManagementLogsCreateVar.value = value;
}).then(function () {
// Set error message
// Input_Username.Valid = False
model.widgets.get(idService.getId("Input_Username")).validAttr = false;
// Input_Username.ValidationMessage = "Incorrect Email"
model.widgets.get(idService.getId("Input_Username")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oad+lVIfyke5nUt+RbHEQg#Value.874352417.1", "Incorrect Email");
// Execute Action: Logout5
model.flush();
return OS$SystemActions.logout(callContext);
}).then(function () {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
});
}

});
});
} else {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
}

});
}

});
}).catch(function (ex) {
OS$Logger.debug("Login.LoginOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "b9191273-c9fc-4b5a-b372-814b79f982db");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: Logout2
model.flush();
return OS$SystemActions.logout(callContext).then(function () {
return OS$Flow.returnAsync();

});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_closeOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("CloseOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "677f6903-9c40-491b-b535-9c0b13b616ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("CloseOnClick");
callContext = controller.callContext(callContext);
// ShowSelectUserPopup = False
model.variables.showSelectUserPopupVar = false;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_openPopupToSelectUser$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OpenPopupToSelectUser", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupToSelectUser");
span.setAttribute("outsystems.function.key", "75d16204-a6ff-4042-a5ca-1a7ad1803f1c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OpenPopupToSelectUser");
callContext = controller.callContext(callContext);
// ShowSelectUserPopup = True
model.variables.showSelectUserPopupVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_sendCodeOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SendCodeOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SendCodeOnClick");
span.setAttribute("outsystems.function.key", "cad4e4e4-3698-43cf-8649-c43cd73456ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SendCodeOnClick");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var checkLastPasswordVar = new OS$DataTypes.VariableHolder();
var serviceCheckSupplierUserEmailVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Msg = ""
model.variables.msgVar = "";
// IsEnabled = False
model.variables.isEnabledVar = false;
// UserEmail = Trim
model.variables.userEmailVar = OS$BuiltinFunctions.trim(model.variables.userEmailVar);
// Execute Action: ServiceCheckSupplierUserEmail
model.flush();
return controller.serviceCheckSupplierUserEmail$ServerAction(model.variables.userEmailVar, callContext).then(function (value) {
serviceCheckSupplierUserEmailVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((serviceCheckSupplierUserEmailVar.value.o_IsDeletedOut)) {
// Msg = "Utilizador nao ativo"
model.variables.msgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("i0WRxHeZ+Ueqo20ZmPvQHA#Value.1137613060.1", "Utilizador nao ativo");
// Input_Username.Valid = False
model.widgets.get(idService.getId("Input_Username")).validAttr = false;
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
} else {
return OS$Flow.executeSequence(function () {
if((serviceCheckSupplierUserEmailVar.value.o_NotExistsOut)) {
// Execute Action: LoginOnClick
return controller._loginOnClick$Action(callContext);
} else {
// AlreadyActivated?
return OS$Flow.executeSequence(function () {
if((serviceCheckSupplierUserEmailVar.value.o_NotActiveOut)) {
// Msg = "Utilizador nao ativo"
model.variables.msgVar = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vcsbTEWenkWAjvBjPa8xnQ#Value.1137613060.1", "Utilizador nao ativo");
// Input_Username.Valid = False
model.widgets.get(idService.getId("Input_Username")).validAttr = false;
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
} else {
return OS$Flow.executeSequence(function () {
if((model.variables.get2FADataAct.iSactiveOut)) {
// IsExecutingCodeRequest = True
model.variables.isExecutingCodeRequestVar = true;
// Password Empty?
if(((OS$BuiltinFunctions.trim(model.variables.passwordVar) === ""))) {
// Set error message
// Input_Password.Valid = False
model.widgets.get(idService.getId("Input_Password")).validAttr = false;
// Input_Password.ValidationMessage = "Fill password"
model.widgets.get(idService.getId("Input_Password")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("shAHD2bjDkiz0irB_FeuZQ#Value.272586872.1", "Fill password");
}

// Execute Action: CheckLastPassword
model.flush();
return controller.checkLastPassword$ServerAction(model.variables.passwordVar, model.variables.userEmailVar, callContext).then(function (value) {
checkLastPasswordVar.value = value;
}).then(function () {
if((!(checkLastPasswordVar.value.o_IsCorrectOut))) {
// Set error message
// Input_Password.Valid = False
model.widgets.get(idService.getId("Input_Password")).validAttr = false;
// Input_Password.ValidationMessage = "Wrong password"
model.widgets.get(idService.getId("Input_Password")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("r5dUmBVvakSYAs1JXTfOpQ#Value.1671957454.1", "Wrong password");
}

return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("LoginForm")).validAttr)) {
// Execute Action: FeedbackMessageClose
OutSystemsUIController$feedbackMessageClose$Action(callContext);
// Execute Action: SendSupplier2FA
model.flush();
return controller.sendSupplier2FA$ServerAction("Conecta Proveedores", model.variables.userEmailVar, callContext).then(function () {
// Step = 2
model.variables.stepVar = 2;
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
});
} else {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
}

});
});
} else {
// Execute Action: LoginOnClickSupplier
return controller._loginOnClickSupplier$Action(callContext);
}

});
}

});
}

});
}

});
});
}).catch(function (ex) {
OS$Logger.debug("Login.SendCodeOnClick", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "8e7a3010-79e5-44ec-801f-3fd0fd53c51d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecutingCodeRequest = False
model.variables.isExecutingCodeRequestVar = false;
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: Logout2
model.flush();
return OS$SystemActions.logout(callContext).then(function () {
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_userOnSelect$Action(emailIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("UserOnSelect", function (span) {
if(span) {
span.setAttribute("code.function", "UserOnSelect");
span.setAttribute("outsystems.function.key", "d07fbdae-9180-4228-b0a8-2b854fe376f9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("UserOnSelect");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.a_Common.Login.UserOnSelect$vars"))());
vars.value.emailInLocal = emailIn;
// UserEmail = Email
model.variables.userEmailVar = vars.value.emailInLocal;
// Password = "CuentaTelcel1"
model.variables.passwordVar = "CuentaTelcel1";
// Execute Action: CloseOnClick
controller._closeOnClick$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_loginOnClickSupplier$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("LoginOnClickSupplier", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClickSupplier");
span.setAttribute("outsystems.function.key", "e39e6861-4a65-4d72-85cd-f94105cb1a5c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("LoginOnClickSupplier");
callContext = controller.callContext(callContext);
var allExceptionsVar = new OS$DataTypes.VariableHolder(new OS$DataTypes.ErrorHandlerOutputType());
var serviceUserProviderSetLastLoginDateVar = new OS$DataTypes.VariableHolder();
var serviceSupplierCodeValidateVar = new OS$DataTypes.VariableHolder();
var doLoginVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Destination: /ConectaProveedores/Homepage
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
} else {
// UserEmail = Trim
model.variables.userEmailVar = OS$BuiltinFunctions.trim(model.variables.userEmailVar);
return OS$Flow.executeSequence(function () {
if((model.variables.get2FADataAct.iSactiveOut)) {
// Code Empty?
if(((OS$BuiltinFunctions.trim(model.variables.userCodeVar) === ""))) {
// Set error message
// Input_Password.Valid = False
model.widgets.get(idService.getId("Input_Password")).validAttr = false;
// Input_Password.ValidationMessage = "Fill password"
model.widgets.get(idService.getId("Input_Password")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("m2DfziRh6ESDdiZOwzDzug#Value.272586872.1", "Fill password");
}

// Execute Action: ServiceSupplierCodeValidate
model.flush();
return controller.serviceSupplierCodeValidate$ServerAction(model.variables.userEmailVar, model.variables.userCodeVar, callContext).then(function (value) {
serviceSupplierCodeValidateVar.value = value;
}).then(function () {
if((!(serviceSupplierCodeValidateVar.value.isValidOut))) {
// Set error message
// Input_Usercode.Valid = False
model.widgets.get(idService.getId("Input_Usercode")).validAttr = false;
// Input_Usercode.ValidationMessage = "Invalid Code"
model.widgets.get(idService.getId("Input_Usercode")).validationMessageAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("UbaeXglidkmFB8lEDFV+aQ#Value.631903926.1", "Invalid Code");
}

});
}

}).then(function () {
return OS$Flow.executeSequence(function () {
if((model.widgets.get(idService.getId("LoginForm")).validAttr)) {
// IsExecuting = true
// IsExecuting = True
model.variables.isExecutingVar = true;
// Execute Action: FeedbackMessageClose
OutSystemsUIController$feedbackMessageClose$Action(callContext);
// Execute Action: DoLogin
model.flush();
return ConectaProveedoresController$doLogin$Action(model.variables.userEmailVar, model.variables.passwordVar, model.variables.getSettingsEnviromentDataAct.environmentOut, callContext).then(function (value) {
doLoginVar.value = value;
}).then(function () {
return OS$Flow.executeSequence(function () {
if((doLoginVar.value.successOut)) {
// Execute Action: ServiceUserProviderSetLastLoginDate
model.flush();
return controller.serviceUserProviderSetLastLoginDate$ServerAction(OS$BuiltinFunctions.getUserId(), callContext).then(function (value) {
serviceUserProviderSetLastLoginDateVar.value = value;
}).then(function () {
if((!(serviceUserProviderSetLastLoginDateVar.value.o_ReturnOut.isSuccessAttr))) {
OS$FeedbackMessageService.showFeedbackMessage(serviceUserProviderSetLastLoginDateVar.value.o_ReturnOut.messageAttr, /*Error*/ 3);
}

// Execute Action: CreateUserSession
model.flush();
return controller.createUserSession$ServerAction(callContext).then(function () {
// Destination: /ConectaProveedores/Requisitions
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
});
} else {
// UserCode = ""
model.variables.userCodeVar = "";
// Step = 1
model.variables.stepVar = 1;
// Raise Error: InvalidLoginSuppliers
throw new OS$Exceptions.Exceptions.UserException("ConectaProveedores.InvalidLoginSuppliers", doLoginVar.value.errorMessageOut);
}

});
});
} else {
// IsEnabled = True
// IsEnabled = True
model.variables.isEnabledVar = true;
}

});
});
}

});
}).catch(function (ex) {
OS$Logger.debug("Login.LoginOnClickSupplier", OS$Exceptions.getMessage(ex));
// Handle Error: AllExceptions
if(!(OS$Exceptions.isSystem(ex))) {
OS$Logger.error(null, ex, null, null, 1);
allExceptionsVar.value.exceptionMessageAttr = OS$Exceptions.getMessage(ex);
return OS$Logger.startActiveSpan("AllExceptions", function (span) {
if(span) {
span.setAttribute("code.function", "AllExceptions");
span.setAttribute("outsystems.function.key", "b407a6a0-c0f8-4ef3-81ef-ec47a1a693c6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_EXCEPTION_HANDLER");
}

return OS$Flow.tryFinally(function () {
return OS$Flow.executeAsyncFlow(function () {
// Clear Password
// Password = ""
model.variables.passwordVar = "";
// IsExecuting = false
// IsExecuting = False
model.variables.isExecutingVar = false;
OS$FeedbackMessageService.showFeedbackMessage(allExceptionsVar.value.exceptionMessageAttr, /*Error*/ 3);
// Execute Action: Logout2
model.flush();
return OS$SystemActions.logout(callContext).then(function () {
// Destination: /ConectaProveedores/Login
return OS$Flow.returnAsync(OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "Login", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), callContext, true));
});
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}

throw ex;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onTogglePasswordVisibility$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "f6b666d4-6caa-45cf-9c28-0e585f47adc5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnTogglePasswordVisibility");
callContext = controller.callContext(callContext);
var dEPRECATED_ShowPasswordVar = new OS$DataTypes.VariableHolder();
// MakePasswordVisible = notMakePasswordVisible
model.variables.makePasswordVisibleVar = (!(model.variables.makePasswordVisibleVar));
// Execute Action: DEPRECATED_ShowPassword
dEPRECATED_ShowPasswordVar.value = OutSystemsUIController$dEPRECATED_ShowPassword$Action(callContext);

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;

getSettingsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettingsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettingsOnAfterFetch");
span.setAttribute("outsystems.function.key", "3e213851-0266-4e03-92d0-24afdb05e284");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSettingsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "4c0d5321-e106-4310-91f2-c9da5d907e88");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onInitialize$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

loginOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LoginOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClick");
span.setAttribute("outsystems.function.key", "4f0af8ba-89c3-42ba-b2f3-c2720d1f1dd3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._loginOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

closeOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CloseOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "CloseOnClick");
span.setAttribute("outsystems.function.key", "677f6903-9c40-491b-b535-9c0b13b616ce");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._closeOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

openPopupToSelectUser$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OpenPopupToSelectUser__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OpenPopupToSelectUser");
span.setAttribute("outsystems.function.key", "75d16204-a6ff-4042-a5ca-1a7ad1803f1c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._openPopupToSelectUser$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

sendCodeOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SendCodeOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SendCodeOnClick");
span.setAttribute("outsystems.function.key", "cad4e4e4-3698-43cf-8649-c43cd73456ee");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._sendCodeOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

userOnSelect$Action(emailIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("UserOnSelect__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "UserOnSelect");
span.setAttribute("outsystems.function.key", "d07fbdae-9180-4228-b0a8-2b854fe376f9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._userOnSelect$Action, callContext, emailIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

loginOnClickSupplier$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("LoginOnClickSupplier__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "LoginOnClickSupplier");
span.setAttribute("outsystems.function.key", "e39e6861-4a65-4d72-85cd-f94105cb1a5c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._loginOnClickSupplier$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onTogglePasswordVisibility$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnTogglePasswordVisibility__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnTogglePasswordVisibility");
span.setAttribute("outsystems.function.key", "f6b666d4-6caa-45cf-9c28-0e585f47adc5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onTogglePasswordVisibility$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onInitialize$Action(callContext);

};
}

return this._onInitializeEventHandler;
}set onInitializeEventHandler(value) {this._onInitializeEventHandler = value;
}

get onReadyEventHandler() {if(!(this.hasOwnProperty("_onReadyEventHandler"))) {
this._onReadyEventHandler = null;
}

return this._onReadyEventHandler;
}set onReadyEventHandler(value) {this._onReadyEventHandler = value;
}

get onRenderEventHandler() {if(!(this.hasOwnProperty("_onRenderEventHandler"))) {
this._onRenderEventHandler = null;
}

return this._onRenderEventHandler;
}set onRenderEventHandler(value) {this._onRenderEventHandler = value;
}

get onDestroyEventHandler() {if(!(this.hasOwnProperty("_onDestroyEventHandler"))) {
this._onDestroyEventHandler = null;
}

return this._onDestroyEventHandler;
}set onDestroyEventHandler(value) {this._onDestroyEventHandler = value;
}

get onParametersChangedEventHandler() {if(!(this.hasOwnProperty("_onParametersChangedEventHandler"))) {
this._onParametersChangedEventHandler = null;
}

return this._onParametersChangedEventHandler;
}set onParametersChangedEventHandler(value) {this._onParametersChangedEventHandler = value;
}

// Sync Event Handler Actions
get onSyncStartEventHandler() {if(!(this.hasOwnProperty("_onSyncStartEventHandler"))) {
this._onSyncStartEventHandler = null;
}

return this._onSyncStartEventHandler;
}set onSyncStartEventHandler(value) {this._onSyncStartEventHandler = value;
}

get onSyncCompleteEventHandler() {if(!(this.hasOwnProperty("_onSyncCompleteEventHandler"))) {
this._onSyncCompleteEventHandler = null;
}

return this._onSyncCompleteEventHandler;
}set onSyncCompleteEventHandler(value) {this._onSyncCompleteEventHandler = value;
}

get onSyncErrorEventHandler() {if(!(this.hasOwnProperty("_onSyncErrorEventHandler"))) {
this._onSyncErrorEventHandler = null;
}

return this._onSyncErrorEventHandler;
}set onSyncErrorEventHandler(value) {this._onSyncErrorEventHandler = value;
}

get handleError() {if(!(this.hasOwnProperty("_handleError"))) {
this._handleError = function (ex) {
return ConectaProveedores_a_CommonController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIGetUserPreferences", [{
name: "o_TableLinesCount",
attrName: "o_TableLinesCountOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceUserManagementLogsCreate", [{
name: "Id",
attrName: "idOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceGetUserExtensionExternalEmail", [{
name: "o_ExternalEmail",
attrName: "o_ExternalEmailOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_RegionToBeAssigned",
attrName: "o_RegionToBeAssignedOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ActionLoginEntra", [{
name: "o_Message",
attrName: "o_MessageOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_IsSuccess",
attrName: "o_IsSuccessOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ActionGetUserEntraRoleName", [{
name: "o_EntraRoleName",
attrName: "o_EntraRoleNameOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ActionCheckUser", [{
name: "o_Role",
attrName: "o_RoleOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}, {
name: "o_Success",
attrName: "o_SuccessOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_UserId",
attrName: "o_UserIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPICheckLastPassword", [{
name: "o_IsCorrect",
attrName: "o_IsCorrectOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceCheckSupplierUserEmail", [{
name: "o_NotExists",
attrName: "o_NotExistsOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_NotActive",
attrName: "o_NotActiveOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}, {
name: "o_IsDeleted",
attrName: "o_IsDeletedOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceUserProviderSetLastLoginDate", [{
name: "o_Return",
attrName: "o_ReturnOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Record,
defaultValue: function () {
return new ST_b1b6df219277397c7c2be747d587880aStructure();
},
complexType: ST_b1b6df219277397c7c2be747d587880aStructure
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login$ServiceAPIServiceSupplierCodeValidate", [{
name: "IsValid",
attrName: "isValidOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login.OnInitialize$rememberUserEmailJSResult", [{
name: "UserEmail",
attrName: "userEmailOut",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.a_Common.Login.UserOnSelect$vars", [{
name: "Email",
attrName: "emailInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


