import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_position as ConectaProveedores_staticEntities_position, SE_color as ConectaProveedores_staticEntities_color, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Text as OSWidgets$Text, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Label as OSWidgets$Label, Input as OSWidgets$Input, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image, Popup as OSWidgets$Popup, Link as OSWidgets$Link } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallLeft.mvc$view.js";
import ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view from "./ConectaProveedores.s_Storage.wb_PreviewFile.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadEdit.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEdit.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEdit.mvc$controller.js";

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
text: [$text(getTranslation("nro2kgT80kunyV+oByyapw#Value", "Comments and Observations"))],
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("jJh2YbduWECt6uvl84vCDQ#ValueExpression.1497638985.1", "Comments or Observations. If you have a CREDIT NOTE, please provide: Number and amount; otherwise, indicate N/A."),
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
value: model.getCachedValue(idService.getId("hjuThO3_s0mObRsJ8dYxYg.Value"), function () {
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
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal,
OptionalConfigs: model.getCachedValue(idService.getId("PgVHeDsf1k+FM7XqvO+V8w.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = false;
rec.justifyHeadersAttr = true;
return rec;
}();
})
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
return [$text(getTranslation("kXJeZMInXUWfshZepK7w9Q#Value", "Summary"))];
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
return [$text(getTranslation("5IhMbT2n5ES8aO2gxCsD0w#Value", "Partial Delivery"))];
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
}, $text(getTranslation("trY7eFMPyEWms7fKP9mGIg#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
RightAlign: false,
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
SuffixText: "",
InputId: idService.getId("Input_TotalAmount"),
PrefixText: "",
DecimalSeparator: ".",
GroupSeparator: ",",
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
}, $text(getTranslation("omMGu09ESEGk_QplS_wHzQ#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount2"),
SuffixText: "",
UseNumericInput: true,
RightAlign: false,
PrefixText: "",
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
}, $text(getTranslation("cTmb8fL+tEyylryX550lTg#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_TotalAmount3"),
DecimalSeparator: ".",
PrefixText: "",
RightAlign: false,
AlwaysShowDecimalDigits: true,
SuffixText: "",
GroupSeparator: ",",
UseNumericInput: true
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
}, $text(getTranslation("MtBHWKshbEG7o_T197PW+A#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
PrefixText: "",
DecimalSeparator: ".",
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount4"),
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
GroupSeparator: ",",
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
}, $text(getTranslation("VgccgrfvakCEZtGy4W+2Zg#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
UseNumericInput: true,
RightAlign: false,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_InvoicingAmount"),
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
}, $text(getTranslation("LLM7OE_aaEi6vYDjmuuIdg#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "56"
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
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_TotalAmount5"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
UseNumericInput: true,
RightAlign: false,
PrefixText: "",
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
uuid: "57",
alias: "12"
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
uuid: "58"
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
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("_3phQmXUfkG6juC70_8rHA#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
InputId: idService.getId("Input_TotalAmount8"),
GroupSeparator: ",",
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: true,
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
}, $text(getTranslation("mWNQV9B+SUaVoiAv4OyRxQ#Value", "Percentage Delivered"))), createElement(OSWidgets$Container, {
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
AlwaysShowDecimalDigits: true,
RightAlign: false,
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount9"),
PrefixText: "",
SuffixText: "",
GroupSeparator: ","
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
}, $text(getTranslation("wI78bfuYKkivxG_X3iTu3A#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
PrefixText: "",
SuffixText: "",
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
RightAlign: false,
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount10")
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
}, $text(getTranslation("ZH+xlb7kvUGj_skXTYMOCQ#Value", "Partial Delivery Amount"))), createElement(OSWidgets$Input, {
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
RightAlign: false,
GroupSeparator: ",",
InputId: idService.getId("Input_PartialDeliveryAmount"),
DecimalSeparator: ".",
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
PrefixText: "",
AlwaysShowDecimalDigits: true,
UseNumericInput: false
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
}, $text(getTranslation("8xgUYsIfSEuYuGnsF8ynrw#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_InvoicingAmount2"),
RightAlign: false,
PrefixText: "",
SuffixText: "",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true
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
}, $text(getTranslation("UuZSFTxJZkGFEreXtLVoiA#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Container, {
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
SuffixText: "",
GroupSeparator: ",",
DecimalSeparator: ".",
RightAlign: false,
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount6"),
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
}, $text(getTranslation("lyYbUydUVE+8Yn2VOhjFFw#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount7"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
GroupSeparator: ",",
SuffixText: "",
AlwaysShowDecimalDigits: true,
PrefixText: "",
UseNumericInput: true
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
_dependencies: [asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr)]
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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "bold subtitle-line text-neutral-8",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ur2hP+akGE65wJfRJBCs7w#Value", "Folio Files"))), createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getFolioFilesDataAct.invoiceMainFilesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, {
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
uuid: "102",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: model.getCachedValue(idService.getId("FiYBdLulvU63CUVXHhdFYQ.Style"), function () {
return ((((((model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".pdf", 0, false, false)) !== ((-1)))) || (((model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) !== ("")) && ((OS$BuiltinFunctions.index(OS$BuiltinFunctions.toLower(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), ".xml", 0, false, false)) !== ((-1)))))) ? ("") : ("visibility-hidden "));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FileSize: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
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
uuid: "104",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "106",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(!(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Filename: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr,
_i_FilenameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_StorageId: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr,
_i_StorageIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr),
i_FileSize: model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr,
_i_FileSizeInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "107",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("FIAkzC0LEEOhaAueIWvBnA#Value", "Download"))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
uuid: "108",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Ul7xp2YhWk683hwMr8cl5Q.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, 0, OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; text-align: left;"
},
style: "margin-bottom-s text-cyan",
visible: true,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ((OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr) + "|") + model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr),
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.secondary
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
uuid: "113",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("oZIACyWBIUGsB1jCF0IfWw.Value"), function () {
return OS$BuiltinFunctions.substr(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, (OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false) + 1), ((OS$BuiltinFunctions.length(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr) - OS$BuiltinFunctions.index(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr, ".", 0, false, false)) - 1));
}, function () {
return model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr;
}),
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdByNameAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).createdOnAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut.getCurrent(callContext.iterationContext).filenameAttr)]
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
FolioId: model.variables.folioIdIn,
_folioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._folioIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
sendFilesExtra$Action: function (o_FilesListExtraIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SupportSAECUploadSendFilesExtra$Action(o_FilesListExtraIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "116",
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.folioIdIn), asPrimitiveValue(model.variables.getFolioFilesDataAct.invoiceMainFilesOut), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables._folioIdInDataFetchStatus), asPrimitiveValue(model.variables.getFolioFilesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.commentsVar)]
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
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("9cOobBFlUE+lzIyOnAZvlw.Enabled"), function () {
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
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSettingsDataAct.dataFetchStatusAttr, model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}, $text(getTranslation("srTmpC_xI0yFy1sND7AO+g#Value", "Update Folio")))), $if(model.variables.withQuantityErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("W_uzf_pfBUu5b7TuN5vPIQ#Value", "There are fields with missing or incorrect amount, please review")))];
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
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uFiVJPlOxUKm9bzD_C92fQ#Value", "There are fields without delivery date, please review")))];
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
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2cm924MVGkOg7198VuHtGA#Value", "There are no files, please review it")))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "123"
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
uuid: "124",
alias: "28"
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
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("siLv_ur6TEK45khiTRYgYA#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("C8R484PJCU6vTWy8ZcIhIQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nOmQlkQZaUGa7HACJgBVmw#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3QxulJMa3EmLROd1k7CU5w#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("K+xFZXd1yk2K92vwR57QVw#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
style: model.getCachedValue(idService.getId("_oY9+XkPCEyRp0AxT6_yMg.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "PEP Element"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("QGr2YYXbPE2qTnPtBvKhPw#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WSn4HdBsF0G7kmdtzFNNYQ#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VXSY3yASUkK2CieD_3fKxw#Value", "Remaining Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZGKkvhpsY0yDyQU6h88uLw#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("CHG9H3irt0C4uAyXBsqcbA#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("n_2nnQpZ30e7LaIvFq0Wng#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("kGgo_wRZqkWtID4lBAiXgQ#Value", "By"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WerGHhZ1vk6jTvvIi9htxQ#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Z4ke7H2OmE62wwk7QPNnmw#Value", "Import delivery")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "142"
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
uuid: "143",
alias: "29"
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
uuid: "144"
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
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr,
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr,
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("Cz+K4kOStk6eb+aFremTiA.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr),
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("L2HQztswE0upQ92wUgZXXA.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr;
}),
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr),
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("eyufGJyI0k6QHlLCHoo2og.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("jb2jPoh2IkWj92Th4nX2LQ.Value"), function () {
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
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("08FwVeliMkeVNDZagNDToQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr;
}),
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "3_0")
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
uuid: "182"
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
uuid: "184"
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
uuid: "185",
alias: "30"
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
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QMd6sTFvxkeOVwpS310rfg#ValueExpression.2016389906.1", "Update Folio"),
_idProps: {
service: idService,
uuid: "187"
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
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "190"
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
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ("Estás enviando los archivos: \r\n" + model.variables.newFileNamesUploadedVar),
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "193"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("XlkeBhfpN0aUObmfMiScqA#ValueExpression.-1155902537.1", "Leave a comment..."),
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
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-back",
visible: true,
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("p4ZC9Q9_PUeUqHBcZ1pVmQ#Value", "Close"))), createElement(OSWidgets$Button, {
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
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nqK9j9amrkGVCOAqpInFEQ#Value", "Update Folio"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioEdit",
functionKey: "6b64da99-e225-4b03-b422-559135fd397b",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioEdit",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioEdit.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallLeft_mvc_view, ConectaProveedores_s_Storage_wb_PreviewFile_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Content_Tag_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SupportSAEUploadEdit_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
