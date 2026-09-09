import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_TranslationsResources from "./ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_h_OrderDistributionConfig_Wb_PositionContact_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getAllPositionContacts$AggrRefresh: 0,
getPositionContactsById$AggrRefresh: 0
};
this.dataFetchDependentsGraph = {
getAllPositionContacts$AggrRefresh: [],
getPositionContactsById$AggrRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
createPositionContacts$ServerAction(positionContactListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("CreatePositionContacts", function (span) {
if(span) {
span.setAttribute("code.function", "CreatePositionContacts");
span.setAttribute("outsystems.function.key", "753ff5cd-a7f8-4590-9efc-e7b30c98914e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
PositionContactList: OS$DataConversion.ServerDataConverter.to(positionContactListIn, {
dataType: OS$DataTypes.DataTypes.RecordList,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("CreatePositionContacts", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_PositionContact/ActionCreatePositionContacts", "5peYN2H8ZxpuwbQ0PpepfA", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact$ActionCreatePositionContacts"))();
executeServerActionResult.lastPositionContractIdOut = OS$DataConversion.ServerDataConverter.from(outputs.LastPositionContractId, OS$DataTypes.DataTypes.LongInteger);
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
get getAllPositionContacts$AggrRefresh() {if(!(this.hasOwnProperty("_getAllPositionContacts$AggrRefresh"))) {
this._getAllPositionContacts$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetAllPositionContacts", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_PositionContact/ScreenDataSetGetAllPositionContacts", "wpfNTrafz_bGDojN_KNHRw", maxRecords, startIndex, function (b) {
model.variables.getAllPositionContactsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getAllPositionContactsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getAllPositionContactsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetAllPositionContacts", function (span) {
if(span) {
span.setAttribute("code.function", "GetAllPositionContacts");
span.setAttribute("outsystems.function.key", "3b681c0d-ecbc-440c-a594-fe7607a3548a");
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

return this._getAllPositionContacts$AggrRefresh;
}set getAllPositionContacts$AggrRefresh(value) {this._getAllPositionContacts$AggrRefresh = value;
}

get getPositionContactsById$AggrRefresh() {if(!(this.hasOwnProperty("_getPositionContactsById$AggrRefresh"))) {
this._getPositionContactsById$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPositionContactsById", "screenservices/ConectaProveedores/h_OrderDistributionConfig/Wb_PositionContact/ScreenDataSetGetPositionContactsById", "ju+y4xm25OCvD52om7KlDA", maxRecords, startIndex, function (b) {
model.variables.getPositionContactsByIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPositionContactsByIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPositionContactsByIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPositionContactsById", function (span) {
if(span) {
span.setAttribute("code.function", "GetPositionContactsById");
span.setAttribute("outsystems.function.key", "619fcf1d-211f-4abf-a3d4-9e05209b87c8");
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

return this._getPositionContactsById$AggrRefresh;
}set getPositionContactsById$AggrRefresh(value) {this._getPositionContactsById$AggrRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getAllPositionContacts$AggrRefresh", "getPositionContactsById$AggrRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_edit_LinkOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Edit_LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "Edit_LinkOnClick");
span.setAttribute("outsystems.function.key", "30c7405c-a619-43b3-84aa-d522d2f1e78f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Edit_LinkOnClick");
callContext = controller.callContext(callContext);
// Editable = True
model.variables.editableVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownSearchSupplierOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownSearchSupplierOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchSupplierOnChanged");
span.setAttribute("outsystems.function.key", "62484acf-e71a-4f6d-8905-827a3e579446");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownSearchSupplierOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.DropdownSearchSupplierOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Trigger Event: OnChangePositionContact
return controller.onChangePositionContact$Action(OS$BuiltinFunctions.longIntegerToIdentifier(OS$BuiltinFunctions.textToLongInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr)), callContext).then(function () {
if((model.variables.showLabelFirstIn)) {
// Editable = False
model.variables.editableVar = false;
}

// Refresh Query: GetAllPositionContacts
var result = controller.getAllPositionContacts$AggrRefresh(999999, 0, callContext);
model.flush();
return result;
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
_saveCancel_LinkOnClick$Action(cancelIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SaveCancel_LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SaveCancel_LinkOnClick");
span.setAttribute("outsystems.function.key", "88efa2d9-5e88-4a4b-ae9e-419ae68ae18d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SaveCancel_LinkOnClick");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.SaveCancel_LinkOnClick$vars"))());
vars.value.cancelInLocal = cancelIn;
var createPositionContactsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((vars.value.cancelInLocal)) {
// Editable = False
model.variables.editableVar = false;
// AddNew = False
model.variables.addNewVar = false;
} else {
// Execute Action: CreatePositionContacts
model.flush();
return controller.createPositionContacts$ServerAction(function () {
var list = new OS$DataTypes.TextList();
list.pushAll([model.variables.newPositionContactVar]);
return list;
}(), callContext).then(function (value) {
createPositionContactsVar.value = value;
}).then(function () {
// Trigger Event: OnChangePositionContact
return controller.onChangePositionContact$Action(createPositionContactsVar.value.lastPositionContractIdOut, callContext);
}).then(function () {
// PositionContactId = CreatePositionContacts.LastPositionContractId
model.variables.positionContactIdIn = createPositionContactsVar.value.lastPositionContractIdOut;
// AddNew = False
model.variables.addNewVar = false;
}).then(function () {
if((model.variables.showLabelFirstIn)) {
// Editable = False
model.variables.editableVar = false;
}

// Refresh Query: GetAllPositionContacts
var result = controller.getAllPositionContacts$AggrRefresh(999999, 0, callContext);
model.flush();
return result;
});
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
_addNew_LinkOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("AddNew_LinkOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "AddNew_LinkOnClick");
span.setAttribute("outsystems.function.key", "8c2ccf84-c7c9-4817-a716-ad809c6db887");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("AddNew_LinkOnClick");
callContext = controller.callContext(callContext);
// AddNew = True
model.variables.addNewVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onParametersChanged$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnParametersChanged", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "9772157e-5286-4a9c-bc2d-f3f26df7f13f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnParametersChanged");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetPositionContactsById
var result = controller.getPositionContactsById$AggrRefresh(1, 0, callContext);
model.flush();
return result;
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;

edit_LinkOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Edit_LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Edit_LinkOnClick");
span.setAttribute("outsystems.function.key", "30c7405c-a619-43b3-84aa-d522d2f1e78f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._edit_LinkOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdownSearchSupplierOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownSearchSupplierOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownSearchSupplierOnChanged");
span.setAttribute("outsystems.function.key", "62484acf-e71a-4f6d-8905-827a3e579446");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownSearchSupplierOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

saveCancel_LinkOnClick$Action(cancelIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SaveCancel_LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SaveCancel_LinkOnClick");
span.setAttribute("outsystems.function.key", "88efa2d9-5e88-4a4b-ae9e-419ae68ae18d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._saveCancel_LinkOnClick$Action, callContext, cancelIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

addNew_LinkOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AddNew_LinkOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "AddNew_LinkOnClick");
span.setAttribute("outsystems.function.key", "8c2ccf84-c7c9-4817-a716-ad809c6db887");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._addNew_LinkOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onParametersChanged$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnParametersChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnParametersChanged");
span.setAttribute("outsystems.function.key", "9772157e-5286-4a9c-bc2d-f3f26df7f13f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onParametersChanged$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

get onChangePositionContact$Action() {if(!(this.hasOwnProperty("_onChangePositionContact$Action"))) {
this._onChangePositionContact$Action = function () {
return Promise.resolve();
};
}

return this._onChangePositionContact$Action;
}set onChangePositionContact$Action(value) {this._onChangePositionContact$Action = value;
}


// Event Handler Actions
get onInitializeEventHandler() {if(!(this.hasOwnProperty("_onInitializeEventHandler"))) {
this._onInitializeEventHandler = null;
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
this._onParametersChangedEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onParametersChanged$Action(callContext);

};
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
return controller.handleError(ex);
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
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact$ActionCreatePositionContacts", [{
name: "LastPositionContractId",
attrName: "lastPositionContractIdOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.LongInteger,
defaultValue: function () {
return OS$DataTypes.LongInteger.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.DropdownSearchSupplierOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.h_OrderDistributionConfig.Wb_PositionContact.SaveCancel_LinkOnClick$vars", [{
name: "Cancel",
attrName: "cancelInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


