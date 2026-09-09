import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Text as OSWidgets$Text, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, Form as OSWidgets$Form, TextArea as OSWidgets$TextArea, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType } from "./ConectaProveedores.staticEntities.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SearchUserDropdown.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SearchApprovalProcessDropdown.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_ReassignFolioFromRejectPopup.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "2",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dq0P4sNcp0uryMczPbFNfw#Value", "Reassign Folio SAEC"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: (!(model.variables.l_IsExecutingVar)),
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsExecutingVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-base ",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal,
OptionalConfigs: model.getCachedValue(idService.getId("C5D+eeu5qUaqEPeZli5E4A.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.justifyHeadersAttr = true;
return rec;
}();
}),
StartingTab: 0
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onTabChange$Action: function (tabsIdIn, activeTabIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.tabsOnTabChange$Action(activeTabIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "8",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "9",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("V9nyIwvIB0OwHnPL3DtnCQ#Value", "First Approver"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "11",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("lU4qwI3iBEaBFZhUKoe1kw#Value", "Flow"))],
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "13",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsMandatory: true,
i_IsDisable: false,
i_IsValid: model.variables.l_IsValidSearchUserDropdownVar,
i_UserId: model.variables.l_SelectedUserVar,
i_IsFilter: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (userIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SearchUserDropdownRefresh$Action(userIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "15",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SelectedUserVar), asPrimitiveValue(model.variables.l_IsValidSearchUserDropdownVar)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "16",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("JyphmXscVEWOli27P2vyYg.Style"), function () {
return ("os-boxlabel " + ((((model.variables.l_ApprovalProcessTypeSelectedVar === ConectaProveedores_staticEntities_approvalProcessType.alternative) || (model.variables.l_ApprovalProcessTypeSelectedVar === OS$BuiltinFunctions.nullIdentifier()))) ? (" ") : (" margin-bottom-m ")));
}, function () {
return model.variables.l_ApprovalProcessTypeSelectedVar;
}),
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_ApprovalProcessTypeSelected",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zRJ1SnKuM0aVnJP3LyvrzA#Value", "Workflow type"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7VvdeptMB0mJ_+2nAcRXeg#ValueExpression.1835588343.1", "Select workflow type"),
enabled: true,
labels: function (elem) {
return elem.approvalProcessTypeAttr.label_ESAttr;
},
list: model.variables.getApprovalProcessTypesAggr.listOut,
mandatory: false,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_ApprovalProcessTypeSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "dropdown",
values: function (elem) {
return elem.approvalProcessTypeAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.l_ApprovalProcessTypeSelectedVar, function (value) {
model.variables.l_ApprovalProcessTypeSelectedVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_ApprovalProcessTypeSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovalProcessTypesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: ((model.variables.l_ApprovalProcessTypeSelectedVar === ConectaProveedores_staticEntities_approvalProcessType.construction) || (model.variables.l_ApprovalProcessTypeSelectedVar === ConectaProveedores_staticEntities_approvalProcessType.special)),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsDisable: false,
i_ApprovalProcessId: model.variables.l_SelectedApprovalProcessVar,
i_IsMandatory: true,
i_IsFilter: true,
i_IsValid: model.variables.l_IsValidSearchApprovalProcessDropdownVar,
i_ApprovalProcessTypeId: model.variables.l_ApprovalProcessTypeSelectedVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function (approvalProcessIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SearchApprovalProcessDropdownRefresh$Action(approvalProcessIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "21",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsValidSearchApprovalProcessDropdownVar), asPrimitiveValue(model.variables.l_SelectedApprovalProcessVar), asPrimitiveValue(model.variables.getApprovalProcessTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcessTypesAggr.listOut), asPrimitiveValue(model.variables.l_ApprovalProcessTypeSelectedVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsValidSearchApprovalProcessDropdownVar), asPrimitiveValue(model.variables.l_SelectedApprovalProcessVar), asPrimitiveValue(model.variables.getApprovalProcessTypesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovalProcessTypesAggr.listOut), asPrimitiveValue(model.variables.l_ApprovalProcessTypeSelectedVar), asPrimitiveValue(model.variables.l_SelectedUserVar), asPrimitiveValue(model.variables.l_IsValidSearchUserDropdownVar)]
})), createElement(OSWidgets$Form, {
_validationProps: {
validationService: validationService
},
gridProperties: {
classes: "OSFillParent"
},
style: "form",
_idProps: {
service: idService,
name: "Form"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory ",
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("87SnLVMDuUel3RC7s+svQw#Value", "Motive"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: (!(model.variables.l_IsExecutingVar)),
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
maxLength: 500,
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_MotiveVar, function (value) {
model.variables.l_MotiveVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_Motive"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsExecutingVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(false, controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("CkVsznzq30SQBrngf7VNHg#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: (!(model.variables.l_IsExecutingVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
_this.validateWidget(idService.getId("Form"));
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.reassignOnClick$Action(controller.callContext(eventHandlerContext));
});

;
},
style: "btn btn-approve",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xu2EwKwdF0Su6lz5ncvH5Q#Value", "Reassign")))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_ReassignFolioFromRejectPopup",
functionKey: "eb02934b-b677-4c1d-be9d-c0aa90c54ee3",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_ReassignFolioFromRejectPopup",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SearchUserDropdown_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SearchApprovalProcessDropdown_mvc_view];
};


return ELEM;
};

export default componentFactory()
