import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Button as OSWidgets$Button, Label as OSWidgets$Label, Dropdown as OSWidgets$Dropdown, Input as OSWidgets$Input, Link as OSWidgets$Link, ButtonGroup as OSWidgets$ButtonGroup, ButtonGroupItem as OSWidgets$ButtonGroupItem, Text as OSWidgets$Text, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Expression as OSWidgets$Expression, RowCell as OSWidgets$RowCell, Icon as OSWidgets$Icon, Image as OSWidgets$Image, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { BuiltinFunctions as OS$BuiltinFunctions, Model as OS$Model, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Navigation as OS$Navigation, Transitions as OS$Transitions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_datePickerTimeFormat as ConectaProveedores_staticEntities_datePickerTimeFormat, SE_origin as ConectaProveedores_staticEntities_origin } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_GetAuditList_mvc_view from "./ConectaProveedores.y_Logs.Wb_GetAuditList.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view from "./ConectaProveedores.y_Utils.Wb_ConfirmPopup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getOrderMainDataOnInputDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
name: "body"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfigDetails", {
ConfigId: OS$DataConversion.ServerDataConverter.to(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("cZVTBHDaTEWvbmryp99nag#Value", "Add New"))))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: " margin-bottom-m",
visible: true,
_idProps: {
service: idService,
name: "FiltersContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((((model.variables.l_TabNumberVar) !== (0)) && ((model.variables.l_TabNumberVar) !== (2))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3"
},
style: "os-boxlabel margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QGZKQofxo0u3JcYQc9TrPQ#Value", "Division"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("MT+q8TIjgE6MhWu2cdW_sA#ValueExpression.429364429.1", "Division"),
enabled: (model.variables.getOrderMainDataOnInputDataAct.outFiltersOut.divisionAttr === ""),
labels: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
list: model.variables.getRegionsAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.regionAttr.divisionFIAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderDistributionConfig_Division(), function (value) {
ConectaProveedoresClientVariables.setOrderDistributionConfig_Division(value);
}),
_idProps: {
service: idService,
name: "Dropdown1"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainDataOnInputDataAct.dataFetchStatusAttr),
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRegionsAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("q2RJHWzyckO9hWGflAvSGA#Value", "Applicant"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("y+ouvAC5J0CWwIXYziISOw#ValueExpression.-86032670.1", "Applicant"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderDistributionConfig_Applicant(), function (value) {
ConectaProveedoresClientVariables.setOrderDistributionConfig_Applicant(value);
}),
_idProps: {
service: idService,
name: "Input_Applicant"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Applicant")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "11",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LX4bxRxmqUChhubGWq9JPA#Value", "Applicant Description"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DSDcbE_UNkSBkClOKsD7+w#ValueExpression.-495856738.1", "Applicant Description"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderDistributionConfig_ApplicantDescription(), function (value) {
ConectaProveedoresClientVariables.setOrderDistributionConfig_ApplicantDescription(value);
}),
_idProps: {
service: idService,
name: "Input_ApplicantDesc"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_ApplicantDesc"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "15",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SZRqn4L8LU+zj62fwwf6Yg#Value", "Direction"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aFH2nwQusU2PT2blNBro8Q#ValueExpression.1041377119.1", "Direction"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderDistributionConfig_Direction(), function (value) {
ConectaProveedoresClientVariables.setOrderDistributionConfig_Direction(value);
}),
_idProps: {
service: idService,
name: "Input_Direction"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Direction")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "19",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IweBDqK2v02Gf+c8_AMfqA#Value", "Role"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("s4oj4ho3kk+IqCfSddGSrQ#ValueExpression.2552982.1", "Role"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, ConectaProveedoresClientVariables.getOrderDistributionConfig_Role(), function (value) {
ConectaProveedoresClientVariables.setOrderDistributionConfig_Role(value);
}),
_idProps: {
service: idService,
name: "Input_Role"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_Role")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(false, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "23",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jcF92UwwckeRtEe9J9QhkQ#Value", "Clear Filters"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: (auto);"
},
style: "",
visible: true,
_idProps: {
service: idService,
name: "TabsContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || (!(model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && model.variables.l_IsOrderRejectedVar)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: model.getCachedValue(idService.getId("pjypaK+VlEqPWJ3FJeKl1g.Visible"), function () {
return (!(model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) || model.variables.l_IsOrderRejectedVar);
}, function () {
return model.variables.i_OrderIdIn;
}, function () {
return model.variables.l_IsOrderRejectedVar;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus)
}, createElement(OSWidgets$ButtonGroup, {
_validationProps: {
validationService: validationService
},
enabled: true,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.buttonGroupOnChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "button-group",
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.l_TabNumberVar, function (value) {
model.variables.l_TabNumberVar = value;
}),
_idProps: {
service: idService,
name: "ButtonGroup1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$ButtonGroupItem, {
enabled: true,
style: "button-group-item",
value: 0,
visible: true,
_idProps: {
service: idService,
name: "ButtonGroupItem1"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dFFUaVwK8k25Gh95uj+Wtg#Value", "Corporate"))), createElement(OSWidgets$ButtonGroupItem, {
enabled: true,
style: "button-group-item",
value: 1,
visible: true,
_idProps: {
service: idService,
name: "ButtonGroupItem2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IQTLpw2puEu1aO+CLoFfsg#Value", "Regions 1 to 8"))), createElement(OSWidgets$ButtonGroupItem, {
enabled: true,
style: "button-group-item",
value: 2,
visible: true,
_idProps: {
service: idService,
name: "ButtonGroupItem3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_EfqwOWsoUCFHDqJ+Rx1LQ#Value", "Region 9")))))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "",
visible: true,
_idProps: {
service: idService,
name: "ListContainer"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderDistributionConfigAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderDistributionConfigAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "text-align-center",
text: [$text(getTranslation("+Q4C6tm1Z0CU+cLQjH7FBw#Value", "There are no entries at this time."))],
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
Height: model.getCachedValue(idService.getId("qdJGR7gD_UqVUAgt5aZDlg.Height"), function () {
return ((model.variables.i_InPopupIn) ? ("320px") : (""));
}, function () {
return model.variables.i_InPopupIn;
}),
_heightInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InPopupInDataFetchStatus),
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
ExtendedClass: model.getCachedValue(idService.getId("qdJGR7gD_UqVUAgt5aZDlg.ExtendedClass"), function () {
return ((model.variables.i_InPopupIn) ? ("VerticalScroll") : (""));
}, function () {
return model.variables.i_InPopupIn;
}),
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_InPopupInDataFetchStatus)
},
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
uuid: "35",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getOrderDistributionConfigAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "RequestDistributionConfigsTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("qb0QeYjLF0S_nhqRB6cMqw.class"), function () {
return (((model.variables.l_TabNumberVar === 1)) ? ("") : ("hidden"));
}, function () {
return model.variables.l_TabNumberVar;
})
},
style: "donotshow",
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JXJX4I4MykiUJrk8AdpEfw#ValueExpression.429364429.1", "Division"),
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$HeaderCell, {
style: "donotshow",
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("CqkeM7XbV0WBEAHkLLWi0g#ValueExpression.-86032670.1", "Applicant"),
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("F3QDxaJ5Dk2zb5BYWSU+tw#Value", "Direction"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("The4Bwqh50KhX0NNJR_5hQ#Value", "Position first contact"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DDxpiOjoYUWeU0cbtF6UDQ#Value", "Position second contact"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WOLFAiQT5UGjj7BSNGcqAA#Value", "Position first approver"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jSXCbFQaSU2uT6brEdm4eQ#Value", "Position second approver"))), createElement(OSWidgets$HeaderCell, {
style: "donotshow",
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
extendedProperties: {
className: model.getCachedValue(idService.getId("4kio0KvG9ECA3iKNJrMxKg.class"), function () {
return (((model.variables.l_TabNumberVar === 1)) ? ("tight-text normal-text") : ("hidden"));
}, function () {
return model.variables.l_TabNumberVar;
})
},
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantAttr,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "tiny-text margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 20,
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.applicantDescriptionAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
},
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
uuid: "53",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).telcelDirectionAttr.nameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 100,
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).telcelDirectionAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
},
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
uuid: "55",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstContactEntraRoleAttr.roleNameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 100,
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstContactEntraRoleAttr.roleNameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
},
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
uuid: "57",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondContactEntraRoleAttr.roleNameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondContactEntraRoleAttr.roleNameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr),
i_NChar: 100
},
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
uuid: "59",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstApproverEntraRoleAttr.roleNameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstApproverEntraRoleAttr.roleNameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr),
i_NChar: 100
},
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
uuid: "61",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "tight-text normal-text",
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondApproverEntraRoleAttr.roleNameAttr)]
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondApproverEntraRoleAttr.roleNameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr),
i_NChar: 100
},
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
uuid: "63",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondContactEntraRoleAttr.idAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstContactEntraRoleAttr.idAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.i_OrderIdIn)]
}, $if(model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrderDistributionConfigDetails", {
ConfigId: OS$DataConversion.ServerDataConverter.to(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "pencil-square-o",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if((model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).firstContactEntraRoleAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).secondContactEntraRoleAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "67",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_alerta.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("XCr1ooWgYUCp6zp2hKtGvg#Value", "This distribution line needs attention please contact your administrator"))];
})
},
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupConfirmation$Action(model.variables.getOrderDistributionConfigAggr.listOut.getCurrent(callContext.iterationContext).orderDistributionConfigAttr.idAttr, model.variables.i_OrderIdIn, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
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
uuid: "70",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_agregar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("bT9T6RDxTE6sZFfrWakE8g#Value", "Select Distribution"))];
})
},
_dependencies: []
}))];
})];
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_TabNumberVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.l_TabNumberVar), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDistributionConfigAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.l_StartIndexVar,
TotalCount: model.variables.getOrderDistributionConfigAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDistributionConfigAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "72",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "73",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
})];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
name: "loader"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), $if(model.variables.i_InPopupIn, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showAudit_OnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "padding-base",
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("d_Py2n98YkCsXx9jL9zcUg.Value"), function () {
return ((model.variables.l_ShowAuditVar) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kjhFrsF3tUizX_7wSGCW8w#ValueExpression.837418877.1", "Hide Audit")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kjhFrsF3tUizX_7wSGCW8w#ValueExpression.1269466360.1", "Show Audit")));
}, function () {
return model.variables.l_ShowAuditVar;
}),
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}))), $if(model.variables.l_ShowAuditVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "AuditFilters"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TimeFormat: ConectaProveedores_staticEntities_datePickerTimeFormat.time24hFormat,
ShowTodayButton: true,
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnSelected$Action(datePickerIdIn, selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerPeriodInit",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodInit"), controller.callContext(eventHandlerContext));

