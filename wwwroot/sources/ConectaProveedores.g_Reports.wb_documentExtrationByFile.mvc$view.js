import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Popup as OSWidgets$Popup, Image as OSWidgets$Image, RadioGroup as OSWidgets$RadioGroup, RadioButton as OSWidgets$RadioButton, Upload as OSWidgets$Upload, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Button as OSWidgets$Button, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Checkbox as OSWidgets$Checkbox } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { Navigation as OS$Navigation, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view from "./ConectaProveedores.g_Reports.Wb_PreviewFile.mvc$view.js";
import ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view from "./ConectaProveedores.s_Storage.wb_DownloadFile.mvc$view.js";
import ModelFactory from "./ConectaProveedores.g_Reports.wb_documentExtrationByFile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.g_Reports.wb_documentExtrationByFile.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-s",
visible: true,
_idProps: {
service: idService,
uuid: "0"
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
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openPopup$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RMjNeyhY1EehbK76PPlIyg#Value", "Download Templates"))), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showdownloadPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "4"
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
uuid: "5",
alias: "1"
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
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UasrFjgr7k6hIMmWUbVHBA#Value", "Download Templates"))), createElement(OSWidgets$Container, {
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
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplates$Action(1, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("M5uLL3bDH0aZ+eYeaBOSTg#Value", "Template for Provider")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplates$Action(2, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("rUhNGgtp50+q1E9aEtnxog#Value", "Template for UUID")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplates$Action(3, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qFJEPr_83UmVjGIXAmUihQ#Value", "Template for Date Ranges")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplates$Action(4, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("9x7kEl_7QEKo8k3TO3XtrQ#Value", "Template for Period")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadTemplates$Action(5, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("GmjnH97Lg0q7sQbneoIWUQ#Value", "Template for Accounts")))))), createElement(OSWidgets$RadioGroup, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "radio-group",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.selectionVar, function (value) {
model.variables.selectionVar = value;
}),
_idProps: {
service: idService,
name: "RadioGroup2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$RadioButton, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
style: "radio-button",
value: "1",
visible: true,
_idProps: {
service: idService,
name: "RadioButton6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("l5xZp4xdfUefND2ECxcxSQ#Value", "Find by Suppliers"))), createElement(OSWidgets$RadioButton, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
style: "radio-button",
value: "2",
visible: true,
_idProps: {
service: idService,
name: "RadioButton7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("dJ_+ZlI63UOqFUZml3Os7A#Value", "Find by UUID"))), createElement(OSWidgets$RadioButton, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
style: "radio-button",
value: "3",
visible: true,
_idProps: {
service: idService,
name: "RadioButton8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("QDB3JPgf_0+QqHQEKXb_OA#Value", "Find by Dates"))), createElement(OSWidgets$RadioButton, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
style: "radio-button",
value: "4",
visible: true,
_idProps: {
service: idService,
name: "RadioButton9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LHN9UHZkxU+aZmLgBc4Peg#Value", "Find by Request"))), createElement(OSWidgets$RadioButton, {
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
style: "radio-button",
value: "5",
visible: true,
_idProps: {
service: idService,
name: "RadioButton10"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Vczulo_ceUmlaqjpvMz_sA#Value", "Find by Spend Account")))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width8"
},
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Upload, {
_validationProps: {
validationService: validationService
},
accept: /*Any*/ 2,
fileContent: model.createVariable(OS$DataTypes.DataTypes.BinaryData, model.variables.binaryDataVarVar, function (value) {
model.variables.binaryDataVarVar = value;
}),
fileName: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.textVarVar, function (value) {
model.variables.textVarVar = value;
}),
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "upload",
_idProps: {
service: idService,
name: "Upload1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "paperclip",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
value: model.getCachedValue(idService.getId("J2rNY1dIYUWEY22Jy2kB4A.Value"), function () {
return (((model.variables.textVarVar === "")) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TqVwQTyNZ06VJSFHw4bC3A#ValueExpression.1824724480.1", "Select file")) : (model.variables.textVarVar));
}, function () {
return model.variables.textVarVar;
}),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.findOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("sOAC49OduU2_9JucfrdMcA#Value", "Load"))), createElement(ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ForceRefresh: model.variables.forceRefreshVar,
StorageId: model.variables.storageIdVar
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
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(((!(model.variables.outputListVar.isEmpty)) && (model.variables.returnVar.messageAttr === "")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isSelectOneVar, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadAll$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "download",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #a6a8aa;"
},
icon: "download",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.outputListVar,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "37"
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "SupplierName",
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("8MJmfrxp0kulaevADs13KQ#Value", "Suplplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "InvoiceName",
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("fXx9dEEUckmbn2YgtraW6Q#Value", "Invoice Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "RequisitionName",
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("dzWNRjCCtEqK5nse72H_lA#Value", "Requisition"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "TotalAmount",
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gzlKZWS1zEmcOve+u6nj2g#Value", "Total Amount"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Currency",
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Bq1Vjk2tLEq1pbrcqyfnng#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, "UUID"), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Filename",
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nnouQG9npkGYSB3sbanbmA#Value", "Filename"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "CreateOn",
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("gCvAYzVacE2TM82zvASf5g#Value", "Created On"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "AccountDate",
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("sMpLV1JhcEOQjN4iCvjnnw#Value", "Account Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hxpCZnE+kUqvVceKOGzGug#Value", "Options")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).selectAttr)]
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectLines$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.outputListVar.getCurrent(callContext.iterationContext).selectAttr, function (value) {
model.variables.outputListVar.getCurrent(callContext.iterationContext).selectAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).supplierNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).supplierNameAttr,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).invoiceNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).invoiceNameAttr,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).requisitionNameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).requisitionNameAttr,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).totalAmountAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Unno9WKmf06pi4IkGz8O0Q.Value"), function () {
return OS$BuiltinFunctions.formatDecimal(model.variables.outputListVar.getCurrent(callContext.iterationContext).totalAmountAttr, 2, ".", ",");
}, function () {
return model.variables.outputListVar.getCurrent(callContext.iterationContext).totalAmountAttr;
}),
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).currencyAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).currencyAttr,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).uUIdAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).uUIdAttr,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).filenameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.outputListVar.getCurrent(callContext.iterationContext).filenameAttr,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).createOnAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateTimeToText(model.variables.outputListVar.getCurrent(callContext.iterationContext).createOnAttr),
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).accountDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("hCcICKV+jE6pPchc+xg3kg.Value"), function () {
return ((model.variables.outputListVar.getCurrent(callContext.iterationContext).accountDateAttr.equals(OS$BuiltinFunctions.nullDate())) ? ("-") : (OS$BuiltinFunctions.dateToText(model.variables.outputListVar.getCurrent(callContext.iterationContext).accountDateAttr)));
}, function () {
return model.variables.outputListVar.getCurrent(callContext.iterationContext).accountDateAttr;
}),
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$RowCell, {
extendedProperties: {
style: "text-align: right;"
},
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).sizeAttr), asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).filenameAttr), asPrimitiveValue(model.variables.outputListVar.getCurrent(callContext.iterationContext).storageIdAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.selectFile$Action(model.variables.outputListVar.getCurrent(callContext.iterationContext).storageIdAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "eye",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_StorageId: model.variables.outputListVar.getCurrent(callContext.iterationContext).storageIdAttr,
i_Filename: model.variables.outputListVar.getCurrent(callContext.iterationContext).filenameAttr,
i_FileSize: model.variables.outputListVar.getCurrent(callContext.iterationContext).sizeAttr
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
start$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileStart$Action(controller.callContext(eventHandlerContext));

;
},
end$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_DownloadFileEnd$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "75",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "1_0")
},
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.variables.returnVar.messageAttr,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "wb_documentExtrationByFile",
functionKey: "ff0a77e1-879a-48f5-97e1-6160c53281b8",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "g_Reports.wb_documentExtrationByFile",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_g_Reports_Wb_PreviewFile_mvc_view, ConectaProveedores_s_Storage_wb_DownloadFile_mvc_view];
};


return ELEM;
};

export default componentFactory()
