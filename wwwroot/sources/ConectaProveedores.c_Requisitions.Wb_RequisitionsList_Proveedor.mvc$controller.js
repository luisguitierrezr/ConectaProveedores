import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, BuiltinFunctions as OS$BuiltinFunctions, Exceptions as OS$Exceptions, GenericTypeCache as OS$GenericTypeCache } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClose$Action as OutSystemsUIController$datePickerClose$Action, datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import { ST_60f22bd2e9b10a22278b8afe6d7f601aStructure } from "./OutSystemsUI.model.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionsList_Proveedor_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getRequisitionsProveedor$AggrRefresh: 0,
getCompanies$AggrRefresh: 0,
getProjectAssetServices$AggrRefresh: 0,
getDistinctRegions$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getRequisitionsProveedor$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getProjectAssetServices$AggrRefresh: [],
getDistinctRegions$DataActRefresh: []
};
this.shouldSendClientVarsToDataSources = true;
}

// Server Actions - Methods
columnTogglerPassColumn$ServerAction(i_ColumnJSONIn, i_TableNameIn, i_UserIdIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "68473301-c3d5-4d78-a652-7ce384c4cbd7");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
i_ColumnJSON: OS$DataConversion.ServerDataConverter.to(i_ColumnJSONIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_TableName: OS$DataConversion.ServerDataConverter.to(i_TableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
}),
i_UserId: OS$DataConversion.ServerDataConverter.to(i_UserIdIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
});
}, function () {
if(span) {
span.end();
}

});
}, 0);
}
;
getSettings$ServerAction(tableNameIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSettings", function (span) {
if(span) {
span.setAttribute("code.function", "GetSettings");
span.setAttribute("outsystems.function.key", "cf0e9209-a3bd-4677-a149-06f9ec265149");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "SCREEN_SERVICE_SERVER_ACTION_CALL");
}

return OS$Flow.tryFinally(function () {
var pendingPromises = [];
var inputs = {
TableName: OS$DataConversion.ServerDataConverter.to(tableNameIn, {
dataType: OS$DataTypes.DataTypes.Text,
pendingPromises: pendingPromises
})
};
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor$ActionGetSettings"))();
executeServerActionResult.outSettingsTextOut = OS$DataConversion.ServerDataConverter.from(outputs.OutSettingsText, OS$DataTypes.DataTypes.Text);
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
get getRequisitionsProveedor$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionsProveedor$AggrRefresh"))) {
this._getRequisitionsProveedor$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionsProveedor", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/ScreenDataSetGetRequisitionsProveedor", "NqGYa2kZt82jNEj4qL2Kwg", maxRecords, startIndex, function (b) {
model.variables.getRequisitionsProveedorAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsProveedorAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsProveedorAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionsProveedor", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsProveedor");
span.setAttribute("outsystems.function.key", "59347a2c-2d7a-48b6-9e67-08d19f3481e6");
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

return this._getRequisitionsProveedor$AggrRefresh;
}set getRequisitionsProveedor$AggrRefresh(value) {this._getRequisitionsProveedor$AggrRefresh = value;
}

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "c8bd5f32-fbf0-42aa-a6a9-5f03208d7719");
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

return this._getCompanies$AggrRefresh;
}set getCompanies$AggrRefresh(value) {this._getCompanies$AggrRefresh = value;
}

get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "fff91243-9c64-4574-a953-3997bb0717f1");
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

return this._getProjectAssetServices$AggrRefresh;
}set getProjectAssetServices$AggrRefresh(value) {this._getProjectAssetServices$AggrRefresh = value;
}

