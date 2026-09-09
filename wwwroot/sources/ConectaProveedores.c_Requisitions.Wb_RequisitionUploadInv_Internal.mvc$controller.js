import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import { Controller as OS$Controller, Flow as OS$Flow, Logger as OS$Logger, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, Exceptions as OS$Exceptions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedoresLanguageResources from "./ConectaProveedores.languageResources.js";
import { datePickerClear$Action as OutSystemsUIController$datePickerClear$Action } from "./OutSystemsUI.controller.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_mvc_TranslationsResources from "./ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.mvc$translationsResources.js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";

{class ControllerInner extends 
OS$Controller.BaseViewController {
constructor(model, messagesProvider, idService) {
super(model, messagesProvider, idService, ConectaProveedores_c_Requisitions_Wb_RequisitionUploadInv_Internal_mvc_TranslationsResources);
var controller = this.controller;
this.clientActionProxies = {};
this.dataFetchDependenciesOriginal = {
getProjectAssetServices$AggrRefresh: 0,
getRequisitionsForUpload$AggrRefresh: -1,
getCompanies$AggrRefresh: 0,
getApprovalProcessIds2$DataActRefresh: 0
};
this.dataFetchDependentsGraph = {
getProjectAssetServices$AggrRefresh: [],
getRequisitionsForUpload$AggrRefresh: [],
getCompanies$AggrRefresh: [],
getApprovalProcessIds2$DataActRefresh: ["getRequisitionsForUpload$AggrRefresh"]
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
return controller.callServerAction("ColumnTogglerPassColumn", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/ActionColumnTogglerPassColumn", "CdBjpqOzG3k0+Q1AYbtdhg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
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
return controller.callServerAction("GetSettings", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/ActionGetSettings", "YMh+L1Z1H9xV5gLNPZiIAg", inputs, controller.callContext(callContext), undefined, undefined, true, pendingPromises).then(function (outputs) {
var executeServerActionResult = new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal$ActionGetSettings"))();
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
get getProjectAssetServices$AggrRefresh() {if(!(this.hasOwnProperty("_getProjectAssetServices$AggrRefresh"))) {
this._getProjectAssetServices$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetProjectAssetServices", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/ScreenDataSetGetProjectAssetServices", "QmIftqTsNkC++1frUcNFQw", maxRecords, startIndex, function (b) {
model.variables.getProjectAssetServicesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getProjectAssetServicesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getProjectAssetServicesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetProjectAssetServices", function (span) {
if(span) {
span.setAttribute("code.function", "GetProjectAssetServices");
span.setAttribute("outsystems.function.key", "1709d2d1-6966-4642-8488-3805b28f88bc");
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

get getRequisitionsForUpload$AggrRefresh() {if(!(this.hasOwnProperty("_getRequisitionsForUpload$AggrRefresh"))) {
this._getRequisitionsForUpload$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetRequisitionsForUpload", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/ScreenDataSetGetRequisitionsForUpload", "1ceECdIrYAzCq82jp7gAPQ", maxRecords, startIndex, function (b) {
model.variables.getRequisitionsForUploadAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getRequisitionsForUploadAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getRequisitionsForUploadAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getRequisitionsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetRequisitionsForUpload", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsForUpload");
span.setAttribute("outsystems.function.key", "7b7b00fd-939f-4ae0-b084-c9e5d3dadfa5");
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

return this._getRequisitionsForUpload$AggrRefresh;
}set getRequisitionsForUpload$AggrRefresh(value) {this._getRequisitionsForUpload$AggrRefresh = value;
}

get getCompanies$AggrRefresh() {if(!(this.hasOwnProperty("_getCompanies$AggrRefresh"))) {
this._getCompanies$AggrRefresh = function () {
var innerBody = function (maxRecords, startIndex, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callAggregateWithStartIndexAndClientVars("ScreenDataSetGetCompanies", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/ScreenDataSetGetCompanies", "dUlLiZXilCXZfHjYY_ZYJg", maxRecords, startIndex, function (b) {
model.variables.getCompaniesAggr.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getCompaniesAggr.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getCompaniesAggr.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true);
}.bind(this);
return OS$Logger.startActiveSpan("GetCompanies", function (span) {
if(span) {
span.setAttribute("code.function", "GetCompanies");
span.setAttribute("outsystems.function.key", "a8c256a4-4794-497a-ad5e-8993a432a1f5");
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

get getApprovalProcessIds2$DataActRefresh() {if(!(this.hasOwnProperty("_getApprovalProcessIds2$DataActRefresh"))) {
this._getApprovalProcessIds2$DataActRefresh = function () {
var innerBody = function (callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
var callContext = controller.callContext(callContext);
return controller.callDataAction("DataActionGetApprovalProcessIds2", "screenservices/ConectaProveedores/c_Requisitions/Wb_RequisitionUploadInv_Internal/DataActionGetApprovalProcessIds2", "J3HdnFtqJ75YA0ktpUGprQ", function (b) {
model.variables.getApprovalProcessIds2DataAct.dataFetchStatusAttr = b;
}, function (json) {
model.variables.getApprovalProcessIds2DataAct.replaceWith(OS$DataConversion.ServerDataConverter.from(json, model.variables.getApprovalProcessIds2DataAct.constructor));
}, undefined, undefined, undefined, callContext, ConectaProveedoresClientVariables, true).then(function () {
return controller._getSpecialWorkflowIdsOnAfterFetch$Action(controller.callContext(callContext));
});
}.bind(this);
return OS$Logger.startActiveSpan("GetApprovalProcessIds2", function (span) {
if(span) {
span.setAttribute("code.function", "GetApprovalProcessIds2");
span.setAttribute("outsystems.function.key", "b3a4f2bb-db93-40db-a70e-bd442f0805a7");
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

return this._getApprovalProcessIds2$DataActRefresh;
}set getApprovalProcessIds2$DataActRefresh(value) {this._getApprovalProcessIds2$DataActRefresh = value;
}


get dataFetchActionNames() {if(!(this.hasOwnProperty("_dataFetchActionNames"))) {
this._dataFetchActionNames = ["getProjectAssetServices$AggrRefresh", "getRequisitionsForUpload$AggrRefresh", "getCompanies$AggrRefresh", "getApprovalProcessIds2$DataActRefresh"];
}

return this._dataFetchActionNames;
}set dataFetchActionNames(value) {this._dataFetchActionNames = value;
}

// Client Actions - Methods
_onSort$Action(sortByIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnSort", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "0393181d-4a64-4400-8f92-25e9efecae5d");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnSort");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.OnSort$vars"))());
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
// Refresh Query: GetRequisitionsForUpload
var result = controller.getRequisitionsForUpload$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_datePickerFrom$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerFrom", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "3bd20f7a-323c-49e1-bfdb-a5e33d016b0c");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerFrom");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.DatePickerFrom$vars"))());
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
_datePickerTo$Action(selectedDateIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("DatePickerTo", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "61e65755-9885-4dd9-97fc-024d889bd475");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

try {controller.ensureControllerAlive("DatePickerTo");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.DatePickerTo$vars"))());
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
_expandFilters$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ExpandFilters", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "665a5719-45a5-4b7f-875b-312ad03d3ef1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ExpandFilters");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.ExpandFilters$vars"))());
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
// Refresh Query: GetRequisitionsForUpload
var result = controller.getRequisitionsForUpload$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "69aa2c0b-5121-4138-9bf5-a181ab9ac119");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("ColumnTogglerPassColumn");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.ColumnTogglerPassColumn$vars"))());
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
_setColumnVisiblityOnClick$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "94d79161-c810-4587-bd2c-55f57e4d9150");
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
_refreshList$Action(i_IsClearFiltersIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("RefreshList", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b36e7ba2-6eb3-46b0-9a8c-09403cd2b475");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("RefreshList");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.RefreshList$vars"))());
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

// Refresh Query: GetRequisitionsForUpload
var result = controller.getRequisitionsForUpload$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_onDebounce$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnDebounce", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "bdaf2b80-a0b0-4b5d-864b-cd6c27ebf89f");
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
_onInitialize$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnInitialize", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c7661ee9-a57e-40ac-9cd9-be9e409be8a3");
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
_getSpecialWorkflowIdsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetSpecialWorkflowIdsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialWorkflowIdsOnAfterFetch");
span.setAttribute("outsystems.function.key", "c800d367-e2ea-4903-94d7-a04a06e2c2d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("GetSpecialWorkflowIdsOnAfterFetch");
callContext = controller.callContext(callContext);
return OS$Flow.executeAsyncFlow(function () {
return OS$Flow.executeSequence(function () {
if((!((model.variables.getApprovalProcessIds2DataAct.o_ApprovalProcessIdsOut === "")))) {
// Refresh Query: GetRequisitionsForUpload
var result = controller.getRequisitionsForUpload$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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
_getRequisitionsOnAfterFetch$Action(callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "f7259f4d-b38a-4f21-a178-d3b9212eb5bd");
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
_onPaginationNavigate$Action(newStartIndexIn, callContext) {
var model = this.model;
var controller = this.controller;
var idService = this.idService;
return OS$Logger.startActiveSpan("OnPaginationNavigate", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "f95a56a4-a434-443f-9bfe-c45e69762960");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
controller.ensureControllerAlive("OnPaginationNavigate");
callContext = controller.callContext(callContext);
var vars = new OS$DataTypes.VariableHolder(new (controller.constructor.getVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.OnPaginationNavigate$vars"))());
vars.value.newStartIndexInLocal = newStartIndexIn;
return OS$Flow.executeAsyncFlow(function () {
// StartIndex = NewStartIndex
// l_StartIndex = NewStartIndex
model.variables.l_StartIndexVar = vars.value.newStartIndexInLocal;
// Refresh Query: GetRequisitionsForUpload
var result = controller.getRequisitionsForUpload$AggrRefresh(ConectaProveedoresClientVariables.getMaxRecords(), model.variables.l_StartIndexVar, callContext);
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

onSort$Action(sortByIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnSort__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnSort");
span.setAttribute("outsystems.function.key", "0393181d-4a64-4400-8f92-25e9efecae5d");
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

datePickerFrom$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerFrom__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerFrom");
span.setAttribute("outsystems.function.key", "3bd20f7a-323c-49e1-bfdb-a5e33d016b0c");
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

datePickerTo$Action(selectedDateIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("DatePickerTo__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "DatePickerTo");
span.setAttribute("outsystems.function.key", "61e65755-9885-4dd9-97fc-024d889bd475");
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

expandFilters$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ExpandFilters__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ExpandFilters");
span.setAttribute("outsystems.function.key", "665a5719-45a5-4b7f-875b-312ad03d3ef1");
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

columnTogglerPassColumn$Action(columnJSONIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("ColumnTogglerPassColumn__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "ColumnTogglerPassColumn");
span.setAttribute("outsystems.function.key", "69aa2c0b-5121-4138-9bf5-a181ab9ac119");
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

setColumnVisiblityOnClick$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("SetColumnVisiblityOnClick__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "SetColumnVisiblityOnClick");
span.setAttribute("outsystems.function.key", "94d79161-c810-4587-bd2c-55f57e4d9150");
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

refreshList$Action(i_IsClearFiltersIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("RefreshList__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "RefreshList");
span.setAttribute("outsystems.function.key", "b36e7ba2-6eb3-46b0-9a8c-09403cd2b475");
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

onDebounce$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnDebounce__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnDebounce");
span.setAttribute("outsystems.function.key", "bdaf2b80-a0b0-4b5d-864b-cd6c27ebf89f");
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

onInitialize$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnInitialize__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnInitialize");
span.setAttribute("outsystems.function.key", "c7661ee9-a57e-40ac-9cd9-be9e409be8a3");
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

getSpecialWorkflowIdsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetSpecialWorkflowIdsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetSpecialWorkflowIdsOnAfterFetch");
span.setAttribute("outsystems.function.key", "c800d367-e2ea-4903-94d7-a04a06e2c2d1");
span.setAttribute("outsystems.function.owner.name", "ConectaProveedores");
span.setAttribute("outsystems.function.owner.key", "588dd3e9-ffc1-4591-bd4e-2f57e6c30828");
span.setAttribute("outsystems.function.type", "CLIENT_SCREEN_ACTION");
}

return OS$Flow.tryFinally(function () {
return controller.safeExecuteClientAction(controller._getSpecialWorkflowIdsOnAfterFetch$Action, callContext);
}, function () {
if(span) {
span.end();
}

});
}, 0);

}

getRequisitionsOnAfterFetch$Action(callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("GetRequisitionsOnAfterFetch__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "GetRequisitionsOnAfterFetch");
span.setAttribute("outsystems.function.key", "f7259f4d-b38a-4f21-a178-d3b9212eb5bd");
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

onPaginationNavigate$Action(newStartIndexIn, callContext) {
var controller = this.controller;
return OS$Logger.startActiveSpan("OnPaginationNavigate__proxy", function (span) {
if(span) {
span.setAttribute("code.function", "OnPaginationNavigate");
span.setAttribute("outsystems.function.key", "f95a56a4-a434-443f-9bfe-c45e69762960");
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
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal$ActionGetSettings", [{
name: "OutSettingsText",
attrName: "outSettingsTextOut",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);

// Client Actions - Variables
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.OnSort$vars", [{
name: "SortBy",
attrName: "sortByInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.DatePickerFrom$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.DatePickerTo$vars", [{
name: "SelectedDate",
attrName: "selectedDateInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Date,
defaultValue: function () {
return OS$DataTypes.DateTime.defaultValue;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.ExpandFilters$vars", [{
name: "IsRefresh",
attrName: "isRefreshVar",
mandatory: false,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.ColumnTogglerPassColumn$vars", [{
name: "ColumnJSON",
attrName: "columnJSONInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Text,
defaultValue: function () {
return "";
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.RefreshList$vars", [{
name: "i_IsClearFilters",
attrName: "i_IsClearFiltersInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Boolean,
defaultValue: function () {
return false;
}
}]);
Controller.registerVariableGroupType("ConectaProveedores.c_Requisitions.Wb_RequisitionUploadInv_Internal.OnPaginationNavigate$vars", [{
name: "NewStartIndex",
attrName: "newStartIndexInLocal",
mandatory: true,
dataType: OS$DataTypes.DataTypes.Integer,
defaultValue: function () {
return 0;
}
}]);

}
export default new OS$Controller.ControllerFactory(Controller, ConectaProveedoresLanguageResources);


