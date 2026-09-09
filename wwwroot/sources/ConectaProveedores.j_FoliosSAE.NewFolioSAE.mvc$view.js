import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Link as OSWidgets$Link, Switch as OSWidgets$Switch, Button as OSWidgets$Button, Checkbox as OSWidgets$Checkbox, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$view.js";
import { SE_steps as ConectaProveedores_staticEntities_steps, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import { DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.NewFolioSAE.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.NewFolioSAE.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Initiative: "FCP",
ChatBotIsEnable: true
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("EglDIvcli0ahO+RPDqS+6g#Value", "Create delivery approval request"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, {
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
uuid: "3",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Status: model.getCachedValue(idService.getId("AxVEodMv+UG5ufjeSTsSgA.Status"), function () {
return (((model.variables.l_StepVar === 1)) ? (ConectaProveedores_staticEntities_steps.active) : (ConectaProveedores_staticEntities_steps.past));
}, function () {
return model.variables.l_StepVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClick$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setStep$Action(1, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "4",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #03d758;"
},
icon: "search",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("HcmOFDexHUS2AMjW9LTGew#Value", "Select Request"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Status: model.getCachedValue(idService.getId("pMCn_2KGPUO8PfgRPnQ84w.Status"), function () {
return (((model.variables.l_StepVar === 2)) ? (ConectaProveedores_staticEntities_steps.active) : ((((model.variables.l_StepVar < 2)) ? (ConectaProveedores_staticEntities_steps.next) : (ConectaProveedores_staticEntities_steps.past))));
}, function () {
return model.variables.l_StepVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClick$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setStep$Action(2, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "6",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #03d758;"
},
icon: "list-ul",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("iQ0XIKVuzk2rSgrr8Pn9DA#Value", "Select Line Positions"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Status: model.getCachedValue(idService.getId("FU0dnzERv0+NV8yQHn4Xmw.Status"), function () {
return (((model.variables.l_StepVar === 3)) ? (ConectaProveedores_staticEntities_steps.active) : (ConectaProveedores_staticEntities_steps.next));
}, function () {
return model.variables.l_StepVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClick$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setStep$Action(3, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "8",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #03d758;"
},
icon: "folder-open",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("gWoDI5OGP0qjAMTFPfddMg#Value", "Create Folio")), createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
value: ((" (" + model.variables.l_OrderIdNumberSelectedVar) + ")"),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar), asPrimitiveValue(model.variables.l_StepVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "12",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.l_StepVar === 1),
_idProps: {
service: idService,
name: "Step1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_OrderNumberFilter",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KLaYRd3d7Um2Wo4GOuiYTw#Value", "Order Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EqZ4O4MfM0WEhZ_9THCnmw#ValueExpression.69519515.1", "Order Number"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_OrderNumberFilterVar, function (value) {
model.variables.l_OrderNumberFilterVar = value;
}),
_idProps: {
service: idService,
name: "Input_OrderNumberFilter"
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
DebounceDelay: 700,
WidgetId: idService.getId("Input_OrderNumberFilter")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "18",
alias: "7"
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Dropdown_CompanyIdFilter",
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("aaA4oGrqvEq+XJF+Yiszrw#Value", "Client"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("k_n5drxixECYrrtd5nN1Eg#ValueExpression.65921.1", "All"),
enabled: true,
labels: function (elem) {
return elem.companyAttr.descriptionAttr;
},
list: model.variables.getCompaniesAggr.listOut,
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshList$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.companyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.l_CompanyIdFilterVar, function (value) {
model.variables.l_CompanyIdFilterVar = value;
}),
_idProps: {
service: idService,
name: "Dropdown_CompanyIdFilter"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCompaniesAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrdersDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrdersDataAct.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uwayTNmDhkmQDtdHMP5pvQ#Value", "There are no orders available at this time as they are pending release by Accounts Payable/Expenses. Please contact the relevant department.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
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
uuid: "25",
alias: "8"
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
source: model.variables.getOrdersDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "OrdersAvailableTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6h7cCUq4wESLm6q9ObArGQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Company.Description",
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("OVc4D2SEDUWqIIXQxq34KQ#Value", "Client"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "OrderMain.OrderNumber",
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("c3jEQ7qtsEW7+eWc_+e50g#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderMain.TotalAmount",
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pivpQ8kcNUuucmKbQ77T6g#Value", "Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency.Name",
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("b7KTitOd_EiqQkNchBqN_A#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "OrderMain.OrderDate",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("flq9peiAv0qIGYL7boummg#Value", "Order Date")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.selectOrder$Action(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr, model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
title: (("- " + model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr) + " - ")
},
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).companyAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).quantidadeTotalAttr.valueAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).quantidadeEntregadaAttr.valueAttr)]
}, $if(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).quantidadeEntregadaAttr.valueAttr.gte(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).quantidadeTotalAttr.valueAttr), false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: "paid",
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("sTeIyEjftEO8SgLOYuciqg#Value.1316322684.1", "Not Available")
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
uuid: "39",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ZUt9Vyvd_E+pTa3TvB_xtw#Value.1270065833.1", "Available"),
i_Class: "payments"
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
uuid: "40",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5J2mw7WCnE+XvC0gacOeMg.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr, "", 2, ".", ",");
}, function () {
return model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("3_Zi1iKoV0GuWRoXS87Qcg.Value"), function () {
return ((model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.dateToText(model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr)));
}, function () {
return model.variables.getOrdersDataAct.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderDateAttr;
}),
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr)
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
TotalCount: OS$BuiltinFunctions.integerToLongInteger(model.variables.getOrdersDataAct.countOut),
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrdersDataAct.dataFetchStatusAttr),
StartIndex: model.variables.startIndexVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "49",
alias: "11"
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
return controller.paginationOnNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "50",
alias: "12"
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
uuid: "51"
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
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.l_StepVar === 2),
_idProps: {
service: idService,
name: "Step2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "margin-left-base",
targetWidget: "Switch_IsExcludeFinalDelivery",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WcI_xJtY5E2fM4qoypiGOg#Value", "Exclude Final Delivery"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.filtersChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsExcludeFinalDeliveryVar, function (value) {
model.variables.l_IsExcludeFinalDeliveryVar = value;
}),
_idProps: {
service: idService,
name: "Switch_IsExcludeFinalDelivery"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically margin-left-m",
visible: true,
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "margin-left-base",
targetWidget: "Switch_ShowOnlyAvailable",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NJxpmPbpIku4QeACVdYfug#Value", "Only available"))), createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.filtersChange$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_ShowOnlyAvailableVar, function (value) {
model.variables.l_ShowOnlyAvailableVar = value;
}),
_idProps: {
service: idService,
name: "Switch_ShowOnlyAvailable"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
style: "margin-bottom-s text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (model.variables.isSelectedVar || model.variables.l_IsSelectAllVar),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.addToRequestOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SwImedELtk2rvSal8cMiNw#Value", "Add to request")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainItemsDataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getOrderMainItemsDataAct.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xZC6Lp4Tv0+RYZGnRm2YeQ#Value", "No records to show...")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.horizontal
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
uuid: "67",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getOrderMainItemsDataAct.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "OrderMainItemsTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%; text-align: center;"
},
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.variables.l_IsShowSelectAllVar,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkboxIsSelectAllOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsSelectAllVar, function (value) {
model.variables.l_IsSelectAllVar = value;
}),
_idProps: {
service: idService,
name: "CheckboxIsSelectAll"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("q3CCdpnSV02raPjegLXidw#Value", "Is Final Delivered"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HD6yL_HAl02jbKWHW_vWSA#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("S5S7CqHmgUOTz9AJJ3B3+g#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("eSVqhdyZVk+oWncEUM7paQ#Value", "Material Code"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PHKFl7IDxkim+PsM_tM+mQ#Value", "Material Description"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0OD+PrQ3dECDmu9u1BU1Rg#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SzZk3CLt8Ea7BvdXs4hV5g#Value", "Quantity Delivered"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "QuantityAvailable",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ST5vbyBkqEeXzc3gsFOZ_Q#Value", "Quantity Available"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("4wKiEvwyfUa6dTRh6O7g6Q#Value", "Order Unit Of Measure"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("M0s3pIL5bUCeHjBuszatHg#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+mgz5RTJrky+cD1ughtUxg#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3T_1658jf0u3MHZtEdLodg#Value", "Vat Rate"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yS1egs1ZSE2n4n8TyY_8nA#Value", "Total"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("venTYJ7dt0ad4Z5QiRcrtw#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2sEai6y5WE+ONV6PcF+Dlg#Value", "Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).selectAttr)]
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: (((model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)) && (model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr === false)) && (model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr === false)) && (model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr === false)),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.checkboxIsSelectedOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).selectAttr, function (value) {
model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).selectAttr = value;
}),
_idProps: {
service: idService,
name: "CheckboxIsSelected"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr)]
}, $if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isBlockedAttr, false, this, function () {
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
uuid: "92",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "lock",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("D0_FeuUs3UC+SWyJRET_rw#Value", "Locked"))];
})
},
_dependencies: []
})];
}, function () {
return [$if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isDeletedAttr, false, this, function () {
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
uuid: "94",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "trash-o",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("jil23x41vUueSWpL_GwDXQ#Value", "Deleted"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isMultipleImputationAttr)]
}, $if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isMultipleImputationAttr, false, this, function () {
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
uuid: "97",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_mosaico.svg"),
style: "margin-right-s",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return ["Múltiple imputación"];
})
},
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr)]
}, createElement(OSWidgets$Icon, {
icon: "check",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).isFinalDeliveredAttr,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr),
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr),
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("PS3GT1gOHUiUnA_jUCgUVg.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr)]
}, createElement(OSWidgets$Expression, {
value: (OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr.times(OS$BuiltinFunctions.integerToDecimal(100))) + "%"),
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("sE2q_F4oCUy1kJdKZmt1YA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).assigmentCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).assigmentCodeAttr,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr)]
}, $if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)), false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: "approved",
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Fylu62yat0KKK+6onCfm6g#Value.1761640548.1", "Delivered")
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
uuid: "133",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [$if(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)), false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: "inapproval",
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("zZXk3E2k6kKaPKM0OF5YBg#Value.-196070569.1", "Not delivered")
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
uuid: "134",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: "saved",
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("y4LXrx41SkKWyDvv8b530w#Value.315908229.1", "Partial delivered")
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
uuid: "135",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut)]
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: (model.variables.l_StepVar === 3),
_idProps: {
service: idService,
name: "Step3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getApplicantTypeDataAct.approvalProcessTypeIdOut === ConectaProveedores_staticEntities_approvalProcessType.construction), false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
LocalSelectedLines: model.variables.localSelectedLinesVar,
i_OrderId: model.variables.l_OrderIdSelectedVar,
ApplicantId: model.variables.getApplicantTypeDataAct.applicantIdOut,
_applicantIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApplicantTypeDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
goBackToStep2$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setStep$Action(2, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "138",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
LocalSelectedLines: model.variables.localSelectedLinesVar,
i_OrderId: model.variables.l_OrderIdSelectedVar,
AprovalProcessTypeId: model.variables.getApplicantTypeDataAct.approvalProcessTypeIdOut,
_aprovalProcessTypeIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApplicantTypeDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
goBackToStep2$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setStep$Action(2, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "139",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_OrderIdSelectedVar), asPrimitiveValue(model.variables.localSelectedLinesVar), asPrimitiveValue(model.variables.getApplicantTypeDataAct.applicantIdOut), asPrimitiveValue(model.variables.getApplicantTypeDataAct.approvalProcessTypeIdOut), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.isSelectedVar), asPrimitiveValue(model.variables.l_ShowOnlyAvailableVar), asPrimitiveValue(model.variables.l_IsExcludeFinalDeliveryVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.getOrdersDataAct.countOut), asPrimitiveValue(model.variables.getOrdersDataAct.listOut), asPrimitiveValue(model.variables.getOrdersDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getApplicantTypeDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrdersDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.l_CompanyIdFilterVar), asPrimitiveValue(model.variables.l_OrderNumberFilterVar), asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar), asPrimitiveValue(model.variables.l_StepVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "NewFolioSAE",
functionKey: "a9b4d603-6a5e-4156-8adf-2456b57f8082",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.NewFolioSAE",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioCreateConstruction_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioCreate_mvc_view];
};


return ELEM;
};

export default componentFactory()
