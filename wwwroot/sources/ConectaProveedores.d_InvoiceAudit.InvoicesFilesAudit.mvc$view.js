import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Button as OSWidgets$Button, List as OSWidgets$List, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import OutSystemsUI_Content_Accordion_mvc_view from "./OutSystemsUI.Content.Accordion.mvc$view.js";
import OutSystemsUI_Content_AccordionItem_mvc_view from "./OutSystemsUI.Content.AccordionItem.mvc$view.js";
import ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvc_view from "./ConectaProveedores.d_InvoiceAudit.Wb_InvoiceFilesAudit.mvc$view.js";
import ModelFactory from "./ConectaProveedores.d_InvoiceAudit.InvoicesFilesAudit.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.d_InvoiceAudit.InvoicesFilesAudit.mvc$controller.js";
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
text: [$text(getTranslation("nIqTfcc2TUW5QLzAqIyGWw#Value", "Homepage"))],
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
text: [$text(getTranslation("eGt+equgW0iYIoc9N_N5XQ#Value", "Dashboard"))],
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
}), createElement(OSWidgets$Container, {
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
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("VamBg8W07kua+NsYHe2+3w#Value", "View and download invoice"))],
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("yZXSRP0tdES6XACg8dda5A#Value", "View and Download Invoices"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
name: "Filters"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_Width2"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setIsSaveAllFiles$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-edit",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("grlPjQ7OVUO_zaT+MIb0yA#Value", "Download all")), createElement(OSWidgets$Image, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getInvoicesDataAct.invoicesOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OutSystemsUI_Content_Accordion_mvc_view, {
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
uuid: "22",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-base",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_AccordionItem_mvc_view, {
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
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex justify-content-space-between margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
style: "bold",
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oCaaiQ+K0UCTX44LnxIr3A#ValueExpression.-670115059.1", "Invoice") + " ") + model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceNameAttr),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
style: "bold",
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("bgMs_afRZ0q2hh2qQbELww#ValueExpression.-946147.1", "Supplier Number") + ": ") + model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).supplierNrAttr),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
gridProperties: {
classes: "OSFillParent"
},
style: "bold",
value: model.getCachedValue(idService.getId("0kS9yNtXYUCO5RITDwNwNQ.Value"), function () {
return ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cA93+k+JeEiHErkS08Ke5w#ValueExpression.-1621719443.1", "Upload Date") + ": ") + OS$BuiltinFunctions.formatDateTime(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceUpdatedOnAttr, "dd MM yyyy"));
}, function () {
return model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceUpdatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
})))];
}),
customIcon: Widget.PlaceholderContent.Empty,
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsSaveSelectedFiles: model.variables.i_IsSaveSelectedFilesVar,
i_InvoiceName: model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceNameAttr,
_i_InvoiceNameInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr),
i_IsSaveAllFiles: model.variables.i_IsSaveAllFilesVar,
i_InvoiceId: model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceIdAttr,
_i_InvoiceIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
afterSaveAllFiles$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setIsSaveAllFiles$Action(controller.callContext(eventHandlerContext));

;
},
afterSaveSelectedFiles$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setIsSaveSelectedFiles$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "32",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_IsSaveAllFilesVar), asPrimitiveValue(model.variables.i_IsSaveSelectedFilesVar), asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceIdAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceUpdatedOnAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).supplierNrAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceNameAttr)]
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_IsSaveAllFilesVar), asPrimitiveValue(model.variables.i_IsSaveSelectedFilesVar), asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceIdAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceUpdatedOnAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).supplierNrAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut.getCurrent(callContext.iterationContext).invoiceNameAttr)]
})];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.i_IsSaveAllFilesVar), asPrimitiveValue(model.variables.i_IsSaveSelectedFilesVar), asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr)]
})))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.i_IsSaveAllFilesVar), asPrimitiveValue(model.variables.i_IsSaveSelectedFilesVar), asPrimitiveValue(model.variables.getInvoicesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesDataAct.invoicesOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "InvoicesFilesAudit",
functionKey: "74ed6ddc-1973-4e76-8c53-ca571b2d2435",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "d_InvoiceAudit.InvoicesFilesAudit",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.d_InvoiceAudit.InvoicesFilesAudit.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Content_Accordion_mvc_view, OutSystemsUI_Content_AccordionItem_mvc_view, ConectaProveedores_d_InvoiceAudit_Wb_InvoiceFilesAudit_mvc_view];
};


return ELEM;
};

export default componentFactory()
