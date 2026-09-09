import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_60f22bd2e9b10a22278b8afe6d7f601aStructure, ST_4e53cb8815b86020ced1d2f2652c9b1dStructure, ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Form as OSWidgets$Form, Label as OSWidgets$Label, Expression as OSWidgets$Expression, Switch as OSWidgets$Switch, Input as OSWidgets$Input, TextArea as OSWidgets$TextArea, List as OSWidgets$List, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, DataTypes as OS$DataTypes, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$view.js";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_approvalProcessType as ConectaProveedores_staticEntities_approvalProcessType, SE_datePickerTimeFormat as ConectaProveedores_staticEntities_datePickerTimeFormat, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_size as ConectaProveedores_staticEntities_size, SE_color as ConectaProveedores_staticEntities_color, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import OutSystemsUI_Interaction_DropdownSearch_mvc_view from "./OutSystemsUI.Interaction.DropdownSearch.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { EN_d1d0320db36efbb094ad0082361435a0EntityRecord, EN_f81a3d226103fd013068b8763798067aEntityRecord, ST_09ca0b4d4a2f96d3f5dee609d73f12b2Structure } from "./ConectaProveedores.model.js";
import { ST_6f620840109ac6f721328b723ec0152cStructure } from "./Extension.ForeignInvoiceTextParserService.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUpload.mvc$view.js";
import BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view from "./BigUpload.BigUpload.wb_BigUploadMultipleFiles.mvc$view.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("ihyc9DVhqUSmpK92vgvGIw.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
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
uuid: "0",
alias: "1"
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
uuid: "1",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("7e0600umvUqLtzblXABH3w#Value", "Payment Information"))];
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
uuid: "2",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("d7cFv5wwEUy0Y1pxUHlXCg#Value", "Crear Solicitud"))];
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
uuid: "3",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut, false, this, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn,
_i_OrderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus)
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
uuid: "5",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn,
_i_OrderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus)
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
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut)]
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
uuid: "7",
alias: "7"
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
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "custom-columns-cards",
visible: true,
_idProps: {
service: idService,
uuid: "9"
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
uuid: "10",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "Header"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
extendedProperties: {
title: model.getCachedValue(idService.getId("8XSXO1Yi90K+Av0m4xAxhw.title"), function () {
return (((model.variables.aprovalProcessTypeIdIn === ConectaProveedores_staticEntities_approvalProcessType.normal)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7BLcz2nTPECVBzVlsak9lQ#Value.-1955878649.1", "Normal")) : ((((model.variables.aprovalProcessTypeIdIn === ConectaProveedores_staticEntities_approvalProcessType.alternative)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("7BLcz2nTPECVBzVlsak9lQ#Value.1471074189.1", "Alternative")) : (" - "))));
}, function () {
return model.variables.aprovalProcessTypeIdIn;
})
},
style: "display font-size-sub-heading",
text: [$text(getTranslation("8XSXO1Yi90K+Av0m4xAxhw#Value", "Details"))],
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Form, {
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
}, $if(((model.variables.aprovalProcessTypeIdIn === ConectaProveedores_staticEntities_approvalProcessType.alternative) || (OS$BuiltinFunctions.toUpper(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr) === "Q")), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-bottom-m",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ZAQ0qF8GvESi5PmkpTMKqg#Value", "Approver"))), createElement(OutSystemsUI_Interaction_DropdownSearch_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("IuoVEY5WxkGTEJ7GTtKXiA#Value.1414582808.1", "Select the approver"),
OptionsList: model.getCachedValue(idService.getId("Dropdown_Approver.OptionsList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getFirstApproverListDataAct.firstApproverListOut, new (OS$GenericTypeCache.getGenericList(ST_60f22bd2e9b10a22278b8afe6d7f601aStructure))(), function (source, target) {
target.valueAttr = source.userIdAttr;
target.labelAttr = source.userNameAttr;
target.descriptionAttr = source.rolenameAttr;
return target;
});
}, function () {
return model.variables.getFirstApproverListDataAct.firstApproverListOut;
}),
_optionsListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFirstApproverListDataAct.dataFetchStatusAttr),
OptionalConfigs: model.getCachedValue(idService.getId("Dropdown_Approver.OptionalConfigs"), function () {
return function () {
var rec = new ST_4e53cb8815b86020ced1d2f2652c9b1dStructure();
rec.noResultsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("3C4MHVsue0inqovlmRnccQ#Value.-796168008.1", "There are no approvers to select");
rec.searchPromptAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1mNANnim2UmkpuRuwj+apg#Value.-1329997251.1", "Search Approver");
rec.noOptionsTextAttr = OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("1XsFq8fVtkesJGp+wR8Brw#Value.-1076950967.1", "There are no options to show");
return rec;
}();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onChanged$Action: function (dropdownSearchIdIn, selectedOptionListIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.dropdown_ApproverOnChanged$Action(selectedOptionListIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "Dropdown_Approver",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: (!(model.variables.approverValidVar)),
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-error font-size-xs",
value: model.variables.approverErrorMessageVar,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "22"
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
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "23",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Switch, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
style: "margin-bottom: 0;"
},
style: "switch",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.l_IsApplyToAllVar, function (value) {
model.variables.l_IsApplyToAllVar = value;
}),
_idProps: {
service: idService,
name: "SwitchIsApplyToAll"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("0MhlBbT+JUaUg2uwT9G6jQ#Value", "Apply to all lines"))],
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsApplyToAllVar)]
})), $if(model.variables.l_IsApplyToAllVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
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
targetWidget: "Input_DeliveryDate",
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Fb41VEO5AkKiEhjSKiXcHw#Value", "Delivery Date"))), createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TimeFormat: ConectaProveedores_staticEntities_datePickerTimeFormat.disabled,
DateFormat: "DD/MM/YYYY",
OptionalConfigs: model.getCachedValue(idService.getId("DatePicker.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
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
controller.datePickerOnSelected$Action(selectedDateTimeIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
name: "DatePicker",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
enabled: true,
extendedProperties: {
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HAJTBthDYUq6jexKwcQkbw#Value.1002767249.1", "Select a date"),
style: "margin-bottom: 0;"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.deliveryDateVar, function (value) {
model.variables.deliveryDateVar = value;
}),
_idProps: {
service: idService,
name: "Input_DeliveryDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar)]
}))];
}, function () {
return [];
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "30"
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
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("XhTHDWydqEu8gj7dc78yXw#Value", "Comments and Observations"))],
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 1000,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WWmrRXgwo0OOGMe7H+7_bw#ValueExpression.1497638985.1", "Comments or Observations. If you have a CREDIT NOTE, please provide: Number and amount; otherwise, indicate N/A."),
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
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("E6hYhyi36U21Z6u2fFfHyw.Value"), function () {
return ((OS$BuiltinFunctions.length(model.variables.commentsVar)).toString() + "/1000");
}, function () {
return model.variables.commentsVar;
}),
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
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
uuid: "37"
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
OptionalConfigs: model.getCachedValue(idService.getId("2AZNNsyTy0mUevnrHprMCg.OptionalConfigs"), function () {
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
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "38",
alias: "12"
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
uuid: "39",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("qghkX7xmwkCSHoKuLTSYKg#Value", "Summary"))];
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
uuid: "40",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("wnXxFg5dF06KfqYNuvHWrQ#Value", "Partial Delivery"))];
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
uuid: "41",
alias: "15"
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
uuid: "42"
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
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KVgriwJ9SkO+EKUx0w+vzw#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
GroupSeparator: ",",
UseNumericInput: true,
PrefixText: "",
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_TotalAmount"),
RightAlign: false,
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
uuid: "46",
alias: "16"
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
targetWidget: "Input_TotalAmount2",
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("NevdAgVJiEyy+QdfzBWKtA#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
PrefixText: "",
UseNumericInput: true,
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
InputId: idService.getId("Input_TotalAmount2"),
SuffixText: "",
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
uuid: "51",
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
uuid: "52"
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
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("SEqhrdzjWku80aIkwPVhWQ#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
PrefixText: "",
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
GroupSeparator: ",",
DecimalSeparator: ".",
SuffixText: "",
RightAlign: false,
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
uuid: "56",
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
uuid: "57"
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
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ELya9kC_ykuPaW_ep3HSAw#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
SuffixText: "",
PrefixText: "",
DecimalSeparator: ".",
UseNumericInput: true,
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
GroupSeparator: ",",
InputId: idService.getId("Input_TotalAmount4")
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
uuid: "62"
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
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Sje_m8Mm40OomDWcOmZfgg#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_InvoicingAmount"),
DecimalSeparator: ".",
GroupSeparator: ",",
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
PrefixText: "",
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
uuid: "66",
alias: "20"
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
uuid: "67",
alias: "21"
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
uuid: "68"
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
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ykga19aWRUKVL7h+5SN2+g#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "71"
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
InputId: idService.getId("Input_TotalAmount5"),
SuffixText: "",
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
PrefixText: "",
AlwaysShowDecimalDigits: true,
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
uuid: "72",
alias: "22"
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
uuid: "73"
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
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("KUpkLIqfLkCKCVLt2PneJg#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "76"
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
SuffixText: "",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
PrefixText: "",
RightAlign: false,
InputId: idService.getId("Input_TotalAmount8")
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
uuid: "77",
alias: "23"
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
targetWidget: "Input_TotalAmount9",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UFCO2y6EeE6hjhK6fVEEBg#Value", "Percentage Delivered"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "80"
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
GroupSeparator: ",",
PrefixText: "",
SuffixText: "",
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount9"),
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
uuid: "82",
alias: "24"
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
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "84"
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
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y0b2i4SVfU6n+ST6zHgemA#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
uuid: "87"
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
PrefixText: "",
RightAlign: false,
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount10"),
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
uuid: "88",
alias: "25"
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
uuid: "89"
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
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vBpAmxvsykKsjG9UEWzfrA#Value", "Invoice amount (subtotal)"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.filesListVar.isEmpty,
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
})), createElement(OSWidgets$Expression, {
extendedProperties: {
style: "left: 12px; top: 8px;"
},
style: "position-absolute text-neutral-6",
value: model.variables.l_SummaryRecVar.currencyAttr,
_idProps: {
service: idService,
uuid: "93"
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
SuffixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
RightAlign: false,
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: false,
InputId: idService.getId("Input_PartialDeliveryAmount"),
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
uuid: "94",
alias: "26"
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
uuid: "95",
alias: "27"
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
uuid: "96"
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
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oIXQixtfFUiL8mBAnj9LwA#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
uuid: "99"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
DecimalSeparator: ".",
RightAlign: false,
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_InvoicingAmount2"),
UseNumericInput: true,
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
uuid: "100",
alias: "28"
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
uuid: "101"
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
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("DrcUeNVekU+js8C35HztsQ#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "103"
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
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount6"),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
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
uuid: "105",
alias: "29"
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
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel position-relative margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "107"
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
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2lZjyzv57kSq9dZtF6IcWQ#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
uuid: "110"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount7"),
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
RightAlign: false,
PrefixText: "",
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
uuid: "111",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr)]
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
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ShowTitle: true,
ImportAnticipo: model.variables.l_ImportAnticipoVar,
OrderId: model.variables.i_OrderIdIn,
_orderIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_OrderIdInDataFetchStatus),
IsFromFolio: true,
i_IsEnable: true
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
sendInvoiceType$Action: function (orderAccConceptsIDIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_InvoiceSAECUploadSendInvoiceType$Action(orderAccConceptsIDIn, controller.callContext(eventHandlerContext));

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
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "114",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(true, false, this, function () {
return [createElement(BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6fknC0OoLkyvD1efoRmx0w#Value.-814858255.1", "Attach Other Evidences"),
MaxSize: 100,
IsEnable: true,
IsMandatory: true,
isValid: true,
ShowStatus: true,
Message: ""
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
notifyFileId$Action: function (fileIdIn, filenameIn, mimeTypeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, controller.callContext(eventHandlerContext));

;
},
eventEndProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadMultipleFilesEventEndProcess$Action(controller.callContext(eventHandlerContext));

;
},
eventstartProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadMultipleFilesEventstartProcess$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "116",
alias: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.filesListExtraVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.filesListExtraVar.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Color: ConectaProveedores_staticEntities_color.neutral3
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
alias: "33"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: var(--color-third); !important"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "121"
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
i_Text: model.variables.filesListExtraVar.getCurrent(callContext.iterationContext).nameAttr,
i_NChar: 20
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
uuid: "122",
alias: "34"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.removeFromList$Action(model.variables.filesListExtraVar.getCurrentRowNumber(callContext.iterationContext), true, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListExtraVar.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: []
}))];
}, function () {
return [];
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListExtraVar), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.l_ImportAnticipoVar), asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.approverErrorMessageVar), asPrimitiveValue(model.variables.approverValidVar), asPrimitiveValue(model.variables.getFirstApproverListDataAct.firstApproverListOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getFirstApproverListDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._aprovalProcessTypeIdInDataFetchStatus), asPrimitiveValue(model.variables.aprovalProcessTypeIdIn)]
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
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(false, false, this, function () {
return [];
}, function () {
return [];
}), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("fglF3nBXP0CaNRbJpJ60ng.Enabled"), function () {
return (((((((((model.variables.filesListVar.length === 2) || ((((model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr) !== ("MX")) || model.variables.getSettingsDataAct.isForceForeignerOut) && (model.variables.filesListVar.length === 1))) && (!(model.variables.maxAmountErrorVar))) && (!(model.variables.filesListExtraVar.isEmpty))) && (!(model.variables.withFilesErrorVar))) && (!(model.variables.datesQuantityPEPErrorVar))) && ((((model.variables.aprovalProcessTypeIdIn === ConectaProveedores_staticEntities_approvalProcessType.alternative) || (OS$BuiltinFunctions.toUpper(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr) === "Q"))) ? (true) : (((model.variables.firstUserIdentifierVar) !== (OS$BuiltinFunctions.nullTextIdentifier()))))) && !(model.variables.orderAccConceptsIdToCreateVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && ((!(model.variables.creditNote_IsNeededVar)) || (model.variables.creditNoteFilesListVar.length === 2)));
}, function () {
return model.variables.filesListVar.length;
}, function () {
return model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr;
}, function () {
return model.variables.getSettingsDataAct.isForceForeignerOut;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.datesQuantityPEPErrorVar;
}, function () {
return model.variables.aprovalProcessTypeIdIn;
}, function () {
return model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr;
}, function () {
return model.variables.firstUserIdentifierVar;
}, function () {
return model.variables.orderAccConceptsIdToCreateVar;
}, function () {
return model.variables.creditNote_IsNeededVar;
}, function () {
return model.variables.creditNoteFilesListVar.length;
}),
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.createFolioOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDetailAggr.dataFetchStatusAttr, model.variables.getSettingsDataAct.dataFetchStatusAttr, model.variables._aprovalProcessTypeIdInDataFetchStatus)
}, $text(getTranslation("IogSaj2hKEuV55Ny3sg2XA#Value", "Create Folio")))), $if(model.variables.withQuantityErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GquWofwas0egEmQ0DBF1cQ#Value", "There are fields with missing or incorrect amount, please review")))];
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
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hhRtoNgamkC9NKdQYbghqw#Value", "There are fields without delivery date, please review")))];
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
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("w6ztIq_Wh0mJHA0LIRxKCQ#Value", "There are no files, please review it")))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "132"
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
uuid: "133",
alias: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.localSelectedLinesIn,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "LocalSelectedLinesTable"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_SyQr1VW4UuqJJsrWh26jQ#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mrxg_2Z5106E9S3Fx_ViTQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ws3kttHH0UWcegVjxlvUKw#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3bztiPfD10+BtVc66uN5Kw#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "140"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mfsGCdfkD0qNedsR+NkzJw#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
style: model.getCachedValue(idService.getId("nFrYcrzlS0WCccFQKxHfkA.Style"), function () {
return (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
_dependencies: []
}, $text(getTranslation("a6DZ6djdOUmiJeCbJXj4oQ#Value", "PEP Element"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("272AhqGaIU6ZUuroH1SNQg#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "143"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6C6m4z+RIUWIdVooYeYXpA#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "144"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rTo0C3wzvE+G5SWxXbrO3Q#Value", "Remaining Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Om4yVZr+mUKHozkvxi1gSQ#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rgBeqsyiKEepgQjbyQJSQw#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Vbl3HoJW5E2AG2uQbCY1dw#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("qU5YmZ6xykywgDCV72NKeA#Value", "By"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Z0Az0SViGEmZxSRIzohsKw#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("TlI8o9A6NUWQ9FFsjtOf5w#Value", "Import delivery"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isMultipleImputationAttr)]
}, $if(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isMultipleImputationAttr, false, this, function () {
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
uuid: "153",
alias: "36"
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
uuid: "154"
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
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).articleNumberAttr)]
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
value: model.getCachedValue(idService.getId("w1WnLYykQkmfmTC4gITM_Q.Value"), function () {
return OS$BuiltinFunctions.integerToText(OS$BuiltinFunctions.textToInteger(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).articleNumberAttr));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).articleNumberAttr;
}),
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("WFUL2QoRZEOD+Z9LHpvR6w.Style"), function () {
return (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr) ? ("borderred") : (""))) : ("display-none"));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr;
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr;
}),
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).pEPAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "167"
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
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).pEPAttr, function (value) {
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).pEPAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PEP"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}), createElement(CloneOfDebounce_DebounceFlow_Debounce_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
DebounceDelay: 1000,
WidgetId: idService.getId("Input_PEP")
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
uuid: "169",
alias: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("jWW1IPvIkke90LzL0hp9VQ.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr;
}),
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr), asPrimitiveValue(model.variables.l_IsApplyToAllVar)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "171"
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
OptionalConfigs: model.getCachedValue(idService.getId("RgtmAQEQ_kWun2MPVyk_7g.OptionalConfigs"), function () {
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
uuid: "172",
alias: "38"
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
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("tG6_0QFiB0698gRSv9kQmw#Value.1002767249.1", "Select a date"),
autoComplete: "off"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
style: "form-control ",
variable: model.createVariable(OS$DataTypes.DataTypes.Date, model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr, function (value) {
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_DeliveryDateLine"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryDateAttr)]
})];
}, function () {
return [createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("qHs5sHPUSkGSduWn1o76Dw.Value"), function () {
return ((model.variables.deliveryDateVar.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.formatDateTime(model.variables.deliveryDateVar, "dd/MM/yyyy")));
}, function () {
return model.variables.deliveryDateVar;
}),
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("syILywcNKkqC+93UbKTU6g.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr;
}),
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "176"
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
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr, function (value) {
model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr = value;
}),
_idProps: {
service: idService,
name: "Input_InvoiceQtt"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}), createElement(InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SuffixText: "",
DecimalSeparator: ".",
PrefixText: "",
UseNumericInput: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
RightAlign: false,
AlwaysShowDecimalDigits: true,
InputId: idService.getId("Input_InvoiceQtt"),
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
uuid: "178",
alias: "39"
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
DebounceDelay: 1000,
WidgetId: idService.getId("Input_InvoiceQtt")
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
uuid: "179",
alias: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Expression, {
style: model.getCachedValue(idService.getId("vIIRpMj2NE2iSfjzUQkkbw.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr),
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rhwxyc_VYEKo3dmvwDrBJQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
style: model.getCachedValue(idService.getId("OD1HV00HlEujLrW8FnAXRw.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("rpYRQptTyEubPCenEchlpQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr.div(OS$BuiltinFunctions.integerToDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr)).times(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr), 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr;
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr;
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "187"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "192"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryQttAttr,
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "196"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Oe5JEeAmHEW800VVpHmaaQ.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr;
}),
_idProps: {
service: idService,
uuid: "197"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "198"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeOnClick$Action(model.variables.localSelectedLinesIn.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "199"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "200"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-top: 200px;"
},
visible: true,
_idProps: {
service: idService,
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesIn), asPrimitiveValue(model.variables.withDatesErrorVar), asPrimitiveValue(model.variables.withQuantityErrorVar), asPrimitiveValue(model.variables.creditNoteFilesListVar.length), asPrimitiveValue(model.variables.creditNote_IsNeededVar), asPrimitiveValue(model.variables.orderAccConceptsIdToCreateVar), asPrimitiveValue(model.variables.firstUserIdentifierVar), asPrimitiveValue(model.variables.datesQuantityPEPErrorVar), asPrimitiveValue(model.variables.withFilesErrorVar), asPrimitiveValue(model.variables.maxAmountErrorVar), asPrimitiveValue(model.variables.getSettingsDataAct.isForceForeignerOut), asPrimitiveValue(model.variables.filesListExtraVar), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.l_ImportAnticipoVar), asPrimitiveValue(model.variables.filesListVar.length), asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.approverErrorMessageVar), asPrimitiveValue(model.variables.approverValidVar), asPrimitiveValue(model.variables.getFirstApproverListDataAct.firstApproverListOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getFirstApproverListDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._aprovalProcessTypeIdInDataFetchStatus), asPrimitiveValue(model.variables.aprovalProcessTypeIdIn)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesIn), asPrimitiveValue(model.variables.withDatesErrorVar), asPrimitiveValue(model.variables.withQuantityErrorVar), asPrimitiveValue(model.variables.creditNoteFilesListVar.length), asPrimitiveValue(model.variables.creditNote_IsNeededVar), asPrimitiveValue(model.variables.orderAccConceptsIdToCreateVar), asPrimitiveValue(model.variables.firstUserIdentifierVar), asPrimitiveValue(model.variables.datesQuantityPEPErrorVar), asPrimitiveValue(model.variables.withFilesErrorVar), asPrimitiveValue(model.variables.maxAmountErrorVar), asPrimitiveValue(model.variables.filesListExtraVar), asPrimitiveValue(model.variables.l_ImportAnticipoVar), asPrimitiveValue(model.variables.filesListVar.length), asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.approverErrorMessageVar), asPrimitiveValue(model.variables.approverValidVar), asPrimitiveValue(model.variables.getFirstApproverListDataAct.firstApproverListOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.assignmentCodeAttr), asPrimitiveValue(model.variables.aprovalProcessTypeIdIn), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.getFirstApproverListDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables._aprovalProcessTypeIdInDataFetchStatus), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.isForceForeignerOut), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioCreate",
functionKey: "6ff4a332-3d3f-426f-8bfc-0e70a1d5a822",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioCreate",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioCreate.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, OutSystemsUI_Interaction_DropdownSearch_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_InvoiceSAECUpload_mvc_view, BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()
