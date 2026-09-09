import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, GenericTypeCache as OS$GenericTypeCache, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Text as OSWidgets$Text, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image, Popup as OSWidgets$Popup, Link as OSWidgets$Link } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUpload.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if((model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.evidenceRequested), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #eb9100;"
},
icon: "exclamation-triangle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
style: "heading6",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioCommentsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioCommentAttr.messageAttr,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioCommentsByFolioIdAggr.dataFetchStatusAttr)
})))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-columns-cards",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns3_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
TabletBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "7",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "Header2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("04li0sr90kCdmjLMrRKEPg#Value", "Comments and Observations"))],
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 1000,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("NDD9z5+4zEGxfE0fp3jrSA#ValueExpression.1497638985.1", "Comments or Observations. If you have a CREDIT NOTE, please provide: Number and amount; otherwise, indicate N/A."),
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.commentsVar, function (value) {
model.variables.commentsVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_Comments"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 12px; text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("BTSBlm09K067fx2xAp9Wrg.Value"), function () {
return ((OS$BuiltinFunctions.length(model.variables.commentsVar)).toString() + "/1000");
}, function () {
return model.variables.commentsVar;
}),
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioObservationsByFolioIdAggr.listOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: #787b7e; font-size: 10px; text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr),
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr)]
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "22"
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
OptionalConfigs: model.getCachedValue(idService.getId("ZyCo70xJaESWYOVHVgCrNw.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = false;
rec.justifyHeadersAttr = true;
return rec;
}();
}),
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal
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
uuid: "23",
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
uuid: "24",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("j3cMM56og0ekE1jPj1NMmg#Value", "Summary"))];
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
uuid: "25",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("zMtyYryLUUW7gV3p6qcpMQ#Value", "Partial Delivery"))];
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
uuid: "26",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount",
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("H9_rBRIHXkaAKucuc85n6Q#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.totalAmountAttr, function (value) {
model.variables.l_SummaryRecVar.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
RightAlign: false,
InputId: idService.getId("Input_TotalAmount"),
UseNumericInput: true,
DecimalSeparator: ".",
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
AlwaysShowDecimalDigits: true
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
uuid: "31",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount2",
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3AQPCVlGoke_U0pJm7A48w#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.amountDeliveredAttr, function (value) {
model.variables.l_SummaryRecVar.amountDeliveredAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
PrefixText: "",
UseNumericInput: true,
RightAlign: false,
InputId: idService.getId("Input_TotalAmount2")
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
uuid: "36",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount3",
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4b4ftBtdak2ckmUCibmJiw#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.0",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.percentageDeliveredAttr, function (value) {
model.variables.l_SummaryRecVar.percentageDeliveredAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount3"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: "%",
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
UseNumericInput: true,
GroupSeparator: ",",
InputId: idService.getId("Input_TotalAmount3"),
SuffixText: "",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
PrefixText: ""
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
uuid: "41",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount4",
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("R8b9fYWWREq8ZmO5NgM9TQ#Value", "Amount left"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.amountLeftAttr, function (value) {
model.variables.l_SummaryRecVar.amountLeftAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount4"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InputId: idService.getId("Input_TotalAmount4"),
GroupSeparator: ",",
UseNumericInput: true,
RightAlign: false,
PrefixText: "",
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: "."
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
uuid: "46",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_InvoicingAmount",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IRQQ8jV__0CWw9Ckv_aXsA#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.invoicingAmountAttr, function (value) {
model.variables.l_SummaryRecVar.invoicingAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_InvoicingAmount"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
PrefixText: "",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
SuffixText: "",
InputId: idService.getId("Input_InvoicingAmount")
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
uuid: "51",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr)]
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
uuid: "52",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount5",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("E_l6hxnpRE2tE9azRUDuIQ#Value", "Total Amount"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount8",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oZMhQDMLJ0SOsCPghh0H9w#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.amountDeliveredAttr, function (value) {
model.variables.l_SummaryRecVar.amountDeliveredAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount8"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
PrefixText: "",
InputId: idService.getId("Input_TotalAmount8"),
RightAlign: false,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true
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
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.totalAmountAttr, function (value) {
model.variables.l_SummaryRecVar.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount5"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PrefixText: "",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
RightAlign: false,
InputId: idService.getId("Input_TotalAmount5"),
UseNumericInput: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: ""
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
uuid: "62",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount9",
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IpGO9flpl0urpHFQhEtIfg#Value", "Percentage Delivered"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.0",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.percentageDeliveredAttr, function (value) {
model.variables.l_SummaryRecVar.percentageDeliveredAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount9"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
UseNumericInput: true,
PrefixText: "",
GroupSeparator: ",",
DecimalSeparator: ".",
SuffixText: "",
RightAlign: false,
InputId: idService.getId("Input_TotalAmount9"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true
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
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: "%",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount10",
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("TJQS22HXe0e9gbuQ5UWP7A#Value", "Amount left"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.amountLeftAttr, function (value) {
model.variables.l_SummaryRecVar.amountLeftAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_TotalAmount10"),
GroupSeparator: ",",
PrefixText: "",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
SuffixText: "",
RightAlign: false
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
uuid: "73",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PartialDeliveryAmount",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("p3Ct2XALQkWEz6ZD_5n1+g#Value", "Partial Delivery Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
extendedEvents: {
onKeyUp: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_PartialDeliveryAmountOnChange$Action(controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.000",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.partialDeliveryAmountAttr, function (value) {
model.variables.l_SummaryRecVar.partialDeliveryAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PartialDeliveryAmount"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
InputId: idService.getId("Input_PartialDeliveryAmount"),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
RightAlign: false,
PrefixText: ""
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
uuid: "78",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
WidgetId: idService.getId("Input_PartialDeliveryAmount")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.prorate$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "79",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_InvoicingAmount2",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("i_JpPCjEb0yQYn4vcn6G7w#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.invoicingAmountAttr, function (value) {
model.variables.l_SummaryRecVar.invoicingAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_InvoicingAmount2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
RightAlign: false,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
SuffixText: "",
InputId: idService.getId("Input_InvoicingAmount2"),
AlwaysShowDecimalDigits: true,
PrefixText: ""
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
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_TotalAmount6",
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oDHzyeAPuEiqMwjSt7vFAw#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.0",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr, function (value) {
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
SuffixText: "",
GroupSeparator: ",",
PrefixText: "",
InputId: idService.getId("Input_TotalAmount6")
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
uuid: "89",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: "%",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
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
mandatory: false,
targetWidget: "Input_TotalAmount7",
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("kHBW9iPi2kCTanrGZF4rSQ#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
prompt: "0.00",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr, function (value) {
model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount7"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GroupSeparator: ",",
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount7"),
SuffixText: "",
DecimalSeparator: ".",
RightAlign: false,
PrefixText: "",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2)
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
uuid: "95",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr)]
}))];
}),
column3: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFolioApprovalRejectReasonAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #eb9100;"
},
icon: "exclamation-triangle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.variables.getFolioApprovalRejectReasonAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.rejectReasonAttr,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsFromFolio: true,
ImportAnticipo: model.variables.l_ImportAnticipoVar,
i_IsEnable: (!(model.variables.datesQuantityPEPErrorVar)),
OrderId: model.variables.i_OrderIdIn,
_orderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
ShowTitle: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
removeFileCreditNote$Action: function (event_CreditNoteFilesListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendFilesCreditNote$Action(event_CreditNoteFilesListIn, controller.callContext(eventHandlerContext));

;
},
removeFile$Action: function (event_FilesListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendFiles$Action(event_FilesListIn, new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), new ST_6f620840109ac6f721328b723ec0152cStructure(), false, new EN_f81a3d226103fd013068b8763798067aEntityRecord(), true, new (OS$GenericTypeCache.getGenericList(ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure))(), new EN_d1d0320db36efbb094ad0082361435a0EntityRecord(), false, controller.callContext(eventHandlerContext));

