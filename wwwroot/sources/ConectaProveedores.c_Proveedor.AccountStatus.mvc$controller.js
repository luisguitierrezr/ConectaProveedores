import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, SystemActions as OS$SystemActions, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions, Authorization as OS$Authorization, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import ConectaProveedoresController$default, { showLoading$Action as ConectaProveedoresController$showLoading$Action, hideLoading$Action as ConectaProveedoresController$hideLoading$Action } from "./ConectaProveedores.controller.js";
import { ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure } from "./AuditEngine.model.js";
import { SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import ConectaProveedores_c_Proveedor_AccountStatus_mvc_TranslationsResources from "./ConectaProveedores.c_Proveedor.AccountStatus.mvc$translationsResources.js";
import ConectaProveedores_c_ProveedorController$default from "./ConectaProveedores.c_Proveedor.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Proveedor_AccountStatus_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getSupplierUserByUserId$AggrRefresh: 0,
getSupplierDetailsBySupplierId$AggrRefresh: -1,
getPaymentTerms$AggrRefresh: 0,
getRegions$AggrRefresh: 0,
getSapData$DataActRefresh: -1
};
this.dataFetchDependentsGraph = {
getSupplierUserByUserId$AggrRefresh: ["getSupplierDetailsBySupplierId$AggrRefresh", "getSapData$DataActRefresh"],
getSupplierDetailsBySupplierId$AggrRefresh: [],
getPaymentTerms$AggrRefresh: [],
getRegions$AggrRefresh: [],
getSapData$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
auditCreateWrapper$ServerAction(sourceIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("AuditCreateWrapper", function (span) {
if(span) {
span.setAttribute("code.function", "AuditCreateWrapper");
span.setAttribute("outsystems.function.key", "29ed484b-b7f1-432a-9518-6b19b3ff7cf9");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Source: OS$DataConversion.ServerDataConverter.to(sourceIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("AuditCreateWrapper", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ActionAuditCreateWrapper", "R9ncJjtM_dSZmMkM5XAN_g", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
generateCurrentAccountPdf$ServerAction(i_ACREEDORIn, i_ANTICIPOS_HIGHIn, i_ANTICIPOS_LOWIn, i_F_PARTABIEIn, i_PCOMP_HIGHIn, i_PCOMP_LOWIn, i_REGIONIn, i_SOCIEDADIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateCurrentAccountPdf", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateCurrentAccountPdf");
span.setAttribute("outsystems.function.key", "630e8900-f486-4b74-8027-8194a8c83ba0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
I_ACREEDOR: OS$DataConversion.ServerDataConverter.to(i_ACREEDORIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_ANTICIPOS_HIGH: OS$DataConversion.ServerDataConverter.to(i_ANTICIPOS_HIGHIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_ANTICIPOS_LOW: OS$DataConversion.ServerDataConverter.to(i_ANTICIPOS_LOWIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_F_PARTABIE: OS$DataConversion.ServerDataConverter.to(i_F_PARTABIEIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_PCOMP_HIGH: OS$DataConversion.ServerDataConverter.to(i_PCOMP_HIGHIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_PCOMP_LOW: OS$DataConversion.ServerDataConverter.to(i_PCOMP_LOWIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_REGION: OS$DataConversion.ServerDataConverter.to(i_REGIONIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
I_SOCIEDAD: OS$DataConversion.ServerDataConverter.to(i_SOCIEDADIn, {
dataType: OS$DataTypes.DataTypes.LongInteger,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateCurrentAccountPdf", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ActionGenerateCurrentAccountPdf", "nMPxl6a3UHL2IVmoCk3jNw", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionGenerateCurrentAccountPdf"))();
executeServerActionResult.o_fileOut = OS$DataConversion.ServerDataConverter.from(outputs.o_file, OS$DataTypes.DataTypes.BinaryData);
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
exportProviderCurrentAccountExcel$ServerAction(responseIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportProviderCurrentAccountExcel", function (span) {
if(span) {
span.setAttribute("code.function", "ExportProviderCurrentAccountExcel");
span.setAttribute("outsystems.function.key", "6e0eaf16-9600-4980-b2ed-65f6ce786709");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Response: OS$DataConversion.ServerDataConverter.to(responseIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ExportProviderCurrentAccountExcel", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ActionExportProviderCurrentAccountExcel", "6nGOehgd+Tf6ZazPgWZyug", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionExportProviderCurrentAccountExcel"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.file, OS$DataTypes.DataTypes.BinaryData);
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
generateCurrentAccountCSV$ServerAction(responseIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GenerateCurrentAccountCSV", function (span) {
if(span) {
span.setAttribute("code.function", "GenerateCurrentAccountCSV");
span.setAttribute("outsystems.function.key", "83743934-3c90-4a86-ac84-5c788844287e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
Response: OS$DataConversion.ServerDataConverter.to(responseIn, {
dataType: OS$DataTypes.DataTypes.Record,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GenerateCurrentAccountCSV", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ActionGenerateCurrentAccountCSV", "eViix+lX6IHVNxOO94L_rg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionGenerateCurrentAccountCSV"))();
executeServerActionResult.fileOut = OS$DataConversion.ServerDataConverter.from(outputs.file, OS$DataTypes.DataTypes.BinaryData);
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
get getSupplierUserByUserId$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierUserByUserId$AggrRefresh"))) {
this._getSupplierUserByUserId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierUserByUserId", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ScreenDataSetGetSupplierUserByUserId", "qf8IZArR62nE7JhJxPcuZw", maxRecords, startIndex, function (b) {
model.variables.getSupplierUserByUserIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierUserByUserIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierUserByUserIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSupplierUserByUserIdOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierUserByUserId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserId");
span.setAttribute("outsystems.function.key", "0bb3a64a-69a3-47bc-9a05-7806f096e5d4");
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

return this._getSupplierUserByUserId$AggrRefresh;
}set getSupplierUserByUserId$AggrRefresh(value) {this._getSupplierUserByUserId$AggrRefresh = value;
}

get getSupplierDetailsBySupplierId$AggrRefresh() {if(!(this.hasOwnProperty("_getSupplierDetailsBySupplierId$AggrRefresh"))) {
this._getSupplierDetailsBySupplierId$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetSupplierDetailsBySupplierId", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ScreenDataSetGetSupplierDetailsBySupplierId", "gwaHwYI_e_5qCt_Z79NOaA", maxRecords, startIndex, function (b) {
model.variables.getSupplierDetailsBySupplierIdAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSupplierDetailsBySupplierIdAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSupplierDetailsBySupplierIdAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetSupplierDetailsBySupplierId", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierDetailsBySupplierId");
span.setAttribute("outsystems.function.key", "29ca27a6-3152-4f70-90ba-302aff03cc33");
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

return this._getSupplierDetailsBySupplierId$AggrRefresh;
}set getSupplierDetailsBySupplierId$AggrRefresh(value) {this._getSupplierDetailsBySupplierId$AggrRefresh = value;
}

get getPaymentTerms$AggrRefresh() {if(!(this.hasOwnProperty("_getPaymentTerms$AggrRefresh"))) {
this._getPaymentTerms$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetPaymentTerms", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ScreenDataSetGetPaymentTerms", "+6OhqwjTKpS9lXyr02rGqw", maxRecords, startIndex, function (b) {
model.variables.getPaymentTermsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getPaymentTermsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getPaymentTermsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetPaymentTerms", function (span) {
if(span) {
span.setAttribute("code.function", "GetPaymentTerms");
span.setAttribute("outsystems.function.key", "9c6db4d5-0c1d-4980-b4bf-946fd21b04d7");
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

return this._getPaymentTerms$AggrRefresh;
}set getPaymentTerms$AggrRefresh(value) {this._getPaymentTerms$AggrRefresh = value;
}

get getRegions$AggrRefresh() {if(!(this.hasOwnProperty("_getRegions$AggrRefresh"))) {
this._getRegions$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRegions", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/ScreenDataSetGetRegions", "F9suSx2_X8+qIMY5h0gbYw", maxRecords, startIndex, function (b) {
model.variables.getRegionsAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRegionsAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRegionsAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetRegions");
span.setAttribute("outsystems.function.key", "aa747d44-c48e-4b23-94e6-6291f3e2ace9");
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

return this._getRegions$AggrRefresh;
}set getRegions$AggrRefresh(value) {this._getRegions$AggrRefresh = value;
}

get getSapData$DataActRefresh() {if(!(this.hasOwnProperty("_getSapData$DataActRefresh"))) {
this._getSapData$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetSapData", "screenservices/ConectaProveedores/c_Proveedor/AccountStatus/DataActionGetSapData", "f4Ax0UdABchGTjINnLPsng", function (b) {
model.variables.getSapDataDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getSapDataDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getSapDataDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
controller._getSapDataOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetSapData", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapData");
span.setAttribute("outsystems.function.key", "348661b4-d574-4b39-83be-367eeae8286f");
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

return this._getSapData$DataActRefresh;
}set getSapData$DataActRefresh(value) {this._getSapData$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getSupplierUserByUserId$AggrRefresh", "getSupplierDetailsBySupplierId$AggrRefresh", "getPaymentTerms$AggrRefresh", "getRegions$AggrRefresh", "getSapData$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_showDataFiltered$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowDataFiltered", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDataFiltered");
span.setAttribute("outsystems.function.key", "16a0b778-9b84-4dc5-8b72-0b585a70e286");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowDataFiltered");
callContext = controller.callContext(callContext);
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_FACTPENPAGVar, callContext);
// Foreach L_FACTPENPAGFiltered
callContext.iterationContext.registerIterationStart(model.variables.l_FACTPENPAGFilteredVar);
try {var l_FACTPENPAGFilteredIterator = callContext.iterationContext.getIterator(model.variables.l_FACTPENPAGFilteredVar);
var l_FACTPENPAGFilteredIndexMax = model.variables.maxRecordsVar;
var l_FACTPENPAGFilteredIndex = model.variables.startIndexVar;
while ((((l_FACTPENPAGFilteredIndex < model.variables.l_FACTPENPAGFilteredVar.length)) && (l_FACTPENPAGFilteredIndexMax > 0))) {
l_FACTPENPAGFilteredIterator.currentRowNumber = l_FACTPENPAGFilteredIndex;
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.l_FACTPENPAGVar, model.variables.l_FACTPENPAGFilteredVar.getItem(l_FACTPENPAGFilteredIndex.valueOf()), callContext);
l_FACTPENPAGFilteredIndexMax--;
l_FACTPENPAGFilteredIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.l_FACTPENPAGFilteredVar);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "1f8e0309-2969-4dce-b698-676a4295392a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
if((((model.variables.tableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// TableSort = SortBy + " DESC"
model.variables.tableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// TableSort = SortBy
model.variables.tableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// StartIndex = 0
model.variables.startIndexVar = 0;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_picker_FechaanticiposfinOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Picker_FechaanticiposfinOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaanticiposfinOnSelected");
span.setAttribute("outsystems.function.key", "2d148313-2116-4b6c-96f7-7f6397f1d490");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Picker_FechaanticiposfinOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaanticiposfinOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Supplier_Fechaanticiposfin = SelectedDateTime
ConectaProveedoresClientVariables.setSupplier_Fechaanticiposfin(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_searchOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SearchOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "412046e5-1c10-4f94-8885-27ea90e7e12d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("SearchOnClick");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Refresh Query: GetSapData
var result = controller.getSapData$DataActRefresh(callContext);
model.flush();
return result.then(function () {
// StartIndex = 0
model.variables.startIndexVar = 0;
// DateTime = CurrDateTime
model.variables.dateTimeVar = OS$BuiltinFunctions.currDateTime();
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
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
span.setAttribute("outsystems.function.key", "42b8f570-4978-4d5e-922c-2531fe2b7316");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
if((((OS$BuiltinFunctions.getUserId()) !== (OS$BuiltinFunctions.nullTextIdentifier())))) {
// Set Dates
// Supplier_Fechapartidasabiertas = If
ConectaProveedoresClientVariables.setSupplier_Fechapartidasabiertas(((ConectaProveedoresClientVariables.getSupplier_Fechapartidasabiertas().equals(OS$BuiltinFunctions.nullDate())) ? (OS$BuiltinFunctions.currDate()) : (ConectaProveedoresClientVariables.getSupplier_Fechapartidasabiertas())));
// Supplier_Fechaanticiposinicio = If
ConectaProveedoresClientVariables.setSupplier_Fechaanticiposinicio(OS$BuiltinFunctions.dateTimeToDate(((ConectaProveedoresClientVariables.getSupplier_Fechaanticiposinicio().equals(OS$BuiltinFunctions.nullDate())) ? (OS$BuiltinFunctions.addMonths(OS$BuiltinFunctions.currDate(), (-2))) : (ConectaProveedoresClientVariables.getSupplier_Fechaanticiposinicio()))));
// Supplier_Fechaanticiposfin = If
ConectaProveedoresClientVariables.setSupplier_Fechaanticiposfin(((ConectaProveedoresClientVariables.getSupplier_Fechaanticiposfin().equals(OS$BuiltinFunctions.nullDate())) ? (OS$BuiltinFunctions.currDate()) : (ConectaProveedoresClientVariables.getSupplier_Fechaanticiposfin())));
// Supplier_Fechacompensadasinicio = If
ConectaProveedoresClientVariables.setSupplier_Fechacompensadasinicio(OS$BuiltinFunctions.dateTimeToDate(((ConectaProveedoresClientVariables.getSupplier_Fechacompensadasinicio().equals(OS$BuiltinFunctions.nullDate())) ? (OS$BuiltinFunctions.addMonths(OS$BuiltinFunctions.currDate(), (-2))) : (ConectaProveedoresClientVariables.getSupplier_Fechacompensadasinicio()))));
// Supplier_Fechacompensadasfin = If
ConectaProveedoresClientVariables.setSupplier_Fechacompensadasfin(((ConectaProveedoresClientVariables.getSupplier_Fechacompensadasfin().equals(OS$BuiltinFunctions.nullDate())) ? (OS$BuiltinFunctions.currDate()) : (ConectaProveedoresClientVariables.getSupplier_Fechacompensadasfin())));
} else {
// Raise Error: NotProveedor
throw new OS$Exceptions.Exceptions.NotRegisteredException("SecurityAuth.NotProveedor", OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dm3dqGytSkaXm2gstnJyhQ#Message.-1752224544.1", "You have no access to this page"));
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_picker_FechacompensadasinicioOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Picker_FechacompensadasinicioOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechacompensadasinicioOnSelected");
span.setAttribute("outsystems.function.key", "507b6093-bd90-4aa2-9976-68da9cfb37b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Picker_FechacompensadasinicioOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechacompensadasinicioOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Supplier_Fechacompensadasinicio = SelectedDateTime
ConectaProveedoresClientVariables.setSupplier_Fechacompensadasinicio(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_onReady$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnReady", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "51f8ef29-f5d1-4703-a837-562f8221ce3c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnReady");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: AuditCreateWrapper
model.flush();
return controller.auditCreateWrapper$ServerAction(function () {
var rec = new ST_294e4a8da2ce2078a89c70e4dbbd3a0dStructure();
rec.idAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.originAttr = ConectaProveedores_staticEntities_origin.screenAccess;
rec.identifierAttr = OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
rec.messageAttr = "";
rec.screenAttr = "Proveedor - Account Status";
rec.functionalityAttr = "View";
rec.occurrenceRoleNameAttr = ConectaProveedoresClientVariables.getApplicationRole();
return rec;
}(), callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_picker_FechaanticiposinicioOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Picker_FechaanticiposinicioOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaanticiposinicioOnSelected");
span.setAttribute("outsystems.function.key", "61b4351e-11ce-4393-a090-e3167c32c667");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Picker_FechaanticiposinicioOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaanticiposinicioOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Supplier_Fechaanticiposinicio = SelectedDateTime
ConectaProveedoresClientVariables.setSupplier_Fechaanticiposinicio(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_exportPDFOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExportPDFOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "ExportPDFOnClick");
span.setAttribute("outsystems.function.key", "7fe6d7fa-ad4f-44a1-8926-d9628705ba2c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExportPDFOnClick");
callContext = controller.callContext(callContext);
var generateCurrentAccountPdfVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: GenerateCurrentAccountPdf
model.flush();
return controller.generateCurrentAccountPdf$ServerAction(model.variables.getSupplierUserByUserIdAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr, OS$BuiltinFunctions.dateToText(ConectaProveedoresClientVariables.getSupplier_Fechaanticiposfin()), OS$BuiltinFunctions.dateToText(ConectaProveedoresClientVariables.getSupplier_Fechaanticiposinicio()), OS$BuiltinFunctions.dateToText(ConectaProveedoresClientVariables.getSupplier_Fechapartidasabiertas()), OS$BuiltinFunctions.dateToText(ConectaProveedoresClientVariables.getSupplier_Fechacompensadasfin()), OS$BuiltinFunctions.dateToText(ConectaProveedoresClientVariables.getSupplier_Fechacompensadasinicio()), model.variables.regionSelectedVar, model.variables.supplierDetailIdentifierVar, callContext).then(function (value) {
generateCurrentAccountPdfVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateCurrentAccountPdfVar.value.o_fileOut, (("CurrentAccount" + OS$BuiltinFunctions.dateTimeToText(OS$BuiltinFunctions.currDateTime())) + ".pdf")));
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
_getSupplierUserByUserIdOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSupplierUserByUserIdOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "99dcdd75-2671-4690-96d0-06ffd6e6f1f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSupplierUserByUserIdOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetSupplierDetailsBySupplierId
var result = controller.getSupplierDetailsBySupplierId$AggrRefresh(999999999, 0, callContext);
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
_paginationOnNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("PaginationOnNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "ad99537e-43cc-4c2c-8b7f-30805d92f31f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("PaginationOnNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.PaginationOnNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// StartIndex = NewStartIndex
model.variables.startIndexVar = vars.value.newStartIndexInLocal;
if(((model.variables.invoiceTextNumberVar === ""))) {
// Execute Action: ShowData
controller._showData$Action(callContext);
} else {
// Execute Action: ShowDataFiltered
controller._showDataFiltered$Action(callContext);
}

// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_tabsOnTabChange$Action(activeTabIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("TabsOnTabChange", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "b4b4e6b9-e151-43bf-91a9-c9645aaf90c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("TabsOnTabChange");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.TabsOnTabChange$vars"))());
vars.value.activeTabInLocal = activeTabIn;
// l_Tab = ActiveTab
model.variables.l_TabVar = vars.value.activeTabInLocal;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_picker_FechacompensadasfinOnSelected$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Picker_FechacompensadasfinOnSelected", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechacompensadasfinOnSelected");
span.setAttribute("outsystems.function.key", "b4d00d84-ef67-4bf6-92a5-dcdad6c750bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Picker_FechacompensadasfinOnSelected");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechacompensadasfinOnSelected$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Supplier_Fechacompensadasfin = SelectedDateTime
ConectaProveedoresClientVariables.setSupplier_Fechacompensadasfin(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_find$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Find", function (span) {
if(span) {
span.setAttribute("code.function", "Find");
span.setAttribute("outsystems.function.key", "be2af04c-213d-45a8-afb5-1092911b1151");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Find");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
if(((OS$BuiltinFunctions.trim(model.variables.invoiceTextNumberVar) === ""))) {
// TotalRecords = GetSapData.List.T_FACT_PEN_PAG_Out.Length
model.variables.totalRecordsVar = model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.length;
// StartIndex = 0
model.variables.startIndexVar = 0;
// Execute Action: ShowData
controller._showData$Action(callContext);
} else {
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr, function (p) {
return (p.xBLNRAttr === model.variables.invoiceTextNumberVar);
}, callContext);

// TotalRecords = ListFilter.FilteredList.Length
model.variables.totalRecordsVar = listFilterVar.value.filteredListOut.length;
// StartIndex = 0
model.variables.startIndexVar = 0;
// L_FACTPENPAGFiltered = ListFilter.FilteredList
model.variables.l_FACTPENPAGFilteredVar = listFilterVar.value.filteredListOut;
// Execute Action: ShowDataFiltered
controller._showDataFiltered$Action(callContext);
}

// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_showData$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ShowData", function (span) {
if(span) {
span.setAttribute("code.function", "ShowData");
span.setAttribute("outsystems.function.key", "c622f3b8-99e7-4033-a8d3-9203f01f985c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("ShowData");
callContext = controller.callContext(callContext);
var listFilterVar = new OS$DataTypes.VariableHolder();
// Execute Action: ListClear
OS$SystemActions.listClear(model.variables.l_FACTPENPAGVar, callContext);
// Foreach GetSapData.List.T_FACT_PEN_PAG_Out
callContext.iterationContext.registerIterationStart(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr);
try {var t_FACT_PEN_PAG_OutIterator = callContext.iterationContext.getIterator(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr);
var t_FACT_PEN_PAG_OutIndexMax = model.variables.maxRecordsVar;
var t_FACT_PEN_PAG_OutIndex = model.variables.startIndexVar;
while ((((t_FACT_PEN_PAG_OutIndex < model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.length)) && (t_FACT_PEN_PAG_OutIndexMax > 0))) {
t_FACT_PEN_PAG_OutIterator.currentRowNumber = t_FACT_PEN_PAG_OutIndex;
// Execute Action: ListFilter
listFilterVar.value = OS$SystemActions.listFilter(model.variables.getPaymentTermsAggr.listOut, function (p) {
return (OS$BuiltinFunctions.trim(p.paymentTermsAttr.estructuraDescripcionPROPAttr) === OS$BuiltinFunctions.trim(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getItem(t_FACT_PEN_PAG_OutIndex.valueOf()).zTERMAttr));
}, callContext);

// Set Payment Terms
// GetSapData.List.T_FACT_PEN_PAG_Out.Current.ZTERM = If
model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getItem(t_FACT_PEN_PAG_OutIndex.valueOf()).zTERMAttr = ((listFilterVar.value.filteredListOut.isEmpty) ? (model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getItem(t_FACT_PEN_PAG_OutIndex.valueOf()).zTERMAttr) : (listFilterVar.value.filteredListOut.getCurrent(callContext.iterationContext).paymentTermsAttr.descriptionAttr));
// Execute Action: ListAppend
OS$SystemActions.listAppend(model.variables.l_FACTPENPAGVar, model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.getItem(t_FACT_PEN_PAG_OutIndex.valueOf()), callContext);
t_FACT_PEN_PAG_OutIndexMax--;
t_FACT_PEN_PAG_OutIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr);
}

} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getSapDataOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSapDataOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "d8537f63-8233-414a-89f5-3a7d0c5d5070");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("GetSapDataOnAfterFetch");
callContext = controller.callContext(callContext);
var listDistinctVar = new OS$DataTypes.VariableHolder();
// Foreach GetSapData.List.T_FAC_PAG_CAB_Out
callContext.iterationContext.registerIterationStart(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
try {var t_FAC_PAG_CAB_OutIterator = callContext.iterationContext.getIterator(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
var t_FAC_PAG_CAB_OutIndex = 0;
while (((t_FAC_PAG_CAB_OutIndex < model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr.length))) {
t_FAC_PAG_CAB_OutIterator.currentRowNumber = t_FAC_PAG_CAB_OutIndex;
// Set Zero
// GetSapData.List.T_FAC_PAG_CAB_Out.Current.KURSF = 0
model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr.getItem(t_FAC_PAG_CAB_OutIndex.valueOf()).kURSFAttr = OS$BuiltinFunctions.integerToDecimal(0);
t_FAC_PAG_CAB_OutIndex++;
}

} finally {
callContext.iterationContext.registerIterationEnd(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr);
}

// Execute Action: ListDistinct
listDistinctVar.value = OS$SystemActions.listDistinct(model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr, callContext);

// GetSapData.List.T_FAC_PAG_CAB_Out = ListDistinct.DistinctList
model.variables.getSapDataDataAct.listOut.t_FAC_PAG_CAB_OutAttr = listDistinctVar.value.distinctListOut;
// Execute Action: ShowData
controller._showData$Action(callContext);
// TotalRecords = GetSapData.List.T_FACT_PEN_PAG_Out.Length
model.variables.totalRecordsVar = model.variables.getSapDataDataAct.listOut.t_FACT_PEN_PAG_OutAttr.length;
// ViewDetail = True
model.variables.viewDetailVar = true;
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_picker_FechaFechapartidasabiertasOnSelect$Action(selectedDateTimeIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("Picker_FechaFechapartidasabiertasOnSelect", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaFechapartidasabiertasOnSelect");
span.setAttribute("outsystems.function.key", "db347b8f-f8b7-4d4b-b22a-e3d04b6e3ded");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("Picker_FechaFechapartidasabiertasOnSelect");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaFechapartidasabiertasOnSelect$vars"))());
vars.value.selectedDateTimeInLocal = selectedDateTimeIn;
// Supplier_Fechapartidasabiertas = SelectedDateTime
ConectaProveedoresClientVariables.setSupplier_Fechapartidasabiertas(OS$BuiltinFunctions.dateTimeToDate(vars.value.selectedDateTimeInLocal));
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_exportOnClickExcel$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExportOnClickExcel", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOnClickExcel");
span.setAttribute("outsystems.function.key", "dd303d4d-251e-4afb-9bb8-6cb481d776c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExportOnClickExcel");
callContext = controller.callContext(callContext);
var exportProviderCurrentAccountExcelVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: ExportProviderCurrentAccountExcel
model.flush();
return controller.exportProviderCurrentAccountExcel$ServerAction(model.variables.getSapDataDataAct.listOut, callContext).then(function (value) {
exportProviderCurrentAccountExcelVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(exportProviderCurrentAccountExcelVar.value.fileOut, (("CurrentAccount" + OS$BuiltinFunctions.dateTimeToText(OS$BuiltinFunctions.currDateTime())) + ".zip")));
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
_exportOnClickCSV$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExportOnClickCSV", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOnClickCSV");
span.setAttribute("outsystems.function.key", "e232a93f-c296-4945-b3ef-f71f44d70ca3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExportOnClickCSV");
callContext = controller.callContext(callContext);
var generateCurrentAccountCSVVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ShowLoading
ConectaProveedoresController$showLoading$Action(callContext);
// Execute Action: GenerateCurrentAccountCSV
model.flush();
return controller.generateCurrentAccountCSV$ServerAction(model.variables.getSapDataDataAct.listOut, callContext).then(function (value) {
generateCurrentAccountCSVVar.value = value;
}).then(function () {
// Execute Action: HideLoading
ConectaProveedoresController$hideLoading$Action(callContext);
return OS$Flow.returnAsync(OS$Controller.BaseViewController.downloadBinary(generateCurrentAccountCSVVar.value.fileOut, (("CurrentAccount" + OS$BuiltinFunctions.dateTimeToText(OS$BuiltinFunctions.currDateTime())) + ".zip")));
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

showDataFiltered$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowDataFiltered__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowDataFiltered");
span.setAttribute("outsystems.function.key", "16a0b778-9b84-4dc5-8b72-0b585a70e286");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showDataFiltered$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "1f8e0309-2969-4dce-b698-676a4295392a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._onSort$Action, callContext, sortByIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

picker_FechaanticiposfinOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Picker_FechaanticiposfinOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaanticiposfinOnSelected");
span.setAttribute("outsystems.function.key", "2d148313-2116-4b6c-96f7-7f6397f1d490");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._picker_FechaanticiposfinOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

searchOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SearchOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SearchOnClick");
span.setAttribute("outsystems.function.key", "412046e5-1c10-4f94-8885-27ea90e7e12d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._searchOnClick$Action, callContext);
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
span.setAttribute("outsystems.function.key", "42b8f570-4978-4d5e-922c-2531fe2b7316");
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

picker_FechacompensadasinicioOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Picker_FechacompensadasinicioOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechacompensadasinicioOnSelected");
span.setAttribute("outsystems.function.key", "507b6093-bd90-4aa2-9976-68da9cfb37b5");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._picker_FechacompensadasinicioOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

onReady$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnReady__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnReady");
span.setAttribute("outsystems.function.key", "51f8ef29-f5d1-4703-a837-562f8221ce3c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onReady$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

picker_FechaanticiposinicioOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Picker_FechaanticiposinicioOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaanticiposinicioOnSelected");
span.setAttribute("outsystems.function.key", "61b4351e-11ce-4393-a090-e3167c32c667");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._picker_FechaanticiposinicioOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

exportPDFOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportPDFOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExportPDFOnClick");
span.setAttribute("outsystems.function.key", "7fe6d7fa-ad4f-44a1-8926-d9628705ba2c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._exportPDFOnClick$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getSupplierUserByUserIdOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSupplierUserByUserIdOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSupplierUserByUserIdOnAfterFetch");
span.setAttribute("outsystems.function.key", "99dcdd75-2671-4690-96d0-06ffd6e6f1f6");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSupplierUserByUserIdOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

paginationOnNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("PaginationOnNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "PaginationOnNavigate");
span.setAttribute("outsystems.function.key", "ad99537e-43cc-4c2c-8b7f-30805d92f31f");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._paginationOnNavigate$Action, callContext, newStartIndexIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

tabsOnTabChange$Action(activeTabIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("TabsOnTabChange__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "TabsOnTabChange");
span.setAttribute("outsystems.function.key", "b4b4e6b9-e151-43bf-91a9-c9645aaf90c8");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._tabsOnTabChange$Action, callContext, activeTabIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

picker_FechacompensadasfinOnSelected$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Picker_FechacompensadasfinOnSelected__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechacompensadasfinOnSelected");
span.setAttribute("outsystems.function.key", "b4d00d84-ef67-4bf6-92a5-dcdad6c750bd");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._picker_FechacompensadasfinOnSelected$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

find$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Find__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Find");
span.setAttribute("outsystems.function.key", "be2af04c-213d-45a8-afb5-1092911b1151");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._find$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

showData$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ShowData__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ShowData");
span.setAttribute("outsystems.function.key", "c622f3b8-99e7-4033-a8d3-9203f01f985c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._showData$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getSapDataOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSapDataOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSapDataOnAfterFetch");
span.setAttribute("outsystems.function.key", "d8537f63-8233-414a-89f5-3a7d0c5d5070");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._getSapDataOnAfterFetch$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

picker_FechaFechapartidasabiertasOnSelect$Action(selectedDateTimeIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("Picker_FechaFechapartidasabiertasOnSelect__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "Picker_FechaFechapartidasabiertasOnSelect");
span.setAttribute("outsystems.function.key", "db347b8f-f8b7-4d4b-b22a-e3d04b6e3ded");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._picker_FechaFechapartidasabiertasOnSelect$Action, callContext, selectedDateTimeIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

exportOnClickExcel$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportOnClickExcel__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOnClickExcel");
span.setAttribute("outsystems.function.key", "dd303d4d-251e-4afb-9bb8-6cb481d776c0");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._exportOnClickExcel$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

exportOnClickCSV$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExportOnClickCSV__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExportOnClickCSV");
span.setAttribute("outsystems.function.key", "e232a93f-c296-4945-b3ef-f71f44d70ca3");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._exportOnClickCSV$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
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
this._onReadyEventHandler = function (callContext) {
var controller = this.controller;
var model = this.model;
var idService = this.idService;

return controller.onReady$Action(callContext);

};
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
return ConectaProveedores_c_ProveedorController$default.handleError(ex, this.callContext());
};
}

return this._handleError;
}set handleError(value) {this._handleError = value;
}

static checkPermissions() {
OS$Authorization.ensureUserHasRole({
roles: [ConectaProveedoresController$default.roles.Proveedor]
});
}

getDefaultTimeout() {
return ConectaProveedoresController$default.defaultTimeout;
}

}

var Controller = ControllerInner;
// Server Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionGenerateCurrentAccountPdf", [{
name: "o_file",
attrName: "o_fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionExportProviderCurrentAccountExcel", [{
name: "file",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus$ActionGenerateCurrentAccountCSV", [{
name: "file",
attrName: "fileOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.BinaryData,
defaultValue: function () {
return OS$DataTypes.BinaryData.defaultValue;
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaanticiposfinOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechacompensadasinicioOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaanticiposinicioOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.PaginationOnNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.TabsOnTabChange$vars", [{
name: "ActiveTab",
attrName: "activeTabInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechacompensadasfinOnSelected$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Proveedor.AccountStatus.Picker_FechaFechapartidasabiertasOnSelect$vars", [{
name: "SelectedDateTime",
attrName: "selectedDateTimeInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.DateTime,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


