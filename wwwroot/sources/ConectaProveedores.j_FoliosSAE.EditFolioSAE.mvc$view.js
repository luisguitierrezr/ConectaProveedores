import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Popup as OSWidgets$Popup, Container as OSWidgets$Container, Button as OSWidgets$Button, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, Checkbox as OSWidgets$Checkbox, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardV2.mvc$view.js";
import { SE_steps as ConectaProveedores_staticEntities_steps, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType, SE_folioStatus as ConectaProveedores_staticEntities_folioStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view from "./OutSystemsUI.Navigation.DEPRECATED_WizardItemV2.mvc$view.js";
import { Model as OS$Model, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEdit.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.EditFolioSAE.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.EditFolioSAE.mvc$controller.js";
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
text: [$text(getTranslation("XMVe4Fcu8kezdWxl2uYUBg#Value", "Create delivery approval request"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Popup, {
showPopup: model.variables.showPopupVar,
style: "popup-dialog",
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, "¿Al volver a la selección de los ítems del pedido, perderá la configuración de los valores iniciales; desea continuar?", createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancelOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VLZ0wqU8uUuRQDjHFUZTBg#Value", "Cancel"))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.yesOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ltWfRU6cB0O697RTQcuVCg#Value", "Yes")))))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "6"
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
uuid: "7",
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
Status: model.getCachedValue(idService.getId("OGRCZqOn4kKbg3cH+noSoQ.Status"), function () {
return (((model.variables.l_StepVar === 1)) ? (ConectaProveedores_staticEntities_steps.active) : ((((model.variables.l_StepVar < 1)) ? (ConectaProveedores_staticEntities_steps.next) : (ConectaProveedores_staticEntities_steps.past))));
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
uuid: "8",
alias: "3"
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("jrXE+8pa_kqjB05TohMkcQ#Value", "Select Line Positions"))];
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
Status: model.getCachedValue(idService.getId("52Rb2BJZAEO9_jZMHna4BA.Status"), function () {
return (((model.variables.l_StepVar === 2)) ? (ConectaProveedores_staticEntities_steps.active) : (ConectaProveedores_staticEntities_steps.next));
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
uuid: "10",
alias: "4"
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
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
label: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("T9u60Sqf+Uuf2RImlnnP6Q#Value", "Create Folio")), createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
value: ((" (" + model.variables.l_OrderIdNumberSelectedVar) + ")"),
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(model.variables.getSettingsDataAct.o_IsActiveDEV_NumeroDeFolioVisibleOut, false, this, function () {
return [createElement(OSWidgets$Expression, {
gridProperties: {
marginLeft: "0"
},
style: "font-semi-bold",
value: ((" (" + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr) + ")"),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_NumeroDeFolioVisibleOut), asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_NumeroDeFolioVisibleOut), asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar), asPrimitiveValue(model.variables.l_StepVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "14"
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
uuid: "15",
alias: "5"
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
extendedProperties: {
style: "text-align: right;"
},
style: "margin-bottom-s",
visible: true,
_idProps: {
service: idService,
uuid: "17"
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
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("y4v8eVpJxk+BBavvr7a4zg#Value", "Add to request")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "19"
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("YcAiWNoGc0yC3rIb_PvIwQ#Value", "No records to show...")))];
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
uuid: "21"
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
uuid: "22",
alias: "6"
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.variables.l_IsShowSelectAllVar,
_idProps: {
service: idService,
uuid: "25"
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("yLTn9tuLi0qCRDtbnkek3Q#Value", "Is Final Delivered"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("1BfbdjVsfkGnwXuFUFL8_A#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("iJiB1HhhiUmAtSHGkzvEBQ#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("qWavRs_r5U6TB6GibJKELw#Value", "Material Code"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("8mOseaaT10qJMXb0MbEQ6g#Value", "Material Description"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SlS5lQYWhUGPnIl80_3CLg#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("GOvXAron20et8hYQV9HMfQ#Value", "Quantity Delivered"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "QuantityAvailable",
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JBOJsKO0O0axgGlI28oBzA#Value", "Quantity Available"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xCSAOj8dBEiSoxFgTF6aGw#Value", "Order Unit Of Measure"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6ygV1RQiqU+o8neLrCKK1w#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZlsEfGjSA0ay2K7WRifwtQ#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("CVsQxppfo0+0WIpPozPq8w#Value", "Vat Rate"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wAc9YmZdv02k4X3RVrU1+Q#Value", "Total"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("bjhWGyx+x06v1SeAHVkYeA#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("V_AO2Mj4AUWDr42D+nrPXw#Value", "Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "43"
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
uuid: "45"
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
uuid: "46",
alias: "7"
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
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("NrWrwKBUQUaCLd0FYyw_ZQ#Value", "Locked"))];
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
uuid: "48",
alias: "8"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("JRr+FYcfPEWAybrX0xqgZQ#Value", "Deleted"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
})), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "50"
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
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialCodeAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).materialDescriptionAttr,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityDeliveredAttr),
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).quantityAvailableAttr),
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).orderUnitOfMeasureAttr,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("GKvQ5nT1jE+C9J7Xb5+x8A.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr)]
}, createElement(OSWidgets$Expression, {
value: (OS$BuiltinFunctions.decimalToText(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).vATRateAttr.times(OS$BuiltinFunctions.integerToDecimal(100))) + "%"),
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("aY1jN3lt7Ea_pyDW7d6Y2g.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).assigmentCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getOrderMainItemsDataAct.listOut.getCurrent(callContext.iterationContext).assigmentCodeAttr,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "83"
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
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("0DDgs0On0UmV_wNbNlnbrg#Value.1761640548.1", "Delivered")
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
uuid: "84",
alias: "9"
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
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RTrZCWU5iEW0n2VyvBbdNQ#Value.-196070569.1", "Not delivered")
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
alias: "10"
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
i_Text: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("a8uNJVuOyU+xNWsp1o0TWA#Value.315908229.1", "Partial delivered"),
i_Class: "saved"
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
uuid: "86",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}))];
}, callContext, idService, "1_0")
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
uuid: "87"
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
}, $if(!(model.variables.l_OrderIdSelectedVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [$if((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr === ConectaProveedores_staticEntities_approvalProcessType.construction), false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.l_OrderIdSelectedVar,
FolioId: model.variables.folioIdIn,
i_LocalSelectedLines: model.variables.localSelectedLinesVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
goBackToStep2$Action: function () {
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
uuid: "89",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [$if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice) && model.variables.getSettingsDataAct.o_IsActiveDEV_HU13046Out), false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.l_OrderIdSelectedVar,
FolioId: model.variables.folioIdIn,
i_LocalSelectedLines: model.variables.localSelectedLinesVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
goBackToStep1$Action: function () {
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
uuid: "90",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_LocalSelectedLines: model.variables.localSelectedLinesVar,
i_OrderId: model.variables.l_OrderIdSelectedVar,
FolioId: model.variables.folioIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
goBackToStep1$Action: function () {
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
uuid: "91",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
})];
}, function () {
return [];
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar), asPrimitiveValue(model.variables.folioIdIn), asPrimitiveValue(model.variables.l_OrderIdSelectedVar), asPrimitiveValue(model.variables.l_IsShowSelectAllVar), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.listOut), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.l_IsSelectAllVar), asPrimitiveValue(model.variables.isSelectedVar), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.approvalProcessTypeIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getOrderMainItemsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13046Out), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_NumeroDeFolioVisibleOut), asPrimitiveValue(model.variables.l_OrderIdNumberSelectedVar), asPrimitiveValue(model.variables.l_StepVar), asPrimitiveValue(model.variables.showPopupVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "EditFolioSAE",
functionKey: "19d8c520-1d3a-425e-9d30-86bc0b3e691f",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.EditFolioSAE",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardV2_mvc_view, OutSystemsUI_Navigation_DEPRECATED_WizardItemV2_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioEditConstruction_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioEditIncorrectInvoice_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioEdit_mvc_view];
};


return ELEM;
};

export default componentFactory()
