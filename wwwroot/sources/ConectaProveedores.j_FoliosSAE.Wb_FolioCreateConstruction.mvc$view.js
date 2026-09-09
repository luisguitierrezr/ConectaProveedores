import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure, ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Form as OSWidgets$Form, Switch as OSWidgets$Switch, Label as OSWidgets$Label, Input as OSWidgets$Input, TextArea as OSWidgets$TextArea, Expression as OSWidgets$Expression, Dropdown as OSWidgets$Dropdown, Icon as OSWidgets$Icon, Checkbox as OSWidgets$Checkbox, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Image as OSWidgets$Image, Link as OSWidgets$Link } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes, DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$view.js";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_datePickerTimeFormat as ConectaProveedores_staticEntities_datePickerTimeFormat, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_Columns3_mvc_view from "./OutSystemsUI.Adaptive.Columns3.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FlowOptions.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import CloneOfDebounce_DebounceFlow_Debounce_mvc_view from "./CloneOfDebounce.DebounceFlow.Debounce.mvc$view.js";
import { ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure } from "./ConectaProveedores.model.js";
import ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstruction_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.mvc$view.js";
import OutSystemsUI_Utilities_Separator_mvc_view from "./OutSystemsUI.Utilities.Separator.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.mvc$controller.js";

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
OptionalConfigs: model.getCachedValue(idService.getId("KZ8cO9hG9EqLVESGwq4eig.OptionalConfigs"), function () {
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
return [$text(getTranslation("rd6chnUm3keCzpeVfwRGFQ#Value", "Payment Information"))];
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
return [$text(getTranslation("nw1Ob6qEAUSpwu+S73BqBw#Value", "Crear Solicitud"))];
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
title: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9Lmk7XA230akgXaLacRZjw#Value.-1831639823.1", "Construction")
},
style: "display font-size-sub-heading",
text: [$text(getTranslation("u0Fui835_0SiD6+CyPrczw#Value", "Details"))],
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
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.getCachedValue(idService.getId("2qayyqRNVkmJK7WOo_5PPw.i_FolioId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}),
i_ApplicantId: model.variables.applicantIdIn,
_i_ApplicantIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._applicantIdInDataFetchStatus),
i_MandatoryError: model.variables.withApprovalProcessErrorVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
approvalProcessSelected$Action: function (i_ApprovaProcessIdSelectedIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_FlowOptionsApprovalProcessSelected$Action(i_ApprovaProcessIdSelectedIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService,
validationParentId: idService.getId("Form")
},
_idProps: {
service: idService,
uuid: "18",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-m margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "19"
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
uuid: "20",
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
text: [$text(getTranslation("MjJWZAku4UGaWIjgm9mzZw#Value", "Apply to all lines"))],
_idProps: {
service: idService,
uuid: "22"
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
uuid: "23"
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1frpqtxbSkyf0DzEJa75Ag#Value", "Delivery Date"))), createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("DatePicker.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
rec.maxDateAttr = OS$BuiltinFunctions.currDate();
return rec;
}();
}),
DateFormat: "DD/MM/YYYY",
TimeFormat: ConectaProveedores_staticEntities_datePickerTimeFormat.disabled
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
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VZJqAUiuZU6ECqegU6lFrw#Value.1002767249.1", "Select a date"),
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
uuid: "27"
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
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("+TJc32sAYEaAc1W_gNGvgQ#Value", "Comments and Observations"))],
_idProps: {
service: idService,
uuid: "30"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("uCHXosVwfkyZ4k4thNaR0A#ValueExpression.1497638985.1", "Comments or Observations. If you have a CREDIT NOTE, please provide: Number and amount; otherwise, indicate N/A."),
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
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("1wAqb4CSPU+sRJEKTL9jgA.Value"), function () {
return ((OS$BuiltinFunctions.length(model.variables.commentsVar)).toString() + "/1000");
}, function () {
return model.variables.commentsVar;
}),
_idProps: {
service: idService,
uuid: "33"
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
uuid: "34"
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
OptionalConfigs: model.getCachedValue(idService.getId("Wb1zUsCHjUCxB7nsf1+6aA.OptionalConfigs"), function () {
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
uuid: "35",
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
uuid: "36",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("mtl39XnAPEu0Yns66ccIdw#Value", "Summary"))];
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
uuid: "37",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("eBsXmuIvZ06l4CXHEwZ7qQ#Value", "Partial Delivery"))];
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
uuid: "38",
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
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lLQrNzDl4EWpdZFLE9hHpA#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "42"
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
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount"),
UseNumericInput: true,
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
uuid: "43",
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
uuid: "44"
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
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0cdvjvd_EEGK_KkUwU1LCg#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "47"
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
InputId: idService.getId("Input_TotalAmount2"),
GroupSeparator: ",",
DecimalSeparator: ".",
PrefixText: "",
SuffixText: "",
AlwaysShowDecimalDigits: true,
RightAlign: false,
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
uuid: "48",
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
uuid: "49"
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
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GDsVaqS5m0SxLe1sXm_lLw#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "52"
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
SuffixText: "",
RightAlign: false,
PrefixText: "",
InputId: idService.getId("Input_TotalAmount3"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
DecimalSeparator: ".",
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
uuid: "53",
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
uuid: "54"
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
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OiP5aHUIVkasJoKJ0LnWWw#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
uuid: "57"
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
UseNumericInput: true,
GroupSeparator: ",",
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount4"),
RightAlign: false,
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
uuid: "58",
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
uuid: "59"
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
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oKHL2oS5FEK5gxIvLaiHvQ#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
uuid: "62"
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
UseNumericInput: true,
InputId: idService.getId("Input_InvoicingAmount"),
GroupSeparator: ",",
AlwaysShowDecimalDigits: true,
PrefixText: "",
RightAlign: false,
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
uuid: "63",
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
uuid: "64",
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
uuid: "65"
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
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+qg5tWX6B0S5ADGzr5KKLw#Value", "Total Amount"))), createElement(OSWidgets$Input, {
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
uuid: "68"
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
UseNumericInput: true,
PrefixText: "",
InputId: idService.getId("Input_TotalAmount5"),
GroupSeparator: ",",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
RightAlign: false,
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
uuid: "69",
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
uuid: "70"
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
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0L47Wf0krkKXV9ahLqkgUg#Value", "Amount Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "73"
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
InputId: idService.getId("Input_TotalAmount8"),
RightAlign: false,
GroupSeparator: ",",
DecimalSeparator: ".",
UseNumericInput: true,
PrefixText: "",
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
uuid: "74",
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
uuid: "75"
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
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("196jiqXPEECTt66ujQYRFQ#Value", "Percentage Delivered"))), createElement(OSWidgets$Input, {
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
uuid: "78"
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
SuffixText: "",
RightAlign: false,
PrefixText: "",
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
GroupSeparator: ",",
InputId: idService.getId("Input_TotalAmount9"),
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
uuid: "79",
alias: "24"
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
targetWidget: "Input_TotalAmount10",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5olva1O_iEie9uPJ3LlQsw#Value", "Amount left"))), createElement(OSWidgets$Input, {
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
DecimalSeparator: ".",
SuffixText: "",
PrefixText: "",
InputId: idService.getId("Input_TotalAmount10"),
GroupSeparator: ",",
RightAlign: false,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
AlwaysShowDecimalDigits: true,
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
uuid: "85"
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
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("XuB0PdsTkk24ICTrBa0Y7A#Value", "Invoice amount (subtotal)"))), createElement(OSWidgets$Input, {
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
uuid: "88"
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
UseNumericInput: false,
SuffixText: "",
PrefixText: "",
InputId: idService.getId("Input_PartialDeliveryAmount"),
GroupSeparator: ",",
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
uuid: "89",
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
uuid: "90",
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
uuid: "91"
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
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7NPwohnUXE+PL6A9JKfDug#Value", "Invoicing Amount"))), createElement(OSWidgets$Input, {
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
InputId: idService.getId("Input_InvoicingAmount2"),
UseNumericInput: true,
GroupSeparator: ",",
PrefixText: "",
RightAlign: false,
SuffixText: "",
AlwaysShowDecimalDigits: true,
DecimalSeparator: ".",
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
uuid: "96"
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
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1NCFw+Xe7U2_4sP2_zB4xA#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
DecimalSeparator: ".",
InputId: idService.getId("Input_TotalAmount6"),
RightAlign: false,
AlwaysShowDecimalDigits: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
SuffixText: "",
UseNumericInput: true,
PrefixText: "",
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
alias: "29"
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
targetWidget: "Input_TotalAmount7",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Hq6Rdf2B0k6IhNy2U6HtzQ#Value", "Difference_SAE_Invoice"))), createElement(OSWidgets$Input, {
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
uuid: "104"
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
UseNumericInput: true,
InputId: idService.getId("Input_TotalAmount7"),
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(2),
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
uuid: "105",
alias: "30"
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
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s os-boxlabel",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("xO32zPbiQUe+OPJ5NaRbsA#Value", "Concept of the Minutes"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
emptyValue: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hReqf1l2p0WHBB9y4A56nw#ValueExpression.-1165887790.1", "Select One Minute"),
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
})), $if(((model.variables.minuteSelectedVar) !== (0)), false, this, function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstruction_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsUpdate: false,
OrderNumber: model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr,
_orderNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderDetailAggr.dataFetchStatusAttr),
List: model.getCachedValue(idService.getId("Cf8gVH3vNkqiw3aFzoGctQ.List"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getMinutesDocumentsDataAct.listOut, new (OS$GenericTypeCache.getGenericList(ST_e2ce4ef6ecd16e4be5db908d06bb6674Structure))(), function (source, target) {
target.keyAttr = source.keyAttr;
target.valueAttr = source.valueAttr;
target.fileNameAttr = source.fileNameAttr;
target.mandatoryAttr = source.mandatoryAttr;
target.withDocumentAttr = source.withDocumentAttr;
return target;
});
}, function () {
return model.variables.getMinutesDocumentsDataAct.listOut;
}),
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
uuid: "110",
alias: "31"
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
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "112"
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
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "info-circle",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "114"
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
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("Q18S+7cSHkO6ow123Om6rg#Value", "If you have a credit note / voucher or advance amortization,enter the indicated amount excluding VAT."))],
_idProps: {
service: idService,
uuid: "116"
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
uuid: "117",
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
uuid: "118"
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
uuid: "119"
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
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("nfDSCz26XEiC3wkZRx1idg.Style"), function () {
return ((model.variables.constructionStructVar.advPaymentAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.advPaymentAttr;
}),
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("lo0cmt3_3kaUM0aqEuqqOA#Value", "Advance repayment"))), createElement(OSWidgets$Input, {
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
uuid: "124"
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
GroupSeparator: ",",
DecimalSeparator: ".",
AlwaysShowDecimalDigits: true,
UseNumericInput: true,
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
InputId: idService.getId("Input_AdvPaymentValue"),
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
uuid: "125",
alias: "33"
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
uuid: "126"
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
uuid: "127"
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
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("EPpWz406dkmND5znz_LGgA.Style"), function () {
return ((model.variables.constructionStructVar.creditNoteAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.creditNoteAttr;
}),
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("9O5laTXN80ycS7GIdUJ5LQ#Value", "Credit note"))), createElement(OSWidgets$Input, {
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
uuid: "132"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
UseNumericInput: true,
PrefixText: "",
AlwaysShowDecimalDigits: true,
SuffixText: "",
InputId: idService.getId("Input_CreditNoteValue"),
RightAlign: false,
GroupSeparator: ",",
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
uuid: "133",
alias: "34"
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
uuid: "134"
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
uuid: "135"
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
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("pFE8yamD9U224aPHKHM+qQ.Style"), function () {
return ((model.variables.constructionStructVar.voucherAttr) ? ("mandatory") : (""));
}, function () {
return model.variables.constructionStructVar.voucherAttr;
}),
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("v2W2KDjBHE+xITaa7yuhpw#Value", "Voucher"))), createElement(OSWidgets$Input, {
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
uuid: "140"
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
InputId: idService.getId("Input_VoucherValue"),
PrefixText: "",
GroupSeparator: ",",
UseNumericInput: true,
SuffixText: "",
RightAlign: false,
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
uuid: "141",
alias: "35"
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
uuid: "142"
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
uuid: "143"
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
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
}, "N/A")))];
})
},
_dependencies: [asPrimitiveValue(model.variables.constructionStructVar.nAAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherValueAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteValueAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentValueAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentAttr), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.listOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.getMinutesDataAct.keyValueListOut), asPrimitiveValue(model.variables.minuteSelectedVar), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.withApprovalProcessErrorVar), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getMinutesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._applicantIdInDataFetchStatus), asPrimitiveValue(model.variables.applicantIdIn)]
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
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
title: model.getCachedValue(idService.getId("ljO74vWhiEK6w7cufh_dPg.title"), function () {
return ((((((((((((((((((((((("FilesListExtra.Empty = False " + (((!(model.variables.filesListExtraVar.isEmpty))) ? ("True") : ("False"))) + "\r\n") + "WithFilesError = False ") + (((!(model.variables.withFilesErrorVar))) ? ("True") : ("False"))) + "\r\n") + "MaxAmountError = False ") + (((!(model.variables.maxAmountErrorVar))) ? ("True") : ("False"))) + "\r\n") + "l_ApprovalProcessId <> NullIdentifier() ") + ((!(model.variables.l_ApprovalProcessIdVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) ? ("True") : ("False"))) + "\r\n") + "MinuteSelected <> 0 ") + ((((model.variables.minuteSelectedVar) !== (0))) ? ("True") : ("False"))) + "\r\n") + "If(AdvPayment) ") + ((((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n") + "If(CreditNote) ") + ((((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n") + "If(Voucher) ") + ((((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) ? ("True") : ("False"))) + "\r\n");
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.l_ApprovalProcessIdVar;
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
uuid: "147"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Button, {
enabled: model.getCachedValue(idService.getId("8z37aZzwUUChnBW1b5XBlw.Enabled"), function () {
return ((((((((model.variables.filesListExtraVar.isEmpty === false) && (model.variables.withFilesErrorVar === false)) && (model.variables.maxAmountErrorVar === false)) && !(model.variables.l_ApprovalProcessIdVar.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))) && ((model.variables.minuteSelectedVar) !== (0))) && ((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true))) && ((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true)));
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.l_ApprovalProcessIdVar;
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
}),
extendedProperties: {
title: model.getCachedValue(idService.getId("8z37aZzwUUChnBW1b5XBlw.title"), function () {
return (((((((((((((("FilesListExtra.Empty:" + (model.variables.filesListExtraVar.isEmpty ? "True" : "False")) + "\r\n") + "WithFilesError:") + (model.variables.withFilesErrorVar ? "True" : "False")) + "\r\n") + "MaxAmountError") + (model.variables.maxAmountErrorVar ? "True" : "False")) + "\r\n") + "l_ApprovalProcessId <> NullIdentifier():") + OS$BuiltinFunctions.longIntegerToText(model.variables.l_ApprovalProcessIdVar))) !== (((((((((((((((((OS$BuiltinFunctions.nullIdentifier()).toString() + "\r\n") + "MinuteSelected <> 0:") + (((model.variables.minuteSelectedVar) !== (0)) ? "True" : "False")) + "\r\n") + "If(ConstructionStruct.AdvPayment,ConstructionStruct.AdvPaymentValue <> 0, True):") + (((model.variables.constructionStructVar.advPaymentAttr) ? (!(model.variables.constructionStructVar.advPaymentValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true)) ? "True" : "False")) + "\r\n") + "If(ConstructionStruct.CreditNote,ConstructionStruct.CreditNoteValue <> 0, True):") + (((model.variables.constructionStructVar.creditNoteAttr) ? (!(model.variables.constructionStructVar.creditNoteValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true)) ? "True" : "False")) + "\r\n") + "If(ConstructionStruct.Voucher,ConstructionStruct.VoucherValue <> 0, True):") + (((model.variables.constructionStructVar.voucherAttr) ? (!(model.variables.constructionStructVar.voucherValueAttr.equals(OS$BuiltinFunctions.integerToDecimal(0)))) : (true)) ? "True" : "False")) + "\r\n") + "DatesQuantityError = False") + (model.variables.datesQuantityPEPErrorVar ? "True" : "False")))) === false) ? "True" : "False");
}, function () {
return model.variables.filesListExtraVar.isEmpty;
}, function () {
return model.variables.withFilesErrorVar;
}, function () {
return model.variables.maxAmountErrorVar;
}, function () {
return model.variables.l_ApprovalProcessIdVar;
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
return model.variables.datesQuantityPEPErrorVar;
})
},
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
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("G3O2rp1cZUqs_sOnJ4L6TQ#Value", "Create Folio")))), $if(model.variables.withQuantityErrorVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "error",
visible: true,
_idProps: {
service: idService,
uuid: "149"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3FrejXCoZ0SJISS2+YsTYg#Value", "There are fields with missing or incorrect amount, please review")))];
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
uuid: "150"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("X3eE1tIhU0S71pHG5KZnUg#Value", "There are fields without delivery date, please review")))];
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
uuid: "151"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yV1bp829qECQipIwdBRCoA#Value", "There are no files, please review it")))];
}, function () {
return [];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "summary-container margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "152"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "153"
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
uuid: "154",
alias: "36"
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
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VVT5u9pWnkOuf5T2WbylhA#Value", "Position"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "158"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("PcIivgHMp0mU3Fz_IOTaqQ#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "159"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Wmg0wfacbESYeeS0Sla8Fw#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "160"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("+CdDALNqTEKUxev9Frl6cw#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("I5S7snKuFUGD5I_JxzSReQ#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
style: model.getCachedValue(idService.getId("kandQpBohU6W6o07WhqOeg.Style"), function () {
return (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? ("") : ("display-none"));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr;
}),
_idProps: {
service: idService,
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
_dependencies: []
}, "PEP Element"), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("VzGM7dLOzkiK82Vf1Amljw#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("0sKFDSwKOk6B2FM1DwCRwQ#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mdmev4xI9k6n0cVCgZt8cw#Value", "Remaining Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "166"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dj5Ww+DLBUu_UwErPMbSYw#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZoMeKWm+j0SVFTFmdNpxnA#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "168"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jzif0Pz3yEejhm9dtQepJg#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "BaseQuantity",
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_Tne+9X1BE2mPOIh2cdNCw#Value", "By"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SrguoRxlK06TIIPDfhEbUA#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "171"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("YUkuDxIOnE6sHVSZS2wjEA#Value", "Import delivery"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "173"
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
uuid: "174",
alias: "37"
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
uuid: "175"
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
uuid: "176"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).positionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).positionAttr,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "178"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).orderNumberAttr,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).articleNumberAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "181"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).articleNumberAttr,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "183"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).descriptionAttr,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr,
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("fiFEKrv6o0a3PfRVPz86yQ.Style"), function () {
return (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr === "Q")) ? (((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr) ? ("borderred") : (""))) : ("display-none"));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).inputationCodeAttr;
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isPEPErrorAttr;
}),
_idProps: {
service: idService,
uuid: "187"
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
uuid: "188"
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
uuid: "190",
alias: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("USlXZDfAWkSvF+yBvXtRlw.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isDateErrorAttr;
}),
_idProps: {
service: idService,
uuid: "191"
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
uuid: "192"
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
OptionalConfigs: model.getCachedValue(idService.getId("WUFMs0cCnkatsTvqrX_+uA.OptionalConfigs"), function () {
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
uuid: "193",
alias: "39"
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
"aria-label": OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("HRn9UkSwXkiJ6ZOx3LSoPQ#Value.1002767249.1", "Select a date"),
autoComplete: "off"
},
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Date*/ 4,
mandatory: false,
maxLength: 0,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.validateDatesInvoiceQttPEP$Action(controller.callContext(eventHandlerContext));

;
},
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
value: model.getCachedValue(idService.getId("NoHbjlxVmkCEVIst+mSRhg.Value"), function () {
return ((model.variables.deliveryDateVar.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.formatDateTime(model.variables.deliveryDateVar, "dd/MM/yyyy")));
}, function () {
return model.variables.deliveryDateVar;
}),
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
style: model.getCachedValue(idService.getId("IQqPA5fcf02Ba1jeVsQZ4g.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr) ? ("borderred") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).isInvoiceErrorAttr;
}),
_idProps: {
service: idService,
uuid: "196"
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
uuid: "197"
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
style: "form-control only-positive",
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
DecimalDigits: OS$BuiltinFunctions.integerToDecimal(3),
DecimalSeparator: ".",
UseNumericInput: false,
InputId: idService.getId("Input_InvoiceQtt"),
RightAlign: false,
PrefixText: "",
SuffixText: "",
AlwaysShowDecimalDigits: true,
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
uuid: "199",
alias: "40"
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
uuid: "200",
alias: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "201"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Expression, {
style: model.getCachedValue(idService.getId("oC1W3AZp1EiV3Aa_sk3ujQ.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr),
_idProps: {
service: idService,
uuid: "202"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus),
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "203"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "204"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("ch_RfMaCnUyCh+O+cSQFXw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr, 2, ".", ",");
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "205"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "206"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).unitPriceAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).invoiceQttAttr), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
style: model.getCachedValue(idService.getId("t9Haduq3gkCMIeYYesiDbA.Style"), function () {
return ((model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr.lt(OS$BuiltinFunctions.integerToDecimal(0))) ? ("text-red") : (""));
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).remainingQttAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "207"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("ZEBM6E4veE2PPCZ3mtXi0Q.Value"), function () {
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
uuid: "208"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "209"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "210"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).quantityAttr),
_idProps: {
service: idService,
uuid: "211"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "212"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "213"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).baseQuantityAttr).toString(),
_idProps: {
service: idService,
uuid: "214"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "215"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).deliveryQttAttr,
_idProps: {
service: idService,
uuid: "216"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "217"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("3FB+ZjecO028LrBONYg0Mw.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr, 3, ".", ",");
}, function () {
return model.variables.localSelectedLinesIn.getCurrent(callContext.iterationContext).importdeliveryAttr;
}),
_idProps: {
service: idService,
uuid: "218"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._localSelectedLinesInDataFetchStatus)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "219"
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
uuid: "220"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "221"
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
uuid: "222"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesIn), asPrimitiveValue(model.variables.withDatesErrorVar), asPrimitiveValue(model.variables.withQuantityErrorVar), asPrimitiveValue(model.variables.datesQuantityPEPErrorVar), asPrimitiveValue(model.variables.l_ApprovalProcessIdVar), asPrimitiveValue(model.variables.maxAmountErrorVar), asPrimitiveValue(model.variables.withFilesErrorVar), asPrimitiveValue(model.variables.filesListExtraVar.isEmpty), asPrimitiveValue(model.variables.constructionStructVar.nAAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherValueAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteValueAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentValueAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentAttr), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.listOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.getMinutesDataAct.keyValueListOut), asPrimitiveValue(model.variables.minuteSelectedVar), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.withApprovalProcessErrorVar), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getMinutesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._applicantIdInDataFetchStatus), asPrimitiveValue(model.variables.applicantIdIn)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.localSelectedLinesIn), asPrimitiveValue(model.variables.withDatesErrorVar), asPrimitiveValue(model.variables.withQuantityErrorVar), asPrimitiveValue(model.variables.datesQuantityPEPErrorVar), asPrimitiveValue(model.variables.l_ApprovalProcessIdVar), asPrimitiveValue(model.variables.maxAmountErrorVar), asPrimitiveValue(model.variables.withFilesErrorVar), asPrimitiveValue(model.variables.filesListExtraVar.isEmpty), asPrimitiveValue(model.variables.constructionStructVar.nAAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherValueAttr), asPrimitiveValue(model.variables.constructionStructVar.voucherAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteValueAttr), asPrimitiveValue(model.variables.constructionStructVar.creditNoteAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentValueAttr), asPrimitiveValue(model.variables.constructionStructVar.advPaymentAttr), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.listOut), asPrimitiveValue(model.variables.getOrderDetailAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderNumberAttr), asPrimitiveValue(model.variables.getMinutesDataAct.keyValueListOut), asPrimitiveValue(model.variables.minuteSelectedVar), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_AmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.difference_FormSAE_Invoice_PercentAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.partialDeliveryAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.invoicingAmountAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountLeftAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.percentageDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.amountDeliveredAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.currencyAttr), asPrimitiveValue(model.variables.l_SummaryRecVar.totalAmountAttr), asPrimitiveValue(model.variables.commentsVar), asPrimitiveValue(model.variables.deliveryDateVar), asPrimitiveValue(model.variables.l_IsApplyToAllVar), asPrimitiveValue(model.variables.withApprovalProcessErrorVar), asPrimitiveValue(model.variables.applicantIdIn), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables._localSelectedLinesInDataFetchStatus), asPrimitiveValue(model.variables.getMinutesDocumentsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderDetailAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getMinutesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._applicantIdInDataFetchStatus), asPrimitiveValue(model.variables._i_OrderIdInDataFetchStatus), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_FolioCreateConstruction",
functionKey: "fd1981f3-1dbf-4468-8a50-f4f83a4442d7",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_FolioCreateConstruction",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_FolioCreateConstruction.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view, OutSystemsUI_Adaptive_Columns3_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FlowOptions_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view, CloneOfDebounce_DebounceFlow_Debounce_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_UploadDocumentsConstruction_mvc_view, OutSystemsUI_Utilities_Separator_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()