;
},
sendFiles$Action: function (event_FilesListIn, event_InvoiceIn, event_InvoiceForeignIn, event_InvoiceExtendedIn, event_IsNationalIn, event_ClaveProdServIn, event_TipoDeComprobanteIn, event_CreditNoteFilesListIn, event_CreditNoteInvoiceIn, event_NeedsCreditNoteIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendFiles$Action(event_FilesListIn, event_InvoiceIn, event_InvoiceForeignIn, event_IsNationalIn, event_InvoiceExtendedIn, false, event_CreditNoteFilesListIn, event_CreditNoteInvoiceIn, event_NeedsCreditNoteIn, controller.callContext(eventHandlerContext));

;
},
sendInvoiceType$Action: function (orderAccConceptsIDIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsIDIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "103",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.datesQuantityPEPErrorVar), asPrimitiveValue(model.variables.l_ImportAnticipoVar), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.listOut.getCurrent(callContext.iterationContext).folioApprovalLevelAttr.rejectReasonAttr), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getFolioApprovalRejectReasonAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.commentsVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-s summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("WW2zj8WKnUuxLh5kCUa2rw.Enabled"), function () {
return ((((model.variables.getSettingsDataAct.o_IsActiveDEV_HU13046Out && (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.incorrectInvoice)) && (model.variables.filesListVar.isEmpty === false))) ? (true) : (((model.variables.filesListExtraVar.isEmpty === false) && model.variables.haveNewFilesVar)));
}, function () {
return model.variables.getSettingsDataAct.o_IsActiveDEV_HU13046Out;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr;
}, function () {
return model.variables.filesListVar.isEmpty;
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.haveNewFilesVar;
}),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopup$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr, model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("WcCgbAUWRk6KSlC8Vvjxqg#Value", "Update Folio")))), $if(model.variables.withQuantityErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("d6g3ZmCeyUCK_uMQURuuEw#Value", "There are fields with missing or incorrect amount, please review")))];
}, function () {
return [];
}), $if(model.variables.withDatesErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("109Fdwzsoky38bf5foymtQ#Value", "There are fields without delivery date, please review")))];
}, function () {
return [];
}), $if(model.variables.withFilesErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oSWOMHTHC0ebGLJ3wHXL0g#Value", "There are no files, please review it")))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "110"
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
uuid: "111",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.localSelectedLinesVar,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "LocalSelectedLinesTable"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("7UxS0fVb8kyIDQ2pSyLNQg#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("oi5BXrlR2kmm9FVhjoqb6w#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+gqBVAk0xEK5_fgHl8sfbQ#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wnYW87OVkEi7+5CK2B2Fkw#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("v2W_yj3pe0OzvbZq0HT+kw#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
style: model.getCachedValue(idService.getId("E+EyNPE0nkal52z7rh13MA.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "PEP Element"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ky_wXGqH+EedikuWqQ5Gqg#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("abT2kx5EhkON8xKzjgn3kg#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("H5lBpXERa0Km1yPyipLEGA#Value", "Remaining Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("70ZHB99TlUuro8bBkhTBHQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PR4dWeYhnUCkFbKBRki9iA#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("8MazV1qiBke4LPkU3I076g#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Lmmsd0YyPUuNjs6uDfDvkA#Value", "By"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LiQU5NndsUOEnzxxxMCgow#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3_8noujvSkWhM1RJAkLrRA#Value", "Import delivery")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isMultipleImputationAttr)]
}, $if(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isMultipleImputationAttr, false, this, function () {
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
uuid: "130",
alias: "23"
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
uuid: "131"
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
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("wcGkxKiFe0mleETWQS6MVg.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr,
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr),
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("IQyMcAJgS06Sya4xQJ_97A.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr;
}),
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr),
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("zySDI3uy8Eu3huV0DCAZUw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("bbuWUHiF2kq9ipbVvfAr0g.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr)).times(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr), 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr;
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr;
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr,
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("5TTrUQ_X0kGzpiYqzrVj1w.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr;
}),
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 200px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.l_IsOpenPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "UpdateFolio"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "171"
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
uuid: "172",
alias: "24"
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
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Q+CP0I9YYUy6IPvMECuB+Q#ValueExpression.2016389906.1", "Update Folio"),
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
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
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopup$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ("Estás enviando los archivos: \r\n" + model.variables.newFileNamesUploadedVar),
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("_fILK37c0kmRrLDbTLmaNA#ValueExpression.-1155902537.1", "Leave a comment..."),
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_IsOpenPopupCommentVar, function (value) {
model.variables.l_IsOpenPopupCommentVar = value;
}),
_idProps: {
service: idService,
name: "TextArea_l_IsOpenPopupComment"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.togglePopup$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-back",
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("28hyVobvBkWtJPN5+Av0LQ#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: (model.variables.filesListExtraVar.isEmpty === false),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.updateFolioOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XqlA4Hx+oUmXaZ2cmYsBFg#Value", "Update Folio"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioEditIncorrectInvoice",
functionKey: "63cf5b04-36eb-4a20-8577-965a1dc234a8",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioEditIncorrectInvoice",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioEditIncorrectInvoice.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