get getDistinctRegions$DataActRefresh() {if(!(this.hasOwnProperty("_getDistinctRegions$DataActRefresh"))) {
this._getDistinctRegions$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetDistinctRegions", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionsList_Proveedor/DataActionGetDistinctRegions", "woYCBi5jA1pXLVCAwQvdPg", function (b) {
model.variables.getDistinctRegionsDataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getDistinctRegionsDataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getDistinctRegionsDataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getDistinctRegionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetDistinctRegions", function (span) {
if(span) {
span.setAttribute("code.function", "GetDistinctRegions");
span.setAttribute("outsystems.function.key", "fbc604e6-4904-4e2f-ab60-638e31d9acc3");
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

return this._getDistinctRegions$DataActRefresh;
}set getDistinctRegions$DataActRefresh(value) {this._getDistinctRegions$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getRequisitionsProveedor$AggrRefresh", "getCompanies$AggrRefresh", "getProjectAssetServices$AggrRefresh", "getDistinctRegions$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_clearCreationDateTo$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearCreationDateTo", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDateTo");
span.setAttribute("outsystems.function.key", "0f26abf0-1c22-4d68-a09b-fa58a95ebdc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearCreationDateTo");
callContext = controller.callContext(callContext);
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
var datePickerClearVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Requisitions_ProveedorFilter_UploadDateTo = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateTo(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerProveedorTo"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorTo"), callContext);

// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_datePickerFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "105bf858-5ef7-4554-a5e6-5ccbdf8e97df");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DatePickerFrom$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Requisitions_ProveedorFilter_UploadDateFrom = SelectedDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "10cf08b6-5add-4f39-928d-2757c2d30b6a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.ColumnTogglerPassColumn$vars"))());
vars.value.columnJSONInLocal = columnJSONIn;
return OS$Flow.executeAsyncFlow(function () {
// Execute Action: ColumnTogglerPassColumn
model.flush();
return controller.columnTogglerPassColumn$ServerAction(vars.value.columnJSONInLocal, idService.getId("ConectaProveedoresRequisitionsGetRequisitions"), OS$BuiltinFunctions.getUserId(), callContext).then(function () {
// l_ColumnJSONVarGetRequisitions = ColumnJSON
model.variables.l_ColumnJSONVarGetRequisitionsVar = vars.value.columnJSONInLocal;
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "3f99e523-41c2-4d22-a426-5e0cb28dae06");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetRequisitionsProveedor
var result = controller.getRequisitionsProveedor$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
span.setAttribute("outsystems.function.key", "4b349fd3-95c8-4e99-a9df-8ada27388244");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("OnInitialize");
callContext = controller.callContext(callContext);
// l_AmountFromText = Requisitions_AmountFrom
model.variables.l_AmountFromTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getRequisitions_AmountFrom());
// l_AmountToText = Requisitions_AmountTo
model.variables.l_AmountToTextVar = OS$BuiltinFunctions.decimalToText(ConectaProveedoresClientVariables.getRequisitions_AmountTo());
// l_ShowFilters = Requisitions_ProjectId <> NullIdentifier or Requisitions_AmountFrom <> 0 or Requisitions_AmountTo <> 0
model.variables.l_ShowFiltersVar = ((!(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))));
// MaxRecords = If
ConectaProveedoresClientVariables.setMaxRecords((((ConectaProveedoresClientVariables.getMaxRecords() <= 5)) ? (5) : (ConectaProveedoresClientVariables.getMaxRecords())));
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
span.setAttribute("outsystems.function.key", "6d5d5f4a-5f11-4406-87fa-03049f19a31e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.OnSort$vars"))());
vars.value.sortByInLocal = sortByIn;
return OS$Flow.executeAsyncFlow(function () {
if((((model.variables.l_TableSortVar === vars.value.sortByInLocal) && ((vars.value.sortByInLocal) !== (""))))) {
// TableSort += DESC
// l_TableSort = SortBy + " DESC"
model.variables.l_TableSortVar = (vars.value.sortByInLocal + " DESC");
} else {
// TableSort = SortBy
// l_TableSort = SortBy
model.variables.l_TableSortVar = vars.value.sortByInLocal;
}

// StartIndex = 0
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
// Refresh Query: GetRequisitionsProveedor
var result = controller.getRequisitionsProveedor$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_getDistinctRegionsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetDistinctRegionsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetDistinctRegionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "71a962fc-0141-4854-8b01-531e957a97dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetDistinctRegionsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Refresh Query: GetRequisitionsProveedor
var result = controller.getRequisitionsProveedor$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "75ee02f7-c51b-48bb-8aa3-53839f02c6ef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.RefreshList$vars"))());
vars.value.i_IsClearFiltersInLocal = i_IsClearFiltersIn;
var datePickerClearPaymentDateToVar = new OS$DataTypes.VariableHolder();
var datePickerClearUploadDateFromVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// l_StartIndex = 0
model.variables.l_StartIndexVar = 0;
if((vars.value.i_IsClearFiltersInLocal)) {
// Reset Filters
// Requisitions_AmountFrom = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_AmountTo = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_CompanyId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_CompanyId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_RequisitionSearch = ""
ConectaProveedoresClientVariables.setRequisitions_RequisitionSearch("");
// Requisitions_SupplierId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_SupplierId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_UploadDate = NullDate
ConectaProveedoresClientVariables.setRequisitions_UploadDate(OS$BuiltinFunctions.nullDate());
// Requisitions_ProjectId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_RequisitionsStatusId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_RequisitionsStatusId(OS$BuiltinFunctions.nullIdentifier());
// Requisitions_ProveedorFilter_UploadDateFrom = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(OS$BuiltinFunctions.nullDate());
// Requisitions_ProveedorFilter_UploadDateTo = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateTo(OS$BuiltinFunctions.nullDate());
// Requisitions_ApprovalStatusId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ApprovalStatusId(OS$BuiltinFunctions.nullIdentifier());
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
// Requisitions_CostCenterId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_CostCenterId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// Execute Action: DatePickerClearUploadDateFrom
datePickerClearUploadDateFromVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorFrom"), callContext);

// Execute Action: DatePickerClearPaymentDateTo
datePickerClearPaymentDateToVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorTo"), callContext);

}