;
}
},
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oD9oP5L3fUmHC7S6ZObbtA#Value", "Period Init"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
},
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
uuid: "85",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "padding: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodInit"), controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
style: "margin-top: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodInit"), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Datetime*/ 5,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("kp+3UEAtCUWUeV2kLRUhgg#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.DateTime, model.variables.l_AuditInitialDateTimeVar, function (value) {
model.variables.l_AuditInitialDateTimeVar = value;
}),
_idProps: {
service: idService,
name: "Input_PeriodInit"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_AuditInitialDateTimeVar)]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_AuditInitialDateTimeVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
style: "margin-2percent",
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DateFormat: "DD/MM/YYYY",
TimeFormat: ConectaProveedores_staticEntities_datePickerTimeFormat.time24hFormat,
ShowTodayButton: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnSelected$Action(datePickerIdIn, selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerPeriodEnd",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodEnd"), controller.callContext(eventHandlerContext));

;
}
},
style: "os-boxlabel cursorpointer",
visible: true,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("DAckTd41skWYjUdeJY0yfw#Value", "Period End"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
},
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
uuid: "93",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "padding: 10px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodEnd"), controller.callContext(eventHandlerContext));

;
}
},
extendedProperties: {
style: "margin-top: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerOnClick$Action(idService.getId("DatePickerPeriodEnd"), controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Datetime*/ 5,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("lwty4Pqi2kiju1QjZA0iPQ#ValueExpression.65921.1", "All"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.DateTime, model.variables.l_AuditFinalDateTimeVar, function (value) {
model.variables.l_AuditFinalDateTimeVar = value;
}),
_idProps: {
service: idService,
name: "Input_PeriodEnd"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_AuditFinalDateTimeVar)]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_AuditFinalDateTimeVar)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Logs_Wb_GetAuditList_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ShowErrors: false,
OriginId: ConectaProveedores_staticEntities_origin.orderDistributionConfig,
PeriodEnd: model.variables.l_AuditFinalDateTimeVar,
MaxRecords: 50,
PeriodInit: model.variables.l_AuditInitialDateTimeVar
},
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
uuid: "98",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "paddin: var(--space-base);"
},
showPopup: model.variables.isOpenPopupConfirmationVar,
style: "popup-dialog1 card",
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ConfirmationText: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ow2V0xFEcEutV9oWwFJOwQ#Value.-689525629.1", "Are you sure you want to assign this distribution line to this order?"),
i_PopupTitle: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VmDk7Nglg06MweNxj_WBog#Value.682071221.1", "Request Distribution")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupConfirmation$Action(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()), controller.callContext(eventHandlerContext));

;
},
confirm$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmOnClick$Action(model.variables.requestDistributionConfigId_ToSaveVar, model.variables.orderMainId_ToSaveVar, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "100",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
name: "loader2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderDistributionConfig",
functionKey: "3c2c6813-ce13-4fa8-9549-3b44de40347c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "h_OrderDistributionConfig.Wb_OrderDistributionConfig",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.h_OrderDistributionConfig.Wb_OrderDistributionConfig.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, ConectaProveedores_y_Logs_Wb_GetAuditList_mvc_view, ConectaProveedores_y_Utils_Wb_ConfirmPopup_mvc_view];
};


return ELEM;
};

export default componentFactory()
