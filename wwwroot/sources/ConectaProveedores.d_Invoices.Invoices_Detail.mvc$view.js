import { withBaseWebScreen, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetails.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsFiles.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsItems.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvc_view from "./ConectaProveedores.d_Invoices.Wb_i_InvoiceAccounting_Old.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsChat.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoiceDetailsHistory.mvc$view.js";
import ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvc_view from "./ConectaProveedores.d_Invoices.Wb_InvoicesEntra_Historic.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_Invoices.Invoices_Detail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_Invoices.Invoices_Detail.mvc$controller.js";
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_inicio2025.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link font-semi-bold",
text: [$text(getTranslation("oU4zGhiHKUGdc7KK3QUFTg#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Dashboard", {}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link ",
text: [$text(getTranslation("diWm8ATggUqJ6jQYQEDhuw#Value", "Dashboard"))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(model.variables.i_RequisitionIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("zFsQojV9o0ivpKpG0WCpxA#Value", "Invoices"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}),
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("d2L2k_RJyUS6lCEhTckxSw#Value", "Requisitions"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(true, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.i_RequisitionIdIn, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("6BmSBicRbU6cClwxPu4MpQ#Value", "Requisition Detail"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("wP7WDpC8t0enbwF0Xe4Idg#Value", "Invoice Detail"))],
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "display",
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("QBXgsvZ6OkybwV3AXfZKLQ#ValueExpression.-670115059.1", "Invoice") + " ") + model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "ContainerStatusTitle",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInitializationDataDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
i_Class: model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
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
uuid: "29",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "OSInline",
width: "auto",
marginLeft: "0"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.getInitializationDataDataAct.isProveedorOut)), false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "RequisitionDetail", {
i_IsUploadInvoice: OS$DataConversion.ServerDataConverter.to(false, {
dataType: OS$DataTypes.DataTypes.Boolean
}),
i_RequisitionId: OS$DataConversion.ServerDataConverter.to(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.requisitionIdAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading",
text: [$text(getTranslation("4LcMVj3rKUil544Ptj9Myg#Value", "Requisition"))],
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Icon, {
icon: "external-link",
iconSize: /*FontSize*/ 0,
style: "icon margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
})))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right position-absolute absolute-bottom-right",
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "italic text-align-right absolute-bottom",
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("aCR6qIourUm5XV5iJxseHw.Value"), function () {
return (model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr + ((((model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr) !== (""))) ? (((" (" + model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr) + ")")) : ("")));
}, function () {
return model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr;
}, function () {
return model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr;
}),
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("xIszhSnEm0uSgqc7Pk5Sbw.Value"), function () {
return ((((model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr) !== (""))) ? (((" (" + model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr) + ")")) : (""));
}, function () {
return model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr;
}),
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: ((model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr + " ") + model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr),
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.requisitionIdAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: model.getCachedValue(idService.getId("tvoM0KK2YUmsaQj8zf8sjg.ExtendedClass"), function () {
return ((model.variables.getInitializationDataDataAct.isProveedorOut) ? ("columns single-column") : (""));
}, function () {
return model.variables.getInitializationDataDataAct.isProveedorOut;
}),
_extendedClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
GutterSize: ConectaProveedores_staticEntities_gutterSize.base
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
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal,
OptionalConfigs: model.getCachedValue(idService.getId("nldO4IiSmEC_s30DJQ+QHA.OptionalConfigs"), function () {
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
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.tabsOnTabChange$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "47",
alias: "5"
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
name: "Details",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("Ze0Yfts9eEidih2IaBfQLw#Value", "Invoice Detail"))];
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
name: "Files",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("tzj+aslw9EOT8Z1+AofBQg#Value", "Files"))];
})
},
_dependencies: []
}), $if((model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX"), false, this, function () {
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
name: "Items",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("6imHnu+SN0aiddzVsWIomg#Value", "Invoice items"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if(model.variables.getInitializationDataDataAct.isUserCxpOut, false, this, function () {
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
name: "Acc",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("5D0sLP63wkyGdp_YJg1atQ#Value", "Accounting"))];
})
},
_dependencies: []
})];
}, function () {
return [];
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
name: "Chat",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("SAlPajkD3kC4LyI5ge9Gxg#Value", "Comments"))];
})
},
_dependencies: []
}), $if((!(model.variables.getInitializationDataDataAct.isProveedorOut)), false, this, function () {
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
name: "Hist",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("t0gXgCxalE6i+ANY9QcNbA#Value", "History"))];
})
},
_dependencies: []
})];
}, function () {
return [];
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
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Details2",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("UEfH1XLJT0mYxzK+Urm4Xg.Style"), function () {
return (((!(model.variables.getInitializationDataDataAct.isProveedorOut))) ? (".not-proveedor-content") : ("True"));
}, function () {
return model.variables.getInitializationDataDataAct.isProveedorOut;
}),
visible: true,
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
}, createElement(ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.i_InvoiceIdIn,
IsActiveUser: model.variables.getInitializationDataDataAct.isActiveUserOut,
_isActiveUserInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
i_RequisitionId: model.variables.i_RequisitionIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refreshHistory$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.refreshMainPageData$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "56",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveUserOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut)]
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Files2",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceName: model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr,
_i_InvoiceNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
i_InvoiceId: model.variables.i_InvoiceIdIn,
IsProveedor: model.variables.getInitializationDataDataAct.isProveedorOut,
_isProveedorInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
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
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr)]
}), $if((model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr === "MX"), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Items2",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.i_InvoiceIdIn
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
uuid: "60",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn)]
})];
}, function () {
return [];
}), $if(model.variables.getInitializationDataDataAct.isUserCxpOut, false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Acc2",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getInitializationDataDataAct.isActiveDEV_AccountingCeBeOut, false, this, function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsActiveUser: model.variables.getInitializationDataDataAct.isActiveUserOut,
_isActiveUserInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
IsCorp: model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut,
_isCorpInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr),
i_InvoiceId: model.variables.i_InvoiceIdIn,
SupplierNumber: model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_supplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
i_RequisitionId: model.variables.i_RequisitionIdIn
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
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsCorp: model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut,
_isCorpInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr),
i_InvoiceId: model.variables.i_InvoiceIdIn,
i_RequisitionId: model.variables.i_RequisitionIdIn,
IsActiveUser: model.variables.getInitializationDataDataAct.isActiveUserOut,
_isActiveUserInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr),
SupplierNumber: model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr,
_supplierNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInitializationDataDataAct.dataFetchStatusAttr)
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
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveUserOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveDEV_AccountingCeBeOut)]
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Chat2",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_InvoiceId: model.variables.i_InvoiceIdIn
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
uuid: "65",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn)]
}), $if((!(model.variables.getInitializationDataDataAct.isProveedorOut)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "padding-right-none"
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
name: "Hist2",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Refresh: model.variables.refreshInvoiceDetailsHistoryVar,
i_InvoiceId: model.variables.i_InvoiceIdIn
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
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.refreshInvoiceDetailsHistoryVar)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.refreshInvoiceDetailsHistoryVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveDEV_AccountingCeBeOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveUserOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isUserCxpOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if((!(model.variables.getInitializationDataDataAct.isProveedorOut)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RefreshWB: model.getCachedValue(idService.getId("_ua5I6KBmEuN3gcakq+RDA.i_RefreshWB"), function () {
return OS$BuiltinFunctions.currDateTime();
}),
i_InvoiceId: model.variables.i_InvoiceIdIn
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
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.refreshInvoiceDetailsHistoryVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.i_RequisitionIdIn), asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveDEV_AccountingCeBeOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveUserOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isUserCxpOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr)]
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.refreshInvoiceDetailsHistoryVar), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.isCorporativoCxPOut), asPrimitiveValue(model.variables.i_InvoiceIdIn), asPrimitiveValue(model.variables.getUserApplicationRolesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveDEV_AccountingCeBeOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isActiveUserOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isUserCxpOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isProveedorOut), asPrimitiveValue(model.variables.getInitializationDataDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).regionAttr.codeAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.paisAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.numberAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.n_ident_fis_1Attr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).supplierAttr.nameAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.classAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceStatusAttr.labelAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.requisitionIdAttr), asPrimitiveValue(model.variables.getInitializationDataDataAct.invoiceByIdOut.getCurrent(callContext.iterationContext).invoiceAttr.nameAttr), asPrimitiveValue(model.variables.i_RequisitionIdIn)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "Invoices_Detail",
functionKey: "d2a7dffb-04b3-4a78-9542-4af8de6bf575",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_Invoices.Invoices_Detail",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.d_Invoices.Invoices_Detail.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoiceDetails_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsFiles_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsItems_mvc_view, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_mvc_view, ConectaProveedores_d_Invoices_Wb_i_InvoiceAccounting_Old_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsChat_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoiceDetailsHistory_mvc_view, ConectaProveedores_d_Invoices_Wb_InvoicesEntra_Historic_mvc_view];
};


return ELEM;
};

export default componentFactory()