// Refresh Query: GetRequisitionsProveedor
var result = controller.getRequisitionsProveedor$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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
_clearCreationDateFrom$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ClearCreationDateFrom", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDateFrom");
span.setAttribute("outsystems.function.key", "7667f944-c089-4a8d-8dbf-bb6b55f8d3da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ClearCreationDateFrom");
callContext = controller.callContext(callContext);
var datePickerClearVar = new OS$DataTypes.VariableHolder();
var datePickerCloseVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
// Clear date
// Requisitions_ProveedorFilter_UploadDateFrom = NullDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateFrom(OS$BuiltinFunctions.nullDate());
// Execute Action: DatePickerClose
datePickerCloseVar.value = OutSystemsUIController$datePickerClose$Action(idService.getId("DatePickerProveedorFrom"), callContext);

// Execute Action: DatePickerClear
datePickerClearVar.value = OutSystemsUIController$datePickerClear$Action(idService.getId("DatePickerProveedorFrom"), callContext);

// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "91e8bf99-ffa2-492b-9f66-eca169348895");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnDebounce");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
// Requisitions_AmountFrom = TextToDecimal
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountFromTextVar));
// Requisitions_AmountTo = TextToDecimal
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.textToDecimal(model.variables.l_AmountToTextVar));
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_datePickerTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "b354a034-e251-499b-bf9b-15cbb7669758");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DatePickerTo$vars"))());
vars.value.selectedDateInLocal = selectedDateIn;
// Requisitions_ProveedorFilter_UploadDateTo = SelectedDate
ConectaProveedoresClientVariables.setRequisitions_ProveedorFilter_UploadDateTo(vars.value.selectedDateInLocal);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "b6cb7350-96f0-40a2-8050-2a70f8b845b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("DropdownProjectSearchOnChanged");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DropdownProjectSearchOnChanged$vars"))());
vars.value.selectedOptionListInLocal = selectedOptionListIn.clone();
return OS$Flow.executeAsyncFlow(function () {
// Requisitions_ProjectId = IntegerToIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.integerToIdentifier(OS$BuiltinFunctions.textToInteger(vars.value.selectedOptionListInLocal.getCurrent(callContext.iterationContext).valueAttr))));
// Execute Action: RefreshList
return controller._refreshList$Action(false, callContext);
});
}, function () {
if(span) {
span.end();
}

});
}, 1);
}
;
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "befd49cf-e794-44bd-bbfa-c9cc0e43a18c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.ExpandFilters$vars"))());
return OS$Flow.executeAsyncFlow(function () {
// l_ShowFilters = notl_ShowFilters
model.variables.l_ShowFiltersVar = (!(model.variables.l_ShowFiltersVar));
return OS$Flow.executeSequence(function () {
if((!(model.variables.l_ShowFiltersVar))) {
// IsRefresh = Requisitions_CompanyId <> NullIdentifier or Requisitions_ProjectId <> NullIdentifier or Requisitions_AmountFrom <> 0 or Requisitions_AmountTo <> 0
vars.value.isRefreshVar = (((!(ConectaProveedoresClientVariables.getRequisitions_CompanyId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || !(ConectaProveedoresClientVariables.getRequisitions_ProjectId().equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountFrom().equals(OS$BuiltinFunctions.integerToDecimal(0)))) || !(ConectaProveedoresClientVariables.getRequisitions_AmountTo().equals(OS$BuiltinFunctions.integerToDecimal(0))));
// Reset Filters
// Requisitions_AmountFrom = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountFrom(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_AmountTo = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_AmountTo(OS$BuiltinFunctions.integerToDecimal(OS$BuiltinFunctions.nullIdentifier()));
// Requisitions_ProjectId = NullIdentifier
ConectaProveedoresClientVariables.setRequisitions_ProjectId(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()));
// l_AmountFromText = 0
model.variables.l_AmountFromTextVar = "0";
// l_AmountToText = 0
model.variables.l_AmountToTextVar = "0";
return OS$Flow.executeSequence(function () {
if((vars.value.isRefreshVar)) {
// Refresh Query: GetRequisitionsProveedor
var result = controller.getRequisitionsProveedor$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
model.flush();
return result.then(function () {
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
});
}

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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "ddadecb6-802f-4636-b9d8-27d8f130230c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("SetColumnVisiblityOnClick");
callContext = controller.callContext(callContext);
} finally {
if(span) {
span.end();
}

}

}, 1);
}
;
_getRequisitionsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "ea9e6aaa-8772-4888-bc38-3798fa1d3def");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetRequisitionsOnAfterFetch");
callContext = controller.callContext(callContext);
var getSettingsVar = new OS$DataTypes.VariableHolder();
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if(((model.variables.l_CountAfterFetchGetRequisitionsVar === 0))) {
// l_CountAfterFetchGetRequisitions = l_CountAfterFetchGetRequisitions + 1
model.variables.l_CountAfterFetchGetRequisitionsVar = (model.variables.l_CountAfterFetchGetRequisitionsVar + 1);
// Execute Action: GetSettings
model.flush();
return controller.getSettings$ServerAction(idService.getId("ConectaProveedoresRequisitionsGetRequisitions"), callContext).then(function (value) {
getSettingsVar.value = value;
}).then(function () {
// l_ColumnJSONVarGetRequisitions = GetSettings.OutSettingsText
model.variables.l_ColumnJSONVarGetRequisitionsVar = getSettingsVar.value.outSettingsTextOut;
// l_ReInvokeToggler = notl_ReInvokeToggler
model.variables.l_ReInvokeTogglerVar = (!(model.variables.l_ReInvokeTogglerVar));
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

clearCreationDateTo$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearCreationDateTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDateTo");
span.setAttribute("outsystems.function.key", "0f26abf0-1c22-4d68-a09b-fa58a95ebdc4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearCreationDateTo$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "105bf858-5ef7-4554-a5e6-5ccbdf8e97df");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerFrom$Action, callContext, selectedDateIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "10cf08b6-5add-4f39-928d-2757c2d30b6a");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._columnTogglerPassColumn$Action, callContext, columnJSONIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "3f99e523-41c2-4d22-a426-5e0cb28dae06");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onPaginationNavigate$Action, callContext, newStartIndexIn);
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
span.setAttribute("outsystems.function.key", "4b349fd3-95c8-4e99-a9df-8ada27388244");
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "6d5d5f4a-5f11-4406-87fa-03049f19a31e");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onSort$Action, callContext, sortByIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getDistinctRegionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetDistinctRegionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetDistinctRegionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "71a962fc-0141-4854-8b01-531e957a97dc");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getDistinctRegionsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "75ee02f7-c51b-48bb-8aa3-53839f02c6ef");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._refreshList$Action, callContext, i_IsClearFiltersIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

clearCreationDateFrom$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ClearCreationDateFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ClearCreationDateFrom");
span.setAttribute("outsystems.function.key", "7667f944-c089-4a8d-8dbf-bb6b55f8d3da");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._clearCreationDateFrom$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "91e8bf99-ffa2-492b-9f66-eca169348895");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._onDebounce$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

datePickerTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "b354a034-e251-499b-bf9b-15cbb7669758");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._datePickerTo$Action, callContext, selectedDateIn);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

dropdownProjectSearchOnChanged$Action(selectedOptionListIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DropdownProjectSearchOnChanged__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DropdownProjectSearchOnChanged");
span.setAttribute("outsystems.function.key", "b6cb7350-96f0-40a2-8050-2a70f8b845b4");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._dropdownProjectSearchOnChanged$Action, callContext, selectedOptionListIn);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

expandFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExpandFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "befd49cf-e794-44bd-bbfa-c9cc0e43a18c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._expandFilters$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "ddadecb6-802f-4636-b9d8-27d8f130230c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {return controller.safeExecuteClientAction(controller._setColumnVisiblityOnClick$Action, callContext);
} finally {
if(span) {
span.end();
}

}

}, 0);

}

getRequisitionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "ea9e6aaa-8772-4888-bc38-3798fa1d3def");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getRequisitionsOnAfterFetch$Action, callContext);
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DatePickerFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DatePickerTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.DropdownProjectSearchOnChanged$vars", [{
name: "SelectedOptionList",
attrName: "selectedOptionListInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.RecordList,
defaultValue: function () {
return new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))();
},
complexType: (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionsList_Proveedor.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


