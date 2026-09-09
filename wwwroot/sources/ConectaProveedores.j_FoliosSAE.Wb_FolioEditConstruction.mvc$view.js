import { withBaseWebBlock, ifWidget as $if, textWidget as $text, getTranslation, asPrimitiveValue, Widget, useTracing } from "@outsystems/runtime-view-js";
import { SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import { Model as OS$Model, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { Container as OSWidgets$Container, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Text as OSWidgets$Text, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, Checkbox as OSWidgets$Checkbox, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image, Link as OSWidgets$Link, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-columns-cards",
visible: true,
_idProps: {
service: idService,
uuid: "5"
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
TabletBehavior: ConectaProveedores_staticEntities_breakColumns.all,
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
uuid: "6",
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
uuid: "7"
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("3+ozUmCPcEqYe0dmU8otsQ#Value", "Comments and Observations"))],
_idProps: {
service: idService,
uuid: "10"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("8blvIHGdAki0cB_sY_0w6g#ValueExpression.1497638985.1", "Comments or Observations. If you have a CREDIT NOTE, please provide: Number and amount; otherwise, indicate N/A."),
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("d6UC_GUgjUOnPpnfa03hXg.Value"), function () {
return ((OS$BuiltinFunctions.length(model.variables.commentsVar)).toString() + "/1000");
}, function () {
return model.variables.commentsVar;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "14"
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
uuid: "15"
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
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.observationAttr,
_idProps: {
service: idService,
uuid: "18"
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateTimeToText(model.variables.getFolioObservationsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioObservationsAttr.createdOnAttr),
_idProps: {
service: idService,
uuid: "20"
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
uuid: "21"
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
OptionalConfigs: model.getCachedValue(idService.getId("DKexlbyhA027J9EF2h73kA.OptionalConfigs"), function () {
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
uuid: "22",
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
uuid: "23",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("iHygZbCnNEa+aOjzDdh0NA#Value", "Summary"))];
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
uuid: "24",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("NY0YSb0XjUG9ustuqqSZ6A#Value", "Partial Delivery"))];
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
uuid: "25",
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
uuid: "26"
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QatQJZJ5Lkep9tlwTbJBJQ#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "29"
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
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount"),
UseNumericInput: true,
SuffixText: "",
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
uuid: "30",
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
uuid: "31"
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
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FcahoY54wUyLt5tN6KQeOg#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "34"
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
InputId: idService.getId("Input_TotalAmount2"),
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
PrefixText: "",
DecimalSeparator: ".",
SuffixText: "",
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
uuid: "35",
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
uuid: "36"
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
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JaZ2rFmPYk61371YKgv3YA#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "39"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
RightAlign: false,
PrefixText: "",
SuffixText: "",
UseNumericInput: true,
GroupSeparator: ",",
InputId: idService.getId("Input_TotalAmount3")
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
uuid: "41"
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
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6Zh1NYt1rEO+6zhx7HFNzQ#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
uuid: "44"
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
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
InputId: idService.getId("Input_TotalAmount4"),
UseNumericInput: true,
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
uuid: "45",
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
uuid: "46"
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
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("mV2u_bIw0k+gVoFXOO6amQ#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
uuid: "49"
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
GroupSeparator: ",",
UseNumericInput: true,
RightAlign: false,
DecimalSeparator: ".",
InputId: idService.getId("Input_InvoicingAmount"),
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
uuid: "50",
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
uuid: "51",
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
uuid: "52"
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
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("T9ypSbJwOE+tFZrVY4MyPQ#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "55"
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
PrefixText: "",
UseNumericInput: true,
SuffixText: "",
InputId: idService.getId("Input_TotalAmount5"),
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
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
uuid: "56",
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
uuid: "57"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5CJ4Ah3TDUGOTF7oohl9xQ#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "60"
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
PrefixText: "",
DecimalSeparator: ".",
GroupSeparator: ",",
SuffixText: "",
RightAlign: false,
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_TotalAmount8"),
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
uuid: "61",
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
uuid: "62"
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
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("L_iMDs9T8kyheJ6yF+AEfg#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: "%",
_idProps: {
service: idService,
uuid: "65"
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
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_TotalAmount9"),
PrefixText: "",
SuffixText: "",
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
uuid: "66",
alias: "14"
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
uuid: "67"
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
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XJos1xoKe0yUGSP8OKH5qg#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
uuid: "70"
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
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_TotalAmount10"),
PrefixText: "",
DecimalSeparator: ".",
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
uuid: "71",
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
uuid: "72"
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
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("DGB5dWOQK0WfcKIyFpp88w#Value", "Partial Delivery Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
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
prompt: "0.00",
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
uuid: "75"
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
InputId: idService.getId("Input_PartialDeliveryAmount"),
DecimalSeparator: ".",
RightAlign: false,
AlwaysShowDecimalDigits: true,
SuffixText: "",
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
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
uuid: "76",
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
uuid: "77",
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
uuid: "78"
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
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KaxUmm3CuE6f89CZHVIMMQ#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
uuid: "81"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
DecimalSeparator: ".",
PrefixText: "",
GroupSeparator: ",",
RightAlign: false,
InputId: idService.getId("Input_InvoicingAmount2"),
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
uuid: "82",
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
uuid: "83"
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
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VZojgx+4tkuUrYr8G4UWPw#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
}), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: "%",
_idProps: {
service: idService,
uuid: "86"
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
PrefixText: "",
UseNumericInput: true,
SuffixText: "",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount6"),
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
uuid: "87",
alias: "19"
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
uuid: "88"
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
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ireA+LBWD0eGksi7vG0mJg#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
uuid: "91"
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
InputId: idService.getId("Input_TotalAmount7"),
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
DecimalSeparator: ".",
SuffixText: "",
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
uuid: "92",
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
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("CkIu2CamtEmC4Go9nayiYg#Value", "Concept of the Minutes"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("C91kjZ4vSE6H4zCvsgrzWw#ValueExpression.-1165887790.1", "Select One Minute"),
enabled: true,
labels: function (elem) {
return elem.valueAttr;
},
list: model.variables.getMinutesDataAct.keyValueListOut,
mandatory: true,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.selectMinute$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "dropdown",
values: function (elem) {
return elem.keyAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Integer, model.variables.minuteSelectedVar, function (value) {
model.variables.minuteSelectedVar = value;
}),
_idProps: {
service: idService,
name: "DropdownConceptMinutes"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMinutesDataAct.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), $if((((model.variables.minuteSelectedVar) !== (0)) && model.variables.getMinutesDocumentsDataAct.isDataFetchedAttr), false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.folioIdIn,
_i_FolioIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._folioIdInDataFetchStatus),
OrderNumber: model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_orderNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDetailAggr.dataFetchStatusAttr),
FilesList: model.variables.getMinutesDocumentsDataAct.filesList2Out,
_filesListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr),
List: model.variables.getMinutesDocumentsDataAct.listOut,
_listInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
sendFiles$Action: function (event_FilesListIn, event_MinuteDocumentTypeListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_UploadDocumentsConstructionSendFiles$Action(event_FilesListIn, event_MinuteDocumentTypeListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "97",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "info-circle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("1kN2grFTukS1kBpyXAioMw#Value", "If you have a credit note / voucher or advance amortization,enter the indicated amount excluding VAT."))],
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Utilities_Separator_mvc_view, {
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
uuid: "104",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.paymentType$Action("1", controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.constructionStructVar.advPaymentAttr, function (value) {
model.variables.constructionStructVar.advPaymentAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
style: "os-boxlabel position-relative ",
visible: true,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("WfJyEqKAHEOpjJz37RNazw.Style"), function () {
return ((model.variables.constructionStructVar.advPaymentAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.advPaymentAttr;
}),
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Kudt37nQcUKfvw3ESZ4LNw#Value", "Advance repayment"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.constructionStructVar.advPaymentAttr,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.constructionStructVar.advPaymentValueAttr, function (value) {
model.variables.constructionStructVar.advPaymentValueAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AdvPaymentValue"
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
uuid: "111"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
InputId: idService.getId("Input_AdvPaymentValue"),
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
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
uuid: "112",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.paymentType$Action("2", controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.constructionStructVar.creditNoteAttr, function (value) {
model.variables.constructionStructVar.creditNoteAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
style: "os-boxlabel position-relative ",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("x2uIJ8Gm3EaHWVmpom+UaQ.Style"), function () {
return ((model.variables.constructionStructVar.creditNoteAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.creditNoteAttr;
}),
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("VWdPZS74y0SvP_8Vl5mfvw#Value", "Credit note"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.constructionStructVar.creditNoteAttr,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.constructionStructVar.creditNoteValueAttr, function (value) {
model.variables.constructionStructVar.creditNoteValueAttr = value;
}),
_idProps: {
service: idService,
name: "Input_CreditNoteValue"
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
uuid: "119"
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
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_CreditNoteValue"),
DecimalSeparator: ".",
RightAlign: false,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
UseNumericInput: true,
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
uuid: "120",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.paymentType$Action("3", controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.constructionStructVar.voucherAttr, function (value) {
model.variables.constructionStructVar.voucherAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
style: "os-boxlabel position-relative ",
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("Gu49DvLG3Uq7uShBsh4R4Q.Style"), function () {
return ((model.variables.constructionStructVar.voucherAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.voucherAttr;
}),
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("w4TrsqY+o0Kw7igF33fWiQ#Value", "Voucher"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.constructionStructVar.voucherAttr,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.constructionStructVar.voucherValueAttr, function (value) {
model.variables.constructionStructVar.voucherValueAttr = value;
}),
_idProps: {
service: idService,
name: "Input_VoucherValue"
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
uuid: "127"
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
UseNumericInput: true,
DecimalSeparator: ".",
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
GroupSeparator: ",",
InputId: idService.getId("Input_VoucherValue"),
PrefixText: "",
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
uuid: "128",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.paymentType$Action("4", controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.constructionStructVar.nAAttr, function (value) {
model.variables.constructionStructVar.nAAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, "N/A")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.constructionStructVar.nAAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherValueAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteValueAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentValueAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.folioIdIn), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.listOut), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.filesList2Out), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getMinutesDataAct.keyValueListOut), asPrimitiveValue(model.variables.minuteSelectedVar), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._folioIdInDataFetchStatus), asPrimitiveValue(model.variables.getMinutesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioObservationsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.commentsVar)]
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
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
title: model.getCachedValue(idService.getId("Ijf3DhULyEuL8o9ZX7MB9Q.title"), function () {
return (((((((((((((((((((((((((("FilesListExtra.Empty = False " + (((!(model.variables.filesListExtraVar.isEmpty))) ? ("True") : ("False"))) + "\r\n") + "l_SummaryRec.InvoicingAmount > 0 ") + ((model.variables.l_SummaryRecVar.invoicingAmountAttr.gt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("True") : ("False"))) + "\r\n") + "DatesQuantityError = False ") + (((!(model.variables.datesQuantityPEPErrorVar))) ? ("True") : ("False"))) + "\r\n") + "DatesQuantityError = False ") + (((!(model.variables.datesQuantityPEPErrorVar))) ? ("True") : ("False"))) + "\r\n") + "MinuteSelected <> 0 ") + ((((model.variables.minuteSelectedVar) !== (0))) ? ("True") : ("False"))) + "\r\n") + "If(AdvPayment) ") + ((((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n") + "If(CreditNote) ") + ((((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n") + "If(Voucher) ") + ((((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n") + "MinuteSelected <> 0 ") + ((((model.variables.minuteSelectedVar) !== (0))) ? ("True") : ("False"))) + "\r\n");
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.l_SummaryRecVar.invoicingAmountAttr;
}, function () {
return model.variables.datesQuantityPEPErrorVar;
}, function () {
return model.variables.minuteSelectedVar;
}, function () {
return model.variables.constructionStructVar.advPaymentAttr;
}, function () {
return model.variables.constructionStructVar.advPaymentValueAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteValueAttr;
}, function () {
return model.variables.constructionStructVar.voucherAttr;
}, function () {
return model.variables.constructionStructVar.voucherValueAttr;
})
},
icon: "flag",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("7VTyXJ3YUUu8B878KHA+Yg.Enabled"), function () {
return (((((((((model.variables.filesListExtraVar.isEmpty === false) && (model.variables.withFilesErrorVar === false)) && (model.variables.maxAmountErrorVar === false)) && (model.variables.datesQuantityPEPErrorVar === false)) && ((model.variables.minuteSelectedVar) !== (0))) && ((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && model.variables.l_SummaryRecVar.invoicingAmountAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)));
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.datesQuantityPEPErrorVar;
}, function () {
return model.variables.minuteSelectedVar;
}, function () {
return model.variables.constructionStructVar.advPaymentAttr;
}, function () {
return model.variables.constructionStructVar.advPaymentValueAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteValueAttr;
}, function () {
return model.variables.constructionStructVar.voucherAttr;
}, function () {
return model.variables.constructionStructVar.voucherValueAttr;
}, function () {
return model.variables.l_SummaryRecVar.invoicingAmountAttr;
}),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
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
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("nE06AFOWn0ORC70wX4MCCw#Value", "Update Folio")))), $if(model.variables.withQuantityErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dzPflChTLEuLRBxtrURHTQ#Value", "There are fields with missing or incorrect amount, please review")))];
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
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zRRJBybuY0updV5wN6OO6Q#Value", "There are fields without delivery date, please review")))];
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
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("jakRmBZbBUS9kCCxpZfs9A#Value", "There are no files, please review it")))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "140"
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
uuid: "141",
alias: "26"
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
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("J6fdSFd45UuddQxXf9WYkA#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("wH2ll_QwpUWmaIcl4T6hqQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MZS2nIOu9060WXyEoWZslQ#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("bvnuVXI79U6sB4fUJCHnmg#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("N8yuh4bHGUSwuKN8t+V93Q#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
style: model.getCachedValue(idService.getId("604qgfHS5kCdL0olFjtwVQ.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "PEP Element"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("e1t_z6CAr0Kzt8BOom1lCQ#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VFIYZgE+Q0iFY3KZto_57g#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("eDTGdKLaTESf9EPmeDIkyA#Value", "Remaining Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "153"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("qIfctHP9kUq3Cdwy_MbeuQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("xr8cnAiwgUyB9FHXXqns9w#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("e0LxLPEgGkCESnsN1xC8gw#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "BaseQuantity",
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EII4buTQ2UibT4ZmmUhcSg#Value", "By"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("IFW7TVKtMk2dYNUwWQV2Bw#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("KPhMkqIdiEabCO_4rMmOmA#Value", "Import delivery"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "160"
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
uuid: "161",
alias: "27"
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
uuid: "162"
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
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).orderNumberAttr,
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
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).articleNumberAttr,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr,
_idProps: {
service: idService,
uuid: "173"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("XiBf48OCv0CzkSyTl+i7mA.Style"), function () {
return (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? (((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isPEPErrorAttr) ? ("borderred") : (""))) : ("display-none"));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr;
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isPEPErrorAttr;
}),
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 24,
style: "form-control input-width-180px",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr, function (value) {
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).pEPAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PEP"
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
WidgetId: idService.getId("Input_PEP"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.debouncePEPOnDebounce$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "177",
alias: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("FEeHSOUjk0qJWA28j6PhDg.Style"), function () {
return ((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isDateErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isDateErrorAttr;
}),
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr), asPrimitiveValue(model.variables.l_IsApplyToAllVar)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.l_IsApplyToAllVar)), false, this, function () {
return [createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DateFormat: "DD/MM/YYYY",
OptionalConfigs: model.getCachedValue(idService.getId("rk7Y_Ib4+E6CvUKd_M6KWQ.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
rec.initialDateAttr = OS$BuiltinFunctions.nullDate();
rec.maxDateAttr = OS$BuiltinFunctions.currDate();
return rec;
}();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectDeliveryDate$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "180",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedProperties: {
"aria-label": "Select a date",
autoComplete: "off"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr, function (value) {
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DeliveryDateLine"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryDateAttr)]
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Av3YkHKW1kSaYdf4X3jMVA.Value"), function () {
return ((model.variables.deliveryDateVar.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.formatDateTime(model.variables.deliveryDateVar, "dd/MM/yyyy")));
}, function () {
return model.variables.deliveryDateVar;
}),
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("Dh1IcWDDzku1Dm0GFLRpHA.Style"), function () {
return ((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isInvoiceErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).isInvoiceErrorAttr;
}),
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
extendedEvents: {
onKeyUp: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_InvoiceQttOnChange$Action(controller.callContext(eventHandlerContext));

;
}
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 15,
prompt: "0.000",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr, function (value) {
model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr = value;
}),
_idProps: {
service: idService,
name: "Input_InvoiceQtt"
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
InputId: idService.getId("Input_InvoiceQtt"),
UseNumericInput: false,
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
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
uuid: "186",
alias: "30"
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
WidgetId: idService.getId("Input_InvoiceQtt"),
DebounceDelay: 1000
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDebounce$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.debounceInvoiceQttOnDebounce$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "187",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Expression, {
style: model.getCachedValue(idService.getId("wVNXUYxR4kyfafOZGrrr+g.Style"), function () {
return ((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr),
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1mkikKf4P0ufjIaL7Esdgw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).invoiceQttAttr), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
style: model.getCachedValue(idService.getId("ClEY4Yy3zkisBDpY09A1hw.Style"), function () {
return ((model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1kUTRdm8e0qrVd8txDxwnQ.Value"), function () {
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
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).deliveryQttAttr,
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("bZikb7YcSEaVCgA21wi9Qw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).importdeliveryAttr;
}),
_idProps: {
service: idService,
uuid: "205"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeOnClick$Action(model.variables.localSelectedLinesVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "207"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "3_0")
},
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.localSelectedLinesVar.getCurrent(callContext.iterationContext).inputationCodeAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.localSelectedLinesVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 200px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Popup, {
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
uuid: "211"
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
uuid: "212",
alias: "32"
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
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Wf+7Gfi_NUW3hdFsiGMJuA#ValueExpression.2016389906.1", "Update Folio"),
_idProps: {
service: idService,
uuid: "214"
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
uuid: "215"
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
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), $if(model.variables.haveNewFilesVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "218"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: ("Estás enviando los archivos: \r\n" + model.variables.newFileNamesUploadedVar),
_idProps: {
service: idService,
uuid: "219"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "220"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("G7i5o2md5ECLk27Qe+Z0kw#ValueExpression.-1155902537.1", "Leave a comment..."),
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
uuid: "222"
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
uuid: "223"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("se1ypEI8O0upSXQD0OgYBQ#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("g7bcXKvZPkqeGqMILnAyuQ.Enabled"), function () {
return (((((((((model.variables.filesListExtraVar.isEmpty === false) && (model.variables.withFilesErrorVar === false)) && (model.variables.maxAmountErrorVar === false)) && (model.variables.datesQuantityPEPErrorVar === false)) && ((model.variables.minuteSelectedVar) !== (0))) && ((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && model.variables.l_SummaryRecVar.invoicingAmountAttr.gt(OS$BuiltinFunctions.integerToDecimal(0)));
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.datesQuantityPEPErrorVar;
}, function () {
return model.variables.minuteSelectedVar;
}, function () {
return model.variables.constructionStructVar.advPaymentAttr;
}, function () {
return model.variables.constructionStructVar.advPaymentValueAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteAttr;
}, function () {
return model.variables.constructionStructVar.creditNoteValueAttr;
}, function () {
return model.variables.constructionStructVar.voucherAttr;
}, function () {
return model.variables.constructionStructVar.voucherValueAttr;
}, function () {
return model.variables.l_SummaryRecVar.invoicingAmountAttr;
}),
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
uuid: "224"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("I7r16mmRDUqu71NZiGh8ew#Value", "Update Folio"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioEditConstruction",
functionKey: "78ca4ede-b8c0-4018-adff-cda1c8cf3e8d",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioEditConstruction",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioEditConstruction.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstructionEdit_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view];
};


return ELEM;
};

export default componentFactory()
