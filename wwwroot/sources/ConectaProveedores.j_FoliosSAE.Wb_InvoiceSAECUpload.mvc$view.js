import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Label as OSWidgets$Label, List as OSWidgets$List, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Image as OSWidgets$Image, Popup as OSWidgets$Popup, Input as OSWidgets$Input, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view from "./ConectaProveedores.d_Invoices.wb_AccSelect.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_AnticipoImport_mvc_view from "./ConectaProveedores.y_Utils.Wb_AnticipoImport.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import { SE_size as ConectaProveedores_staticEntities_size, SE_color as ConectaProveedores_staticEntities_color } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import { ST_bc4abb4233d9ce894e855c520a20c76fStructure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Interaction_DatePicker_mvc_view from "./OutSystemsUI.Interaction.DatePicker.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view from "./InputMasks.InputMaskReactFlow.MaskCurrency.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUpload.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUpload.mvc$controller.js";

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
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
name: "Header3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("PBx8tbP+DEKJKYoJjfWe7g#Value", "Invoice Type"))],
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-bottom-s margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderMainID: model.variables.orderIdIn,
_orderMainIDInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._orderIdInDataFetchStatus),
IsEnable: true,
IsFromFolio: model.variables.isFromFolioIn,
_isFromFolioInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._isFromFolioInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
sendOrderAccConcept$Action: function (oFolioAccDataIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_FolioAccSelectSendOrderAccConcept$Action(oFolioAccDataIn, controller.callContext(eventHandlerContext));
});
;
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
_dependencies: []
}), $if(!(model.variables.accDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
extendedProperties: {
style: "color: #67686a; font-size: 14px;"
},
value: model.getCachedValue(idService.getId("ovNrw+L4EkKDXhgXFzCL2A.Value"), function () {
return (((OS$BuiltinFunctions.decimalToText(model.variables.accDataVar.ammountAttr) + " | ") + model.variables.accDataVar.currencyIDAttr) + ((!(model.variables.accDataVar.paymentDateAttr.equals(OS$BuiltinFunctions.nullDate()))) ? ((" | " + OS$BuiltinFunctions.dateToText(model.variables.accDataVar.paymentDateAttr))) : ("")));
}, function () {
return model.variables.accDataVar.ammountAttr;
}, function () {
return model.variables.accDataVar.currencyIDAttr;
}, function () {
return model.variables.accDataVar.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
}))), $if(model.variables.showTitleIn, false, this, function () {
return [createElement(OSWidgets$Container, {
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
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-sub-heading",
text: [$text(getTranslation("z9Ne8cozSUe9NOtIRr1hhQ#Value", "Invoice Upload"))],
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}), createElement(ConectaProveedores_y_Utils_Wb_AnticipoImport_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ImportAnticipo: model.variables.importAnticipoIn,
_importAnticipoInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._importAnticipoInDataFetchStatus)
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
uuid: "11",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "MainFiles"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FilesMaxSize: 5242880,
i_IsEnabled: model.getCachedValue(idService.getId("KnNsGgcnLEW7nO13LZuigg.i_IsEnabled"), function () {
return (model.variables.i_IsEnableIn && !(model.variables.accDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, function () {
return model.variables.i_IsEnableIn;
}, function () {
return model.variables.accDataVar.orderAccConceptIDAttr;
}),
_i_IsEnabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsEnableInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.customUploadOnFileChange$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "13",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
dropArea: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("XbpgHshVN0CPDcvpmVtVNw.Value"), function () {
return ((model.variables.getSupplierDataAct.isNationalOut) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dxmAPPl3IUm0VYzLdSj5AA#ValueExpression.-1981578035.1", "Attach Main Files (xml & pdf)")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dxmAPPl3IUm0VYzLdSj5AA#ValueExpression.-1652585721.1", "Attach Main File (pdf)")));
}, function () {
return model.variables.getSupplierDataAct.isNationalOut;
}),
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSupplierDataAct.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.filesListVar.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: model.getCachedValue(idService.getId("zIqS2WDTMk+HfVgda1s7ig.Style"), function () {
return (((model.variables.i_IsEnableIn && !(model.variables.accDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) ? ("text-neutral-9") : ("text-neutral-7"));
}, function () {
return model.variables.i_IsEnableIn;
}, function () {
return model.variables.accDataVar.orderAccConceptIDAttr;
}),
text: [$text(getTranslation("zIqS2WDTMk+HfVgda1s7ig#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsEnableInDataFetchStatus)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.filesListVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "20"
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
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
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
uuid: "22",
alias: "4"
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
uuid: "23"
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
i_Text: model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr,
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
uuid: "24",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeFromList$Action(model.variables.filesListVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: []
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("UbNdDqhtWUCRkqGutD5xlQ.style"), function () {
return ((model.variables.filesListVar.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.filesListVar.isEmpty;
})
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.accDataVar.orderAccConceptIDAttr), asPrimitiveValue(model.variables.i_IsEnableIn), asPrimitiveValue(model.variables.filesListVar), asPrimitiveValue(model.variables._i_IsEnableInDataFetchStatus), asPrimitiveValue(model.variables.getSupplierDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSupplierDataAct.isNationalOut)]
})), $if(model.variables.isUploadCreditNoteVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "CreditNote"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_IsEnabled: model.getCachedValue(idService.getId("9O2rDsG2V0y9puDPn8y1Cw.i_IsEnabled"), function () {
return (model.variables.i_IsEnableIn && !(model.variables.accDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))));
}, function () {
return model.variables.i_IsEnableIn;
}, function () {
return model.variables.accDataVar.orderAccConceptIDAttr;
}),
_i_IsEnabledInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsEnableInDataFetchStatus),
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.customUploadOnFileChangeCreditNote$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));
});
;
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
placeholders: {
dropArea: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
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
style: "mandatory",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("KcBEzz4n6EC3lnBfiGdTcQ#ValueExpression.1305281721.1", "Credit Note"),
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.creditNoteFilesListVar.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: model.getCachedValue(idService.getId("HaB1RdUnA0C3YNRd5WMXkw.Style"), function () {
return (((model.variables.i_IsEnableIn && !(model.variables.accDataVar.orderAccConceptIDAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))))) ? ("text-neutral-9") : ("text-neutral-7"));
}, function () {
return model.variables.i_IsEnableIn;
}, function () {
return model.variables.accDataVar.orderAccConceptIDAttr;
}),
text: [$text(getTranslation("HaB1RdUnA0C3YNRd5WMXkw#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsEnableInDataFetchStatus)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.creditNoteFilesListVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "37"
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.creditNoteFilesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral3,
Size: ConectaProveedores_staticEntities_size.small
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
alias: "7"
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
uuid: "40"
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
i_NChar: 20,
i_Text: model.variables.creditNoteFilesListVar.getCurrent(callContext.iterationContext).nameAttr
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
}), $if(true, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeFromListCreditNote$Action(model.variables.creditNoteFilesListVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.creditNoteFilesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "2")
},
_dependencies: []
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("UxKae5W1p0acu5L7m7tG9g.style"), function () {
return ((model.variables.filesListVar.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.filesListVar.isEmpty;
})
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.isEmpty), asPrimitiveValue(model.variables._i_IsEnableInDataFetchStatus), asPrimitiveValue(model.variables.accDataVar.orderAccConceptIDAttr), asPrimitiveValue(model.variables.i_IsEnableIn), asPrimitiveValue(model.variables.creditNoteFilesListVar)]
}))];
}, function () {
return [];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.isOpenPopupForeignerVar,
style: "popup-dialog card width-750px",
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "47"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-main-heading",
text: [$text(getTranslation("ulsHxFse30Kvx2ZMg8SZcw#Value", "Foreigner data"))],
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-auto",
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClosePopupForeigner$Action(false, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*Twotimes*/ 1,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "Inputs"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
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
mandatory: true,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("heCBfJ43lU+Mx8NB719Q8g#Value", "Invoice Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("VUYGQUXAzkavqBw4ru57hA#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.invoiceNumberAttr, function (value) {
model.variables.invoiceForeignVar.invoiceNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name2",
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pDaKQ6YNU0uUdKjDm_rUXg#Value", "Direction"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("LZHENnuq1Ui8bz_HDzL5Rw#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.customerAddressDetectedAttr, function (value) {
model.variables.invoiceForeignVar.customerAddressDetectedAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name2"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name3",
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4BdaG6hyCE6NuCEcf+5V_w#Value", "Social Reason Telcel"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("Za5sj7d8mkC1Vrz+vvybSQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.customerNameDetectedAttr, function (value) {
model.variables.invoiceForeignVar.customerNameDetectedAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name3"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
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
mandatory: true,
targetWidget: "Input_Name10",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("h6eE2gDvv0OybzLSQP+nHA#Value", "RFC Telcel"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("PvR1_LZx5EuvNWsWTd7aJA#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.customerTaxIdDetectedAttr, function (value) {
model.variables.invoiceForeignVar.customerTaxIdDetectedAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name10"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name4",
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Xk5jzgH9gke0XeWGnxkzKA#Value", "Supplier Social Reason"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("oKbJSzV+o0Ge6jhFtt3DzQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.supplierNameAttr, function (value) {
model.variables.invoiceForeignVar.supplierNameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
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
mandatory: true,
targetWidget: "Input_Name9",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pNjl9TOGSEKBHSEhyVv+Tw#Value", "Supplier Tax Id"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("I_HCMQYMp06VWB_wxRa+4w#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.supplierTaxIdAttr, function (value) {
model.variables.invoiceForeignVar.supplierTaxIdAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getSupplierDataAct.isActiveDEV_TK395Out, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "DateFrom"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_DatePicker_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("DatePickerInvoiceDate.OptionalConfigs"), function () {
return function () {
var rec = new ST_bc4abb4233d9ce894e855c520a20c76fStructure();
return rec;
}();
}),
ShowTodayButton: true,
DateFormat: "DD/MM/YYYY"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onSelected$Action: function (datePickerIdIn, selectedDateTimeIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.datePickerInvoiceDate$Action(OS$BuiltinFunctions.dateTimeToDate(selectedDateTimeIn), controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DatePickerInvoiceDate",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
datepicker: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_InvoiceDate",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vG9ecmX2YkS5vVm3b654FQ#Value", "Invoice Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
uuid: "83",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.invoiceForeignVar.invoiceDateAttr === "") || (model.variables.invoiceForeignVar.invoiceDateAttr === OS$BuiltinFunctions.dateToText(OS$BuiltinFunctions.nullDate()))), false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.BlueCalendar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.calendarClearOnClick$Action(controller.callContext(eventHandlerContext));

;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedCalendar.svg"),
style: "cursorpointer",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hGFAqBB6AECvUTsjqJGJRw#ValueExpression.1815858133.1", "Not found"),
style: "form-control cursorpointer",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.invoiceDateAttr, function (value) {
model.variables.invoiceForeignVar.invoiceDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_InvoiceDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.invoiceForeignVar.invoiceDateAttr)]
}))];
}),
placeholder_SSPreview: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.invoiceForeignVar.invoiceDateAttr)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name5",
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8yjtxBiqpUG2ChKjjxTSQw#Value", "Invoice Date"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("9MQc0hD0iE+a1+yDE+6Prw#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.invoiceDateAttr, function (value) {
model.variables.invoiceForeignVar.invoiceDateAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name5"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
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
mandatory: true,
targetWidget: "Input_AmountByServiceType",
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("TzSTqmxlqU+ZcAC7KtxM7Q#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("MHb0lCIKL0SyN8BO27IXgw#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.totalAmountAttr, function (value) {
model.variables.invoiceForeignVar.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_AmountByServiceType"
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
RightAlign: true,
InputId: idService.getId("Input_AmountByServiceType"),
AlwaysShowDecimalDigits: true,
SuffixText: "",
UseNumericInput: true,
GroupSeparator: ",",
DecimalSeparator: ".",
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
uuid: "94",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_Name12",
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4W7tATGDokeypRjgbzFe0Q#Value", "Currency"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("ABJE_Qc30EuVagUQOf5tXQ#ValueExpression.1815858133.1", "Not found"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.invoiceForeignVar.currencyAttr, function (value) {
model.variables.invoiceForeignVar.currencyAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name12"
},
_widgetRecordProvider: widgetsRecordProvider
}))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-xl",
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClosePopupForeigner$Action(false, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-back",
visible: true,
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("s2jTDgOp9EiOTo9TABkIRQ#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: true,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClosePopupForeigner$Action(true, controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("3+f8Qpgaq0mDHD6vfNPkYQ#Value", "Save"))))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_InvoiceSAECUpload",
functionKey: "c54045a2-26d1-4aa7-ba2b-39a584512774",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_InvoiceSAECUpload",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_InvoiceSAECUpload.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_d_Invoices_wb_AccSelect_mvc_view, ConectaProveedores_y_Utils_Wb_AnticipoImport_mvc_view, ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Interaction_DatePicker_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, InputMasks_InputMaskReactFlow_MaskCurrency_mvc_view];
};


return ELEM;
};

export default componentFactory()
